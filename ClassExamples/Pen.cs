using System;

namespace ClassExamples
{
    internal class Pen
    {
        private string inkColor;
        private string model;
        private int inkAmount;
        public Pen()
        {
            Console.WriteLine("Pen Object");
        }
        public int InkAmount
        {
            get
            {
                return inkAmount;
            }
            set
            {
                if (value < 0)
                {
                    inkAmount = 0;
                }
                else if (value > 100) // Assuming 100 is the maximum ink capacity
                {
                    inkAmount = 100;
                }
                else
                {
                    inkAmount = value;
                }
            }
        }

        public Pen(string inkColor, string model, int inkAmount)
        {
            this.inkColor = inkColor;
            this.model = model;
            this.InkAmount = inkAmount; // Use the property to set the initial value
        }

        public void Write()
        {
            if (InkAmount > 0)
            {
                Console.WriteLine($"Writing in {inkColor} ink.");
                InkAmount--;
            }
            else
            {
                Console.WriteLine("The pen is out of ink!");
            }
        }
    }
}
