using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace BlossomSaves
{
    [Serializable]
    class BlossomConfig
    {
        public string OriginalSaveDirectory;
        public string ManagedSaveDirectory;


        private static readonly string _configDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string _configFileName = "config.json";
        private static readonly string _configFile = Path.Combine(_configDirectory, _configFileName);
        private static readonly string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string _saveDirectory = Path.Combine(_configDirectory, "SaveData");
        private static BlossomConfig _blossomConfig;

        private BlossomConfig() {}

        public static BlossomConfig GetBlossomConfig()
        {
            if (_blossomConfig == null)
            {
                _blossomConfig = new BlossomConfig();
                LoadConfig();
            }

            return _blossomConfig;
        }


        public static void SaveConfig(BlossomConfig config)
        {
            if (config == null) return;

            var configText = JsonConvert.SerializeObject(config);
            try
            {
                File.WriteAllText(_configFile, configText);
            }
            catch (Exception) { }
        }

        public static void LoadConfig()
        {
            if (File.Exists(_configFile))
            {
                string configText = string.Empty;
                try
                {
                    configText = File.ReadAllText(_configFile);
                }
                catch { }
                _blossomConfig = JsonConvert.DeserializeObject<BlossomConfig>(configText);
            }
            else
            {
                _blossomConfig = new BlossomConfig()
                {

                    OriginalSaveDirectory = Path.Combine(_appDataPath, "Blossom Tales"),
                    ManagedSaveDirectory = _saveDirectory
                };
            }
        }

        public static bool BlossomConfigExists()
        {
            return File.Exists(_configFile);
        }
    }
}
