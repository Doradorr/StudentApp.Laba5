namespace StudentApp.BLL
{
    public interface IBicycleSkill
    {
        string RideBicycle();
    }

    public class Librarian : IBicycleSkill
    {
        public string RideBicycle() => "The librarian rides a bicycle calmly.";
    }

    public class SoftwareDeveloper : IBicycleSkill
    {
        public string RideBicycle() => "The software developer rides a bicycle fast.";
    }
}

