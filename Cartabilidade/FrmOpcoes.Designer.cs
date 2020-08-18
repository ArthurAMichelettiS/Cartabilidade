namespace Cartabilidade
{
    partial class FrmOpcoes
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
            this.lblTituloSobre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radExtremo = new System.Windows.Forms.RadioButton();
            this.radDificil = new System.Windows.Forms.RadioButton();
            this.radMedio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radSemSom = new System.Windows.Forms.RadioButton();
            this.radMus = new System.Windows.Forms.RadioButton();
            this.radTodoAudio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloSobre
            // 
            this.lblTituloSobre.AutoSize = true;
            this.lblTituloSobre.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSobre.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSobre.Location = new System.Drawing.Point(69, 17);
            this.lblTituloSobre.Name = "lblTituloSobre";
            this.lblTituloSobre.Size = new System.Drawing.Size(168, 53);
            this.lblTituloSobre.TabIndex = 5;
            this.lblTituloSobre.Text = "OPÇÕES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radExtremo);
            this.panel1.Controls.Add(this.radDificil);
            this.panel1.Controls.Add(this.radMedio);
            this.panel1.Location = new System.Drawing.Point(54, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 131);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIFICULDADE";
            // 
            // radExtremo
            // 
            this.radExtremo.AutoSize = true;
            this.radExtremo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExtremo.Location = new System.Drawing.Point(32, 100);
            this.radExtremo.Name = "radExtremo";
            this.radExtremo.Size = new System.Drawing.Size(99, 28);
            this.radExtremo.TabIndex = 2;
            this.radExtremo.TabStop = true;
            this.radExtremo.Text = "Extremo";
            this.radExtremo.UseVisualStyleBackColor = true;
            // 
            // radDificil
            // 
            this.radDificil.AutoSize = true;
            this.radDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDificil.Location = new System.Drawing.Point(32, 66);
            this.radDificil.Name = "radDificil";
            this.radDificil.Size = new System.Drawing.Size(71, 28);
            this.radDificil.TabIndex = 1;
            this.radDificil.TabStop = true;
            this.radDificil.Text = "Dificil";
            this.radDificil.UseVisualStyleBackColor = true;
            // 
            // radMedio
            // 
            this.radMedio.AutoSize = true;
            this.radMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedio.Location = new System.Drawing.Point(32, 32);
            this.radMedio.Name = "radMedio";
            this.radMedio.Size = new System.Drawing.Size(81, 28);
            this.radMedio.TabIndex = 0;
            this.radMedio.TabStop = true;
            this.radMedio.Text = "Medio";
            this.radMedio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.radSemSom);
            this.panel2.Controls.Add(this.radMus);
            this.panel2.Controls.Add(this.radTodoAudio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(54, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 131);
            this.panel2.TabIndex = 7;
            // 
            // radSemSom
            // 
            this.radSemSom.AutoSize = true;
            this.radSemSom.Location = new System.Drawing.Point(24, 98);
            this.radSemSom.Name = "radSemSom";
            this.radSemSom.Size = new System.Drawing.Size(84, 17);
            this.radSemSom.TabIndex = 7;
            this.radSemSom.TabStop = true;
            this.radSemSom.Text = "Desativados";
            this.radSemSom.UseVisualStyleBackColor = true;
            // 
            // radMus
            // 
            this.radMus.AutoSize = true;
            this.radMus.Location = new System.Drawing.Point(24, 75);
            this.radMus.Name = "radMus";
            this.radMus.Size = new System.Drawing.Size(59, 17);
            this.radMus.TabIndex = 6;
            this.radMus.TabStop = true;
            this.radMus.Text = "Música";
            this.radMus.UseVisualStyleBackColor = true;
            // 
            // radTodoAudio
            // 
            this.radTodoAudio.AutoSize = true;
            this.radTodoAudio.Location = new System.Drawing.Point(24, 52);
            this.radTodoAudio.Name = "radTodoAudio";
            this.radTodoAudio.Size = new System.Drawing.Size(142, 17);
            this.radTodoAudio.TabIndex = 5;
            this.radTodoAudio.TabStop = true;
            this.radTodoAudio.Text = "Música e efeitos sonoros";
            this.radTodoAudio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AUDIO";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(62, 371);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(175, 56);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Salvar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(315, 453);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloSobre);
            this.MaximizeBox = false;
            this.Name = "FrmOpcoes";
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.FrmOpcoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloSobre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radExtremo;
        private System.Windows.Forms.RadioButton radDificil;
        private System.Windows.Forms.RadioButton radMedio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radSemSom;
        private System.Windows.Forms.RadioButton radMus;
        private System.Windows.Forms.RadioButton radTodoAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
    }
}