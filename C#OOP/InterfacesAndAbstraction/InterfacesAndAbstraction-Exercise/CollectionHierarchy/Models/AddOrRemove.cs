using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddOrRemove : IAdd, IRemove
    {
        public AddOrRemove()
        {
            AddColection = new List<string>();
        }
        public List<string> AddColection { get; set ; }

        public List<int> Add(params string[] elements)
        {
            List<int> indexes = new List<int>();
            int insertPosition = 0;
            foreach (var item in elements)
            {
                AddColection.Insert(insertPosition, item);
                indexes.Add(insertPosition);
            }
            return indexes;
        }

        public List<string> Remove(int times)
        {
            var removedColection = new List<string>();            
            for (int i = 0; i < times; i++)
            {
                int removePosition = AddColection.Count - 1;
                string removed = AddColection[removePosition];
                removedColection.Add(removed);
                AddColection.RemoveAt(removePosition);               
            }

            return removedColection;
        }
    }
}
