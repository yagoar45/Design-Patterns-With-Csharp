# Exemplos de Design Patterns em C#

Este projeto contém exemplos práticos dos principais design patterns implementados em C#. Cada pasta neste repositório representa um tipo de pattern, e dentro de cada pasta você encontrará exemplos de uso correto e uso incorreto do respectivo design pattern.

## Lista de Design Patterns

Aqui está uma lista dos design patterns incluídos neste projeto:


- **Pasta `Strategy`**: O padrão Strategy define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. Isso permite que o algoritmo varie independentemente dos clientes que o utilizam.

- **Pasta `ChainOfResponsibility`**: O padrão Chain of Responsibility permite que você passe solicitações ao longo de uma cadeia de manipuladores, onde cada manipulador decide se pode processar a solicitação ou se deve passá-la para o próximo manipulador na cadeia.

- **Pasta `TemplateMethod`**: O padrão Template Method define o esqueleto de um algoritmo em uma classe base, permitindo que as subclasses forneçam implementações específicas para partes desse algoritmo.

- **Pasta `Decorator`**: O padrão Decorator permite adicionar comportamentos adicionais a um objeto dinamicamente, envolvendo-o em um objeto decorador especial que contém a funcionalidade extra.

- **Pasta `State`**: O padrão State permite que um objeto altere seu comportamento quando seu estado interno muda. Isso é alcançado permitindo que o objeto delegue a implementação de comportamentos para diferentes classes de estado.

- **Pasta `Builder`**: O padrão Builder separa a construção de um objeto complexo de sua representação, permitindo que o mesmo processo de construção crie diferentes representações.

- **Pasta `Observer`**: O padrão Observer define uma dependência de um-para-muitos entre objetos, de modo que quando um objeto muda de estado, todos os seus dependentes são notificados e atualizados automaticamente.

- **Pasta `Factory`**: O padrão Factory fornece uma interface para criar objetos, mas permite que as subclasses decidam qual classe concreta deve ser instanciada.

- **Pasta `Flyweight`**: O padrão Flyweight visa minimizar o uso de memória compartilhando o máximo possível de estado entre objetos semelhantes.

- **Pasta `Memento`**: O padrão Memento permite capturar e armazenar o estado interno de um objeto, de modo que ele possa ser restaurado posteriormente sem violar o encapsulamento.

- **Pasta `Interpreter`**: O padrão Interpreter fornece uma maneira de avaliar gramáticas ou expressões regulares em uma linguagem específica.


## Instruções de Uso

1. Clone este repositório em sua máquina local.
2. Navegue para a pasta do design pattern que você deseja explorar.
3. Dentro da pasta, você encontrará exemplos de uso correto e uso incorreto do design pattern.
4. Analise o código fonte e os comentários para entender como o design pattern está sendo aplicado em cada caso.
5. Execute os exemplos de código e observe os resultados.
6. Sinta-se à vontade para fazer modificações nos exemplos ou criar seus próprios exemplos para aprofundar sua compreensão.


## Contribuição

Se você deseja contribuir com exemplos adicionais de design patterns ou melhorias nos exemplos existentes, sinta-se à vontade para fazer um fork deste repositório e enviar um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
