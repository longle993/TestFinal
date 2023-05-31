using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.UserControl_Test;

namespace TestManagement.GUI
{

    public partial class Checkin : Form
    {
        private Form currentChildForm;

        public Checkin()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm, Panel_Advanced panel)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            //Add Form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtCheckIn.Texts.Length>0)
            {
                Infomation infomation = new Infomation(txtCheckIn.Texts);
                this.Hide();
                infomation.ShowDialog();
                this.Show();
            }
            else if (txtCheckIn.Texts.Length==0)
            {
                MessageBox.Show("Vui lòng nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
