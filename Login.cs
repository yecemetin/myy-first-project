using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace ExecuteScript
{
    public partial class Login : Form
    {
        MainForm MainForm = new MainForm();
        DbOperation baglanti = new DbOperation();
        iniOlustur ini = new iniOlustur("D:\\Ayarlar.ini");   
        public Login()
        {
            InitializeComponent();
        }
        iniOlustur INI = new iniOlustur(Application.StartupPath + @"\\Ayarlar.ini");
        private void IniYaz()
        {         
            INI.IniYaz("Bilgiler", "IP", textBoxIP.Text);
            INI.IniYaz("Bilgiler", "Port", textBoxPort.Text);
            INI.IniYaz("Bilgiler", "Username", textBoxUser.Text);
            INI.IniYaz("Bilgiler", "Password", textBoxPass.Text);
        }
        private void IniOku()
        {
           try
            {
                if (File.Exists(Application.StartupPath + @"\\Ayarlar.ini"))
                {                   
                    textBoxIP.Text = INI.IniOku("Bilgiler", "IP");
                    textBoxPort.Text = INI.IniOku("Bilgiler", "Port");
                    textBoxUser.Text = INI.IniOku("Bilgiler", "Username");
                    textBoxPass.Text = INI.IniOku("Bilgiler", "Password");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hataa" + hata.Message);
            }
        }     
        private void Login_Load(object sender, EventArgs e)
        {   
            IniOku();
        }
        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=" + textBoxIP.Text + ";port=" + textBoxPort.Text + ";user id=" + textBoxUser.Text + ";password=" + textBoxPass.Text + ";persistsecurityinfo=True;");
            try
            {
                conn.Open();
                IniYaz();

                MainForm.IP = textBoxIP.Text;
                MainForm.Port = textBoxPort.Text;
                MainForm.UserName = textBoxUser.Text;
                MainForm.Password = textBoxPass.Text;
                MainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Başarısız. Tekrar Deneyiniz..");
            }
            conn.Close();    
        }
    }
}
