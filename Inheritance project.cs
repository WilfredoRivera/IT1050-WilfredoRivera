using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        public class Account
        {
            decimal balance;

            public decimal Balance
            {
                get { return balance; }
                set
                {
                    if (value >= 0.0M)
                    {
                        balance = value;
                    }
                    else
                    {
                        balance = 0.0M;
                        Console.WriteLine("Initial balance was invalid. Zero used");
                    }
                }
            }

            public Account(decimal balance)
            {
                Balance = balance;
            }

            public virtual void Credit(decimal amount)
            {
                balance += amount;
            }

            public virtual bool Debit(decimal amount)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    Console.WriteLine("Debit amount exceeded account balance");
                    return false;
                }
            }

        }

        public class SavingsAccount : Account
        {
            decimal interestRate;

            public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
            {
                this.interestRate = interestRate;
            }

            public decimal CalculateInterest()
            {
                return Balance * interestRate / 100m;
            }
        }

        public class CheckingAccount : Account
        {
            decimal fee;

            public CheckingAccount(decimal balance, decimal fee) : base(balance)
            {
                this.fee = fee;
            }

            public override void Credit(decimal amount)
            {
                base.Credit(amount);
                Balance -= fee;
            }

            public override bool Debit(decimal amount)
            {
                if (base.Debit(amount))
                {
                    Balance -= fee;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        class Program
        {
            static void main()
            {
                Account acc1 = new Account(100);
                Console.WriteLine("The intial balance of account 1 is {0:C}", acc1.Balance);
                acc1.Credit(100);
                acc1.Debit(50);
                Console.WriteLine("The final balance of account 1 is {0:C}", acc1.Balance);
                Console.WriteLine();
                Account acc2 = new Account(-100);
                Console.WriteLine("The intial balance of account 2 is {0:C}", acc2.Balance);
                acc2.Credit(30);
                acc2.Debit(40);
                Console.WriteLine("The final balance of account 2 is {0:C}", acc2.Balance);
                Console.WriteLine();

                SavingsAccount acc3 = new SavingsAccount(100, 5);
                Console.WriteLine("The intial balance of account 3 is {0:C}", acc3.Balance);
                acc3.Credit(200);
                acc3.Debit(40);
                Console.WriteLine("The current balance of account 3 is {0:C}", acc3.Balance);
                decimal interest = acc3.CalculateInterest();
                acc3.Credit(interest);
                Console.WriteLine("The final balance of account 3 is {0:C}", acc3.Balance);
                Console.WriteLine();

                CheckingAccount acc4 = new CheckingAccount(100, 2.5M);
                Console.WriteLine("The intial balance of account 4 is {0:C}", acc4.Balance);
                acc4.Credit(100);
                acc4.Debit(70);
                Console.WriteLine("The final balance of account 4 is {0:C}", acc4.Balance);

                Console.ReadKey();
            }
        }
    }









