
namespace TestManagement.UserControl_Test
{
    partial class AddFunctionHome
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
            this.panelSort = new TestManagement.UserControl_Test.Panel_Advanced();
            this.btnAddTest = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnAddFolder = new TestManagement.UserControl_Test.Button_Advanced();
            this.panelSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSort
            // 
            this.panelSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelSort.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelSort.Controls.Add(this.btnAddTest);
            this.panelSort.Controls.Add(this.btnAddFolder);
            this.panelSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSort.EdgeWidth = 1;
            this.panelSort.EndColor = System.Drawing.Color.White;
            this.panelSort.FlatBorderColor = System.Drawing.Color.DarkGray;
            this.panelSort.Location = new System.Drawing.Point(0, 0);
            this.panelSort.Name = "panelSort";
            this.panelSort.RectRadius = 10;
            this.panelSort.ShadowColor = System.Drawing.Color.DimGray;
            this.panelSort.ShadowShift = 0;
            this.panelSort.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelSort.Size = new System.Drawing.Size(192, 80);
            this.panelSort.StartColor = System.Drawing.Color.White;
            this.panelSort.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelSort.TabIndex = 1;
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddTest.BorderColor = System.Drawing.Color.White;
            this.btnAddTest.BorderRadius = 0;
            this.btnAddTest.BorderSize = 0;
            this.btnAddTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTest.FlatAppearance.BorderSize = 0;
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.Color.Black;
            this.btnAddTest.Image = global::TestManagement.Properties.Resources.newtest;
            this.btnAddTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTest.Location = new System.Drawing.Point(0, 40);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Padding = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.btnAddTest.Size = new System.Drawing.Size(192, 40);
            this.btnAddTest.TabIndex = 6;
            this.btnAddTest.Text = "Thêm bài kiểm tra";
            this.btnAddTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTest.TextColor = System.Drawing.Color.Black;
            this.btnAddTest.UseVisualStyleBackColor = false;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFolder.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddFolder.BorderColor = System.Drawing.Color.White;
            this.btnAddFolder.BorderRadius = 0;
            this.btnAddFolder.BorderSize = 0;
            this.btnAddFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.Black;
            this.btnAddFolder.Image = global::TestManagement.Properties.Resources.newfolder;
            this.btnAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolder.Location = new System.Drawing.Point(0, 0);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btnAddFolder.Size = new System.Drawing.Size(192, 40);
            this.btnAddFolder.TabIndex = 5;
            this.btnAddFolder.Text = "Thêm thư mục";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.TextColor = System.Drawing.Color.Black;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.MouseEnter += new System.EventHandler(this.AddFunctionHome_MouseEnter);
            this.btnAddFolder.MouseLeave += new System.EventHandler(this.AddFunctionHome_MouseLeave);
            // 
            // AddFunctionHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSort);
            this.Name = "AddFunctionHome";
            this.Size = new System.Drawing.Size(192, 80);
            this.panelSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button_Advanced btnAddTest;
        private Panel_Advanced panelSort;
        public Button_Advanced btnAddFolder;
    }
}
