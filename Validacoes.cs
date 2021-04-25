using CaixaEletronico.Notas;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class Validacoes
    {
        private ValorSaque ValorSaque { get; set; }
        private IDinheiro nota10;
        private IDinheiro nota20;
        private IDinheiro nota50;
        private IDinheiro nota100;
        public Validacoes(ValorSaque valorSaque)
        {
            this.ValorSaque = valorSaque;
            nota10 = new NotaDez();
            nota20 = new NotaVinte();
            nota50 = new NotaCinquenta();
            nota100 = new NotaCem();

        }

        public bool ValorSaqueMinimo()
        {
            return ValorSaque.Valor >= 10;
        }

        // Verifica se a ultima casa decimal está <> 0
        public bool SaqueInformadoCorreto()
        {
            return ValorSaque.Valor.ToString().EndsWith('0');
        }

        public void VerificaCalculoMesmaNota()
        {

            nota100.CalculaSaqueMesmaNota(ValorSaque);
            nota50.CalculaSaqueMesmaNota(ValorSaque);
            nota20.CalculaSaqueMesmaNota(ValorSaque);
            nota10.CalculaSaqueMesmaNota(ValorSaque);
        }

        public string RealizaCalculoNotasDiferentes()
        {
            int saque = ValorSaque.Valor;
            int contNota10 = 0;
            int contNota20 = 0;
            int contNota50 = 0;
            int contNota100 = 0;

            while(saque > 0)
            {
                if (saque >= nota100.NotaValor)
                {
                    contNota100 = saque / nota100.NotaValor;
                    saque = saque % nota100.NotaValor;
                }
                else if (saque >= nota50.NotaValor)
                {
                    contNota50 = saque / nota50.NotaValor;
                    saque = saque % nota50.NotaValor;
                }
                else if (saque >= nota20.NotaValor)
                {
                    contNota20 = saque / nota20.NotaValor;
                    saque = saque % nota20.NotaValor;
                }
                else if(saque >= nota10.NotaValor)
                {
                    contNota10 = saque / nota10.NotaValor;
                    saque = saque % nota10.NotaValor;
                }
            }

            return $"Saque: {contNota100} Nota(s) de 100 \n" +
                $"{contNota50} Nota(s) de 50 \n" +
                $"{contNota20} Nota(s) de 20 \n" +
                $"{contNota10} Nota(s) de 10 \n";
        }
    }
}
