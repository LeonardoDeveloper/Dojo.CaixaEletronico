using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Notas
{
    public class NotaDez : IDinheiro
    {
        public int NotaValor { get; set; }

        public NotaDez()
        {
            NotaValor = 10;
        }
        public void CalculaSaqueMesmaNota(ValorSaque valorSaque)
        {
            if ((valorSaque.Valor % NotaValor) == 0)
                RetornaSaqueMesmaNota(valorSaque);

        }

        public void RetornaSaqueMesmaNota(ValorSaque valorSaque)
        {
            int quantidadeNotas = valorSaque.Valor / NotaValor;
            Console.WriteLine($"{quantidadeNotas} notas de {NotaValor}");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
