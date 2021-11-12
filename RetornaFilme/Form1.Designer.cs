
namespace RetornaFilme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRomance = new System.Windows.Forms.Button();
            this.btnComedia = new System.Windows.Forms.Button();
            this.btnDrama = new System.Windows.Forms.Button();
            this.btnTerror = new System.Windows.Forms.Button();
            this.btnAventura = new System.Windows.Forms.Button();
            this.btnAcao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetornaFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRomanceAleatorio = new System.Windows.Forms.Button();
            this.btnComediaAleatorio = new System.Windows.Forms.Button();
            this.btnDramaAleatorio = new System.Windows.Forms.Button();
            this.btnTerrorAleatorio = new System.Windows.Forms.Button();
            this.btnAventuraAleatoria = new System.Windows.Forms.Button();
            this.btnAcaoAleatorio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnRomance);
            this.panel1.Controls.Add(this.btnComedia);
            this.panel1.Controls.Add(this.btnDrama);
            this.panel1.Controls.Add(this.btnTerror);
            this.panel1.Controls.Add(this.btnAventura);
            this.panel1.Controls.Add(this.btnAcao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 163);
            this.panel1.TabIndex = 0;
            // 
            // btnRomance
            // 
            this.btnRomance.Location = new System.Drawing.Point(214, 115);
            this.btnRomance.Name = "btnRomance";
            this.btnRomance.Size = new System.Drawing.Size(75, 23);
            this.btnRomance.TabIndex = 6;
            this.btnRomance.Text = "Romance";
            this.btnRomance.UseVisualStyleBackColor = true;
            this.btnRomance.Click += new System.EventHandler(this.btnRomance_Click);
            // 
            // btnComedia
            // 
            this.btnComedia.Location = new System.Drawing.Point(111, 115);
            this.btnComedia.Name = "btnComedia";
            this.btnComedia.Size = new System.Drawing.Size(75, 23);
            this.btnComedia.TabIndex = 5;
            this.btnComedia.Text = "Comédia";
            this.btnComedia.UseVisualStyleBackColor = true;
            this.btnComedia.Click += new System.EventHandler(this.btnComedia_Click);
            // 
            // btnDrama
            // 
            this.btnDrama.Location = new System.Drawing.Point(14, 115);
            this.btnDrama.Name = "btnDrama";
            this.btnDrama.Size = new System.Drawing.Size(75, 23);
            this.btnDrama.TabIndex = 4;
            this.btnDrama.Text = "Drama";
            this.btnDrama.UseVisualStyleBackColor = true;
            this.btnDrama.Click += new System.EventHandler(this.btnDrama_Click);
            // 
            // btnTerror
            // 
            this.btnTerror.Location = new System.Drawing.Point(214, 61);
            this.btnTerror.Name = "btnTerror";
            this.btnTerror.Size = new System.Drawing.Size(75, 23);
            this.btnTerror.TabIndex = 3;
            this.btnTerror.Text = "Terror";
            this.btnTerror.UseVisualStyleBackColor = true;
            this.btnTerror.Click += new System.EventHandler(this.btnTerror_Click);
            // 
            // btnAventura
            // 
            this.btnAventura.Location = new System.Drawing.Point(111, 61);
            this.btnAventura.Name = "btnAventura";
            this.btnAventura.Size = new System.Drawing.Size(75, 23);
            this.btnAventura.TabIndex = 2;
            this.btnAventura.Text = "Aventura";
            this.btnAventura.UseVisualStyleBackColor = true;
            this.btnAventura.Click += new System.EventHandler(this.btnAventura_Click);
            // 
            // btnAcao
            // 
            this.btnAcao.Location = new System.Drawing.Point(14, 61);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(75, 23);
            this.btnAcao.TabIndex = 1;
            this.btnAcao.Text = "Ação";
            this.btnAcao.UseVisualStyleBackColor = true;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o gênero do filme :";
            // 
            // txtRetornaFilme
            // 
            this.txtRetornaFilme.Location = new System.Drawing.Point(371, 28);
            this.txtRetornaFilme.Multiline = true;
            this.txtRetornaFilme.Name = "txtRetornaFilme";
            this.txtRetornaFilme.ReadOnly = true;
            this.txtRetornaFilme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRetornaFilme.Size = new System.Drawing.Size(417, 410);
            this.txtRetornaFilme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indicação aleatória:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btnRomanceAleatorio);
            this.panel2.Controls.Add(this.btnComediaAleatorio);
            this.panel2.Controls.Add(this.btnDramaAleatorio);
            this.panel2.Controls.Add(this.btnTerrorAleatorio);
            this.panel2.Controls.Add(this.btnAventuraAleatoria);
            this.panel2.Controls.Add(this.btnAcaoAleatorio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 150);
            this.panel2.TabIndex = 3;
            // 
            // btnRomanceAleatorio
            // 
            this.btnRomanceAleatorio.Location = new System.Drawing.Point(214, 107);
            this.btnRomanceAleatorio.Name = "btnRomanceAleatorio";
            this.btnRomanceAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnRomanceAleatorio.TabIndex = 7;
            this.btnRomanceAleatorio.Text = "Romance";
            this.btnRomanceAleatorio.UseVisualStyleBackColor = true;
            this.btnRomanceAleatorio.Click += new System.EventHandler(this.btnRomanceAleatorio_Click);
            // 
            // btnComediaAleatorio
            // 
            this.btnComediaAleatorio.Location = new System.Drawing.Point(111, 107);
            this.btnComediaAleatorio.Name = "btnComediaAleatorio";
            this.btnComediaAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnComediaAleatorio.TabIndex = 7;
            this.btnComediaAleatorio.Text = "Comédia";
            this.btnComediaAleatorio.UseVisualStyleBackColor = true;
            this.btnComediaAleatorio.Click += new System.EventHandler(this.btnComediaAleatorio_Click);
            // 
            // btnDramaAleatorio
            // 
            this.btnDramaAleatorio.Location = new System.Drawing.Point(14, 107);
            this.btnDramaAleatorio.Name = "btnDramaAleatorio";
            this.btnDramaAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnDramaAleatorio.TabIndex = 7;
            this.btnDramaAleatorio.Text = "Drama";
            this.btnDramaAleatorio.UseVisualStyleBackColor = true;
            this.btnDramaAleatorio.Click += new System.EventHandler(this.btnDramaAleatorio_Click);
            // 
            // btnTerrorAleatorio
            // 
            this.btnTerrorAleatorio.Location = new System.Drawing.Point(214, 50);
            this.btnTerrorAleatorio.Name = "btnTerrorAleatorio";
            this.btnTerrorAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnTerrorAleatorio.TabIndex = 7;
            this.btnTerrorAleatorio.Text = "Terror";
            this.btnTerrorAleatorio.UseVisualStyleBackColor = true;
            this.btnTerrorAleatorio.Click += new System.EventHandler(this.btnTerrorAleatorio_Click);
            // 
            // btnAventuraAleatoria
            // 
            this.btnAventuraAleatoria.Location = new System.Drawing.Point(111, 50);
            this.btnAventuraAleatoria.Name = "btnAventuraAleatoria";
            this.btnAventuraAleatoria.Size = new System.Drawing.Size(75, 23);
            this.btnAventuraAleatoria.TabIndex = 7;
            this.btnAventuraAleatoria.Text = "Aventura";
            this.btnAventuraAleatoria.UseVisualStyleBackColor = true;
            this.btnAventuraAleatoria.Click += new System.EventHandler(this.btnAventuraAleatoria_Click);
            // 
            // btnAcaoAleatorio
            // 
            this.btnAcaoAleatorio.Location = new System.Drawing.Point(14, 50);
            this.btnAcaoAleatorio.Name = "btnAcaoAleatorio";
            this.btnAcaoAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAcaoAleatorio.TabIndex = 3;
            this.btnAcaoAleatorio.Text = "Ação";
            this.btnAcaoAleatorio.UseVisualStyleBackColor = true;
            this.btnAcaoAleatorio.Click += new System.EventHandler(this.btnAcaoAleatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRetornaFilme);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRomance;
        private System.Windows.Forms.Button btnComedia;
        private System.Windows.Forms.Button btnDrama;
        private System.Windows.Forms.Button btnTerror;
        private System.Windows.Forms.Button btnAventura;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetornaFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDramaAleatorio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTerrorAleatorio;
        private System.Windows.Forms.Button btnAventuraAleatoria;
        private System.Windows.Forms.Button btnAcaoAleatorio;
        private System.Windows.Forms.Button btnRomanceAleatorio;
        private System.Windows.Forms.Button btnComediaAleatorio;
    }
}

