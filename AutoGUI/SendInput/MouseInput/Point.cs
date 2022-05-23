using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGUI
{
    /// <summary>
    /// Defines the X and Y axis of a point
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Sets X and Y axis of a point
        /// </summary>
        /// <param name="x">X axis</param>
        /// <param name="y">Y axis</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// X axis
        /// </summary>
        public int X;

        /// <summary>
        /// Y axis
        /// </summary>
        public int Y;

        /// <summary>
        /// Returns string representation of Point structure
        /// </summary>
        /// <returns>X=[X value], Y=[Y value]</returns>
        public override string ToString()
        {
            return "X=" + X + "Y=" + Y;
        }
    }
}
