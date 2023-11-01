namespace CPCD.Repository.Domains.Responses;

public class CreateUserResponse
{
    public string StatusCode { get; set; }
    public bool IsOperationSuccessful { get; set; }
    public string Message { get; set; }
}
