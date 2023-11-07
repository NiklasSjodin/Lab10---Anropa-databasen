using Lab10___Anropa_databasen.Data;
using Lab10___Anropa_databasen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Lab10___Anropa_databasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. List all customers ASC");
            Console.WriteLine("2. List all customers DESC");
            Console.WriteLine("3. Add a new customer");
            int input = int.Parse(Console.ReadLine());

            using(var context = new NorthwindContext())
            {
                if (input == 1)
                {
                    Console.Clear();
                    var acendingCustomers = context.Customers
                        .Include(c => c.Orders)
                        .OrderBy(c => c.CompanyName)
                        .ToList();

                    CustomersInfo(acendingCustomers);

                    Console.Write("Select customer number to get more info: ");
                    int userInput = int.Parse(Console.ReadLine());

                    CustomerInfo(acendingCustomers, userInput);
                }
                else if (input == 2)
                {
                    Console.Clear();
                    var decendingCustomers = context.Customers
                        .Include(c => c.Orders)
                        .OrderByDescending(c => c.CompanyName)
                        .ToList();

                    CustomersInfo(decendingCustomers);

                    Console.Write("Select customer number to get more info: ");
                    int userInput = int.Parse(Console.ReadLine());

                    CustomerInfo(decendingCustomers, userInput);
                }
                else if (input == 3)
                {
                    Console.Clear();
                    Console.Write("Enter Companyname: ");
                    string cName = Console.ReadLine();
                    Console.Write("ContactName: ");
                    string cName2 = Console.ReadLine();
                    Console.Write("ContactTitle: ");
                    string cTitle = Console.ReadLine();
                    Console.Write("Adress: ");
                    string adress = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("Region: ");
                    string region = Console.ReadLine();
                    Console.Write("Postalcode: ");
                    string pCode = Console.ReadLine();
                    Console.Write("Country: ");
                    string country = Console.ReadLine();
                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();
                    Console.Write("Fax: ");
                    string fax = Console.ReadLine();

                    using (var context2 = new NorthwindContext())
                    {
                        int customerCount = context.Customers.Count() + 1;
                        var newCustomer = new Customer
                        {
                            CompanyName = cName,
                            CustomerId = cName.Substring(0,5).ToUpper(),
                            ContactName = cName2,
                            ContactTitle = cTitle,
                            Address = adress,
                            City = city,
                            Region = region,
                            PostalCode = pCode,
                            Country = country,
                            Phone = phone,
                            Fax = fax
                        };

                        context.Customers.Add(newCustomer);
                        context.SaveChanges();

                        Console.WriteLine("New customer added.");
                    }
                }
            }

            static void CustomersInfo(IEnumerable<Customer> customers)
            {
                for (var i = 0; i < customers.Count(); i++)
                {
                    Console.WriteLine($"{i}. CompanyName: {customers.ElementAt(i).CompanyName}\n" +
                        $"Country: {customers.ElementAt(i).Country}\n" +
                        $"Region: {customers.ElementAt(i).Region}\n" +
                        $"Phonenumber: {customers.ElementAt(i).Phone}\n" +
                        $"Orders: {customers.ElementAt(i).Orders.Count()}");
                    Console.WriteLine();
                }
            }
            static void CustomerInfo(IEnumerable<Customer> customers, int search)
            {
                bool customerFound = false;
                for (var i = 0; i < customers.Count(); i++)
                {
                    if(search == i)
                    {
                        Console.Clear ();
                        Console.WriteLine($"{i}. Companyname: {customers.ElementAt(i).CompanyName} \n" +
                            $"Contactname: {customers.ElementAt(i).ContactName} \n" +
                            $"ContactName: {customers.ElementAt(i).ContactName}\n" +
                            $"ContactTitle: {customers.ElementAt(i).ContactTitle} \n" +
                            $"Adress: {customers.ElementAt(i).Address} \n" +
                            $"City: {customers.ElementAt(i).City} \n" +
                            $"Region: {customers.ElementAt(i).Region} \n" +
                            $"Postalcode: {customers.ElementAt(i).PostalCode} \n" +
                            $"Country: {customers.ElementAt(i).Country} \n" +
                            $"Phone: {customers.ElementAt(i).Phone} \n" +
                            $"Fax: {customers.ElementAt(i).Fax}\n" +
                            $"Orders: {customers.ElementAt(i).Orders.Count()}");
                        customerFound = true;
                    }
                }
                if (!customerFound)
                {
                    Console.Clear();
                    Console.WriteLine("Customer info not found.");
                }
            }
        }
    }
}