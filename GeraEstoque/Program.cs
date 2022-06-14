namespace GeraEstoque;

class Program
{
    static void Main()
    {
        Menu();

       
    }

    static void Menu(){
        Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1  Cadastrar produto");
        Console.WriteLine("2  Consultar produto");
        Console.WriteLine("3  Modificar produto");
        Console.WriteLine("4  Excluir produto");
        Console.WriteLine("0  Sair");
        Console.WriteLine("Digite a opção:");
        var option =short.Parse(Console.ReadLine());
       
       switch(option)
       {
        case 1: CadastrarProduto();break;
        case 2: {Console.Clear();Environment.Exit(0);break;}
       }

    }

    static void CadastrarProduto()
    {   
        Console.Clear();
        Console.WriteLine("Insira o Nome :");
        var name =(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Quantidade em Estoque  :");
        var qtd =(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Valor de compra   :");
        float valorCompra =float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Valor de Venda :");
        float valorVenda =float.Parse(Console.ReadLine());
        Console.Clear();
        Guid id= Guid.NewGuid();
        Console.WriteLine("Produto cadastrado com sucesso!");
         Console.WriteLine();
        Console.WriteLine("ID: {0}",id);
        Console.WriteLine("Nome: Produto {0}",name);
        Console.WriteLine("Qtd: {0}",qtd);
        Console.WriteLine("R$ Compra:R$ {0}",valorCompra);
        Console.WriteLine("R$ Venda:R$ {0}",valorVenda);
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu");
        var tecla =(Console.ReadLine());
        Console.Clear();
        Menu();


    }

   
}