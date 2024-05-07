namespace Lab_9.MedicalStaff;

internal class MedicalStaffFactory
{
    public Nurse CreateNurse(string name, IDiagnoseMethod diagnoseMethod)
    {
        return new Nurse(name, diagnoseMethod);
    }

    public Doctor CreateDoctor(string name, IDiagnoseMethod diagnoseMethod)
    {
        return new Doctor(name, diagnoseMethod);
    }
}
