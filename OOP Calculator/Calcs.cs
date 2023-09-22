 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator
{
    internal class Calcs
    {

        public double number1 = 0;
        public double number2 = 0;


        public Calcs(double Cnumber1,double Cnumber2) {    //Constructor
            this.number1 = Cnumber1;
            this.number2 = Cnumber2;
        
        }
         public double Addition() 
        {
            return number1 + number2;
        }
        public void printAdd() {
            Console.WriteLine(Addition());
        }



        public double Subtraction()
        {
            return number1 - number2;
        }
        public void printSub() {
            Console.WriteLine(Subtraction());        
        }

        public double Multiplication()
        {
            return (number1 * number2);

        }

        public void printMulti()
        {
            Console.WriteLine(Multiplication());

        }




        public double Division()
        {

            if(number2 ==0) number2 = 1;
            return number1 / number2;
        }


        public void PrintDiv() { 
            Console.WriteLine(Division());
        }


        public double Modulo()
        {
            if(number2  == 0) number2 = 1;
            return number1 % number2;
        }
        public void printMod()
        {
            Console.WriteLine(Modulo());

        }



    }
}
