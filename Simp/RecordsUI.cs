﻿namespace Simp
{
    internal class RecordsUI
    {
        public RecordsUI()
        {
            
        }

        public int MenuSelection()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("- Employee Info Stuff -\n " +
                "\n  1: Display Raw Employee Data " +
                "\n  2: Go Through Records " +
                "\n  3: Add Employee \n  4: Delete Employee " +
                "\n  5: Update Employee " +
                "\n  6: Serialize Employees " +
                "\n  7: Get Employee " +
                "\n  8: Search Employee By ID " +
                "\n  9: Search Employee By Last Name " +
                "\n  10: Search All Employees By Last Name " +
                "\n  11: Print All Employees " +
                "\n  0: Exit");
            System.Console.Write("Enter Choice: ");
            int input = int.Parse(System.Console.ReadLine());
            return input;
        }

        public int RequestInt(string message)
        {
            System.Console.Write(message);
            int input = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            return input;
        }

        public string RequestString(string message)
        {
            System.Console.Write(message);
            string input = System.Console.ReadLine();
            System.Console.WriteLine();

            return input;
        }

        public string getPath(string message)
        {
            System.Console.WriteLine(message);
            string usersPath = System.Console.ReadLine();

            //Console.WriteLine(usersPath + @"\");
            //PrintEmployee(usersPath + @"\");

            return usersPath;
        }

        public string UpdatingMenu(string message)
        {
            return "nothing yet";
        }

    }
}