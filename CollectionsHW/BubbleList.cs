using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHW
{
    class BubbleList : List<int>
    {
        public void BubbleSort()
        {
            for (int j = 0; j < Count - 1; j++)
            {
                for (int i = 0; i < Count - 1 - j; i++)
                {
                    if (this[i] > this[i + 1])
                    {
                        int TmpValue = this[i];

                        this[i] = this[i + 1];

                        this[i + 1] = TmpValue;
                    }
                }
            }
        }
    }
}
