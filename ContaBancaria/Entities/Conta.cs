using ContaBancaria.Entities.Exceptions;

namespace ContaBancaria.Entities
{
    public class Conta
    {

        public Conta() { }

        public Conta(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public double Deposit ( double amount)
        {
            return Balance += amount;
        }
        public double WithDraw ( double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException(" The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            return Balance -= amount;
        }              


    }
}