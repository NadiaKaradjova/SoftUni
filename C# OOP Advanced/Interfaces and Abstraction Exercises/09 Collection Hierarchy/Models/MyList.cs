using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class MyList : Collections, IMyList
    {
        public int Used
        {
            get { return this.List.Count; }
        }

        public int Add(string element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            var temp = this.List[0];
            this.List.RemoveAt(0);
            return temp;
        }
    }
}