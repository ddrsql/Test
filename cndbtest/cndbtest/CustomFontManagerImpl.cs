﻿using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Skia;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cndbtest
{
    public class CustomFontManagerImpl : IFontManagerImpl
    {
        private readonly Typeface[] _customTypefaces;
        private readonly string _defaultFamilyName;

        //Load font resources in the project, you can load multiple font resources
        private readonly Typeface _defaultTypeface =
            new Typeface("resm:cndbtest.Assets.Fonts.msyh#Microsoft YaHei");

        public CustomFontManagerImpl()
        {
            _customTypefaces = new[] { _defaultTypeface };
            _defaultFamilyName = _defaultTypeface.FontFamily.FamilyNames.PrimaryFamilyName;
        }

        /// <summary>
        /// 获取系统的默认字体族名称
        /// </summary>
        /// <returns></returns>
        public string GetDefaultFontFamilyName()
        {
            return _defaultFamilyName;
        }

        /// <summary>
        /// 获取系统中所有已安装的字体
        /// </summary>
        /// <param name="checkForUpdates"></param>
        /// <returns></returns>
        public IEnumerable<string> GetInstalledFontFamilyNames(bool checkForUpdates = false)
        {
            return _customTypefaces.Select(x => x.FontFamily.Name);
        }

        private readonly string[] _bcp47 = { CultureInfo.CurrentCulture.ThreeLetterISOLanguageName, CultureInfo.CurrentCulture.TwoLetterISOLanguageName };

        /// <summary>
        /// 正在尝试将指定的字符与支持指定字体属性的字体相匹配
        /// </summary>
        /// <param name="codepoint"></param>
        /// <param name="fontStyle"></param>
        /// <param name="fontWeight"></param>
        /// <param name="fontFamily"></param>
        /// <param name="culture"></param>
        /// <param name="typeface"></param>
        /// <returns></returns>
        public bool TryMatchCharacter(int codepoint, FontStyle fontStyle, FontWeight fontWeight, FontFamily fontFamily,
            CultureInfo culture, out Typeface typeface)
        {
            foreach (var customTypeface in _customTypefaces)
            {
                if (customTypeface.GlyphTypeface.GetGlyph((uint)codepoint) == 0)
                {
                    continue;
                }

                typeface = new Typeface(customTypeface.FontFamily.Name, fontStyle, fontWeight);

                return true;
            }

            var fallback = SKFontManager.Default.MatchCharacter(fontFamily?.Name, (SKFontStyleWeight)fontWeight,
                SKFontStyleWidth.Normal, (SKFontStyleSlant)fontStyle, _bcp47, codepoint);

            typeface = new Typeface(fallback?.FamilyName ?? _defaultFamilyName, fontStyle, fontWeight);

            return true;
        }

        /// <summary>
        /// 创建字形字体
        /// </summary>
        /// <param name="typeface"></param>
        /// <returns></returns>
        public IGlyphTypefaceImpl CreateGlyphTypeface(Typeface typeface)
        {
            SKTypeface skTypeface;
            switch (typeface.FontFamily.Name)
            {
                case FontFamily.DefaultFontFamilyName:
                case "Microsoft YaHei":  //font family name
                    skTypeface = SKTypeface.FromFamilyName(_defaultTypeface.FontFamily.Name); 
                    break;
                default:
                    skTypeface = SKTypeface.FromFamilyName("Microsoft YaHei",//typeface.FontFamily.Name,
                        (SKFontStyleWeight)typeface.Weight, SKFontStyleWidth.Normal, (SKFontStyleSlant)typeface.Style);
                    break;
            }

            // 解决linux系统下skTypeface是null
            if (skTypeface == null)
            {
                skTypeface = SKTypeface.FromFamilyName(_defaultTypeface.FontFamily.Name);
            }

            //// 如果是centos7之类的使用linux里面的字体
            //if (skTypeface == null)
            //{
            //    skTypeface = SKTypeface.FromFamilyName("WenQuanYi Micro Hei");
            //}

            return new GlyphTypefaceImpl(skTypeface);
        }
    }
}
