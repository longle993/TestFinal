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
    public partial class AddFunctionHome : UserControl
    {
        public AddFunctionHome()
        {
            InitializeComponent();
        }

        private void AddFunctionHome_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(74, 164, 247);
        }

        private void AddFunctionHome_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

        }
    }
}
