namespace TotpTest.Services.Dtos;

public class TotpTestInput
{
    public string Code { get; set; }
}

public class TotpTestOutput
{
    public string OtpNetCode { get; set; }

    public string InputCode { get; set; }
}