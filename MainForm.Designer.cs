namespace ExecuteScript
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelDb = new System.Windows.Forms.Label();
            this.labelFields = new System.Windows.Forms.Label();
            this.lbFields = new System.Windows.Forms.ListBox();
            this.labelTables = new System.Windows.Forms.Label();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.recSorgular = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.sbKapat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExcel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRunScript = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelDb);
            this.panelControl1.Controls.Add(this.labelFields);
            this.panelControl1.Controls.Add(this.lbFields);
            this.panelControl1.Controls.Add(this.labelTables);
            this.panelControl1.Controls.Add(this.lbTables);
            this.panelControl1.Controls.Add(this.cbDatabase);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(230, 802);
            this.panelControl1.TabIndex = 0;
            // 
            // labelDb
            // 
            this.labelDb.AutoSize = true;
            this.labelDb.BackColor = System.Drawing.Color.OldLace;
            this.labelDb.Location = new System.Drawing.Point(61, 25);
            this.labelDb.Name = "labelDb";
            this.labelDb.Size = new System.Drawing.Size(72, 13);
            this.labelDb.TabIndex = 16;
            this.labelDb.Text = "DATABASES :";
            // 
            // labelFields
            // 
            this.labelFields.AutoSize = true;
            this.labelFields.BackColor = System.Drawing.Color.OldLace;
            this.labelFields.Location = new System.Drawing.Point(24, 461);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(51, 13);
            this.labelFields.TabIndex = 15;
            this.labelFields.Text = "FIELDS : ";
            // 
            // lbFields
            // 
            this.lbFields.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbFields.FormattingEnabled = true;
            this.lbFields.Location = new System.Drawing.Point(24, 487);
            this.lbFields.Name = "lbFields";
            this.lbFields.Size = new System.Drawing.Size(179, 303);
            this.lbFields.TabIndex = 14;
            this.lbFields.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.BackColor = System.Drawing.Color.OldLace;
            this.labelTables.Location = new System.Drawing.Point(25, 114);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(50, 13);
            this.labelTables.TabIndex = 13;
            this.labelTables.Text = "TABLES :";
            // 
            // lbTables
            // 
            this.lbTables.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(27, 139);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(176, 290);
            this.lbTables.TabIndex = 12;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cbDatabase
            // 
            this.cbDatabase.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(48, 52);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(121, 21);
            this.cbDatabase.TabIndex = 11;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.recSorgular);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1095, 219);
            this.panelControl2.TabIndex = 1;
            // 
            // recSorgular
            // 
            this.recSorgular.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recSorgular.Dock = System.Windows.Forms.DockStyle.Top;
            this.recSorgular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recSorgular.Location = new System.Drawing.Point(2, 2);
            this.recSorgular.Name = "recSorgular";
            this.recSorgular.Overtype = true;
            this.recSorgular.Size = new System.Drawing.Size(1091, 217);
            this.recSorgular.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(230, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1099, 802);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.tabControl2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 221);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1095, 507);
            this.panelControl4.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Location = new System.Drawing.Point(2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(12, 4);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1091, 503);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl2_DrawItem);
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            this.tabControl2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl2_MouseDoubleClick);
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.sbKapat);
            this.panelControl5.Controls.Add(this.simpleButtonExcel);
            this.panelControl5.Controls.Add(this.simpleButtonRunScript);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(2, 728);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1095, 72);
            this.panelControl5.TabIndex = 3;
            // 
            // sbKapat
            // 
            this.sbKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbKapat.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.sbKapat.Appearance.Options.UseFont = true;
            this.sbKapat.Appearance.Options.UseForeColor = true;
            this.sbKapat.Location = new System.Drawing.Point(824, 14);
            this.sbKapat.Name = "sbKapat";
            this.sbKapat.Size = new System.Drawing.Size(247, 48);
            this.sbKapat.TabIndex = 3;
            this.sbKapat.Text = "KAPAT";
            this.sbKapat.Click += new System.EventHandler(this.sbKapat_Click);
            // 
            // simpleButtonExcel
            // 
            this.simpleButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonExcel.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.simpleButtonExcel.Appearance.Options.UseFont = true;
            this.simpleButtonExcel.Appearance.Options.UseForeColor = true;
            this.simpleButtonExcel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExcel.Image")));
            this.simpleButtonExcel.Location = new System.Drawing.Point(585, 14);
            this.simpleButtonExcel.Name = "simpleButtonExcel";
            this.simpleButtonExcel.Size = new System.Drawing.Size(232, 50);
            this.simpleButtonExcel.TabIndex = 2;
            this.simpleButtonExcel.Text = "EXCEL\'E AKTARMA";
            this.simpleButtonExcel.Click += new System.EventHandler(this.simpleButtonExcel_Click);
            // 
            // simpleButtonRunScript
            // 
            this.simpleButtonRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonRunScript.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonRunScript.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.simpleButtonRunScript.Appearance.Options.UseFont = true;
            this.simpleButtonRunScript.Appearance.Options.UseForeColor = true;
            this.simpleButtonRunScript.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonRunScript.Image")));
            this.simpleButtonRunScript.Location = new System.Drawing.Point(331, 14);
            this.simpleButtonRunScript.Name = "simpleButtonRunScript";
            this.simpleButtonRunScript.Size = new System.Drawing.Size(237, 49);
            this.simpleButtonRunScript.TabIndex = 1;
            this.simpleButtonRunScript.Text = "RUN SCRİPT";
            this.simpleButtonRunScript.Click += new System.EventHandler(this.simpleButtonRunScript_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 802);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
       
        private DevExpress.XtraRichEdit.RichEditControl recSorgular;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExcel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRunScript;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label labelFields;
        private System.Windows.Forms.ListBox lbFields;
        private System.Windows.Forms.Label labelTables;
        private DevExpress.XtraEditors.SimpleButton sbKapat;
        private System.Windows.Forms.Label labelDb;
    }
}