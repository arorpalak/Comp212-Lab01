using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***** Palak Arora- 301112908 *****

namespace Palak_Arora_Exercise02
{
    static class StringBuilderExtension
    {
        public static int Extension(StringBuilder strob) //static method used to calculate the number of words contained the object strob
        {
            return strob.ToString().Split(' ').Length;  //returning the number of words contained in the strob object as output
        } //end of method
    }//end of class
}//end of namespace
