using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class BankAccount
    {


        BigInteger accountNo;
        BigInteger id;
        BigInteger balance =0;
        string name;
        static int ctr;
        //Setters
        public void SetId( BigInteger _id)
        {
            id = _id;
        }
        public void SetAccountNo(BigInteger _accountNo) { accountNo = _accountNo; }
        public void SetName(string _name) { name = _name; }

        public void withdraw(int amount)
        {
            if (amount <= 0) Console.WriteLine("Amount Can Not Be Less than or Equal 0");
            else if (amount > 0 && amount <= balance)
            {

                Console.WriteLine($"Transaction is Processing...\n {amount} L.E is being withdrwan");
                balance -= amount;
            }
            else { Console.WriteLine("Amount is greater than you balance!!"); }
        }


        public void deposit(BigInteger _amount)
        {
            balance += _amount;
        }




        //Getters
        public string GetName() { return name; }
        public BigInteger GetBalance() { return balance; }
        public BigInteger GetAccountNo() { return accountNo; }
        public BigInteger GetID() { return id; }
        public static int GetCounter() //return counter
        {
            return ctr;
        }



        //Define constructors
        public BankAccount()
        {
            ctr++;
        }


        public BankAccount(BigInteger _id , string _name )
        {
            this.id = _id;
            this.name = _name;
            ctr++;
        }

        public BankAccount( BigInteger _accountNumber , BigInteger _amount ) // this constructor take account number and the amount to deposit
        { 
            this.accountNo = _accountNumber;
            deposit(_amount);
            ctr++;
        }





    }
}
