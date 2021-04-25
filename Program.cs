using CaixaEletronico.Notas;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Valor para saque: ");
            var valorSaque = new ValorSaque(int.Parse(Console.ReadLine()));

            var validacoes = new Validacoes(valorSaque);
            if (!validacoes.SaqueInformadoCorreto() && validacoes.ValorSaqueMinimo())
            {
                Console.WriteLine("Valor de saque inválido");
                return;
            }

            //validacoes.VerificaCalculoMesmaNota();

            Console.WriteLine(validacoes.RealizaCalculoNotasDiferentes());
            Console.ReadKey();









        }

    }
}
