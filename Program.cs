using System;
using Sistema_de_carrinho_de_compras.classes;

namespace Sistema_de_carrinho_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {   
            string resp = "";
            Carrinho carrinho = new Carrinho();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------Lista de Produtos-----------");
            Produto p1 = new Produto(1, "Read Dead Redemption 2", 499f);
            Console.WriteLine(p1.Codigo + p1.Nome);
            Produto p2 = new Produto(2, "GTA 5", 56.90f);
            Console.WriteLine(p2.Codigo + p2.Nome);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.50f);
            Console.WriteLine(p3.Codigo + p3.Nome);
            Produto p4 = new Produto(4,"Celeste", 22.99f);
            Console.WriteLine(p4.Codigo + p4.Nome);
            
            

            do{    
            Console.WriteLine("Digite o código do produto para adicioná-lo ao carrinho");
            int escolha = int.Parse(Console.ReadLine());
        
              
              switch(escolha){

                  case 1:  carrinho.AdicionarProduto(p1);
                    carrinho.MostrarProduto();

                  break;

                  case 2:carrinho.AdicionarProduto(p2);
                    carrinho.MostrarProduto();

                  break;

                  case 3:carrinho.AdicionarProduto(p3);
                    carrinho.MostrarProduto();

                  break;

                  case 4:carrinho.AdicionarProduto(p4);
                    carrinho.MostrarProduto();

                  break;

                  default:

                  break;
                }
                Console.WriteLine("Adicionar mais produtos no carrinho? s /n");
                resp = Console.ReadLine();
                
                }while(resp == "s");

                
    }
    }
}
