using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.DTO;
using TestManagement.BUS;
namespace TestManagement.GUI.HomePage
{
    public partial class AdjustFolder : Form
    {
        string subName;
        public AdjustFolder()
        {
            InitializeComponent();
        }
        public AdjustFolder(string subName)
        {
            InitializeComponent();
            this.subName = subName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Texts.Length>0)
            {
                Subject_BUS.Instance.UpdateSubject(subName, txtFolderName.Texts);
                MessageBox.Show("Thay dổi tên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (txtFolderName.Texts.Length==0)
            {
                MessageBox.Show("Hãy nhập tên thư mục mới!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void AdjustFolder_Load(object sender, EventArgs e)
        {
            txtFolderName.PlaceholderText = subName;
        }
    }
}
