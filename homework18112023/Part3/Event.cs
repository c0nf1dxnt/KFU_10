using System;
using System.IO;

namespace Part3
{
    public class Event
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public int numberOfStudents { get; set; }
        public Event(string name, DateTime date, int numberOfStudents)
        {
            this.name = name;
            this.date = date;
            this.numberOfStudents = numberOfStudents;
        }
        public void AddEventToFile(string filePath)
        {
            File.AppendAllText(filePath, $"Мероприятие {name} назначено на {date}, от каждой группы требуется {numberOfStudents} человек\n");
            Console.WriteLine($"Мероприятие {name} назначено на {date}, от каждой группы требуется {numberOfStudents} человек\n");
        }
    }
}
