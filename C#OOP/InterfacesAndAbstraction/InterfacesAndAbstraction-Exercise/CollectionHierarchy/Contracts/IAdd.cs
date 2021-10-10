using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IAdd
    {
        public List<string> AddColection { get; set; }

        public List<int> Add(params string[] elements);
    }
}
