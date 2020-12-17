namespace Sistema_de_carrinho_de_compras.classes
{
    public class Produto
    {

        
        public float Codigo {get; set;}

        public string Nome {get; set;}

        public float Preco {get; set;}

        public Produto(){

        }

        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

       }    
}