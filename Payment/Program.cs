namespace Payment
{
    class DisplayClass
    { 
        public void Display(string mode,int amount)
        {
            Console.WriteLine("Payemnt made throug:" + mode);
            Console.WriteLine("Of amount:" + amount);
        }
    }
    class creditpayment :DisplayClass
    {
        public void Display(string mode, int amount)
        {
            Console.WriteLine("Payemnt made throug:" + mode);
            Console.WriteLine("Of amount:" + amount);
        }
    }
    class bankpayment : DisplayClass
    {
        public void Display(string mode, int amount)
        {
            Console.WriteLine("Payemnt made throug:" + mode);
            Console.WriteLine("Of amount:" + amount);
        }
    }
    class walletpayment : DisplayClass
    {
        public void Display(string mode, int amount)
        {
            Console.WriteLine("Payemnt made throug:" + mode);
            Console.WriteLine("Of amount:" + amount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            walletpayment obj1=new walletpayment();
            obj1.Display("wallet", 100);
            creditpayment obj2=new creditpayment();
            obj2.Display("debit", 1000);
            bankpayment obj3=new bankpayment();
            obj2.Display("bank",3000);
            
        }
    }
}
