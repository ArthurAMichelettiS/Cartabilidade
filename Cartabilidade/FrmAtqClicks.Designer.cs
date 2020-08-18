namespace Cartabilidade
{
    partial class FrmAtqClicks
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblAtq = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 89);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Carregar ataque";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(175, 42);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 60;
            // 
            // lblAtq
            // 
            this.lblAtq.AutoSize = true;
            this.lblAtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtq.Location = new System.Drawing.Point(196, 21);
            this.lblAtq.Name = "lblAtq";
            this.lblAtq.Size = new System.Drawing.Size(59, 25);
            this.lblAtq.TabIndex = 2;
            this.lblAtq.Text = "ATK:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAtqClicks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(331, 172);
            this.Controls.Add(this.lblAtq);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "FrmAtqClicks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atirar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmClicks_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmClicks_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblAtq;
        private System.Windows.Forms.Timer timer1;
    }
}