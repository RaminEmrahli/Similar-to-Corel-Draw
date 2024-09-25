using Datalar;
using Datalar.Enttites;
namespace sdf2hazirliq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Datalar.AppContext context = new Datalar.AppContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sinifler sinif = new Sinifler();
                sinif.Name = txtSinifName.Text;
                sinif.Id = 1;
                GenericRepository<Sinifler> genericRepository = new GenericRepository<Sinifler>(context);
                genericRepository.Add(sinif);
                genericRepository.Save();
                timer1.Start();
            }
            catch (Exception ex)
            {
                ErrorBase error = new ErrorBase();
                error.Logging(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenericRepository<Sinifler> genericRepository = new GenericRepository<Sinifler>(context);
        }

        private void telebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telebeformu telebeformu = new Telebeformu();
            telebeformu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenericRepository<Telebeler> genericRepository = new GenericRepository<Telebeler>(context);
            foreach (var item in genericRepository.GetAll())
            {

            }
        }
    }
}