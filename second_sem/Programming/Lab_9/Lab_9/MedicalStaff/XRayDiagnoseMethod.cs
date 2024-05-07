namespace Lab_9.MedicalStaff;

internal class XRayDiagnoseMethod : IDiagnoseMethod
{
    public void Diagnose()
    {
        Console.WriteLine("Performing X-ray examination");
    }
}