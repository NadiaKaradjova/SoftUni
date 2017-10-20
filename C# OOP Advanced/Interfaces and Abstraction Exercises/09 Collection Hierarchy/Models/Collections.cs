using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public abstract class Collections
    {
        private readonly IList<string> list;

        protected Collections()
        {
            this.list = new List<string>();
        }

        public IList<string> List => this.list;
    }
}