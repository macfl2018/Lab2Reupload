using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace AreaPerimiterCode

{

    class Program

    {

        static void Main(string[] args)

        {




            decimal lenVar;

            decimal widthVar;

            decimal areaVar;

            decimal perVar;

            int question;



            question = 0;

            while (question == 0)

            {

                Console.WriteLine("We are going to measure the area and perimiter of our rooms. Please start with length of the room then the width");

                string lengthStr = Console.ReadLine();



                Console.WriteLine("Please enter the width of the Room");

                string widthStr = Console.ReadLine();



                lenVar = Convert.ToDecimal(lengthStr);

                widthVar = Convert.ToDecimal(widthStr);

                areaVar = widthVar * lenVar;

                perVar = (widthVar * 2) + (lenVar * 2);



                Console.WriteLine("The area of your room is" + " " + areaVar + " " + "Square feet");

                Console.WriteLine(" The perimiter of your room is" + " " + perVar + " " + "Feet");

                Console.ReadLine();

                Console.WriteLine(" Would you like to try another room? (Yes/No)?");

                string anwQuest = Console.ReadLine();



                if (anwQuest == "No")

                {

                    question++;

                }

                else

                {

                    question = 0;

                }













            }

        }

    }



}




