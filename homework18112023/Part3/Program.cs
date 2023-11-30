using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Part3
{
    class Program
    {
        static List<Student> ReadStudentsFromFile(string filePath)
        {
            List<Student> students = new List<Student>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        students.Add(new Student
                        {
                            name = parts[0],
                            group = int.Parse(parts[1]),
                            isFreeloader = bool.Parse(parts[2])
                        });
                    }
                }
            }
            return students;
        }

        static void Task1()
        {
            Console.WriteLine("Task1\n");
            List<Student> students = ReadStudentsFromFile("students.txt");

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.name} - {student.group} - {student.isFreeloader}");
            }

            Event newEvent;
            Console.Write("Введите название мероприятия: ");
            string eventName = Console.ReadLine();
            Console.Write("Введите дату в формате dd.mm.yyyy: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.Write("Введите количество студентов, которые должны учавствовать от одной группы: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfStudentsPerGroup)) {
                    newEvent = new Event(eventName, date, numberOfStudentsPerGroup);
                    newEvent.AddEventToFile("data.txt");
                    List<Student> eventParticipants = new List<Student>();
                    foreach (Student student in students)
                    {
                        if (student.isFreeloader)
                        {
                            eventParticipants.Add(student);
                            File.AppendAllText("data.txt", $"Студент {student.name} из группы {student.group} примет участие в мероприятии {newEvent.name}\n");
                            Console.WriteLine($"Студент {student.name} из группы {student.group} примет участие в мероприятии {newEvent.name}\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат числа!");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат времени!");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Task2\n");

            List<Person> persons = new List<Person>
            {
                new Person("Данияр", "выход сериала"),
                new Person("Павел", "концерт"),
                new Person("Инсаф", "турнир по доте")
            };
            Console.Write("Введите событие: ");
            string newevent = Console.ReadLine();
            foreach (Person person in persons)
            {
                if (person.hobby.Equals(newevent.ToLower()))
                {
                    Console.WriteLine($"{person.name} будет рад событию {newevent}!");
                }
                else
                {
                    Console.WriteLine($"{person.name} равнодушен к {newevent}");
                }
            }
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
