
namespace TestManagement.UserControl_Test
{
    partial class QuesSetting
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.txtMark = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQues = new System.Windows.Forms.Label();
            this.txtTrueAnswer = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.panel_Advanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.txtTrueAnswer);
            this.panel_Advanced1.Controls.Add(this.txtMark);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Controls.Add(this.label1);
            this.panel_Advanced1.Controls.Add(this.lblQues);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Advanced1.EdgeWidth = 1;
            this.panel_Advanced1.EndColor = System.Drawing.Color.White;
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.Gainsboro;
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 10;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(142, 147);
            this.panel_Advanced1.StartColor = System.Drawing.Color.White;
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 0;
            // 
            // txtMark
            // 
            this.txtMark.BackColor = System.Drawing.Color.White;
            this.txtMark.BorderColor = System.Drawing.Color.LightGray;
            this.txtMark.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMark.BorderRadius = 10;
            this.txtMark.BorderSize = 1;
            this.txtMark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.IsFocused = false;
            this.txtMark.Location = new System.Drawing.Point(65, 92);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4);
            this.txtMark.Multiline = false;
            this.txtMark.Name = "txtMark";
            this.txtMark.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.txtMark.PasswordChar = false;
            this.txtMark.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMark.PlaceholderText = "";
            this.txtMark.ReadOnly = false;
            this.txtMark.Size = new System.Drawing.Size(61, 32);
            this.txtMark.TabIndex = 5;
            this.txtMark.Texts = "";
            this.txtMark.UnderlineedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đáp án:";
            // 
            // lblQues
            // 
            this.lblQues.AutoSize = true;
            this.lblQues.BackColor = System.Drawing.Color.White;
            this.lblQues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(130)))), ((int)(((byte)(236)))));
            this.lblQues.Location = new System.Drawing.Point(3, 17);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(51, 21);
            this.lblQues.TabIndex = 4;
            this.lblQues.Text = "Câu 1:";
            // 
            // txtTrueAnswer
            // 
            this.txtTrueAnswer.BackColor = System.Drawing.Color.White;
            this.txtTrueAnswer.BorderColor = System.Drawing.Color.LightGray;
            this.txtTrueAnswer.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTrueAnswer.BorderRadius = 10;
            this.txtTrueAnswer.BorderSize = 1;
            this.txtTrueAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrueAnswer.IsFocused = false;
            this.txtTrueAnswer.Location = new System.Drawing.Point(65, 52);
            this.txtTrueAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrueAnswer.Multiline = false;
            this.txtTrueAnswer.Name = "txtTrueAnswer";
            this.txtTrueAnswer.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.txtTrueAnswer.PasswordChar = false;
            this.txtTrueAnswer.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTrueAnswer.PlaceholderText = "";
            this.txtTrueAnswer.ReadOnly = true;
            this.txtTrueAnswer.Size = new System.Drawing.Size(61, 32);
            this.txtTrueAnswer.TabIndex = 5;
            this.txtTrueAnswer.Texts = "";
            this.txtTrueAnswer.UnderlineedStyle = false;
            // 
            // QuesSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_Advanced1);
            this.Name = "QuesSetting";
            this.Size = new System.Drawing.Size(142, 147);
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel_Advanced panel_Advanced1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblQues;
        public System.Windows.Forms.Label label2;
        public TextBox_Advanced txtMark;
        public TextBox_Advanced txtTrueAnswer;
    }
}
