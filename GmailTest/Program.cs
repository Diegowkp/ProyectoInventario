using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary1;

namespace GmailTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GmailLib gmailLib = new GmailLib();
            IList<Label> etiquetas = gmailLib.getCarpetas();
            foreach (Label label in etiquetas)
            {
                Console.WriteLine(label.Name);
            }
            Console.ReadKey();
        }
        
    }
}
