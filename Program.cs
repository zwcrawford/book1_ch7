using System;
using System.Collections.Generic;

namespace Classes
{
	/******************************* EMPLOYEE CLASS *******************************/
	public class Employee {

		// An employee has the following properties: firstName, lastName, title, startDate.
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Title { get; set; }
		public DateTime StartDate { get; set; }

		// Concatenating the first and last names of each employee
		public string FullName
		{
			get
			{
			return string.Format($"{FirstName} {LastName}");
			}
		}
	}

	/******************************* COMPANY CLASS *******************************/
	public class Company
	{
    	/*
			Create a constructor method that accepts two arguments:
				1. The name of the company
				2. The date it was created
			*/
		public Company(string name, DateTime CompanyStart)
		{
			name = Name;
			CreatedOn = CompanyStart;
		}
		DateTime CompanyStart = new DateTime(2010, 6, 10);
    	// Some readonly properties (let's talk about gets, baby)
    	public string Name { get; }
			public DateTime CreatedOn { get; }
    	// Create a public property for holding a list of current employees
			public List<string> EmployeeList = new List<string>();
		//The constructor will set the value of the public properties
	}
	/******************************* PROGRAM CLASS *******************************/
	class Program
	{
    static void Main(string[] args)
    {
		// Create an instance of a company. Name it whatever you like.
		//Company WidgetsInc = new Company("WidgetsInc");
		DateTime zacStart = new DateTime(2011, 6, 10);
		DateTime gradyStart = new DateTime(2013, 6, 10);
		DateTime colleenStart = new DateTime(2015 , 6, 10);
		// Create three employees
		Employee zac = new Employee()
		{
			FirstName = "Zac",
			LastName = "Crawford",
			Title = "COO",
			StartDate = zacStart
		};
		Employee grady = new Employee()
		{
			FirstName = "Grady",
			LastName = "Robbins",
			Title = "CEO",
			StartDate = gradyStart
		};
		Employee colleen = new Employee()
		{
			FirstName = "Colleen",
			LastName = "Woosley",
			Title = "CFO",
			StartDate = colleenStart
		};
		Company MyCompany = new Company( "WidgetsInc", DateTime.Now);

		// What I want the output to be:

		// "{Employee (firstName + lastName)} works for {Company Name} as {title} since {DateTime}"

		// Print full name - check.
		// Print Company name -
		// Print Title -
		// Print DateTime -

		Console.WriteLine($"{zac.FullName} works for");
		Console.WriteLine($"{grady.FullName} works for");
		Console.WriteLine($"{colleen.FullName} works for");
		Console.WriteLine($"{zac.StartDate.ToString("MM/dd/yyyy")}");
		Console.WriteLine($"{colleen.FullName} works for");
		Console.WriteLine($"{MyCompany.Name}");
    }
	}
}