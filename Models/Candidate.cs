namespace RoyalArtSchool.Models
{
    public class Candidate
    {
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public int? Age { get; set; }
        //? ile nullcheck yaptım.
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public String? Email { get; set; }=String.Empty;
        public String? SelectedCourseName {  get; set; }= String.Empty;
        public DateTime AppliedAt { get; set; }
        //bunu yukarıda yapabilirdim ama nesne tanımlanırken yaptım.
        public Candidate()
        {
            AppliedAt = DateTime.Now;
        }



    }
}
