using System.Collections.Generic;


namespace CSHFPg427ListOfDucks
{
    public class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
            {
                return 1;
            }
            if (x.Size > y.Size)
            {
                return -1;
            }
            return 0;
        }
    }
}
