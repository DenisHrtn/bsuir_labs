namespace Lab_9.MedicalStaff;

internal abstract class MedicalStaffBase
{
    protected string Name;
    protected string Profile;

    protected MedicalStaffBase(string name, string profile)
    {
        Name = name;
        Profile = profile;
    }
    
    // вывод информации о персонале
    public abstract void GetInfo();
    
    // вывод сообщения с именем медперсонала
    public void Say(string message)
    {
        Console.WriteLine($"{Name} says: {message}");
    }
}
