namespace Jogo_N2
{
    partial class frDificil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDificil));
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tmrMovimento = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Navy;
            this.lblPontuacao.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(139, 9);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(19, 20);
            this.lblPontuacao.TabIndex = 9;
            this.lblPontuacao.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pontuação:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Navy;
            this.lblTempo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(461, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(19, 20);
            this.lblTempo.TabIndex = 11;
            this.lblTempo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tempo:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(228, 298);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 16;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Location = new System.Drawing.Point(158, 173);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(82, 82);
            this.btnVerde.TabIndex = 15;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseDown);
            this.btnVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseUp);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarelo.Location = new System.Drawing.Point(285, 62);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(82, 82);
            this.btnAmarelo.TabIndex = 14;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAmarelo_MouseDown);
            this.btnAmarelo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAmarelo_MouseUp);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Location = new System.Drawing.Point(285, 173);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(82, 82);
            this.btnAzul.TabIndex = 13;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAzul_MouseDown);
            this.btnAzul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAzul_MouseUp);
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVermelho.Location = new System.Drawing.Point(158, 62);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(82, 82);
            this.btnVermelho.TabIndex = 12;
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVermelho_MouseDown);
            this.btnVermelho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVermelho_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tmrMovimento
            // 
            this.tmrMovimento.Interval = 10;
            this.tmrMovimento.Tick += new System.EventHandler(this.tmrMovimento_Tick);
            // 
            // frDificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_N2.Properties.Resources.the_mind;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frDificil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius: Difícil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frDificil_FormClosing);
            this.Load += new System.EventHandler(this.frDificil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer tmrMovimento;
    }
}