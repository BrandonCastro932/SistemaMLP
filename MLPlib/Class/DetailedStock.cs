using System;

namespace MLPlib.Class
{
    public class DetailedStock
    {
        public int IDDetailedStock { get; set; }
        public decimal FiletStock { get; set; }
        public decimal ChoppedStock { get; set; }
        public decimal Waste { get; set; }
        public DateTime RegDate { get; set; }


        public DetailedStock()
        {

        }

    }
}