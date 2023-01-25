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
    public partial class Matrix2 : Form
    {
        public Matrix2()
        {
            InitializeComponent();
        }
        static int[,] data1 = new int[2, 3];
        private void button1_Click(object sender, EventArgs e)
        {
            
            data1[0, 0] = int.Parse(this.textBox1.Text);
            data1[0, 1] = int.Parse(this.textBox2.Text);
            data1[0, 2] = int.Parse(this.textBox3.Text);
            data1[1, 0] = int.Parse(this.textBox4.Text);
            data1[1, 1] = int.Parse(this.textBox5.Text);
            data1[1, 2] = int.Parse(this.textBox6.Text);

            this.Hide();
            Matrix3 obj = new Matrix3();
            obj.Show();
        }
    }
}
