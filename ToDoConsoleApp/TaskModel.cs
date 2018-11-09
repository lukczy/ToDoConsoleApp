using System;
using System.Runtime.InteropServices;

namespace ToDoConsoleApp
{
    public class TaskModel
    {
	    private string _nameTask;
	    private DateTime _dateStart;
	    private DateTime _dateEnd;
	    private bool _allDayTaskFlag;
	    private bool _importantTaskFlag;

	    public void NameTask()
	    {
			Console.WriteLine("Podaj nazwę zadania: ");
		    _nameTask = Console.ReadLine();
	    }
	    public void DateStart()
	    {
		    Console.WriteLine("Podaj datę rozpoczęcia zadania: ");
		    _dateStart = DateTime.Parse(Console.ReadLine());
	    }
	    public void DateEnd()
	    {
		    Console.WriteLine("Podaj datę zakończenia zadania: ");
		    _dateEnd= DateTime.Parse(Console.ReadLine());
	    }
	    public void AllDayTaskFlag()
	    {
		    Console.WriteLine("Czy zadanie jest całodniowe? Wpisz false jeśli nie, wpisz true jeśli tak: ");
		    _allDayTaskFlag = Boolean.Parse(Console.ReadLine());
		}
		public void ImportantTaskFlag()
	    {
		    Console.WriteLine("Czy zadanie jest ważne? Wpisz false jeśli nie, wpisz true jeśli tak: ");
			_importantTaskFlag = Boolean.Parse(Console.ReadLine());
		}

	    public void Show()
	    {
		    Console.WriteLine("Nazwa zadania: " + _nameTask);
		    Console.WriteLine("Data zakończenia: " + _dateStart);
		    Console.WriteLine("Czy całodniowe: " + _allDayTaskFlag);
		    Console.WriteLine("Data zakończenia: " + _dateEnd);
		    Console.WriteLine("Czy ważne: " + _importantTaskFlag);
	    }

	    public string TaskModelLine()
	    {
		    return _nameTask + ";" + _dateStart + ";" + _allDayTaskFlag + ";" + _dateStart + ";" + _importantTaskFlag;
	    }

	public TaskModel()
	    {
			NameTask();
			DateStart();
		    AllDayTaskFlag();
		    if (_allDayTaskFlag is false)
		    {
				DateEnd();
			}
		    ImportantTaskFlag();
	    }

		
    }

	
	
}