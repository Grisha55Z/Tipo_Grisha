using System;

class Program
{
    class Student
    {
        public string Name { get; set; }
    }

    static void Main(string[] args)
    {
        // Создаем объекты студентов
        Student[] students = new Student[]
        {
            new Student() { Name = "Максим" },
            new Student() { Name = "Максим" },
            new Student() { Name = "Мавксим" },
            new Student() { Name = "Никита" },
            new Student() { Name = "Динис" },
            new Student() { Name = "Малик" },
            new Student() { Name = "..." }
        };

        // Имя текущего пользователя
        string currentUser = "Ильнар";

        // Выводим список студентов
        foreach (Student student in students)
        {
            if (student.Name == currentUser)
            {
                Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет вывода для текущего пользователя
                Console.WriteLine(student.Name);
                Console.ResetColor(); // сбрасываем цвет вывода
            }
            else
            {
                Console.WriteLine(student.Name);
            }
        }

        Console.ReadLine();
    }
}