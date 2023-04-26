using Classe_Produto;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine());

Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();    
Console.Write("Digite o número dos produtos a serem adicionados: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o número dos produtos a serem removidos: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);