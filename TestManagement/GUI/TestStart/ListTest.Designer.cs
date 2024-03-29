﻿
namespace TestManagement.GUI
{
    partial class ListTest
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
            this.panelDetail = new TestManagement.UserControl_Test.Panel_Advanced();
            this.panelButtonDetail = new System.Windows.Forms.Panel();
            this.btnResultTest = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnEdit = new TestManagement.UserControl_Test.Button_Advanced();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.picIconDetail = new System.Windows.Forms.PictureBox();
            this.panellFile = new TestManagement.UserControl_Test.Panel_Advanced();
            this.sortedList = new TestManagement.UserControl_Test.SortedList();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.btnSort = new TestManagement.UserControl_Test.Button_Advanced();
            this.flowTest = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDetail.SuspendLayout();
            this.panelButtonDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconDetail)).BeginInit();
            this.panellFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelDetail.Controls.Add(this.panelButtonDetail);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.lblDescription);
            this.panelDetail.Controls.Add(this.lblFileName);
            this.panelDetail.Controls.Add(this.picIconDetail);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetail.EdgeWidth = 2;
            this.panelDetail.EndColor = System.Drawing.Color.White;
            this.panelDetail.FlatBorderColor = System.Drawing.Color.White;
            this.panelDetail.Location = new System.Drawing.Point(1051, 0);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.RectRadius = 20;
            this.panelDetail.ShadowColor = System.Drawing.Color.DimGray;
            this.panelDetail.ShadowShift = 0;
            this.panelDetail.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelDetail.Size = new System.Drawing.Size(368, 929);
            this.panelDetail.StartColor = System.Drawing.Color.White;
            this.panelDetail.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelDetail.TabIndex = 5;
            // 
            // panelButtonDetail
            // 
            this.panelButtonDetail.BackColor = System.Drawing.Color.Transparent;
            this.panelButtonDetail.Controls.Add(this.btnResultTest);
            this.panelButtonDetail.Controls.Add(this.btnEdit);
            this.panelButtonDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonDetail.Location = new System.Drawing.Point(0, 209);
            this.panelButtonDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtonDetail.Name = "panelButtonDetail";
            this.panelButtonDetail.Size = new System.Drawing.Size(368, 720);
            this.panelButtonDetail.TabIndex = 8;
            // 
            // btnResultTest
            // 
            this.btnResultTest.BackColor = System.Drawing.Color.White;
            this.btnResultTest.BackgroundColor = System.Drawing.Color.White;
            this.btnResultTest.BorderColor = System.Drawing.Color.White;
            this.btnResultTest.BorderRadius = 5;
            this.btnResultTest.BorderSize = 0;
            this.btnResultTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultTest.FlatAppearance.BorderSize = 0;
            this.btnResultTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultTest.ForeColor = System.Drawing.Color.Black;
            this.btnResultTest.Image = global::TestManagement.Properties.Resources.detail;
            this.btnResultTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResultTest.Location = new System.Drawing.Point(0, 57);
            this.btnResultTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnResultTest.Name = "btnResultTest";
            this.btnResultTest.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btnResultTest.Size = new System.Drawing.Size(368, 57);
            this.btnResultTest.TabIndex = 2;
            this.btnResultTest.Text = "Bảng điểm";
            this.btnResultTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultTest.TextColor = System.Drawing.Color.Black;
            this.btnResultTest.UseVisualStyleBackColor = false;
            this.btnResultTest.Click += new System.EventHandler(this.btnResultTest_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.White;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::TestManagement.Properties.Resources.play;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btnEdit.Size = new System.Drawing.Size(368, 57);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Bắt đầu kiểm tra";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(-1, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "_____________________________________________";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(57, 121);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 28);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "#describe";
            this.lblDescription.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.Color.White;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(111, 82);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(97, 28);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "FileName";
            // 
            // picIconDetail
            // 
            this.picIconDetail.Image = global::TestManagement.Properties.Resources.File;
            this.picIconDetail.Location = new System.Drawing.Point(63, 71);
            this.picIconDetail.Margin = new System.Windows.Forms.Padding(4);
            this.picIconDetail.Name = "picIconDetail";
            this.picIconDetail.Size = new System.Drawing.Size(32, 37);
            this.picIconDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIconDetail.TabIndex = 0;
            this.picIconDetail.TabStop = false;
            // 
            // panellFile
            // 
            this.panellFile.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panellFile.Controls.Add(this.sortedList);
            this.panellFile.Controls.Add(this.checkAll);
            this.panellFile.Controls.Add(this.btnSort);
            this.panellFile.Controls.Add(this.flowTest);
            this.panellFile.Controls.Add(this.label4);
            this.panellFile.Controls.Add(this.label3);
            this.panellFile.Controls.Add(this.label5);
            this.panellFile.Controls.Add(this.label2);
            this.panellFile.Controls.Add(this.label1);
            this.panellFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellFile.EdgeWidth = 2;
            this.panellFile.EndColor = System.Drawing.Color.White;
            this.panellFile.FlatBorderColor = System.Drawing.Color.White;
            this.panellFile.Location = new System.Drawing.Point(0, 0);
            this.panellFile.Margin = new System.Windows.Forms.Padding(4);
            this.panellFile.Name = "panellFile";
            this.panellFile.RectRadius = 20;
            this.panellFile.ShadowColor = System.Drawing.Color.DimGray;
            this.panellFile.ShadowShift = 0;
            this.panellFile.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panellFile.Size = new System.Drawing.Size(1017, 929);
            this.panellFile.StartColor = System.Drawing.Color.White;
            this.panellFile.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panellFile.TabIndex = 4;
            // 
            // sortedList
            // 
            this.sortedList.BackColor = System.Drawing.Color.White;
            this.sortedList.Location = new System.Drawing.Point(185, 79);
            this.sortedList.Margin = new System.Windows.Forms.Padding(5);
            this.sortedList.Name = "sortedList";
            this.sortedList.Size = new System.Drawing.Size(264, 247);
            this.sortedList.TabIndex = 0;
            this.sortedList.Visible = false;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(157, 145);
            this.checkAll.Margin = new System.Windows.Forms.Padding(4);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(18, 17);
            this.checkAll.TabIndex = 0;
            this.checkAll.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.BackgroundColor = System.Drawing.Color.White;
            this.btnSort.BorderColor = System.Drawing.Color.White;
            this.btnSort.BorderRadius = 5;
            this.btnSort.BorderSize = 0;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.Image = global::TestManagement.Properties.Resources.sort;
            this.btnSort.Location = new System.Drawing.Point(177, 30);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(47, 44);
            this.btnSort.TabIndex = 6;
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.TextColor = System.Drawing.Color.Black;
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // flowTest
            // 
            this.flowTest.AutoScroll = true;
            this.flowTest.BackColor = System.Drawing.Color.White;
            this.flowTest.Location = new System.Drawing.Point(120, 186);
            this.flowTest.Margin = new System.Windows.Forms.Padding(4);
            this.flowTest.Name = "flowTest";
            this.flowTest.Size = new System.Drawing.Size(893, 298);
            this.flowTest.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(821, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sửa đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng quan";
            // 
            // ListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1419, 929);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panellFile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListTest";
            this.Text = "ListTest";
            this.Load += new System.EventHandler(this.ListTest_Load);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panelButtonDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIconDetail)).EndInit();
            this.panellFile.ResumeLayout(false);
            this.panellFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public UserControl_Test.Panel_Advanced panelDetail;
        private System.Windows.Forms.Panel panelButtonDetail;
        private UserControl_Test.Button_Advanced btnResultTest;
        private UserControl_Test.Button_Advanced btnEdit;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox picIconDetail;
        public UserControl_Test.Panel_Advanced panellFile;
        private UserControl_Test.SortedList sortedList;
        private System.Windows.Forms.CheckBox checkAll;
        private UserControl_Test.Button_Advanced btnSort;
        private System.Windows.Forms.FlowLayoutPanel flowTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}