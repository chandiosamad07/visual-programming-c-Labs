using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btnDemo.Top = this.btnDemo.Top + 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.btnDemo.Left = this.btnDemo.Left + 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.btnDemo.Left = this.btnDemo.Left - 10;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.btnDemo.Top = this.btnDemo.Top - 10;
        }
    }
}
