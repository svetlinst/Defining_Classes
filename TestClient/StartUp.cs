using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().ToArray();
            Dictionary<int, BankAccount> records = new Dictionary<int, BankAccount>();
            while (command[0]!="End")
            {
                switch (command[0])
                {
                    case "Create":
                        Create(command, records);
                        break;
                    case "Deposit":
                        Deposit(command, records);
                        break;
                    case "Withdraw":
                        Withdraw(command, records);
                        break;
                    case "Print":
                        Print(command, records);
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }
        }

        private static void Withdraw(string[] command, Dictionary<int, BankAccount> records)
        {
            var currId = int.Parse(command[1]);
            var amount = decimal.Parse(command[2]);
            if (records.ContainsKey(currId))
            {
                if (records[currId].Balacne>= amount)
                {
                    records[currId].Withdraw(amount);
                }
                else
                {
                    Console.WriteLine($"Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine($"Account does not exist");
            }
        }

        private static void Deposit(string[] command, Dictionary<int, BankAccount> records)
        {
            var currId = int.Parse(command[1]);
            if (records.ContainsKey(currId))
            {
                var amount = decimal.Parse(command[2]);
                records[currId].Deposit(amount);
            }
            else
            {
                Console.WriteLine($"Account does not exist");
            }
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine($"Account already exists");
            }
            else
            {
                var currAccount = new BankAccount();
                currAccount.Id = id;
                accounts.Add(id, currAccount);
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var currId = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(currId))
            {
                Console.WriteLine(accounts[currId].ToString());
            }
            else
            {
                Console.WriteLine($"Account does not exist");

            }
        }
    }
}
