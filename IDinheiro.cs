using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface IDinheiro
    {
        int NotaValor { get; set; }
        void CalculaSaqueMesmaNota(ValorSaque valorSaque);
        void RetornaSaqueMesmaNota(ValorSaque valorSaque);
    }
}
