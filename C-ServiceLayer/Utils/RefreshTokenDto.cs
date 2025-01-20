namespace C_ServiceLayer.Utils;

public class RefreshTokenDto
{
    public string AccessToken { get; set; }  = null!;
    public string RefreshToken { get; set; } = null!;
    
}