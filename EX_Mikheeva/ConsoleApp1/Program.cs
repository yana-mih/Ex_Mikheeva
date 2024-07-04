using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите размер вашего массива: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size<=0 || size>int.MaxValue) 
            {
                Console.WriteLine("Ошибка! Введите целое положительное число!");
            }

            DeansOffice deans = new DeansOffice(size);

            for (int i = 0; i < deans.students.Length; i++)
            {
                deans.students[i] = new Student();
                Console.WriteLine($"Заполните {i + 1} элемент вашего массива. Введите фамилию студента: ");

                bool flag = false;
                string lname;

                while (flag == false)
                {
                    lname = Console.ReadLine();

                    if (string.IsNullOrEmpty(lname) || lname.Length < 2)
                    {
                        Console.WriteLine("Ошибка! Введите фамилию студента!");
                    }
                    else
                    {
                        flag = true;
                        deans.students[i].LastName = lname;
                        Console.WriteLine("Введите имя студента:");
                    }
                }

                flag = false;
                string name;

                while (flag == false)
                {
                    name = Console.ReadLine();

                    if (string.IsNullOrEmpty(name) || name.Length < 2)
                    {
                        Console.WriteLine("Ошибка! Введите имя студента!");
                    }
                    else
                    {
                        flag = true;
                        deans.students[i].Name = name;
                        Console.WriteLine("Введите номер зачётной книжки студента:");
                    }
                }

                flag = false;
                int number;

                while (flag == false)
                {

                    if (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number > int.MaxValue || number.ToString().Length !=6)
                    {
                        Console.WriteLine("Ошибка! Введите положительный номер зачётной книжки, состоящий из 6 цифр!");
                    }
                    else
                    {
                        flag = true;
                        deans.students[i].Number = number;
                    }
                }
            }
            Helper.Write_in_File(deans.students);
        }
    }
}
