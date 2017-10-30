using System;

namespace PhoneNumbers
{
    public class PhoneNumberTree
    {
        public int Node { get; set; }

        public int NodeDepth { get; set; }

        public PhoneNumberTree Parent { get; set; }

        public Tuple<PhoneNumberTree, PhoneNumberTree> Children { get; set; }
    }
}
