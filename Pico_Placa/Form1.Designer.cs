
namespace Pico_Placa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitbtn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.holidaylbl = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.platetxt = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.platelbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timelbl = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.DateTimePicker();
            this.panelcolor = new System.Windows.Forms.Panel();
            this.allowedlbl = new System.Windows.Forms.Label();
            this.paneltext = new System.Windows.Forms.Panel();
            this.infolbl = new System.Windows.Forms.Label();
            this.notallowedlbl = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxQuito = new System.Windows.Forms.PictureBox();
            this.pictureBoxPicoPlaca = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelcolor.SuspendLayout();
            this.paneltext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicoPlaca)).BeginInit();
            this.SuspendLayout();
            // 
            // hour
            // 
            resources.ApplyResources(this.hour, "hour");
            this.hour.Name = "hour";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timetxt);
            this.panel1.Controls.Add(this.timelbl);
            this.panel1.Controls.Add(this.submitbtn);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.holidaylbl);
            this.panel1.Controls.Add(this.datetxt);
            this.panel1.Controls.Add(this.platetxt);
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.platelbl);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // submitbtn
            // 
            resources.ApplyResources(this.submitbtn, "submitbtn");
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.DropDownWidth = 400;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            resources.GetString("comboBoxType.Items"),
            resources.GetString("comboBoxType.Items1"),
            resources.GetString("comboBoxType.Items2"),
            resources.GetString("comboBoxType.Items3"),
            resources.GetString("comboBoxType.Items4"),
            resources.GetString("comboBoxType.Items5"),
            resources.GetString("comboBoxType.Items6"),
            resources.GetString("comboBoxType.Items7")});
            resources.ApplyResources(this.comboBoxType, "comboBoxType");
            this.comboBoxType.Name = "comboBoxType";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // holidaylbl
            // 
            resources.ApplyResources(this.holidaylbl, "holidaylbl");
            this.holidaylbl.Name = "holidaylbl";
            // 
            // datetxt
            // 
            resources.ApplyResources(this.datetxt, "datetxt");
            this.datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetxt.Name = "datetxt";
            this.datetxt.Value = new System.DateTime(2021, 8, 8, 0, 0, 0, 0);
            // 
            // platetxt
            // 
            resources.ApplyResources(this.platetxt, "platetxt");
            this.platetxt.Name = "platetxt";
            this.platetxt.Tag = "";
            this.platetxt.TextChanged += new System.EventHandler(this.platetxt_TextChanged);
            // 
            // datelbl
            // 
            resources.ApplyResources(this.datelbl, "datelbl");
            this.datelbl.Name = "datelbl";
            // 
            // platelbl
            // 
            resources.ApplyResources(this.platelbl, "platelbl");
            this.platelbl.Name = "platelbl";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoToolTip = true;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBoxQuito);
            this.panel2.Controls.Add(this.pictureBoxPicoPlaca);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.hour);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelcolor);
            this.panel3.Controls.Add(this.paneltext);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // timelbl
            // 
            resources.ApplyResources(this.timelbl, "timelbl");
            this.timelbl.Name = "timelbl";
            // 
            // timetxt
            // 
            resources.ApplyResources(this.timetxt, "timetxt");
            this.timetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timetxt.Name = "timetxt";
            this.timetxt.ShowUpDown = true;
            this.timetxt.Value = new System.DateTime(2021, 8, 8, 10, 50, 0, 0);
            // 
            // panelcolor
            // 
            this.panelcolor.Controls.Add(this.notallowedlbl);
            this.panelcolor.Controls.Add(this.allowedlbl);
            resources.ApplyResources(this.panelcolor, "panelcolor");
            this.panelcolor.Name = "panelcolor";
            // 
            // allowedlbl
            // 
            resources.ApplyResources(this.allowedlbl, "allowedlbl");
            this.allowedlbl.Name = "allowedlbl";
            // 
            // paneltext
            // 
            this.paneltext.Controls.Add(this.infolbl);
            resources.ApplyResources(this.paneltext, "paneltext");
            this.paneltext.Name = "paneltext";
            // 
            // infolbl
            // 
            resources.ApplyResources(this.infolbl, "infolbl");
            this.infolbl.Name = "infolbl";
            // 
            // notallowedlbl
            // 
            resources.ApplyResources(this.notallowedlbl, "notallowedlbl");
            this.notallowedlbl.Name = "notallowedlbl";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AutoToolTip = true;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBoxQuito
            // 
            this.pictureBoxQuito.Image = global::Pico_Placa.Properties.Resources.Logo_Quito;
            resources.ApplyResources(this.pictureBoxQuito, "pictureBoxQuito");
            this.pictureBoxQuito.Name = "pictureBoxQuito";
            this.pictureBoxQuito.TabStop = false;
            // 
            // pictureBoxPicoPlaca
            // 
            this.pictureBoxPicoPlaca.Image = global::Pico_Placa.Properties.Resources.Pico_placa_horario;
            resources.ApplyResources(this.pictureBoxPicoPlaca, "pictureBoxPicoPlaca");
            this.pictureBoxPicoPlaca.Name = "pictureBoxPicoPlaca";
            this.pictureBoxPicoPlaca.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelcolor.ResumeLayout(false);
            this.panelcolor.PerformLayout();
            this.paneltext.ResumeLayout(false);
            this.paneltext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicoPlaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label platelbl;
        private System.Windows.Forms.TextBox platetxt;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label holidaylbl;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBoxQuito;
        private System.Windows.Forms.PictureBox pictureBoxPicoPlaca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.DateTimePicker timetxt;
        private System.Windows.Forms.Panel panelcolor;
        private System.Windows.Forms.Label allowedlbl;
        private System.Windows.Forms.Panel paneltext;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label notallowedlbl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

