namespace Google
{
    public class Children
    {
        public string ChildrenName { get; set; }
        public string ChildrenBirthDay { get; set; }

        public Children(string childrenName, string childrenBirthDay)
        {
            this.ChildrenName = childrenName;
            this.ChildrenBirthDay = childrenBirthDay;
        }
    }
}
