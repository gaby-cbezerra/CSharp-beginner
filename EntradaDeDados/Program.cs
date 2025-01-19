//Entrada de Dados
string frase = Console.ReadLine(); //Ler o texto até a quebra de linha

string x, y, z;

x = Console.ReadLine();           //Ler três palavras, cada uma em uma linha
y = Console.ReadLine();
z = Console.ReadLine();
                                                     
                                                      //Ler três palavras na mesma linha separada por espaço diretamente no vetor, sem criar uma variável.
string[] vet = Console.ReadLine().Split(' ');        // Divide a string usando o espaço como separador
string a = vet[0];
string b = vet[1];
string c = vet[2];


Console.WriteLine("Você digitou: ");
Console.WriteLine($"{frase}\n{x}\n{y}\n{z}\n{a}\n{b}\n{c}"); // \n para dar quebra de linha