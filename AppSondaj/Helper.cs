using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppSondaj
{
    public static class Helper
    {
        // Getting the configuration string from the configuration Manager
        public static string dbConn(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        // Getting the theme
        public static string getTheme()
        {
            return ConfigurationManager.AppSettings["Theme"];
        }

        // Changing the theme value
        public static void changeTheme(string theme)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Theme"].Value = theme;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
