using KenanNIhat.Data;
using KenanNIhat.Data.Interfaces;
using AppContext = KenanNIhat.Data.AppContext;

namespace KenanNihat
{
    public partial class Form1 : Form
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IStudentRepository _studentRepository;
        public Form1(IGroupRepository groupRepository, IStudentRepository studentRepository)
        {
            _groupRepository = groupRepository;
            _studentRepository = studentRepository;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Name = txtName.Text;
            _groupRepository.Add(group);
            _groupRepository.Save();
            FillGroups();
        }

        private void telebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelebeAdd telebeAdd = new TelebeAdd(_groupRepository, _studentRepository);
            telebeAdd.ShowDialog();
        }

        public void FillGroups()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var student in _groupRepository.GetAll())
            {
                var sc = new TelebeCard();
                sc.Name = student.Name;
                sc.img = @"C:\Users\Ramin\OneDrive\Masaüstü\Adsýz.png";
                sc.Visible = true;
                flowLayoutPanel1.Controls.Add(sc);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillGroups();
        }
    }
}