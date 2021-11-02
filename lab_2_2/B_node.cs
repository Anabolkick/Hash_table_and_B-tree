using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    public class B_node
    {
        public int MaxKeysCount { get; set; }
        public int KeysUsed { get; set; }
        public int?[] Keys { get; set; }
        public B_node Parent_node { get; set; }
        public List<B_node> Children_nodes { get; set; }
        public bool isLeaf { get; set; }
        public B_node(int m)
        {
            MaxKeysCount = m - 1;
            Keys = new int?[MaxKeysCount+1];
            KeysUsed = 0;
            isLeaf = false;
            Children_nodes = new List<B_node>();
        }
    }


}
