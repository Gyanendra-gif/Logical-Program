using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void Calculation(int numb)
        {
            int r, reverse = 0;
            while (numb > 0)
            {
                r = numb % 10;
                reverse = reverse * 10 + r;
                numb = numb / 10;
           }
        }
    }
}
