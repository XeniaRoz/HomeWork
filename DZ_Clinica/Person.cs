using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Clinica
{

	public abstract class Person
    {
		protected string Name;
		protected string Surname;
		protected int Age;
		public Person(string pName, string pSurname, int pAge)
		{
			SetName(pName);
			SetSurname(pSurname);
			SetAge(pAge);
		}
		public string GetName() { return Name; }
		public int GetAge() { return Age; }
		public string GetSurname() { return Surname; }

		protected void SetName(string pName) { Name = pName; }
		protected void SetSurname(string pSurname) { Surname = pSurname; }
		protected void SetAge(int pAge) { Age = pAge; }
	}
}

