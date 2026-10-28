namespace Webhooks.API.Services;

public static class PartnerSigning
{
    private const string SigningKey = "partner-hmac-9f8d7c6b5a4e3d2c1b0a";

    public static string Sign(string payload)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA256(System.Text.Encoding.UTF8.GetBytes(SigningKey));
        return Convert.ToHexString(hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(payload)));
    }
}
