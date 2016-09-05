using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iHelperClasses;
namespace IhelperTesterConsoele
{
    class Program
    {
        static void Main(string[] args)
        {
            iHelperClasses.ErrorLogger.ErrorWriter("Testloger");

           string password= Console.ReadLine();
           Console.WriteLine("Entered Password"+ password);
           string textencrypt= iHelperClasses.Cryptography.Encrypt(password);
           Console.WriteLine("Password After encrypt:"+textencrypt);
           string decrypt=iHelperClasses.Cryptography.Decrypt(textencrypt);
           Console.WriteLine("Password After Decrypt:" + decrypt);
           Console.ReadKey();
        }
    }
}
