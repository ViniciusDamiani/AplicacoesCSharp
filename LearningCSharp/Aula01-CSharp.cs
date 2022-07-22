using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VARIAVEIS
class Aula01_CSharp{

    static void Main()
    {
        byte n1 = 10; //Entre 0 e 255
        int num = 0;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Vinicius";

        //É definida pelo valor passado 
        var aux = 10;

        //Multiplas variaveis
        int num1, num2, res;
        num1 = 2;
        num2 = 3;

        res = num1 * num2;

        //Concatenando a variavel com uma string
        Console.WriteLine("Meu nome é: " + nome);
        Console.WriteLine("O resultado da multiplicação entre "+ num1 +" e "+ num2 +" é: "+ res +"! \nSe multiplicarmos o resultado por "+ num1 +" chegamos em: " + res * num1 );
        Console.ReadKey();
    }

}
