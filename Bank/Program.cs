namespace Bank
{
    class PersonalBank
    {
        public static string bankName;
        const int minBalance = 1000;
        const int interest = 7;
        const int perodicity = 6;
        public double balance;
        public PersonalBank(double b)
        {
            Console.Write("the bank name:"+PersonalBank.bankName);
            balance = b;
            Console.WriteLine("\nBank balance:" + balance);
        }
        public void Rename(string name)
        {
            bankName = name;
            Console.WriteLine("Bank name updated:"+bankName);
        }
        public void WithDraw(int amount)
        {
            if (balance - amount < minBalance)
            {
                Console.WriteLine("Insufficiant balance to withdraw");
            }
            else
            {
                Console.WriteLine("Amount withDraw successful of:"+amount);
                balance -= amount;
                Console.WriteLine("Current balance:" + balance);
            }
        }
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Current balance:" + balance);

        }
     public void AddInterest()
        {
            double perodicityInterest = balance * interest * (perodicity / 12.0) / 100;
            double interestRate = balance * interest * (4 / 12.0) / 100 ;
            balance += interestRate;
            Console.WriteLine("Current balance:" + balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Bank name:");
            string name = Console.ReadLine();
            PersonalBank.bankName = name;
            Console.Write("\nEnter the account balance:");
            double b = Convert.ToDouble(Console.ReadLine());
            PersonalBank obj = new PersonalBank(b);
            Console.Write("Enter the bank name to rename it:");
            string rename = Console.ReadLine();
            obj.Rename(rename);
            Console.WriteLine(new string('-', 60));
            int amount;
            char choice;
            do
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Add Interest");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(new string('-', 60));

                switch (choice)
                {
                    case '1':Console.Write("Enter the amount to withdraw:");
                             amount = Convert.ToInt16(Console.ReadLine());
                             obj.WithDraw(amount);
                             break;
                    case '2':Console.Write("Enter the amount to Deposite:");
                             amount = Convert.ToInt16(Console.ReadLine());
                              obj.Deposit(amount);
                              break;
                    case '3':obj.AddInterest();break;
                    case '4':Console.Write("Exit");break;
                    default: Console.WriteLine("Invalid choice. Please try again.");
                            break;
                }
            } while (choice != '4');
        }
    }
}