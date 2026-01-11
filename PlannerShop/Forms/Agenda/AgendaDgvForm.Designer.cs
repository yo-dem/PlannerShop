namespace PlannerShop.Forms.Agenda
{
    partial class AgendaDgvForm
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
            components = new System.ComponentModel.Container();
            dgvData = new DataGridView();
            btnPrevWeek = new Button();
            btnNextWeek = new Button();
            btnWeek = new Button();
            lblTimeSlot = new Label();
            lblTime = new Label();
            timerTime = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = SystemColors.Control;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(13, 164);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1159, 486);
            dgvData.TabIndex = 6;
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.Location = new Point(12, 12);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(75, 36);
            btnPrevWeek.TabIndex = 7;
            btnPrevWeek.Text = "<<";
            btnPrevWeek.UseVisualStyleBackColor = true;
            btnPrevWeek.Click += btnPrevWeek_Click;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNextWeek.Location = new Point(1097, 12);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(75, 36);
            btnNextWeek.TabIndex = 8;
            btnNextWeek.Text = ">>";
            btnNextWeek.UseVisualStyleBackColor = true;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // btnWeek
            // 
            btnWeek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnWeek.Location = new Point(93, 12);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(998, 36);
            btnWeek.TabIndex = 9;
            btnWeek.Text = "Today";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 18F);
            lblTimeSlot.Location = new Point(86, 130);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(134, 32);
            lblTimeSlot.TabIndex = 10;
            lblTimeSlot.Text = "lblTimeSlot";
            lblTimeSlot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 32F);
            lblTime.Location = new Point(12, 71);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(162, 59);
            lblTime.TabIndex = 11;
            lblTime.Text = "lblTime";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerTime
            // 
            timerTime.Enabled = true;
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // AgendaDgvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblTime);
            Controls.Add(lblTimeSlot);
            Controls.Add(btnWeek);
            Controls.Add(btnNextWeek);
            Controls.Add(btnPrevWeek);
            Controls.Add(dgvData);
            MinimumSize = new Size(1100, 670);
            Name = "AgendaDgvForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgendaDgvForm";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnPrevWeek;
        private Button btnNextWeek;
        private Button btnWeek;
        private Label lblTimeSlot;
        private Label lblTime;
        private System.Windows.Forms.Timer timerTime;
    }
}