namespace Lab_9.MedicalStaff;

public class Program
{
    static void Main(string[] args)
    {
        // создание фабрики
        MedicalStaffFactory factory = new MedicalStaffFactory();

        // создание объектов диагностики
        IDiagnoseMethod mriDiagnoseMethod = new MRIDiagnoseMethod();
        IDiagnoseMethod xRayDiagnoseMethod = new XRayDiagnoseMethod();

        // Создание коллекции медперсонала
        List<MedicalStaffBase> medicalStaff = new List<MedicalStaffBase>
        {
            factory.CreateNurse("Alice", mriDiagnoseMethod),
            factory.CreateDoctor("Bob", xRayDiagnoseMethod)
        };

        // вызов методов для каждого элемента коллекции
        foreach (var staff in medicalStaff)
        {
            staff.GetInfo();
            
            // проверяем тип объекта и вызываем соответствующие методы
            if (staff is Doctor)
            {
                var doctor = (Doctor)staff;
                doctor.Walk();
                doctor.Run();
                doctor.DoWork();
                doctor.Diagnose();
            }
            else if (staff is Nurse)
            {
                var nurse = (Nurse)staff;
                nurse.Walk();
                nurse.Run();
                nurse.DoWork();
                nurse.Diagnose();
            }

            Console.WriteLine();
        }
    }
}
