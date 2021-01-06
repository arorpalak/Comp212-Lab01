using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***** Palak Arora- 301112908 *****

namespace Palak_Arora_Exercise02
{
    class ExtensionMethodTest
    {
        static void Main(string[] args)  //main method
        {
            StringBuilder strob = new StringBuilder("This is to test whether the extension method count can return a right answer or not.");  //initializing the StringBuilder object.
            Console.WriteLine("The number of words contained in the StringBuilder object strob is {0}", StringBuilderExtension.Extension(strob));  //caling the extension method and passing the value of strob object as a parameter
            Console.ReadLine();
        }//end of main method
    }//end of class
}//end of namespace
