
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
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescribe = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.btnCreate = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnCancel = new TestManagement.UserControl_Test.Button_Advanced();
            this.cbboxFolder = new System.Windows.Forms.ComboBox();
            this.lblNewFolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestName = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Advanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.label3);
            this.panel_Advanced1.Controls.Add(this.txtDescribe);
            this.panel_Advanced1.Controls.Add(this.btnCreate);
            this.panel_Advanced1.Controls.Add(this.btnCancel);
            this.panel_Advanced1.Controls.Add(this.cbboxFolder);
            this.panel_Advanced1.Controls.Add(this.lblNewFolder);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Controls.Add(this.txtTestName);
            this.panel_Advanced1.Controls.Add(this.label1);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Advanced1.EdgeWidth = 1;
            this.panel_Advanced1.EndColor = System.Drawing.Color.White;
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 10;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(535, 492);
            this.panel_Advanced1.StartColor = System.Drawing.Color.White;
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mô tả";
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
            this.txtDescribe.Location = new System.Drawing.Point(50, 191);
            this.txtDescribe.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescribe.Multiline = false;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtDescribe.PasswordChar = false;
            this.txtDescribe.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtDescribe.PlaceholderText = "Description";
            this.txtDescribe.ReadOnly = false;
            this.txtDescribe.Size = new System.Drawing.Size(439, 53);
            this.txtDescribe.TabIndex = 24;
            this.txtDescribe.Texts = "";
            this.txtDescribe.UnderlineedStyle = false;
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
            this.btnCreate.Location = new System.Drawing.Point(422, 408);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(67, 49);
            this.btnCreate.TabIndex = 25;
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
            this.btnCancel.Location = new System.Drawing.Point(318, 408);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 49);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbboxFolder
            // 
            this.cbboxFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxFolder.FormattingEnabled = true;
            this.cbboxFolder.Location = new System.Drawing.Point(50, 303);
            this.cbboxFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cbboxFolder.Name = "cbboxFolder";
            this.cbboxFolder.Size = new System.Drawing.Size(437, 36);
            this.cbboxFolder.TabIndex = 27;
            // 
            // lblNewFolder
            // 
            this.lblNewFolder.AutoSize = true;
            this.lblNewFolder.BackColor = System.Drawing.Color.White;
            this.lblNewFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFolder.Location = new System.Drawing.Point(45, 357);
            this.lblNewFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewFolder.Name = "lblNewFolder";
            this.lblNewFolder.Size = new System.Drawing.Size(207, 28);
            this.lblNewFolder.TabIndex = 20;
            this.lblNewFolder.Text = "+ Thêm thư mục mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chọn thư mục";
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
            this.txtTestName.Location = new System.Drawing.Point(50, 78);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(5);
            this.txtTestName.Multiline = false;
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtTestName.PasswordChar = false;
            this.txtTestName.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtTestName.PlaceholderText = "Untitled File";
            this.txtTestName.ReadOnly = false;
            this.txtTestName.Size = new System.Drawing.Size(439, 53);
            this.txtTestName.TabIndex = 23;
            this.txtTestName.Texts = "";
            this.txtTestName.UnderlineedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tạo bài kiểm tra";
            // 
            // NewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 492);
            this.Controls.Add(this.panel_Advanced1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTest";
            this.Load += new System.EventHandler(this.NewTest_Load);
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panel_Advanced1;
        private System.Windows.Forms.Label label3;
        public UserControl_Test.TextBox_Advanced txtDescribe;
        private UserControl_Test.Button_Advanced btnCreate;
        private UserControl_Test.Button_Advanced btnCancel;
        private System.Windows.Forms.ComboBox cbboxFolder;
        private System.Windows.Forms.Label lblNewFolder;
        private System.Windows.Forms.Label label2;
        public UserControl_Test.TextBox_Advanced txtTestName;
        private System.Windows.Forms.Label label1;
    }
}