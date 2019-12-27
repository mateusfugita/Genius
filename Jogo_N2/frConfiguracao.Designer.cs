namespace Jogo_N2
{
    partial class frConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frConfiguracao));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdDificil = new System.Windows.Forms.RadioButton();
            this.rdMedio = new System.Windows.Forms.RadioButton();
            this.rdFacil = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSomOn = new System.Windows.Forms.Button();
            this.btnSomOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dificuldade";
            // 
            // rdDificil
            // 
            this.rdDificil.AutoSize = true;
            this.rdDificil.Location = new System.Drawing.Point(70, 85);
            this.rdDificil.Name = "rdDificil";
            this.rdDificil.Size = new System.Drawing.Size(52, 17);
            this.rdDificil.TabIndex = 10;
            this.rdDificil.Text = "Difícil";
            this.rdDificil.UseVisualStyleBackColor = true;
            // 
            // rdMedio
            // 
            this.rdMedio.AutoSize = true;
            this.rdMedio.Location = new System.Drawing.Point(70, 62);
            this.rdMedio.Name = "rdMedio";
            this.rdMedio.Size = new System.Drawing.Size(54, 17);
            this.rdMedio.TabIndex = 9;
            this.rdMedio.Text = "Médio";
            this.rdMedio.UseVisualStyleBackColor = true;
            // 
            // rdFacil
            // 
            this.rdFacil.AutoSize = true;
            this.rdFacil.Location = new System.Drawing.Point(70, 39);
            this.rdFacil.Name = "rdFacil";
            this.rdFacil.Size = new System.Drawing.Size(47, 17);
            this.rdFacil.TabIndex = 8;
            this.rdFacil.Text = "Fácil";
            this.rdFacil.UseVisualStyleBackColor = true;
            this.rdFacil.CheckedChanged += new System.EventHandler(this.rdFacil_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSomOn);
            this.groupBox2.Controls.Add(this.btnSomOff);
            this.groupBox2.Location = new System.Drawing.Point(62, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Som";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSomOn
            // 
            this.btnSomOn.Location = new System.Drawing.Point(23, 43);
            this.btnSomOn.Name = "btnSomOn";
            this.btnSomOn.Size = new System.Drawing.Size(50, 50);
            this.btnSomOn.TabIndex = 4;
            this.btnSomOn.Text = "On";
            this.btnSomOn.UseVisualStyleBackColor = true;
            this.btnSomOn.Click += new System.EventHandler(this.btnSomOn_Click);
            // 
            // btnSomOff
            // 
            this.btnSomOff.Location = new System.Drawing.Point(108, 44);
            this.btnSomOff.Name = "btnSomOff";
            this.btnSomOff.Size = new System.Drawing.Size(50, 50);
            this.btnSomOff.TabIndex = 5;
            this.btnSomOff.Text = "Off";
            this.btnSomOff.UseVisualStyleBackColor = true;
            this.btnSomOff.Click += new System.EventHandler(this.btnSomOff_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rdFacil);
            this.groupBox3.Controls.Add(this.rdMedio);
            this.groupBox3.Controls.Add(this.rdDificil);
            this.groupBox3.Location = new System.Drawing.Point(49, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // frConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(304, 286);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frConfiguracao_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdDificil;
        private System.Windows.Forms.RadioButton rdMedio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSomOn;
        private System.Windows.Forms.Button btnSomOff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdFacil;
    }
}