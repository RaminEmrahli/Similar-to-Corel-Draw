using Data;
using Data.Contracts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace SDF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Data.ApplicationContext _context = new Data.ApplicationContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                GenericRepository<UserModel> genericRepository = new GenericRepository<UserModel>(_context);
                UserModel user = new UserModel();
                user.Name = txtUserName.Text;
                genericRepository.Add(user);
                genericRepository.Save();
                FrmGrups frm = new FrmGrups(user);
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                ErrorModel err = new ErrorModel();
                err.Logging(ex.Message);
                throw;
            }
        }
    }
}