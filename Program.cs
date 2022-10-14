using System;

namespace code_challenge_sgas
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtraction();
        }

        public static void Subtraction()
        {
            Console.WriteLine("Enter firstNumber:");
            int Num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter secondNumber:");
            int Num2= int.Parse(Console.ReadLine());
            if(Num1>=Num2)
            {
                Console.Write(Num2 -  Num1);
            }
            else 
            {
                Console.Write(Num1- Num2);
                
            }
             
             if(Num1 == Num2)
             {
                Console.Write(Num1- Num2);
                
             }

           
        
        } 
    //  question 2
           public static void tittle()
           {
                string[] abc = new string[0];
                 
                
            
            
                
            

            

           }

    }
}
 