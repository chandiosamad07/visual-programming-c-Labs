namespace pictureViewer
{
    public partial class Form1 : Form
    {
        int count = 2;
        string path = @"C:\Users\Captain Jack Sparrow\Desktop\";
        string[] array = { "1.jpg", "2.jpg", "3.jpg" };
        public Form1()
        {
        
            
            InitializeComponent();

            this.pictureBox1.ImageLocation = @"C:\Users\Captain Jack Sparrow\Desktop\1.jpg";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (count <= 3)
            {

                this.pictureBox1.ImageLocation = path + count + ".jpg";
                count++;
            }
            else
            {
                count = 1;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (count > 0 && count <= 3)
            {
                this.pictureBox1.ImageLocation = path + count + ".jpg";
                count--;
            }
            else if (count == 0)
            {
                count = array.Length;
            }

            else
            {
                count = 1;
            }
        }
    }
}