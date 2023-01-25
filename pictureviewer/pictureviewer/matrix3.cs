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
    public partial class Matrix3 : Form
    {
        public Matrix3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Main(string[] args)
        {
            Matrix1 obj = new Matrix1();
            Matrix2 obj2 = new Matrix2();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
