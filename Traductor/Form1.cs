using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Traductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            this.button1.Text = translate.hola;
        }
    }
}
