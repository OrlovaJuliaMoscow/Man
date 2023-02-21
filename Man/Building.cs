using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;


        int Length
        { 
            get
            {
                return length;
            }
            set
            {
                if (value > 1000)
                    length = 1000;
                else if (value < 10)
                    length = 10;
                else
                    length = value;
            }
        
        }

        int Width
        {
            get
            {
                return width;
            }


            set
            {
                if (value > 1000)
                    width = 1000;
                else if (value < 10)
                    width = 10;
                else
                    width = value;

            }

        }

        int Height
        {
            get
            {
                return height;
            }


            set
            {
                if (value > 500)
                    height = 500;
                else if (value < 3)
                    height = 3;
                else
                    height = value;

            }

        }
        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{adress} {length} {width} {height}";
        }
    }
}
