# DIS-PATTERN
# Property Container Pattern


## Exemplo

Para demonstração deste padrão de desenho iremos usar o exemplo de um **livro**.
Ao projetar a definição de livro deparamo-nos com algumas questões:
- Que atributos descrevem um livro?
   - Quais desses atributos são relevantes?
   - Qual a atomicidade de cada atributo?
   - Serão adicionados atributos em tempo de execução
   - Haverá atributos especificos de objeto?


## Contexto

São inúmeros os atributos que descrevem um livro, sendo que em diferentes fases do projeto os mesmo podem deixar de ser relevantes e removidos, adicionados novos ou repartido em atributos mais atómicos.
O utilizador poderá querer adicionar novos atributos aos livro que não foram projetados inicialmente, ou adicionar atributos especificamente a um livro único.

Numa perspetiva de orientação a objetos adição de novos atributos à classe pressupõe algumas alterações ao código, nomeadamente a adição dos ditos atributos, assim como os respetivos métodos de acesso, impossibilitando assim a manipulação de atributos durante o tempo de execução.


## Problema
  
Dado o ponto anterior, a alteração de código apresenta um esforço adicional na medida em que, no mínimo, o projeto terá de ser compilado novamente e terá de ser executado novamente o *deploy* da aplicação, o que poderá ser um processo moroso e desnecessário.


## Solução

Uma forma simples de resolver o problema anteriormente mencionado é recorrer à implementação do padrão Property Container.

Para a implementação deste padrão é necessário a criação duma interface para o *property container* que terá a assinatura dos métodos que farão a adição e remoção dos atributos a gerir em tempo de execução.
A implementar a interface será uma classe abstrata que terá o código para a gestão dos atributos.

Finalmente a classe que necessita do *property container* herdará da superclasse tudo o que necessita para gerir os seus atributos em tempo de execução.

![Pattern example](/images/pattern_example.png) 

Tal como podemos ver na interface da PropertyContainer temos quatro métodos: adicionar, remover, obter uma determinada propriedade e listar todas as propriedades. 

Sendo que conforme são adicionadas propriedades aos objetos da classe *Book*, a respetiva hashtable do objeto, por herança da PropertyContainerImpl, irá gerir o novo atributo.


## Consequências

### Vantagens

- *Business Objects* leves – os objetos apenas guardarão atributos que para si são revelantes.

- Informação adicionada dinamicamente – Com a possibilidade de adionar e remover atributos em tempo de execução temos um objeto preparado para mudanças e com grande flexibilidade.

- Bom para aplicações quando associado à capacidade de atravessar uma hierarquia de contenção

### Desvantagens

- *Overhead* - Para obter o atributo, é primeiro necessário aceder ao *property container*, aceder às propriedades pelo nome e finalmente realizar um cast para o tipo de objeto correspondente.

- Interface menos explicita – Já não é possível examinar a interface para perceber que atributos existem, é obrigatório saber o nome, ou listar todos os atributos para os obtermos.

- Perda de *strong typing* - o cliente terá de ser mais complexo para gerir o acesso aos atributos, pois, após a sua obtenção será necessário fazer o cast para o tipo correspondente. 

- Se estivermos - Persistência -  Será necessário um maior esforço para o mapeamento entre o *property container* e um sistema de persistência relacional uma vez que não um mapeamento direto.


## Utilizações

Para considerar usar o padrão *property container* um dos seguintes critérios tem de estar presente:

- Há informação que é associada a um objeto em específico.

- Atributos que são adicionados dinamicamente aos objetos.