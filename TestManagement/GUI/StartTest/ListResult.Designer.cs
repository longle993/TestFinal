
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
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timesubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTestName = new System.Windows.Forms.Label();
            this.panelTestDetail = new TestManagement.UserControl_Test.Panel_Advanced();
            this.btnEnd = new TestManagement.UserControl_Test.Button_Advanced();
            this.panel_Advanced2 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTesttimeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Advanced1 = new TestManagement.UserControl_Test.Panel_Advanced();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTestDetail.SuspendLayout();
            this.panel_Advanced2.SuspendLayout();
            this.panel_Advanced1.SuspendLayout();
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
            this.panelTestDetail.BackColor = System.Drawing.Color.White;
            this.panelTestDetail.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panelTestDetail.Controls.Add(this.btnEnd);
            this.panelTestDetail.Controls.Add(this.panel_Advanced2);
            this.panelTestDetail.Controls.Add(this.panel_Advanced1);
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
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnEnd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnEnd.BorderRadius = 5;
            this.btnEnd.BorderSize = 0;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(16, 291);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(305, 47);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "Kết thúc đợt thi";
            this.btnEnd.TextColor = System.Drawing.Color.White;
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel_Advanced2
            // 
            this.panel_Advanced2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_Advanced2.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced2.Controls.Add(this.label1);
            this.panel_Advanced2.Controls.Add(this.lblTesttimeID);
            this.panel_Advanced2.Controls.Add(this.label3);
            this.panel_Advanced2.EdgeWidth = 1;
            this.panel_Advanced2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_Advanced2.FlatBorderColor = System.Drawing.Color.White;
            this.panel_Advanced2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Advanced2.Location = new System.Drawing.Point(0, 135);
            this.panel_Advanced2.Name = "panel_Advanced2";
            this.panel_Advanced2.RectRadius = 5;
            this.panel_Advanced2.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced2.ShadowShift = 0;
            this.panel_Advanced2.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced2.Size = new System.Drawing.Size(340, 137);
            this.panel_Advanced2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel_Advanced2.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "00:00 ";
            // 
            // lblTesttimeID
            // 
            this.lblTesttimeID.AutoSize = true;
            this.lblTesttimeID.BackColor = System.Drawing.Color.Transparent;
            this.lblTesttimeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesttimeID.ForeColor = System.Drawing.Color.Black;
            this.lblTesttimeID.Location = new System.Drawing.Point(119, 66);
            this.lblTesttimeID.Name = "lblTesttimeID";
            this.lblTesttimeID.Size = new System.Drawing.Size(99, 21);
            this.lblTesttimeID.TabIndex = 2;
            this.lblTesttimeID.Text = "#testtimeID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng:";
            // 
            // panel_Advanced1
            // 
            this.panel_Advanced1.BackColor = System.Drawing.Color.White;
            this.panel_Advanced1.BackgroundGradientMode = TestManagement.UserControl_Test.Panel_Advanced.PanelGradientMode.Vertical;
            this.panel_Advanced1.Controls.Add(this.lblTime);
            this.panel_Advanced1.Controls.Add(this.label2);
            this.panel_Advanced1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Advanced1.EdgeWidth = 1;
            this.panel_Advanced1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.panel_Advanced1.FlatBorderColor = System.Drawing.Color.White;
            this.panel_Advanced1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Advanced1.Location = new System.Drawing.Point(0, 0);
            this.panel_Advanced1.Name = "panel_Advanced1";
            this.panel_Advanced1.RectRadius = 5;
            this.panel_Advanced1.ShadowColor = System.Drawing.Color.DimGray;
            this.panel_Advanced1.ShadowShift = 0;
            this.panel_Advanced1.ShadowStyle = TestManagement.UserControl_Test.Panel_Advanced.ShadowMode.ForwardDiagonal;
            this.panel_Advanced1.Size = new System.Drawing.Size(340, 66);
            this.panel_Advanced1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.panel_Advanced1.Style = TestManagement.UserControl_Test.Panel_Advanced.BevelStyle.Flat;
            this.panel_Advanced1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(349, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 21);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "00:00 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "TestName";
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
            this.Name = "ListResult";
            this.Text = "ListResult";
            this.Load += new System.EventHandler(this.ListResult_Load);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTestDetail.ResumeLayout(false);
            this.panel_Advanced2.ResumeLayout(false);
            this.panel_Advanced2.PerformLayout();
            this.panel_Advanced1.ResumeLayout(false);
            this.panel_Advanced1.PerformLayout();
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
        private UserControl_Test.Panel_Advanced panel_Advanced2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTesttimeID;
        private System.Windows.Forms.Label label3;
        private UserControl_Test.Panel_Advanced panel_Advanced1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private UserControl_Test.Button_Advanced btnEnd;
    }
}