using cndbtest.Models;
using cndbtest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ReactiveUI;
using System.ComponentModel;
using Avalonia;

namespace cndbtest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!°¡";

        private string _stringValue = "Test²âÊÔ";
        public string StringValue
        {
            get { return _stringValue; }
            set { this.RaiseAndSetIfChanged(ref _stringValue, value); }
        }
        public void Running(string msg)
        {
            var message = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("±êÌâ", msg);
            message.Show();
        }

        #region DM
        public async Task DMInsertAsync()
        {
            using (var db = new DMBloggingContext())
            {
                await db.Blogs.AddAsync(new Blog { Url = "http://blogs.msdn.com/adonet", CreateTime = DateTime.Now,Price = 1.2M });
                var count = await db.SaveChangesAsync();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                var temp = string.Empty;
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                    temp += DateTime.Now + JsonConvert.SerializeObject(blog) + "\r";
                }
                StringValue = temp;
            }
        }

        public async Task DMDeleteAsync()
        {
            using (var db = new DMBloggingContext())
            {
                var url = "http://blogs.msdn.com/adonet";
                var blog = await db.Blogs.Where(p => p.Url == url).AsNoTracking().FirstOrDefaultAsync();
                if (blog != null)
                {
                    db.Blogs.Remove(blog);
                    await db.SaveChangesAsync();
                    await DMSelectAsync();
                }
            }
        }

        public async Task DMUpdateAsync()
        {
            using (var db = new DMBloggingContext())
            {
                var url = "http://blogs.msdn.com/adonet";
                var blog = await db.Blogs.Where(p => p.Url == url).AsNoTracking().FirstOrDefaultAsync();
                if(blog != null)
                {
                    blog.Url = "123";
                    db.Blogs.Update(blog);
                    await db.SaveChangesAsync();
                    await DMSelectAsync();
                }
            }
        }

        public async Task DMSelectAsync()
        {
            var temp = string.Empty;
            using (var db = new DMBloggingContext())
            {
                var blog = await db.Blogs.AsNoTracking().ToListAsync();
                foreach(var item in blog)
                {
                    temp += DateTime.Now + JsonConvert.SerializeObject(item) + "\r";
                }
            }
            StringValue = temp;
        }
        #endregion
    }
}
