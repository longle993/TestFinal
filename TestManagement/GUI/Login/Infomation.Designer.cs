
namespace TestManagement.GUI
{
    partial class Infomation
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
            this.btnStart = new TestManagement.UserControl_Test.Button_Advanced();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.txtName = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.panel_Advanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.txtName);
            this.panel_Advanced1.Controls.Add(this.txtID);
            this.panel_Advanced1.Controls.Add(this.btnStart);
            this.panel_Advanced1.Controls.Add(this.label3);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Controls.Add(this.label1);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Advanced1.EdgeWidth = 2;
            this.panel_Advanced1.EndColor = System.Drawing.Color.White;
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.Gainsboro;
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 20;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(783, 543);
            this.panel_Advanced1.StartColor = System.Drawing.Color.White;
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 3;
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
            this.btnStart.Location = new System.Drawing.Point(233, 398);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(325, 68);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Họ và Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(240, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "THÔNG TIN CỦA BẠN";
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
            this.txtID.Location = new System.Drawing.Point(156, 176);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtID.PlaceholderText = "Untitled File";
            this.txtID.ReadOnly = false;
            this.txtID.Size = new System.Drawing.Size(439, 53);
            this.txtID.TabIndex = 28;
            this.txtID.Texts = "";
            this.txtID.UnderlineedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtName.BorderRadius = 5;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.IsFocused = false;
            this.txtName.Location = new System.Drawing.Point(156, 300);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtName.PlaceholderText = "Untitled File";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(439, 53);
            this.txtName.TabIndex = 29;
            this.txtName.Texts = "";
            this.txtName.UnderlineedStyle = false;
            // 
            // Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(783, 543);
            this.Controls.Add(this.panel_Advanced1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Infomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infomation";
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panel_Advanced1;
        private UserControl_Test.Button_Advanced btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public UserControl_Test.TextBox_Advanced txtName;
        public UserControl_Test.TextBox_Advanced txtID;
    }
}