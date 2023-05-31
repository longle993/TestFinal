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

namespace TestManagement.UserControl_Test
{
    public partial class ListFolder : UserControl
    {
        public ListFolder()
        {
            InitializeComponent();
        }

        #region properties


        [Category("Custom Props")]
        public string FolderName { get => lblfolderName.Text; set => lblfolderName.Text = value; }

        [Category("Custom Props")]
        public string CreatedDay { get => lblcreatedDay.Text; set => lblcreatedDay.Text = value; }

        [Category("Custom Props")]
        public Image Icon { get => picIcon.Image; set => picIcon.Image = value; }

        [Category("Custom Props")]
        public string ChangedDay { get => lblChangedDay.Text; set => lblChangedDay.Text = value; }

        #endregion

        private void list_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void list_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void list_ControlClick(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Tag = lblfolderName.Text;
        }

        private void ListFolder_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(74, 164, 247);

        }

        private void ListFolder_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
    }

