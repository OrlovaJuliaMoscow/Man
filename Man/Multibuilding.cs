using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Man
{
    class Multibuilding : Building
    {
        string levels;

        public Multibuilding(string adress, int length, int width, int height)
            : base(adress, length, width, height);
        int Levels
        {
            get
            {
                return levels;
            }

            set
            {
                if (value > 50)
                    levels = 50;
                else if (value < 1)
                    levels = 1;
                else
                    levels = value;

            }
        }

        {
          this.Levels = levels;
        }
         public string Print()
        {
            string result = base.Print();
            result += $" {levels}";
            return result;
        }
    }
}
