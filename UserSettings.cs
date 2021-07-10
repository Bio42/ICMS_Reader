namespace ICMS_Reader
{
    internal class UserSettings
    {
        public string Username { get; internal set; }
        public string Password { get; internal set; }
        public CallMeDadi.Studys Study { get; internal set; }
        public bool BrowserIsChrome { get; internal set; }
        public string Website { get; internal set; }

        public override string ToString()
        {
            return Username + ";" + Password + ";" + Study + ";" + BrowserIsChrome + ";" + Website;
        }

        public UserSettings (string settings)
        {
            var split = settings.Split(';');
            this.Username = split[0];
            this.Password = split[1];
            if (split[2] == CallMeDadi.Studys.MEC.ToString())
            {
                this.Study = CallMeDadi.Studys.MEC;
            }
            else
            {
                this.Study = CallMeDadi.Studys.EIT;
            }

            this.BrowserIsChrome = split[3] == "True";
            this.Website = split[4];
        }

        public UserSettings (string username, string password, CallMeDadi.Studys study, 
            bool browserIschrome, string website)
        {
            this.Username = username;
            this.Password = password;
            this.Study = study;
            this.BrowserIsChrome = browserIschrome;
            this.Website = website;
        }
    }
}