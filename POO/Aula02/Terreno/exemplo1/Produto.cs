using System;
using System.Collections.Generic;
using System.Text;

namespace exemplo1
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        //construtor 

        public Produto (string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        // metodos

        public double valor_Total_Em_Estoque()
        {
            return preco * quantidade;

        }

        public void Adicionar_Produto(int qtd)

        {
            quantidade += qtd;
        }
        

        public void Remover_Produtos(int qtd)

        {
            quantidade -= qtd;
        }

        public string Dados_do_Produto()

        {
            return $"Nome: {nome}, Preço: {preco}, quantidade: {quantidade}" +
                $"\n Total: {valor_Total_Em_Estoque()}";
        }
    }
}
