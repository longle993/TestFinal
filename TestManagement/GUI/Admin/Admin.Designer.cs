
namespace TestManagement.GUI
{
    partial class Admin
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
            this.btnMore = new TestManagement.UserControl_Test.Button_Advanced();
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.flowAccount = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAccount = new TestManagement.UserControl_Test.Button_Advanced();
            this.panel_Advanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnMore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnMore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnMore.BorderRadius = 20;
            this.btnMore.BorderSize = 0;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(59, 28);
            this.btnMore.Name = "btnMore";
            this.btnMore.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMore.Size = new System.Drawing.Size(45, 45);
            this.btnMore.TabIndex = 6;
            this.btnMore.Text = "+";
            this.btnMore.TextColor = System.Drawing.Color.White;
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.flowAccount);
            this.panel_Advanced1.Controls.Add(this.label5);
            this.panel_Advanced1.Controls.Add(this.label4);
            this.panel_Advanced1.Controls.Add(this.label3);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Controls.Add(this.label1);
            this.panel_Advanced1.EdgeWidth = 2;
            this.panel_Advanced1.EndColor = System.Drawing.Color.White;
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel_Advanced1.Location = new System.Drawing.Point(170, 3);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 20;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(1064, 755);
            this.panel_Advanced1.StartColor = System.Drawing.Color.White;
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 0;
            this.panel_Advanced1.Click += new System.EventHandler(this.panel_Advanced1_Click);
            // 
            // flowAccount
            // 
            this.flowAccount.BackColor = System.Drawing.Color.White;
            this.flowAccount.Location = new System.Drawing.Point(43, 139);
            this.flowAccount.Name = "flowAccount";
            this.flowAccount.Size = new System.Drawing.Size(966, 604);
            this.flowAccount.TabIndex = 8;
            this.flowAccount.Click += new System.EventHandler(this.panel_Advanced1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(845, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phân quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.White;
            this.btnAddAccount.BackgroundColor = System.Drawing.Color.White;
            this.btnAddAccount.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.BorderRadius = 5;
            this.btnAddAccount.BorderSize = 1;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Image = global::TestManagement.Properties.Resources.Folder;
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.Location = new System.Drawing.Point(59, 79);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnAddAccount.Size = new System.Drawing.Size(192, 40);
            this.btnAddAccount.TabIndex = 7;
            this.btnAddAccount.Text = "Thêm tài khoản mới";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAccount.TextColor = System.Drawing.Color.Black;
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Visible = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            this.btnAddAccount.MouseEnter += new System.EventHandler(this.btnAddFolder_MouseEnter);
            this.btnAddAccount.MouseLeave += new System.EventHandler(this.btnAddFolder_MouseLeave);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 775);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.panel_Advanced1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Click += new System.EventHandler(this.panel_Advanced1_Click);
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panel_Advanced1;
        private System.Windows.Forms.FlowLayoutPanel flowAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControl_Test.Button_Advanced btnMore;
        public UserControl_Test.Button_Advanced btnAddAccount;
    }
}