using System;
using System.Threading;

namespace PasswordGen
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("██████╗░░█████╗░░██████╗░██████╗    ░██████╗░███████╗███╗░░██╗███████╗██████╗░░█████╗░████████╗░█████╗░██████╗░");
            Console.WriteLine("██╔══██╗██╔══██╗██╔════╝██╔════╝    ██╔════╝░██╔════╝████╗░██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗");
            Console.WriteLine("██████╔╝███████║╚█████╗░╚█████╗░    ██║░░██╗░█████╗░░██╔██╗██║█████╗░░██████╔╝███████║░░░██║░░░██║░░██║██████╔╝");
            Console.WriteLine("██╔═══╝░██╔══██║░╚═══██╗░╚═══██╗    ██║░░╚██╗██╔══╝░░██║╚████║██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██║░░██║██╔══██╗");
            Console.WriteLine("██║░░░░░██║░░██║██████╔╝██████╔╝    ╚██████╔╝███████╗██║░╚███║███████╗██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║");
            Console.WriteLine("╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═════╝░    ░╚═════╝░╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Please Set Length:");
            var InputLength = int.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine(" ");

                      var chars = "123456789QWE@#RO!$PZSDF%GH$&CV&abc*defghijklmno)(pqrstuv&*^wxyz0123456789~`";
            var stringChars = new char[InputLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            
            Console.WriteLine("Generated Password: " + finalString);
            Console.WriteLine(" ");
            Console.WriteLine("click Enter to Quit...");
            Console.ReadLine();
        }
    }
}
