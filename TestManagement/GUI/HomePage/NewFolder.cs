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

namespace TestManagement.GUI
{
    public partial class NewFolder : Form
    {
        public NewFolder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            string ID = "SUB" + (Subject_BUS.Instance.CountSubject() + 1).ToString("000");
            sub.SubjectID = ID;
            sub.SubjectName = txtFolderName.Texts;
            sub.InitiationDay = DateTime.Now;
            sub.ChangedDay = DateTime.Now;
            Subject_BUS.Instance.AddSubject(sub);
            this.Close();
        }
    }
}
