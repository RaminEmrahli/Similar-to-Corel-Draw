using ShoppingData.Contracts;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class FrmContactUs : Form
    {
        private readonly IContactUsRepository _contactUsRepository;
        public FrmContactUs(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
            InitializeComponent();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="" || txtName.Text == "" || txtPhone.Text == "" || richTxtMessage.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa bütün məlumatları doldurun");
            }
            else
            {
                ContactUs contact = new ContactUs();
                contact.Email = txtEmail.Text;
                contact.Name = txtName.Text;
                contact.PhoneNumber = txtPhone.Text;
                contact.Message = richTxtMessage.Text;
                _contactUsRepository.Add(contact);
                _contactUsRepository.Save();
                this.Close();
            }
        }
    }
}
