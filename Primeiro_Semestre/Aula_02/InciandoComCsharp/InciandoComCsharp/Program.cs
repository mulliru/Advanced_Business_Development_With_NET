// Este código é um exemplo básico de C# para demonstrar strings, interpolação, tipos primitivos e condicionais.

// Escreve "Hello, World!" no console
// No Java, isso seria feito com System.out.println("Hello, World!");
Console.WriteLine("Hello, World!");

// Lê uma entrada do usuário e a armazena na variável 'texto'.
// O '?' indica que a variável 'texto' pode ser nula.
string? texto = Console.ReadLine();

// Exibe o texto digitado pelo usuário no console.
Console.WriteLine(texto);

// Declarando uma string simples e atribuindo um nome a ela.
var nome = "Leonardo";

// Declarando uma string multi-linha usando """ (três aspas duplas).
var textoMultilinha = """
                      Olá mundo,
                      meu nome é Murillo,
                      e estou aqui para aprender C#!
                      """;

// Escreve a string multi-linha no console.
Console.WriteLine(textoMultilinha);

// Criando uma string interpolada, que permite inserir variáveis dentro da string.
var textoInterpolado = $"Olá, meu nome é {nome}";

// Escreve a string interpolada no console.
Console.WriteLine(textoInterpolado);

// Declarando e inicializando variáveis de tipos primitivos.
var idade = 19;         // Inteiro
var altura = 1.76;      // Ponto flutuante (double)
var maiorDeIdade = true; // Booleano (verdadeiro ou falso)
var sexo = 'M';         // Caractere (char)
var nome_ = "Murillo";  // String

// Conversão de tipos
// idade = (double)idade;          // This line is unnecessary as 'idade' is already an int.
altura = (int)altura;           // Converte altura de double para inteiro (perde a parte decimal).
maiorDeIdade = maiorDeIdade.ToString(); // Converte o valor booleano para string ("True" ou "False").

// Condicional 'if-else' para verificar se a idade é maior ou igual a 18.
if (idade >= 18)
    Console.WriteLine("Maior de idade");
else
    Console.WriteLine("Menor de idade");

// Operador ternário para realizar a mesma verificação de forma mais concisa.
Console.WriteLine(idade >= 18 ? "Maior de idade" : "Menor de idade");