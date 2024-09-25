using Datalar;
using Datalar.Enttites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdf2hazirliq
{
    public partial class Telebeformu : Form
    {
        public Telebeformu()
        {
            InitializeComponent();
        }

        Datalar.AppContext context = new Datalar.AppContext();
        private void Telebeformu_Load(object sender, EventArgs e)
        {
            GenericRepository<Sinifler> genericRepository = new GenericRepository<Sinifler>(context);
            GenericRepository<Telebeler> repo = new GenericRepository<Telebeler>(context);
            foreach (var item in genericRepository.GetAll())
            {
                comboBox1.Items.Add(item.Name);
            }

            foreach (var item in repo.GetAll())
            {
                string id=item.Id.ToString();
                string name = item.Name;
                string sinifName = item.Sinif.Name;
                string[] arr = {id,name,sinifName};
                ListViewItem lst = new ListViewItem(arr);
                listView1.Items.Add(lst);
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenericRepository<Sinifler> genericRepository = new GenericRepository<Sinifler>(context);
            List<Sinifler> sinifler = genericRepository.GetAll();
            GenericRepository<Telebeler> repo = new GenericRepository<Telebeler>(context);

            Sinifler sinif = sinifler.Find(x => x.Name == comboBox1.Text);
            Telebeler telebe = new Telebeler();
            telebe.Name = textBox1.Text;
            telebe.SiniflerId = sinif.Id;
            repo.Add(telebe);
            repo.Save();
        }
    }
}
