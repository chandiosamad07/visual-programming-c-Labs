using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureViewer
{
    public partial class Matrix1 : Form
    {
        public Matrix1()
        {
            InitializeComponent();
        }
        static int[,] data = new int[2, 3];
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            data[0, 0] = int.Parse(this.textBox1.Text);
            data[0, 1] = int.Parse(this.textBox2.Text);
            data[0, 2] = int.Parse(this.textBox3.Text);
            data[1, 0] = int.Parse(this.textBox4.Text);
            data[1, 1] = int.Parse(this.textBox5.Text);
            data[1, 2] = int.Parse(this.textBox6.Text);

            this.Hide();
            Matrix2 obj = new Matrix2();
            obj.Show();
        }
    }
}
