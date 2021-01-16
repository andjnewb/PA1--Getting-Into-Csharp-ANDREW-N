using System;

namespace PA1__Getting_Into_Csharp__ANDREW_N_
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.start();


            //Console.ReadKey();

            
        }

        void start()
        {
            //This is our main loop
            Store newStore = new Store();

            Console.WriteLine("---Welcome to Andrew's Item Shop---");

            while (newStore.update() != false)
            {
                newStore.update();
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();

            return;

        }

    }
}
