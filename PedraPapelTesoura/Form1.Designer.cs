namespace PedraPapelTesoura
{
    partial class Form1
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
            this.LblEscolha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPontos = new System.Windows.Forms.Label();
            this.LblPC = new System.Windows.Forms.Label();
            this.LblVC = new System.Windows.Forms.Label();
            this.JogarNovamente = new System.Windows.Forms.Button();
            this.PicPedraVerm = new System.Windows.Forms.PictureBox();
            this.PicAdversario = new System.Windows.Forms.PictureBox();
            this.PicTesoura = new System.Windows.Forms.PictureBox();
            this.PicPapel = new System.Windows.Forms.PictureBox();
            this.PicPedra = new System.Windows.Forms.PictureBox();
            this.PicPapelVerm = new System.Windows.Forms.PictureBox();
            this.PicTesouraVerm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPedraVerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdversario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPapelVerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTesouraVerm)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEscolha
            // 
            this.LblEscolha.AutoSize = true;
            this.LblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEscolha.Location = new System.Drawing.Point(134, 259);
            this.LblEscolha.Name = "LblEscolha";
            this.LblEscolha.Size = new System.Drawing.Size(192, 31);
            this.LblEscolha.TabIndex = 3;
            this.LblEscolha.Text = "Escolha o seu!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(493, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 409);
            this.panel1.TabIndex = 5;
            // 
            // LblPontos
            // 
            this.LblPontos.AutoSize = true;
            this.LblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPontos.Location = new System.Drawing.Point(496, 12);
            this.LblPontos.Name = "LblPontos";
            this.LblPontos.Size = new System.Drawing.Size(80, 26);
            this.LblPontos.TabIndex = 6;
            this.LblPontos.Text = "Pontos";
            // 
            // LblPC
            // 
            this.LblPC.AutoSize = true;
            this.LblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPC.Location = new System.Drawing.Point(496, 51);
            this.LblPC.Name = "LblPC";
            this.LblPC.Size = new System.Drawing.Size(114, 20);
            this.LblPC.TabIndex = 7;
            this.LblPC.Text = "Computador: 0";
            // 
            // LblVC
            // 
            this.LblVC.AutoSize = true;
            this.LblVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVC.Location = new System.Drawing.Point(497, 76);
            this.LblVC.Name = "LblVC";
            this.LblVC.Size = new System.Drawing.Size(63, 20);
            this.LblVC.TabIndex = 8;
            this.LblVC.Text = "Você: 0";
            // 
            // JogarNovamente
            // 
            this.JogarNovamente.Enabled = false;
            this.JogarNovamente.Location = new System.Drawing.Point(505, 363);
            this.JogarNovamente.Name = "JogarNovamente";
            this.JogarNovamente.Size = new System.Drawing.Size(110, 23);
            this.JogarNovamente.TabIndex = 9;
            this.JogarNovamente.Text = "Jogar Novamente";
            this.JogarNovamente.UseVisualStyleBackColor = true;
            this.JogarNovamente.Click += new System.EventHandler(this.JogarNovamente_Click);
            // 
            // PicPedraVerm
            // 
            this.PicPedraVerm.Image = global::PedraPapelTesoura.Properties.Resources.red;
            this.PicPedraVerm.Location = new System.Drawing.Point(57, 369);
            this.PicPedraVerm.Name = "PicPedraVerm";
            this.PicPedraVerm.Size = new System.Drawing.Size(17, 18);
            this.PicPedraVerm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPedraVerm.TabIndex = 10;
            this.PicPedraVerm.TabStop = false;
            this.PicPedraVerm.Visible = false;
            // 
            // PicAdversario
            // 
            this.PicAdversario.Location = new System.Drawing.Point(152, 12);
            this.PicAdversario.Name = "PicAdversario";
            this.PicAdversario.Size = new System.Drawing.Size(185, 155);
            this.PicAdversario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAdversario.TabIndex = 4;
            this.PicAdversario.TabStop = false;
            // 
            // PicTesoura
            // 
            this.PicTesoura.Image = global::PedraPapelTesoura.Properties.Resources.tesoura;
            this.PicTesoura.Location = new System.Drawing.Point(346, 315);
            this.PicTesoura.Name = "PicTesoura";
            this.PicTesoura.Size = new System.Drawing.Size(100, 50);
            this.PicTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicTesoura.TabIndex = 2;
            this.PicTesoura.TabStop = false;
            this.PicTesoura.Click += new System.EventHandler(this.PicTesoura_Click);
            this.PicTesoura.MouseHover += new System.EventHandler(this.PicTesoura_MouseHover);
            // 
            // PicPapel
            // 
            this.PicPapel.Image = global::PedraPapelTesoura.Properties.Resources.papel;
            this.PicPapel.Location = new System.Drawing.Point(182, 315);
            this.PicPapel.Name = "PicPapel";
            this.PicPapel.Size = new System.Drawing.Size(100, 50);
            this.PicPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPapel.TabIndex = 1;
            this.PicPapel.TabStop = false;
            this.PicPapel.Click += new System.EventHandler(this.PicPapel_Click);
            this.PicPapel.MouseHover += new System.EventHandler(this.PicPapel_MouseHover);
            // 
            // PicPedra
            // 
            this.PicPedra.Image = global::PedraPapelTesoura.Properties.Resources.pedra;
            this.PicPedra.Location = new System.Drawing.Point(12, 315);
            this.PicPedra.Name = "PicPedra";
            this.PicPedra.Size = new System.Drawing.Size(100, 50);
            this.PicPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPedra.TabIndex = 0;
            this.PicPedra.TabStop = false;
            this.PicPedra.Click += new System.EventHandler(this.PicPedra_Click);
            this.PicPedra.MouseHover += new System.EventHandler(this.PicPedra_MouseHover);
            // 
            // PicPapelVerm
            // 
            this.PicPapelVerm.Image = global::PedraPapelTesoura.Properties.Resources.red;
            this.PicPapelVerm.Location = new System.Drawing.Point(222, 369);
            this.PicPapelVerm.Name = "PicPapelVerm";
            this.PicPapelVerm.Size = new System.Drawing.Size(17, 18);
            this.PicPapelVerm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPapelVerm.TabIndex = 11;
            this.PicPapelVerm.TabStop = false;
            this.PicPapelVerm.Visible = false;
            // 
            // PicTesouraVerm
            // 
            this.PicTesouraVerm.Image = global::PedraPapelTesoura.Properties.Resources.red;
            this.PicTesouraVerm.Location = new System.Drawing.Point(390, 369);
            this.PicTesouraVerm.Name = "PicTesouraVerm";
            this.PicTesouraVerm.Size = new System.Drawing.Size(17, 18);
            this.PicTesouraVerm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTesouraVerm.TabIndex = 12;
            this.PicTesouraVerm.TabStop = false;
            this.PicTesouraVerm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 395);
            this.Controls.Add(this.PicTesouraVerm);
            this.Controls.Add(this.PicPapelVerm);
            this.Controls.Add(this.PicPedraVerm);
            this.Controls.Add(this.JogarNovamente);
            this.Controls.Add(this.LblVC);
            this.Controls.Add(this.LblPC);
            this.Controls.Add(this.LblPontos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicAdversario);
            this.Controls.Add(this.LblEscolha);
            this.Controls.Add(this.PicTesoura);
            this.Controls.Add(this.PicPapel);
            this.Controls.Add(this.PicPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel e Tesoura";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PicPedraVerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAdversario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPapelVerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTesouraVerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPedra;
        private System.Windows.Forms.PictureBox PicPapel;
        private System.Windows.Forms.PictureBox PicTesoura;
        private System.Windows.Forms.Label LblEscolha;
        private System.Windows.Forms.PictureBox PicAdversario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPontos;
        private System.Windows.Forms.Label LblPC;
        private System.Windows.Forms.Label LblVC;
        private System.Windows.Forms.Button JogarNovamente;
        private System.Windows.Forms.PictureBox PicPedraVerm;
        private System.Windows.Forms.PictureBox PicPapelVerm;
        private System.Windows.Forms.PictureBox PicTesouraVerm;
    }
}

