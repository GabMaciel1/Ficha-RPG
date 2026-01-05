using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Personagem
    {  
        // Identidade
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Origem { get; set; }
        public int Nex { get; set; }

        //  propriedades usadas em Form2
        public string Trilha { get; set; }
        public string NomeJogador { get; set; }

        public int Prestigio { get; set; }
        public string GetPatente( int prestigio)
        {
            if (prestigio <= 0)
                return "Recruta";
            else if (prestigio >= 20)
                return "Operador";
            else if (prestigio >= 50)
                return "Agente Especial";
            else if (prestigio <= 100)
                return "Oficial de Operacoes";
            else
                return "agente de elite";
        }

      
        public string Elemento { get; set; }
        public int XP { get; set; }
        public int PM { get; set; }

        // Atributos
        public int Agilidade { get; set; }
        public int Forca { get; set; }
        public int Intelecto { get; set; }
        public int Presenca { get; set; }
        public int Vigor { get; set; }

        // Recursos
        public int VidaAtual { get; set; }
        public int VidaMax { get; set; }

        public int SanidadeAtual { get; set; }
        public int SanidadeMax { get; set; }

        public int EsforcoAtual { get; set; }
        public int EsforcoMax { get; set; }

        // Defesa
        public int Defesa { get; set; }
        public int Bloqueio { get; set; }
        public int Esquiva { get; set; }

        // Abas futuras
        public List<Ataque> Ataques { get; set; }
        public List<Poder> Poderes { get; set; }
        public List<Ritual> Rituais { get; set; }
        public List<ItemInventario> Inventario { get; set; }

        public List<Pericias> Pericias { get; set; }

        public string[] HistoricoNotas { get; set; } = new string[2];


    public Personagem(string nome, string classe, string origem, int nex, string trilha, string nomeJogador, int prestigio, string elemento, int xP, int pM, int agilidade, int forca, int intelecto, int presenca, int vigor, int vidaAtual, int vidaMax, int sanidadeAtual, int sanidadeMax, int esforcoAtual, int esforcoMax, int defesa, int bloqueio, int esquiva, List<Ataque> ataques, List<Poder> poderes, List<Ritual> rituais, List<ItemInventario> inventario, string[] historicoNotas)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Classe = classe ?? throw new ArgumentNullException(nameof(classe));
            Origem = origem ?? throw new ArgumentNullException(nameof(origem));
            Nex = nex;
            Trilha = trilha ?? throw new ArgumentNullException(nameof(trilha));
            NomeJogador = nomeJogador ?? throw new ArgumentNullException(nameof(nomeJogador));
            Prestigio = prestigio;
            Elemento = (Nex != 0) ? elemento : null;
            XP = xP;
            PM = pM;
            Agilidade = agilidade;
            Forca = forca;
            Intelecto = intelecto;
            Presenca = presenca;
            Vigor = vigor;
            VidaAtual = vidaAtual;
            VidaMax = vidaMax;
            SanidadeAtual = sanidadeAtual;
            SanidadeMax = sanidadeMax;
            EsforcoAtual = esforcoAtual;
            EsforcoMax = esforcoMax;
            Defesa = defesa;
            Bloqueio = bloqueio;
            Esquiva = esquiva;
            Ataques = ataques ?? throw new ArgumentNullException(nameof(ataques));
            Poderes = poderes ?? throw new ArgumentNullException(nameof(poderes));
            Rituais = rituais ?? throw new ArgumentNullException(nameof(rituais));
            Inventario = inventario ?? throw new ArgumentNullException(nameof(inventario));
            HistoricoNotas = historicoNotas ?? throw new ArgumentNullException(nameof(historicoNotas));
        }
        public Personagem()
        {
        }
    }
}

