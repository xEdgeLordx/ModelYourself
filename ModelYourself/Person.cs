using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ModelYourself
{
    internal class Person
    {
        private string name;

        private int age;

        private string hårfarge;

        private string hobby;

        public Person(string name, int age, string hårfarge, string hobby)
        {
            this.name = name;
            this.age = age;
            this.hårfarge = hårfarge;
            this.hobby = hobby;
        }

        public void printInfo()
        {
            Console.WriteLine("Hei jeg heter " + name + "\nJeg er " + Convert.ToString(age) + " år gammel\nJeg har " + hårfarge + " hår og nå " + hobby);
        }
    } 
    
}
