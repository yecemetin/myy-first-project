using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.API.Native;
using System.Configuration;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;
using System.Drawing;

namespace ExecuteScript
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        DbOperation baglanti = new DbOperation();
        public string IP { get; internal set; }
        public string Port { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }

        const int LEADING_SPACE = 10;
        const int CLOSE_SPACE = 13;
        const int CLOSE_AREA = 13;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        private void simpleButtonExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Dosyası | *.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                GridControl grid = getgrid(tabControl2.SelectedIndex);
                grid.ExportToXlsx(save.FileName);
            }
            if (File.Exists(save.FileName))
                Process.Start(save.FileName);
        }

        public void TabOlustur()
        {
            //TabPage oluşturduk.
            string title = "Result " + (tabControl2.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl2.TabPages.Add(myTabPage);

            //TabPage içine grid oluşturduk.
            GridControl gridControl = new GridControl();
            gridControl.Dock = DockStyle.Fill;
            gridControl.Name = "gridControl";
            gridControl.Location = new System.Drawing.Point(3, 3);
            gridControl.UseEmbeddedNavigator = true;
            gridControl.Size = new System.Drawing.Size(888, 287);
            gridControl.TabIndex = 0;
            DevExpress.XtraGrid.Views.Grid.GridView gridView
                = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.RowAutoHeight = true;
            gridControl.ViewCollection.Add(gridView);
            myTabPage.Controls.Add(gridControl);
        }
        public GridControl getgrid(int i)// i. tabpage de yer alan gridcontrolu geri doner
        {
            foreach (var control in tabControl2.TabPages[i].Controls)
            {
                if (control is GridControl)
                {
                    return (GridControl)control;
                }
            }
            return null;
        }
        public void ComboDoldur()
        {
            DbOperation baglanti = new DbOperation();
            DataTable dt = baglanti.Listele("SHOW DATABASES", IP, Port, UserName, Password, cbDatabase.Text);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow satir in dt.Rows)
                {
                    cbDatabase.Items.Add(satir[0]);
                }
            }
        }
        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DbOperation baglanti = new DbOperation();
            DataTable dt = baglanti.Listele("SHOW TABLES", IP, Port, UserName, Password, cbDatabase.Text);
            if (dt.Rows.Count > 0)
            {
                lbTables.Items.Clear();
                lbFields.Items.Clear();
                foreach (DataRow satir in dt.Rows)
                {
                    lbTables.Items.Add(satir[0]);
                }
            }
            else
            {
                lbTables.Text = "";
            }
        }
        private void simpleButtonRunScript_Click_1(object sender, EventArgs e)
        {
            tabControl2.TabPages.Clear();
            string[] scripts = recSorgular.Text.Trim().Split(';'); //; den sonraki sorguları ayırdık. her sorgu farklı tabpagede görüntülensin diye.

            if (recSorgular.Text != "")
            {
                for (int i = 0; i < scripts.Length; i++)
                {
                    if (scripts[i].Trim() != "")
                    {
                        DbOperation baglanti = new DbOperation();
                        DataTable dt = baglanti.Listele(scripts[i].Trim(), IP, Port, UserName, Password, cbDatabase.Text);
                        if (dt != null && dt.Rows.Count > 0)
                        {

                            TabOlustur();
                            GridControl grid = getgrid(i);
                            grid.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Tablo Boş");
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Script Giriniz");
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                simpleButtonRunScript.PerformClick();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbOperation db = new DbOperation();
            DataTable dt = db.Listele("show columns from " + lbTables.Text, IP, Port, UserName, Password, cbDatabase.Text);
            if (dt.Rows.Count > 0)
            {
                lbFields.Items.Clear();
                lbFields.Items.Add("*");
                foreach (DataRow satir in dt.Rows)
                {                   
                    lbFields.Items.Add(satir[0]);
                }
            }
        }
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString(" X ", e.Font, Brushes.Red, e.Bounds.Right - CLOSE_AREA, e.Bounds.Top + 5);
            e.Graphics.DrawString(this.tabControl2.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + LEADING_SPACE, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if(lbFields.Text != "")
            {
                    recSorgular.Document.AppendText("Select" + " " + lbFields.Text + " " + "From" + " " + lbTables.Text + " ;" + "\n");       
            }   
        }
        private void tabControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl2.TabPages.Remove(tabControl2.SelectedTab);
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tabControl2, lbTables.Text);
            toolTip.IsBalloon = true;
        }

        private void sbKapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
