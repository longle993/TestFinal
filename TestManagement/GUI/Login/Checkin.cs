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
            this.Hide();
            OpenChildForm(new Infomation(), panel_Advanced1);
            this.Close();
        }
    }
    
}
