using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ExecuteScript
{
    class iniOlustur
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public iniOlustur(string dosyaYolu)
        {
            DosyaYolu = dosyaYolu;
        }
        private string DosyaYolu = String.Empty;
        public string Varsayilan { get; set; }
        public string IniOku(string bolum, string anahtar)
        {
            Varsayilan = Varsayilan ?? String.Empty;
            StringBuilder builder = new StringBuilder(256);
            GetPrivateProfileString(bolum, anahtar, Varsayilan, builder, 255, DosyaYolu);
            return builder.ToString();
        }
        public long IniYaz(string bolum, string anahtar, string deger)
        {     
            return WritePrivateProfileString(bolum, anahtar, deger, DosyaYolu);
        }
    }
}
