namespace clinic
{
    internal class Program
    {
        static void Main()
        {
            using var _DBcontext = new ClinicDbContext();

            //Add new patient
            var newPatient = new Patient { Name = "Nadir Saad", ContactDetails = "92070706" };
            _DBcontext.Patients.Add(newPatient);
            

            //Retrieve patients
            var patients = _DBcontext.Patients.ToList();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Patient ID: {patient.PatientID}, Name: {patient.Name}");
            }

            _DBcontext.SaveChanges();
        }
    }
}
