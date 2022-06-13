namespace Chat_App.Models
{
    public class SaltModel
    {
        public SaltModel(string pass, string salt)
        {
            Pass = pass;
            Salt = salt;
        }
        public string Pass { get; set; }
        public string Salt { get; set; }
    }
}
