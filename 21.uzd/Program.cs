using System;

namespace _21.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Janis", "Peteris", "Andris" };
            Console.WriteLine(names[1]);
            names[2] = "Jekabs";
            Console.WriteLine(names[2]);

        }
    }
}


//Izveidot console aplikāciju, kurā ir definēts string tipa masīvs ar sākotnējām vērtībām "Jānis", "Pēteris", "Andris".
// Izvadīt uz ekrāna masīva otrā elementa vērtību("Pēteris"). Samainīt masīva 3 elementa vērtību no "Andris" uz "Jēkabs".