using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCreche
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
        public string IdadeTurma { get; set; }
        public string AtividadeExtra { get; set; }

        public void CadastrarFuncionario() { }
        public void DemitirFuncionario() { }
        public void Promover() { }
        public void AtualizarCadastro() { }

    }
}
