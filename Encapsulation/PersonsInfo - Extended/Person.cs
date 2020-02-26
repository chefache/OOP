namespace PersonsInfo
{
	using System;

	public class Person
    {
		private decimal minimalSalary = 460;
		private string firstName;
		private int age;
		private string lastName;
		private decimal salary;


		public Person(string firstName, string lastName, int age, decimal salary)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
			this.Salary = salary;
		}

		public string FirstName
		{
			get 
			{ 
				return firstName; 
			}
			private set
			{
				NameValidator(value);
				this.firstName = value;
			}
		}

		public string LastName
		{
			get 
			{
				return lastName; 
			}
			private set 
			{
				NameValidator(value);
				this.lastName = value; 
			}
		}

		public int Age
		{
			get 
			{
				return age; 
			}
			private set 
			{
				if (value < 0)
				{
					throw new ArgumentException(nameof(value), "cannot be negative number.");
				}
				else
				{
					this.age = value;
				}
			}
		}

		public decimal Salary
		{
			get 
			{ 
				return salary; 
			}
			private set
			{
				if (value < minimalSalary)
				{
					throw new ArgumentException(nameof(value), "cannot be less than 460 leva!");
				}
				this.salary = value;
			}
		}

		public void IncreaseSalary(decimal percentage)
		{
			if (this.Age < 30 )
			{
				percentage = percentage / 2;	
			}
			this.Salary *= 1 + (percentage / 100);
		}

		private static void NameValidator(string value)
		{
			if (!(char.IsUpper(value, 0)))
			{
				throw new ArgumentException(nameof(value), "Name cannot start with minuscule!");
			}
			if (value.Length < 3)
			{
				throw new ArgumentException(nameof(value), "Name cannot contain fewer than 3 symbols!");
			}
		}

		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName} recive {this.Salary:f2} years old.";
		}
	}
}
