using System;






namespace DZ_Clinica 
{
    static class Program
    {


        public static string PatientInfo(Patient bolnoy)
        {
            string name = bolnoy.GetName();
            string age = bolnoy.GetAge().ToString();
            string bolezn = bolnoy.GetBolezn();
            string status = bolnoy.GetStatus();
            return name + ", " + age + ", " + bolezn + ", " + status;
        }
        public static string DoctorInfo(Doctor doc)
        {
            string name = doc.GetName();
            string surname = doc.GetSurname();
            string spec = doc.GetSpeciality();
            string stage = doc.GetStage().ToString();
            return name + ", " + surname + ", " + spec + ", стаж " + stage+" лет";
        }
            static void Main()
            {
                Doctor[] doctors = new Doctor[3];
                doctors[0] = new Doctor("Иван Иванович", "Иванов", 54, 20, "Офтальмолог");
                doctors[1] = new Doctor("Петр Васильевич", "Белов", 40, 15, "Терапевт");
                doctors[2] = new Doctor("Мария Романовна", "Хлебова", 54, 20, "Педиатр");

                Patient[] patients = new Patient[2];
                patients[0] = new Patient("Елизавета Алексеевна", "Швец", 20, "ул. Центральная, 2А", "Ангина");
                patients[1] = new Patient("Арсений Павлович", "Игрец", 12, "ул. Ленина, 101", "Боль в животе");



                Console.WriteLine("Выберите пациента, которого отправите к врачу");
                Console.WriteLine("1 - " + PatientInfo(patients[0]));
                Console.WriteLine("2 - " + PatientInfo(patients[1]));
                string vibor = Console.ReadLine();
                Patient patient_vibor = patients[0];
                switch (vibor)
                {
                    case "1":
                        {
                            patient_vibor = patients[0];
                        }
                        break;
                    case "2":
                        {
                            patient_vibor = patients[1];
                        }
                        break;
                    default:
                        Console.WriteLine("Такой пациент не найден");
                        break;
                }
                if (patient_vibor.GetAge() >= 18)
                {
                    doctors[1].Cure(patient_vibor);
                    Console.WriteLine("Лечащий врач - " + DoctorInfo(doctors[1]));
                }
                else
                {
                    doctors[2].Cure(patient_vibor);
                    Console.WriteLine("Лечащий врач - " + DoctorInfo(doctors[2]));
                }

            }
        
    }
}
    
    


