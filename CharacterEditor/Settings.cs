using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterEditor
{
    public class CharSettings : ConfigurationSection
    {
        private static CharSettings mSettings = ConfigurationManager.GetSection("Settings") as CharSettings;

        public static CharSettings Settings 
        { 
            get { return mSettings; } 
        }

        public CharSettings()
        {
            DirectoryInfo xmlDir = new DirectoryInfo(this.XmlRootDir);
            if (!xmlDir.Exists)
            {
                xmlDir.Create();
            }
        }

        [ConfigurationProperty("xmlRootDir",
            IsRequired = true)]
        public string XmlRootDir
        {
            get { return (string)this["xmlRootDir"]; }
            set { this["xmlRootDir"] = value; }
        }



    }
}
