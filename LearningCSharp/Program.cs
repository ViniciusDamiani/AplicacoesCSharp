using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando o objeto "house1" que terá acesso aos metodos e atributos da classe House
            House house1 = new House();

            //Setando valores para o Objeto
            house1.Address = "Rua Martinho Brunelli";
            house1.Color = "Azul";

            BankAccount bankAccount = new BankAccount();
            bankAccount.PersonName = "Vinicius Damiani";
            bankAccount.Balance = 0;
            bankAccount.Deposit(amount : 100);
            bankAccount.ShowDetails();
        }
    }

    public class House
    {
        //Atributos da classe
        public string Address;
        public string Color;

        //Métodos
        public void TurnOnLight()
        {
            Console.WriteLine("Acende a Luz");
            Console.ReadKey();
        }
        public void TurnOffLight()
        {
            Console.WriteLine("Apagar a Luz");
            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        public string PersonName;
        public decimal Balance;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{PersonName} possui saldo de {Balance:C2}");
        }

    }
}