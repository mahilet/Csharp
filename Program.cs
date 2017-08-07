using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSatemnetCoffe
{
    class Program
    {
        public static void Main(string[] args)

        {
         
            Console.WriteLine("Welcome to mahilet Coffe Shop! ");
          
            int TotalCoffeCost = 0;
            Start:
            Console.WriteLine(" please Select Your Cofee Size : 1- Small Size, 2- Midium Size, 3- Large Size");
            int UserChoice = int.Parse(Console.ReadLine());
       
            switch (UserChoice)
            {

                case 1:
                    TotalCoffeCost += 1;       
                    break;

                case 2:
                    TotalCoffeCost += 2;
                    break;

                case 3:
                    TotalCoffeCost += 3;               
                        break;

                default :
                    Console.WriteLine("Your Choice is {0} in valid", UserChoice);
                    //break;
                    goto Start;
            }

            Decide:
           Console.WriteLine("Do you wnat to buy another coffe - Yes Or No ");

            string UserDecision = Console.ReadLine();

     
            switch (UserDecision.ToUpper())
            {

              case "YES":
                   goto Start;
               case "NO":
                    break;
                default:
                    Console.WriteLine("your choice is {0} in Valide. Please try again..... ", UserDecision);
                   goto Decide;
            }
            Console.WriteLine("Thank you for shooping with us ");
            Console.WriteLine(" Today, Your  Bill Amount IS :{0} ", "$" + "" + TotalCoffeCost);
            Console.ReadKey();
        }
        
    }

}
