using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Operadores e Operações
 class Aula03_CSharp
{
    public static void Aula03()
    {
        int num = 10 + 5;
        Console.WriteLine(num);

        bool res = 10 < 5;
        Console.WriteLine(res);
        
        
        int num2 = 0;
        num2 = num2 + 1;
        //OU
        num2 += 1;
        //OU
        num2++;
        Console.WriteLine(num2);
    }

}
