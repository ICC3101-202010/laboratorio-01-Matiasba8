using System;

namespace Lab1
{
    public class Person
    {
        //Atributos
        public string Name;
        public string LastName;

        public void Lanzar()    //Comportamiento
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(0, 3));
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Bob";
            person.LastName = "Kunga";
            
            person.Lanzar();
            
        }
    }

    
}
