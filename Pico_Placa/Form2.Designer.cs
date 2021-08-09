
namespace Pico_Placa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.infolbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLinkedinlbl = new System.Windows.Forms.LinkLabel();
            this.pictureJavi = new System.Windows.Forms.PictureBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJavi)).BeginInit();
            this.SuspendLayout();
            // 
            // infolbl
            // 
            resources.ApplyResources(this.infolbl, "infolbl");
            this.infolbl.Name = "infolbl";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLinkedinlbl);
            this.panel1.Controls.Add(this.pictureJavi);
            this.panel1.Controls.Add(this.infolbl);
            this.panel1.Controls.Add(this.datelbl);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // linkLinkedinlbl
            // 
            resources.ApplyResources(this.linkLinkedinlbl, "linkLinkedinlbl");
            this.linkLinkedinlbl.Name = "linkLinkedinlbl";
            this.linkLinkedinlbl.TabStop = true;
            this.linkLinkedinlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureJavi
            // 
            this.pictureJavi.Image = global::Pico_Placa.Properties.Resources.Javier;
            resources.ApplyResources(this.pictureJavi, "pictureJavi");
            this.pictureJavi.Name = "pictureJavi";
            this.pictureJavi.TabStop = false;
            // 
            // datelbl
            // 
            resources.ApplyResources(this.datelbl, "datelbl");
            this.datelbl.Name = "datelbl";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureJavi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureJavi;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.LinkLabel linkLinkedinlbl;
    }
}