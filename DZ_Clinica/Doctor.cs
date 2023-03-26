using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Clinica
{
	public class Doctor : Person
	{
		private int Stage;
		private string Speciality;

		public Doctor(string pName, string pSurname, int pAge, int pStage, string pSpeciality) : base(pName, pSurname, pAge)
		{
			SetSpeciality(pSpeciality);
			SetStage(pStage);
		}

		public string GetSpeciality() { return Speciality; }
		public int GetStage() { return Stage; }

		private void SetSpeciality(string pSpeciality) { Speciality = pSpeciality; }
		private void SetStage(int pStage) { Stage = pStage; }

		public void Cure(Patient bolnoy)
		{
			switch(bolnoy.GetStatus())
			{
				case "Болен":
                    {
						Console.WriteLine("Пациент действительно болен. Нажмите клавишу Enter, чтобы вылечить");
						bolnoy.SetBolezn("");
						Console.ReadLine();
						Console.WriteLine("Пациент вылечился!");
					}; break;
				case "Здоров":
                    {
						Console.WriteLine("Пациент уже здоров!"); break;
                    }
				default: Console.WriteLine("Не понятно, что с пациентом"); break;
			}
		} 
	}
}
