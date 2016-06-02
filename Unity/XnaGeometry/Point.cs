#region License
/*
MIT License
Copyright © 2006 The Mono.Xna Team

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License
using System;

namespace XnaGeometry
{
    public struct Point : IEquatable<Point>
    {
        #region Private Fields

        private static Point zeroPoint = new Point();

        #endregion Private Fields


        #region Public Fields

        public Int32 X;
        public Int32 Y;

        #endregion Public Fields


        #region Properties

        public static Point Zero
        {
            get { return zeroPoint; }
        }

        #endregion Properties


        #region Constructors

        public Point(Int32 x, Int32 y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion Constructors


        #region Public methods

        public static Boolean operator ==(Point a, Point b)
        {
            return a.Equals(b);
        }

        public static Boolean operator !=(Point a, Point b)
        {
            return !a.Equals(b);
        }

        public Boolean Equals(Point other)
        {
            return ((X == other.X) && (Y == other.Y));
        }
        
        public override Boolean Equals(Object obj)
        {
            return (obj is Point) ? Equals((Point)obj) : false;
        }

        public override Int32 GetHashCode()
        {
            return X ^ Y;
        }

        public override String ToString()
        {
            return String.Format("{{X:{0} Y:{1}}}", X, Y);
        }

        #endregion
    }
}

