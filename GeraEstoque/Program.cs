namespace GeraEstoque;

public class Program
{   
    
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Menu();
    }

    public void Menu()
    {
        Program program = new Program();
        Console.Clear();
        System.Console.WriteLine("Seja Bem vindo ao GeraEstoque 1.0");
        System.Console.WriteLine("--------------------------------------");
        System.Console.WriteLine("1 Cadastrar protuto");
        System.Console.WriteLine("2 Consultar produto");
        System.Console.WriteLine("3 Modificar produto");
        System.Console.WriteLine("4 Excluir produto");
        System.Console.WriteLine("0 Sair");
        System.Console.WriteLine($"\nDigite a opção:");
        string? escolha =Console.ReadLine();

        switch(escolha)
        {
            case "1":
                Console.Clear();
                program.CadastrarProduto();
                
            break;
           
        }
    }
    public void CadastrarProduto()
    
    {   
        Guid g = Guid.NewGuid();
        System.Console.Write("Insira o nome do Produto :");
        string? nome=Console.ReadLine();
        System.Console.Write("Insira a quantidade em estoque do produto: ");
        int qtd = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Insira o valor de compra do produto:R$");
        double valorCompra=Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Insira o valor de venda do produto:R$");
        double valorVenda=Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("\nProduto cadastrado com sucesso!");
        System.Console.WriteLine($"\nID: {g}");
        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Qtd: {qtd}");
        System.Console.WriteLine($"R$ Compra: R${valorCompra}");
        System.Console.WriteLine($"R$ Venda: R${valorVenda}");

        System.Console.WriteLine("\n Pressione qualquer tecla para voltar ao Menu Inicial");
        Console.Read();
        Menu();
       
    }
}