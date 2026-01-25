namespace PlannerShop.Forms
{
    partial class SendMailForm
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
            lblOldPassword = new Label();
            Password = new GroupBox();
            picAnteprima = new PictureBox();
            txtOggetto = new TextBox();
            lblNomeLocandina = new Label();
            btnCaricaLocandina = new Button();
            lblOggetto = new Label();
            txtMessage = new TextBox();
            lblMessage = new Label();
            btnOk = new Button();
            pnlTop = new Panel();
            progressBarSend = new ProgressBar();
            Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnteprima).BeginInit();
            SuspendLayout();
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(6, 18);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(0, 15);
            lblOldPassword.TabIndex = 0;
            // 
            // Password
            // 
            Password.Controls.Add(picAnteprima);
            Password.Controls.Add(txtOggetto);
            Password.Controls.Add(lblNomeLocandina);
            Password.Controls.Add(btnCaricaLocandina);
            Password.Controls.Add(lblOggetto);
            Password.Controls.Add(lblOldPassword);
            Password.Controls.Add(txtMessage);
            Password.Controls.Add(lblMessage);
            Password.Location = new Point(10, 26);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.Padding = new Padding(3, 2, 3, 2);
            Password.Size = new Size(404, 552);
            Password.TabIndex = 0;
            Password.TabStop = false;
            Password.Text = "INVIO MAIL";
            // 
            // picAnteprima
            // 
            picAnteprima.Location = new Point(6, 80);
            picAnteprima.Name = "picAnteprima";
            picAnteprima.Size = new Size(392, 204);
            picAnteprima.SizeMode = PictureBoxSizeMode.Zoom;
            picAnteprima.TabIndex = 5;
            picAnteprima.TabStop = false;
            // 
            // txtOggetto
            // 
            txtOggetto.Location = new Point(6, 320);
            txtOggetto.Name = "txtOggetto";
            txtOggetto.Size = new Size(392, 23);
            txtOggetto.TabIndex = 1;
            // 
            // lblNomeLocandina
            // 
            lblNomeLocandina.Location = new Point(6, 287);
            lblNomeLocandina.Name = "lblNomeLocandina";
            lblNomeLocandina.Size = new Size(392, 15);
            lblNomeLocandina.TabIndex = 4;
            lblNomeLocandina.Text = "lblNomeLocandina";
            lblNomeLocandina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCaricaLocandina
            // 
            btnCaricaLocandina.Location = new Point(6, 21);
            btnCaricaLocandina.Name = "btnCaricaLocandina";
            btnCaricaLocandina.Size = new Size(392, 38);
            btnCaricaLocandina.TabIndex = 3;
            btnCaricaLocandina.Text = "CARICA LOCANDINA";
            btnCaricaLocandina.UseVisualStyleBackColor = true;
            btnCaricaLocandina.Click += btnCaricaLocandina_Click;
            // 
            // lblOggetto
            // 
            lblOggetto.AutoSize = true;
            lblOggetto.Location = new Point(6, 302);
            lblOggetto.Name = "lblOggetto";
            lblOggetto.Size = new Size(60, 15);
            lblOggetto.TabIndex = 2;
            lblOggetto.Text = "OGGETTO";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(6, 363);
            txtMessage.Margin = new Padding(3, 2, 3, 2);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(392, 176);
            txtMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(6, 346);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(72, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "MESSAGGIO";
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOk.Image = Properties.Resources.okImage;
            btnOk.Location = new Point(10, 611);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(404, 51);
            btnOk.TabIndex = 3;
            btnOk.Text = "INVIA";
            btnOk.TextAlign = ContentAlignment.BottomCenter;
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(192, 192, 255);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(425, 10);
            pnlTop.TabIndex = 24;
            // 
            // progressBarSend
            // 
            progressBarSend.Location = new Point(16, 583);
            progressBarSend.Name = "progressBarSend";
            progressBarSend.Size = new Size(392, 23);
            progressBarSend.Style = ProgressBarStyle.Marquee;
            progressBarSend.TabIndex = 25;
            progressBarSend.Visible = false;
            // 
            // SendMailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 673);
            Controls.Add(progressBarSend);
            Controls.Add(pnlTop);
            Controls.Add(btnOk);
            Controls.Add(Password);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SendMailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MAIL";
            Password.ResumeLayout(false);
            Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnteprima).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Label lblOldPassword;
        private GroupBox Password;
        private TextBox txtMessage;
        private Label lblMessage;
        private Button btnOk;
        private Panel pnlTop;
        private TextBox txtOggetto;
        private Label lblOggetto;
        private Button btnCaricaLocandina;
        private ProgressBar progressBarSend;
        private Label lblNomeLocandina;
        private PictureBox picAnteprima;
    }
}