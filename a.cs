using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public double salaryday { get; set; }
        public bool officials { get; set; }

        public Worker()
        {
        }

        public Worker(string name, string surname, int age, double salaryday, bool officials)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salaryday = salaryday;
            this.officials = officials;
         
        }

        public double Area
        {
            get
            {
                if (officials == false)
                {
                    Console.WriteLine("Зарплата в месяц неофициального работника: ");
                    return salaryday * 31;

                   
                }
                else 
                {
                    Console.WriteLine("Зарплата в месяц официального работника: ");
                    return (salaryday * 31) - (19.5);
                }
            }
        }

        public bool pension
        {
            get
            {
                if( age >= 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }













    }
}
