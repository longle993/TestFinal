﻿namespace TestManagement.GUI.StartTest
{
    partial class NewTestTime
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
            this.btnCreate = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnCancel = new TestManagement.UserControl_Test.Button_Advanced();
            this.txtCode = new TestManagement.UserControl_Test.TextBox_Advanced();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bài kiểm tra";
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
            this.txtTestName.Location = new System.Drawing.Point(44, 79);
            this.txtTestName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTestName.Multiline = false;
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtTestName.PasswordChar = false;
            this.txtTestName.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtTestName.PlaceholderText = "Untitled File";
            this.txtTestName.ReadOnly = false;
            this.txtTestName.Size = new System.Drawing.Size(439, 53);
            this.txtTestName.TabIndex = 1;
            this.txtTestName.Texts = "";
            this.txtTestName.UnderlineedStyle = false;
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
            this.btnCreate.Location = new System.Drawing.Point(416, 297);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(67, 49);
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
            this.btnCancel.Location = new System.Drawing.Point(312, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtCode.BorderRadius = 5;
            this.txtCode.BorderSize = 1;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.IsFocused = false;
            this.txtCode.Location = new System.Drawing.Point(44, 192);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.Padding = new System.Windows.Forms.Padding(27, 12, 9, 12);
            this.txtCode.PasswordChar = false;
            this.txtCode.PlaceholderColor = System.Drawing.Color.Silver;
            this.txtCode.PlaceholderText = "Description";
            this.txtCode.ReadOnly = false;
            this.txtCode.Size = new System.Drawing.Size(439, 53);
            this.txtCode.TabIndex = 2;
            this.txtCode.Texts = "";
            this.txtCode.UnderlineedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phòng";
            // 
            // NewTestTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewTestTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public UserControl_Test.TextBox_Advanced txtTestName;
        private UserControl_Test.Button_Advanced btnCreate;
        private UserControl_Test.Button_Advanced btnCancel;
        public UserControl_Test.TextBox_Advanced txtCode;
        private System.Windows.Forms.Label label3;
    }
}