using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your total Grade? ");
        string grade = Console.ReadLine();

        int parseGrade = int.Parse(grade);

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 60;


        if (parseGrade >= A){
            Console.WriteLine ("Congrats you got a A!");
        }
        else if (parseGrade >= B){
            Console.WriteLine("Nice you've got a decen B!");
        }
        else if (parseGrade >= C){
            Console.WriteLine("Nothing too spectacular you've got a C!");
        }
        else if (parseGrade >= D){
            Console.WriteLine("Do Better you've got a failing grade of D!");
        }
        else if (parseGrade < 60){
            Console.WriteLine("I Don't think this class is for you F!");
        }

    }
}