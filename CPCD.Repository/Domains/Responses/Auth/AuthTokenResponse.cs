namespace CPCD.Repository.Domains.Responses;

public class AuthTokenResponse
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public string RememberMeToken { get; set; }
    public long ExpireAt { get; set; }
}
