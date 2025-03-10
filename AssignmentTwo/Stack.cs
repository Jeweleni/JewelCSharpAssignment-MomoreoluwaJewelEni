//using System.Collections;
//using System;
//using System.Collections.Generic;

//namespace AssignmentTwo
//{
//    public class StackDesign
//    {


//            static void StackDesignFunc()
//            {
//                var stack = new Stack();
//                stack.Push(1);
//                stack.Push(2);
//                stack.Push(3);

//                Console.WriteLine(stack.Pop()); // Output: 3
//                Console.WriteLine(stack.Pop()); // Output: 2
//                Console.WriteLine(stack.Pop()); // Output: 1
//            }






//        private readonly List<object> _items = new List<object>();

//        // Push method to add an item to the stack
//        public void Push(object obj)
//        {
//            if (obj == null)
//                throw new InvalidOperationException("Cannot add null to the stack.");

//            _items.Add(obj);
//        }

//        // Pop method to remove and return the top item of the stack
//        public object Pop()
//        {
//            if (_items.Count == 0)
//                throw new InvalidOperationException("Stack is empty. Cannot pop an item.");

//            int lastIndex = _items.Count - 1;
//            object topItem = _items[lastIndex];
//            _items.RemoveAt(lastIndex);

//            return topItem;
//        }

//        // Clear method to remove all items from the stack
//        public void Clear()
//        {
//            _items.Clear();
//        }


//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StackDesign
{
    public class Stack : IStack
    {
        private object[] _items = new object[2];
        private int _count = 0;

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null to the stack.");

            //Resizes array if full
            if (_count == _items.Length)
                Resize();

            _items[_count] = obj;
            _count++;
        }

        public object Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var lastItem = _items[--_count];
            _items[_count] = null;
            return lastItem;
        }

        public void Clear()
        {
            for (int i = 0; i < _count; i++)
                _items[i] = null;

            _count = 0;
        }

        private void Resize()
        {
            Array.Resize(ref _items, _items.Length * 2);
        }

        public void DisplayArray()
        {
            foreach (var item in _items)
            {
                if (item == null)
                    continue;

                Console.Write($"{item} ");
            }
        }
    }
}