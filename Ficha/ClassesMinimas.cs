using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
        public class Poder
        {
            public string Nome { get; set; }
            public string Tipo { get; set; } // Passivo / Ativo
            public string Descricao { get; set; }

            public override string ToString() => Nome;
        

    }
    /// <summary>
    /// 
    /// </summary>
    public class Ritual
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Elemento { get; set; }
        public string Execucao { get; set; }
        public string Alcance { get; set; }
        public string Area { get; set; }
        public string Duracao { get; set; }
        public string Resistencia { get; set; }
        public string Efeito { get; set; }

        public override string ToString() => Nome;
    }
    /// <summary>
    /// 
    /// </summary>
    public class ItemInventario
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public string Efeito { get; set; }

        public override string ToString()
            => Quantidade > 1 ? $"{Nome} x{Quantidade}" : Nome;


    }
    /// <summary>
    /// 
    /// </summary>
    public class Ataque
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Dano { get; set; }
        public string Tipo { get; set; }
        public string Observacoes { get; set; }

        public override string ToString() => Nome;
    }

    public class Pericias
    {
        public string Nome { get; set; }
        public string Atributo { get; set; }
        public string Descricao { get; set; }
        public string Bonus { get; set; }
    }
}
