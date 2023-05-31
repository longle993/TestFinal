﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.BUS;
using TestManagement.DTO;

namespace TestManagement.GUI
{
    public partial class NewTest : Form
    {
        #region Set chiều cao cho ComboBox
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        private const Int32 CB_SETITEMHEIGHT = 0x153;
        private void SetComboBoxHeight(IntPtr comboBoxHandle, Int32 comboBoxDesiredHeight)
        {
            SendMessage(comboBoxHandle, CB_SETITEMHEIGHT, -1, comboBoxDesiredHeight);
        }
        #endregion
        List<Subject> subjects;
        FormMain formMain;

        
        public NewTest()
        {
            InitializeComponent();
            
        }
        public NewTest(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

        }
        private void NewTest_Load(object sender, EventArgs e)
        {
            SetComboBoxHeight(cbboxFolder.Handle, 30);
            cbboxFolder.Refresh();
            LoadAll();
        }

        private void lblNewFolder_Click(object sender, EventArgs e)
        {
            NewFolder folder = new NewFolder();
            folder.ShowDialog();
            LoadAll();

        }
        private void LoadAll()
        {
            subjects = Subject_BUS.Instance.GetSubjects();

            //Load Combo Box
            cbboxFolder.Items.Clear();
            foreach(Subject sub in subjects)
            {
                cbboxFolder.Items.Add(sub.SubjectName);
            }
            cbboxFolder.Items.Add("File đồng cấp folder");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            Subject sub = subjects.SingleOrDefault(p => p.SubjectName == cbboxFolder.Text);
            string testID = "T" + (Test_BUS.Instance.CountTest() + 1).ToString("000");
            test.TestID = testID;
            test.TestName = txtTestName.Texts;
            test.InitiationDate = DateTime.Now;
            test.ChangedDate = DateTime.Now;
            test.Description = txtDescribe.Texts;
            if(sub is null)
            {
                test.SubjectID = "0";
            }
            else
            {
                test.SubjectID = sub.SubjectID;
            }
            formMain.OpenChildForm(new CreateTest(test),formMain.panelMain);
            formMain.panellFile.Visible = false;
            formMain.panelDetail.Visible = false;
            this.Close();
            
        }
    }
}