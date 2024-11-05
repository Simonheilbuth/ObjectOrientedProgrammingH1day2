
using ObjectOrientedProgrammingH1day2.Exercises;
using System.Threading.Channels;

namespace ObjectOrientedProgrammingH1day2
{
    internal class  Program
    {
        static void Main()
        {
            AccountOwner Simon = new AccountOwner(100000, "Simon", "Jensen");
            AccountAdmin accountAdmin = new AccountAdmin(100001, "Casper", "Hansen");
            Account SimonsAccount = new Account(5000, Simon);
            SimonsAccount.Deposit(1000);
            SimonsAccount.Withdraw(500);
            Console.ReadKey();
        }
    }
}
