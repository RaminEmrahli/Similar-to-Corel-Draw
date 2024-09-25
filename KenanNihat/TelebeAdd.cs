using KenanNIhat.Data;
using KenanNIhat.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using AppContext = KenanNIhat.Data.AppContext;


namespace KenanNihat
{
    public partial class TelebeAdd : Form
    {
        private readonly IGroupRepository _groupRepisotry;
        private readonly IStudentRepository _studentRepisotry;
        public TelebeAdd(IGroupRepository groupRepository, IStudentRepository studentRepisotry)
        {
            _groupRepisotry = groupRepository;
            _studentRepisotry = studentRepisotry;
            InitializeComponent();

        }

        ErrorsRepository errorsRepository=new ErrorsRepository();
        private void btnTelebeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Students student = new Students();
                List<KenanNIhat.Data.Group> groups = _groupRepisotry.GetAll();
                KenanNIhat.Data.Group group = groups.Find(x => x.Name == comboBox1.Text);
                student.GroupId = group.Id;
                student.Name = txttelebename.Text;
                _studentRepisotry.Add(student);
                _studentRepisotry.Save();
                FillTelebeler();
            }
            catch (Exception ex)
            {
                errorsRepository.Logging(ex.Message);
            }
        }

        public void FillTelebeler()
        {
            listViewTelebeler.Items.Clear();
            List<KenanNIhat.Data.Group> groups = _groupRepisotry.GetAll();
            foreach (var group in groups)
            {
                comboBox1.Items.Add(group.Name);
            }
            List<Students> students = _studentRepisotry.GetAll();
            foreach (var student in students)
            {
                string id = student.Id.ToString();
                string name = student.Name;
                string groupName = student.Group.Name;
                string[] telebeler = {id,name, groupName};
                ListViewItem listViewItem = new ListViewItem(telebeler);
                listViewTelebeler.Items.Add(listViewItem);
            }
        }
        private void TelebeAdd_Load(object sender, EventArgs e)
        {
            try
            {
                FillTelebeler();
            }
            catch (Exception ex)
            {
                errorsRepository.Logging(ex.Message);
            }
        }
    }
}
