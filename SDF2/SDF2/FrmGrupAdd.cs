using Data.Contracts;
using Data.Entities;
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
    public partial class FrmGrupAdd : Form
    {
        private readonly System.Windows.Forms.Timer _timer;
        public FrmGrupAdd(System.Windows.Forms.Timer timer)
        {
            _timer = timer;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        Data.ApplicationContext context = new Data.ApplicationContext();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GenericRepository<Grup> genericRepository = new GenericRepository<Grup>(context);
            Grup grup = new Grup();
            grup.Name = txtGrupName.Text;
            genericRepository.Add(grup);
            genericRepository.Save();
            _timer.Start();
            Close();
        }

        private void FrmGrupAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
