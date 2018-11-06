using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying5 {
    class Box {
        private int length, width, height;

        public Box(int length, int width, int height) {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int Length {
            get { return length; }
            set { length = value; }
        }

        public int Width {
            get { return width; }
            set { width = value; }
        }

        public int Height{
            get { return height; }
            set { height = value; }
        }

        public int Volume{
            get { return length * height * width; }
        }

        public void ShowBox() {
            Console.WriteLine($"The volume of the box with width {Width}, " +
                $"height {Height} and length {Length} is equals to {Volume}.");
        }
    }
}
