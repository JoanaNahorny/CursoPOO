namespace CursoPOO
{
    public class Item
    {
        private const int PADRAO_QUANTIDADE = 2;
        public string Nome { get; set; }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
                _quantidade = PADRAO_QUANTIDADE;
            }
        }

        private decimal _preco;
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            }
        }
        //public decimal Total
        //{
        //    get { return Preco * Quantidade; }
        //}
        public decimal Total => Preco * Quantidade;
        public string TotalFormatado => Total.ToString("C");
        public Item()
        {
            _quantidade = PADRAO_QUANTIDADE;
        }

        public Item(string nome, decimal preco) : base()
        {
            Nome = nome;
            _quantidade = PADRAO_QUANTIDADE;
            _preco = preco;
        }

        public static Item CriarBola()
        {
            var bola = new Item();
            bola.Nome = "Bola de Futebol";
            bola.Quantidade = 1;
            bola.Preco = 90M;

            return bola;
        }
    }
}
