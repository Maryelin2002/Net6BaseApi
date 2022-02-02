namespace Net6BaseApi.Core.Settings
{
    public class EmailSettings
    {
        public string? From { get; set; }
        public string? FriendlyName { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int? Port { get; set; }
        public bool? UseSSL { get; set; }
    }
}
