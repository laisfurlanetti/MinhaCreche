using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCreche
{
    class Crianca
    {
        public string Nome {get; set;}
        public int Idade { get; set; }
        public bool ContemUniforme { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Turma { get; set; }

        public void CadastrarCrianca() { }
        public void InativarCrianca() { }
        public void AtualizarCadastro() { }
        public void CadastrarAdvertencia() { }
    }
}
