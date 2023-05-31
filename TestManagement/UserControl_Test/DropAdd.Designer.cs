
namespace TestManagement.UserControl_Test
{
    partial class DropAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropAdd));
            this.panelHomePage = new TestManagement.UserControl_Test.Panel_Advanced();
            this.button_Advanced1 = new TestManagement.UserControl_Test.Button_Advanced();
            this.btnAddFolder = new TestManagement.UserControl_Test.Button_Advanced();
            this.panelHomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHomePage
            // 
            this.panelHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelHomePage.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelHomePage.Controls.Add(this.button_Advanced1);
            this.panelHomePage.Controls.Add(this.btnAddFolder);
            this.panelHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHomePage.EdgeWidth = 1;
            this.panelHomePage.EndColor = System.Drawing.Color.White;
            this.panelHomePage.FlatBorderColor = System.Drawing.Color.DarkGray;
            this.panelHomePage.Location = new System.Drawing.Point(0, 0);
            this.panelHomePage.Name = "panelHomePage";
            this.panelHomePage.RectRadius = 10;
            this.panelHomePage.ShadowColor = System.Drawing.Color.DimGray;
            this.panelHomePage.ShadowShift = 0;
            this.panelHomePage.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelHomePage.Size = new System.Drawing.Size(206, 110);
            this.panelHomePage.StartColor = System.Drawing.Color.White;
            this.panelHomePage.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelHomePage.TabIndex = 1;
            // 
            // button_Advanced1
            // 
            this.button_Advanced1.BackColor = System.Drawing.Color.Transparent;
            this.button_Advanced1.BackgroundColor = System.Drawing.Color.Transparent;
            this.button_Advanced1.BorderColor = System.Drawing.Color.White;
            this.button_Advanced1.BorderRadius = 5;
            this.button_Advanced1.BorderSize = 0;
            this.button_Advanced1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Advanced1.FlatAppearance.BorderSize = 0;
            this.button_Advanced1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Advanced1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Advanced1.ForeColor = System.Drawing.Color.Black;
            this.button_Advanced1.Image = global::TestManagement.Properties.Resources.AddTest;
            this.button_Advanced1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Advanced1.Location = new System.Drawing.Point(0, 55);
            this.button_Advanced1.Name = "button_Advanced1";
            this.button_Advanced1.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.button_Advanced1.Size = new System.Drawing.Size(206, 55);
            this.button_Advanced1.TabIndex = 1;
            this.button_Advanced1.Text = "Tạo bài kiểm tra";
            this.button_Advanced1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Advanced1.TextColor = System.Drawing.Color.Black;
            this.button_Advanced1.UseVisualStyleBackColor = false;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFolder.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddFolder.BorderColor = System.Drawing.Color.White;
            this.btnAddFolder.BorderRadius = 5;
            this.btnAddFolder.BorderSize = 0;
            this.btnAddFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.Black;
            this.btnAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFolder.Image")));
            this.btnAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFolder.Location = new System.Drawing.Point(0, 0);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.btnAddFolder.Size = new System.Drawing.Size(206, 55);
            this.btnAddFolder.TabIndex = 0;
            this.btnAddFolder.Text = "Thêm thư mục";
            this.btnAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFolder.TextColor = System.Drawing.Color.Black;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            // 
            // DropAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHomePage);
            this.Name = "DropAdd";
            this.Size = new System.Drawing.Size(206, 110);
            this.panelHomePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button_Advanced button_Advanced1;
        private Panel_Advanced panelHomePage;
        private Button_Advanced btnAddFolder;
    }
}
