namespace VendaDeShow
{
    public class Ingresso
    {
        private string nomeDoShow;

        private double preco;

        private int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetNomeDoShow(string nomeDoShow)
        {
            this.nomeDoShow = nomeDoShow;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public void SetQuantidadeDisponivel(int quantidadeDisponivel)
        {
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public void AlterarPreco(double novoPreco)
        {
            if (novoPreco >= 0)
            {
                preco = novoPreco;
            }
            else
            {
                throw new ArgumentException("O preço do ingresso não pode ser negativo");
            }
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            if (novaQuantidade >= 0)
            {
                quantidadeDisponivel = novaQuantidade;
            }
            else
            {
                throw new ArgumentException("A quantidade de ingressos não pode ser negativa");
            } 
        }

        public string ExibirInformacoes()
        {
            return $"Nome do show: {nomeDoShow}, Preço: {preco}, Quantidade de ingresso disponível: {quantidadeDisponivel}";
        }
    }
}