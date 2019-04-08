using System;
using System.Collections.Generic;
using System.Text;

namespace TesteEGS
{
    class Produto {

        public string Nome;
        public double Preco;
        public double Desconto;
        public double TotalDesconto;

        public double DescontoProduto() {

            Desconto = 0.6 * Preco;
            return Desconto;

        }

        public double ValorComDesconto() {
            TotalDesconto = Preco - Desconto;

            return TotalDesconto;

        }

    }

    
}
