using System;
using System.Collections;
using System.Collections.Generic;

namespace Hashtable_Challenge
{
    internal class Program
    {
        //Challenge
        /*Write a program that will iterate through each element of the students array and insert them into a hashtable
        if a student with the same ID already exists in the hashtable, skip it and siplay the following error:
        "Sorry, A student with the same ID already Exists".
        Hint: Use the method ContainsKey() to check wether a student with the same ID already exists*/

        static void Main(string[] args)
        {
            Hashtable tabelaEstudante = new Hashtable();
            Student[] student = new Student[5];
            student[0] = new Student(1, "Marcos");
            student[1] = new Student(2, "Magnos");
            student[2] = new Student(3, "Maquinos");
            student[3] = new Student(4, "Malygos");
            student[4] = new Student(4, "Macarcos");

            foreach (Student s in student)
            {

                if (tabelaEstudante.ContainsKey(s.Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists");
                    Console.WriteLine("The ID: {0}", s.Id);
                    s.Id = s.Id + 2;
                    Console.WriteLine("The ID after the increment: {0}", s.Id);
                }
                else
                {
                    tabelaEstudante.Add(s.Id, s);
                    Console.WriteLine("All good, there is no student with the same id as you, the ID {0} has been added!!", s.Id);
                }

            }
        }
    }
}
