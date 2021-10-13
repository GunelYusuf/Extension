using System;

namespace ExtensionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Salam Gunel,Necesen Gunel,hardasan Gunel";
            Console.WriteLine(msg.MatchCount("Gunel"));

            Console.Write("Reqem daxil edin: ");
            int x = int.Parse(Console.ReadLine());
            x.Polendrom();
           
           
            

        }
    }
}
