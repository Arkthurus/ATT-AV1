﻿using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Cadastro do produto {i + 1}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            decimal preco;
            while (!decimal.TryParse(Console.ReadLine(), out preco))
            {
                Console.Write("Por favor, insira um preço valido: ");
            }

            Console.Write("Quantidade: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade))
            {
                Console.Write("Por favor, insira uma quantidade valida: ");
            }

            produtos.Add(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
            Console.WriteLine();
        }

        decimal totalEstoque = 0;
        Console.WriteLine("Produtos cadastrados:");
        foreach (var produto in produtos)
        {
            decimal valorTotal = produto.Preco * produto.Quantidade;
            totalEstoque += valorTotal;
            Console.WriteLine($"Nome: {produto.Nome}, Preco: {produto.Preco:C}, Quantidade: {produto.Quantidade}, Valor Total: {valorTotal:C}");
        }

        Console.WriteLine($"\nValor total em estoque: {totalEstoque:C}");
    }
}
