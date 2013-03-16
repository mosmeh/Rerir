using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Rerir
{
    public class FontEnclosure
    {
        string filename;
        FontFamily ffamily;

        public FontEnclosure(string path)
        {
            filename = path;
            using (var fontcln = new PrivateFontCollection())
            {
                fontcln.AddFontFile(path);
                ffamily = fontcln.Families[0];
            }
        }

        public FontEnclosure(FontFamily fontfamily)
        {
            ffamily = fontfamily;
        }

        private IEnumerable<FontStyle> GetSupportedStyles()
        {
            return Enum.GetValues(typeof(FontStyle))
                .OfType<FontStyle>()
                .Where(x => ffamily.IsStyleAvailable(x));
        }

        public Font GetFont()
        {
            return new Font(ffamily, ConfigStore.DefaultPreviewFontSize, GetSupportedStyles().First());
        }

        public Font GetFont(float fontsize)
        {
            return new Font(ffamily, fontsize, GetSupportedStyles().First());
        }

        public FontInfo GetFontInfo()
        {
            FontStyle style = GetSupportedStyles().First();
            double emheight = (double)ffamily.GetEmHeight(style);

            var supported = new List<string>();
            GetSupportedStyles().ToList().ForEach(x => supported.Add(x.ToJapanese()));

            return new FontInfo()
            {
                Name = ffamily.Name,
                FileName = filename,
                Height = (double)ffamily.GetLineSpacing(style) / emheight,
                Ascent = (double)ffamily.GetCellAscent(style) / emheight,
                Descent = (double)ffamily.GetCellDescent(style) / emheight,
                SupportedStyles = string.Join(",", supported)
            };
        }

        public void Install()
        {
            new Shell32.ShellClass()
                .NameSpace(Environment.GetFolderPath(Environment.SpecialFolder.Fonts))
                .CopyHere(filename);
        }
    }

    public static class FontStore
    {
        private static List<FontEnclosure> enclosures = new List<FontEnclosure>();

        public static void Add(FontEnclosure fontecr)
        {
            enclosures.Add(fontecr);
        }

        public static FontEnclosure GetEnclosureByFamilyName(string familyname)
        {
            return enclosures.Where(x => x.GetFont().FontFamily.Name == familyname).First();
        }

        public static List<FontEnclosure> GetFontEnclosures()
        {
            return enclosures;
        }
    }

    public static class FontFileChecker
    {
        public static bool IsValidFontFile(string path)
        {
            using (var fontcln = new PrivateFontCollection())
            {
                try
                {
                    fontcln.AddFontFile(path);
                    return true;
                }
                catch (System.IO.FileNotFoundException)
                {
                    return false;
                }
            }
        }
    }

    public static class FontStyleExt
    {
        public static string ToJapanese(this FontStyle value)
        {
            switch (value)
            {
                case FontStyle.Regular:
                    return "標準";
                case FontStyle.Bold:
                    return "太字";
                case FontStyle.Italic:
                    return "斜体";
                case FontStyle.Strikeout:
                    return "打ち消し線";
                case FontStyle.Underline:
                    return "下線";
            }
            return null;
        }
    }

    [ReadOnly(true)]
    public class FontInfo
    {
        [DisplayName("フォント名")]
        public string Name { get; set; }

        [DisplayName("ファイル名")]
        public string FileName { get; set; }

        [TypeConverter(typeof(PercentageTypeConverter))]
        [DisplayName("行間")]
        public double Height { get; set; }

        [TypeConverter(typeof(PercentageTypeConverter))]
        [DisplayName("アセント")]
        public double Ascent { get; set; }

        [TypeConverter(typeof(PercentageTypeConverter))]
        [DisplayName("ディセント")]
        public double Descent { get; set; }

        [DisplayName("サポートされているスタイル")]
        public string SupportedStyles { get; set; }
    }
}
