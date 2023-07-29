using System;

namespace lab6ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
          

          ContCurent cont1 = new ContCurent("Mickey Mouse", "RO12 BLA 123456");
          ContEconomii cont2 = new ContEconomii("Donald Duck", "RO15 BLA 23454", 0.20);
          ContInvestitii cont3 = new ContInvestitii("Donald Duck", "RO18 BLA 33445",  20, 0.14);
            ContInvestitii cont4 = new ContInvestitii("Mickey Mouse", "RO28 BLA 123", 31, 0.14);



            Depunere(cont1, 20);
            Retragere(cont1, 10);
            Retragere(cont1, 15);
            
            
            Depunere(cont2, 20);
            Retragere(cont2, 10);
            Retragere(cont2, 15);
            
            Depunere(cont3, 20);
            Retragere(cont3, 10);
            Retragere(cont3, 15);

            Depunere(cont4, 20);
            Retragere(cont4, 10);
            Retragere(cont4, 15);


            Console.WriteLine($"nr conturi: {Cont.GetNrConturi()}");


            static void Depunere(Cont cont, double suma)
            {
                Console.WriteLine("=====================");
                Console.WriteLine($"Depunere: {suma}");
                cont.Deposit(suma);
                Console.WriteLine("=====================");

                Console.WriteLine($"{cont.ToString()}");
                Console.WriteLine("=====================");


            }

            static void Retragere(Cont cont, double suma)
            {

                Console.WriteLine("=====================");
                Console.WriteLine($"Retragere: {suma}");
                cont.Withdraw(suma);
                Console.WriteLine("=====================");

                Console.WriteLine($"{cont.ToString()}");
                Console.WriteLine("=====================");

            }


        }
    }
}
