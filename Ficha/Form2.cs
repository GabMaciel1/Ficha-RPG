using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //oculstimos, vontade, percepcao, tatica, fortitude, tecnologia e investigacao e medicina
    public partial class Form2 : Form
    {
        private Personagem personagem;

        public Form2(Personagem personagem)
        {
            InitializeComponent();
            this.personagem = personagem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

            lblDetalhesInventario.AutoSize = true;
            lblDetalhesInventario.MaximumSize = new Size(600, 0); // largura fixa
            lblDetalhesInventario.AutoEllipsis = false;

            lblDescricaoPericia.AutoSize = true;
            lblDescricaoPericia.MaximumSize = new Size(600, 0); // largura fixa, altura livre
            lblDescricaoPericia.AutoEllipsis = false;

            listBoxInventario.BorderStyle = BorderStyle.None;
         

            // MUITO IMPORTANTE:
            listBoxInventario.BackColor = Color.FromArgb(245, 245, 245);
            listBoxPoderesDisponiveis.BackColor = Color.FromArgb(245, 245, 245);
            listBoxRituaisDisponiveis.BackColor = Color.FromArgb(245, 245, 245);

            rTxtBxCadernoDireita.BackColor = Color.FromArgb(245, 245, 245);
            rTxtBxCadernoEsquerda.BackColor = Color.FromArgb(245, 245, 245);

            //tag para as listbox
            listBoxRituaisDisponiveis.Tag = TipoSelecao.Ritual;
            listBoxPoderesDisponiveis.Tag = TipoSelecao.Poder;
            listBoxInventario.Tag = TipoSelecao.Item;

            // DataSource das listas "disponíveis" (dados fixos)
            listBoxRituaisDisponiveis.DataSource = DadosFixos.Rituais;
            listBoxPoderesDisponiveis.DataSource = DadosFixos.Poderes;
          

            AtualizarTela();

            // preencher o ListView com as perícias
            PreencherListViewPericias();

            // preencher o ListBox com inventário do personagem
            PreencherListBoxInventario();
        }

        private void PreencherListViewPericias()
        {
            listViewPericias.BeginUpdate();
            listViewPericias.Clear();

            listViewPericias.View = View.Details;
            listViewPericias.FullRowSelect = true;
            listViewPericias.ShowItemToolTips = false;

            listViewPericias.Columns.Add("Nome", 220);
            listViewPericias.Columns.Add("Atributo", 70);
            listViewPericias.Columns.Add("Bônus", 60);

            foreach (var p in DadosFixos.Pericia)
            {
                var item = new ListViewItem(p.Nome ?? string.Empty);
                item.SubItems.Add(p.Atributo ?? string.Empty);
                item.SubItems.Add(p.Bonus ?? string.Empty);
                item.Tag = p;
                listViewPericias.Items.Add(item);
            }

            listViewPericias.EndUpdate();
        }

        private void PreencherListBoxInventario()
        {
            if (listBoxInventario == null || personagem == null)
                return;

            listBoxInventario.BeginUpdate();

            listBoxInventario.DataSource = null;
            listBoxInventario.DisplayMember = "Nome"; // ou use ToString()
            listBoxInventario.ValueMember = null;

            listBoxInventario.DataSource = personagem.Inventario;

            listBoxInventario.EndUpdate();
        }


        private void listViewPericias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPericias.SelectedItems.Count > 0)
            {
                var p = listViewPericias.SelectedItems[0].Tag as Pericias;
                if (p != null)
                {
                    if (this.Controls.ContainsKey("lblDescricaoPericia"))
                        this.Controls["lblDescricaoPericia"].Text = p.Descricao ?? string.Empty;
                }
                else
                {
                    if (this.Controls.ContainsKey("lblDescricaoPericia"))
                        this.Controls["lblDescricaoPericia"].Text = string.Empty;
                }
            }
            else
            {
                if (this.Controls.ContainsKey("lblDescricaoPericia"))
                    this.Controls["lblDescricaoPericia"].Text = string.Empty;
            }
        }

        private void listBoxInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxInventario.SelectedItem is ItemInventario it)
            {
                if (this.Controls.ContainsKey("lblDetalhesInventario"))
                    this.Controls["lblDetalhesInventario"].Text = it.Descricao ?? string.Empty;
            }
            else
            {
                if (this.Controls.ContainsKey("lblDetalhesInventario"))
                    this.Controls["lblDetalhesInventario"].Text = string.Empty;
            }
        }


        private void AtualizarTela()
        {
            lblPersonagemform2.Text = personagem.Nome;
            lblOrigemform2.Text = personagem.Origem;
            lblTrilhaform2.Text = personagem.Trilha;
            lblJogadorform2.Text = personagem.NomeJogador;
            lblClasseform2.Text = personagem.Classe;
            lblPatenteform2.Text = personagem.GetPatente(0);
            lblElementoform2.Text = personagem.Elemento;
            lblnexform2.Text = $"{personagem.Nex}";
            lblxpform2.Text = $"{personagem.XP}";
            lblpmform2.Text = $"{personagem.PM}";

            lblnexform2.Text = personagem.Nex.ToString();

         

            rTxtBxCadernoEsquerda.Text = personagem.HistoricoNotas[0];
            rTxtBxCadernoDireita.Text = personagem.HistoricoNotas[1];
            listBoxInventario.SelectedIndexChanged += listBoxInventario_SelectedIndexChanged;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void rTxtBxCadernoEsquerda_TextChanged(object sender, EventArgs e)
        {
            personagem.HistoricoNotas[0] = rTxtBxCadernoEsquerda.Text;
        }

        private void rTxtBxCadernoDireita_TextChanged(object sender, EventArgs e)
        {
            personagem.HistoricoNotas[1] = rTxtBxCadernoDireita.Text;
        }

        private void AtualizarListBox<T>(ListBox listBox, List<T> lista)
        {
            listBox.DataSource = null;
            listBox.DataSource = lista;
        }

        private void AdicionarItem<T>(
            ListBox listBoxDisponiveis,
            List<T> listaPersonagem,
            ListBox listBoxPersonagem)
        {
            if (listBoxDisponiveis.SelectedItem is T item)
            {
                if (!listaPersonagem.Contains(item))
                {
                    listaPersonagem.Add(item);
                    AtualizarListBox(listBoxPersonagem, listaPersonagem);
                }

                // se alterou inventario do personagem, atualiza listBoxInventario
                if (typeof(T) == typeof(ItemInventario))
                    PreencherListBoxInventario();
            }
        }

        private void RemoverItem<T>(
            ListBox listBoxPersonagem,
            List<T> listaPersonagem)
        {
            if (listBoxPersonagem.SelectedItem is T item)
            {
                listaPersonagem.Remove(item);
                AtualizarListBox(listBoxPersonagem, listaPersonagem);
            }

            // se alterou inventario do personagem, atualiza listBoxInventario
            if (typeof(T) == typeof(ItemInventario))
                PreencherListBoxInventario();
        }

        private enum TipoSelecao
        {
            Ritual,
            Poder,
            Item,
            Arma,
            Ataque
        }

        private TipoSelecao tipoAtual;

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBoxDisponiveis_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = $"Adicionar {tipoAtual}";
            btnRemover.Text = $"Remover {tipoAtual}";

            if (sender is ListBox lb && lb.Tag is TipoSelecao tipo)
            {
                tipoAtual = tipo;
                lblItemSelecionado.Text = $"Item Selecionado: {(lb.SelectedItem != null ? lb.SelectedItem.ToString() : "Nenhum")}";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            switch (tipoAtual)
            {
                case TipoSelecao.Ritual:
                    RemoverItem(listBoxRituaisPersonagem, personagem.Rituais);
                    break;

                case TipoSelecao.Poder:
                    RemoverItem(listBoxPoderesPersonagem, personagem.Poderes);
                    break;

               
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            switch (tipoAtual)
            {
                case TipoSelecao.Ritual:
                    AdicionarItem(listBoxRituaisDisponiveis, personagem.Rituais, listBoxRituaisPersonagem);
                    break;

                case TipoSelecao.Poder:
                    AdicionarItem(listBoxPoderesDisponiveis, personagem.Poderes, listBoxPoderesPersonagem);
                    break;

               
            }
        }

        private void tbpgCombate_Click(object sender, EventArgs e)
        {
        }

        private void ListBoxDisponiveis2_Click(object sender, EventArgs e)
        {
            if (sender is ListBox lb && lb.Tag is TipoSelecao tipo)
            {
                tipoAtual = tipo;
                lblDetalhesInventario.Text = $"Item Selecionado: {(lb.SelectedItem != null ? lb.SelectedItem.ToString() : "Nenhum")}";
            }
        }

        private void listBoxInventario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            if (listBoxInventario.SelectedItem is ItemInventario it)
            {
                lblDetalhesInventario.Text = it.Descricao ?? string.Empty;
            }
            else
            {
                lblDetalhesInventario.Text = string.Empty;
            
        }

    }

        private void listViewPericias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (listViewPericias.SelectedItems.Count == 0)
            {
                lblDescricaoPericia.Text = string.Empty;
                return;
            }

            if (listViewPericias.SelectedItems[0].Tag is Pericias p)
            {
                lblDescricaoPericia.Text = p.Descricao ?? string.Empty;
            }
        

    }
}
}









