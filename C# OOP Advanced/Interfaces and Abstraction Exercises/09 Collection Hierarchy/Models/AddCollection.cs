using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Models
{
    public class AddCollection : Collections, IAddCollection
    {
        public int Add(string element)
        {
            this.List.Add(element);
            return this.List.Count - 1;
        }
    }
}