
namespace TestManagement.GUI
{
    partial class SendOTP
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
            this.panelResetPass = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.lblEmailCheck = new System.Windows.Forms.Label();
            this.btnSendOTP = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnConfirm = new TestManagement.UserControl_Test.Button_Advanced();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.txtEmail = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResetPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResetPass
            // 
            this.panelResetPass.Controls.Add(this.lblError);
            this.panelResetPass.Controls.Add(this.lblEmailCheck);
            this.panelResetPass.Controls.Add(this.btnSendOTP);
            this.panelResetPass.Controls.Add(this.btnConfirm);
            this.panelResetPass.Controls.Add(this.label4);
            this.panelResetPass.Controls.Add(this.label3);
            this.panelResetPass.Controls.Add(this.txtConfirm);
            this.panelResetPass.Controls.Add(this.txtEmail);
            this.panelResetPass.Controls.Add(this.label2);
            this.panelResetPass.Controls.Add(this.label9);
            this.panelResetPass.Controls.Add(this.label1);
            this.panelResetPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResetPass.Location = new System.Drawing.Point(0, 0);
            this.panelResetPass.Margin = new System.Windows.Forms.Padding(2);
            this.panelResetPass.Name = "panelResetPass";
            this.panelResetPass.Size = new System.Drawing.Size(456, 574);
            this.panelResetPass.TabIndex = 0;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(47, 368);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(152, 19);
            this.lblError.TabIndex = 39;
            this.lblError.Text = "Mã OTP không hợp lệ!!";
            this.lblError.Visible = false;
            // 
            // lblEmailCheck
            // 
            this.lblEmailCheck.AutoSize = true;
            this.lblEmailCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblEmailCheck.ForeColor = System.Drawing.Color.Red;
            this.lblEmailCheck.Location = new System.Drawing.Point(46, 249);
            this.lblEmailCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCheck.Name = "lblEmailCheck";
            this.lblEmailCheck.Size = new System.Drawing.Size(235, 19);
            this.lblEmailCheck.TabIndex = 38;
            this.lblEmailCheck.Text = "Không có Email này trong hệ thống!";
            this.lblEmailCheck.Visible = false;
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSendOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSendOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSendOTP.BorderRadius = 5;
            this.btnSendOTP.BorderSize = 0;
            this.btnSendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOTP.FlatAppearance.BorderSize = 0;
            this.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendOTP.ForeColor = System.Drawing.Color.White;
            this.btnSendOTP.Location = new System.Drawing.Point(341, 213);
            this.btnSendOTP.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.Size = new System.Drawing.Size(71, 32);
            this.btnSendOTP.TabIndex = 36;
            this.btnSendOTP.Text = "Gửi mã";
            this.btnSendOTP.TextColor = System.Drawing.Color.White;
            this.btnSendOTP.UseVisualStyleBackColor = false;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(115, 431);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(210, 40);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nhập Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nhập mã xác nhận";
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtConfirm.BorderFocusColor = System.Drawing.Color.Black;
            this.txtConfirm.BorderRadius = 5;
            this.txtConfirm.BorderSize = 1;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.IsFocused = false;
            this.txtConfirm.Location = new System.Drawing.Point(50, 332);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Multiline = false;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Padding = new System.Windows.Forms.Padding(27, 5, 22, 5);
            this.txtConfirm.PasswordChar = false;
            this.txtConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirm.PlaceholderText = "";
            this.txtConfirm.ReadOnly = false;
            this.txtConfirm.Size = new System.Drawing.Size(362, 32);
            this.txtConfirm.TabIndex = 35;
            this.txtConfirm.Texts = "";
            this.txtConfirm.UnderlineedStyle = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Black;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.IsFocused = false;
            this.txtEmail.Location = new System.Drawing.Point(50, 213);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(27, 5, 22, 5);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(362, 32);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlineedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "của bạn và chúng tôi sẽ gửi cho bạn mã xác nhận để bạn đặt lại mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nhập địa chỉ email đã được xác minh của tài khoản người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // SendOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 574);
            this.Controls.Add(this.panelResetPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SendOTP";
            this.Text = "SendOTP";
            this.panelResetPass.ResumeLayout(false);
            this.panelResetPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResetPass;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblEmailCheck;
        private UserControl_Test.Button_Advanced btnSendOTP;
        private UserControl_Test.Button_Advanced btnConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UserControl_Test.TextBox_Advanced txtConfirm;
        private UserControl_Test.TextBox_Advanced txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}