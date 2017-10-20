using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : Collections, IAddRemoveCollection
    {
        public int Add(string element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            var temp = this.List[List.Count - 1];
            this.List.RemoveAt(this.List.Count-1);
            return temp;
        }
    }
}