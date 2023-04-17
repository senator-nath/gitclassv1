using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double number1, number2, Result;
            string opration;

            Console.WriteLine("enter first no and press enter:");
            number1= Double.Parse(Console.ReadLine());
            Console.WriteLine("enter opration(+,-,*,/,%) and press enter:");
            opration = Console.ReadLine();
            Console.WriteLine("enter second no and press enter:");
            number2= Double.Parse(Console.ReadLine());

            switch(opration) 
            {
                case "+": Result = number1 + number2;break;
                case "-": Result = number1 - number2;break;
                case"*": Result = number1 * number2;break;
                case"/":
                    if(number2 == 0) 
                    {
                        Console.WriteLine("div by 0 is invalid");return;
                    }
                    Result= number1 / number2;break;
                case "%": Result= number1 % number2;break;
                default: Console.WriteLine("invalid operation");return;
            }
            Console.WriteLine("result:{0}",Result, Math.Round(Result, 4));
            Console.WriteLine("press any key to exit");
            
        }
    }
}
        

    
        
                
         

            
        
    

