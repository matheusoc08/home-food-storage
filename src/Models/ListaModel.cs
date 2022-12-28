using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_estoque.src.Models
{
    public class ListaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public bool Comprado { get; set; }
    }
}