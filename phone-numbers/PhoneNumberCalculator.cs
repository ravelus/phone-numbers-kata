using System;
using System.Collections.Generic;

namespace PhoneNumbers
{
    public class PhoneNumberCalculator
    {
        const int PHONE_NUMBER_LENGTH = 7;

        int _totalNumbers = 0;

        public int GetTotal()
        {
            return _totalNumbers;
        }

        public void GetChildrenPhoneNumbersFor(PhoneNumberTree current)
        {
            if (current.NodeDepth >= PHONE_NUMBER_LENGTH)
            {
                _totalNumbers++;
                PrintPhoneNumber(current);

                return;
            }

            current.Children = CalculateChildren(current);

            if (current.Children == null)
                return;

            GetChildrenPhoneNumbersFor(current.Children.Item1);
            GetChildrenPhoneNumbersFor(current.Children.Item2);
        }

        Tuple<PhoneNumberTree, PhoneNumberTree> CalculateChildren(PhoneNumberTree node)
        {
            var children = Ruler.GetValidMovesFrom(node.Node);

            if (children == null)
                return null;

            return new Tuple<PhoneNumberTree, PhoneNumberTree>(
                new PhoneNumberTree
                {
                    Parent = node,
                    Node = children.Item1,
                    NodeDepth = node.NodeDepth + 1
                },
                new PhoneNumberTree
                {
                    Parent = node,
                    Node = children.Item2,
                    NodeDepth = node.NodeDepth + 1
                });
        }

        void PrintPhoneNumber(PhoneNumberTree currentNode)
        {
            var phoneNumber = new List<int> { };
            BuildPhoneNumber(currentNode, phoneNumber);

            foreach (var number in phoneNumber)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }

        void BuildPhoneNumber(PhoneNumberTree node, List<int> phoneNumber)
        {
            if (node != null)
            {
                BuildPhoneNumber(node.Parent, phoneNumber);
            }

            if (node != null)
                phoneNumber.Add(node.Node);
        }
    }
}
