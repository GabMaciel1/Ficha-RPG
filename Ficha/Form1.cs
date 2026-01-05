using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Personagem personagem;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            personagem = new Personagem
            {
                NomeJogador = "Gab",
                Nome = "Vicente",
                Classe = "Ocultista",
                Origem = "Vitima",
                Nex = 0,

                Agilidade = 2,
                Forca = 1,
                Intelecto = 3,
                Presenca = 2,
                Vigor = 1,

                VidaAtual = 13,
                VidaMax = 13,

                SanidadeAtual = 20,
                SanidadeMax = 20,

                EsforcoAtual = 6,
                EsforcoMax = 6,

                Defesa = 12, // 10 + AGI
                Bloqueio = 13, // VIG + Fortitude
                Esquiva = 19, // DEF + Reflexos

                //para forms2
                Prestigio = 0,
                Ataques = new List<Ataque>(),
                Poderes = new List<Poder>(),
                Rituais = new List<Ritual>(),
                Inventario = new List<ItemInventario>(DadosFixos.Itens),
                Pericias = new List<Pericias>()
            };


            AtualizarTela();

        }

        private void AtualizarTela()
        {
            lblNome.Text = personagem.Nome;
            lblClasse.Text = personagem.Classe;
            lblOrigem.Text = personagem.Origem;

            lblNex.Text = personagem.Nex.ToString();

            int vidaAtual = personagem.VidaAtual;
            lblBarraVida.Text = $"{GerarBarraASCII(ref vidaAtual, personagem.VidaMax)}";
            personagem.VidaAtual = vidaAtual;

            int sanidadeAtual = personagem.SanidadeAtual;
            lblBarraSanidade.Text = $"{GerarBarraASCII(ref sanidadeAtual, personagem.SanidadeMax)}";
            personagem.SanidadeAtual = sanidadeAtual;

            int esforcoAtual = personagem.EsforcoAtual;
            lblBarraEsforco.Text = $"{GerarBarraASCII(ref esforcoAtual, personagem.EsforcoMax)}";
            personagem.EsforcoAtual = esforcoAtual;

            label9.Text = personagem.Defesa.ToString();
            label11.Text = personagem.Bloqueio.ToString();
            label13.Text = personagem.Esquiva.ToString();

            AtualizarAtributos();
        }
        private void AtualizarAtributos()
        {
            var valores = new[]
            {
                personagem.Agilidade.ToString(),
                personagem.Forca.ToString(),
                personagem.Intelecto.ToString(),
                personagem.Presenca.ToString(),
                personagem.Vigor.ToString()
            };

            lblAtributosAParece.Text = $" {valores[0]}   {valores[1]}   {valores[2]}   {valores[3]}   {valores[4]}";
        }
        public static string GerarBarraASCII(ref int valorAtual, int valorMaximo, int? botarTirar = 0)
        {
            int tamanhoBarra = 15;

            if (valorMaximo <= 0)
                return "[░░░░░░░░░░░░░] 0 / 0";

            // aplica a alteração ao valor atual (ref altera a variável passada)
            valorAtual = valorAtual + (int)botarTirar;

            // garante limites
            if (valorAtual > valorMaximo) valorAtual = valorMaximo;
            if (valorAtual < 0) valorAtual = 0;

            double percentual = (double)valorAtual / valorMaximo;
            int preenchidos = (int)Math.Round(percentual * tamanhoBarra);

            if (preenchidos > tamanhoBarra)
                preenchidos = tamanhoBarra;

            if (preenchidos < 0)
                preenchidos = 0;

            string cheios = new string('█', preenchidos);
            string vazios = new string('░', tamanhoBarra - preenchidos);

            return $"[{cheios}{vazios}]  {valorAtual} / {valorMaximo}";
        }

        private void lblBotarVida_Click(object sender, EventArgs e)
        {
            int vidaAtual = personagem.VidaAtual;
            lblBarraVida.Text = GerarBarraASCII(ref vidaAtual, personagem.VidaMax, 1);
            personagem.VidaAtual = vidaAtual;
        }

        private void lblTirarVida_Click(object sender, EventArgs e)
        {
            int vidaAtual = personagem.VidaAtual;
            lblBarraVida.Text = GerarBarraASCII(ref vidaAtual, personagem.VidaMax, -1);
            personagem.VidaAtual = vidaAtual;
        }

        private void lblBotarSanidade_Click(object sender, EventArgs e)
        {
            int sanidadeAtual = personagem.SanidadeAtual;
            lblBarraSanidade.Text = GerarBarraASCII(ref sanidadeAtual, personagem.SanidadeMax, 1);
            personagem.SanidadeAtual = sanidadeAtual;
        }

        private void lblTirarSanidade_Click(object sender, EventArgs e)
        {
            int sanidadeAtual = personagem.SanidadeAtual;
            lblBarraSanidade.Text = GerarBarraASCII(ref sanidadeAtual, personagem.SanidadeMax, -1);
            personagem.SanidadeAtual = sanidadeAtual;
        }

        private void lblBotarEsforco_Click(object sender, EventArgs e)
        {
            int esforcoAtual = personagem.EsforcoAtual;
            lblBarraEsforco.Text = GerarBarraASCII(ref esforcoAtual, personagem.EsforcoMax, 1);
            personagem.EsforcoAtual = esforcoAtual;
        }

        private void lblTirarEsforco_Click(object sender, EventArgs e)
        {
            int esforcoAtual = personagem.EsforcoAtual;
            lblBarraEsforco.Text = GerarBarraASCII(ref esforcoAtual, personagem.EsforcoMax, -1);
            personagem.EsforcoAtual = esforcoAtual;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Corrigido: Color não é um construtor, use Color.FromArgb para criar uma cor personalizada.
            // Os valores devem ser inteiros (R, G, B).
            using (Pen pen = new Pen(Color.FromArgb(179, 165, 150)))
            {
                // Corrigido: DrawRectangle espera 1 Pen e 4 ints (x, y, width, height).
                e.Graphics.DrawRectangle(pen, 1, 0, this.Width - 2, this.Height - 1);
            }
        }
        private void lblFecharPrograma_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void lblProxPagina_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(personagem);
            form2.Show();
        }
    }
}