using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Clinica
{
	public class Patient : Person
	{
		private string Bolezn;
		private  string Adress;

		public Patient(string pName, string pSurname, int pAge, string pAdress, string pBolezn) : base(pName, pSurname, pAge)
		{
			SetBolezn(pBolezn);
			SetAdress(pAdress);
		}

		public string GetBolezn() { return Bolezn; }
		public string GetAdress() { return Adress; }

		public void SetBolezn(string pBolezn) { 	Bolezn = pBolezn; }
		private void SetAdress(string pAdress) { Adress = pAdress; }
		public string GetStatus()
        {
			if (Bolezn == "")
				return "Здоров";
			else
				return "Болен";
        }

	}
}
