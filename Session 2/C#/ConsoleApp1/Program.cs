using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person1 = new Person("John", 25);
            Employee employee1 = new Employee("Jane", 30, "Developer");

            person1.speak();
            employee1.speak();
            employee1.speak("I am working now.");
        }
    }

    public class Person{
        public string name;
        public int age;
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }
        public virtual void speak(){
            Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
        }
    }

    public class Employee : Person{
        public string job;
        public Employee(string name, int age, string job) : base(name, age){
            this.job = job;
        }
        public void work(){
            Console.WriteLine("I am a " + job);
        }
        public override void speak(){
            Console.WriteLine("My name is " + name + " and I am " + age + " years old. I am a " + job);
        }
        public void speak(string words){
            Console.WriteLine("Employee says: " + words);
        }
    }
}