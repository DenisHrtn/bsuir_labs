namespace Lab_9.MedicalStaff;

internal class Nurse : MedicalStaffBase, IMovable, IWorker, IDiagnosable
{
    public readonly IDiagnoseMethod _diagnoseMethod;
    public Nurse(string name, IDiagnoseMethod diagnoseMethod) : base(name, "Nurse")
    {
        _diagnoseMethod = diagnoseMethod;
    }

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking");
    }

    public void Run()
    {
        Console.WriteLine($"{Name} is running");
    }

    public void DoWork()
    {
        Say("I'm assisting the doctor");
    }

    public void Diagnose()
    {
        _diagnoseMethod.Diagnose();
    }

    public override void GetInfo()
    {
        Say($"Nurse {Name}, profile: {Profile}");
    }
}
