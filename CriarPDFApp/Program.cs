using CriarPDFApp.Entities;

Console.WriteLine("Quantos arquivos deseja criar?");
int qtd = int.Parse(Console.ReadLine());

Console.WriteLine("Por favor digite o endereço do arquivo");
string caminho = Console.ReadLine();

for (int i = 1; i <= qtd; i++)
{
    Console.WriteLine($"Arquivo N°{i}");
    Console.Write("Por favor digite seu nome: ");
    string nome = Console.ReadLine();

    Usuario usuario = new Usuario(nome, caminho);

    usuario.CriarPDF(nome, caminho);

    Console.WriteLine("Arquivo PDF criado");
}
