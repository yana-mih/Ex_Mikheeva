using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
   public static class Helper
    {
        public static void Write_in_File(Student[] students)
        {
            Student[] sortArray = students.OrderBy(x => x.LastName).ThenBy(x => x.Name).ToArray();

            StreamWriter stream = new StreamWriter(@"D:\Users\stu-ipsp121\Desktop\экзамен_Михеева\EX_Mikheeva\ConsoleApp1\result.txt");

            foreach(Student s in sortArray) 
            {
                stream.WriteLine(s.LastName.ToString());
                stream.WriteLine(s.Name.ToString());
                stream.WriteLine(s.Number.ToString());
            }
            stream.Close();
            Console.WriteLine("Ваш массив успешно добавлен!");
        }
    }
}
