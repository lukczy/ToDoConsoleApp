using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsoleApp
{
	partial class Program
    {
		static List<TaskModel> Listazadań = new List<TaskModel>();

	    public static void AddTask()
	    {
		   Listazadań.Add(new TaskModel());
		}


		static void Main(string[] args)

		{

            string command;

            do
            {
				Console.WriteLine("Wpisz polecenie: ");
	            command = Console.ReadLine();

                if (command == "add")
                {
					AddTask();
                }
                else if (command == "Remove")
                {

                }
                else if (command =="ShowAll" )
                {
	                foreach (var taskModel in Listazadań)
	                {
		                taskModel.Show();
	                }
                }
                else if (command == "Write")
                {
	                System.IO.StreamWriter file = new StreamWriter("data.csv");

	                foreach (var taskModel in Listazadań)
	                {
						file.WriteLine(taskModel.TaskModelLine());
					}
					file.Close();
				}
                else if (command == "Read")
                {

                }

			} while (command != "exit");
        }
    }
}
