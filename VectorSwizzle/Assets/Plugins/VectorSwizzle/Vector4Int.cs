/*
**	VectorSwizzle is a set of extensions methods that allows using the "swizzle" feature with unity types.
**  Copyright (C) 2020  z0rg - Sebastien Maire
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
        /// <summary>
        /// Shorthand for writing Vector4Int (0, -1, 0).
        /// </summary>
        private static readonly Vector4Int _down = new Vector4Int(0, -1, 0, 0);
        /// <summary>
        /// Shorthand for writing Vector4Int (0, 1, 0).
        /// </summary>
        private static readonly Vector4Int _up = new Vector4Int(0, 1, 0, 0);
        /// <summary>
        /// Shorthand for writing Vector4Int (1, 1, 1).
        /// </summary>
        private static readonly Vector4Int _one = new Vector4Int(1, 1, 1, 1);
        /// <summary>
        /// Shorthand for writing Vector4Int (0, 0, 0).
        /// </summary>
        private static readonly Vector4Int _zero = new Vector4Int(0, 0, 0, 0);
        /// <summary>
        /// Shorthand for writing Vector4Int (-1, 0, 0).
        /// </summary>
        private static readonly Vector4Int _left = new Vector4Int(-1, 0, 0, 0);
        /// <summary>
        /// Shorthand for writing Vector4Int (1, 0, 0).
        /// </summary>
        private static Vector4Int _right = new Vector4Int(1, 0, 0, 0);

        /// <summary>
        /// X component of the vector.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public int z { get; set; }

        /// <summary>
        /// W component of the vector.
        /// </summary>
        public int w { get; set; }

        public Vector4Int(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Returns true if the objects are equal.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (!(other is Vector4Int)) return false;

            return Equals((Vector4Int)other);
        }

        /// <summary>
        /// Returns true if the objects are equal.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Shorthand for writing Vector4Int (0, -1, 0, 0).
        /// </summary>
        public static Vector4Int down { get { return _down; } }
        //
        // Summary:
        //     Shorthand for writing Vector4Int (0, 1, 0, 0).
        public static Vector4Int up { get { return _up; } }
        /// <summary>
        /// Shorthand for writing Vector4Int (1, 1, 1, 1).
        /// </summary>
        public static Vector4Int one { get { return _one; } }
        /// <summary>
        /// Shorthand for writing Vector4Int (0, 0, 0, 0).
        /// </summary>
        public static Vector4Int zero { get { return _zero; } }
        /// <summary>
        /// Shorthand for writing Vector4Int (-1, 0, 0, 0).
        /// </summary>
        public static Vector4Int left { get { return _left; } }
        /// <summary>
        /// Shorthand for writing Vector4Int (1, 0, 0, 0).
        /// </summary>
        public static Vector4Int right { get { return _right; } }
        //
        // Summary:
        //     
        /// <summary>
        /// Returns the length of this vector (Read Only).
        /// </summary>
        public float magnitude { get { return Distance(Vector4Int.zero, this); } }

        /// <summary>
        /// Returns the squared length of this vector (Read Only).
        /// </summary>
        public int sqrMagnitude { get { return x * x + y * y + z * z + w * w; } }

        /// <summary>
        /// Converts a Vector4 to a Vector4Int by doing a Ceiling to each value.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector4Int CeilToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z), Mathf.CeilToInt(v.w));
        }

        /// <summary>
        /// Returns the distance between a and b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Distance(Vector4Int a, Vector4Int b)
        {
            var vec = b - a;
            var sqrMagn = vec.sqrMagnitude;
            return sqrMagn;
        }

        /// <summary>
        /// Converts a Vector3 to a Vector3Int by doing a Floor to each value.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector4Int FloorToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z), Mathf.FloorToInt(v.w));
        }

        /// <summary>
        /// Returns a vector that is made from the largest components of two vectors.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static Vector4Int Max(Vector4Int lhs, Vector4Int rhs)
        {
            return new Vector4Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
        }

        /// <summary>
        /// Returns a vector that is made from the smallest components of two vectors.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static Vector4Int Min(Vector4Int lhs, Vector4Int rhs)
        {
            return new Vector4Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
        }

        /// <summary>
        /// Converts a Vector3 to a Vector3Int by doing a Round to each value.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static Vector4Int RoundToInt(Vector4 v)
        {
            return new Vector4Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z), Mathf.RoundToInt(v.w));
        }

        /// <summary>
        /// Multiplies two vectors component-wise.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector4Int Scale(Vector4Int a, Vector4Int b)
        {
            return new Vector4Int(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }

        /// <summary>
        /// Clamps the Vector3Int to the bounds given by min and max.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void Clamp(Vector4Int min, Vector4Int max)
        {
            var vec = Vector4Int.Max(Vector4Int.Min(this, max), min);
            this.Set(vec.x, vec.y, vec.z, vec.w);
        }

        /// <summary>
        /// Gets the hash code for the Vector3Int.
        /// </summary>
        /// <returns>The hash code of the Vector4Int.</returns>
        public override int GetHashCode()
        {
            var yHash = y.GetHashCode();
            var zHash = z.GetHashCode();
            var wHash = w.GetHashCode();
            return x.GetHashCode() ^ (yHash << 8) ^ (yHash >> 24) ^ (zHash << 16) ^ (zHash >> 16) ^ (wHash << 24) ^ (wHash >> 8);
        }

        /// <summary>
        /// Multiplies every component of this vector by the same component of scale.
        /// </summary>
        /// <param name="scale"></param>
        public void Scale(Vector4Int scale)
        {
            this.x *= scale.x;
            this.y *= scale.y;
            this.z *= scale.z;
            this.w *= scale.w;
        }

        /// <summary>
        /// Set x, y and z components of an existing Vector3Int.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public void Set(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ToString(null, CultureInfo.InvariantCulture.NumberFormat);
        }

        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.InvariantCulture.NumberFormat);
        }

        /// <summary>
        /// Returns a nicely formatted string for this vector.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts a Vector4Int to a [[Vector4]].
        /// </summary>
        /// <param name="v"></param>
        public static implicit operator Vector4(Vector4Int v)
        {
            return new Vector4(v.x, v.y, v.z, v.w);
        }

        /// <summary>
        /// Converts a Vector4Int to a [[Vector3Int]].
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Vector3Int(Vector4Int v)
        {
            return new Vector3Int(v.x, v.y, v.z);
        }

        /// <summary>
        /// Converts a Vector4Int to a [[Vector2Int]].
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Vector2Int(Vector4Int v)
        {
            return new Vector2Int(v.x, v.y);
        }
    }
}