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
    public partial class FrmGrups : Form
    {
        private readonly UserModel _user;
        public FrmGrups(UserModel user)
        {
            _user = user;
            InitializeComponent();
        }

        Data.ApplicationContext _context = new Data.ApplicationContext();
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            FrmGrupAdd frm = new FrmGrupAdd(timer1);

            frm.ShowDialog();

        }

        public void FillGroups()
        {
            listBoxGrups.Items.Clear();
            GenericRepository<Grup> genericRepository = new GenericRepository<Grup>(_context);
            foreach (var item in genericRepository.GetAll())
            {
                listBoxGrups.Items.Add(item.Name);

            }
        }
        private void FrmGrups_Load(object sender, EventArgs e)
        {
            FillGroups();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillGroups();
            timer1.Stop();

        }

        string GrupName = "";
        private void listBoxGrups_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrupName = listBoxGrups.SelectedItem.ToString();
            FillMessages();
        }

        public void FillMessages()
        {
            listBox2.Items.Clear();
            GenericRepository<Grup> grupRepository = new GenericRepository<Grup>(_context);
            GenericRepository<Data.Entities.Message> messageRepository = new GenericRepository<Data.Entities.Message>(_context);
            List<Grup> grups = grupRepository.GetAll();
            Grup grup = grups.Find(x => x.Name == GrupName);
            List<Data.Entities.Message> messages = messageRepository.GetAll().FindAll(x => x.GrupId == grup.Id);
            foreach (var item in messages)
            {
                listBox2.Items.Add(item.User.Name);
                listBox2.Items.Add(item.MessageText);
            }
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            GenericRepository<Grup> grupRepository = new GenericRepository<Grup>(_context);
            GenericRepository<UserModel> userRepository = new GenericRepository<UserModel>(_context);
            GenericRepository<Data.Entities.Message> messageRepository = new GenericRepository<Data.Entities.Message>(_context);
            List<Grup> grups = grupRepository.GetAll();
            Grup grup = grups.Find(x => x.Name == GrupName);
            Data.Entities.Message message = new Data.Entities.Message();
            message.MessageText = txtMessage.Text;
            message.UserId = _user.Id;
            message.GrupId = grup.Id;
            messageRepository.Add(message);
            messageRepository.Save();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            FillMessages();
            timer2.Stop();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
