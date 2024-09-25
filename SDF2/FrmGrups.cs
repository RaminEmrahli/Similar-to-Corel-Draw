using Data.Contracts;
using Data.Entities;
using Data.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDF2
{
    public partial class FrmGrups : Form
    {

        public FrmGrups()
        {
            InitializeComponent();
        }

        Data.ApplicationContext context=new Data.ApplicationContext();  
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FrmGrupAdd frm = new FrmGrupAdd();
            frm.ShowDialog();
        }

        private void FrmGrups_Load(object sender, EventArgs e)
        {
            GenericRepository<Grup> genericRepository = new GenericRepository<Grup>(context);
            foreach (var item in genericRepository.GetAll())
            {
                listBox1.Items.Add(item);
            }
            
        }
    }
}
