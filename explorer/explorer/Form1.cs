using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMyComp();
            AddDriversToComp();
            tVDriveAndFolders.Nodes[0].Expand();
        }
        private void AddMyComp()
        {
            TreeNode root = new TreeNode("MyComp");
            root.ImageKey = "MyComp";
            root.Name = "MyComp";
            tVDriveAndFolders.Nodes.Add(root);
        }
        private void AddDriversToComp()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode nodeDrive = new TreeNode(drive.Name);
                nodeDrive.Name = drive.Name;
                nodeDrive.ImageIndex = 2;
                nodeDrive.SelectedImageIndex = 2;
                tVDriveAndFolders.Nodes["MyComp"].Nodes.Add(nodeDrive);
            }
        }

        private void tVDriveAndFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lVFolders.Items.Clear();
            textBox1.Text = "";
            textBox1.Text += e.Node.Name;
            string driverName = e.Node.Name;
            string[] folders = Directory.GetDirectories(driverName);
            foreach (string folder in folders)
            {
                DateTime changedTime = Directory.GetLastAccessTime(folder);
                string typeFolder = "File folder";
                float sizeFolder = folder.Length;
                string[] columnArray = new string[4];
                columnArray[0] = folder;
                columnArray[1] = changedTime.ToString();
                columnArray[2] = typeFolder;
                columnArray[3] = sizeFolder.ToString() + "KB";
                ListViewItem item = new ListViewItem(columnArray,1);
                lVFolders.Items.Add(item);
            }

            string[] files = Directory.GetFiles(driverName);
            foreach (string file in files)
            {
                // Icon iconForFile = Icon.ExtractAssociatedIcon(file);
                //imageList1.Images.Add(iconForFile);
                DateTime changedTime = Directory.GetLastAccessTime(file);
                string typeFolder = "File folder";
                float sizeFolder = file.Length;
                string[] columnArray = new string[4];
                columnArray[0] = file;
                columnArray[1] = changedTime.ToString();
                columnArray[2] = typeFolder;
                columnArray[3] = sizeFolder.ToString() + "KB";
                ListViewItem item = new ListViewItem(columnArray, 3);
                lVFolders.Items.Add(file);
            }
        }
        
        string fileName = "";
        private void lVFolders_DoubleClick(object sender, EventArgs e)
        {
            if (fileName.Length <= 3)
            {
                string[] files = Directory.GetFileSystemEntries(fileName);
                foreach (string folder in files)
                {
                    if (!folder.Contains("."))
                    {
                        lVFolders.Items.Add(folder,1);
                    }
                    else if(folder.Contains("."))
                    {
                        lVFolders.Items.Add(folder);
                    }
                    
                }
            }
            else
            {
                textBox1.Text += lVFolders.FocusedItem.Text;
                lVFolders.Items.Clear();
                string[] files = Directory.GetFileSystemEntries(fileName);
                foreach (string folder in files)
                {
                    if (!folder.Contains("."))
                    {
                        lVFolders.Items.Add(folder, 1);
                    }
                    else if(folder.Contains("."))
                    {
                        lVFolders.Items.Add(folder);
                    }
                }
            }
        }
        private void lVFolders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            fileName = e.Item.Text;
        }
    }
}
