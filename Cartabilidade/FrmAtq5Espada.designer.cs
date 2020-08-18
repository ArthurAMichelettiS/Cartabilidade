namespace Cartabilidade
{
    partial class FrmAtq5Espada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pxbHitbox = new System.Windows.Forms.PictureBox();
            this.pxbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbHitbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pxbHitbox
            // 
            this.pxbHitbox.Location = new System.Drawing.Point(36, 18);
            this.pxbHitbox.Name = "pxbHitbox";
            this.pxbHitbox.Size = new System.Drawing.Size(81, 34);
            this.pxbHitbox.TabIndex = 1;
            this.pxbHitbox.TabStop = false;
            // 
            // pxbImg
            // 
            this.pxbImg.BackgroundImage = global::Cartabilidade.Properties.Resources.ESPADA_GIRA;
            this.pxbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pxbImg.Location = new System.Drawing.Point(-31, -38);
            this.pxbImg.Name = "pxbImg";
            this.pxbImg.Size = new System.Drawing.Size(164, 145);
            this.pxbImg.TabIndex = 0;
            this.pxbImg.TabStop = false;
            this.pxbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxbImg_MouseMove);
            // 
            // FrmAtq5Espada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(125, 69);
            this.Controls.Add(this.pxbHitbox);
            this.Controls.Add(this.pxbImg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAtq5Espada";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbHitbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pxbImg;
        private System.Windows.Forms.PictureBox pxbHitbox;
    }
}

