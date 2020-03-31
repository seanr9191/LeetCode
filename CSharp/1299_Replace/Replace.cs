using System;

namespace _1299_Replace
{
    class Replace
    {
        public void run()
        {
            Console.WriteLine("[{0}]", string.Join(", ", ReplaceElements(new int[] { 17, 18, 5, 4, 6, 1 })));
        }

        public int[] ReplaceElements(int[] arr)
        {
            int store = -1;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = store;
                if (store < temp)
                    store = temp;
            }
            return arr;
        }
    }
}
