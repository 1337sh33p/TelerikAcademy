using System;

namespace CompanyInformation
{
    class CompanyInformation
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string fax = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string phone = Console.ReadLine();
            if (string.IsNullOrEmpty(fax))
            {
                fax = "(no fax)";
            }

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, phone);
        }
    }
}
