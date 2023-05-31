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
using TestManagement.GUI.HomePage;

namespace TestManagement.UserControl_Test
{
    public partial class NewQuestion : UserControl
    {
        private Button_Advanced currentBtn;

        public NewQuestion()
        {
            InitializeComponent();
        }

        private void ActivateButton(object senderBtn, TextBox_Advanced txt)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button_Advanced)senderBtn;
                currentBtn.BackColor = Color.FromArgb(201, 225, 247);
                txt.BackColor = Color.FromArgb(199, 224, 247);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                foreach (Control ctr in Controls)
                {
                    if (ctr is TextBox_Advanced)
                    {
                        ctr.BackColor = Color.White;
                    }
                    if (ctr is Button_Advanced)
                    {
                        ctr.BackColor = Color.FromArgb(231, 243, 255);
                    }
                }
            }
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, txtAnswerA);
            Control ctr = (Control)sender;
            ctr.Tag = lblQues.Text;
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, txtAnswerB);
            Control ctr = (Control)sender;
            ctr.Tag = lblQues.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, txtAnswerC);
            Control ctr = (Control)sender;
            ctr.Tag = lblQues.Text;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, txtAnswerD);
            Control ctr = (Control)sender;
            ctr.Tag = lblQues.Text;
        }

        #region properties
        [Category("Custom Props")]
        public string QuestionNumber { get => lblQues.Text; set => lblQues.Text = value; }

        [Category("Custom Props")]
        public string TextQuestion { get => txtTextQues.Texts; set => txtTextQues.Texts = value; }

        [Category("Custom Props")]
        public string AnswerA { get => txtAnswerA.Texts; set => txtAnswerA.Texts = value; }

        [Category("Custom Props")]
        public string AnswerB { get => txtAnswerB.Texts; set => txtAnswerB.Texts = value; }

        [Category("Custom Props")]
        public string AnswerC { get => txtAnswerC.Texts; set => txtAnswerC.Texts = value; }

        [Category("Custom Props")]
        public string AnswerD { get => txtAnswerD.Texts; set => txtAnswerD.Texts = value; }

        [Category("Custom Props")]
        public string Quesnumber { get => lblQues.Text; set => lblQues.Text = value; }


        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Tag = lblQues.Text;
        }
    }
}
