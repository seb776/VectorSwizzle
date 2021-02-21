/*
**	UnitySwizzle is a set of extensions methods that allows using the "swizzle" feature with unity types.
**  Copyright (C) 2020  z0rg - Sebastien Maire
**
**  This program is free software: you can redistribute it and/or modify
**  it under the terms of the GNU General Public License as published by
**  the Free Software Foundation, either version 3 of the License, or
**  (at your option) any later version.
**
**  This program is distributed in the hope that it will be useful,
**  but WITHOUT ANY WARRANTY; without even the implied warranty of
**  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
**  GNU General Public License for more details.
**
**  You should have received a copy of the GNU General Public License
**  along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

namespace VectorSwizzle
{
    [System.Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4Int : IEquatable<Vector4Int>, IFormattable
    {
        //
        // Summary:
        //     Shorthand for writing Vector3Int (0, -1, 0).
        private static readonly Vector4Int _down = new Vector4Int(0, -1, 0, 0);
        //
        // Summary:
        //     Shorthand for writing Vector3Int (0, 1, 0).
        private static readonly Vector4Int _up = new Vector4Int(0, 1, 0, 0);
        //
        // Summary:
        //     Shorthand for writing Vector3Int (1, 1, 1).
        private static readonly Vector4Int _one = new Vector4Int(1, 1, 1, 1);
        //
        // Summary:
        //     Shorthand for writing Vector3Int (0, 0, 0).
        private static readonly Vector4Int _zero = new Vector4Int(0, 0, 0, 0);
        //
        // Summary:
        //     Shorthand for writing Vector3Int (-1, 0, 0).
        private static readonly Vector4Int _left = new Vector4Int(-1, 0, 0, 0);
        //
        // Summary:
        //     Shorthand for writing Vector3Int (1, 0, 0).
        private static Vector4Int _right = new Vector4Int(1, 0, 0, 0);


        // ===================================================================================
        //
        // Summary:
        //     X component of the vector.
        public int x { get; set; }
        //
        // Summary:
        //     Y component of the vector.
        public int y { get; set; }
        //
        // Summary:
        //     Z component of the vector.
        public int z { get; set; }
        //
        // Summary:
        //     W component of the vector.
        public int w { get; set; }

        public Vector4Int(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        //
        // Summary:
        //     Returns true if the objects are equal.
        //
        // Parameters:
        //   other:
        public override bool Equals(object other)
        {
            if (!(other is Vector4Int)) return false;

            return Equals((Vector4Int)other);
        }

        //
        // Summary:
        //     Returns true if the objects are equal.
        //
        // Parameters:
        //   other:
        public bool Equals(Vector4Int other)
        {
            return this == other;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;
                    case 1:
                        return this.y;
                    case 2:
                        return this.z;
                    case 3:
                        return this.w;
                    default:
                        throw new IndexOutOfRangeException(string.Format("Invalid Vector4Int index addressed: {0}!", index));
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;
                    case 1:
                        this.y = value;
                        break;
                    case 2:
                        this.z = value;
                        break;
                    case 3:
                        this.w = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException(string.Format("Invalid Vector4Int index addressed: {0}!", index));
                }
            }
        }

        //
        // Summary:
        //     Shorthand for writing Vector4Int (0, -1, 0, 0).
        public static Vector4Int down { get { return _down; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (0, 1, 0, 0).
        public static Vector4Int up { get { return _up; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (1, 1, 1, 1).
        public static Vector4Int one { get { return _one; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (0, 0, 0, 0).
        public static Vector4Int zero { get { return _zero; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (-1, 0, 0, 0).
        public static Vector4Int left { get { return _left; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (1, 0, 0, 0).
        public static Vector4Int right { get { return _right; } }
        //
        // Summary:
        //     Returns the length of this vector (Read Only).
        public float magnitude { get { return Distance(Vector4Int.zero, this); } }

        //
        // Summary:
        //     Returns the squared length of this vector (Read Only).
        public int sqrMagnitude { get { return x * x + y * y + z * z + w * w; } }

        //
        // Summary:
        //     Converts a Vector4 to a Vector4Int by doing a Ceiling to each value.
        //
        // Parameters:
        //   v:
        public static Vector4Int CeilToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z), Mathf.CeilToInt(v.w));
        }
        //
        // Summary:
        //     Returns the distance between a and b.
        //
        // Parameters:
        //   a:
        //
        //   b:
        public static float Distance(Vector4Int a, Vector4Int b)
        {
            var vec = b - a;
            var sqrMagn = vec.sqrMagnitude;
            return sqrMagn;
        }
        //
        // Summary:
        //     Converts a Vector3 to a Vector3Int by doing a Floor to each value.
        //
        // Parameters:
        //   v:
        public static Vector4Int FloorToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z), Mathf.FloorToInt(v.w));
        }
        //
        // Summary:
        //     Returns a vector that is made from the largest components of two vectors.
        //
        // Parameters:
        //   lhs:
        //
        //   rhs:
        public static Vector4Int Max(Vector4Int lhs, Vector4Int rhs)
        {
            return new Vector4Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
        }
        //
        // Summary:
        //     Returns a vector that is made from the smallest components of two vectors.
        //
        // Parameters:
        //   lhs:
        //
        //   rhs:
        public static Vector4Int Min(Vector4Int lhs, Vector4Int rhs)
        {
            return new Vector4Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
        }
        //
        // Summary:
        //     Converts a Vector3 to a Vector3Int by doing a Round to each value.
        //
        // Parameters:
        //   v:
        public static Vector4Int RoundToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z), Mathf.RoundToInt(v.w));
        }
        //
        // Summary:
        //     Multiplies two vectors component-wise.
        //
        // Parameters:
        //   a:
        //
        //   b:
        public static Vector4Int Scale(Vector4Int a, Vector4Int b)
        {
            return new Vector4Int(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        //
        // Summary:
        //     Clamps the Vector3Int to the bounds given by min and max.
        //
        // Parameters:
        //   min:
        //
        //   max:
        public void Clamp(Vector4Int min, Vector4Int max)
        {
            var vec = Vector4Int.Max(Vector4Int.Min(this, max), min);
            this.Set(vec.x, vec.y, vec.z, vec.w);
        }

        //
        // Summary:
        //     Gets the hash code for the Vector3Int.
        //
        // Returns:
        //     The hash code of the Vector4Int.
        public override int GetHashCode()
        {
            var yHash = y.GetHashCode();
            var zHash = z.GetHashCode();
            var wHash = w.GetHashCode();
            return x.GetHashCode() ^ (yHash << 8) ^ (yHash >> 24) ^ (zHash << 16) ^ (zHash >> 16) ^ (wHash << 24) ^ (wHash >> 8);
        }
        //
        // Summary:
        //     Multiplies every component of this vector by the same component of scale.
        //
        // Parameters:
        //   scale:
        public void Scale(Vector4Int scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
            this.w *= scale.w;
        }
        //
        // Summary:
        //     Set x, y and z components of an existing Vector3Int.
        //
        // Parameters:
        //   x:
        //
        //   y:
        //
        //   z:
        public void Set(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        //
        // Summary:
        //     Returns a nicely formatted string for this vector.
        //
        // Parameters:
        //   format:
        public override string ToString()
        {
            return ToString(null, CultureInfo.InvariantCulture.NumberFormat);
        }
        //
        // Summary:
        //     Returns a nicely formatted string for this vector.
        //
        // Parameters:
        //   format:
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture.NumberFormat);
        }
        //
        // Summary:
        //     Returns a nicely formatted string for this vector.
        //
        // Parameters:
        //   format:
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        public static Vector4Int operator +(Vector4Int a, Vector4Int b)
        {
            return new Vector4Int(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static Vector4Int operator -(Vector4Int a)
        {
            return new Vector4Int(-a.x, -a.y, -a.z, -a.w);
        }
        public static Vector4Int operator -(Vector4Int a, Vector4Int b)
        {
            return new Vector4Int(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
        public static Vector4Int operator *(Vector4Int a, Vector4Int b)
        {
            return new Vector4Int(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static Vector4Int operator *(int a, Vector4Int b)
        {
            return new Vector4Int(a * b.x, a * b.y, a * b.z, a * b.w);
        }
        public static Vector4Int operator *(Vector4Int a, int b)
        {
            return new Vector4Int(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static Vector4Int operator /(Vector4Int a, int b)
        {
            return new Vector4Int(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static bool operator ==(Vector4Int lhs, Vector4Int rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w;
        }
        public static bool operator !=(Vector4Int lhs, Vector4Int rhs)
        {
            return !(lhs == rhs);
        }

        // Converts a Vector4Int to a [[Vector4]].
        public static implicit operator Vector4(Vector4Int v)
        {
            return new Vector4(v.x, v.y, v.z, v.w);
        }

        // Converts a Vector4Int to a [[Vector3Int]].
        public static explicit operator Vector3Int(Vector4Int v)
        {
            return new Vector3Int(v.x, v.y, v.z);
        }

        // Converts a Vector4Int to a [[Vector2Int]].
        public static explicit operator Vector2Int(Vector4Int v)
        {
            return new Vector2Int(v.x, v.y);
        }
    }
}