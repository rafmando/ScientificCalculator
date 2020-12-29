using System;

namespace RafsScientificCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double distance;
            double speed;
            double time;


            Menu();
            void Menu()
            {

                Console.WriteLine("WELCOME TO RAFS SCIENTIFIC CALCULATOR!!");
               
                string[] options = new string[4];

                options[1] = "1.Distance";
                options[2] = "2.Speed";
                options[3] = "3.Time";
              

                for (int x = 0; x < options.Length; x++)
                {
                    Console.WriteLine(options[x]);
                }


                Console.WriteLine("");
                Console.WriteLine("Enter in a number from 1 to 3 from the menu:");
                int input= int.Parse(Console.ReadLine());

                
                if (input == 1)
                {
                    Distance();
                }

                if (input == 2)
                {
                    Speed();
                }

                if (input == 3)
                {
                    Time();
                }
               



            }

            //Methods
           
            void Time()
            {
                Console.WriteLine("");
                Console.WriteLine("Enter in Distance in meters of the object:");
                distance = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter in the Speed in m/s, it took to the given distance of the object:");
                speed = double.Parse(Console.ReadLine());

                double result = distance / speed;


                Console.WriteLine("The Time in seconds of your object is :" + result + "s");
                Console.WriteLine("Would you like to go back to the main menu again ? yes/no");
                string whatNow = Console.ReadLine();

                if (whatNow == "yes")
                {
                    Menu();
                }
                if (whatNow == "no")
                {
                    Console.WriteLine("THANK YOU FOR USING RAFS SCIENTIFIC CALCULATOR!!");
                }
            }
            void Speed()
            {
              
                Console.WriteLine("");
                Console.WriteLine("Enter in Distance in meters of the object:");
                speed = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter in the Time in seconds it took to the given distance of the object:");
                time = double.Parse(Console.ReadLine());

                double result = speed / time;


                Console.WriteLine("The Speed of your object is :"  + result + "m/s");
                Console.WriteLine("Would you like to go back to the main menu again ? yes/no");
                string whatNow = Console.ReadLine();

                if (whatNow == "yes")
                {
                    Menu();
                }
                if (whatNow == "no")
                {
                    Console.WriteLine("THANK YOU FOR USING RAFS SCIENTIFIC CALCULATOR!!");
                }



            }
            void Distance()
            {
                Console.WriteLine("");
                Console.WriteLine("Enter in the Speed in m/s, it took to the given distance of the object:");
                speed = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter in the Time in seconds it took to the given distance of the object:");
                time = double.Parse(Console.ReadLine());

                double result = speed * time;
                Console.WriteLine("The Distance of your object is :" + result + "m");
                Console.WriteLine("Would you like to go back to the main menu again ? yes/no");
                string whatNow = Console.ReadLine();

                if (whatNow == "yes")
                {
                    Menu();
                }
                if (whatNow == "no")
                {
                    Console.WriteLine("THANK YOU FOR USING RAFS SCIENTIFIC CALCULATOR!!");
                }


            }
        }
    }
}
