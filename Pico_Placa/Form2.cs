using System.Diagnostics;
using System.Windows.Forms;

namespace Pico_Placa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.linkedin.com/in/javierzunigas");
        }
    }
}
