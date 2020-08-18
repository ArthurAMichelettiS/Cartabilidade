namespace Cartabilidade
{
    partial class FrmCarta
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
            this.lblDescr = new System.Windows.Forms.Label();
            this.imgCarta = new System.Windows.Forms.PictureBox();
            this.lblCusto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescr
            // 
            this.lblDescr.AutoEllipsis = true;
            this.lblDescr.BackColor = System.Drawing.Color.White;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(6, 88);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(120, 76);
            this.lblDescr.TabIndex = 1;
            this.lblDescr.Text = "Jogue um D20 e tente a sorte. Pode ter efeito benefico ou negativo";
            this.lblDescr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseDown);
            this.lblDescr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseMove);
            this.lblDescr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseUp);
            // 
            // imgCarta
            // 
            this.imgCarta.Image = global::Cartabilidade.Properties.Resources.dodecaedro;
            this.imgCarta.Location = new System.Drawing.Point(6, 5);
            this.imgCarta.Name = "imgCarta";
            this.imgCarta.Size = new System.Drawing.Size(120, 80);
            this.imgCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCarta.TabIndex = 0;
            this.imgCarta.TabStop = false;
            this.imgCarta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseDown);
            this.imgCarta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseMove);
            this.imgCarta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseUp);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCusto.Location = new System.Drawing.Point(7, 168);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(46, 13);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo: 3";
            // 
            // FrmCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(134, 186);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.imgCarta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icosaedro";
            this.Load += new System.EventHandler(this.FrmCarta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmCarta_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCarta;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblCusto;
    }
}