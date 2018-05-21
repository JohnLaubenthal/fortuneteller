using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_One___John_Laubenthal
{
    class Program
    {
        static void Main(string[] args)


        {   string result;
            int age;
       
            

            Console.WriteLine("What is your First Name?");
            string FirstName = Console.ReadLine().ToLower();

            Console.WriteLine("What is your Last Name?");
            string LastName = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age?");
             age =  int.Parse(Console.ReadLine());



            Console.WriteLine("What number month were you born in {1-12}?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your favorite color from, ROY G BIV?");
            string response = Console.ReadLine().ToLower();


            if (response == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");

                Console.WriteLine("Choose your favorite color from, ROY G BIV?");
                response = Console.ReadLine().ToLower();
            }
            switch (response)
            {

                case "red":
                    result = "red";
                    break;
                case "orange":
                    result = "orange";
                    break;
                case "yellow":
                    result = "yellow";
                    break;
                case "green":
                    result = "green";
                    break;
                case "blue":
                    result = "blue";
                    break;
                case "indigo":
                    result = "indigo";
                    break;
                case "violet":
                    result = "violet";
                    break;
              

                    }

            Console.WriteLine("How many siblings do you have?");
                int siblings = int.Parse(Console.ReadLine());

            if ((age % 2)== 0)
            {

                //executed when run.
                



            }

            else
            {
                //executed when run.
                


            }
            
        }//main static void end
           

                    
                    

                



             
                   
    } // class end

             


            
                   

             

            

           
} //namespace end











    






    




