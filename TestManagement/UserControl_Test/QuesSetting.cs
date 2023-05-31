using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManagement.UserControl_Test
{
    public partial class QuesSetting : UserControl
    {

        public QuesSetting()
        {
            InitializeComponent();
        }


        #region properties

        [Category("Custom Props")]
        public string QuesNumber { get => lblQues.Text; set => lblQues.Text = value; }

        [Category("Custom Props")]
        public string TrueAnswer { get => txtTrueAnswer.Texts; set => txtTrueAnswer.Texts = value; }

        [Category("Custom Props")]
        public string Mark { get => txtMark.Texts; set => txtMark.Texts = value; }
        #endregion
    }
}
