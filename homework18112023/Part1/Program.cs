using System;
using System.Text;
using BankLibrary;
using BuildingFactory;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task1:\nСоздать новый класс, который будет являться фабрикой объектов класса банковский счёт. Изменить модификатор доступа конструкторов класса BankAccount на internal. Добавить в BankAccountFactory методы создания и удаления счёта\n");
            //Упражнение 11.1 & 11.2

            BankAccountFactory bankAccountFactory = new BankAccountFactory();

            int accountNumber1 = bankAccountFactory.CreateAccount(BankAccount.AccountType.Savings);
            int accountNumber2 = bankAccountFactory.CreateAccount();

            bankAccountFactory.DeleteAccount(accountNumber1);
            bankAccountFactory.DeleteAccount(accountNumber2);
        }
        static void Task2()
        {
            Console.WriteLine("\nTask2:\nСоздать новый класс, который будет являться фабрикой объектов класса здание. Изменить модификатор доступа конструкторов класса Building на internal. Добавить в BuildingFactory методы создания и удаления счёта\n");
            //Домашнее задание 11.1 & 11.2

            Creator.CreateBuilding(10);
            Creator.CreateBuilding(22.5);
            Creator.CreateBuilding(25, 5, 50, 2);

            Creator.DeleteBuilding(1);
        }
        static void Main()
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Task1();
            Task2();

            Console.ReadKey();
        }
    }
}
