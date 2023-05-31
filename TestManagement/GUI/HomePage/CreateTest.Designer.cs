
namespace TestManagement.GUI
{
    partial class CreateTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTest = new System.Windows.Forms.Panel();
            this.panelAnswer = new TestManagement.UserControl_Test.Panel_Advanced();
            this.btnSave = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnCancel = new TestManagement.UserControl_Test.Button_Advanced();
            this.flowQuesSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.txtMark = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountQues = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelQues = new TestManagement.UserControl_Test.Panel_Advanced();
            this.flowQues = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddQues = new TestManagement.UserControl_Test.Button_Advanced();
            this.panelLine = new System.Windows.Forms.Panel();
            this.lblTestName = new System.Windows.Forms.Label();
            this.panelTest.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.panel_Advanced1.SuspendLayout();
            this.panelQues.SuspendLayout();
            this.flowQues.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTest
            // 
            this.panelTest.BackColor = System.Drawing.Color.Transparent;
            this.panelTest.Controls.Add(this.panelAnswer);
            this.panelTest.Controls.Add(this.panelQues);
            this.panelTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTest.Location = new System.Drawing.Point(0, 0);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(1064, 755);
            this.panelTest.TabIndex = 0;
            // 
            // panelAnswer
            // 
            this.panelAnswer.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelAnswer.Controls.Add(this.btnSave);
            this.panelAnswer.Controls.Add(this.btnCancel);
            this.panelAnswer.Controls.Add(this.flowQuesSetting);
            this.panelAnswer.Controls.Add(this.panel_Advanced1);
            this.panelAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAnswer.EdgeWidth = 1;
            this.panelAnswer.EndColor = System.Drawing.Color.White;
            this.panelAnswer.FlatBorderColor = System.Drawing.Color.White;
            this.panelAnswer.Location = new System.Drawing.Point(604, 0);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.RectRadius = 20;
            this.panelAnswer.ShadowColor = System.Drawing.Color.DimGray;
            this.panelAnswer.ShadowShift = 0;
            this.panelAnswer.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelAnswer.Size = new System.Drawing.Size(460, 755);
            this.panelAnswer.StartColor = System.Drawing.Color.White;
            this.panelAnswer.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelAnswer.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnSave.BorderRadius = 8;
            this.btnSave.BorderSize = 1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(323, 673);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(177, 673);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowQuesSetting
            // 
            this.flowQuesSetting.AutoScroll = true;
            this.flowQuesSetting.BackColor = System.Drawing.Color.Transparent;
            this.flowQuesSetting.Location = new System.Drawing.Point(9, 90);
            this.flowQuesSetting.Name = "flowQuesSetting";
            this.flowQuesSetting.Size = new System.Drawing.Size(444, 568);
            this.flowQuesSetting.TabIndex = 1;
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackColor = System.Drawing.Color.White;
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.txtMark);
            this.panel_Advanced1.Controls.Add(this.label4);
            this.panel_Advanced1.Controls.Add(this.txtCountQues);
            this.panel_Advanced1.Controls.Add(this.label3);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Advanced1.EdgeWidth = 1;
            this.panel_Advanced1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.White;
            this.panel_Advanced1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 5;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(460, 66);
            this.panel_Advanced1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 0;
            // 
            // txtMark
            // 
            this.txtMark.BackColor = System.Drawing.Color.White;
            this.txtMark.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.txtMark.BorderFocusColor = System.Drawing.Color.Black;
            this.txtMark.BorderRadius = 10;
            this.txtMark.BorderSize = 0;
            this.txtMark.IsFocused = false;
            this.txtMark.Location = new System.Drawing.Point(385, 17);
            this.txtMark.Margin = new System.Windows.Forms.Padding(4);
            this.txtMark.Multiline = false;
            this.txtMark.Name = "txtMark";
            this.txtMark.Padding = new System.Windows.Forms.Padding(7);
            this.txtMark.PasswordChar = false;
            this.txtMark.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMark.PlaceholderText = "";
            this.txtMark.ReadOnly = true;
            this.txtMark.Size = new System.Drawing.Size(62, 32);
            this.txtMark.TabIndex = 6;
            this.txtMark.Texts = "";
            this.txtMark.UnderlineedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(294, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng điểm:";
            // 
            // txtCountQues
            // 
            this.txtCountQues.BackColor = System.Drawing.Color.White;
            this.txtCountQues.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.txtCountQues.BorderFocusColor = System.Drawing.Color.Black;
            this.txtCountQues.BorderRadius = 10;
            this.txtCountQues.BorderSize = 0;
            this.txtCountQues.IsFocused = false;
            this.txtCountQues.Location = new System.Drawing.Point(216, 17);
            this.txtCountQues.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountQues.Multiline = false;
            this.txtCountQues.Name = "txtCountQues";
            this.txtCountQues.Padding = new System.Windows.Forms.Padding(25, 7, 7, 7);
            this.txtCountQues.PasswordChar = false;
            this.txtCountQues.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCountQues.PlaceholderText = "";
            this.txtCountQues.ReadOnly = true;
            this.txtCountQues.Size = new System.Drawing.Size(62, 32);
            this.txtCountQues.TabIndex = 5;
            this.txtCountQues.Texts = "";
            this.txtCountQues.UnderlineedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(156, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số câu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐÁP ÁN";
            // 
            // panelQues
            // 
            this.panelQues.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelQues.Controls.Add(this.flowQues);
            this.panelQues.Controls.Add(this.panelLine);
            this.panelQues.Controls.Add(this.lblTestName);
            this.panelQues.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelQues.EdgeWidth = 2;
            this.panelQues.EndColor = System.Drawing.Color.White;
            this.panelQues.FlatBorderColor = System.Drawing.Color.White;
            this.panelQues.Location = new System.Drawing.Point(0, 0);
            this.panelQues.Name = "panelQues";
            this.panelQues.RectRadius = 20;
            this.panelQues.ShadowColor = System.Drawing.Color.DimGray;
            this.panelQues.ShadowShift = 0;
            this.panelQues.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelQues.Size = new System.Drawing.Size(586, 755);
            this.panelQues.StartColor = System.Drawing.Color.White;
            this.panelQues.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelQues.TabIndex = 5;
            // 
            // flowQues
            // 
            this.flowQues.AutoScroll = true;
            this.flowQues.BackColor = System.Drawing.Color.White;
            this.flowQues.Controls.Add(this.btnAddQues);
            this.flowQues.Location = new System.Drawing.Point(15, 87);
            this.flowQues.Name = "flowQues";
            this.flowQues.Size = new System.Drawing.Size(568, 647);
            this.flowQues.TabIndex = 0;
            // 
            // btnAddQues
            // 
            this.btnAddQues.BackColor = System.Drawing.Color.White;
            this.btnAddQues.BackgroundColor = System.Drawing.Color.White;
            this.btnAddQues.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnAddQues.BorderRadius = 8;
            this.btnAddQues.BorderSize = 1;
            this.btnAddQues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQues.FlatAppearance.BorderSize = 0;
            this.btnAddQues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnAddQues.Location = new System.Drawing.Point(3, 3);
            this.btnAddQues.Name = "btnAddQues";
            this.btnAddQues.Size = new System.Drawing.Size(532, 50);
            this.btnAddQues.TabIndex = 1;
            this.btnAddQues.Text = "+ Thêm câu";
            this.btnAddQues.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnAddQues.UseVisualStyleBackColor = false;
            this.btnAddQues.Click += new System.EventHandler(this.btnAddQues_Click);
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.LightGray;
            this.panelLine.Location = new System.Drawing.Point(15, 65);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(550, 1);
            this.panelLine.TabIndex = 2;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(31, 24);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(116, 30);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "#Testname";
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1064, 755);
            this.Controls.Add(this.panelTest);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTest";
            this.Load += new System.EventHandler(this.CreateTest_Load);
            this.panelTest.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.panelQues.ResumeLayout(false);
            this.panelQues.PerformLayout();
            this.flowQues.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTest;
        public UserControl_Test.Panel_Advanced panelAnswer;
        private UserControl_Test.Button_Advanced btnSave;
        private UserControl_Test.Button_Advanced btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowQuesSetting;
        private UserControl_Test.Panel_Advanced panel_Advanced1;
        private UserControl_Test.TextBox_Advanced txtMark;
        private System.Windows.Forms.Label label4;
        private UserControl_Test.TextBox_Advanced txtCountQues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public UserControl_Test.Panel_Advanced panelQues;
        public System.Windows.Forms.FlowLayoutPanel flowQues;
        private UserControl_Test.Button_Advanced btnAddQues;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label lblTestName;
    }
}