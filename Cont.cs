using System;
using System.Text;

namespace lab6ex1
{
    public class Cont
    {
        protected double Balance { get; set; } = 0;
        protected string AccountNr { get; set; } = string.Empty ;
        protected string Name { get; set; } = string.Empty ;
        protected Guid Id { get; set; }
        private static int NrConturi { get; set; } = 0;
        
       
        public Cont()
        {
        }
    public Cont(string name, string accountNr)

    {
        this.Name = name;
        //this.balance = balance;
        this.AccountNr = accountNr;
        this.Id= Guid.NewGuid();
            NrConturi++;


        }


        /// <summary>
        /// Deposit Amount
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Deposit(double amount)
        {
            this.Balance += amount;
        }

        /// <summary>
        /// withdraw amount
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Withdraw(double amount)
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

            string contId = $"{Id}";

            {
                StringBuilder descriere = new StringBuilder();
                descriere.AppendLine($"Nume:  {Name}");
                descriere.AppendLine($"Cont:  {AccountNr}");
                descriere.AppendLine($"Sold:  {Balance}");
                descriere.Append($"Id:  {contId}");

                return descriere.ToString();
            }

        }
        public static int GetNrConturi()
        {
            return NrConturi;
        }

    }
}
