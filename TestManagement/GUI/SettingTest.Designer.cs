
namespace TestManagement.GUI
{
    partial class SettingTest
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
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.txtID = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new TestManagement.UserControl_Test.Button_Advanced();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panel_Advanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.btnStart);
            this.panel_Advanced1.Controls.Add(this.txtID);
            this.panel_Advanced1.Controls.Add(this.lblCancel);
            this.panel_Advanced1.Controls.Add(this.label4);
            this.panel_Advanced1.Controls.Add(this.label3);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Controls.Add(this.label1);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Advanced1.EdgeWidth = 1;
            this.panel_Advanced1.EndColor = System.Drawing.Color.White;
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.Gainsboro;
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 20;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(504, 647);
            this.panel_Advanced1.StartColor = System.Drawing.Color.White;
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtID.BorderRadius = 5;
            this.txtID.BorderSize = 1;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.IsFocused = false;
            this.txtID.Location = new System.Drawing.Point(334, 246);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(20, 10, 7, 10);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtID.PlaceholderText = "";
            this.txtID.ReadOnly = false;
            this.txtID.Size = new System.Drawing.Size(86, 42);
            this.txtID.TabIndex = 1;
            this.txtID.Texts = "";
            this.txtID.UnderlineedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian làm bài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hiển thị đáp án sau khi nộp bài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(188, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀI ĐẶT";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnStart.BorderRadius = 5;
            this.btnStart.BorderSize = 0;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(135, 469);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(210, 40);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.White;
            this.lblCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(217, 534);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(39, 21);
            this.lblCancel.TabIndex = 0;
            this.lblCancel.Text = "Huỷ";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // SettingTest
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(504, 647);
            this.Controls.Add(this.panel_Advanced1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingTest";
            this.Text = "SettingTest";
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panel_Advanced1;
        public UserControl_Test.TextBox_Advanced txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControl_Test.Button_Advanced btnStart;
        private System.Windows.Forms.Label lblCancel;
    }
}