using System;

namespace Epicoin.Term
{
    static class Program
    {  
        public static void Main(string[] args)
        {
            string status = args.Length >= 1 ? args[0] : null;
            string namearg = args.Length >= 2 ? args[1] : null;

            if (status == null)
            {
                Console.WriteLine("Choose between [S]Serveur, [M]Miner, [U]User");
                Console.Write("\n status : ");
                status = Library.Epicoin.ReadLine();
            }
            
            if (status == "S" || status == "Serveur")
            {
                Library.Epicoin.Serveur(namearg);
            }
            if (status == "M" || status == "Miner")
            {
                Library.Epicoin.Miner(namearg);
            }
            if (status == "U" || status == "User")
            {
                Library.Epicoin.User(namearg);
            }
            
            Environment.Exit(Environment.ExitCode);
        }
    }
}
