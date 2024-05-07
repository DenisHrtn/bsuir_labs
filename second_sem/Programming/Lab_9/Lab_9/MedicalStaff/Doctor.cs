namespace Lab_9.MedicalStaff;

internal class Doctor : MedicalStaffBase, IMovable, IWorker, IDiagnosable
{
    private readonly IDiagnoseMethod _diagnoseMethod;
    
    public Doctor(string name, IDiagnoseMethod diagnoseMethod) : base(name, "Doctor")
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
        Say("I am examining patients");
    }
    
    public void Diagnose()
    {
        _diagnoseMethod.Diagnose();
    }

    public override void GetInfo()
    {
        Say($"Doctor {Name}, profile: {Profile}");
    }
}
