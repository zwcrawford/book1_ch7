using System;
using System.Collections.Generic;

namespace Classes
{
	/******************************* EMPLOYEE CLASS *******************************/
	public class Employee {

	// An employee has the following properties: firstName, lastName, title, startDate.
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Title { get; set; }
		public int StartDate { get; set; }
	}
	/******************************* COMPANY CLASS *******************************/
	public class Company
	{
		public Company(string name, DateTime DateTime, string Employees)
		{
			name = ($"firstName + lastName");
			DateTime = DateTime.Now;
			Employees = List<Employee>;

		}
    	// Some readonly properties (let's talk about gets, baby)
    	public string Name { get; }
			public DateTime CreatedOn { get; }
    	// Create a public property for holding a list of current employees
			public List<string> Employees = new List<string>();
    	/*
				Create a constructor method that accepts two arguments:
						1. The name of the company
						2. The date it was created
			*/
		public string ListEmployees(string FirstName)
		{
			return Employee[FirstName]
		};
		//The constructor will set the value of the public properties
}
/******************************* PROGRAM CLASS *******************************/
class Program
{
    static void Main(string[] args)
    {
		// Create an instance of a company. Name it whatever you like.

		// Create three employees

		// Assign the employees to the company

		/*
			Iterate the company's employee list and generate the
			simple report shown above
		*/
    }
	}
}