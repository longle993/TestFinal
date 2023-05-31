
namespace TestManagement.GUI
{
    partial class ListResult
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
            this.panelResult = new TestManagement.UserControl_Test.Panel_Advanced();
            this.lblTestName = new System.Windows.Forms.Label();
            this.panelTestDetail = new TestManagement.UserControl_Test.Panel_Advanced();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelResult.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelResult.Controls.Add(this.lblTestName);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.EdgeWidth = 2;
            this.panelResult.EndColor = System.Drawing.Color.White;
            this.panelResult.FlatBorderColor = System.Drawing.Color.White;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.RectRadius = 20;
            this.panelResult.ShadowColor = System.Drawing.Color.DimGray;
            this.panelResult.ShadowShift = 0;
            this.panelResult.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelResult.Size = new System.Drawing.Size(899, 894);
            this.panelResult.StartColor = System.Drawing.Color.White;
            this.panelResult.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelResult.TabIndex = 0;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(223, 82);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(370, 37);
            this.lblTestName.TabIndex = 2;
            this.lblTestName.Text = "DANH SÁCH HOÀN THÀNH";
            // 
            // panelTestDetail
            // 
            this.panelTestDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelTestDetail.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelTestDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTestDetail.EdgeWidth = 2;
            this.panelTestDetail.EndColor = System.Drawing.Color.White;
            this.panelTestDetail.FlatBorderColor = System.Drawing.Color.White;
            this.panelTestDetail.Location = new System.Drawing.Point(940, 0);
            this.panelTestDetail.Name = "panelTestDetail";
            this.panelTestDetail.RectRadius = 20;
            this.panelTestDetail.ShadowColor = System.Drawing.Color.DimGray;
            this.panelTestDetail.ShadowShift = 0;
            this.panelTestDetail.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panelTestDetail.Size = new System.Drawing.Size(340, 894);
            this.panelTestDetail.StartColor = System.Drawing.Color.White;
            this.panelTestDetail.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelTestDetail.TabIndex = 1;
            // 
            // ListResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 894);
            this.Controls.Add(this.panelTestDetail);
            this.Controls.Add(this.panelResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListResult";
            this.Text = "ListResult";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panelResult;
        private System.Windows.Forms.Label lblTestName;
        private UserControl_Test.Panel_Advanced panelTestDetail;
    }
}