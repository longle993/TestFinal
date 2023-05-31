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
    public partial class TestQuestion : UserControl
    {
        private Button_Advanced currentBtn;
        public TestQuestion()
        {
            InitializeComponent();
        }
        private void ActivateButton(object senderBtn, Panel_Advanced panel)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button_Advanced)senderBtn;
                currentBtn.BackColor = Color.FromArgb(201, 225, 247);
                panel.BackColor = Color.FromArgb(199, 224, 247);
                panel.StartColor = Color.FromArgb(199, 224, 247);
                panel.EndColor = Color.FromArgb(199, 224, 247);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                foreach (Control ctr in Controls)
                {
                    if (ctr is Panel_Advanced)
                    {
                        Panel_Advanced ctr2 = (Panel_Advanced)ctr;
                        ctr2.BackColor = Color.White;
                        ctr2.StartColor = Color.White;
                        ctr2.EndColor = Color.White;
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
            ActivateButton(sender, panelbtnA);
        }


        private void btnB_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelbtnB);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelbtnC);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, panelbtnD);
        }

        #region properties
        [Category("Custom Props")]
        public string QuestionNumber { get => lblQues.Text; set => lblQues.Text = value; }

        [Category("Custom Props")]
        public string TextQuestion { get => lblTextQues.Text; set => lblTextQues.Text = value; }

        [Category("Custom Props")]
        public string AnswerA { get => lblAnswerA.Text; set => lblAnswerA.Text = value; }

        [Category("Custom Props")]
        public string AnswerB { get => lblAnswerB.Text; set => lblAnswerB.Text = value; }

        [Category("Custom Props")]
        public string AnswerC { get => lblAnswerC.Text; set => lblAnswerC.Text = value; }

        [Category("Custom Props")]
        public string AnswerD { get => lblAnswerD.Text; set => lblAnswerD.Text = value; }

        [Category("Custom Props")]
        public string Quesnumber { get => lblQues.Text; set => lblQues.Text = value; }

        #endregion
    }
}
