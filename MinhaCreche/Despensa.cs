using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCreche
{
    class Despensa
    {
        public string Produto { get; set; }
        public string Marca { get; set; }
        public string Fornecedor {get;set;}
        public bool AmbienteLimpo { get; set; }
        public int Quantidade { get; set; }
        public string NomeResponsavel { get; set; }

        public void CadastrarProduto() { }
        public void CadastrarFornecedor() { }
        public void InativarFornecedor() { }
        public void AtualizarResponsavel() { }
    }
}
