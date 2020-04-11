using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dhanar", 18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Rizky", 35, 19112001, "Guru Bahasa indonesia");
            teacher.GetNameAndAge();

            Student student = new Student("Krisnadhy", 20, 19.11.2871, "krisna03@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
