namespace JogoDaForca
{
    partial class frmJogoDaForca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogoDaForca));
            this.btnStart = new System.Windows.Forms.Button();
            this.pnJogo = new System.Windows.Forms.Panel();
            this.pcbBonecoCompleto = new System.Windows.Forms.PictureBox();
            this.pcbBonecoPe = new System.Windows.Forms.PictureBox();
            this.pcbBonecoCorpo = new System.Windows.Forms.PictureBox();
            this.pcbBonecoMao = new System.Windows.Forms.PictureBox();
            this.pcbBonecoCorp = new System.Windows.Forms.PictureBox();
            this.pcbForca = new System.Windows.Forms.PictureBox();
            this.pcbBonecoCabeca = new System.Windows.Forms.PictureBox();
            this.btnGerarPalavra = new System.Windows.Forms.Button();
            this.grpDigiteLetra = new System.Windows.Forms.GroupBox();
            this.btnDica = new System.Windows.Forms.Button();
            this.txbLetrasDg = new System.Windows.Forms.TextBox();
            this.lbLetrasDg = new System.Windows.Forms.Label();
            this.pnDica = new System.Windows.Forms.Panel();
            this.lbDica = new System.Windows.Forms.Label();
            this.lbDicaT = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.lbPalavra = new System.Windows.Forms.Label();
            this.pnMsg = new System.Windows.Forms.Panel();
            this.pcbGameOver = new System.Windows.Forms.PictureBox();
            this.pcbWin = new System.Windows.Forms.PictureBox();
            this.btnPararMusica = new System.Windows.Forms.Button();
            this.btnVoltarMusica = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.pnJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoPe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCorpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoMao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCorp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCabeca)).BeginInit();
            this.grpDigiteLetra.SuspendLayout();
            this.pnDica.SuspendLayout();
            this.pnMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(226, 312);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(394, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar Jogo";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnJogo
            // 
            this.pnJogo.Controls.Add(this.pcbBonecoCompleto);
            this.pnJogo.Controls.Add(this.pcbBonecoPe);
            this.pnJogo.Controls.Add(this.pcbBonecoCorpo);
            this.pnJogo.Controls.Add(this.pcbBonecoMao);
            this.pnJogo.Controls.Add(this.pcbBonecoCorp);
            this.pnJogo.Controls.Add(this.pcbForca);
            this.pnJogo.Controls.Add(this.pcbBonecoCabeca);
            this.pnJogo.Controls.Add(this.btnGerarPalavra);
            this.pnJogo.Controls.Add(this.grpDigiteLetra);
            this.pnJogo.Controls.Add(this.txbPalavra);
            this.pnJogo.Controls.Add(this.lbPalavra);
            this.pnJogo.Location = new System.Drawing.Point(12, 6);
            this.pnJogo.Name = "pnJogo";
            this.pnJogo.Size = new System.Drawing.Size(805, 300);
            this.pnJogo.TabIndex = 1;
            this.pnJogo.Visible = false;
            // 
            // pcbBonecoCompleto
            // 
            this.pcbBonecoCompleto.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoCompleto.Image")));
            this.pcbBonecoCompleto.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoCompleto.Name = "pcbBonecoCompleto";
            this.pcbBonecoCompleto.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoCompleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoCompleto.TabIndex = 8;
            this.pcbBonecoCompleto.TabStop = false;
            this.pcbBonecoCompleto.Visible = false;
            // 
            // pcbBonecoPe
            // 
            this.pcbBonecoPe.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoPe.Image")));
            this.pcbBonecoPe.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoPe.Name = "pcbBonecoPe";
            this.pcbBonecoPe.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoPe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoPe.TabIndex = 9;
            this.pcbBonecoPe.TabStop = false;
            this.pcbBonecoPe.Visible = false;
            // 
            // pcbBonecoCorpo
            // 
            this.pcbBonecoCorpo.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoCorpo.Image")));
            this.pcbBonecoCorpo.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoCorpo.Name = "pcbBonecoCorpo";
            this.pcbBonecoCorpo.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoCorpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoCorpo.TabIndex = 7;
            this.pcbBonecoCorpo.TabStop = false;
            this.pcbBonecoCorpo.Visible = false;
            // 
            // pcbBonecoMao
            // 
            this.pcbBonecoMao.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoMao.Image")));
            this.pcbBonecoMao.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoMao.Name = "pcbBonecoMao";
            this.pcbBonecoMao.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoMao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoMao.TabIndex = 5;
            this.pcbBonecoMao.TabStop = false;
            this.pcbBonecoMao.Visible = false;
            // 
            // pcbBonecoCorp
            // 
            this.pcbBonecoCorp.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoCorp.Image")));
            this.pcbBonecoCorp.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoCorp.Name = "pcbBonecoCorp";
            this.pcbBonecoCorp.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoCorp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoCorp.TabIndex = 6;
            this.pcbBonecoCorp.TabStop = false;
            this.pcbBonecoCorp.Visible = false;
            // 
            // pcbForca
            // 
            this.pcbForca.Image = ((System.Drawing.Image)(resources.GetObject("pcbForca.Image")));
            this.pcbForca.Location = new System.Drawing.Point(610, 84);
            this.pcbForca.Name = "pcbForca";
            this.pcbForca.Size = new System.Drawing.Size(192, 213);
            this.pcbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbForca.TabIndex = 0;
            this.pcbForca.TabStop = false;
            this.pcbForca.Visible = false;
            // 
            // pcbBonecoCabeca
            // 
            this.pcbBonecoCabeca.Image = ((System.Drawing.Image)(resources.GetObject("pcbBonecoCabeca.Image")));
            this.pcbBonecoCabeca.Location = new System.Drawing.Point(610, 84);
            this.pcbBonecoCabeca.Name = "pcbBonecoCabeca";
            this.pcbBonecoCabeca.Size = new System.Drawing.Size(192, 213);
            this.pcbBonecoCabeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBonecoCabeca.TabIndex = 8;
            this.pcbBonecoCabeca.TabStop = false;
            this.pcbBonecoCabeca.Visible = false;
            // 
            // btnGerarPalavra
            // 
            this.btnGerarPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarPalavra.Location = new System.Drawing.Point(676, 31);
            this.btnGerarPalavra.Name = "btnGerarPalavra";
            this.btnGerarPalavra.Size = new System.Drawing.Size(123, 37);
            this.btnGerarPalavra.TabIndex = 5;
            this.btnGerarPalavra.Text = "Gerar Palavra";
            this.btnGerarPalavra.UseVisualStyleBackColor = true;
            this.btnGerarPalavra.Click += new System.EventHandler(this.btnGerarPalavra_Click);
            // 
            // grpDigiteLetra
            // 
            this.grpDigiteLetra.Controls.Add(this.btnDica);
            this.grpDigiteLetra.Controls.Add(this.txbLetrasDg);
            this.grpDigiteLetra.Controls.Add(this.lbLetrasDg);
            this.grpDigiteLetra.Controls.Add(this.pnDica);
            this.grpDigiteLetra.Controls.Add(this.btnVerificar);
            this.grpDigiteLetra.Controls.Add(this.txbLetra);
            this.grpDigiteLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDigiteLetra.Location = new System.Drawing.Point(8, 73);
            this.grpDigiteLetra.Name = "grpDigiteLetra";
            this.grpDigiteLetra.Size = new System.Drawing.Size(593, 224);
            this.grpDigiteLetra.TabIndex = 4;
            this.grpDigiteLetra.TabStop = false;
            this.grpDigiteLetra.Text = "Digite uma letra:";
            // 
            // btnDica
            // 
            this.btnDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDica.Location = new System.Drawing.Point(280, 86);
            this.btnDica.Name = "btnDica";
            this.btnDica.Size = new System.Drawing.Size(244, 37);
            this.btnDica.TabIndex = 9;
            this.btnDica.Text = "Mostrar Dica";
            this.btnDica.UseVisualStyleBackColor = true;
            this.btnDica.Click += new System.EventHandler(this.btnDica_Click);
            // 
            // txbLetrasDg
            // 
            this.txbLetrasDg.Enabled = false;
            this.txbLetrasDg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetrasDg.Location = new System.Drawing.Point(7, 173);
            this.txbLetrasDg.Name = "txbLetrasDg";
            this.txbLetrasDg.Size = new System.Drawing.Size(555, 29);
            this.txbLetrasDg.TabIndex = 8;
            this.txbLetrasDg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLetrasDg
            // 
            this.lbLetrasDg.AutoSize = true;
            this.lbLetrasDg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetrasDg.Location = new System.Drawing.Point(1, 134);
            this.lbLetrasDg.Name = "lbLetrasDg";
            this.lbLetrasDg.Size = new System.Drawing.Size(146, 24);
            this.lbLetrasDg.TabIndex = 7;
            this.lbLetrasDg.Text = "Letras Digitadas:";
            // 
            // pnDica
            // 
            this.pnDica.Controls.Add(this.lbDica);
            this.pnDica.Controls.Add(this.lbDicaT);
            this.pnDica.Location = new System.Drawing.Point(273, 14);
            this.pnDica.Name = "pnDica";
            this.pnDica.Size = new System.Drawing.Size(285, 52);
            this.pnDica.TabIndex = 5;
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(3, 27);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(21, 20);
            this.lbDica.TabIndex = 1;
            this.lbDica.Text = "\"\"";
            this.lbDica.Visible = false;
            // 
            // lbDicaT
            // 
            this.lbDicaT.AutoSize = true;
            this.lbDicaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDicaT.Location = new System.Drawing.Point(3, 3);
            this.lbDicaT.Name = "lbDicaT";
            this.lbDicaT.Size = new System.Drawing.Size(52, 24);
            this.lbDicaT.TabIndex = 0;
            this.lbDicaT.Text = "Dica:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(7, 81);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(212, 42);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbLetra
            // 
            this.txbLetra.Enabled = false;
            this.txbLetra.Location = new System.Drawing.Point(6, 37);
            this.txbLetra.MaxLength = 1;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(212, 29);
            this.txbLetra.TabIndex = 3;
            this.txbLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLetra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbLetra_KeyUp);
            // 
            // txbPalavra
            // 
            this.txbPalavra.Enabled = false;
            this.txbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(8, 29);
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(642, 38);
            this.txbPalavra.TabIndex = 2;
            this.txbPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPalavra
            // 
            this.lbPalavra.AutoSize = true;
            this.lbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalavra.Location = new System.Drawing.Point(3, 3);
            this.lbPalavra.Name = "lbPalavra";
            this.lbPalavra.Size = new System.Drawing.Size(209, 26);
            this.lbPalavra.TabIndex = 1;
            this.lbPalavra.Text = "Descubra a Palavra:";
            // 
            // pnMsg
            // 
            this.pnMsg.Controls.Add(this.pcbGameOver);
            this.pnMsg.Controls.Add(this.pcbWin);
            this.pnMsg.Location = new System.Drawing.Point(12, 6);
            this.pnMsg.Name = "pnMsg";
            this.pnMsg.Size = new System.Drawing.Size(805, 300);
            this.pnMsg.TabIndex = 5;
            this.pnMsg.Visible = false;
            // 
            // pcbGameOver
            // 
            this.pcbGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pcbGameOver.Image")));
            this.pcbGameOver.Location = new System.Drawing.Point(161, -3);
            this.pcbGameOver.Name = "pcbGameOver";
            this.pcbGameOver.Size = new System.Drawing.Size(519, 300);
            this.pcbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGameOver.TabIndex = 11;
            this.pcbGameOver.TabStop = false;
            this.pcbGameOver.Visible = false;
            // 
            // pcbWin
            // 
            this.pcbWin.Image = ((System.Drawing.Image)(resources.GetObject("pcbWin.Image")));
            this.pcbWin.Location = new System.Drawing.Point(115, 55);
            this.pcbWin.Name = "pcbWin";
            this.pcbWin.Size = new System.Drawing.Size(598, 197);
            this.pcbWin.TabIndex = 10;
            this.pcbWin.TabStop = false;
            this.pcbWin.Visible = false;
            // 
            // btnPararMusica
            // 
            this.btnPararMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararMusica.Location = new System.Drawing.Point(714, 310);
            this.btnPararMusica.Name = "btnPararMusica";
            this.btnPararMusica.Size = new System.Drawing.Size(100, 25);
            this.btnPararMusica.TabIndex = 3;
            this.btnPararMusica.Text = "Parar Música";
            this.btnPararMusica.UseVisualStyleBackColor = true;
            this.btnPararMusica.Visible = false;
            this.btnPararMusica.Click += new System.EventHandler(this.btnPararMusica_Click);
            // 
            // btnVoltarMusica
            // 
            this.btnVoltarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMusica.Location = new System.Drawing.Point(714, 339);
            this.btnVoltarMusica.Name = "btnVoltarMusica";
            this.btnVoltarMusica.Size = new System.Drawing.Size(102, 25);
            this.btnVoltarMusica.TabIndex = 4;
            this.btnVoltarMusica.Text = "Voltar Música";
            this.btnVoltarMusica.UseVisualStyleBackColor = true;
            this.btnVoltarMusica.Visible = false;
            this.btnVoltarMusica.Click += new System.EventHandler(this.btnVoltarMusica_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.Location = new System.Drawing.Point(12, 323);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(100, 25);
            this.btnRegras.TabIndex = 6;
            this.btnRegras.Text = "Regras";
            this.btnRegras.UseVisualStyleBackColor = true;
            this.btnRegras.Visible = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // frmJogoDaForca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(823, 367);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.pnMsg);
            this.Controls.Add(this.btnVoltarMusica);
            this.Controls.Add(this.btnPararMusica);
            this.Controls.Add(this.pnJogo);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJogoDaForca";
            this.Text = "Jogo Da Forca";
            this.pnJogo.ResumeLayout(false);
            this.pnJogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoPe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCorpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoMao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCorp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBonecoCabeca)).EndInit();
            this.grpDigiteLetra.ResumeLayout(false);
            this.grpDigiteLetra.PerformLayout();
            this.pnDica.ResumeLayout(false);
            this.pnDica.PerformLayout();
            this.pnMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnJogo;
        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.Label lbPalavra;
        private System.Windows.Forms.GroupBox grpDigiteLetra;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel pnDica;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Label lbDicaT;
        private System.Windows.Forms.TextBox txbLetrasDg;
        private System.Windows.Forms.Label lbLetrasDg;
        private System.Windows.Forms.Button btnGerarPalavra;
        private System.Windows.Forms.Button btnDica;
        private System.Windows.Forms.Button btnPararMusica;
        private System.Windows.Forms.Button btnVoltarMusica;
        private System.Windows.Forms.PictureBox pcbForca;
        private System.Windows.Forms.PictureBox pcbBonecoCompleto;
        private System.Windows.Forms.PictureBox pcbBonecoPe;
        private System.Windows.Forms.PictureBox pcbBonecoCorpo;
        private System.Windows.Forms.PictureBox pcbBonecoMao;
        private System.Windows.Forms.PictureBox pcbBonecoCorp;
        private System.Windows.Forms.PictureBox pcbBonecoCabeca;
        private System.Windows.Forms.PictureBox pcbGameOver;
        private System.Windows.Forms.PictureBox pcbWin;
        private System.Windows.Forms.Panel pnMsg;
        private System.Windows.Forms.Button btnRegras;
    }
}

