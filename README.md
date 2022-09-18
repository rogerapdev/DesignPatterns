# DesignPatterns
Design Patterns - C#


São soluções típicas para problemas comuns em projeto de software. Eles são como plantas de obra pré fabricadas que você pode customizar para resolver um problema de projeto recorrente em seu código.


## Decorator

Permite que você acople novos comportamentos para objetos ao colocá-los dentro de invólucros de objetos que contém os comportamentos

Herança
- É estática, não se pode alterar o comportamento de um objeto durante a execução
- Só poder substituir todo o objeto por outro que foi criado de uma sub-classe diferente
- Uma sub-classe só pode ter uma classe pai

Agregação/Composição
- Permite substituir um objeto por outros mudando o comportamento durante o tempo de execução


## Observer

Permite que você defina um mecanismo de assinatura para notificar múltiplos objetos sobre quaisquer eventos que aconteçam com o objeto que eles estão observando


## Abstract Factory

Permite a criação de famílias de objetos relacionados ou dependentes por meio de uma única interface e sem que a classe concreta seja especificada


## Factory Method

Fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados


## Facade

Fornece uma interface simplificada para uma biblioteca, um framework, ou qualquer conjunto complexo de classes


## Referências

- https://refactoring.guru/pt-br/design-patterns
- https://www.youtube.com/playlist?list=PLfpYVugeLJLYxmNUhOdRzkr1sSDoHALdA
- https://www.dofactory.com/net/design-patterns
