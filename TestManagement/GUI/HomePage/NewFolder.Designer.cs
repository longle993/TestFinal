
namespace TestManagement.GUI
{
    partial class NewFolder
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
            this.panelNewFolder = new TestManagement.UserControl_Test.Panel_Advanced();
            this.btnCreate = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnCancel = new TestManagement.UserControl_Test.Button_Advanced();
            this.txtFolderName = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewFolder
            // 
            this.panelNewFolder.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelNewFolder.Controls.Add(this.btnCreate);
            this.panelNewFolder.Controls.Add(this.btnCancel);
            this.panelNewFolder.Controls.Add(this.txtFolderName);
            this.panelNewFolder.Controls.Add(this.label1);
            this.panelNewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewFolder.EdgeWidth = 1;
            this.panelNewFolder.EndColor = System.Drawing.Color.White;
            this.panelNewFolder.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panelNewFolder.Location = new System.Drawing.Point(0, 0);
            this.panelNewFolder.Name = "panelNewFolder";
            this.panelNewFolder.RectRadius = 10;
            this.panelNewFolder.ShadowColor = System.Drawing.Color.DimGray;
            this.panelNewFolder.ShadowShift = 0;
            this.panelNewFolder.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelNewFolder.Size = new System.Drawing.Size(352, 195);
            this.panelNewFolder.StartColor = System.Drawing.Color.White;
            this.panelNewFolder.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelNewFolder.TabIndex = 0;
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
            this.btnCreate.Location = new System.Drawing.Point(272, 135);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(50, 40);
            this.btnCreate.TabIndex = 15;
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
            this.btnCancel.Location = new System.Drawing.Point(194, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.BackColor = System.Drawing.Color.White;
            this.txtFolderName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtFolderName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtFolderName.BorderRadius = 5;
            this.txtFolderName.BorderSize = 1;
            this.txtFolderName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.IsFocused = false;
            this.txtFolderName.Location = new System.Drawing.Point(30, 65);
            this.txtFolderName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderName.Multiline = false;
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Padding = new System.Windows.Forms.Padding(20, 10, 7, 10);
            this.txtFolderName.PasswordChar = false;
            this.txtFolderName.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtFolderName.PlaceholderText = "Untitled File";
            this.txtFolderName.ReadOnly = false;
            this.txtFolderName.Size = new System.Drawing.Size(292, 42);
            this.txtFolderName.TabIndex = 14;
            this.txtFolderName.Texts = "";
            this.txtFolderName.UnderlineedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thư mục mới";
            // 
            // NewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 195);
            this.Controls.Add(this.panelNewFolder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewFolder";
            this.panelNewFolder.ResumeLayout(false);
            this.panelNewFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panelNewFolder;
        private UserControl_Test.Button_Advanced btnCreate;
        private UserControl_Test.Button_Advanced btnCancel;
        public UserControl_Test.TextBox_Advanced txtFolderName;
        private System.Windows.Forms.Label label1;
    }
}