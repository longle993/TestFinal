using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestManagement.GUI;

namespace TestManagement.UserControl_Test
{
    public partial class DropDownMenu_Advanced : UserControl
    {
        public DropDownMenu_Advanced()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewAccount account = new NewAccount();
            account.Show();

        }
    }
}
