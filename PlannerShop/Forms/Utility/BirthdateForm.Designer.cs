namespace PlannerShop.Forms.Utility
{
    partial class BirthdateForm
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
            btnAnnulla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.BackgroundColor = SystemColors.Control;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 75);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(686, 203);
            dgvData.TabIndex = 25;
            dgvData.CellFormatting += dgvData_CellFormatting;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAnnulla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAnnulla.ForeColor = SystemColors.ControlText;
            btnAnnulla.Image = Properties.Resources.annulla_24;
            btnAnnulla.Location = new Point(12, 282);
            btnAnnulla.Margin = new Padding(3, 2, 3, 2);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(686, 68);
            btnAnnulla.TabIndex = 26;
            btnAnnulla.TabStop = false;
            btnAnnulla.Text = "CHIUDI";
            btnAnnulla.TextAlign = ContentAlignment.BottomCenter;
            btnAnnulla.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // BirthdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 361);
            Controls.Add(btnAnnulla);
            Controls.Add(dgvData);
            MinimumSize = new Size(730, 400);
            Name = "BirthdateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GIFT";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvData;
        private Button btnAnnulla;
    }
}