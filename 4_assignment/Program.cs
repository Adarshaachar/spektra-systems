namespace _4_assignment
{
    delegate void PrintCustomerDetails(int id, string name, string Address, string City,string Country);

    class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public string City;
        public string Country;
        public Customer(int id, string name, string address, string city, string country)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Country = country;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
            new Customer(1, "John Doe", "123 Main St", "New York", "USA"),
            new Customer(2, "Alice Smith", "456 Elm St", "Los Angeles", "USA"),
            new Customer(3, "Bob Johnson", "789 Oak St", "Chicago", "USA"),
            new Customer(4, "Emily Brown", "101 Pine St", "San Francisco", "USA"),
            new Customer(5, "David Lee", "202 Maple St", "Boston", "USA")
            };
            PrintCustomerDetails printCustomer = PrintCustomer;
            PrintCustomerDetails(customers, printCustomer);
        }
        static void PrintCustomer(int id, string name, string address, string city, string country)
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Address: {address}, City: {city}, Country: {country}");
        }
        static void PrintCustomerDetails(List<Customer> customers, PrintCustomerDetails printCustomer)
        {
            Console.WriteLine("Customer Details:");
            foreach (var customer in customers)
            {
                // Invoke the delegate to print customer details
                printCustomer(customer.Id, customer.Name, customer.Address, customer.City, customer.Country);
            }
        }
    }
}
