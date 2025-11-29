namespace StudentApp.BLL
{
    public interface IBicycleSkill
    {
        string RideBicycle();
    }

    public class Librarian : IBicycleSkill
    {
        public string RideBicycle() => "Вміє кататись на велосипеді";
    }

    public class SoftwareDeveloper : IBicycleSkill
    {
        public string RideBicycle() => "Також вміє кататися";
    }
}

