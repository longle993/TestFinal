using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManagement.UserControl_Test
{
    public partial class DataAccount : UserControl
    {
        public DataAccount()
        {
            InitializeComponent();
        }

        #region properties

        [Category("Custom Props")]
        public string UserName { get => lblUserName.Text; set => lblUserName.Text = value; }

        [Category("Custom Props")]
        public string Email { get => lblMail.Text; set => lblMail.Text = value; }

        [Category("Custom Props")]
        public string Pass { get => lblPass.Text; set => lblPass.Text = value; }

        [Category("Custom Props")]
        public string Phanquyen { get => lblPhanQuyen.Text; set => lblPhanQuyen.Text = value; }

        [Category("Custom Props")]
        public Image Icon { get => picIcon.Image; set => picIcon.Image = value; }
        #endregion

        #region fields

        private void dataAccount_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void dataAccount_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void dataAccount_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(74, 164, 247);
        }

        private void dataAccount_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.White;
        }

        #endregion

    }
}
