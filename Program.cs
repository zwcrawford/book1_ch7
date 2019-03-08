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
	}
	/******************************* COMPANY CLASS *******************************/
	public class Company
	{
    	/*
			Create a constructor method that accepts two arguments:
				1. The name of the company
				2. The date it was created
			*/
		public Company(string name, DateTime companyStart)
		{
			Name = name;
			CreatedOn = companyStart;
			Employees = new List<Employee>();
		}
		// Some readonly properties (let's talk about gets, baby)
		// The constructor will set the value of the public properties
		public string Name { get; }
		public DateTime CreatedOn { get; }
		// Create a public property for holding a list of current employees
		public List<Employee> Employees { get; set; }


		// What I want the output to be:
		// "{Employee (firstName + lastName)} works for {Company Name} as {title} since {DateTime}"
		public void ListEmployees () {
			foreach (Employee employee in Employees) {
				Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToString("MM/dd/yyyy")}.");
			}
		}
	}
	/******************************* PROGRAM CLASS *******************************/
	class Program
	{
    static void Main()
    {
		// Create an instance of a company. Name it whatever you like.
		Company MyCompany = new Company("WidgetsInc", DateTime.Now);

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

		MyCompany.Employees.Add(zac);
		MyCompany.Employees.Add(grady);
		MyCompany.Employees.Add(colleen);

		MyCompany.ListEmployees();
    }
	}
}