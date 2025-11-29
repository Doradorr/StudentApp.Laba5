namespace StudentApp.BLL
{
    public class InternetService
    {
        public bool IsInternetAvailable { get; set; }

        public string LearnOnline()
        {
            return IsInternetAvailable
                ? "Student is studying online."
                : "No internet connection!";
        }
    }
}

