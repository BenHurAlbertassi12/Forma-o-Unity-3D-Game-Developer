/*
Desafio 
Você e sua equipe estão finalizando um jogo. 
Porém, ele está muito pesado e você sabem que é devido a grande parte dos Assets 
(recursos que compõem o jogo) não utilizados mas que ainda estão na pasta.
O artista disse que nomeou tudo que estava sendo usado como “_usado”,
portanto,
você pensou em criar um programa que encontrasse
e deletasse todos os arquivos que não tivessem esse sufixo.

Entrada
A entrada serão strings que possuirão,ou não,
o sufixo “_usado”. 

Saída 
Caso o arquivo tenha “_usado” como sufixo,
print no console “Contem,
mantido”. Caso não tenha,
print “Não contem,
deletado”.
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
