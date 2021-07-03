using System;

namespace LearnCSharp.Console
{
    class Person
    {
        private int id;
        private string name;
        // Constructor
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"id = {this.id}, and name = {this.name}");
        }
    }
    public class ReadLine
    {
        public ReadLine()
        {
            var person = new Person(10, "Mr. Ten");
            string name = System.Console.ReadLine();
            System.Console.WriteLine(name);
        }
    }
}
