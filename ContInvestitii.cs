using System;
using System.Text;

namespace lab6ex1
{
    public class ContInvestitii:ContEconomii
    {
        private int Maturity { get; set; } = 0;
    

        

        public ContInvestitii( string name, string accountNr, int maturity, double interest ) : base( name, accountNr, interest)

        {
            this.Maturity = maturity;
        }


        /// <summary>
        /// withdraw amount
        /// </summary>
        /// <param name="amount"></param>
        public override void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                if (Maturity < DateTime.Now.Day)
                {
                    this.Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Nu se pot retrage bani inainta termenului de extragere");

                }
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente");
            }
        }


        public override string ToString()
        {

            {
                string descriere = $"Terment de extragere: {Maturity}";
                return $"{base.ToString()}, \n{ descriere}";

            }
        }


    }
}
