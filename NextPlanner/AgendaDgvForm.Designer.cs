namespace NextPlanner
{
    partial class AgendaDgvForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlToolbar = new Panel();
            btnPrevWeek = new Button();
            btnWeek = new Button();
            btnNextWeek = new Button();
            lblTimeSlot = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            dgvData = new DataGridView();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.Control;
            pnlToolbar.Controls.Add(btnPrevWeek);
            pnlToolbar.Controls.Add(btnWeek);
            pnlToolbar.Controls.Add(btnNextWeek);
            pnlToolbar.Controls.Add(lblTimeSlot);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1184, 119);
            pnlToolbar.TabIndex = 0;
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrevWeek.Location = new Point(12, 12);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(52, 42);
            btnPrevWeek.TabIndex = 0;
            btnPrevWeek.Text = "‹";
            btnPrevWeek.UseVisualStyleBackColor = true;
            btnPrevWeek.Click += btnPrevWeek_Click;
            // 
            // btnWeek
            // 
            btnWeek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWeek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWeek.Location = new Point(70, 12);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(1044, 42);
            btnWeek.TabIndex = 1;
            btnWeek.Text = "OGGI";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNextWeek.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNextWeek.Location = new Point(1120, 12);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(52, 42);
            btnNextWeek.TabIndex = 2;
            btnNextWeek.Text = "›";
            btnNextWeek.UseVisualStyleBackColor = true;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeSlot.Font = new Font("Segoe UI", 20F);
            lblTimeSlot.ForeColor = Color.FromArgb(60, 60, 60);
            lblTimeSlot.Location = new Point(12, 57);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(1160, 38);
            lblTimeSlot.TabIndex = 3;
            lblTimeSlot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timerTime
            // 
            timerTime.Enabled = true;
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // dgvData
            // 
            dgvData.Location = new Point(0, 0);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(1, 1);
            dgvData.TabIndex = 1;
            dgvData.TabStop = false;
            dgvData.Visible = false;
            // 
            // AgendaDgvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 720);
            Controls.Add(pnlToolbar);
            Controls.Add(dgvData);
            MinimumSize = new Size(900, 600);
            Name = "AgendaDgvForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agenda";
            WindowState = FormWindowState.Maximized;
            pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel pnlToolbar;
        private Button btnPrevWeek;
        private Button btnWeek;
        private Button btnNextWeek;
        private Label lblTimeSlot;
        private System.Windows.Forms.Timer timerTime;
        private DataGridView dgvData;
    }
}