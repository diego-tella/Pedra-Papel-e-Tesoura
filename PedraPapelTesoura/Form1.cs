using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        int PcPontos = 0;
        int VcPontos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void PicPedra_Click(object sender, EventArgs e)
        {
            Jogada("pedra");
            PicPedraVerm.Visible = true;
        }

        private void PicPapel_Click(object sender, EventArgs e)
        {
            Jogada("papel");
            PicPapelVerm.Visible = true;
        }

        private void PicTesoura_Click(object sender, EventArgs e)
        {
            Jogada("tesoura");
            PicTesouraVerm.Visible = true;
        }
        private void Jogada(string qual)
        {
            PicAdversario.Visible = true;
            LblEscolha.Text = "Esperando adversário...";
            Random r = new Random();
            int rand = r.Next(0, 3);
            if(rand == 0)
            {
                PicAdversario.Image = Properties.Resources.papel;
                if (qual == "papel") 
                    Empate();
                else if (qual != "tesoura")
                    Perdeu();
                else
                    Ganhou();
            }
            else if(rand == 1)
            {
                PicAdversario.Image = Properties.Resources.pedra;
                if (qual == "pedra") 
                    Empate();
                else if (qual != "papel")
                    Perdeu();
                else
                    Ganhou();
            }
            else if(rand == 2)
            {
                PicAdversario.Image = Properties.Resources.tesoura;
                if (qual == "tesoura") 
                    Empate();
                else if (qual != "pedra")
                    Perdeu();
                else
                    Ganhou();
            }
        }
        private void Perdeu()
        {
            Desativa(false);
            LblEscolha.ForeColor = Color.Red;
            LblEscolha.Text = "Você perdeu!";
            JogarNovamente.Enabled = true;
            PcPontos++;
            Acrescenta(PcPontos, VcPontos);
        }
        private void Ganhou()
        {
            Desativa(false);
            LblEscolha.ForeColor = Color.Green;
            LblEscolha.Text = "Você ganhou!";
            JogarNovamente.Enabled = true;
            VcPontos++;
            Acrescenta(PcPontos, VcPontos);
        }
        private void Empate()
        {
            Desativa(false);
            LblEscolha.Text = "Você Empatou!!";
            JogarNovamente.Enabled = true;
        }
        private void JogarNovamente_Click(object sender, EventArgs e)
        {
            Desativa(true);
            LblEscolha.ForeColor = Color.Black;
            LblEscolha.Text = "Escolha o seu!";
            PicAdversario.Visible = false;
            JogarNovamente.Enabled = false;
            foreach (var c in this.Controls.OfType<PictureBox>())
            {
                if (c.Name.Contains("Verm"))
                    c.Visible = false;
            }
        }
        private void Acrescenta(int pc, int vc)
        {
            LblPC.Text = "Computador: " + pc.ToString();
            LblVC.Text = "Você:" + vc.ToString();
        }
        private void Desativa(bool b)
        {
            foreach (var c in this.Controls.OfType<PictureBox>())
                c.Enabled = b;
        }
        //As funções abaixo serve para modificar o cursor do mouse ao botar o mouse em cima de uma das opções de escolha
        private void PicPedra_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void PicPapel_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void PicTesoura_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
