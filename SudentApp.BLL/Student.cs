namespace StudentApp.BLL
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string StudentCard { get; set; }
        public string PassportSN { get; set; }

        public bool HasIdealWeight => Height - 110 == Weight;

        public void GainWeight(int amount)
        {
            Weight += amount;
        }

        public bool LoseWeight(int amount)
        {
            Weight -= amount;
            return HasIdealWeight;
        }
    }
}

