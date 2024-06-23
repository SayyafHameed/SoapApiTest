using MyBankTests.Settings.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankTests.Settings
{
    public static class ProjectEnvSettings
    {
        private static EnvConfig _envConfig;
        public static EnvConfig EnvConfig => _envConfig ?? (_envConfig = Initialize());

        private static EnvConfig Initialize()
        {
            // Get the location of the JSON file
            var filePath = "E:\\say\\SoapApiTest\\MyBankTests\\Settings\\EnvSettings.json";
            var jsonString = File.ReadAllText(filePath);

            // Deserialize the JSON into our model
            var config = JsonConvert.DeserializeObject<EnvConfig>(jsonString);

            // return the model
            return config;
        }
    }
}
