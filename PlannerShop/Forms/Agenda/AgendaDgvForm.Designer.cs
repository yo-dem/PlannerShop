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
            dgvData = new DataGridView();
            btnPrevWeek = new Button();
            btnNextWeek = new Button();
            btnWeek = new Button();
            lblTimeSlot = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = SystemColors.Control;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(13, 110);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(1059, 510);
            dgvData.TabIndex = 6;
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.Location = new Point(198, 12);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(75, 23);
            btnPrevWeek.TabIndex = 7;
            btnPrevWeek.Text = "<<";
            btnPrevWeek.UseVisualStyleBackColor = true;
            btnPrevWeek.Click += btnPrevWeek_Click;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Location = new Point(510, 12);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(75, 23);
            btnNextWeek.TabIndex = 8;
            btnNextWeek.Text = ">>";
            btnNextWeek.UseVisualStyleBackColor = true;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // btnWeek
            // 
            btnWeek.Location = new Point(279, 12);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(225, 23);
            btnWeek.TabIndex = 9;
            btnWeek.Text = "Today";
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Location = new Point(727, 17);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(38, 15);
            lblTimeSlot.TabIndex = 10;
            lblTimeSlot.Text = "label1";
            // 
            // AgendaDgvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 631);
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
    }
}