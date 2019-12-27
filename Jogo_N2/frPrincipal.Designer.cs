namespace Jogo_N2
{
    partial class frPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPrincipal));
            this.btnJogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnComoJogar = new System.Windows.Forms.Button();
            this.btnRecorde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(180, 87);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(136, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genius";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(180, 240);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(136, 23);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Location = new System.Drawing.Point(180, 189);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(136, 23);
            this.btnConfiguracoes.TabIndex = 3;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnComoJogar
            // 
            this.btnComoJogar.Location = new System.Drawing.Point(180, 138);
            this.btnComoJogar.Name = "btnComoJogar";
            this.btnComoJogar.Size = new System.Drawing.Size(136, 23);
            this.btnComoJogar.TabIndex = 4;
            this.btnComoJogar.Text = "Como jogar";
            this.btnComoJogar.UseVisualStyleBackColor = true;
            this.btnComoJogar.Click += new System.EventHandler(this.btnComoJogar_Click);
            // 
            // btnRecorde
            // 
            this.btnRecorde.Location = new System.Drawing.Point(180, 291);
            this.btnRecorde.Name = "btnRecorde";
            this.btnRecorde.Size = new System.Drawing.Size(136, 23);
            this.btnRecorde.TabIndex = 5;
            this.btnRecorde.Text = "Recordes";
            this.btnRecorde.UseVisualStyleBackColor = true;
            this.btnRecorde.Click += new System.EventHandler(this.btnRecorde_Click);
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_N2.Properties.Resources.Genius;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.btnRecorde);
            this.Controls.Add(this.btnComoJogar);
            this.Controls.Add(this.btnConfiguracoes);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJogar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnComoJogar;
        private System.Windows.Forms.Button btnRecorde;
    }
}

