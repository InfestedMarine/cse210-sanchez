using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while(true){

            Console.WriteLine("1. Add \n2. Record Goal \n3. Show Goals & Points \n4. Exit");
            string option = Console.ReadLine();

            if(option == "1"){
                manager.UserCreateGoal();
            } else if (option == "2"){
                Console.Write("Enter goal name to record: ");
                string name = Console.ReadLine();
                manager.RecordEvent(name);
            } else if (option == "3"){
                manager.ShowGoals();
                manager.ShowScore();
            } else if (option == "4"){
                break;
            }

        }
    }
}