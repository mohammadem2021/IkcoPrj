namespace IKCOProject.Blazor.Components.Services.Base;

public partial class Client: IClient
{
    public HttpClient HttpClient => _httpClient;
}