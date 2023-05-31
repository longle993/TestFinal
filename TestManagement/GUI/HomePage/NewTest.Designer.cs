
namespace TestManagement.GUI
{
    partial class NewTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestName = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label2 = new System.Windows.Forms.Label();
            this.cbboxFolder = new System.Windows.Forms.ComboBox();
            this.btnCreate = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnCancel = new TestManagement.UserControl_Test.Button_Advanced();
            this.lblNewFolder = new System.Windows.Forms.Label();
            this.txtDescribe = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo bài kiểm tra";
            // 
            // txtTestName
            // 
            this.txtTestName.BackColor = System.Drawing.Color.White;
            this.txtTestName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTestName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTestName.BorderRadius = 5;
            this.txtTestName.BorderSize = 1;
            this.txtTestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestName.IsFocused = false;
            this.txtTestName.Location = new System.Drawing.Point(33, 64);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestName.Multiline = false;
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Padding = new System.Windows.Forms.Padding(20, 10, 7, 10);
            this.txtTestName.PasswordChar = false;
            this.txtTestName.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtTestName.PlaceholderText = "Untitled File";
            this.txtTestName.ReadOnly = false;
            this.txtTestName.Size = new System.Drawing.Size(329, 42);
            this.txtTestName.TabIndex = 1;
            this.txtTestName.Texts = "";
            this.txtTestName.UnderlineedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn thư mục";
            // 
            // cbboxFolder
            // 
            this.cbboxFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxFolder.FormattingEnabled = true;
            this.cbboxFolder.Location = new System.Drawing.Point(33, 247);
            this.cbboxFolder.Name = "cbboxFolder";
            this.cbboxFolder.Size = new System.Drawing.Size(329, 29);
            this.cbboxFolder.TabIndex = 18;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 5;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCreate.Location = new System.Drawing.Point(312, 332);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(50, 40);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(234, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNewFolder
            // 
            this.lblNewFolder.AutoSize = true;
            this.lblNewFolder.BackColor = System.Drawing.Color.White;
            this.lblNewFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFolder.Location = new System.Drawing.Point(29, 291);
            this.lblNewFolder.Name = "lblNewFolder";
            this.lblNewFolder.Size = new System.Drawing.Size(162, 21);
            this.lblNewFolder.TabIndex = 0;
            this.lblNewFolder.Text = "+ Thêm thư mục mới";
            this.lblNewFolder.Click += new System.EventHandler(this.lblNewFolder_Click);
            // 
            // txtDescribe
            // 
            this.txtDescribe.BackColor = System.Drawing.Color.White;
            this.txtDescribe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtDescribe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtDescribe.BorderRadius = 5;
            this.txtDescribe.BorderSize = 1;
            this.txtDescribe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribe.IsFocused = false;
            this.txtDescribe.Location = new System.Drawing.Point(33, 156);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescribe.Multiline = false;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Padding = new System.Windows.Forms.Padding(20, 10, 7, 10);
            this.txtDescribe.PasswordChar = false;
            this.txtDescribe.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtDescribe.PlaceholderText = "Description";
            this.txtDescribe.ReadOnly = false;
            this.txtDescribe.Size = new System.Drawing.Size(329, 42);
            this.txtDescribe.TabIndex = 2;
            this.txtDescribe.Texts = "";
            this.txtDescribe.UnderlineedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả";
            // 
            // NewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbboxFolder);
            this.Controls.Add(this.lblNewFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTest";
            this.Load += new System.EventHandler(this.NewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public UserControl_Test.TextBox_Advanced txtTestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbboxFolder;
        private UserControl_Test.Button_Advanced btnCreate;
        private UserControl_Test.Button_Advanced btnCancel;
        private System.Windows.Forms.Label lblNewFolder;
        public UserControl_Test.TextBox_Advanced txtDescribe;
        private System.Windows.Forms.Label label3;
    }
}