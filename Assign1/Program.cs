using System;

namespace Assign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                Console.WriteLine("Please enter Your marks (between 0 -100 ) to be graded: ");
                string input = Console.ReadLine();
                int igrade = int.Parse(input);
                if (igrade > 0 && igrade < 101)
                {
                    //Method that calculates the individual grades based on marks.
                    string grade = Calculate_Grade(igrade);

                    Console.WriteLine("Your Grade is :" + grade);
                }
                else
                {
                    //Marks cannot be greater than 100 or less than 0
                    Console.WriteLine("INvalid input");
                }
                Console.WriteLine("Press any key to Exit ...");
                Console.ReadKey(true);
            } // End of Try
            catch
            {
                Console.WriteLine("Error!! Please enter marks between 0 and 100 only!!");
                Console.WriteLine("Press any key to Exit ...");
                Console.ReadKey(true);
            } //End of catch
        }//End of Main

        private static string Calculate_Grade(int mks)
        {
            string strGrade = " ";
            if (mks >= 95 && mks <= 100)
            {
                strGrade = "A+";
            }
            else if (mks >= 90 && mks < 95)
            {
                strGrade = "A";
            }
            else if (mks >= 87 && mks < 90)
            {
                strGrade = "A-";
            }
            else if (mks >= 84 && mks < 87)
            {
                strGrade = "B+";
            }
            else if (mks >= 80 && mks < 84)
            {
                strGrade = "B";
            }
            else if (mks >= 77 && mks < 80)
            {
                strGrade = "B-";
            }
            else if (mks >= 74 && mks < 77)
            {
                strGrade = "C+";
            }
            else if (mks >= 70 && mks < 74)
            {
                strGrade = "C";
            }
            else if (mks >= 67 && mks < 70)
            {
                strGrade = "C-";
            }
            else if (mks >= 63 && mks < 67)
            {
                strGrade = "D+";
            }
            else if (mks >= 60 && mks < 63)
            {
                strGrade = "D";
            }
            else
            {
                strGrade = "F";
            }

            return strGrade;
        }
    }
}
