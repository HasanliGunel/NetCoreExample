using System;
using System.Collections.Generic;
using System.Text;

namespace Tapshiriq_4
{
    class Person:General
    {
        public string vacancy { get; set; }
        
        
        public void Print (Person person)
        {
            Console.WriteLine($"Id:{person.ID}\n Ad:{person.Name}\n Vakansiya:{person.vacancy}");
        }

        public void certificate(bool certificate)
        {
            if (certificate == true)
            {
                Console.WriteLine("Musahibede ishtirak ede bilersiniz");

            }
        }
        
        public void  Participate(int button)
        {
            Console.WriteLine("Musahibede istirak : button_1 ZOOM meeting\n button_2 Real ofis daxilinde ");
            if (button == 1)
                Console.WriteLine("ZOOM meeting vasitesi ile musahibe olacaq");
            else
                Console.WriteLine("Real ofis daxilinde musahibe olacaq");
        }
    }
}
