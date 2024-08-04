# Calculadora
Case para Engenharia de Software JR (Solução - Eloisa Antero Guisse)

Problemas corrigidos e funcionalidades adicionadas no código:
  1. Aplicação só está processando o primeiro item da fila infinitamente.

  O problema se dava pois o método utilizado era o Peek(), que apenas captura o primeiro elemento da fila. Este foi substituido pelo método Dequeue(), que captura o primeiro elemento e imediatamente o remove da fila, permitindo que o loop não fique preso no mesmo elemento.

  2. Implemente a funcionalidade de divisão.

  A funcionalidade foi implementada na classe 'Calculadora'. Ela retorna o valor em decimal, para permitir o resultado correto em divisões não inteiras.

  3. Aplicação não está calculando a penultima operação corretamente.
     
  O tipo de retorno das operações foi substituido de 'int' para 'long', permitindo que as variáveis armazenem e consigam manipular valores maiores.

  5. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.

  Foi implementado um método na classe Program que imprime as operações restantes na fila.

  6. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final

  Foi criada uma pilha que empilha as operações com os resultados calculados. Ao final do código, é utilizado um método que imprime apenas os resultados de cada operação. Como foi especificada a estrutura de pilha, foi escolhido manter a ordem de empilhamento na hora da exibição dos resultados, evidenciando a ordem inversa das operações. 
