namespace Cartabilidade
{
    partial class FrmJogo
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
            this.btnCarta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtaque1 = new System.Windows.Forms.Button();
            this.btnAtaque2 = new System.Windows.Forms.Button();
            this.btnAtaque3 = new System.Windows.Forms.Button();
            this.btnAtaque4 = new System.Windows.Forms.Button();
            this.btnAtaque5 = new System.Windows.Forms.Button();
            this.lblPtos = new System.Windows.Forms.Label();
            this.btnCompra = new System.Windows.Forms.Button();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.pbInimigo = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInimigo = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnInfo1 = new System.Windows.Forms.Button();
            this.btnInfo2 = new System.Windows.Forms.Button();
            this.btnInfo3 = new System.Windows.Forms.Button();
            this.btnInfo4 = new System.Windows.Forms.Button();
            this.btnInfo5 = new System.Windows.Forms.Button();
            this.pbxAmuletoCura = new System.Windows.Forms.PictureBox();
            this.pbxAmuletoEspinhos = new System.Windows.Forms.PictureBox();
            this.pbxAmuletoDefesa = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoCura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoEspinhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoDefesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCarta
            // 
            this.btnCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarta.Location = new System.Drawing.Point(635, 235);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(150, 225);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.Text = "Ativar Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(635, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 225);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sacrificar\r\nganha 1 ponto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAtaque1
            // 
            this.btnAtaque1.Location = new System.Drawing.Point(28, 42);
            this.btnAtaque1.Name = "btnAtaque1";
            this.btnAtaque1.Size = new System.Drawing.Size(150, 45);
            this.btnAtaque1.TabIndex = 2;
            this.btnAtaque1.TabStop = false;
            this.btnAtaque1.Text = "Corte simples ";
            this.btnAtaque1.UseVisualStyleBackColor = true;
            this.btnAtaque1.Click += new System.EventHandler(this.btnAtaque1_Click);
            // 
            // btnAtaque2
            // 
            this.btnAtaque2.Enabled = false;
            this.btnAtaque2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaque2.Location = new System.Drawing.Point(28, 96);
            this.btnAtaque2.Name = "btnAtaque2";
            this.btnAtaque2.Size = new System.Drawing.Size(150, 45);
            this.btnAtaque2.TabIndex = 3;
            this.btnAtaque2.TabStop = false;
            this.btnAtaque2.Text = "Locked";
            this.btnAtaque2.UseVisualStyleBackColor = true;
            this.btnAtaque2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAtque2_MouseClick);
            // 
            // btnAtaque3
            // 
            this.btnAtaque3.Enabled = false;
            this.btnAtaque3.Location = new System.Drawing.Point(28, 148);
            this.btnAtaque3.Name = "btnAtaque3";
            this.btnAtaque3.Size = new System.Drawing.Size(150, 45);
            this.btnAtaque3.TabIndex = 4;
            this.btnAtaque3.TabStop = false;
            this.btnAtaque3.Text = "Locked";
            this.btnAtaque3.UseVisualStyleBackColor = true;
            this.btnAtaque3.Click += new System.EventHandler(this.btnAtaque3_Click);
            // 
            // btnAtaque4
            // 
            this.btnAtaque4.Enabled = false;
            this.btnAtaque4.Location = new System.Drawing.Point(28, 204);
            this.btnAtaque4.Name = "btnAtaque4";
            this.btnAtaque4.Size = new System.Drawing.Size(150, 45);
            this.btnAtaque4.TabIndex = 5;
            this.btnAtaque4.TabStop = false;
            this.btnAtaque4.Text = "Locked";
            this.btnAtaque4.UseVisualStyleBackColor = true;
            this.btnAtaque4.Click += new System.EventHandler(this.btnAtaque4_Click);
            // 
            // btnAtaque5
            // 
            this.btnAtaque5.Enabled = false;
            this.btnAtaque5.Location = new System.Drawing.Point(28, 260);
            this.btnAtaque5.Name = "btnAtaque5";
            this.btnAtaque5.Size = new System.Drawing.Size(150, 45);
            this.btnAtaque5.TabIndex = 6;
            this.btnAtaque5.TabStop = false;
            this.btnAtaque5.Text = "Locked";
            this.btnAtaque5.UseVisualStyleBackColor = true;
            this.btnAtaque5.Click += new System.EventHandler(this.btnAtaque5_Click);
            // 
            // lblPtos
            // 
            this.lblPtos.AutoSize = true;
            this.lblPtos.BackColor = System.Drawing.Color.DarkGray;
            this.lblPtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtos.ForeColor = System.Drawing.Color.Navy;
            this.lblPtos.Location = new System.Drawing.Point(24, 348);
            this.lblPtos.Name = "lblPtos";
            this.lblPtos.Size = new System.Drawing.Size(156, 20);
            this.lblPtos.TabIndex = 7;
            this.lblPtos.Text = "Pontos Magicos: 5";
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(28, 387);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(182, 56);
            this.btnCompra.TabIndex = 8;
            this.btnCompra.Text = "Comprar Carta\r\npor 2 pontos";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // pbVida
            // 
            this.pbVida.Location = new System.Drawing.Point(363, 433);
            this.pbVida.Maximum = 1000;
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(174, 23);
            this.pbVida.TabIndex = 10;
            this.pbVida.Value = 1000;
            // 
            // pbInimigo
            // 
            this.pbInimigo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbInimigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbInimigo.ForeColor = System.Drawing.Color.Red;
            this.pbInimigo.Location = new System.Drawing.Point(288, 43);
            this.pbInimigo.Maximum = 12000;
            this.pbInimigo.Name = "pbInimigo";
            this.pbInimigo.Size = new System.Drawing.Size(278, 23);
            this.pbInimigo.TabIndex = 11;
            this.pbInimigo.Value = 12000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(302, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "ATAQUES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "BOSS";
            // 
            // lblInimigo
            // 
            this.lblInimigo.AutoSize = true;
            this.lblInimigo.BackColor = System.Drawing.Color.White;
            this.lblInimigo.Location = new System.Drawing.Point(391, 48);
            this.lblInimigo.Name = "lblInimigo";
            this.lblInimigo.Size = new System.Drawing.Size(72, 13);
            this.lblInimigo.TabIndex = 15;
            this.lblInimigo.Text = "12000/12000";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(414, 438);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(60, 13);
            this.lblVida.TabIndex = 16;
            this.lblVida.Text = "1000/1000";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.DarkGray;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(28, 321);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(62, 20);
            this.lblTempo.TabIndex = 17;
            this.lblTempo.Text = "Tempo:";
            // 
            // btnInfo1
            // 
            this.btnInfo1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo1.Location = new System.Drawing.Point(188, 53);
            this.btnInfo1.Name = "btnInfo1";
            this.btnInfo1.Size = new System.Drawing.Size(25, 25);
            this.btnInfo1.TabIndex = 21;
            this.btnInfo1.Text = "I";
            this.btnInfo1.UseVisualStyleBackColor = true;
            this.btnInfo1.Click += new System.EventHandler(this.btnInfo1_Click);
            // 
            // btnInfo2
            // 
            this.btnInfo2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo2.Location = new System.Drawing.Point(188, 107);
            this.btnInfo2.Name = "btnInfo2";
            this.btnInfo2.Size = new System.Drawing.Size(25, 25);
            this.btnInfo2.TabIndex = 22;
            this.btnInfo2.Text = "I";
            this.btnInfo2.UseVisualStyleBackColor = true;
            this.btnInfo2.Click += new System.EventHandler(this.btnInfo2_Click);
            // 
            // btnInfo3
            // 
            this.btnInfo3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo3.Location = new System.Drawing.Point(188, 159);
            this.btnInfo3.Name = "btnInfo3";
            this.btnInfo3.Size = new System.Drawing.Size(25, 25);
            this.btnInfo3.TabIndex = 23;
            this.btnInfo3.Text = "I";
            this.btnInfo3.UseVisualStyleBackColor = true;
            this.btnInfo3.Click += new System.EventHandler(this.btnInfo3_Click);
            // 
            // btnInfo4
            // 
            this.btnInfo4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo4.Location = new System.Drawing.Point(188, 215);
            this.btnInfo4.Name = "btnInfo4";
            this.btnInfo4.Size = new System.Drawing.Size(25, 25);
            this.btnInfo4.TabIndex = 24;
            this.btnInfo4.Text = "I";
            this.btnInfo4.UseVisualStyleBackColor = true;
            this.btnInfo4.Click += new System.EventHandler(this.btnInfo4_Click);
            // 
            // btnInfo5
            // 
            this.btnInfo5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo5.Location = new System.Drawing.Point(188, 271);
            this.btnInfo5.Name = "btnInfo5";
            this.btnInfo5.Size = new System.Drawing.Size(25, 25);
            this.btnInfo5.TabIndex = 25;
            this.btnInfo5.Text = "I";
            this.btnInfo5.UseVisualStyleBackColor = true;
            this.btnInfo5.Click += new System.EventHandler(this.btnInfo5_Click);
            // 
            // pbxAmuletoCura
            // 
            this.pbxAmuletoCura.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAmuletoCura.Image = global::Cartabilidade.Properties.Resources.espada_Cura;
            this.pbxAmuletoCura.Location = new System.Drawing.Point(579, 265);
            this.pbxAmuletoCura.Name = "pbxAmuletoCura";
            this.pbxAmuletoCura.Size = new System.Drawing.Size(50, 50);
            this.pbxAmuletoCura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAmuletoCura.TabIndex = 20;
            this.pbxAmuletoCura.TabStop = false;
            this.pbxAmuletoCura.Visible = false;
            // 
            // pbxAmuletoEspinhos
            // 
            this.pbxAmuletoEspinhos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAmuletoEspinhos.Image = global::Cartabilidade.Properties.Resources.RosaEspinhos;
            this.pbxAmuletoEspinhos.Location = new System.Drawing.Point(579, 321);
            this.pbxAmuletoEspinhos.Name = "pbxAmuletoEspinhos";
            this.pbxAmuletoEspinhos.Size = new System.Drawing.Size(50, 50);
            this.pbxAmuletoEspinhos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAmuletoEspinhos.TabIndex = 19;
            this.pbxAmuletoEspinhos.TabStop = false;
            this.pbxAmuletoEspinhos.Visible = false;
            // 
            // pbxAmuletoDefesa
            // 
            this.pbxAmuletoDefesa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxAmuletoDefesa.Image = global::Cartabilidade.Properties.Resources.escudo_melhor;
            this.pbxAmuletoDefesa.Location = new System.Drawing.Point(580, 377);
            this.pbxAmuletoDefesa.Name = "pbxAmuletoDefesa";
            this.pbxAmuletoDefesa.Size = new System.Drawing.Size(50, 50);
            this.pbxAmuletoDefesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAmuletoDefesa.TabIndex = 18;
            this.pbxAmuletoDefesa.TabStop = false;
            this.pbxAmuletoDefesa.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cartabilidade.Properties.Resources.Drawing__2_;
            this.pictureBox1.Location = new System.Drawing.Point(270, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 12;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 120;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartabilidade.Properties.Resources.stoner_wall;
            this.ClientSize = new System.Drawing.Size(799, 476);
            this.Controls.Add(this.btnInfo5);
            this.Controls.Add(this.btnInfo4);
            this.Controls.Add(this.btnInfo3);
            this.Controls.Add(this.btnInfo2);
            this.Controls.Add(this.btnInfo1);
            this.Controls.Add(this.pbxAmuletoCura);
            this.Controls.Add(this.pbxAmuletoEspinhos);
            this.Controls.Add(this.pbxAmuletoDefesa);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblInimigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbInimigo);
            this.Controls.Add(this.pbVida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.lblPtos);
            this.Controls.Add(this.btnAtaque5);
            this.Controls.Add(this.btnAtaque4);
            this.Controls.Add(this.btnAtaque3);
            this.Controls.Add(this.btnAtaque2);
            this.Controls.Add(this.btnAtaque1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCarta);
            this.MaximizeBox = false;
            this.Name = "FrmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartabilidade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControle_FormClosing);
            this.Load += new System.EventHandler(this.FrmControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoCura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoEspinhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmuletoDefesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtaque1;
        private System.Windows.Forms.Button btnAtaque2;
        private System.Windows.Forms.Button btnAtaque3;
        private System.Windows.Forms.Button btnAtaque4;
        private System.Windows.Forms.Button btnAtaque5;
        private System.Windows.Forms.Label lblPtos;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.ProgressBar pbInimigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInimigo;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.PictureBox pbxAmuletoDefesa;
        private System.Windows.Forms.PictureBox pbxAmuletoEspinhos;
        private System.Windows.Forms.PictureBox pbxAmuletoCura;
        private System.Windows.Forms.Button btnInfo1;
        private System.Windows.Forms.Button btnInfo2;
        private System.Windows.Forms.Button btnInfo3;
        private System.Windows.Forms.Button btnInfo4;
        private System.Windows.Forms.Button btnInfo5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

