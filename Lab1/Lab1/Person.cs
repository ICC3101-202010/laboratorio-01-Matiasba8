using System;

namespace Lab1
{
    public class Person
    {
        //Atributos
        private string name;
        private string LastName;

        public Person(string name,string LastName)
        {
            this.name = name;
            this.LastName = LastName;
        }

        public string GetName() 
        {
            return name;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public void Lanzar()    //Comportamiento
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(0, 3));

        }


    }

    
}
