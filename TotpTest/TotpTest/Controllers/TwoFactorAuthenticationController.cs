using Asp.Versioning;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtpNet;
using System.Text;
using System.Text.Encodings.Web;
using TotpTest.Services.Dtos;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;
using IdentityUser = Volo.Abp.Identity.IdentityUser;

namespace TotpTest.Controllers;

//[ControllerName("TwoFactorAuthentication")]
[Route("/api/twofactor")]
public class TwoFactorAuthenticationController : AbpController
{
    private readonly IdentityUserManager _userManager;
    private readonly UrlEncoder _urlEncoder;
    private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";

    public TwoFactorAuthenticationController(IdentityUserManager userManager, UrlEncoder urlEncoder)
    {
        _userManager = userManager;
        _urlEncoder = urlEncoder;
    }

    [HttpPost]
    [Route("enable")]
    public virtual async Task<EnableAuthenticatorOutput> EnableAuthenticatorAsync()
    {
        var result = new EnableAuthenticatorOutput();

        var user = await _userManager.GetUserAsync(User);
        await LoadSharedKeyAndQrCodeUriAsync(user, result);

        
        result.Test = DateTime.Now.ToString();
        return await Task.FromResult(result);
        //return ProfileAppService.ChangePasswordAsync(input);
    }

    [HttpPost]
    [Route("TotpTest")]
    public virtual async Task<TotpTestOutput> TotpTestAsync(TotpTestInput input)
    {
        var user = await _userManager.GetUserAsync(User);
        var authenticatorKey = await _userManager.GetAuthenticatorKeyAsync(user!);
        var secretKey = Base32Encoding.ToBytes(authenticatorKey);
        var totp = new Totp(secretKey);
        var totpCode = totp.ComputeTotp(DateTime.UtcNow);
        long timeWindowUsed = 0;
        var isValid = totp.VerifyTotp(totpCode, out timeWindowUsed);

        var inputIsValid = totp.VerifyTotp(input.Code, out timeWindowUsed);

        var result = new TotpTestOutput();
        result.OtpNetCode = $"OtpNetCode {totpCode} 验证结果:{isValid}";
        result.InputCode = $"InputCode {input.Code} 验证结果:{inputIsValid}";
        return result;
    }

    private async Task LoadSharedKeyAndQrCodeUriAsync(IdentityUser user, EnableAuthenticatorOutput result)
    {
        // Load the authenticator key & QR code URI to display on the form
        var unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
        if (string.IsNullOrEmpty(unformattedKey))
        {
            await _userManager.ResetAuthenticatorKeyAsync(user);
            unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
        }

        result.SharedKey = FormatKey(unformattedKey);

        var email = await _userManager.GetEmailAsync(user);
        result.AuthenticatorUri = GenerateQrCodeUri(email, unformattedKey);
    }

    private string GenerateQrCodeUri(string email, string unformattedKey)
    {
        return string.Format(
        AuthenticatorUriFormat,
            _urlEncoder.Encode("IdentityStandaloneUserCheck"),
            _urlEncoder.Encode(email),
            unformattedKey);
    }

    private string FormatKey(string unformattedKey)
    {
        var result = new StringBuilder();
        int currentPosition = 0;
        while (currentPosition + 4 < unformattedKey.Length)
        {
            result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
            currentPosition += 4;
        }
        if (currentPosition < unformattedKey.Length)
        {
            result.Append(unformattedKey.Substring(currentPosition));
        }

        return result.ToString().ToLowerInvariant();
    }
}
