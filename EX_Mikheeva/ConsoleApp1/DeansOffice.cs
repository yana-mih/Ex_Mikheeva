using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DeansOffice
    {
        int Lenght;
        public Student[] students { get; set; }

        public DeansOffice(int size) 
        {
            Lenght = size;
            students = new Student[size];

        }
    }
}
