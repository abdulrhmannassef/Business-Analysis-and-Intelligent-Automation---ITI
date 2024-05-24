using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class BankAccount
    {
        BigInteger accountNo;
        BigInteger balance=566210001;
        string name;
        //Setters
        public void SetAccountNo(BigInteger _accountNo) { accountNo = _accountNo; }
        public void SetName(string _name) {  name = _name; }
        //Getters
        public string GetName() { return name; }
        public BigInteger GetBalance() { return balance; }
        public BigInteger GetAccountNo() { return accountNo; }
        public void withdraw(int amount) {
            if (amount <= 0) Console.WriteLine("Amount Can Not Be Less than or Equal 0");
            //else if (amount > 0) Console.WriteLine();
            else if (amount > 0 && amount <= balance)
            {
                
                Console.WriteLine($"Transaction is Processing...\n {amount} L.E is being withdrwan");
                balance -= amount;
            }
            else { Console.WriteLine("Amount is greater than you balance!!"); }
        }


        public void deposit(BigInteger _amount) {
            balance += _amount;
        }
           



    }
}
