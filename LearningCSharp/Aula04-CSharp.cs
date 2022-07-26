using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula04_CSharp
{
    //Formatando saída do console
    public static void Aula04()
    {
        int n1, n2, n3;
        n1 = 20;
        n2 = 30;
        n3 = 40;
        Console.WriteLine("O valor de n1 eh: {0}, \nja o valor de n2 eh: {1} \ne n3 eh: {2}", n1, n2, n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto...........:{0,15}",produto);
        Console.WriteLine("Valor compra......:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.............:{0,15:p}",lucro);
        Console.WriteLine("Valor de venda....:{0,15:p}", valorVenda);
    }

}

