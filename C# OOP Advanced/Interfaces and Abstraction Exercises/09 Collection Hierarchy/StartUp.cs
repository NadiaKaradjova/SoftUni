using System;
using System.Text;
using CollectionHierarchy.Models;

namespace CollectionHierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollectiont = new AddRemoveCollection();
            var myList = new MyList();

            var itemsToAdd = Console.ReadLine().Split();
            var removeOperationsCount = int.Parse(Console.ReadLine());

            var addCollIndexes = new StringBuilder();
            var addRemoveIndexes = new StringBuilder();
            var myListCollAddIndexes = new StringBuilder();

            foreach (var item in itemsToAdd)
            {
                addCollIndexes.Append(addCollection.Add(item)).Append(" ");
                addRemoveIndexes.Append(addRemoveCollectiont.Add(item)).Append(" ");
                myListCollAddIndexes.Append(myList.Add(item)).Append(" ");
            }

            var removeElementFromAddRemoveColl = new StringBuilder();
            var removeElementFormMyList = new StringBuilder();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                removeElementFromAddRemoveColl.Append(addRemoveCollectiont.Remove()).Append(" ");
                removeElementFormMyList.Append(myList.Remove()).Append(" ");
            }

            Console.WriteLine(addCollIndexes.ToString().Trim());
            Console.WriteLine(addRemoveIndexes.ToString().Trim());
            Console.WriteLine(myListCollAddIndexes.ToString().Trim());
            Console.WriteLine(removeElementFromAddRemoveColl.ToString().Trim());
            Console.WriteLine(removeElementFormMyList.ToString().Trim());

        }
    }
}
