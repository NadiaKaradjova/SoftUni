namespace Google
{
    public class Parent
    {
        public string ParentName { get; set; }
        public string ParentBirthDay { get; set; }

        public Parent(string parentName, string parentBirthDay)
        {
            this.ParentName = parentName;
            this.ParentBirthDay = parentBirthDay;
        }
    }
}
