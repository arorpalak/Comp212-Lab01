using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;
// ***** Palak Arora 301112908 *****

namespace LinkedListLibraryTest
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            var list = new LinkedListLibrary.List<int>(); // create List container

            // create data to store in List
            // use List insert methods       
            list.InsertAtFront(5); // adding the first element or node
            list.InsertAtFront(9); // adding the first element or node
            list.InsertAtBack(3);   // adding the last element or node
            list.InsertAtFront(10);  // adding the first element or node

            list.Display();

            list.RemoveFromFront(); //remove the first element
            list.RemoveFromBack();  //remove the last element
            
            list.Display();
            Console.ReadLine();

        } //end of main method
    }// end of class
}//end of namespace
