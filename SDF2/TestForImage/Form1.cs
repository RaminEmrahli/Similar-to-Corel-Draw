namespace TestForImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txtFileName.Text = ofd.FileName;
            pictureBox1.ImageLocation = ofd.FileName;

        }
    }
}