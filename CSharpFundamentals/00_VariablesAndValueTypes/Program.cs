using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish };
    class Program
    {
        static void Main(string[] args)
        {
            //boolean
            bool isDeclared;
            isDeclared= false;
            bool isDeclaredAndInitialized= false;

            //characters
            char character= 'a';
            char symbol= '&';
            char number= '5';
            char space= ' ';
            char specialCharacter= '\n'; //creates a new line

            // whole numbers
            byte byteExample= 255; //max number for a byte is 255
            sbyte sByteExample= -128;
            short shortExample= 32767;
            Int16 anotherShortExample= 32767; //This is just another way to write a short
            int intMin = -2147483648;
            Int32 intMax = 2147483647; //another way to write an int
            long longExample= 9223372036854775807;
            Int64 longMin = -9223372036854775808; //another way to write a long

            int a = 7;
            int b = -7000;

            byte age = 104;

            // Decimals
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.257890728904578978m;
            Console.WriteLine(1.257890728904578978f);
            Console.WriteLine(1.257890728904578978d);
            Console.WriteLine(1.257890728904578978m);

           

            // Enums

            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            //Structs

            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805, 11, 24);
            DateTime defaultExample = new DateTime();

            int example = int.Parse("5");
            Console.WriteLine(example.GetType());
          
            Console.ReadLine();
        }
    }
}
