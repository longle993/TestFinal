
namespace TestManagement.UserControl_Test
{
    partial class ListFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcreatedDay = new System.Windows.Forms.Label();
            this.lblChangedDay = new System.Windows.Forms.Label();
            this.lblfolderName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIcon.Image = global::TestManagement.Properties.Resources.Folder;
            this.picIcon.Location = new System.Drawing.Point(18, 14);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(25, 19);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 12;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.list_ControlClick);
            this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.picIcon.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.picIcon.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.picIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(-1, -11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(649, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "_________________________________________________________________________________" +
    "__________________________";
            this.label6.Click += new System.EventHandler(this.list_ControlClick);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.label6.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            // 
            // lblcreatedDay
            // 
            this.lblcreatedDay.AutoEllipsis = true;
            this.lblcreatedDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcreatedDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedDay.Location = new System.Drawing.Point(338, 14);
            this.lblcreatedDay.Name = "lblcreatedDay";
            this.lblcreatedDay.Size = new System.Drawing.Size(124, 19);
            this.lblcreatedDay.TabIndex = 8;
            this.lblcreatedDay.Text = "24/05/2023";
            this.lblcreatedDay.Click += new System.EventHandler(this.list_ControlClick);
            this.lblcreatedDay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.lblcreatedDay.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.lblcreatedDay.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.lblcreatedDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            // 
            // lblChangedDay
            // 
            this.lblChangedDay.AutoEllipsis = true;
            this.lblChangedDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChangedDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangedDay.Location = new System.Drawing.Point(522, 14);
            this.lblChangedDay.Name = "lblChangedDay";
            this.lblChangedDay.Size = new System.Drawing.Size(126, 19);
            this.lblChangedDay.TabIndex = 9;
            this.lblChangedDay.Text = "24/05/2023";
            this.lblChangedDay.Click += new System.EventHandler(this.list_ControlClick);
            this.lblChangedDay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.lblChangedDay.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.lblChangedDay.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.lblChangedDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            // 
            // lblfolderName
            // 
            this.lblfolderName.AutoEllipsis = true;
            this.lblfolderName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblfolderName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfolderName.Location = new System.Drawing.Point(68, 14);
            this.lblfolderName.Name = "lblfolderName";
            this.lblfolderName.Size = new System.Drawing.Size(217, 19);
            this.lblfolderName.TabIndex = 10;
            this.lblfolderName.Text = "Mạng máy tính";
            this.lblfolderName.Click += new System.EventHandler(this.list_ControlClick);
            this.lblfolderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.lblfolderName.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.lblfolderName.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.lblfolderName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            // 
            // ListFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcreatedDay);
            this.Controls.Add(this.lblChangedDay);
            this.Controls.Add(this.lblfolderName);
            this.DoubleBuffered = true;
            this.Name = "ListFolder";
            this.Size = new System.Drawing.Size(660, 45);
            this.Click += new System.EventHandler(this.list_ControlClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseDown);
            this.MouseEnter += new System.EventHandler(this.list_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListFolder_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picIcon;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblcreatedDay;
        public System.Windows.Forms.Label lblChangedDay;
        public System.Windows.Forms.Label lblfolderName;
    }
}
