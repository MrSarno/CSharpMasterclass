using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Properties
{
    internal class Box
    {
        private int length = 3;
        private int height;
        // private int width = -1;
        private int volume;

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            if (length < 0)
            {
                throw new Exception("Values provided should not be lower than 0.");
            }
            else
            {
                return this.length * this.height * this.Width;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is going to be {1}, and width is {2}." +
                " This means the volume is {3}.", length, height, Width, volume = length * height * Width);
        }
    }
}
