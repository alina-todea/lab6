using System;
using System.Text;

namespace lab6ex1
{
    public class ContEconomii : Cont
    {
        private double Interest { get; set; } = 0;

        public ContEconomii(string name, string accountNr, double interest) : base(name, accountNr)

        {
            this.Interest = interest;
        }
            


        /// <summary>
        /// Deposit Amount
        /// </summary>
        /// <param name="amount"></param>
        public override void Deposit(double amount)
        {
            this.Balance += amount;
            this.Interest = this.Balance * (1 + Interest);
        }

        /// <summary>
        /// withdraw amount
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente");
            }
        }


        public override string ToString()
        {

        

            {
                //StringBuilder descriere = new StringBuilder();
                //descriere.AppendLine($"Rata Dobanzii: {Interest}");

                string descriere = $"Rata Dobanzii: {Interest}";
                return $"{base.ToString()}, \n{ descriere}";

            }
        }
    }
}
