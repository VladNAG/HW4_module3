using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_module3
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Phonebook = new List<Contact>();
            Phonebook.Add(new Contact("Jon", "0509466235"));
            Phonebook.Add(new Contact("Alina", "05697466234"));
            Phonebook.Add(new Contact("Pet", "0539466235"));
            Phonebook.Add(new Contact("Anna", "0409466234"));
            Phonebook.Add(new Contact("Alla", "0609466235"));
        }

        public List<Contact> Phonebook { get; set; }

        public void MySelect()
        {
            Console.WriteLine("Test Select&Revers");
            var selecttest = Phonebook.Select(w => w.Name + $" {w.Phone}").Reverse();

            foreach (var contact in selecttest)
            {
                Console.WriteLine(contact);
            }

            Console.WriteLine("Finish!!!");
        }

        public void MyWere()
        {
            Console.WriteLine("Test Where&OrderBy");
            var selecttest = Phonebook.Where(w => w.Phone.EndsWith("5")).Select(w => w.Name + $" {w.Phone}").OrderBy(w => w);

            foreach (var contact in selecttest)
            {
                Console.WriteLine(selecttest);
            }

            Console.WriteLine("Finish!!!");
        }

        public void MyFirstOrDefault()
        {
            Console.WriteLine("Test FirstOrDefault");
            var selecttest = Phonebook.FirstOrDefault(x => x.Name.StartsWith("A"));
            Console.WriteLine(selecttest);

            Console.WriteLine("Finish!!!");
        }

        public void MyAny()
        {
            Console.WriteLine("Test Any");
            var selecttest = Phonebook.Any(w => w.Name.StartsWith("S"));

            Console.WriteLine(selecttest);

            Console.WriteLine("Finish!!!");
        }

        public void MySkipTeke()
        {
            Console.WriteLine("Test Skip&Teke");
            var selecttest = Phonebook.Skip(2).Take(2);

            foreach (var contact in selecttest)
            {
                Console.WriteLine(contact.Name);
            }

            Console.WriteLine("Finish!!!");
        }

        public void MyDistinct()
        {
            Console.WriteLine("Test Distinct");
            int[] test = { 1, 2, 1, 4, 5, 5, 7 };
            var test1 = test.Distinct();

            foreach (var i in test1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finish!!!");
        }
    }
}