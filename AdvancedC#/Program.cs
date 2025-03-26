
Console.WriteLine("Simple project to study advanced c# topics");

//selectMany - retorna todos elementos da coleção

List<List<int>> numeros = new List<List<int>>
{
    new List<int> {1, 2, 3},
    new List<int> {4, 5, 6},
    new List<int> {7, 8, 9}
};
List<Produtos> lstProdutos1 = new List<Produtos>()
{
    new Produtos { Nome = "Notebook", Preco = 3500 },
    new Produtos { Nome = "Smartphone", Preco = 2500 },
    new Produtos { Nome = "Fone de Ouvido", Preco = 300 }
};


List<Produtos> lstProdutos2 = new List<Produtos>()
{
    new Produtos { Nome = "Notebook", Preco = 3500 },
    new Produtos { Nome = "Smartphone", Preco = 2500 },
    new Produtos { Nome = "Fone de Ouvido", Preco = 300 }
};
IEnumerable<int> retornoNumeros = numeros.SelectMany(x => x);
foreach(var item in retornoNumeros)
{
    Console.Write($"{item} | ");
}

//except - trazer somente os itens da primeira lista que não existem na segunbda
IEnumerable<string> lstProdutosDiferentes = lstProdutos1.Select(x => x.Nome).Except(lstProdutos2.Select(x => x.Nome)).ToList();

//DistinctBy: retorna uma sequência que contém elementos distintos da sequência original, com base em uma chave de comparação especificada;
//ExceptBy: retorna uma sequência que contém elementos da primeira sequência que não estão na segunda sequência, com base em uma chave de comparação especificada;
//IntersectBy: retorna uma sequência que contém elementos que estão presentes em ambas as sequências, com base em uma chave de comparação especificada;
//UnionBy: retorna uma sequência que contém elementos distintos das duas sequências, com base em uma chave de comparação especificada.

//agregate pode juntar o resultado seja a junção de uma string ou a soma de valores

//lstProdutosDiferentes

public class Produtos
{
    public int Preco { get; set; }
    public string Nome { get; set; }
}