using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddElement : IAdd
    {
        public AddElement()
        {
            AddColection = new List<string>();
        }
        public List<string> AddColection { get; set; }

        public List<int> Add(params string[] elements)
        {
            var indexes = new List<int>();
            foreach (var item in elements)
            {
                AddColection.Add(item);
                indexes.Add(AddColection.Count - 1);
            }

            return indexes;
        }
    }
}
