using System;
namespace lab6ex1
{
    public class ContCurent : Cont
    {
        public ContCurent(string name, string accountNr) : base (name, accountNr)

        {
            
        }

        public override string ToString()
        {
            return base.ToString();
            
              
            
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
    }
}
