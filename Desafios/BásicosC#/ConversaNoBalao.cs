/*
Desafio
Durante o desenvolvimento de um jogo, 
você precisa verificar se a conversa com um dos personagens vai caber
no balão desenvolvido pelo artista. 
Para isso, você resolveu desenvolver um programa vai ler cada caractere das frases, 
incluindo pontuação e espaços, e verificar se elas possuem 45 ou menos caracteres.

 

Entrada
A entrada vão ser frases de tamanhos variados. 
Lembrando que não há diferença entre maiúsculas e minúsculas.

Saída
A saída deve ser o espaço é suficiente ou não utilizando os 45 caracteres 
determinado pelo artista.
*/

using System;

public class Program
{
    public static void Main()
    {
        string fraseDeEntrada = Console.ReadLine();

        if (fraseDeEntrada.Length <= 45)
        {
            Console.WriteLine("Suficiente");
        }
        else
        {
            Console.WriteLine("Nao suficiente");
        }
    }
}
