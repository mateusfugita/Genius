namespace Jogo_N2
{
    partial class frFacil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFacil));
            this.btnVermelho = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVermelho
            // 
            this.btnVermelho.BackColor = System.Drawing.Color.Red;
            this.btnVermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVermelho.Location = new System.Drawing.Point(158, 62);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(82, 82);
            this.btnVermelho.TabIndex = 0;
            this.btnVermelho.UseVisualStyleBackColor = false;
            this.btnVermelho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVermelho_MouseDown);
            this.btnVermelho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVermelho_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzul.Location = new System.Drawing.Point(285, 173);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(82, 82);
            this.btnAzul.TabIndex = 1;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAzul_MouseDown);
            this.btnAzul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAzul_MouseUp);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarelo.Location = new System.Drawing.Point(285, 62);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(82, 82);
            this.btnAmarelo.TabIndex = 2;
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAmarelo_MouseDown);
            this.btnAmarelo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAmarelo_MouseUp);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Location = new System.Drawing.Point(158, 173);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(82, 82);
            this.btnVerde.TabIndex = 3;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseDown);
            this.btnVerde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerde_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pontuação:";
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(228, 298);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 6;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Black;
            this.lblPontuacao.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(139, 9);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(19, 20);
            this.lblPontuacao.TabIndex = 7;
            this.lblPontuacao.Text = "0";
            // 
            // frFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_N2.Properties.Resources.Smaller_Brain_Meme2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVermelho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frFacil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius: Fácil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frFacil_FormClosing);
            this.Load += new System.EventHandler(this.frFacil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.Label lblPontuacao;
    }
}