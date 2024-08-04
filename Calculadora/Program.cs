using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();
            Stack<Operacoes> pilhaResultados = new Stack<Operacoes>();   // Pilha para armazenar as operações com resultados calculados
            
            while (filaOperacoes.Count > 0)    // Troca do >= para >, evitando a exceção de fila vazia ao final do loop
            {
                Operacoes operacao = filaOperacoes.Dequeue();   // Troca do Peek() por Dequeue() para remover o elemento da fila
                calculadora.calcular(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                ImprimirOperacoes(filaOperacoes);   // Adição da impressão da fila de operações após cada cálculo
                pilhaResultados.Push(operacao);     // Empilha operação calculada
            }

            ImprimirResultados(pilhaResultados);
           
        }

        // Método para imprimir a lista de operações
        static void ImprimirOperacoes(Queue<Operacoes> operacoes) {

            if (operacoes.Count == 0) Console.WriteLine("Não há nenhuma operação restante a ser processada.");
            else {
                Console.WriteLine("====================");
                Console.WriteLine("Operações restantes:");
                
                int i = 1;
                foreach (var operacao in operacoes) {
                    Console.WriteLine("{0}ª operação: {1} {2} {3}", i, operacao.valorA, operacao.operador, operacao.valorB);
                    i++;
                }

                Console.WriteLine("====================");
            }
        }

        // Método para imprimir a pilha de resultados
        static void ImprimirResultados(Stack<Operacoes> resultados) {
            if (resultados.Count == 0) Console.WriteLine("Não há resultados a serem exibidos.");
            else {
                int i = resultados.Count;
                Console.WriteLine("RESULTADOS FINAIS:");

                foreach (var operacao in resultados) {
                    Console.WriteLine("{0}ª operação: {1}", i, operacao.resultado);
                    i--;
                }
            }
            
        }
    }   
}
