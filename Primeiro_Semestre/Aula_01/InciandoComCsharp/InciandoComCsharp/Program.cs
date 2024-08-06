// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!"); // No Java, seria System.out.println("Hello, World!");

string? texto = Console.ReadLine();
Console.WriteLine(texto);

// String simples
var nome = "Leonardo";

// String multi-linha
var textoMultilinha = """
                      Olá mundo,
                      meu nome é Murillo,
                      e estou aqui para aprender C#!
                      """;

Console.WriteLine(textoMultilinha);

// String interpolada
var textoInterpolado = $"Olá, meu nome é {nome}";
Console.WriteLine(textoInterpolado);

// Tipos primitivos
int idade = 19;
double altura = 1.76;
bool maiorDeIdade = true;
char sexo = 'M';
string nome_ = "Murillo";