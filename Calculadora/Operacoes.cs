using System;
namespace Calculadora
{
    public class Operacoes
    {
        public long valorA {get;set;}    // Troca do int por long para o cálculo ser realizado corretamente para números grandes
        public char operador { get; set; }
        public long valorB { get; set; }
        public decimal resultado { get; set; }

    }
}
