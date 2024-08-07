using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_6
{
    internal class Pessoa
    {
        public string Nome { get; set; } // O GET LÊ E O SET MODIFICA
        public string DataNasc {  get; set; } 
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropria { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }

        public override string ToString() // OVERRIDE SUBSTITUI
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }
    }
}
