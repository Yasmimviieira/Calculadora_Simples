namespace Calculadora;

public class Operador
{
    private double resultado;

    private double RealizarSoma (double valor1, double valor2) 
    {
        resultado = valor1 + valor2;
        return resultado;
    }
private double RealizarSubtracao (double valor1, double valor2) 
    {
        resultado = valor1 - valor2;
        return resultado;
    }
    private double RealizarMultiplicacao (double valor1, double valor2) {

        resultado = valor1 * valor2;
        return resultado;
    }
    private double RealizarDivisao (double valor1, double valor2) {

        resultado = valor1 / valor2;
        return resultado;
    }
    public double RealizarOperacao(double valor1, double valor2, string operador){

        switch (operador)
        {
            case "+":
            resultado = RealizarSoma(valor1, valor2);
            break;

            case "-":
            resultado = RealizarSubtracao (valor1, valor2);
            break;

            case "*":
            resultado = RealizarMultiplicacao (valor1, valor2);
            break;

            case "/":
            resultado = RealizarDivisao(valor1, valor2);
            break;

            case null:
            resultado = 0;
            break;
        }  
        return resultado;
    }
}


    



























