namespace Blog;

public static class Configuration
{
    //TOKEN - JWT - Json Web Token
    public static string JwtKey = "NjhhZjZjMzAtMGZiNS0xMWVlLWJlNTYtMDI0MmFjMTIwMDAy";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "my_api_MjdlMjQzZjRmYjNmYzRmMWUwODc=";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public static string Domain { get; set; }
}
