using System;
using System.Collections.Generic;
using System.Linq;

namespace Tapshiriq_4
{
    class Program
    {

        static void Main(string[] args)
        {


            var companyList = new List<Company>
            {
                new Company() { ID = 1, Name = "Azercell" },
                new Company() { ID = 2, Name = "Bakcell" },
                new Company() { ID = 3, Name = "Nar Mobile" },
            };
            var vacancyList = new List<Person>
            {
                new Person() { ID = 1, Name = "Eli", vacancy = "Software Developer" },
                new Person() { ID = 2, Name = "Veli", vacancy = "Software Developer" },
                new Person() { ID = 3, Name = "Nermin", vacancy = "Project Manager" },
                new Person() { ID = 4, Name = "Huseyn", vacancy = "Product Manager" },
            };
            List<Person> list = new List<Person>();
            {
                new Person() { ID = 1, Name = "Eli", vacancy = "Software Developer" };
                new Person() { ID = 2, Name = "Veli", vacancy = "Software Developer" };
                new Person() { ID = 3, Name = "Nermin", vacancy = "Project Manager" };
                new Person() { ID = 4, Name = "Huseyn", vacancy = "Product Manager" };
            }

            Person person = new Person();


            foreach(var item in vacancyList)
            {
                person.Print(item);
            }
            Company company = new Company();
            for (; ; )
            {
                Console.Write("Namizedin ID-sini daxil edin:");
                int ID = Convert.ToInt32(Console.ReadLine());
                foreach (var item in vacancyList)
                {
                    if (ID == item.ID)
                    {
                        company.SelectPerson(item.ID);
                        Console.WriteLine("Musabibede istirak: button_1/button_2");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        person.Participate(answer);
                    }
                    else
                        Console.WriteLine("ID yanlish daxil edilmisdir");
                }
            }
          
        }
    }
}
