using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_Day10
{
    class UC5AddMultiplePerson
    {
        public static void addMultiple()
        {
            int num;
            Console.WriteLine("How many contacts do you want to creat ?");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while( i < num)
            {
                UC2_AddNewContact.AddPerson();
                
                i++;
            }
        }
    }
}
