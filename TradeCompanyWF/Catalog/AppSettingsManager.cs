using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TradeCompanyWF.Catalog
{
    class AppSettingsManager
    {
            private AppSettings _settings;
            private readonly string _fileName = "settings.json";
            private readonly string _filePath = Application.LocalUserAppDataPath;

            public AppSettingsManager()
            {
                LoadSettingsFromFile();
            }

            private void LoadSettingsFromFile()
            {
                if (Directory.Exists(Application.LocalUserAppDataPath))
                {
                    Directory.CreateDirectory(Application.LocalUserAppDataPath);
                }

                string path = Path.Combine(Application.LocalUserAppDataPath, _fileName);
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }

                string contents = File.ReadAllText(path);
                AppSettings fromFile = JsonConvert.DeserializeObject<AppSettings>(contents);
                if (fromFile != null)
                {
                    _settings = fromFile;
                }
            }

            public void SaveSetting(string propertyName, object value)
            {
                PropertyInfo property = _settings.GetType().GetType().GetProperty(propertyName);
                if (property.GetValue(_settings) != value)
                {
                    //   property.SetValue(_settings.Value);
                    //   UpdateFile();
                    throw new NotImplementedException();
                }
            }

            private void UpdateFile()
            {
                //string json = JsonSerializeObject(_settings);
                //File.WriteAllText(..);
                throw new NotImplementedException();
            }
        }
}
