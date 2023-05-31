
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelResult = new TestManagement.UserControl_Test.Panel_Advanced();
            this.lblTestName = new System.Windows.Forms.Label();
            this.panelTestDetail = new TestManagement.UserControl_Test.Panel_Advanced();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panelResult.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelResult.Controls.Add(this.lblTimeNow);
            this.panelResult.Controls.Add(this.dataGridView1);
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
            this.panelResult.Size = new System.Drawing.Size(899, 758);
            this.panelResult.StartColor = System.Drawing.Color.White;
            this.panelResult.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelResult.TabIndex = 0;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(228, 38);
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
            this.panelTestDetail.Size = new System.Drawing.Size(340, 758);
            this.panelTestDetail.StartColor = System.Drawing.Color.White;
            this.panelTestDetail.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panelTestDetail.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.hovaten,
            this.timesubmit,
            this.point});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(35, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(832, 546);
            this.dataGridView1.TabIndex = 3;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 120;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // hovaten
            // 
            this.hovaten.HeaderText = "Họ và Tên";
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            this.hovaten.Width = 250;
            // 
            // timesubmit
            // 
            this.timesubmit.HeaderText = "Nộp lúc";
            this.timesubmit.Name = "timesubmit";
            this.timesubmit.ReadOnly = true;
            this.timesubmit.Width = 150;
            // 
            // point
            // 
            this.point.HeaderText = "Điểm";
            this.point.Name = "point";
            this.point.ReadOnly = true;
            this.point.Width = 150;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.BackColor = System.Drawing.Color.White;
            this.lblTimeNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.Location = new System.Drawing.Point(774, 90);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(93, 21);
            this.lblTimeNow.TabIndex = 4;
            this.lblTimeNow.Text = "31/05/2023";
            // 
            // ListResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1280, 758);
            this.Controls.Add(this.panelTestDetail);
            this.Controls.Add(this.panelResult);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListResult";
            this.Text = "ListResult";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_Test.Panel_Advanced panelResult;
        private System.Windows.Forms.Label lblTestName;
        private UserControl_Test.Panel_Advanced panelTestDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn timesubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.Label lblTimeNow;
    }
}