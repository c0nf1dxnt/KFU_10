using System;
using System.Text;
using BankLibrary;
using Part1;

namespace Part2
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Task1:\nДля класса BankAccount переопределить операторы ==, != и методы Equals, GetHashCode, ToString, протестировать\n");
            //Упражнение 12.1
            BankAccount account1 = new BankAccount(5412.15m, BankAccount.AccountType.Current);
            BankAccount account2 = new BankAccount(1251.42m, BankAccount.AccountType.Savings);

            Console.WriteLine(account1 == account2 ? "Это один и тот же аккаунт" : "Это разные аккаунты");
            Console.WriteLine(account1 != account1 ? "Это разные аккаунты" : "Это один и тот же аккаунт");
            Console.WriteLine(account1.ToString());
            Console.WriteLine($"Хешкод аккаунта 1: {account1.GetHashCode()}\n");
        }
        static void Task2()
        {
            Console.WriteLine("Task2:\nСоздать класс рациональных чисел с полями числитель и знаменатель, предусмотреть конструктор, определить операторы ==, !=, <, >, <=, >=, +, -, ++, --, *, /, % и методы ToString, Equals, а также операторы преобразования между типом float,int\n");
            //Упражнение 12.2
            RationalNumber number1 = new RationalNumber(2);
            RationalNumber number2 = new RationalNumber(5);
            Console.WriteLine($"{number1} + 1 = {++number1}");
            Console.WriteLine($"{number1} - 1 = {--number1}");
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
            Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
            Console.WriteLine($"{number1} > {number2} : {number1 > number2}");
            Console.WriteLine($"{number1} < {number2} : {number1 < number2}");
            Console.WriteLine($"{number1} <= {number2} : {number1 <= number2}");
            Console.WriteLine($"{number1} >= {number2} : {number1 >= number2}");
            Console.WriteLine($"{number1} == {number2} : {number1 == number2}\n");
        }
        static void Task3()
        {
            Console.WriteLine("Task3:\nСоздать класс комплексных чисел, реализовать операции +, -, *, == и переопределить метод ToString\n");
            //Домашнее задание 12.1
            ComplexNumber number1 = new ComplexNumber(2, 1);
            ComplexNumber number2 = new ComplexNumber(5, 2);
            Console.WriteLine($"Комплексное число 1: {number1.ToString()}\nКомплексное число 2: {number2.ToString()}\n");
            Console.WriteLine($"Операции над ними:\n({number1}) + ({number2}) = {number1 + number2}");
            Console.WriteLine($"({number1}) - ({number2}) = {number1 - number2}");
            Console.WriteLine($"({number1}) * ({number2}) = {number1 * number2}");
            Console.WriteLine($"{number1} == {number2} : {number1 == number2}\n");
        }
        static void Task4()
        {
            Console.WriteLine("Task4:\nНаписать делегат, с помощью которого реализуется сортировка книг. Книга - класс с полями название, автор, издательство. Создать класс, являющийся контейнером для множества книг, критерий сортировки определяется экземпляром делегата, каждый экземпляр делегата должен сравнивать книги по одному из её полей\n");
            //Домашнее задание 12.2

            ArrayOfBooks books = new ArrayOfBooks();
            books.AddBook(new Book("Горе от ума", "Александр Грибоедов", "Эксмо"));
            books.AddBook(new Book("Идиот", "Фёдор Достоевский", "АСТ"));
            books.AddBook(new Book("Архипелаг ГУЛАГ", "Александр Солженицын", "Советский писатель - Новый мир"));

            Console.WriteLine("Книги до сортировки:");
            books.PrintBooks();

            Console.WriteLine("Книги после сортировки по названию:");
            books.SortBooks((book1, book2) => string.Compare(book1.Title, book2.Title));
            books.PrintBooks();

            Console.WriteLine("Книги после сортировки по автору:");
            books.SortBooks((book1, book2) => string.Compare(book1.Author, book2.Author));
            books.PrintBooks();

            Console.WriteLine("Книги после сортировки по издателю:");
            books.SortBooks((book1, book2) => string.Compare(book1.Publisher, book2.Publisher));
            books.PrintBooks();

        }
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadKey();
        }
    }
}
