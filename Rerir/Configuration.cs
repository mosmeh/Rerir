using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Rerir
{
    public static class ConfigStore
    {
        private static readonly string ConfigFile = Application.StartupPath + @"\config.xml";
        private static Config config;

        public static void Load()
        {
            try
            {
                var xmldoc = new XmlDocument()
                {
                    PreserveWhitespace = true
                };
                xmldoc.Load(ConfigFile);
                using (var nr = new XmlNodeReader(xmldoc))
                    config = new XmlSerializer(typeof(Config)).Deserialize(nr) as Config;
            }
            catch
            {
                config = new Config();
            }
        }

        public static void Save()
        {
            using (var sw = new StreamWriter(ConfigFile))
                new XmlSerializer(typeof(Config)).Serialize(sw, config);
        }

        public static void Update(Config updatecfg)
        {
            config = updatecfg;
        }

        /// <summary>
        /// プレビューのデフォルト フォントサイズ
        /// </summary>
        public static int DefaultPreviewFontSize
        {
            get
            {
                return config.DefaultPreviewFontSize;
            }

            set
            {
                config.DefaultPreviewFontSize = value;
            }
        }

        /// <summary>
        /// デフォルト サンプルテキスト
        /// </summary>
        public static string DefaultSampleText
        {
            get
            {
                return config.DefaultSampleText;
            }

            set
            {
                config.DefaultSampleText = value;
            }
        }
    }

    public class Config
    {
        public Config()
        {
            DefaultPreviewFontSize = 12;
            DefaultSampleText = @"あたらしい朝がきた希望の朝だ
喜びに胸を開け青空仰げラジオの声に健やかな胸をこの香る風に開けよ
ABCDEFGHIJKLMNOPQRSTUVWXYZ
abcdefghijklmnopqrstuvwxyz
1234567890-^\!""#$%&'()=~|@[`{;:]+*},./\<>?_";
        }

        /// <summary>
        /// プレビューのデフォルト フォントサイズ
        /// </summary>
        public int DefaultPreviewFontSize { get; set; }

        /// <summary>
        /// デフォルト サンプルテキスト
        /// </summary>
        public string DefaultSampleText { get; set; }
    }
}
