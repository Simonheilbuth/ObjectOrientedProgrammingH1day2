
using ObjectOrientedProgrammingH1day2.Exercises;
using System.Data;
using System.Threading.Channels;

namespace ObjectOrientedProgrammingH1day2;

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

      
       

        AccountOwner Casper = new AccountOwner(10001, "Casper", "Clemmensen");

        Account CasperAccount = new Account(10000, Casper);
        Console.WriteLine(CasperAccount.Balance);
        while (true) 
        {
            Console.WriteLine("Hvor meget vil du sætte ind på Caspers konto?");
            try
            {
                int casperDeposit = int.Parse(Console.ReadLine());

                Console.WriteLine(CasperAccount.Balance);


                if (casperDeposit > 10000)
                {
                    throw new Exception("Du kan ikke indsætte et beløb større end 10000 ind");

                }
                CasperAccount.Deposit(casperDeposit);
                break;

            }

            catch (FormatException Ex1)
            {
                Console.WriteLine($"Fejl {Ex1}");
            }

            catch (InvalidOperationException Ex2)
            {
                Console.WriteLine($"Fejl {Ex2}");
            }

            catch (ArgumentException Ex3)
            {
                Console.WriteLine($"Fejl {Ex3}");
            }

            catch (Exception Ex4)
            {
                Console.WriteLine($"Fejl {Ex4}");
            }

            finally 
            {
                Console.WriteLine($"Din indforståede er {CasperAccount.Balance}");
            }
        }

        Console.WriteLine("Hvor meget vil du hæve på Caspers konto?");
        int casperWithdraw = int.Parse(Console.ReadLine());
        CasperAccount.Withdraw(casperWithdraw);
        Console.WriteLine(CasperAccount.Balance);
        Console.ReadKey();

    }
}
