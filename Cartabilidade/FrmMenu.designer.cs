namespace Cartabilidade
{
    partial class FrmMenu
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
            this.lblTituloJogo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRecordes = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.btnDificuldade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.lblNomedeUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloJogo
            // 
            this.lblTituloJogo.AutoSize = true;
            this.lblTituloJogo.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJogo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblTituloJogo.Location = new System.Drawing.Point(17, 28);
            this.lblTituloJogo.Name = "lblTituloJogo";
            this.lblTituloJogo.Size = new System.Drawing.Size(445, 65);
            this.lblTituloJogo.TabIndex = 1;
            this.lblTituloJogo.Text = "CARTABILIDADE";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(63, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(359, 70);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRecordes
            // 
            this.btnRecordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordes.Location = new System.Drawing.Point(63, 179);
            this.btnRecordes.Name = "btnRecordes";
            this.btnRecordes.Size = new System.Drawing.Size(359, 70);
            this.btnRecordes.TabIndex = 3;
            this.btnRecordes.Text = "Recordes";
            this.btnRecordes.UseVisualStyleBackColor = true;
            this.btnRecordes.Click += new System.EventHandler(this.btnRecordes_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.Location = new System.Drawing.Point(63, 255);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(359, 70);
            this.btnAudio.TabIndex = 4;
            this.btnAudio.Text = "Tutorial";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // btnDificuldade
            // 
            this.btnDificuldade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificuldade.Location = new System.Drawing.Point(62, 331);
            this.btnDificuldade.Name = "btnDificuldade";
            this.btnDificuldade.Size = new System.Drawing.Size(359, 70);
            this.btnDificuldade.TabIndex = 5;
            this.btnDificuldade.Text = "Opções";
            this.btnDificuldade.UseVisualStyleBackColor = true;
            this.btnDificuldade.Click += new System.EventHandler(this.btnDificuldade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(251, 407);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 70);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(63, 407);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(173, 70);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // lblNomedeUsuario
            // 
            this.lblNomedeUsuario.AutoSize = true;
            this.lblNomedeUsuario.Location = new System.Drawing.Point(16, 16);
            this.lblNomedeUsuario.Name = "lblNomedeUsuario";
            this.lblNomedeUsuario.Size = new System.Drawing.Size(89, 13);
            this.lblNomedeUsuario.TabIndex = 8;
            this.lblNomedeUsuario.Text = "Nome de Usuário";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(482, 521);
            this.Controls.Add(this.lblNomedeUsuario);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDificuldade);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnRecordes);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTituloJogo);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloJogo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRecordes;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnDificuldade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Label lblNomedeUsuario;
    }
}

