using System;
using System.Collections;

namespace Hashtable_Challenge
{
    internal class Program
    {
        //Challenge
        /*Write a program that will iterate through each element of the students array and insert them into a hashtable
        if a student with the same ID already exists in the hashtable, skip it and siplay the following error:
        "Sorry, A student with the same ID already Exists".
        Hint: Use the method ContainsKey() to check wether a student with the same ID already exists*/

        static bool ContainsKey(Student student4, Student student5, Hashtable tabelaEstudante)
        {
            foreach (DictionaryEntry entry in tabelaEstudante)
            {
                Student tempValue = (Student)entry.Value;
                if (student4.Id == student5.Id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        static void Main(string[] args)
        {
            Hashtable tabelaEstudante = new Hashtable();
            Student student1 = new Student(1, "Marcos");
            Student student2 = new Student(2, "Magnos");
            Student student3 = new Student(3, "Maquinos");
            Student student4 = new Student(4, "Malygos");
            Student student5 = new Student(4, "Macarcos");
            tabelaEstudante.Add(student1.Id, student1.Name);
            tabelaEstudante.Add(student2.Id, student2.Name);
            tabelaEstudante.Add(student3.Id, student3.Name);
            tabelaEstudante.Add(student4.Id, student4.Name);
            tabelaEstudante.Add(student5.Id, student5.Name);
            if (ContainsKey(student4, student5, tabelaEstudante))
            {
                Console.WriteLine("Sorry, A student with the same ID already Exists");
            }
            else
            {
                Console.WriteLine("All good, the student 4 and student 5 id's are not the same");
            }
            Console.WriteLine("Hello World!");

        }
    }
}
