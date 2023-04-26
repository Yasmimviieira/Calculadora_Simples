using Calculadora;
using System;

Operador objoperador = new Operador();

double valor1, valor2, resultado;
string operador;


Console.WriteLine("Digite um valor: "); 
valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro valor: ");
valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o operador (+, -, *, /)");
operador = Console.ReadLine();

resultado = objoperador.RealizarOperacao(valor1, valor2, operador);

Console.WriteLine("O resultado da operação é: " + resultado);
Console.ReadLine();
        
