/*
**	VectorSwizzle is a set of extensions methods that allows using the "swizzle" feature with unity types.
**  Copyright (C) 2020  z0rg - Sebastien Maire
*/

using UnityEngine;

namespace VectorSwizzle
{
	public static class Vector2xySwizzleExtension
	{
		// Vector2 with 1 components.
		public static float x(this Vector2 v) { return v.x; }
		public static float x(this Vector2 v, float other) { v.x = other; return v.x(); }
		public static float y(this Vector2 v) { return v.y; }
		public static float y(this Vector2 v, float other) { v.y = other; return v.y(); }

		// Vector2 with 2 components.
		public static Vector2 xx(this Vector2 v) { return new Vector2(v.x, v.x); }
		public static Vector2 yx(this Vector2 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yx(this Vector2 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.yx(); }
		public static Vector2 xy(this Vector2 v) { return new Vector2(v.x, v.y); }
		public static Vector2 xy(this Vector2 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.xy(); }
		public static Vector2 yy(this Vector2 v) { return new Vector2(v.y, v.y); }

		// Vector2 with 3 components.
		public static Vector3 xxx(this Vector2 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 yxx(this Vector2 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 xyx(this Vector2 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 yyx(this Vector2 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 xxy(this Vector2 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 yxy(this Vector2 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 xyy(this Vector2 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 yyy(this Vector2 v) { return new Vector3(v.y, v.y, v.y); }

		// Vector2 with 4 components.
		public static Vector4 xxxx(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 yxxx(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 xyxx(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 yyxx(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 xxyx(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 yxyx(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 xyyx(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 yyyx(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 xxxy(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 yxxy(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 xyxy(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 yyxy(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 xxyy(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 yxyy(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 xyyy(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 yyyy(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3xyzSwizzleExtension
	{
		// Vector3 with 1 components.
		public static float x(this Vector3 v) { return v.x; }
		public static float x(this Vector3 v, float other) { v.x = other; return v.x(); }
		public static float y(this Vector3 v) { return v.y; }
		public static float y(this Vector3 v, float other) { v.y = other; return v.y(); }
		public static float z(this Vector3 v) { return v.z; }
		public static float z(this Vector3 v, float other) { v.z = other; return v.z(); }

		// Vector3 with 2 components.
		public static Vector2 xx(this Vector3 v) { return new Vector2(v.x, v.x); }
		public static Vector2 yx(this Vector3 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yx(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.yx(); }
		public static Vector2 zx(this Vector3 v) { return new Vector2(v.z, v.x); }
		public static Vector2 zx(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.zx(); }
		public static Vector2 xy(this Vector3 v) { return new Vector2(v.x, v.y); }
		public static Vector2 xy(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.xy(); }
		public static Vector2 yy(this Vector3 v) { return new Vector2(v.y, v.y); }
		public static Vector2 zy(this Vector3 v) { return new Vector2(v.z, v.y); }
		public static Vector2 zy(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.zy(); }
		public static Vector2 xz(this Vector3 v) { return new Vector2(v.x, v.z); }
		public static Vector2 xz(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.xz(); }
		public static Vector2 yz(this Vector3 v) { return new Vector2(v.y, v.z); }
		public static Vector2 yz(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.yz(); }
		public static Vector2 zz(this Vector3 v) { return new Vector2(v.z, v.z); }

		// Vector3 with 3 components.
		public static Vector3 xxx(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 yxx(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 zxx(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 xyx(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 yyx(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 zyx(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 zyx(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.zyx(); }
		public static Vector3 xzx(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 yzx(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 yzx(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.yzx(); }
		public static Vector3 zzx(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 xxy(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 yxy(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 zxy(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 zxy(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.zxy(); }
		public static Vector3 xyy(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 yyy(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 zyy(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 xzy(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 xzy(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.xzy(); }
		public static Vector3 yzy(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 zzy(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 xxz(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 yxz(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 yxz(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.yxz(); }
		public static Vector3 zxz(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 xyz(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 xyz(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.xyz(); }
		public static Vector3 yyz(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 zyz(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 xzz(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 yzz(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 zzz(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }

		// Vector3 with 4 components.
		public static Vector4 xxxx(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 yxxx(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 zxxx(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 xyxx(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 yyxx(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 zyxx(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 xzxx(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 yzxx(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 zzxx(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 xxyx(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 yxyx(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 zxyx(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 xyyx(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 yyyx(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 zyyx(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 xzyx(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 yzyx(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 zzyx(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 xxzx(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 yxzx(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 zxzx(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 xyzx(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 yyzx(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 zyzx(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 xzzx(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 yzzx(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 zzzx(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 xxxy(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 yxxy(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 zxxy(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 xyxy(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 yyxy(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 zyxy(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 xzxy(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 yzxy(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 zzxy(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 xxyy(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 yxyy(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 zxyy(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 xyyy(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 yyyy(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 zyyy(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 xzyy(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 yzyy(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 zzyy(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 xxzy(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 yxzy(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 zxzy(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 xyzy(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 yyzy(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 zyzy(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 xzzy(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 yzzy(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 zzzy(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 xxxz(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 yxxz(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 zxxz(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 xyxz(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 yyxz(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 zyxz(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 xzxz(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 yzxz(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 zzxz(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 xxyz(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 yxyz(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 zxyz(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 xyyz(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 yyyz(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 zyyz(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 xzyz(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 yzyz(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 zzyz(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 xxzz(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 yxzz(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 zxzz(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 xyzz(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 yyzz(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 zyzz(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 xzzz(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 yzzz(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 zzzz(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4xyzwSwizzleExtension
	{
		// Vector4 with 1 components.
		public static float x(this Vector4 v) { return v.x; }
		public static float x(this Vector4 v, float other) { v.x = other; return v.x(); }
		public static float y(this Vector4 v) { return v.y; }
		public static float y(this Vector4 v, float other) { v.y = other; return v.y(); }
		public static float z(this Vector4 v) { return v.z; }
		public static float z(this Vector4 v, float other) { v.z = other; return v.z(); }
		public static float w(this Vector4 v) { return v.w; }
		public static float w(this Vector4 v, float other) { v.w = other; return v.w(); }

		// Vector4 with 2 components.
		public static Vector2 xx(this Vector4 v) { return new Vector2(v.x, v.x); }
		public static Vector2 yx(this Vector4 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yx(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.yx(); }
		public static Vector2 zx(this Vector4 v) { return new Vector2(v.z, v.x); }
		public static Vector2 zx(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.zx(); }
		public static Vector2 wx(this Vector4 v) { return new Vector2(v.w, v.x); }
		public static Vector2 wx(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.x = (float)other.y(); return v.wx(); }
		public static Vector2 xy(this Vector4 v) { return new Vector2(v.x, v.y); }
		public static Vector2 xy(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.xy(); }
		public static Vector2 yy(this Vector4 v) { return new Vector2(v.y, v.y); }
		public static Vector2 zy(this Vector4 v) { return new Vector2(v.z, v.y); }
		public static Vector2 zy(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.zy(); }
		public static Vector2 wy(this Vector4 v) { return new Vector2(v.w, v.y); }
		public static Vector2 wy(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.y = (float)other.y(); return v.wy(); }
		public static Vector2 xz(this Vector4 v) { return new Vector2(v.x, v.z); }
		public static Vector2 xz(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.xz(); }
		public static Vector2 yz(this Vector4 v) { return new Vector2(v.y, v.z); }
		public static Vector2 yz(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.yz(); }
		public static Vector2 zz(this Vector4 v) { return new Vector2(v.z, v.z); }
		public static Vector2 wz(this Vector4 v) { return new Vector2(v.w, v.z); }
		public static Vector2 wz(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.z = (float)other.y(); return v.wz(); }
		public static Vector2 xw(this Vector4 v) { return new Vector2(v.x, v.w); }
		public static Vector2 xw(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.w = (float)other.y(); return v.xw(); }
		public static Vector2 yw(this Vector4 v) { return new Vector2(v.y, v.w); }
		public static Vector2 yw(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.w = (float)other.y(); return v.yw(); }
		public static Vector2 zw(this Vector4 v) { return new Vector2(v.z, v.w); }
		public static Vector2 zw(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.w = (float)other.y(); return v.zw(); }
		public static Vector2 ww(this Vector4 v) { return new Vector2(v.w, v.w); }

		// Vector4 with 3 components.
		public static Vector3 xxx(this Vector4 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 yxx(this Vector4 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 zxx(this Vector4 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 wxx(this Vector4 v) { return new Vector3(v.w, v.x, v.x); }
		public static Vector3 xyx(this Vector4 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 yyx(this Vector4 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 zyx(this Vector4 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 zyx(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.zyx(); }
		public static Vector3 wyx(this Vector4 v) { return new Vector3(v.w, v.y, v.x); }
		public static Vector3 wyx(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.wyx(); }
		public static Vector3 xzx(this Vector4 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 yzx(this Vector4 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 yzx(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.yzx(); }
		public static Vector3 zzx(this Vector4 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 wzx(this Vector4 v) { return new Vector3(v.w, v.z, v.x); }
		public static Vector3 wzx(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.wzx(); }
		public static Vector3 xwx(this Vector4 v) { return new Vector3(v.x, v.w, v.x); }
		public static Vector3 ywx(this Vector4 v) { return new Vector3(v.y, v.w, v.x); }
		public static Vector3 ywx(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.ywx(); }
		public static Vector3 zwx(this Vector4 v) { return new Vector3(v.z, v.w, v.x); }
		public static Vector3 zwx(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.zwx(); }
		public static Vector3 wwx(this Vector4 v) { return new Vector3(v.w, v.w, v.x); }
		public static Vector3 xxy(this Vector4 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 yxy(this Vector4 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 zxy(this Vector4 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 zxy(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.zxy(); }
		public static Vector3 wxy(this Vector4 v) { return new Vector3(v.w, v.x, v.y); }
		public static Vector3 wxy(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.wxy(); }
		public static Vector3 xyy(this Vector4 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 yyy(this Vector4 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 zyy(this Vector4 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 wyy(this Vector4 v) { return new Vector3(v.w, v.y, v.y); }
		public static Vector3 xzy(this Vector4 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 xzy(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.xzy(); }
		public static Vector3 yzy(this Vector4 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 zzy(this Vector4 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 wzy(this Vector4 v) { return new Vector3(v.w, v.z, v.y); }
		public static Vector3 wzy(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.wzy(); }
		public static Vector3 xwy(this Vector4 v) { return new Vector3(v.x, v.w, v.y); }
		public static Vector3 xwy(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.xwy(); }
		public static Vector3 ywy(this Vector4 v) { return new Vector3(v.y, v.w, v.y); }
		public static Vector3 zwy(this Vector4 v) { return new Vector3(v.z, v.w, v.y); }
		public static Vector3 zwy(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.zwy(); }
		public static Vector3 wwy(this Vector4 v) { return new Vector3(v.w, v.w, v.y); }
		public static Vector3 xxz(this Vector4 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 yxz(this Vector4 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 yxz(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.yxz(); }
		public static Vector3 zxz(this Vector4 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 wxz(this Vector4 v) { return new Vector3(v.w, v.x, v.z); }
		public static Vector3 wxz(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.wxz(); }
		public static Vector3 xyz(this Vector4 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 xyz(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.xyz(); }
		public static Vector3 yyz(this Vector4 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 zyz(this Vector4 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 wyz(this Vector4 v) { return new Vector3(v.w, v.y, v.z); }
		public static Vector3 wyz(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.wyz(); }
		public static Vector3 xzz(this Vector4 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 yzz(this Vector4 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 zzz(this Vector4 v) { return new Vector3(v.z, v.z, v.z); }
		public static Vector3 wzz(this Vector4 v) { return new Vector3(v.w, v.z, v.z); }
		public static Vector3 xwz(this Vector4 v) { return new Vector3(v.x, v.w, v.z); }
		public static Vector3 xwz(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.xwz(); }
		public static Vector3 ywz(this Vector4 v) { return new Vector3(v.y, v.w, v.z); }
		public static Vector3 ywz(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.ywz(); }
		public static Vector3 zwz(this Vector4 v) { return new Vector3(v.z, v.w, v.z); }
		public static Vector3 wwz(this Vector4 v) { return new Vector3(v.w, v.w, v.z); }
		public static Vector3 xxw(this Vector4 v) { return new Vector3(v.x, v.x, v.w); }
		public static Vector3 yxw(this Vector4 v) { return new Vector3(v.y, v.x, v.w); }
		public static Vector3 yxw(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.yxw(); }
		public static Vector3 zxw(this Vector4 v) { return new Vector3(v.z, v.x, v.w); }
		public static Vector3 zxw(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.zxw(); }
		public static Vector3 wxw(this Vector4 v) { return new Vector3(v.w, v.x, v.w); }
		public static Vector3 xyw(this Vector4 v) { return new Vector3(v.x, v.y, v.w); }
		public static Vector3 xyw(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.xyw(); }
		public static Vector3 yyw(this Vector4 v) { return new Vector3(v.y, v.y, v.w); }
		public static Vector3 zyw(this Vector4 v) { return new Vector3(v.z, v.y, v.w); }
		public static Vector3 zyw(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.zyw(); }
		public static Vector3 wyw(this Vector4 v) { return new Vector3(v.w, v.y, v.w); }
		public static Vector3 xzw(this Vector4 v) { return new Vector3(v.x, v.z, v.w); }
		public static Vector3 xzw(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.xzw(); }
		public static Vector3 yzw(this Vector4 v) { return new Vector3(v.y, v.z, v.w); }
		public static Vector3 yzw(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.yzw(); }
		public static Vector3 zzw(this Vector4 v) { return new Vector3(v.z, v.z, v.w); }
		public static Vector3 wzw(this Vector4 v) { return new Vector3(v.w, v.z, v.w); }
		public static Vector3 xww(this Vector4 v) { return new Vector3(v.x, v.w, v.w); }
		public static Vector3 yww(this Vector4 v) { return new Vector3(v.y, v.w, v.w); }
		public static Vector3 zww(this Vector4 v) { return new Vector3(v.z, v.w, v.w); }
		public static Vector3 www(this Vector4 v) { return new Vector3(v.w, v.w, v.w); }

		// Vector4 with 4 components.
		public static Vector4 xxxx(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 yxxx(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 zxxx(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 wxxx(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.x); }
		public static Vector4 xyxx(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 yyxx(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 zyxx(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 wyxx(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.x); }
		public static Vector4 xzxx(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 yzxx(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 zzxx(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 wzxx(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.x); }
		public static Vector4 xwxx(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.x); }
		public static Vector4 ywxx(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.x); }
		public static Vector4 zwxx(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.x); }
		public static Vector4 wwxx(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.x); }
		public static Vector4 xxyx(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 yxyx(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 zxyx(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 wxyx(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.x); }
		public static Vector4 xyyx(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 yyyx(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 zyyx(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 wyyx(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.x); }
		public static Vector4 xzyx(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 yzyx(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 zzyx(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 wzyx(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.x); }
		public static Vector4 wzyx(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.wzyx(); }
		public static Vector4 xwyx(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.x); }
		public static Vector4 ywyx(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.x); }
		public static Vector4 zwyx(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.x); }
		public static Vector4 zwyx(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.zwyx(); }
		public static Vector4 wwyx(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.x); }
		public static Vector4 xxzx(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 yxzx(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 zxzx(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 wxzx(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.x); }
		public static Vector4 xyzx(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 yyzx(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 zyzx(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 wyzx(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.x); }
		public static Vector4 wyzx(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.wyzx(); }
		public static Vector4 xzzx(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 yzzx(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 zzzx(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 wzzx(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.x); }
		public static Vector4 xwzx(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.x); }
		public static Vector4 ywzx(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.x); }
		public static Vector4 ywzx(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.ywzx(); }
		public static Vector4 zwzx(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.x); }
		public static Vector4 wwzx(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.x); }
		public static Vector4 xxwx(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.x); }
		public static Vector4 yxwx(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.x); }
		public static Vector4 zxwx(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.x); }
		public static Vector4 wxwx(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.x); }
		public static Vector4 xywx(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.x); }
		public static Vector4 yywx(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.x); }
		public static Vector4 zywx(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.x); }
		public static Vector4 zywx(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.zywx(); }
		public static Vector4 wywx(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.x); }
		public static Vector4 xzwx(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.x); }
		public static Vector4 yzwx(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.x); }
		public static Vector4 yzwx(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.yzwx(); }
		public static Vector4 zzwx(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.x); }
		public static Vector4 wzwx(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.x); }
		public static Vector4 xwwx(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.x); }
		public static Vector4 ywwx(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.x); }
		public static Vector4 zwwx(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.x); }
		public static Vector4 wwwx(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.x); }
		public static Vector4 xxxy(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 yxxy(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 zxxy(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 wxxy(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.y); }
		public static Vector4 xyxy(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 yyxy(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 zyxy(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 wyxy(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.y); }
		public static Vector4 xzxy(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 yzxy(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 zzxy(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 wzxy(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.y); }
		public static Vector4 wzxy(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.wzxy(); }
		public static Vector4 xwxy(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.y); }
		public static Vector4 ywxy(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.y); }
		public static Vector4 zwxy(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.y); }
		public static Vector4 zwxy(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.zwxy(); }
		public static Vector4 wwxy(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.y); }
		public static Vector4 xxyy(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 yxyy(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 zxyy(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 wxyy(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.y); }
		public static Vector4 xyyy(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 yyyy(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 zyyy(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 wyyy(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.y); }
		public static Vector4 xzyy(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 yzyy(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 zzyy(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 wzyy(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.y); }
		public static Vector4 xwyy(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.y); }
		public static Vector4 ywyy(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.y); }
		public static Vector4 zwyy(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.y); }
		public static Vector4 wwyy(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.y); }
		public static Vector4 xxzy(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 yxzy(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 zxzy(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 wxzy(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.y); }
		public static Vector4 wxzy(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.wxzy(); }
		public static Vector4 xyzy(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 yyzy(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 zyzy(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 wyzy(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.y); }
		public static Vector4 xzzy(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 yzzy(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 zzzy(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 wzzy(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.y); }
		public static Vector4 xwzy(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.y); }
		public static Vector4 xwzy(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.xwzy(); }
		public static Vector4 ywzy(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.y); }
		public static Vector4 zwzy(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.y); }
		public static Vector4 wwzy(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.y); }
		public static Vector4 xxwy(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.y); }
		public static Vector4 yxwy(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.y); }
		public static Vector4 zxwy(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.y); }
		public static Vector4 zxwy(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.zxwy(); }
		public static Vector4 wxwy(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.y); }
		public static Vector4 xywy(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.y); }
		public static Vector4 yywy(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.y); }
		public static Vector4 zywy(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.y); }
		public static Vector4 wywy(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.y); }
		public static Vector4 xzwy(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.y); }
		public static Vector4 xzwy(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.xzwy(); }
		public static Vector4 yzwy(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.y); }
		public static Vector4 zzwy(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.y); }
		public static Vector4 wzwy(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.y); }
		public static Vector4 xwwy(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.y); }
		public static Vector4 ywwy(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.y); }
		public static Vector4 zwwy(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.y); }
		public static Vector4 wwwy(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.y); }
		public static Vector4 xxxz(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 yxxz(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 zxxz(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 wxxz(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.z); }
		public static Vector4 xyxz(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 yyxz(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 zyxz(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 wyxz(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.z); }
		public static Vector4 wyxz(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.wyxz(); }
		public static Vector4 xzxz(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 yzxz(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 zzxz(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 wzxz(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.z); }
		public static Vector4 xwxz(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.z); }
		public static Vector4 ywxz(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.z); }
		public static Vector4 ywxz(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.ywxz(); }
		public static Vector4 zwxz(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.z); }
		public static Vector4 wwxz(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.z); }
		public static Vector4 xxyz(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 yxyz(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 zxyz(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 wxyz(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.z); }
		public static Vector4 wxyz(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.wxyz(); }
		public static Vector4 xyyz(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 yyyz(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 zyyz(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 wyyz(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.z); }
		public static Vector4 xzyz(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 yzyz(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 zzyz(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 wzyz(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.z); }
		public static Vector4 xwyz(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.z); }
		public static Vector4 xwyz(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.xwyz(); }
		public static Vector4 ywyz(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.z); }
		public static Vector4 zwyz(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.z); }
		public static Vector4 wwyz(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.z); }
		public static Vector4 xxzz(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 yxzz(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 zxzz(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 wxzz(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.z); }
		public static Vector4 xyzz(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 yyzz(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 zyzz(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 wyzz(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.z); }
		public static Vector4 xzzz(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 yzzz(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 zzzz(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.z); }
		public static Vector4 wzzz(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.z); }
		public static Vector4 xwzz(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.z); }
		public static Vector4 ywzz(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.z); }
		public static Vector4 zwzz(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.z); }
		public static Vector4 wwzz(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.z); }
		public static Vector4 xxwz(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.z); }
		public static Vector4 yxwz(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.z); }
		public static Vector4 yxwz(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.yxwz(); }
		public static Vector4 zxwz(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.z); }
		public static Vector4 wxwz(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.z); }
		public static Vector4 xywz(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.z); }
		public static Vector4 xywz(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.xywz(); }
		public static Vector4 yywz(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.z); }
		public static Vector4 zywz(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.z); }
		public static Vector4 wywz(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.z); }
		public static Vector4 xzwz(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.z); }
		public static Vector4 yzwz(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.z); }
		public static Vector4 zzwz(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.z); }
		public static Vector4 wzwz(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.z); }
		public static Vector4 xwwz(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.z); }
		public static Vector4 ywwz(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.z); }
		public static Vector4 zwwz(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.z); }
		public static Vector4 wwwz(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.z); }
		public static Vector4 xxxw(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.w); }
		public static Vector4 yxxw(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.w); }
		public static Vector4 zxxw(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.w); }
		public static Vector4 wxxw(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.w); }
		public static Vector4 xyxw(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.w); }
		public static Vector4 yyxw(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.w); }
		public static Vector4 zyxw(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.w); }
		public static Vector4 zyxw(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.zyxw(); }
		public static Vector4 wyxw(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.w); }
		public static Vector4 xzxw(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.w); }
		public static Vector4 yzxw(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.w); }
		public static Vector4 yzxw(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.yzxw(); }
		public static Vector4 zzxw(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.w); }
		public static Vector4 wzxw(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.w); }
		public static Vector4 xwxw(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.w); }
		public static Vector4 ywxw(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.w); }
		public static Vector4 zwxw(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.w); }
		public static Vector4 wwxw(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.w); }
		public static Vector4 xxyw(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.w); }
		public static Vector4 yxyw(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.w); }
		public static Vector4 zxyw(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.w); }
		public static Vector4 zxyw(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.zxyw(); }
		public static Vector4 wxyw(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.w); }
		public static Vector4 xyyw(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.w); }
		public static Vector4 yyyw(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.w); }
		public static Vector4 zyyw(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.w); }
		public static Vector4 wyyw(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.w); }
		public static Vector4 xzyw(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.w); }
		public static Vector4 xzyw(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.xzyw(); }
		public static Vector4 yzyw(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.w); }
		public static Vector4 zzyw(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.w); }
		public static Vector4 wzyw(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.w); }
		public static Vector4 xwyw(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.w); }
		public static Vector4 ywyw(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.w); }
		public static Vector4 zwyw(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.w); }
		public static Vector4 wwyw(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.w); }
		public static Vector4 xxzw(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.w); }
		public static Vector4 yxzw(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.w); }
		public static Vector4 yxzw(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.yxzw(); }
		public static Vector4 zxzw(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.w); }
		public static Vector4 wxzw(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.w); }
		public static Vector4 xyzw(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w); }
		public static Vector4 xyzw(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.xyzw(); }
		public static Vector4 yyzw(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.w); }
		public static Vector4 zyzw(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.w); }
		public static Vector4 wyzw(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.w); }
		public static Vector4 xzzw(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.w); }
		public static Vector4 yzzw(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.w); }
		public static Vector4 zzzw(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.w); }
		public static Vector4 wzzw(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.w); }
		public static Vector4 xwzw(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.w); }
		public static Vector4 ywzw(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.w); }
		public static Vector4 zwzw(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.w); }
		public static Vector4 wwzw(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.w); }
		public static Vector4 xxww(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.w); }
		public static Vector4 yxww(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.w); }
		public static Vector4 zxww(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.w); }
		public static Vector4 wxww(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.w); }
		public static Vector4 xyww(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.w); }
		public static Vector4 yyww(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.w); }
		public static Vector4 zyww(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.w); }
		public static Vector4 wyww(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.w); }
		public static Vector4 xzww(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.w); }
		public static Vector4 yzww(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.w); }
		public static Vector4 zzww(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.w); }
		public static Vector4 wzww(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.w); }
		public static Vector4 xwww(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.w); }
		public static Vector4 ywww(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.w); }
		public static Vector4 zwww(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.w); }
		public static Vector4 wwww(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.w); }
	}

	public static class Vector2rgSwizzleExtension
	{
		// Vector2 with 1 components.
		public static float r(this Vector2 v) { return v.x; }
		public static float r(this Vector2 v, float other) { v.x = other; return v.r(); }
		public static float g(this Vector2 v) { return v.y; }
		public static float g(this Vector2 v, float other) { v.y = other; return v.g(); }

		// Vector2 with 2 components.
		public static Vector2 rr(this Vector2 v) { return new Vector2(v.x, v.x); }
		public static Vector2 gr(this Vector2 v) { return new Vector2(v.y, v.x); }
		public static Vector2 gr(this Vector2 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.gr(); }
		public static Vector2 rg(this Vector2 v) { return new Vector2(v.x, v.y); }
		public static Vector2 rg(this Vector2 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.rg(); }
		public static Vector2 gg(this Vector2 v) { return new Vector2(v.y, v.y); }

		// Vector2 with 3 components.
		public static Vector3 rrr(this Vector2 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 grr(this Vector2 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 rgr(this Vector2 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 ggr(this Vector2 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 rrg(this Vector2 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 grg(this Vector2 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 rgg(this Vector2 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ggg(this Vector2 v) { return new Vector3(v.y, v.y, v.y); }

		// Vector2 with 4 components.
		public static Vector4 rrrr(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 grrr(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 rgrr(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ggrr(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 rrgr(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 grgr(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 rggr(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 gggr(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 rrrg(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 grrg(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 rgrg(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ggrg(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 rrgg(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 grgg(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 rggg(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 gggg(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3rgbSwizzleExtension
	{
		// Vector3 with 1 components.
		public static float r(this Vector3 v) { return v.x; }
		public static float r(this Vector3 v, float other) { v.x = other; return v.r(); }
		public static float g(this Vector3 v) { return v.y; }
		public static float g(this Vector3 v, float other) { v.y = other; return v.g(); }
		public static float b(this Vector3 v) { return v.z; }
		public static float b(this Vector3 v, float other) { v.z = other; return v.b(); }

		// Vector3 with 2 components.
		public static Vector2 rr(this Vector3 v) { return new Vector2(v.x, v.x); }
		public static Vector2 gr(this Vector3 v) { return new Vector2(v.y, v.x); }
		public static Vector2 gr(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.gr(); }
		public static Vector2 br(this Vector3 v) { return new Vector2(v.z, v.x); }
		public static Vector2 br(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.br(); }
		public static Vector2 rg(this Vector3 v) { return new Vector2(v.x, v.y); }
		public static Vector2 rg(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.rg(); }
		public static Vector2 gg(this Vector3 v) { return new Vector2(v.y, v.y); }
		public static Vector2 bg(this Vector3 v) { return new Vector2(v.z, v.y); }
		public static Vector2 bg(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.bg(); }
		public static Vector2 rb(this Vector3 v) { return new Vector2(v.x, v.z); }
		public static Vector2 rb(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.rb(); }
		public static Vector2 gb(this Vector3 v) { return new Vector2(v.y, v.z); }
		public static Vector2 gb(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.gb(); }
		public static Vector2 bb(this Vector3 v) { return new Vector2(v.z, v.z); }

		// Vector3 with 3 components.
		public static Vector3 rrr(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 grr(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 brr(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 rgr(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 ggr(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 bgr(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 bgr(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.bgr(); }
		public static Vector3 rbr(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 gbr(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 gbr(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.gbr(); }
		public static Vector3 bbr(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 rrg(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 grg(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 brg(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 brg(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.brg(); }
		public static Vector3 rgg(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ggg(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 bgg(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 rbg(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 rbg(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.rbg(); }
		public static Vector3 gbg(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 bbg(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 rrb(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 grb(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 grb(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.grb(); }
		public static Vector3 brb(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 rgb(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 rgb(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.rgb(); }
		public static Vector3 ggb(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 bgb(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 rbb(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 gbb(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 bbb(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }

		// Vector3 with 4 components.
		public static Vector4 rrrr(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 grrr(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 brrr(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 rgrr(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ggrr(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 bgrr(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 rbrr(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 gbrr(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 bbrr(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 rrgr(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 grgr(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 brgr(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 rggr(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 gggr(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 bggr(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 rbgr(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 gbgr(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 bbgr(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 rrbr(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 grbr(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 brbr(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 rgbr(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 ggbr(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 bgbr(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 rbbr(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 gbbr(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 bbbr(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 rrrg(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 grrg(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 brrg(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 rgrg(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ggrg(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 bgrg(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 rbrg(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 gbrg(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 bbrg(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 rrgg(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 grgg(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 brgg(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 rggg(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 gggg(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 bggg(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 rbgg(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 gbgg(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 bbgg(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 rrbg(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 grbg(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 brbg(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 rgbg(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 ggbg(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 bgbg(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 rbbg(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 gbbg(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 bbbg(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 rrrb(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 grrb(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 brrb(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 rgrb(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 ggrb(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 bgrb(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 rbrb(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 gbrb(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 bbrb(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 rrgb(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 grgb(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 brgb(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 rggb(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 gggb(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 bggb(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 rbgb(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 gbgb(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 bbgb(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 rrbb(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 grbb(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 brbb(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 rgbb(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 ggbb(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 bgbb(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 rbbb(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 gbbb(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 bbbb(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4rgbaSwizzleExtension
	{
		// Vector4 with 1 components.
		public static float r(this Vector4 v) { return v.x; }
		public static float r(this Vector4 v, float other) { v.x = other; return v.r(); }
		public static float g(this Vector4 v) { return v.y; }
		public static float g(this Vector4 v, float other) { v.y = other; return v.g(); }
		public static float b(this Vector4 v) { return v.z; }
		public static float b(this Vector4 v, float other) { v.z = other; return v.b(); }
		public static float a(this Vector4 v) { return v.w; }
		public static float a(this Vector4 v, float other) { v.w = other; return v.a(); }

		// Vector4 with 2 components.
		public static Vector2 rr(this Vector4 v) { return new Vector2(v.x, v.x); }
		public static Vector2 gr(this Vector4 v) { return new Vector2(v.y, v.x); }
		public static Vector2 gr(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.gr(); }
		public static Vector2 br(this Vector4 v) { return new Vector2(v.z, v.x); }
		public static Vector2 br(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.br(); }
		public static Vector2 ar(this Vector4 v) { return new Vector2(v.w, v.x); }
		public static Vector2 ar(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.x = (float)other.y(); return v.ar(); }
		public static Vector2 rg(this Vector4 v) { return new Vector2(v.x, v.y); }
		public static Vector2 rg(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.rg(); }
		public static Vector2 gg(this Vector4 v) { return new Vector2(v.y, v.y); }
		public static Vector2 bg(this Vector4 v) { return new Vector2(v.z, v.y); }
		public static Vector2 bg(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.bg(); }
		public static Vector2 ag(this Vector4 v) { return new Vector2(v.w, v.y); }
		public static Vector2 ag(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.y = (float)other.y(); return v.ag(); }
		public static Vector2 rb(this Vector4 v) { return new Vector2(v.x, v.z); }
		public static Vector2 rb(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.rb(); }
		public static Vector2 gb(this Vector4 v) { return new Vector2(v.y, v.z); }
		public static Vector2 gb(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.gb(); }
		public static Vector2 bb(this Vector4 v) { return new Vector2(v.z, v.z); }
		public static Vector2 ab(this Vector4 v) { return new Vector2(v.w, v.z); }
		public static Vector2 ab(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.z = (float)other.y(); return v.ab(); }
		public static Vector2 ra(this Vector4 v) { return new Vector2(v.x, v.w); }
		public static Vector2 ra(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.w = (float)other.y(); return v.ra(); }
		public static Vector2 ga(this Vector4 v) { return new Vector2(v.y, v.w); }
		public static Vector2 ga(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.w = (float)other.y(); return v.ga(); }
		public static Vector2 ba(this Vector4 v) { return new Vector2(v.z, v.w); }
		public static Vector2 ba(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.w = (float)other.y(); return v.ba(); }
		public static Vector2 aa(this Vector4 v) { return new Vector2(v.w, v.w); }

		// Vector4 with 3 components.
		public static Vector3 rrr(this Vector4 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 grr(this Vector4 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 brr(this Vector4 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 arr(this Vector4 v) { return new Vector3(v.w, v.x, v.x); }
		public static Vector3 rgr(this Vector4 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 ggr(this Vector4 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 bgr(this Vector4 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 bgr(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.bgr(); }
		public static Vector3 agr(this Vector4 v) { return new Vector3(v.w, v.y, v.x); }
		public static Vector3 agr(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.agr(); }
		public static Vector3 rbr(this Vector4 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 gbr(this Vector4 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 gbr(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.gbr(); }
		public static Vector3 bbr(this Vector4 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 abr(this Vector4 v) { return new Vector3(v.w, v.z, v.x); }
		public static Vector3 abr(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.abr(); }
		public static Vector3 rar(this Vector4 v) { return new Vector3(v.x, v.w, v.x); }
		public static Vector3 gar(this Vector4 v) { return new Vector3(v.y, v.w, v.x); }
		public static Vector3 gar(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.gar(); }
		public static Vector3 bar(this Vector4 v) { return new Vector3(v.z, v.w, v.x); }
		public static Vector3 bar(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.bar(); }
		public static Vector3 aar(this Vector4 v) { return new Vector3(v.w, v.w, v.x); }
		public static Vector3 rrg(this Vector4 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 grg(this Vector4 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 brg(this Vector4 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 brg(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.brg(); }
		public static Vector3 arg(this Vector4 v) { return new Vector3(v.w, v.x, v.y); }
		public static Vector3 arg(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.arg(); }
		public static Vector3 rgg(this Vector4 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ggg(this Vector4 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 bgg(this Vector4 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 agg(this Vector4 v) { return new Vector3(v.w, v.y, v.y); }
		public static Vector3 rbg(this Vector4 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 rbg(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.rbg(); }
		public static Vector3 gbg(this Vector4 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 bbg(this Vector4 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 abg(this Vector4 v) { return new Vector3(v.w, v.z, v.y); }
		public static Vector3 abg(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.abg(); }
		public static Vector3 rag(this Vector4 v) { return new Vector3(v.x, v.w, v.y); }
		public static Vector3 rag(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.rag(); }
		public static Vector3 gag(this Vector4 v) { return new Vector3(v.y, v.w, v.y); }
		public static Vector3 bag(this Vector4 v) { return new Vector3(v.z, v.w, v.y); }
		public static Vector3 bag(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.bag(); }
		public static Vector3 aag(this Vector4 v) { return new Vector3(v.w, v.w, v.y); }
		public static Vector3 rrb(this Vector4 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 grb(this Vector4 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 grb(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.grb(); }
		public static Vector3 brb(this Vector4 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 arb(this Vector4 v) { return new Vector3(v.w, v.x, v.z); }
		public static Vector3 arb(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.arb(); }
		public static Vector3 rgb(this Vector4 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 rgb(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.rgb(); }
		public static Vector3 ggb(this Vector4 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 bgb(this Vector4 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 agb(this Vector4 v) { return new Vector3(v.w, v.y, v.z); }
		public static Vector3 agb(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.agb(); }
		public static Vector3 rbb(this Vector4 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 gbb(this Vector4 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 bbb(this Vector4 v) { return new Vector3(v.z, v.z, v.z); }
		public static Vector3 abb(this Vector4 v) { return new Vector3(v.w, v.z, v.z); }
		public static Vector3 rab(this Vector4 v) { return new Vector3(v.x, v.w, v.z); }
		public static Vector3 rab(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.rab(); }
		public static Vector3 gab(this Vector4 v) { return new Vector3(v.y, v.w, v.z); }
		public static Vector3 gab(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.gab(); }
		public static Vector3 bab(this Vector4 v) { return new Vector3(v.z, v.w, v.z); }
		public static Vector3 aab(this Vector4 v) { return new Vector3(v.w, v.w, v.z); }
		public static Vector3 rra(this Vector4 v) { return new Vector3(v.x, v.x, v.w); }
		public static Vector3 gra(this Vector4 v) { return new Vector3(v.y, v.x, v.w); }
		public static Vector3 gra(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.gra(); }
		public static Vector3 bra(this Vector4 v) { return new Vector3(v.z, v.x, v.w); }
		public static Vector3 bra(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.bra(); }
		public static Vector3 ara(this Vector4 v) { return new Vector3(v.w, v.x, v.w); }
		public static Vector3 rga(this Vector4 v) { return new Vector3(v.x, v.y, v.w); }
		public static Vector3 rga(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.rga(); }
		public static Vector3 gga(this Vector4 v) { return new Vector3(v.y, v.y, v.w); }
		public static Vector3 bga(this Vector4 v) { return new Vector3(v.z, v.y, v.w); }
		public static Vector3 bga(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.bga(); }
		public static Vector3 aga(this Vector4 v) { return new Vector3(v.w, v.y, v.w); }
		public static Vector3 rba(this Vector4 v) { return new Vector3(v.x, v.z, v.w); }
		public static Vector3 rba(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.rba(); }
		public static Vector3 gba(this Vector4 v) { return new Vector3(v.y, v.z, v.w); }
		public static Vector3 gba(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.gba(); }
		public static Vector3 bba(this Vector4 v) { return new Vector3(v.z, v.z, v.w); }
		public static Vector3 aba(this Vector4 v) { return new Vector3(v.w, v.z, v.w); }
		public static Vector3 raa(this Vector4 v) { return new Vector3(v.x, v.w, v.w); }
		public static Vector3 gaa(this Vector4 v) { return new Vector3(v.y, v.w, v.w); }
		public static Vector3 baa(this Vector4 v) { return new Vector3(v.z, v.w, v.w); }
		public static Vector3 aaa(this Vector4 v) { return new Vector3(v.w, v.w, v.w); }

		// Vector4 with 4 components.
		public static Vector4 rrrr(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 grrr(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 brrr(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 arrr(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.x); }
		public static Vector4 rgrr(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ggrr(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 bgrr(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 agrr(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.x); }
		public static Vector4 rbrr(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 gbrr(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 bbrr(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 abrr(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.x); }
		public static Vector4 rarr(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.x); }
		public static Vector4 garr(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.x); }
		public static Vector4 barr(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.x); }
		public static Vector4 aarr(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.x); }
		public static Vector4 rrgr(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 grgr(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 brgr(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 argr(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.x); }
		public static Vector4 rggr(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 gggr(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 bggr(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 aggr(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.x); }
		public static Vector4 rbgr(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 gbgr(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 bbgr(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 abgr(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.x); }
		public static Vector4 abgr(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.abgr(); }
		public static Vector4 ragr(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.x); }
		public static Vector4 gagr(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.x); }
		public static Vector4 bagr(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.x); }
		public static Vector4 bagr(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.bagr(); }
		public static Vector4 aagr(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.x); }
		public static Vector4 rrbr(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 grbr(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 brbr(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 arbr(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.x); }
		public static Vector4 rgbr(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 ggbr(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 bgbr(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 agbr(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.x); }
		public static Vector4 agbr(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.agbr(); }
		public static Vector4 rbbr(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 gbbr(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 bbbr(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 abbr(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.x); }
		public static Vector4 rabr(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.x); }
		public static Vector4 gabr(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.x); }
		public static Vector4 gabr(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.gabr(); }
		public static Vector4 babr(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.x); }
		public static Vector4 aabr(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.x); }
		public static Vector4 rrar(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.x); }
		public static Vector4 grar(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.x); }
		public static Vector4 brar(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.x); }
		public static Vector4 arar(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.x); }
		public static Vector4 rgar(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.x); }
		public static Vector4 ggar(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.x); }
		public static Vector4 bgar(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.x); }
		public static Vector4 bgar(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.bgar(); }
		public static Vector4 agar(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.x); }
		public static Vector4 rbar(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.x); }
		public static Vector4 gbar(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.x); }
		public static Vector4 gbar(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.gbar(); }
		public static Vector4 bbar(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.x); }
		public static Vector4 abar(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.x); }
		public static Vector4 raar(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.x); }
		public static Vector4 gaar(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.x); }
		public static Vector4 baar(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.x); }
		public static Vector4 aaar(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.x); }
		public static Vector4 rrrg(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 grrg(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 brrg(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 arrg(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.y); }
		public static Vector4 rgrg(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ggrg(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 bgrg(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 agrg(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.y); }
		public static Vector4 rbrg(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 gbrg(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 bbrg(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 abrg(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.y); }
		public static Vector4 abrg(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.abrg(); }
		public static Vector4 rarg(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.y); }
		public static Vector4 garg(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.y); }
		public static Vector4 barg(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.y); }
		public static Vector4 barg(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.barg(); }
		public static Vector4 aarg(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.y); }
		public static Vector4 rrgg(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 grgg(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 brgg(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 argg(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.y); }
		public static Vector4 rggg(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 gggg(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 bggg(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 aggg(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.y); }
		public static Vector4 rbgg(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 gbgg(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 bbgg(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 abgg(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.y); }
		public static Vector4 ragg(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.y); }
		public static Vector4 gagg(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.y); }
		public static Vector4 bagg(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.y); }
		public static Vector4 aagg(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.y); }
		public static Vector4 rrbg(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 grbg(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 brbg(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 arbg(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.y); }
		public static Vector4 arbg(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.arbg(); }
		public static Vector4 rgbg(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 ggbg(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 bgbg(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 agbg(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.y); }
		public static Vector4 rbbg(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 gbbg(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 bbbg(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 abbg(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.y); }
		public static Vector4 rabg(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.y); }
		public static Vector4 rabg(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.rabg(); }
		public static Vector4 gabg(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.y); }
		public static Vector4 babg(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.y); }
		public static Vector4 aabg(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.y); }
		public static Vector4 rrag(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.y); }
		public static Vector4 grag(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.y); }
		public static Vector4 brag(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.y); }
		public static Vector4 brag(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.brag(); }
		public static Vector4 arag(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.y); }
		public static Vector4 rgag(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.y); }
		public static Vector4 ggag(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.y); }
		public static Vector4 bgag(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.y); }
		public static Vector4 agag(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.y); }
		public static Vector4 rbag(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.y); }
		public static Vector4 rbag(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.rbag(); }
		public static Vector4 gbag(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.y); }
		public static Vector4 bbag(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.y); }
		public static Vector4 abag(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.y); }
		public static Vector4 raag(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.y); }
		public static Vector4 gaag(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.y); }
		public static Vector4 baag(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.y); }
		public static Vector4 aaag(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.y); }
		public static Vector4 rrrb(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 grrb(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 brrb(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 arrb(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.z); }
		public static Vector4 rgrb(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 ggrb(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 bgrb(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 agrb(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.z); }
		public static Vector4 agrb(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.agrb(); }
		public static Vector4 rbrb(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 gbrb(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 bbrb(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 abrb(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.z); }
		public static Vector4 rarb(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.z); }
		public static Vector4 garb(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.z); }
		public static Vector4 garb(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.garb(); }
		public static Vector4 barb(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.z); }
		public static Vector4 aarb(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.z); }
		public static Vector4 rrgb(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 grgb(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 brgb(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 argb(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.z); }
		public static Vector4 argb(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.argb(); }
		public static Vector4 rggb(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 gggb(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 bggb(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 aggb(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.z); }
		public static Vector4 rbgb(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 gbgb(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 bbgb(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 abgb(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.z); }
		public static Vector4 ragb(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.z); }
		public static Vector4 ragb(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.ragb(); }
		public static Vector4 gagb(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.z); }
		public static Vector4 bagb(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.z); }
		public static Vector4 aagb(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.z); }
		public static Vector4 rrbb(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 grbb(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 brbb(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 arbb(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.z); }
		public static Vector4 rgbb(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 ggbb(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 bgbb(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 agbb(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.z); }
		public static Vector4 rbbb(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 gbbb(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 bbbb(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.z); }
		public static Vector4 abbb(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.z); }
		public static Vector4 rabb(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.z); }
		public static Vector4 gabb(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.z); }
		public static Vector4 babb(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.z); }
		public static Vector4 aabb(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.z); }
		public static Vector4 rrab(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.z); }
		public static Vector4 grab(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.z); }
		public static Vector4 grab(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.grab(); }
		public static Vector4 brab(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.z); }
		public static Vector4 arab(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.z); }
		public static Vector4 rgab(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.z); }
		public static Vector4 rgab(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.rgab(); }
		public static Vector4 ggab(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.z); }
		public static Vector4 bgab(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.z); }
		public static Vector4 agab(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.z); }
		public static Vector4 rbab(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.z); }
		public static Vector4 gbab(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.z); }
		public static Vector4 bbab(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.z); }
		public static Vector4 abab(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.z); }
		public static Vector4 raab(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.z); }
		public static Vector4 gaab(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.z); }
		public static Vector4 baab(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.z); }
		public static Vector4 aaab(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.z); }
		public static Vector4 rrra(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.w); }
		public static Vector4 grra(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.w); }
		public static Vector4 brra(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.w); }
		public static Vector4 arra(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.w); }
		public static Vector4 rgra(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.w); }
		public static Vector4 ggra(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.w); }
		public static Vector4 bgra(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.w); }
		public static Vector4 bgra(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.bgra(); }
		public static Vector4 agra(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.w); }
		public static Vector4 rbra(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.w); }
		public static Vector4 gbra(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.w); }
		public static Vector4 gbra(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.gbra(); }
		public static Vector4 bbra(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.w); }
		public static Vector4 abra(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.w); }
		public static Vector4 rara(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.w); }
		public static Vector4 gara(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.w); }
		public static Vector4 bara(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.w); }
		public static Vector4 aara(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.w); }
		public static Vector4 rrga(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.w); }
		public static Vector4 grga(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.w); }
		public static Vector4 brga(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.w); }
		public static Vector4 brga(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.brga(); }
		public static Vector4 arga(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.w); }
		public static Vector4 rgga(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.w); }
		public static Vector4 ggga(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.w); }
		public static Vector4 bgga(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.w); }
		public static Vector4 agga(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.w); }
		public static Vector4 rbga(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.w); }
		public static Vector4 rbga(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.rbga(); }
		public static Vector4 gbga(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.w); }
		public static Vector4 bbga(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.w); }
		public static Vector4 abga(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.w); }
		public static Vector4 raga(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.w); }
		public static Vector4 gaga(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.w); }
		public static Vector4 baga(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.w); }
		public static Vector4 aaga(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.w); }
		public static Vector4 rrba(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.w); }
		public static Vector4 grba(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.w); }
		public static Vector4 grba(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.grba(); }
		public static Vector4 brba(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.w); }
		public static Vector4 arba(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.w); }
		public static Vector4 rgba(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w); }
		public static Vector4 rgba(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.rgba(); }
		public static Vector4 ggba(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.w); }
		public static Vector4 bgba(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.w); }
		public static Vector4 agba(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.w); }
		public static Vector4 rbba(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.w); }
		public static Vector4 gbba(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.w); }
		public static Vector4 bbba(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.w); }
		public static Vector4 abba(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.w); }
		public static Vector4 raba(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.w); }
		public static Vector4 gaba(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.w); }
		public static Vector4 baba(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.w); }
		public static Vector4 aaba(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.w); }
		public static Vector4 rraa(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.w); }
		public static Vector4 graa(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.w); }
		public static Vector4 braa(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.w); }
		public static Vector4 araa(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.w); }
		public static Vector4 rgaa(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.w); }
		public static Vector4 ggaa(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.w); }
		public static Vector4 bgaa(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.w); }
		public static Vector4 agaa(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.w); }
		public static Vector4 rbaa(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.w); }
		public static Vector4 gbaa(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.w); }
		public static Vector4 bbaa(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.w); }
		public static Vector4 abaa(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.w); }
		public static Vector4 raaa(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.w); }
		public static Vector4 gaaa(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.w); }
		public static Vector4 baaa(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.w); }
		public static Vector4 aaaa(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.w); }
	}

	public static class Vector2stSwizzleExtension
	{
		// Vector2 with 1 components.
		public static float s(this Vector2 v) { return v.x; }
		public static float s(this Vector2 v, float other) { v.x = other; return v.s(); }
		public static float t(this Vector2 v) { return v.y; }
		public static float t(this Vector2 v, float other) { v.y = other; return v.t(); }

		// Vector2 with 2 components.
		public static Vector2 ss(this Vector2 v) { return new Vector2(v.x, v.x); }
		public static Vector2 ts(this Vector2 v) { return new Vector2(v.y, v.x); }
		public static Vector2 ts(this Vector2 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.ts(); }
		public static Vector2 st(this Vector2 v) { return new Vector2(v.x, v.y); }
		public static Vector2 st(this Vector2 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.st(); }
		public static Vector2 tt(this Vector2 v) { return new Vector2(v.y, v.y); }

		// Vector2 with 3 components.
		public static Vector3 sss(this Vector2 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 tss(this Vector2 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 sts(this Vector2 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 tts(this Vector2 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 sst(this Vector2 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 tst(this Vector2 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 stt(this Vector2 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ttt(this Vector2 v) { return new Vector3(v.y, v.y, v.y); }

		// Vector2 with 4 components.
		public static Vector4 ssss(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 tsss(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 stss(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ttss(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 ssts(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 tsts(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 stts(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 ttts(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 ssst(this Vector2 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 tsst(this Vector2 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 stst(this Vector2 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ttst(this Vector2 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 sstt(this Vector2 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 tstt(this Vector2 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 sttt(this Vector2 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 tttt(this Vector2 v) { return new Vector4(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3stpSwizzleExtension
	{
		// Vector3 with 1 components.
		public static float s(this Vector3 v) { return v.x; }
		public static float s(this Vector3 v, float other) { v.x = other; return v.s(); }
		public static float t(this Vector3 v) { return v.y; }
		public static float t(this Vector3 v, float other) { v.y = other; return v.t(); }
		public static float p(this Vector3 v) { return v.z; }
		public static float p(this Vector3 v, float other) { v.z = other; return v.p(); }

		// Vector3 with 2 components.
		public static Vector2 ss(this Vector3 v) { return new Vector2(v.x, v.x); }
		public static Vector2 ts(this Vector3 v) { return new Vector2(v.y, v.x); }
		public static Vector2 ts(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.ts(); }
		public static Vector2 ps(this Vector3 v) { return new Vector2(v.z, v.x); }
		public static Vector2 ps(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.ps(); }
		public static Vector2 st(this Vector3 v) { return new Vector2(v.x, v.y); }
		public static Vector2 st(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.st(); }
		public static Vector2 tt(this Vector3 v) { return new Vector2(v.y, v.y); }
		public static Vector2 pt(this Vector3 v) { return new Vector2(v.z, v.y); }
		public static Vector2 pt(this Vector3 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.pt(); }
		public static Vector2 sp(this Vector3 v) { return new Vector2(v.x, v.z); }
		public static Vector2 sp(this Vector3 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.sp(); }
		public static Vector2 tp(this Vector3 v) { return new Vector2(v.y, v.z); }
		public static Vector2 tp(this Vector3 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.tp(); }
		public static Vector2 pp(this Vector3 v) { return new Vector2(v.z, v.z); }

		// Vector3 with 3 components.
		public static Vector3 sss(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 tss(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 pss(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 sts(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 tts(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 pts(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 pts(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.pts(); }
		public static Vector3 sps(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 tps(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 tps(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.tps(); }
		public static Vector3 pps(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 sst(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 tst(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 pst(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 pst(this Vector3 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.pst(); }
		public static Vector3 stt(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ttt(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 ptt(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 spt(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 spt(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.spt(); }
		public static Vector3 tpt(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 ppt(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 ssp(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 tsp(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 tsp(this Vector3 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.tsp(); }
		public static Vector3 psp(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 stp(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 stp(this Vector3 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.stp(); }
		public static Vector3 ttp(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 ptp(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 spp(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 tpp(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 ppp(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }

		// Vector3 with 4 components.
		public static Vector4 ssss(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 tsss(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 psss(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 stss(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ttss(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 ptss(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 spss(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 tpss(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 ppss(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 ssts(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 tsts(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 psts(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 stts(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 ttts(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 ptts(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 spts(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 tpts(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 ppts(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 ssps(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 tsps(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 psps(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 stps(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 ttps(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 ptps(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 spps(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 tpps(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 ppps(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 ssst(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 tsst(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 psst(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 stst(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ttst(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 ptst(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 spst(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 tpst(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 ppst(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 sstt(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 tstt(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 pstt(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 sttt(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 tttt(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 pttt(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 sptt(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 tptt(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 pptt(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 sspt(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 tspt(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 pspt(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 stpt(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 ttpt(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 ptpt(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 sppt(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 tppt(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 pppt(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 sssp(this Vector3 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 tssp(this Vector3 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 pssp(this Vector3 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 stsp(this Vector3 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 ttsp(this Vector3 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 ptsp(this Vector3 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 spsp(this Vector3 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 tpsp(this Vector3 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 ppsp(this Vector3 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 sstp(this Vector3 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 tstp(this Vector3 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 pstp(this Vector3 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 sttp(this Vector3 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 tttp(this Vector3 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 pttp(this Vector3 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 sptp(this Vector3 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 tptp(this Vector3 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 pptp(this Vector3 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 sspp(this Vector3 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 tspp(this Vector3 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 pspp(this Vector3 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 stpp(this Vector3 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 ttpp(this Vector3 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 ptpp(this Vector3 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 sppp(this Vector3 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 tppp(this Vector3 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 pppp(this Vector3 v) { return new Vector4(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4stpqSwizzleExtension
	{
		// Vector4 with 1 components.
		public static float s(this Vector4 v) { return v.x; }
		public static float s(this Vector4 v, float other) { v.x = other; return v.s(); }
		public static float t(this Vector4 v) { return v.y; }
		public static float t(this Vector4 v, float other) { v.y = other; return v.t(); }
		public static float p(this Vector4 v) { return v.z; }
		public static float p(this Vector4 v, float other) { v.z = other; return v.p(); }
		public static float q(this Vector4 v) { return v.w; }
		public static float q(this Vector4 v, float other) { v.w = other; return v.q(); }

		// Vector4 with 2 components.
		public static Vector2 ss(this Vector4 v) { return new Vector2(v.x, v.x); }
		public static Vector2 ts(this Vector4 v) { return new Vector2(v.y, v.x); }
		public static Vector2 ts(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.x = (float)other.y(); return v.ts(); }
		public static Vector2 ps(this Vector4 v) { return new Vector2(v.z, v.x); }
		public static Vector2 ps(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.x = (float)other.y(); return v.ps(); }
		public static Vector2 qs(this Vector4 v) { return new Vector2(v.w, v.x); }
		public static Vector2 qs(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.x = (float)other.y(); return v.qs(); }
		public static Vector2 st(this Vector4 v) { return new Vector2(v.x, v.y); }
		public static Vector2 st(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.y = (float)other.y(); return v.st(); }
		public static Vector2 tt(this Vector4 v) { return new Vector2(v.y, v.y); }
		public static Vector2 pt(this Vector4 v) { return new Vector2(v.z, v.y); }
		public static Vector2 pt(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.y = (float)other.y(); return v.pt(); }
		public static Vector2 qt(this Vector4 v) { return new Vector2(v.w, v.y); }
		public static Vector2 qt(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.y = (float)other.y(); return v.qt(); }
		public static Vector2 sp(this Vector4 v) { return new Vector2(v.x, v.z); }
		public static Vector2 sp(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.z = (float)other.y(); return v.sp(); }
		public static Vector2 tp(this Vector4 v) { return new Vector2(v.y, v.z); }
		public static Vector2 tp(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.z = (float)other.y(); return v.tp(); }
		public static Vector2 pp(this Vector4 v) { return new Vector2(v.z, v.z); }
		public static Vector2 qp(this Vector4 v) { return new Vector2(v.w, v.z); }
		public static Vector2 qp(this Vector4 v, Vector2 other) { v.w = (float)other.x();v.z = (float)other.y(); return v.qp(); }
		public static Vector2 sq(this Vector4 v) { return new Vector2(v.x, v.w); }
		public static Vector2 sq(this Vector4 v, Vector2 other) { v.x = (float)other.x();v.w = (float)other.y(); return v.sq(); }
		public static Vector2 tq(this Vector4 v) { return new Vector2(v.y, v.w); }
		public static Vector2 tq(this Vector4 v, Vector2 other) { v.y = (float)other.x();v.w = (float)other.y(); return v.tq(); }
		public static Vector2 pq(this Vector4 v) { return new Vector2(v.z, v.w); }
		public static Vector2 pq(this Vector4 v, Vector2 other) { v.z = (float)other.x();v.w = (float)other.y(); return v.pq(); }
		public static Vector2 qq(this Vector4 v) { return new Vector2(v.w, v.w); }

		// Vector4 with 3 components.
		public static Vector3 sss(this Vector4 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 tss(this Vector4 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 pss(this Vector4 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 qss(this Vector4 v) { return new Vector3(v.w, v.x, v.x); }
		public static Vector3 sts(this Vector4 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 tts(this Vector4 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 pts(this Vector4 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 pts(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.pts(); }
		public static Vector3 qts(this Vector4 v) { return new Vector3(v.w, v.y, v.x); }
		public static Vector3 qts(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z(); return v.qts(); }
		public static Vector3 sps(this Vector4 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 tps(this Vector4 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 tps(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.tps(); }
		public static Vector3 pps(this Vector4 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 qps(this Vector4 v) { return new Vector3(v.w, v.z, v.x); }
		public static Vector3 qps(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z(); return v.qps(); }
		public static Vector3 sqs(this Vector4 v) { return new Vector3(v.x, v.w, v.x); }
		public static Vector3 tqs(this Vector4 v) { return new Vector3(v.y, v.w, v.x); }
		public static Vector3 tqs(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.tqs(); }
		public static Vector3 pqs(this Vector4 v) { return new Vector3(v.z, v.w, v.x); }
		public static Vector3 pqs(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z(); return v.pqs(); }
		public static Vector3 qqs(this Vector4 v) { return new Vector3(v.w, v.w, v.x); }
		public static Vector3 sst(this Vector4 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 tst(this Vector4 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 pst(this Vector4 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 pst(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.pst(); }
		public static Vector3 qst(this Vector4 v) { return new Vector3(v.w, v.x, v.y); }
		public static Vector3 qst(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z(); return v.qst(); }
		public static Vector3 stt(this Vector4 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 ttt(this Vector4 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 ptt(this Vector4 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 qtt(this Vector4 v) { return new Vector3(v.w, v.y, v.y); }
		public static Vector3 spt(this Vector4 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 spt(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.spt(); }
		public static Vector3 tpt(this Vector4 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 ppt(this Vector4 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 qpt(this Vector4 v) { return new Vector3(v.w, v.z, v.y); }
		public static Vector3 qpt(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z(); return v.qpt(); }
		public static Vector3 sqt(this Vector4 v) { return new Vector3(v.x, v.w, v.y); }
		public static Vector3 sqt(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.sqt(); }
		public static Vector3 tqt(this Vector4 v) { return new Vector3(v.y, v.w, v.y); }
		public static Vector3 pqt(this Vector4 v) { return new Vector3(v.z, v.w, v.y); }
		public static Vector3 pqt(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z(); return v.pqt(); }
		public static Vector3 qqt(this Vector4 v) { return new Vector3(v.w, v.w, v.y); }
		public static Vector3 ssp(this Vector4 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 tsp(this Vector4 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 tsp(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.tsp(); }
		public static Vector3 psp(this Vector4 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 qsp(this Vector4 v) { return new Vector3(v.w, v.x, v.z); }
		public static Vector3 qsp(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z(); return v.qsp(); }
		public static Vector3 stp(this Vector4 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 stp(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.stp(); }
		public static Vector3 ttp(this Vector4 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 ptp(this Vector4 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 qtp(this Vector4 v) { return new Vector3(v.w, v.y, v.z); }
		public static Vector3 qtp(this Vector4 v, Vector3 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z(); return v.qtp(); }
		public static Vector3 spp(this Vector4 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 tpp(this Vector4 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 ppp(this Vector4 v) { return new Vector3(v.z, v.z, v.z); }
		public static Vector3 qpp(this Vector4 v) { return new Vector3(v.w, v.z, v.z); }
		public static Vector3 sqp(this Vector4 v) { return new Vector3(v.x, v.w, v.z); }
		public static Vector3 sqp(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.sqp(); }
		public static Vector3 tqp(this Vector4 v) { return new Vector3(v.y, v.w, v.z); }
		public static Vector3 tqp(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z(); return v.tqp(); }
		public static Vector3 pqp(this Vector4 v) { return new Vector3(v.z, v.w, v.z); }
		public static Vector3 qqp(this Vector4 v) { return new Vector3(v.w, v.w, v.z); }
		public static Vector3 ssq(this Vector4 v) { return new Vector3(v.x, v.x, v.w); }
		public static Vector3 tsq(this Vector4 v) { return new Vector3(v.y, v.x, v.w); }
		public static Vector3 tsq(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.tsq(); }
		public static Vector3 psq(this Vector4 v) { return new Vector3(v.z, v.x, v.w); }
		public static Vector3 psq(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z(); return v.psq(); }
		public static Vector3 qsq(this Vector4 v) { return new Vector3(v.w, v.x, v.w); }
		public static Vector3 stq(this Vector4 v) { return new Vector3(v.x, v.y, v.w); }
		public static Vector3 stq(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.stq(); }
		public static Vector3 ttq(this Vector4 v) { return new Vector3(v.y, v.y, v.w); }
		public static Vector3 ptq(this Vector4 v) { return new Vector3(v.z, v.y, v.w); }
		public static Vector3 ptq(this Vector4 v, Vector3 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z(); return v.ptq(); }
		public static Vector3 qtq(this Vector4 v) { return new Vector3(v.w, v.y, v.w); }
		public static Vector3 spq(this Vector4 v) { return new Vector3(v.x, v.z, v.w); }
		public static Vector3 spq(this Vector4 v, Vector3 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.spq(); }
		public static Vector3 tpq(this Vector4 v) { return new Vector3(v.y, v.z, v.w); }
		public static Vector3 tpq(this Vector4 v, Vector3 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z(); return v.tpq(); }
		public static Vector3 ppq(this Vector4 v) { return new Vector3(v.z, v.z, v.w); }
		public static Vector3 qpq(this Vector4 v) { return new Vector3(v.w, v.z, v.w); }
		public static Vector3 sqq(this Vector4 v) { return new Vector3(v.x, v.w, v.w); }
		public static Vector3 tqq(this Vector4 v) { return new Vector3(v.y, v.w, v.w); }
		public static Vector3 pqq(this Vector4 v) { return new Vector3(v.z, v.w, v.w); }
		public static Vector3 qqq(this Vector4 v) { return new Vector3(v.w, v.w, v.w); }

		// Vector4 with 4 components.
		public static Vector4 ssss(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 tsss(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 psss(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 qsss(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.x); }
		public static Vector4 stss(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 ttss(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 ptss(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 qtss(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.x); }
		public static Vector4 spss(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 tpss(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 ppss(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 qpss(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.x); }
		public static Vector4 sqss(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.x); }
		public static Vector4 tqss(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.x); }
		public static Vector4 pqss(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.x); }
		public static Vector4 qqss(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.x); }
		public static Vector4 ssts(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 tsts(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 psts(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 qsts(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.x); }
		public static Vector4 stts(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 ttts(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 ptts(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 qtts(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.x); }
		public static Vector4 spts(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 tpts(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 ppts(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 qpts(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.x); }
		public static Vector4 qpts(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.qpts(); }
		public static Vector4 sqts(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.x); }
		public static Vector4 tqts(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.x); }
		public static Vector4 pqts(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.x); }
		public static Vector4 pqts(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.x = (float)other.w(); return v.pqts(); }
		public static Vector4 qqts(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.x); }
		public static Vector4 ssps(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 tsps(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 psps(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 qsps(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.x); }
		public static Vector4 stps(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 ttps(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 ptps(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 qtps(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.x); }
		public static Vector4 qtps(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.qtps(); }
		public static Vector4 spps(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 tpps(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 ppps(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 qpps(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.x); }
		public static Vector4 sqps(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.x); }
		public static Vector4 tqps(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.x); }
		public static Vector4 tqps(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.x = (float)other.w(); return v.tqps(); }
		public static Vector4 pqps(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.x); }
		public static Vector4 qqps(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.x); }
		public static Vector4 ssqs(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.x); }
		public static Vector4 tsqs(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.x); }
		public static Vector4 psqs(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.x); }
		public static Vector4 qsqs(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.x); }
		public static Vector4 stqs(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.x); }
		public static Vector4 ttqs(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.x); }
		public static Vector4 ptqs(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.x); }
		public static Vector4 ptqs(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.ptqs(); }
		public static Vector4 qtqs(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.x); }
		public static Vector4 spqs(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.x); }
		public static Vector4 tpqs(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.x); }
		public static Vector4 tpqs(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.x = (float)other.w(); return v.tpqs(); }
		public static Vector4 ppqs(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.x); }
		public static Vector4 qpqs(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.x); }
		public static Vector4 sqqs(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.x); }
		public static Vector4 tqqs(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.x); }
		public static Vector4 pqqs(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.x); }
		public static Vector4 qqqs(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.x); }
		public static Vector4 ssst(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 tsst(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 psst(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 qsst(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.y); }
		public static Vector4 stst(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 ttst(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 ptst(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 qtst(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.y); }
		public static Vector4 spst(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 tpst(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 ppst(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 qpst(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.y); }
		public static Vector4 qpst(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.qpst(); }
		public static Vector4 sqst(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.y); }
		public static Vector4 tqst(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.y); }
		public static Vector4 pqst(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.y); }
		public static Vector4 pqst(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.y = (float)other.w(); return v.pqst(); }
		public static Vector4 qqst(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.y); }
		public static Vector4 sstt(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 tstt(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 pstt(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 qstt(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.y); }
		public static Vector4 sttt(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 tttt(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 pttt(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 qttt(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.y); }
		public static Vector4 sptt(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 tptt(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 pptt(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 qptt(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.y); }
		public static Vector4 sqtt(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.y); }
		public static Vector4 tqtt(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.y); }
		public static Vector4 pqtt(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.y); }
		public static Vector4 qqtt(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.y); }
		public static Vector4 sspt(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 tspt(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 pspt(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 qspt(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.y); }
		public static Vector4 qspt(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.qspt(); }
		public static Vector4 stpt(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 ttpt(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 ptpt(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 qtpt(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.y); }
		public static Vector4 sppt(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 tppt(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 pppt(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 qppt(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.y); }
		public static Vector4 sqpt(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.y); }
		public static Vector4 sqpt(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.z = (float)other.z();v.y = (float)other.w(); return v.sqpt(); }
		public static Vector4 tqpt(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.y); }
		public static Vector4 pqpt(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.y); }
		public static Vector4 qqpt(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.y); }
		public static Vector4 ssqt(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.y); }
		public static Vector4 tsqt(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.y); }
		public static Vector4 psqt(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.y); }
		public static Vector4 psqt(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.psqt(); }
		public static Vector4 qsqt(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.y); }
		public static Vector4 stqt(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.y); }
		public static Vector4 ttqt(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.y); }
		public static Vector4 ptqt(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.y); }
		public static Vector4 qtqt(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.y); }
		public static Vector4 spqt(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.y); }
		public static Vector4 spqt(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.w = (float)other.z();v.y = (float)other.w(); return v.spqt(); }
		public static Vector4 tpqt(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.y); }
		public static Vector4 ppqt(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.y); }
		public static Vector4 qpqt(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.y); }
		public static Vector4 sqqt(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.y); }
		public static Vector4 tqqt(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.y); }
		public static Vector4 pqqt(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.y); }
		public static Vector4 qqqt(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.y); }
		public static Vector4 sssp(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 tssp(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 pssp(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 qssp(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.z); }
		public static Vector4 stsp(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 ttsp(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 ptsp(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 qtsp(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.z); }
		public static Vector4 qtsp(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.qtsp(); }
		public static Vector4 spsp(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 tpsp(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 ppsp(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 qpsp(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.z); }
		public static Vector4 sqsp(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.z); }
		public static Vector4 tqsp(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.z); }
		public static Vector4 tqsp(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.w = (float)other.y();v.x = (float)other.z();v.z = (float)other.w(); return v.tqsp(); }
		public static Vector4 pqsp(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.z); }
		public static Vector4 qqsp(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.z); }
		public static Vector4 sstp(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 tstp(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 pstp(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 qstp(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.z); }
		public static Vector4 qstp(this Vector4 v, Vector4 other) { v.w = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.qstp(); }
		public static Vector4 sttp(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 tttp(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 pttp(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 qttp(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.z); }
		public static Vector4 sptp(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 tptp(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 pptp(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 qptp(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.z); }
		public static Vector4 sqtp(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.z); }
		public static Vector4 sqtp(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.w = (float)other.y();v.y = (float)other.z();v.z = (float)other.w(); return v.sqtp(); }
		public static Vector4 tqtp(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.z); }
		public static Vector4 pqtp(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.z); }
		public static Vector4 qqtp(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.z); }
		public static Vector4 sspp(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 tspp(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 pspp(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 qspp(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.z); }
		public static Vector4 stpp(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 ttpp(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 ptpp(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 qtpp(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.z); }
		public static Vector4 sppp(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 tppp(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 pppp(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.z); }
		public static Vector4 qppp(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.z); }
		public static Vector4 sqpp(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.z); }
		public static Vector4 tqpp(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.z); }
		public static Vector4 pqpp(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.z); }
		public static Vector4 qqpp(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.z); }
		public static Vector4 ssqp(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.z); }
		public static Vector4 tsqp(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.z); }
		public static Vector4 tsqp(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.tsqp(); }
		public static Vector4 psqp(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.z); }
		public static Vector4 qsqp(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.z); }
		public static Vector4 stqp(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.z); }
		public static Vector4 stqp(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.w = (float)other.z();v.z = (float)other.w(); return v.stqp(); }
		public static Vector4 ttqp(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.z); }
		public static Vector4 ptqp(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.z); }
		public static Vector4 qtqp(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.z); }
		public static Vector4 spqp(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.z); }
		public static Vector4 tpqp(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.z); }
		public static Vector4 ppqp(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.z); }
		public static Vector4 qpqp(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.z); }
		public static Vector4 sqqp(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.z); }
		public static Vector4 tqqp(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.z); }
		public static Vector4 pqqp(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.z); }
		public static Vector4 qqqp(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.z); }
		public static Vector4 sssq(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.w); }
		public static Vector4 tssq(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.w); }
		public static Vector4 pssq(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.w); }
		public static Vector4 qssq(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.w); }
		public static Vector4 stsq(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.w); }
		public static Vector4 ttsq(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.w); }
		public static Vector4 ptsq(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.w); }
		public static Vector4 ptsq(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.y = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.ptsq(); }
		public static Vector4 qtsq(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.w); }
		public static Vector4 spsq(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.w); }
		public static Vector4 tpsq(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.w); }
		public static Vector4 tpsq(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.z = (float)other.y();v.x = (float)other.z();v.w = (float)other.w(); return v.tpsq(); }
		public static Vector4 ppsq(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.w); }
		public static Vector4 qpsq(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.w); }
		public static Vector4 sqsq(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.w); }
		public static Vector4 tqsq(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.w); }
		public static Vector4 pqsq(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.w); }
		public static Vector4 qqsq(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.w); }
		public static Vector4 sstq(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.w); }
		public static Vector4 tstq(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.w); }
		public static Vector4 pstq(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.w); }
		public static Vector4 pstq(this Vector4 v, Vector4 other) { v.z = (float)other.x();v.x = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.pstq(); }
		public static Vector4 qstq(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.w); }
		public static Vector4 sttq(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.w); }
		public static Vector4 tttq(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.w); }
		public static Vector4 pttq(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.w); }
		public static Vector4 qttq(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.w); }
		public static Vector4 sptq(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.w); }
		public static Vector4 sptq(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.z = (float)other.y();v.y = (float)other.z();v.w = (float)other.w(); return v.sptq(); }
		public static Vector4 tptq(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.w); }
		public static Vector4 pptq(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.w); }
		public static Vector4 qptq(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.w); }
		public static Vector4 sqtq(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.w); }
		public static Vector4 tqtq(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.w); }
		public static Vector4 pqtq(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.w); }
		public static Vector4 qqtq(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.w); }
		public static Vector4 sspq(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.w); }
		public static Vector4 tspq(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.w); }
		public static Vector4 tspq(this Vector4 v, Vector4 other) { v.y = (float)other.x();v.x = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.tspq(); }
		public static Vector4 pspq(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.w); }
		public static Vector4 qspq(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.w); }
		public static Vector4 stpq(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w); }
		public static Vector4 stpq(this Vector4 v, Vector4 other) { v.x = (float)other.x();v.y = (float)other.y();v.z = (float)other.z();v.w = (float)other.w(); return v.stpq(); }
		public static Vector4 ttpq(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.w); }
		public static Vector4 ptpq(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.w); }
		public static Vector4 qtpq(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.w); }
		public static Vector4 sppq(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.w); }
		public static Vector4 tppq(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.w); }
		public static Vector4 pppq(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.w); }
		public static Vector4 qppq(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.w); }
		public static Vector4 sqpq(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.w); }
		public static Vector4 tqpq(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.w); }
		public static Vector4 pqpq(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.w); }
		public static Vector4 qqpq(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.w); }
		public static Vector4 ssqq(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.w); }
		public static Vector4 tsqq(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.w); }
		public static Vector4 psqq(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.w); }
		public static Vector4 qsqq(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.w); }
		public static Vector4 stqq(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.w); }
		public static Vector4 ttqq(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.w); }
		public static Vector4 ptqq(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.w); }
		public static Vector4 qtqq(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.w); }
		public static Vector4 spqq(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.w); }
		public static Vector4 tpqq(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.w); }
		public static Vector4 ppqq(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.w); }
		public static Vector4 qpqq(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.w); }
		public static Vector4 sqqq(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.w); }
		public static Vector4 tqqq(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.w); }
		public static Vector4 pqqq(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.w); }
		public static Vector4 qqqq(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.w); }
	}

	public static class Vector2IntxySwizzleExtension
	{
		// Vector2Int with 1 components.
		public static int x(this Vector2Int v) { return v.x; }
		public static int x(this Vector2Int v, int other) { v.x = other; return v.x(); }
		public static int y(this Vector2Int v) { return v.y; }
		public static int y(this Vector2Int v, int other) { v.y = other; return v.y(); }

		// Vector2Int with 2 components.
		public static Vector2Int xx(this Vector2Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int yx(this Vector2Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yx(this Vector2Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.yx(); }
		public static Vector2Int xy(this Vector2Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int xy(this Vector2Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.xy(); }
		public static Vector2Int yy(this Vector2Int v) { return new Vector2Int(v.y, v.y); }

		// Vector2Int with 3 components.
		public static Vector3Int xxx(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int yxx(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int xyx(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int yyx(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int xxy(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int yxy(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int xyy(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int yyy(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.y); }

		// Vector2Int with 4 components.
		public static Vector4Int xxxx(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int yxxx(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int xyxx(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int yyxx(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int xxyx(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int yxyx(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int xyyx(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int yyyx(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int xxxy(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int yxxy(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int xyxy(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int yyxy(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int xxyy(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int yxyy(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int xyyy(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int yyyy(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3IntxyzSwizzleExtension
	{
		// Vector3Int with 1 components.
		public static int x(this Vector3Int v) { return v.x; }
		public static int x(this Vector3Int v, int other) { v.x = other; return v.x(); }
		public static int y(this Vector3Int v) { return v.y; }
		public static int y(this Vector3Int v, int other) { v.y = other; return v.y(); }
		public static int z(this Vector3Int v) { return v.z; }
		public static int z(this Vector3Int v, int other) { v.z = other; return v.z(); }

		// Vector3Int with 2 components.
		public static Vector2Int xx(this Vector3Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int yx(this Vector3Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yx(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.yx(); }
		public static Vector2Int zx(this Vector3Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int zx(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.zx(); }
		public static Vector2Int xy(this Vector3Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int xy(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.xy(); }
		public static Vector2Int yy(this Vector3Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int zy(this Vector3Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int zy(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.zy(); }
		public static Vector2Int xz(this Vector3Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int xz(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.xz(); }
		public static Vector2Int yz(this Vector3Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int yz(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.yz(); }
		public static Vector2Int zz(this Vector3Int v) { return new Vector2Int(v.z, v.z); }

		// Vector3Int with 3 components.
		public static Vector3Int xxx(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int yxx(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int zxx(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int xyx(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int yyx(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int zyx(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int zyx(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.zyx(); }
		public static Vector3Int xzx(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int yzx(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int yzx(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.yzx(); }
		public static Vector3Int zzx(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int xxy(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int yxy(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int zxy(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int zxy(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.zxy(); }
		public static Vector3Int xyy(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int yyy(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int zyy(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int xzy(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int xzy(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.xzy(); }
		public static Vector3Int yzy(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int zzy(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int xxz(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int yxz(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int yxz(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.yxz(); }
		public static Vector3Int zxz(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int xyz(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int xyz(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.xyz(); }
		public static Vector3Int yyz(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int zyz(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int xzz(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int yzz(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int zzz(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.z); }

		// Vector3Int with 4 components.
		public static Vector4Int xxxx(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int yxxx(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int zxxx(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int xyxx(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int yyxx(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int zyxx(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int xzxx(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int yzxx(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int zzxx(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int xxyx(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int yxyx(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int zxyx(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int xyyx(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int yyyx(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int zyyx(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int xzyx(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int yzyx(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int zzyx(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int xxzx(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int yxzx(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int zxzx(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int xyzx(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int yyzx(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int zyzx(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int xzzx(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int yzzx(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int zzzx(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int xxxy(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int yxxy(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int zxxy(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int xyxy(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int yyxy(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int zyxy(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int xzxy(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int yzxy(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int zzxy(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int xxyy(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int yxyy(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int zxyy(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int xyyy(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int yyyy(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int zyyy(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int xzyy(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int yzyy(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int zzyy(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int xxzy(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int yxzy(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int zxzy(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int xyzy(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int yyzy(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int zyzy(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int xzzy(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int yzzy(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int zzzy(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int xxxz(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int yxxz(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int zxxz(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int xyxz(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int yyxz(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int zyxz(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int xzxz(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int yzxz(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int zzxz(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int xxyz(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int yxyz(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int zxyz(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int xyyz(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int yyyz(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int zyyz(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int xzyz(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int yzyz(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int zzyz(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int xxzz(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int yxzz(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int zxzz(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int xyzz(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int yyzz(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int zyzz(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int xzzz(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int yzzz(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int zzzz(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4IntxyzwSwizzleExtension
	{
		// Vector4Int with 1 components.
		public static int x(this Vector4Int v) { return v.x; }
		public static int x(this Vector4Int v, int other) { v.x = other; return v.x(); }
		public static int y(this Vector4Int v) { return v.y; }
		public static int y(this Vector4Int v, int other) { v.y = other; return v.y(); }
		public static int z(this Vector4Int v) { return v.z; }
		public static int z(this Vector4Int v, int other) { v.z = other; return v.z(); }
		public static int w(this Vector4Int v) { return v.w; }
		public static int w(this Vector4Int v, int other) { v.w = other; return v.w(); }

		// Vector4Int with 2 components.
		public static Vector2Int xx(this Vector4Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int yx(this Vector4Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yx(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.yx(); }
		public static Vector2Int zx(this Vector4Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int zx(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.zx(); }
		public static Vector2Int wx(this Vector4Int v) { return new Vector2Int(v.w, v.x); }
		public static Vector2Int wx(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.x = (int)other.y(); return v.wx(); }
		public static Vector2Int xy(this Vector4Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int xy(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.xy(); }
		public static Vector2Int yy(this Vector4Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int zy(this Vector4Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int zy(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.zy(); }
		public static Vector2Int wy(this Vector4Int v) { return new Vector2Int(v.w, v.y); }
		public static Vector2Int wy(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.y = (int)other.y(); return v.wy(); }
		public static Vector2Int xz(this Vector4Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int xz(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.xz(); }
		public static Vector2Int yz(this Vector4Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int yz(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.yz(); }
		public static Vector2Int zz(this Vector4Int v) { return new Vector2Int(v.z, v.z); }
		public static Vector2Int wz(this Vector4Int v) { return new Vector2Int(v.w, v.z); }
		public static Vector2Int wz(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.z = (int)other.y(); return v.wz(); }
		public static Vector2Int xw(this Vector4Int v) { return new Vector2Int(v.x, v.w); }
		public static Vector2Int xw(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.w = (int)other.y(); return v.xw(); }
		public static Vector2Int yw(this Vector4Int v) { return new Vector2Int(v.y, v.w); }
		public static Vector2Int yw(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.w = (int)other.y(); return v.yw(); }
		public static Vector2Int zw(this Vector4Int v) { return new Vector2Int(v.z, v.w); }
		public static Vector2Int zw(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.w = (int)other.y(); return v.zw(); }
		public static Vector2Int ww(this Vector4Int v) { return new Vector2Int(v.w, v.w); }

		// Vector4Int with 3 components.
		public static Vector3Int xxx(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int yxx(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int zxx(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int wxx(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.x); }
		public static Vector3Int xyx(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int yyx(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int zyx(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int zyx(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.zyx(); }
		public static Vector3Int wyx(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.x); }
		public static Vector3Int wyx(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.wyx(); }
		public static Vector3Int xzx(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int yzx(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int yzx(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.yzx(); }
		public static Vector3Int zzx(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int wzx(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.x); }
		public static Vector3Int wzx(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.wzx(); }
		public static Vector3Int xwx(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.x); }
		public static Vector3Int ywx(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.x); }
		public static Vector3Int ywx(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.ywx(); }
		public static Vector3Int zwx(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.x); }
		public static Vector3Int zwx(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.zwx(); }
		public static Vector3Int wwx(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.x); }
		public static Vector3Int xxy(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int yxy(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int zxy(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int zxy(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.zxy(); }
		public static Vector3Int wxy(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.y); }
		public static Vector3Int wxy(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.wxy(); }
		public static Vector3Int xyy(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int yyy(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int zyy(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int wyy(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.y); }
		public static Vector3Int xzy(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int xzy(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.xzy(); }
		public static Vector3Int yzy(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int zzy(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int wzy(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.y); }
		public static Vector3Int wzy(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.wzy(); }
		public static Vector3Int xwy(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.y); }
		public static Vector3Int xwy(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.xwy(); }
		public static Vector3Int ywy(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.y); }
		public static Vector3Int zwy(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.y); }
		public static Vector3Int zwy(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.zwy(); }
		public static Vector3Int wwy(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.y); }
		public static Vector3Int xxz(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int yxz(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int yxz(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.yxz(); }
		public static Vector3Int zxz(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int wxz(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.z); }
		public static Vector3Int wxz(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.wxz(); }
		public static Vector3Int xyz(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int xyz(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.xyz(); }
		public static Vector3Int yyz(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int zyz(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int wyz(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.z); }
		public static Vector3Int wyz(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.wyz(); }
		public static Vector3Int xzz(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int yzz(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int zzz(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.z); }
		public static Vector3Int wzz(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.z); }
		public static Vector3Int xwz(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.z); }
		public static Vector3Int xwz(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.xwz(); }
		public static Vector3Int ywz(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.z); }
		public static Vector3Int ywz(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.ywz(); }
		public static Vector3Int zwz(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.z); }
		public static Vector3Int wwz(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.z); }
		public static Vector3Int xxw(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.w); }
		public static Vector3Int yxw(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.w); }
		public static Vector3Int yxw(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.yxw(); }
		public static Vector3Int zxw(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.w); }
		public static Vector3Int zxw(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.zxw(); }
		public static Vector3Int wxw(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.w); }
		public static Vector3Int xyw(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.w); }
		public static Vector3Int xyw(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.xyw(); }
		public static Vector3Int yyw(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.w); }
		public static Vector3Int zyw(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.w); }
		public static Vector3Int zyw(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.zyw(); }
		public static Vector3Int wyw(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.w); }
		public static Vector3Int xzw(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.w); }
		public static Vector3Int xzw(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.xzw(); }
		public static Vector3Int yzw(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.w); }
		public static Vector3Int yzw(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.yzw(); }
		public static Vector3Int zzw(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.w); }
		public static Vector3Int wzw(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.w); }
		public static Vector3Int xww(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.w); }
		public static Vector3Int yww(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.w); }
		public static Vector3Int zww(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.w); }
		public static Vector3Int www(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.w); }

		// Vector4Int with 4 components.
		public static Vector4Int xxxx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int yxxx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int zxxx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int wxxx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.x); }
		public static Vector4Int xyxx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int yyxx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int zyxx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int wyxx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.x); }
		public static Vector4Int xzxx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int yzxx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int zzxx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int wzxx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.x); }
		public static Vector4Int xwxx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.x); }
		public static Vector4Int ywxx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.x); }
		public static Vector4Int zwxx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.x); }
		public static Vector4Int wwxx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.x); }
		public static Vector4Int xxyx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int yxyx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int zxyx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int wxyx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.x); }
		public static Vector4Int xyyx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int yyyx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int zyyx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int wyyx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.x); }
		public static Vector4Int xzyx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int yzyx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int zzyx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int wzyx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.x); }
		public static Vector4Int wzyx(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.wzyx(); }
		public static Vector4Int xwyx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.x); }
		public static Vector4Int ywyx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.x); }
		public static Vector4Int zwyx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.x); }
		public static Vector4Int zwyx(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.zwyx(); }
		public static Vector4Int wwyx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.x); }
		public static Vector4Int xxzx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int yxzx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int zxzx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int wxzx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.x); }
		public static Vector4Int xyzx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int yyzx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int zyzx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int wyzx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.x); }
		public static Vector4Int wyzx(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.wyzx(); }
		public static Vector4Int xzzx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int yzzx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int zzzx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int wzzx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.x); }
		public static Vector4Int xwzx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.x); }
		public static Vector4Int ywzx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.x); }
		public static Vector4Int ywzx(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.ywzx(); }
		public static Vector4Int zwzx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.x); }
		public static Vector4Int wwzx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.x); }
		public static Vector4Int xxwx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.x); }
		public static Vector4Int yxwx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.x); }
		public static Vector4Int zxwx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.x); }
		public static Vector4Int wxwx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.x); }
		public static Vector4Int xywx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.x); }
		public static Vector4Int yywx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.x); }
		public static Vector4Int zywx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.x); }
		public static Vector4Int zywx(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.zywx(); }
		public static Vector4Int wywx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.x); }
		public static Vector4Int xzwx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.x); }
		public static Vector4Int yzwx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.x); }
		public static Vector4Int yzwx(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.yzwx(); }
		public static Vector4Int zzwx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.x); }
		public static Vector4Int wzwx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.x); }
		public static Vector4Int xwwx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.x); }
		public static Vector4Int ywwx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.x); }
		public static Vector4Int zwwx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.x); }
		public static Vector4Int wwwx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.x); }
		public static Vector4Int xxxy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int yxxy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int zxxy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int wxxy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.y); }
		public static Vector4Int xyxy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int yyxy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int zyxy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int wyxy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.y); }
		public static Vector4Int xzxy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int yzxy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int zzxy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int wzxy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.y); }
		public static Vector4Int wzxy(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.wzxy(); }
		public static Vector4Int xwxy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.y); }
		public static Vector4Int ywxy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.y); }
		public static Vector4Int zwxy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.y); }
		public static Vector4Int zwxy(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.zwxy(); }
		public static Vector4Int wwxy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.y); }
		public static Vector4Int xxyy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int yxyy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int zxyy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int wxyy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.y); }
		public static Vector4Int xyyy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int yyyy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int zyyy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int wyyy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.y); }
		public static Vector4Int xzyy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int yzyy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int zzyy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int wzyy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.y); }
		public static Vector4Int xwyy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.y); }
		public static Vector4Int ywyy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.y); }
		public static Vector4Int zwyy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.y); }
		public static Vector4Int wwyy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.y); }
		public static Vector4Int xxzy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int yxzy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int zxzy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int wxzy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.y); }
		public static Vector4Int wxzy(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.wxzy(); }
		public static Vector4Int xyzy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int yyzy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int zyzy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int wyzy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.y); }
		public static Vector4Int xzzy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int yzzy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int zzzy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int wzzy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.y); }
		public static Vector4Int xwzy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.y); }
		public static Vector4Int xwzy(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.xwzy(); }
		public static Vector4Int ywzy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.y); }
		public static Vector4Int zwzy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.y); }
		public static Vector4Int wwzy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.y); }
		public static Vector4Int xxwy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.y); }
		public static Vector4Int yxwy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.y); }
		public static Vector4Int zxwy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.y); }
		public static Vector4Int zxwy(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.zxwy(); }
		public static Vector4Int wxwy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.y); }
		public static Vector4Int xywy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.y); }
		public static Vector4Int yywy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.y); }
		public static Vector4Int zywy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.y); }
		public static Vector4Int wywy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.y); }
		public static Vector4Int xzwy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.y); }
		public static Vector4Int xzwy(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.xzwy(); }
		public static Vector4Int yzwy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.y); }
		public static Vector4Int zzwy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.y); }
		public static Vector4Int wzwy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.y); }
		public static Vector4Int xwwy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.y); }
		public static Vector4Int ywwy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.y); }
		public static Vector4Int zwwy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.y); }
		public static Vector4Int wwwy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.y); }
		public static Vector4Int xxxz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int yxxz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int zxxz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int wxxz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.z); }
		public static Vector4Int xyxz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int yyxz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int zyxz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int wyxz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.z); }
		public static Vector4Int wyxz(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.wyxz(); }
		public static Vector4Int xzxz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int yzxz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int zzxz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int wzxz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.z); }
		public static Vector4Int xwxz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.z); }
		public static Vector4Int ywxz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.z); }
		public static Vector4Int ywxz(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.ywxz(); }
		public static Vector4Int zwxz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.z); }
		public static Vector4Int wwxz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.z); }
		public static Vector4Int xxyz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int yxyz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int zxyz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int wxyz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.z); }
		public static Vector4Int wxyz(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.wxyz(); }
		public static Vector4Int xyyz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int yyyz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int zyyz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int wyyz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.z); }
		public static Vector4Int xzyz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int yzyz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int zzyz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int wzyz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.z); }
		public static Vector4Int xwyz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.z); }
		public static Vector4Int xwyz(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.xwyz(); }
		public static Vector4Int ywyz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.z); }
		public static Vector4Int zwyz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.z); }
		public static Vector4Int wwyz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.z); }
		public static Vector4Int xxzz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int yxzz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int zxzz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int wxzz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.z); }
		public static Vector4Int xyzz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int yyzz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int zyzz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int wyzz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.z); }
		public static Vector4Int xzzz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int yzzz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int zzzz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
		public static Vector4Int wzzz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.z); }
		public static Vector4Int xwzz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.z); }
		public static Vector4Int ywzz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.z); }
		public static Vector4Int zwzz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.z); }
		public static Vector4Int wwzz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.z); }
		public static Vector4Int xxwz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.z); }
		public static Vector4Int yxwz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.z); }
		public static Vector4Int yxwz(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.yxwz(); }
		public static Vector4Int zxwz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.z); }
		public static Vector4Int wxwz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.z); }
		public static Vector4Int xywz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.z); }
		public static Vector4Int xywz(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.xywz(); }
		public static Vector4Int yywz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.z); }
		public static Vector4Int zywz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.z); }
		public static Vector4Int wywz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.z); }
		public static Vector4Int xzwz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.z); }
		public static Vector4Int yzwz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.z); }
		public static Vector4Int zzwz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.z); }
		public static Vector4Int wzwz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.z); }
		public static Vector4Int xwwz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.z); }
		public static Vector4Int ywwz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.z); }
		public static Vector4Int zwwz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.z); }
		public static Vector4Int wwwz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.z); }
		public static Vector4Int xxxw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.w); }
		public static Vector4Int yxxw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.w); }
		public static Vector4Int zxxw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.w); }
		public static Vector4Int wxxw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.w); }
		public static Vector4Int xyxw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.w); }
		public static Vector4Int yyxw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.w); }
		public static Vector4Int zyxw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.w); }
		public static Vector4Int zyxw(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.zyxw(); }
		public static Vector4Int wyxw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.w); }
		public static Vector4Int xzxw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.w); }
		public static Vector4Int yzxw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.w); }
		public static Vector4Int yzxw(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.yzxw(); }
		public static Vector4Int zzxw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.w); }
		public static Vector4Int wzxw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.w); }
		public static Vector4Int xwxw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.w); }
		public static Vector4Int ywxw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.w); }
		public static Vector4Int zwxw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.w); }
		public static Vector4Int wwxw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.w); }
		public static Vector4Int xxyw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.w); }
		public static Vector4Int yxyw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.w); }
		public static Vector4Int zxyw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.w); }
		public static Vector4Int zxyw(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.zxyw(); }
		public static Vector4Int wxyw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.w); }
		public static Vector4Int xyyw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.w); }
		public static Vector4Int yyyw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.w); }
		public static Vector4Int zyyw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.w); }
		public static Vector4Int wyyw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.w); }
		public static Vector4Int xzyw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.w); }
		public static Vector4Int xzyw(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.xzyw(); }
		public static Vector4Int yzyw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.w); }
		public static Vector4Int zzyw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.w); }
		public static Vector4Int wzyw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.w); }
		public static Vector4Int xwyw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.w); }
		public static Vector4Int ywyw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.w); }
		public static Vector4Int zwyw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.w); }
		public static Vector4Int wwyw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.w); }
		public static Vector4Int xxzw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.w); }
		public static Vector4Int yxzw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.w); }
		public static Vector4Int yxzw(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.yxzw(); }
		public static Vector4Int zxzw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.w); }
		public static Vector4Int wxzw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.w); }
		public static Vector4Int xyzw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.w); }
		public static Vector4Int xyzw(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.xyzw(); }
		public static Vector4Int yyzw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.w); }
		public static Vector4Int zyzw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.w); }
		public static Vector4Int wyzw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.w); }
		public static Vector4Int xzzw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.w); }
		public static Vector4Int yzzw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.w); }
		public static Vector4Int zzzw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.w); }
		public static Vector4Int wzzw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.w); }
		public static Vector4Int xwzw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.w); }
		public static Vector4Int ywzw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.w); }
		public static Vector4Int zwzw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.w); }
		public static Vector4Int wwzw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.w); }
		public static Vector4Int xxww(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.w); }
		public static Vector4Int yxww(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.w); }
		public static Vector4Int zxww(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.w); }
		public static Vector4Int wxww(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.w); }
		public static Vector4Int xyww(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.w); }
		public static Vector4Int yyww(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.w); }
		public static Vector4Int zyww(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.w); }
		public static Vector4Int wyww(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.w); }
		public static Vector4Int xzww(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.w); }
		public static Vector4Int yzww(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.w); }
		public static Vector4Int zzww(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.w); }
		public static Vector4Int wzww(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.w); }
		public static Vector4Int xwww(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.w); }
		public static Vector4Int ywww(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.w); }
		public static Vector4Int zwww(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.w); }
		public static Vector4Int wwww(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.w); }
	}

	public static class Vector2IntrgSwizzleExtension
	{
		// Vector2Int with 1 components.
		public static int r(this Vector2Int v) { return v.x; }
		public static int r(this Vector2Int v, int other) { v.x = other; return v.r(); }
		public static int g(this Vector2Int v) { return v.y; }
		public static int g(this Vector2Int v, int other) { v.y = other; return v.g(); }

		// Vector2Int with 2 components.
		public static Vector2Int rr(this Vector2Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int gr(this Vector2Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int gr(this Vector2Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.gr(); }
		public static Vector2Int rg(this Vector2Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int rg(this Vector2Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.rg(); }
		public static Vector2Int gg(this Vector2Int v) { return new Vector2Int(v.y, v.y); }

		// Vector2Int with 3 components.
		public static Vector3Int rrr(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int grr(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int rgr(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int ggr(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int rrg(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int grg(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int rgg(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ggg(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.y); }

		// Vector2Int with 4 components.
		public static Vector4Int rrrr(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int grrr(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int rgrr(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ggrr(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int rrgr(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int grgr(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int rggr(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int gggr(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int rrrg(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int grrg(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int rgrg(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ggrg(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int rrgg(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int grgg(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int rggg(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int gggg(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3IntrgbSwizzleExtension
	{
		// Vector3Int with 1 components.
		public static int r(this Vector3Int v) { return v.x; }
		public static int r(this Vector3Int v, int other) { v.x = other; return v.r(); }
		public static int g(this Vector3Int v) { return v.y; }
		public static int g(this Vector3Int v, int other) { v.y = other; return v.g(); }
		public static int b(this Vector3Int v) { return v.z; }
		public static int b(this Vector3Int v, int other) { v.z = other; return v.b(); }

		// Vector3Int with 2 components.
		public static Vector2Int rr(this Vector3Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int gr(this Vector3Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int gr(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.gr(); }
		public static Vector2Int br(this Vector3Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int br(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.br(); }
		public static Vector2Int rg(this Vector3Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int rg(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.rg(); }
		public static Vector2Int gg(this Vector3Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int bg(this Vector3Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int bg(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.bg(); }
		public static Vector2Int rb(this Vector3Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int rb(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.rb(); }
		public static Vector2Int gb(this Vector3Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int gb(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.gb(); }
		public static Vector2Int bb(this Vector3Int v) { return new Vector2Int(v.z, v.z); }

		// Vector3Int with 3 components.
		public static Vector3Int rrr(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int grr(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int brr(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int rgr(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int ggr(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int bgr(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int bgr(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.bgr(); }
		public static Vector3Int rbr(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int gbr(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int gbr(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.gbr(); }
		public static Vector3Int bbr(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int rrg(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int grg(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int brg(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int brg(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.brg(); }
		public static Vector3Int rgg(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ggg(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int bgg(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int rbg(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int rbg(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.rbg(); }
		public static Vector3Int gbg(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int bbg(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int rrb(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int grb(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int grb(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.grb(); }
		public static Vector3Int brb(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int rgb(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int rgb(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.rgb(); }
		public static Vector3Int ggb(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int bgb(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int rbb(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int gbb(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int bbb(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.z); }

		// Vector3Int with 4 components.
		public static Vector4Int rrrr(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int grrr(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int brrr(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int rgrr(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ggrr(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int bgrr(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int rbrr(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int gbrr(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int bbrr(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int rrgr(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int grgr(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int brgr(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int rggr(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int gggr(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int bggr(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int rbgr(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int gbgr(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int bbgr(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int rrbr(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int grbr(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int brbr(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int rgbr(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int ggbr(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int bgbr(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int rbbr(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int gbbr(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int bbbr(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int rrrg(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int grrg(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int brrg(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int rgrg(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ggrg(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int bgrg(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int rbrg(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int gbrg(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int bbrg(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int rrgg(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int grgg(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int brgg(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int rggg(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int gggg(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int bggg(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int rbgg(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int gbgg(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int bbgg(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int rrbg(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int grbg(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int brbg(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int rgbg(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int ggbg(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int bgbg(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int rbbg(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int gbbg(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int bbbg(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int rrrb(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int grrb(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int brrb(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int rgrb(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int ggrb(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int bgrb(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int rbrb(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int gbrb(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int bbrb(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int rrgb(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int grgb(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int brgb(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int rggb(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int gggb(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int bggb(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int rbgb(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int gbgb(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int bbgb(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int rrbb(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int grbb(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int brbb(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int rgbb(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int ggbb(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int bgbb(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int rbbb(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int gbbb(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int bbbb(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4IntrgbaSwizzleExtension
	{
		// Vector4Int with 1 components.
		public static int r(this Vector4Int v) { return v.x; }
		public static int r(this Vector4Int v, int other) { v.x = other; return v.r(); }
		public static int g(this Vector4Int v) { return v.y; }
		public static int g(this Vector4Int v, int other) { v.y = other; return v.g(); }
		public static int b(this Vector4Int v) { return v.z; }
		public static int b(this Vector4Int v, int other) { v.z = other; return v.b(); }
		public static int a(this Vector4Int v) { return v.w; }
		public static int a(this Vector4Int v, int other) { v.w = other; return v.a(); }

		// Vector4Int with 2 components.
		public static Vector2Int rr(this Vector4Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int gr(this Vector4Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int gr(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.gr(); }
		public static Vector2Int br(this Vector4Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int br(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.br(); }
		public static Vector2Int ar(this Vector4Int v) { return new Vector2Int(v.w, v.x); }
		public static Vector2Int ar(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.x = (int)other.y(); return v.ar(); }
		public static Vector2Int rg(this Vector4Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int rg(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.rg(); }
		public static Vector2Int gg(this Vector4Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int bg(this Vector4Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int bg(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.bg(); }
		public static Vector2Int ag(this Vector4Int v) { return new Vector2Int(v.w, v.y); }
		public static Vector2Int ag(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.y = (int)other.y(); return v.ag(); }
		public static Vector2Int rb(this Vector4Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int rb(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.rb(); }
		public static Vector2Int gb(this Vector4Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int gb(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.gb(); }
		public static Vector2Int bb(this Vector4Int v) { return new Vector2Int(v.z, v.z); }
		public static Vector2Int ab(this Vector4Int v) { return new Vector2Int(v.w, v.z); }
		public static Vector2Int ab(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.z = (int)other.y(); return v.ab(); }
		public static Vector2Int ra(this Vector4Int v) { return new Vector2Int(v.x, v.w); }
		public static Vector2Int ra(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.w = (int)other.y(); return v.ra(); }
		public static Vector2Int ga(this Vector4Int v) { return new Vector2Int(v.y, v.w); }
		public static Vector2Int ga(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.w = (int)other.y(); return v.ga(); }
		public static Vector2Int ba(this Vector4Int v) { return new Vector2Int(v.z, v.w); }
		public static Vector2Int ba(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.w = (int)other.y(); return v.ba(); }
		public static Vector2Int aa(this Vector4Int v) { return new Vector2Int(v.w, v.w); }

		// Vector4Int with 3 components.
		public static Vector3Int rrr(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int grr(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int brr(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int arr(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.x); }
		public static Vector3Int rgr(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int ggr(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int bgr(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int bgr(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.bgr(); }
		public static Vector3Int agr(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.x); }
		public static Vector3Int agr(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.agr(); }
		public static Vector3Int rbr(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int gbr(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int gbr(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.gbr(); }
		public static Vector3Int bbr(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int abr(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.x); }
		public static Vector3Int abr(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.abr(); }
		public static Vector3Int rar(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.x); }
		public static Vector3Int gar(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.x); }
		public static Vector3Int gar(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.gar(); }
		public static Vector3Int bar(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.x); }
		public static Vector3Int bar(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.bar(); }
		public static Vector3Int aar(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.x); }
		public static Vector3Int rrg(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int grg(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int brg(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int brg(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.brg(); }
		public static Vector3Int arg(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.y); }
		public static Vector3Int arg(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.arg(); }
		public static Vector3Int rgg(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ggg(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int bgg(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int agg(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.y); }
		public static Vector3Int rbg(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int rbg(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.rbg(); }
		public static Vector3Int gbg(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int bbg(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int abg(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.y); }
		public static Vector3Int abg(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.abg(); }
		public static Vector3Int rag(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.y); }
		public static Vector3Int rag(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.rag(); }
		public static Vector3Int gag(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.y); }
		public static Vector3Int bag(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.y); }
		public static Vector3Int bag(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.bag(); }
		public static Vector3Int aag(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.y); }
		public static Vector3Int rrb(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int grb(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int grb(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.grb(); }
		public static Vector3Int brb(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int arb(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.z); }
		public static Vector3Int arb(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.arb(); }
		public static Vector3Int rgb(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int rgb(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.rgb(); }
		public static Vector3Int ggb(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int bgb(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int agb(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.z); }
		public static Vector3Int agb(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.agb(); }
		public static Vector3Int rbb(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int gbb(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int bbb(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.z); }
		public static Vector3Int abb(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.z); }
		public static Vector3Int rab(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.z); }
		public static Vector3Int rab(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.rab(); }
		public static Vector3Int gab(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.z); }
		public static Vector3Int gab(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.gab(); }
		public static Vector3Int bab(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.z); }
		public static Vector3Int aab(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.z); }
		public static Vector3Int rra(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.w); }
		public static Vector3Int gra(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.w); }
		public static Vector3Int gra(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.gra(); }
		public static Vector3Int bra(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.w); }
		public static Vector3Int bra(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.bra(); }
		public static Vector3Int ara(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.w); }
		public static Vector3Int rga(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.w); }
		public static Vector3Int rga(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.rga(); }
		public static Vector3Int gga(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.w); }
		public static Vector3Int bga(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.w); }
		public static Vector3Int bga(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.bga(); }
		public static Vector3Int aga(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.w); }
		public static Vector3Int rba(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.w); }
		public static Vector3Int rba(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.rba(); }
		public static Vector3Int gba(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.w); }
		public static Vector3Int gba(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.gba(); }
		public static Vector3Int bba(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.w); }
		public static Vector3Int aba(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.w); }
		public static Vector3Int raa(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.w); }
		public static Vector3Int gaa(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.w); }
		public static Vector3Int baa(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.w); }
		public static Vector3Int aaa(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.w); }

		// Vector4Int with 4 components.
		public static Vector4Int rrrr(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int grrr(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int brrr(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int arrr(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.x); }
		public static Vector4Int rgrr(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ggrr(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int bgrr(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int agrr(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.x); }
		public static Vector4Int rbrr(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int gbrr(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int bbrr(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int abrr(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.x); }
		public static Vector4Int rarr(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.x); }
		public static Vector4Int garr(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.x); }
		public static Vector4Int barr(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.x); }
		public static Vector4Int aarr(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.x); }
		public static Vector4Int rrgr(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int grgr(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int brgr(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int argr(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.x); }
		public static Vector4Int rggr(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int gggr(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int bggr(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int aggr(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.x); }
		public static Vector4Int rbgr(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int gbgr(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int bbgr(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int abgr(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.x); }
		public static Vector4Int abgr(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.abgr(); }
		public static Vector4Int ragr(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.x); }
		public static Vector4Int gagr(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.x); }
		public static Vector4Int bagr(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.x); }
		public static Vector4Int bagr(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.bagr(); }
		public static Vector4Int aagr(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.x); }
		public static Vector4Int rrbr(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int grbr(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int brbr(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int arbr(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.x); }
		public static Vector4Int rgbr(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int ggbr(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int bgbr(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int agbr(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.x); }
		public static Vector4Int agbr(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.agbr(); }
		public static Vector4Int rbbr(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int gbbr(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int bbbr(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int abbr(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.x); }
		public static Vector4Int rabr(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.x); }
		public static Vector4Int gabr(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.x); }
		public static Vector4Int gabr(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.gabr(); }
		public static Vector4Int babr(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.x); }
		public static Vector4Int aabr(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.x); }
		public static Vector4Int rrar(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.x); }
		public static Vector4Int grar(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.x); }
		public static Vector4Int brar(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.x); }
		public static Vector4Int arar(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.x); }
		public static Vector4Int rgar(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.x); }
		public static Vector4Int ggar(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.x); }
		public static Vector4Int bgar(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.x); }
		public static Vector4Int bgar(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.bgar(); }
		public static Vector4Int agar(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.x); }
		public static Vector4Int rbar(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.x); }
		public static Vector4Int gbar(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.x); }
		public static Vector4Int gbar(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.gbar(); }
		public static Vector4Int bbar(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.x); }
		public static Vector4Int abar(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.x); }
		public static Vector4Int raar(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.x); }
		public static Vector4Int gaar(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.x); }
		public static Vector4Int baar(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.x); }
		public static Vector4Int aaar(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.x); }
		public static Vector4Int rrrg(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int grrg(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int brrg(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int arrg(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.y); }
		public static Vector4Int rgrg(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ggrg(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int bgrg(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int agrg(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.y); }
		public static Vector4Int rbrg(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int gbrg(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int bbrg(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int abrg(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.y); }
		public static Vector4Int abrg(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.abrg(); }
		public static Vector4Int rarg(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.y); }
		public static Vector4Int garg(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.y); }
		public static Vector4Int barg(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.y); }
		public static Vector4Int barg(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.barg(); }
		public static Vector4Int aarg(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.y); }
		public static Vector4Int rrgg(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int grgg(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int brgg(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int argg(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.y); }
		public static Vector4Int rggg(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int gggg(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int bggg(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int aggg(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.y); }
		public static Vector4Int rbgg(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int gbgg(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int bbgg(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int abgg(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.y); }
		public static Vector4Int ragg(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.y); }
		public static Vector4Int gagg(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.y); }
		public static Vector4Int bagg(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.y); }
		public static Vector4Int aagg(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.y); }
		public static Vector4Int rrbg(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int grbg(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int brbg(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int arbg(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.y); }
		public static Vector4Int arbg(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.arbg(); }
		public static Vector4Int rgbg(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int ggbg(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int bgbg(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int agbg(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.y); }
		public static Vector4Int rbbg(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int gbbg(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int bbbg(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int abbg(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.y); }
		public static Vector4Int rabg(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.y); }
		public static Vector4Int rabg(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.rabg(); }
		public static Vector4Int gabg(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.y); }
		public static Vector4Int babg(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.y); }
		public static Vector4Int aabg(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.y); }
		public static Vector4Int rrag(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.y); }
		public static Vector4Int grag(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.y); }
		public static Vector4Int brag(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.y); }
		public static Vector4Int brag(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.brag(); }
		public static Vector4Int arag(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.y); }
		public static Vector4Int rgag(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.y); }
		public static Vector4Int ggag(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.y); }
		public static Vector4Int bgag(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.y); }
		public static Vector4Int agag(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.y); }
		public static Vector4Int rbag(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.y); }
		public static Vector4Int rbag(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.rbag(); }
		public static Vector4Int gbag(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.y); }
		public static Vector4Int bbag(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.y); }
		public static Vector4Int abag(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.y); }
		public static Vector4Int raag(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.y); }
		public static Vector4Int gaag(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.y); }
		public static Vector4Int baag(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.y); }
		public static Vector4Int aaag(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.y); }
		public static Vector4Int rrrb(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int grrb(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int brrb(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int arrb(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.z); }
		public static Vector4Int rgrb(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int ggrb(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int bgrb(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int agrb(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.z); }
		public static Vector4Int agrb(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.agrb(); }
		public static Vector4Int rbrb(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int gbrb(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int bbrb(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int abrb(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.z); }
		public static Vector4Int rarb(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.z); }
		public static Vector4Int garb(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.z); }
		public static Vector4Int garb(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.garb(); }
		public static Vector4Int barb(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.z); }
		public static Vector4Int aarb(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.z); }
		public static Vector4Int rrgb(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int grgb(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int brgb(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int argb(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.z); }
		public static Vector4Int argb(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.argb(); }
		public static Vector4Int rggb(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int gggb(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int bggb(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int aggb(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.z); }
		public static Vector4Int rbgb(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int gbgb(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int bbgb(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int abgb(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.z); }
		public static Vector4Int ragb(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.z); }
		public static Vector4Int ragb(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.ragb(); }
		public static Vector4Int gagb(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.z); }
		public static Vector4Int bagb(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.z); }
		public static Vector4Int aagb(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.z); }
		public static Vector4Int rrbb(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int grbb(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int brbb(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int arbb(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.z); }
		public static Vector4Int rgbb(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int ggbb(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int bgbb(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int agbb(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.z); }
		public static Vector4Int rbbb(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int gbbb(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int bbbb(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
		public static Vector4Int abbb(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.z); }
		public static Vector4Int rabb(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.z); }
		public static Vector4Int gabb(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.z); }
		public static Vector4Int babb(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.z); }
		public static Vector4Int aabb(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.z); }
		public static Vector4Int rrab(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.z); }
		public static Vector4Int grab(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.z); }
		public static Vector4Int grab(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.grab(); }
		public static Vector4Int brab(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.z); }
		public static Vector4Int arab(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.z); }
		public static Vector4Int rgab(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.z); }
		public static Vector4Int rgab(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.rgab(); }
		public static Vector4Int ggab(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.z); }
		public static Vector4Int bgab(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.z); }
		public static Vector4Int agab(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.z); }
		public static Vector4Int rbab(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.z); }
		public static Vector4Int gbab(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.z); }
		public static Vector4Int bbab(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.z); }
		public static Vector4Int abab(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.z); }
		public static Vector4Int raab(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.z); }
		public static Vector4Int gaab(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.z); }
		public static Vector4Int baab(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.z); }
		public static Vector4Int aaab(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.z); }
		public static Vector4Int rrra(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.w); }
		public static Vector4Int grra(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.w); }
		public static Vector4Int brra(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.w); }
		public static Vector4Int arra(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.w); }
		public static Vector4Int rgra(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.w); }
		public static Vector4Int ggra(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.w); }
		public static Vector4Int bgra(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.w); }
		public static Vector4Int bgra(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.bgra(); }
		public static Vector4Int agra(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.w); }
		public static Vector4Int rbra(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.w); }
		public static Vector4Int gbra(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.w); }
		public static Vector4Int gbra(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.gbra(); }
		public static Vector4Int bbra(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.w); }
		public static Vector4Int abra(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.w); }
		public static Vector4Int rara(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.w); }
		public static Vector4Int gara(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.w); }
		public static Vector4Int bara(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.w); }
		public static Vector4Int aara(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.w); }
		public static Vector4Int rrga(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.w); }
		public static Vector4Int grga(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.w); }
		public static Vector4Int brga(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.w); }
		public static Vector4Int brga(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.brga(); }
		public static Vector4Int arga(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.w); }
		public static Vector4Int rgga(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.w); }
		public static Vector4Int ggga(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.w); }
		public static Vector4Int bgga(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.w); }
		public static Vector4Int agga(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.w); }
		public static Vector4Int rbga(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.w); }
		public static Vector4Int rbga(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.rbga(); }
		public static Vector4Int gbga(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.w); }
		public static Vector4Int bbga(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.w); }
		public static Vector4Int abga(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.w); }
		public static Vector4Int raga(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.w); }
		public static Vector4Int gaga(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.w); }
		public static Vector4Int baga(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.w); }
		public static Vector4Int aaga(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.w); }
		public static Vector4Int rrba(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.w); }
		public static Vector4Int grba(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.w); }
		public static Vector4Int grba(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.grba(); }
		public static Vector4Int brba(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.w); }
		public static Vector4Int arba(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.w); }
		public static Vector4Int rgba(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.w); }
		public static Vector4Int rgba(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.rgba(); }
		public static Vector4Int ggba(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.w); }
		public static Vector4Int bgba(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.w); }
		public static Vector4Int agba(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.w); }
		public static Vector4Int rbba(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.w); }
		public static Vector4Int gbba(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.w); }
		public static Vector4Int bbba(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.w); }
		public static Vector4Int abba(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.w); }
		public static Vector4Int raba(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.w); }
		public static Vector4Int gaba(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.w); }
		public static Vector4Int baba(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.w); }
		public static Vector4Int aaba(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.w); }
		public static Vector4Int rraa(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.w); }
		public static Vector4Int graa(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.w); }
		public static Vector4Int braa(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.w); }
		public static Vector4Int araa(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.w); }
		public static Vector4Int rgaa(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.w); }
		public static Vector4Int ggaa(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.w); }
		public static Vector4Int bgaa(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.w); }
		public static Vector4Int agaa(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.w); }
		public static Vector4Int rbaa(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.w); }
		public static Vector4Int gbaa(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.w); }
		public static Vector4Int bbaa(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.w); }
		public static Vector4Int abaa(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.w); }
		public static Vector4Int raaa(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.w); }
		public static Vector4Int gaaa(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.w); }
		public static Vector4Int baaa(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.w); }
		public static Vector4Int aaaa(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.w); }
	}

	public static class Vector2IntstSwizzleExtension
	{
		// Vector2Int with 1 components.
		public static int s(this Vector2Int v) { return v.x; }
		public static int s(this Vector2Int v, int other) { v.x = other; return v.s(); }
		public static int t(this Vector2Int v) { return v.y; }
		public static int t(this Vector2Int v, int other) { v.y = other; return v.t(); }

		// Vector2Int with 2 components.
		public static Vector2Int ss(this Vector2Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int ts(this Vector2Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int ts(this Vector2Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.ts(); }
		public static Vector2Int st(this Vector2Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int st(this Vector2Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.st(); }
		public static Vector2Int tt(this Vector2Int v) { return new Vector2Int(v.y, v.y); }

		// Vector2Int with 3 components.
		public static Vector3Int sss(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int tss(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int sts(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int tts(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int sst(this Vector2Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int tst(this Vector2Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int stt(this Vector2Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ttt(this Vector2Int v) { return new Vector3Int(v.y, v.y, v.y); }

		// Vector2Int with 4 components.
		public static Vector4Int ssss(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int tsss(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int stss(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ttss(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int ssts(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int tsts(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int stts(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int ttts(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int ssst(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int tsst(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int stst(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ttst(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int sstt(this Vector2Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int tstt(this Vector2Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int sttt(this Vector2Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int tttt(this Vector2Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
	}

	public static class Vector3IntstpSwizzleExtension
	{
		// Vector3Int with 1 components.
		public static int s(this Vector3Int v) { return v.x; }
		public static int s(this Vector3Int v, int other) { v.x = other; return v.s(); }
		public static int t(this Vector3Int v) { return v.y; }
		public static int t(this Vector3Int v, int other) { v.y = other; return v.t(); }
		public static int p(this Vector3Int v) { return v.z; }
		public static int p(this Vector3Int v, int other) { v.z = other; return v.p(); }

		// Vector3Int with 2 components.
		public static Vector2Int ss(this Vector3Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int ts(this Vector3Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int ts(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.ts(); }
		public static Vector2Int ps(this Vector3Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int ps(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.ps(); }
		public static Vector2Int st(this Vector3Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int st(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.st(); }
		public static Vector2Int tt(this Vector3Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int pt(this Vector3Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int pt(this Vector3Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.pt(); }
		public static Vector2Int sp(this Vector3Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int sp(this Vector3Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.sp(); }
		public static Vector2Int tp(this Vector3Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int tp(this Vector3Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.tp(); }
		public static Vector2Int pp(this Vector3Int v) { return new Vector2Int(v.z, v.z); }

		// Vector3Int with 3 components.
		public static Vector3Int sss(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int tss(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int pss(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int sts(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int tts(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int pts(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int pts(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.pts(); }
		public static Vector3Int sps(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int tps(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int tps(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.tps(); }
		public static Vector3Int pps(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int sst(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int tst(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int pst(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int pst(this Vector3Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.pst(); }
		public static Vector3Int stt(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ttt(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int ptt(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int spt(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int spt(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.spt(); }
		public static Vector3Int tpt(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int ppt(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int ssp(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int tsp(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int tsp(this Vector3Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.tsp(); }
		public static Vector3Int psp(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int stp(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int stp(this Vector3Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.stp(); }
		public static Vector3Int ttp(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int ptp(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int spp(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int tpp(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int ppp(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.z); }

		// Vector3Int with 4 components.
		public static Vector4Int ssss(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int tsss(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int psss(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int stss(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ttss(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int ptss(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int spss(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int tpss(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int ppss(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int ssts(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int tsts(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int psts(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int stts(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int ttts(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int ptts(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int spts(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int tpts(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int ppts(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int ssps(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int tsps(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int psps(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int stps(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int ttps(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int ptps(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int spps(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int tpps(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int ppps(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int ssst(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int tsst(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int psst(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int stst(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ttst(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int ptst(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int spst(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int tpst(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int ppst(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int sstt(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int tstt(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int pstt(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int sttt(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int tttt(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int pttt(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int sptt(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int tptt(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int pptt(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int sspt(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int tspt(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int pspt(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int stpt(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int ttpt(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int ptpt(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int sppt(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int tppt(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int pppt(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int sssp(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int tssp(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int pssp(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int stsp(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int ttsp(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int ptsp(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int spsp(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int tpsp(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int ppsp(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int sstp(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int tstp(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int pstp(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int sttp(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int tttp(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int pttp(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int sptp(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int tptp(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int pptp(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int sspp(this Vector3Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int tspp(this Vector3Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int pspp(this Vector3Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int stpp(this Vector3Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int ttpp(this Vector3Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int ptpp(this Vector3Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int sppp(this Vector3Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int tppp(this Vector3Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int pppp(this Vector3Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
	}

	public static class Vector4IntstpqSwizzleExtension
	{
		// Vector4Int with 1 components.
		public static int s(this Vector4Int v) { return v.x; }
		public static int s(this Vector4Int v, int other) { v.x = other; return v.s(); }
		public static int t(this Vector4Int v) { return v.y; }
		public static int t(this Vector4Int v, int other) { v.y = other; return v.t(); }
		public static int p(this Vector4Int v) { return v.z; }
		public static int p(this Vector4Int v, int other) { v.z = other; return v.p(); }
		public static int q(this Vector4Int v) { return v.w; }
		public static int q(this Vector4Int v, int other) { v.w = other; return v.q(); }

		// Vector4Int with 2 components.
		public static Vector2Int ss(this Vector4Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int ts(this Vector4Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int ts(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.x = (int)other.y(); return v.ts(); }
		public static Vector2Int ps(this Vector4Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int ps(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.x = (int)other.y(); return v.ps(); }
		public static Vector2Int qs(this Vector4Int v) { return new Vector2Int(v.w, v.x); }
		public static Vector2Int qs(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.x = (int)other.y(); return v.qs(); }
		public static Vector2Int st(this Vector4Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int st(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.y = (int)other.y(); return v.st(); }
		public static Vector2Int tt(this Vector4Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int pt(this Vector4Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int pt(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.y = (int)other.y(); return v.pt(); }
		public static Vector2Int qt(this Vector4Int v) { return new Vector2Int(v.w, v.y); }
		public static Vector2Int qt(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.y = (int)other.y(); return v.qt(); }
		public static Vector2Int sp(this Vector4Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int sp(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.z = (int)other.y(); return v.sp(); }
		public static Vector2Int tp(this Vector4Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int tp(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.z = (int)other.y(); return v.tp(); }
		public static Vector2Int pp(this Vector4Int v) { return new Vector2Int(v.z, v.z); }
		public static Vector2Int qp(this Vector4Int v) { return new Vector2Int(v.w, v.z); }
		public static Vector2Int qp(this Vector4Int v, Vector2Int other) { v.w = (int)other.x();v.z = (int)other.y(); return v.qp(); }
		public static Vector2Int sq(this Vector4Int v) { return new Vector2Int(v.x, v.w); }
		public static Vector2Int sq(this Vector4Int v, Vector2Int other) { v.x = (int)other.x();v.w = (int)other.y(); return v.sq(); }
		public static Vector2Int tq(this Vector4Int v) { return new Vector2Int(v.y, v.w); }
		public static Vector2Int tq(this Vector4Int v, Vector2Int other) { v.y = (int)other.x();v.w = (int)other.y(); return v.tq(); }
		public static Vector2Int pq(this Vector4Int v) { return new Vector2Int(v.z, v.w); }
		public static Vector2Int pq(this Vector4Int v, Vector2Int other) { v.z = (int)other.x();v.w = (int)other.y(); return v.pq(); }
		public static Vector2Int qq(this Vector4Int v) { return new Vector2Int(v.w, v.w); }

		// Vector4Int with 3 components.
		public static Vector3Int sss(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int tss(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int pss(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int qss(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.x); }
		public static Vector3Int sts(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int tts(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int pts(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int pts(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.pts(); }
		public static Vector3Int qts(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.x); }
		public static Vector3Int qts(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z(); return v.qts(); }
		public static Vector3Int sps(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int tps(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int tps(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.tps(); }
		public static Vector3Int pps(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int qps(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.x); }
		public static Vector3Int qps(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z(); return v.qps(); }
		public static Vector3Int sqs(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.x); }
		public static Vector3Int tqs(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.x); }
		public static Vector3Int tqs(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.tqs(); }
		public static Vector3Int pqs(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.x); }
		public static Vector3Int pqs(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z(); return v.pqs(); }
		public static Vector3Int qqs(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.x); }
		public static Vector3Int sst(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int tst(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int pst(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int pst(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.pst(); }
		public static Vector3Int qst(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.y); }
		public static Vector3Int qst(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z(); return v.qst(); }
		public static Vector3Int stt(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int ttt(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int ptt(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int qtt(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.y); }
		public static Vector3Int spt(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int spt(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.spt(); }
		public static Vector3Int tpt(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int ppt(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int qpt(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.y); }
		public static Vector3Int qpt(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z(); return v.qpt(); }
		public static Vector3Int sqt(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.y); }
		public static Vector3Int sqt(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.sqt(); }
		public static Vector3Int tqt(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.y); }
		public static Vector3Int pqt(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.y); }
		public static Vector3Int pqt(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z(); return v.pqt(); }
		public static Vector3Int qqt(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.y); }
		public static Vector3Int ssp(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int tsp(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int tsp(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.tsp(); }
		public static Vector3Int psp(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int qsp(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.z); }
		public static Vector3Int qsp(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z(); return v.qsp(); }
		public static Vector3Int stp(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int stp(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.stp(); }
		public static Vector3Int ttp(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int ptp(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int qtp(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.z); }
		public static Vector3Int qtp(this Vector4Int v, Vector3Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z(); return v.qtp(); }
		public static Vector3Int spp(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int tpp(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int ppp(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.z); }
		public static Vector3Int qpp(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.z); }
		public static Vector3Int sqp(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.z); }
		public static Vector3Int sqp(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.sqp(); }
		public static Vector3Int tqp(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.z); }
		public static Vector3Int tqp(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z(); return v.tqp(); }
		public static Vector3Int pqp(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.z); }
		public static Vector3Int qqp(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.z); }
		public static Vector3Int ssq(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.w); }
		public static Vector3Int tsq(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.w); }
		public static Vector3Int tsq(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.tsq(); }
		public static Vector3Int psq(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.w); }
		public static Vector3Int psq(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z(); return v.psq(); }
		public static Vector3Int qsq(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.w); }
		public static Vector3Int stq(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.w); }
		public static Vector3Int stq(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.stq(); }
		public static Vector3Int ttq(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.w); }
		public static Vector3Int ptq(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.w); }
		public static Vector3Int ptq(this Vector4Int v, Vector3Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z(); return v.ptq(); }
		public static Vector3Int qtq(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.w); }
		public static Vector3Int spq(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.w); }
		public static Vector3Int spq(this Vector4Int v, Vector3Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.spq(); }
		public static Vector3Int tpq(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.w); }
		public static Vector3Int tpq(this Vector4Int v, Vector3Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z(); return v.tpq(); }
		public static Vector3Int ppq(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.w); }
		public static Vector3Int qpq(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.w); }
		public static Vector3Int sqq(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.w); }
		public static Vector3Int tqq(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.w); }
		public static Vector3Int pqq(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.w); }
		public static Vector3Int qqq(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.w); }

		// Vector4Int with 4 components.
		public static Vector4Int ssss(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int tsss(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int psss(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int qsss(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.x); }
		public static Vector4Int stss(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int ttss(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int ptss(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int qtss(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.x); }
		public static Vector4Int spss(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int tpss(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int ppss(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int qpss(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.x); }
		public static Vector4Int sqss(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.x); }
		public static Vector4Int tqss(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.x); }
		public static Vector4Int pqss(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.x); }
		public static Vector4Int qqss(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.x); }
		public static Vector4Int ssts(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int tsts(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int psts(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int qsts(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.x); }
		public static Vector4Int stts(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int ttts(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int ptts(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int qtts(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.x); }
		public static Vector4Int spts(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int tpts(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int ppts(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int qpts(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.x); }
		public static Vector4Int qpts(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.qpts(); }
		public static Vector4Int sqts(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.x); }
		public static Vector4Int tqts(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.x); }
		public static Vector4Int pqts(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.x); }
		public static Vector4Int pqts(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.x = (int)other.w(); return v.pqts(); }
		public static Vector4Int qqts(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.x); }
		public static Vector4Int ssps(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int tsps(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int psps(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int qsps(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.x); }
		public static Vector4Int stps(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int ttps(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int ptps(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int qtps(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.x); }
		public static Vector4Int qtps(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.qtps(); }
		public static Vector4Int spps(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int tpps(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int ppps(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int qpps(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.x); }
		public static Vector4Int sqps(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.x); }
		public static Vector4Int tqps(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.x); }
		public static Vector4Int tqps(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.x = (int)other.w(); return v.tqps(); }
		public static Vector4Int pqps(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.x); }
		public static Vector4Int qqps(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.x); }
		public static Vector4Int ssqs(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.x); }
		public static Vector4Int tsqs(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.x); }
		public static Vector4Int psqs(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.x); }
		public static Vector4Int qsqs(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.x); }
		public static Vector4Int stqs(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.x); }
		public static Vector4Int ttqs(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.x); }
		public static Vector4Int ptqs(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.x); }
		public static Vector4Int ptqs(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.ptqs(); }
		public static Vector4Int qtqs(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.x); }
		public static Vector4Int spqs(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.x); }
		public static Vector4Int tpqs(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.x); }
		public static Vector4Int tpqs(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.x = (int)other.w(); return v.tpqs(); }
		public static Vector4Int ppqs(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.x); }
		public static Vector4Int qpqs(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.x); }
		public static Vector4Int sqqs(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.x); }
		public static Vector4Int tqqs(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.x); }
		public static Vector4Int pqqs(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.x); }
		public static Vector4Int qqqs(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.x); }
		public static Vector4Int ssst(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int tsst(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int psst(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int qsst(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.y); }
		public static Vector4Int stst(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int ttst(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int ptst(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int qtst(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.y); }
		public static Vector4Int spst(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int tpst(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int ppst(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int qpst(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.y); }
		public static Vector4Int qpst(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.qpst(); }
		public static Vector4Int sqst(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.y); }
		public static Vector4Int tqst(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.y); }
		public static Vector4Int pqst(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.y); }
		public static Vector4Int pqst(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.y = (int)other.w(); return v.pqst(); }
		public static Vector4Int qqst(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.y); }
		public static Vector4Int sstt(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int tstt(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int pstt(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int qstt(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.y); }
		public static Vector4Int sttt(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int tttt(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int pttt(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int qttt(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.y); }
		public static Vector4Int sptt(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int tptt(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int pptt(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int qptt(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.y); }
		public static Vector4Int sqtt(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.y); }
		public static Vector4Int tqtt(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.y); }
		public static Vector4Int pqtt(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.y); }
		public static Vector4Int qqtt(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.y); }
		public static Vector4Int sspt(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int tspt(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int pspt(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int qspt(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.y); }
		public static Vector4Int qspt(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.qspt(); }
		public static Vector4Int stpt(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int ttpt(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int ptpt(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int qtpt(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.y); }
		public static Vector4Int sppt(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int tppt(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int pppt(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int qppt(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.y); }
		public static Vector4Int sqpt(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.y); }
		public static Vector4Int sqpt(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.z = (int)other.z();v.y = (int)other.w(); return v.sqpt(); }
		public static Vector4Int tqpt(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.y); }
		public static Vector4Int pqpt(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.y); }
		public static Vector4Int qqpt(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.y); }
		public static Vector4Int ssqt(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.y); }
		public static Vector4Int tsqt(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.y); }
		public static Vector4Int psqt(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.y); }
		public static Vector4Int psqt(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.psqt(); }
		public static Vector4Int qsqt(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.y); }
		public static Vector4Int stqt(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.y); }
		public static Vector4Int ttqt(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.y); }
		public static Vector4Int ptqt(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.y); }
		public static Vector4Int qtqt(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.y); }
		public static Vector4Int spqt(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.y); }
		public static Vector4Int spqt(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.w = (int)other.z();v.y = (int)other.w(); return v.spqt(); }
		public static Vector4Int tpqt(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.y); }
		public static Vector4Int ppqt(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.y); }
		public static Vector4Int qpqt(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.y); }
		public static Vector4Int sqqt(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.y); }
		public static Vector4Int tqqt(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.y); }
		public static Vector4Int pqqt(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.y); }
		public static Vector4Int qqqt(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.y); }
		public static Vector4Int sssp(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int tssp(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int pssp(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int qssp(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.z); }
		public static Vector4Int stsp(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int ttsp(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int ptsp(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int qtsp(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.z); }
		public static Vector4Int qtsp(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.qtsp(); }
		public static Vector4Int spsp(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int tpsp(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int ppsp(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int qpsp(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.z); }
		public static Vector4Int sqsp(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.z); }
		public static Vector4Int tqsp(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.z); }
		public static Vector4Int tqsp(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.w = (int)other.y();v.x = (int)other.z();v.z = (int)other.w(); return v.tqsp(); }
		public static Vector4Int pqsp(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.z); }
		public static Vector4Int qqsp(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.z); }
		public static Vector4Int sstp(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int tstp(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int pstp(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int qstp(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.z); }
		public static Vector4Int qstp(this Vector4Int v, Vector4Int other) { v.w = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.qstp(); }
		public static Vector4Int sttp(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int tttp(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int pttp(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int qttp(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.z); }
		public static Vector4Int sptp(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int tptp(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int pptp(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int qptp(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.z); }
		public static Vector4Int sqtp(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.z); }
		public static Vector4Int sqtp(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.w = (int)other.y();v.y = (int)other.z();v.z = (int)other.w(); return v.sqtp(); }
		public static Vector4Int tqtp(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.z); }
		public static Vector4Int pqtp(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.z); }
		public static Vector4Int qqtp(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.z); }
		public static Vector4Int sspp(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int tspp(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int pspp(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int qspp(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.z); }
		public static Vector4Int stpp(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int ttpp(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int ptpp(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int qtpp(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.z); }
		public static Vector4Int sppp(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int tppp(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int pppp(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
		public static Vector4Int qppp(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.z); }
		public static Vector4Int sqpp(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.z); }
		public static Vector4Int tqpp(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.z); }
		public static Vector4Int pqpp(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.z); }
		public static Vector4Int qqpp(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.z); }
		public static Vector4Int ssqp(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.z); }
		public static Vector4Int tsqp(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.z); }
		public static Vector4Int tsqp(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.tsqp(); }
		public static Vector4Int psqp(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.z); }
		public static Vector4Int qsqp(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.z); }
		public static Vector4Int stqp(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.z); }
		public static Vector4Int stqp(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.w = (int)other.z();v.z = (int)other.w(); return v.stqp(); }
		public static Vector4Int ttqp(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.z); }
		public static Vector4Int ptqp(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.z); }
		public static Vector4Int qtqp(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.z); }
		public static Vector4Int spqp(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.z); }
		public static Vector4Int tpqp(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.z); }
		public static Vector4Int ppqp(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.z); }
		public static Vector4Int qpqp(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.z); }
		public static Vector4Int sqqp(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.z); }
		public static Vector4Int tqqp(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.z); }
		public static Vector4Int pqqp(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.z); }
		public static Vector4Int qqqp(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.z); }
		public static Vector4Int sssq(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.w); }
		public static Vector4Int tssq(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.w); }
		public static Vector4Int pssq(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.w); }
		public static Vector4Int qssq(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.w); }
		public static Vector4Int stsq(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.w); }
		public static Vector4Int ttsq(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.w); }
		public static Vector4Int ptsq(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.w); }
		public static Vector4Int ptsq(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.y = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.ptsq(); }
		public static Vector4Int qtsq(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.w); }
		public static Vector4Int spsq(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.w); }
		public static Vector4Int tpsq(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.w); }
		public static Vector4Int tpsq(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.z = (int)other.y();v.x = (int)other.z();v.w = (int)other.w(); return v.tpsq(); }
		public static Vector4Int ppsq(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.w); }
		public static Vector4Int qpsq(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.w); }
		public static Vector4Int sqsq(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.w); }
		public static Vector4Int tqsq(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.w); }
		public static Vector4Int pqsq(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.w); }
		public static Vector4Int qqsq(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.w); }
		public static Vector4Int sstq(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.w); }
		public static Vector4Int tstq(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.w); }
		public static Vector4Int pstq(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.w); }
		public static Vector4Int pstq(this Vector4Int v, Vector4Int other) { v.z = (int)other.x();v.x = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.pstq(); }
		public static Vector4Int qstq(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.w); }
		public static Vector4Int sttq(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.w); }
		public static Vector4Int tttq(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.w); }
		public static Vector4Int pttq(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.w); }
		public static Vector4Int qttq(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.w); }
		public static Vector4Int sptq(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.w); }
		public static Vector4Int sptq(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.z = (int)other.y();v.y = (int)other.z();v.w = (int)other.w(); return v.sptq(); }
		public static Vector4Int tptq(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.w); }
		public static Vector4Int pptq(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.w); }
		public static Vector4Int qptq(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.w); }
		public static Vector4Int sqtq(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.w); }
		public static Vector4Int tqtq(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.w); }
		public static Vector4Int pqtq(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.w); }
		public static Vector4Int qqtq(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.w); }
		public static Vector4Int sspq(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.w); }
		public static Vector4Int tspq(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.w); }
		public static Vector4Int tspq(this Vector4Int v, Vector4Int other) { v.y = (int)other.x();v.x = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.tspq(); }
		public static Vector4Int pspq(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.w); }
		public static Vector4Int qspq(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.w); }
		public static Vector4Int stpq(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.w); }
		public static Vector4Int stpq(this Vector4Int v, Vector4Int other) { v.x = (int)other.x();v.y = (int)other.y();v.z = (int)other.z();v.w = (int)other.w(); return v.stpq(); }
		public static Vector4Int ttpq(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.w); }
		public static Vector4Int ptpq(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.w); }
		public static Vector4Int qtpq(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.w); }
		public static Vector4Int sppq(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.w); }
		public static Vector4Int tppq(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.w); }
		public static Vector4Int pppq(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.w); }
		public static Vector4Int qppq(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.w); }
		public static Vector4Int sqpq(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.w); }
		public static Vector4Int tqpq(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.w); }
		public static Vector4Int pqpq(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.w); }
		public static Vector4Int qqpq(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.w); }
		public static Vector4Int ssqq(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.w); }
		public static Vector4Int tsqq(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.w); }
		public static Vector4Int psqq(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.w); }
		public static Vector4Int qsqq(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.w); }
		public static Vector4Int stqq(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.w); }
		public static Vector4Int ttqq(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.w); }
		public static Vector4Int ptqq(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.w); }
		public static Vector4Int qtqq(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.w); }
		public static Vector4Int spqq(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.w); }
		public static Vector4Int tpqq(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.w); }
		public static Vector4Int ppqq(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.w); }
		public static Vector4Int qpqq(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.w); }
		public static Vector4Int sqqq(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.w); }
		public static Vector4Int tqqq(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.w); }
		public static Vector4Int pqqq(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.w); }
		public static Vector4Int qqqq(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.w); }
	}

	public static class ColorxyzwSwizzleExtension
	{
		// Color with 1 components.
		public static float x(this Color v) { return v.r; }
		public static float x(this Color v, float other) { v.r = other; return v.x(); }
		public static float y(this Color v) { return v.g; }
		public static float y(this Color v, float other) { v.g = other; return v.y(); }
		public static float z(this Color v) { return v.b; }
		public static float z(this Color v, float other) { v.b = other; return v.z(); }
		public static float w(this Color v) { return v.a; }
		public static float w(this Color v, float other) { v.a = other; return v.w(); }

		// Color with 2 components.
		public static Vector2 xx(this Color v) { return new Vector2(v.r, v.r); }
		public static Vector2 yx(this Color v) { return new Vector2(v.g, v.r); }
		public static Vector2 yx(this Color v, Vector2 other) { v.g = (float)other.r();v.r = (float)other.g(); return v.yx(); }
		public static Vector2 zx(this Color v) { return new Vector2(v.b, v.r); }
		public static Vector2 zx(this Color v, Vector2 other) { v.b = (float)other.r();v.r = (float)other.g(); return v.zx(); }
		public static Vector2 wx(this Color v) { return new Vector2(v.a, v.r); }
		public static Vector2 wx(this Color v, Vector2 other) { v.a = (float)other.r();v.r = (float)other.g(); return v.wx(); }
		public static Vector2 xy(this Color v) { return new Vector2(v.r, v.g); }
		public static Vector2 xy(this Color v, Vector2 other) { v.r = (float)other.r();v.g = (float)other.g(); return v.xy(); }
		public static Vector2 yy(this Color v) { return new Vector2(v.g, v.g); }
		public static Vector2 zy(this Color v) { return new Vector2(v.b, v.g); }
		public static Vector2 zy(this Color v, Vector2 other) { v.b = (float)other.r();v.g = (float)other.g(); return v.zy(); }
		public static Vector2 wy(this Color v) { return new Vector2(v.a, v.g); }
		public static Vector2 wy(this Color v, Vector2 other) { v.a = (float)other.r();v.g = (float)other.g(); return v.wy(); }
		public static Vector2 xz(this Color v) { return new Vector2(v.r, v.b); }
		public static Vector2 xz(this Color v, Vector2 other) { v.r = (float)other.r();v.b = (float)other.g(); return v.xz(); }
		public static Vector2 yz(this Color v) { return new Vector2(v.g, v.b); }
		public static Vector2 yz(this Color v, Vector2 other) { v.g = (float)other.r();v.b = (float)other.g(); return v.yz(); }
		public static Vector2 zz(this Color v) { return new Vector2(v.b, v.b); }
		public static Vector2 wz(this Color v) { return new Vector2(v.a, v.b); }
		public static Vector2 wz(this Color v, Vector2 other) { v.a = (float)other.r();v.b = (float)other.g(); return v.wz(); }
		public static Vector2 xw(this Color v) { return new Vector2(v.r, v.a); }
		public static Vector2 xw(this Color v, Vector2 other) { v.r = (float)other.r();v.a = (float)other.g(); return v.xw(); }
		public static Vector2 yw(this Color v) { return new Vector2(v.g, v.a); }
		public static Vector2 yw(this Color v, Vector2 other) { v.g = (float)other.r();v.a = (float)other.g(); return v.yw(); }
		public static Vector2 zw(this Color v) { return new Vector2(v.b, v.a); }
		public static Vector2 zw(this Color v, Vector2 other) { v.b = (float)other.r();v.a = (float)other.g(); return v.zw(); }
		public static Vector2 ww(this Color v) { return new Vector2(v.a, v.a); }

		// Color with 3 components.
		public static Vector3 xxx(this Color v) { return new Vector3(v.r, v.r, v.r); }
		public static Vector3 yxx(this Color v) { return new Vector3(v.g, v.r, v.r); }
		public static Vector3 zxx(this Color v) { return new Vector3(v.b, v.r, v.r); }
		public static Vector3 wxx(this Color v) { return new Vector3(v.a, v.r, v.r); }
		public static Vector3 xyx(this Color v) { return new Vector3(v.r, v.g, v.r); }
		public static Vector3 yyx(this Color v) { return new Vector3(v.g, v.g, v.r); }
		public static Vector3 zyx(this Color v) { return new Vector3(v.b, v.g, v.r); }
		public static Vector3 zyx(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.zyx(); }
		public static Vector3 wyx(this Color v) { return new Vector3(v.a, v.g, v.r); }
		public static Vector3 wyx(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.wyx(); }
		public static Vector3 xzx(this Color v) { return new Vector3(v.r, v.b, v.r); }
		public static Vector3 yzx(this Color v) { return new Vector3(v.g, v.b, v.r); }
		public static Vector3 yzx(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.yzx(); }
		public static Vector3 zzx(this Color v) { return new Vector3(v.b, v.b, v.r); }
		public static Vector3 wzx(this Color v) { return new Vector3(v.a, v.b, v.r); }
		public static Vector3 wzx(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.wzx(); }
		public static Vector3 xwx(this Color v) { return new Vector3(v.r, v.a, v.r); }
		public static Vector3 ywx(this Color v) { return new Vector3(v.g, v.a, v.r); }
		public static Vector3 ywx(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.ywx(); }
		public static Vector3 zwx(this Color v) { return new Vector3(v.b, v.a, v.r); }
		public static Vector3 zwx(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.zwx(); }
		public static Vector3 wwx(this Color v) { return new Vector3(v.a, v.a, v.r); }
		public static Vector3 xxy(this Color v) { return new Vector3(v.r, v.r, v.g); }
		public static Vector3 yxy(this Color v) { return new Vector3(v.g, v.r, v.g); }
		public static Vector3 zxy(this Color v) { return new Vector3(v.b, v.r, v.g); }
		public static Vector3 zxy(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.zxy(); }
		public static Vector3 wxy(this Color v) { return new Vector3(v.a, v.r, v.g); }
		public static Vector3 wxy(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.wxy(); }
		public static Vector3 xyy(this Color v) { return new Vector3(v.r, v.g, v.g); }
		public static Vector3 yyy(this Color v) { return new Vector3(v.g, v.g, v.g); }
		public static Vector3 zyy(this Color v) { return new Vector3(v.b, v.g, v.g); }
		public static Vector3 wyy(this Color v) { return new Vector3(v.a, v.g, v.g); }
		public static Vector3 xzy(this Color v) { return new Vector3(v.r, v.b, v.g); }
		public static Vector3 xzy(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.xzy(); }
		public static Vector3 yzy(this Color v) { return new Vector3(v.g, v.b, v.g); }
		public static Vector3 zzy(this Color v) { return new Vector3(v.b, v.b, v.g); }
		public static Vector3 wzy(this Color v) { return new Vector3(v.a, v.b, v.g); }
		public static Vector3 wzy(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.wzy(); }
		public static Vector3 xwy(this Color v) { return new Vector3(v.r, v.a, v.g); }
		public static Vector3 xwy(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.xwy(); }
		public static Vector3 ywy(this Color v) { return new Vector3(v.g, v.a, v.g); }
		public static Vector3 zwy(this Color v) { return new Vector3(v.b, v.a, v.g); }
		public static Vector3 zwy(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.zwy(); }
		public static Vector3 wwy(this Color v) { return new Vector3(v.a, v.a, v.g); }
		public static Vector3 xxz(this Color v) { return new Vector3(v.r, v.r, v.b); }
		public static Vector3 yxz(this Color v) { return new Vector3(v.g, v.r, v.b); }
		public static Vector3 yxz(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.yxz(); }
		public static Vector3 zxz(this Color v) { return new Vector3(v.b, v.r, v.b); }
		public static Vector3 wxz(this Color v) { return new Vector3(v.a, v.r, v.b); }
		public static Vector3 wxz(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.wxz(); }
		public static Vector3 xyz(this Color v) { return new Vector3(v.r, v.g, v.b); }
		public static Vector3 xyz(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.xyz(); }
		public static Vector3 yyz(this Color v) { return new Vector3(v.g, v.g, v.b); }
		public static Vector3 zyz(this Color v) { return new Vector3(v.b, v.g, v.b); }
		public static Vector3 wyz(this Color v) { return new Vector3(v.a, v.g, v.b); }
		public static Vector3 wyz(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.wyz(); }
		public static Vector3 xzz(this Color v) { return new Vector3(v.r, v.b, v.b); }
		public static Vector3 yzz(this Color v) { return new Vector3(v.g, v.b, v.b); }
		public static Vector3 zzz(this Color v) { return new Vector3(v.b, v.b, v.b); }
		public static Vector3 wzz(this Color v) { return new Vector3(v.a, v.b, v.b); }
		public static Vector3 xwz(this Color v) { return new Vector3(v.r, v.a, v.b); }
		public static Vector3 xwz(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.xwz(); }
		public static Vector3 ywz(this Color v) { return new Vector3(v.g, v.a, v.b); }
		public static Vector3 ywz(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.ywz(); }
		public static Vector3 zwz(this Color v) { return new Vector3(v.b, v.a, v.b); }
		public static Vector3 wwz(this Color v) { return new Vector3(v.a, v.a, v.b); }
		public static Vector3 xxw(this Color v) { return new Vector3(v.r, v.r, v.a); }
		public static Vector3 yxw(this Color v) { return new Vector3(v.g, v.r, v.a); }
		public static Vector3 yxw(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.yxw(); }
		public static Vector3 zxw(this Color v) { return new Vector3(v.b, v.r, v.a); }
		public static Vector3 zxw(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.zxw(); }
		public static Vector3 wxw(this Color v) { return new Vector3(v.a, v.r, v.a); }
		public static Vector3 xyw(this Color v) { return new Vector3(v.r, v.g, v.a); }
		public static Vector3 xyw(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.xyw(); }
		public static Vector3 yyw(this Color v) { return new Vector3(v.g, v.g, v.a); }
		public static Vector3 zyw(this Color v) { return new Vector3(v.b, v.g, v.a); }
		public static Vector3 zyw(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.zyw(); }
		public static Vector3 wyw(this Color v) { return new Vector3(v.a, v.g, v.a); }
		public static Vector3 xzw(this Color v) { return new Vector3(v.r, v.b, v.a); }
		public static Vector3 xzw(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.xzw(); }
		public static Vector3 yzw(this Color v) { return new Vector3(v.g, v.b, v.a); }
		public static Vector3 yzw(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.yzw(); }
		public static Vector3 zzw(this Color v) { return new Vector3(v.b, v.b, v.a); }
		public static Vector3 wzw(this Color v) { return new Vector3(v.a, v.b, v.a); }
		public static Vector3 xww(this Color v) { return new Vector3(v.r, v.a, v.a); }
		public static Vector3 yww(this Color v) { return new Vector3(v.g, v.a, v.a); }
		public static Vector3 zww(this Color v) { return new Vector3(v.b, v.a, v.a); }
		public static Vector3 www(this Color v) { return new Vector3(v.a, v.a, v.a); }

		// Color with 4 components.
		public static Vector4 xxxx(this Color v) { return new Vector4(v.r, v.r, v.r, v.r); }
		public static Vector4 yxxx(this Color v) { return new Vector4(v.g, v.r, v.r, v.r); }
		public static Vector4 zxxx(this Color v) { return new Vector4(v.b, v.r, v.r, v.r); }
		public static Vector4 wxxx(this Color v) { return new Vector4(v.a, v.r, v.r, v.r); }
		public static Vector4 xyxx(this Color v) { return new Vector4(v.r, v.g, v.r, v.r); }
		public static Vector4 yyxx(this Color v) { return new Vector4(v.g, v.g, v.r, v.r); }
		public static Vector4 zyxx(this Color v) { return new Vector4(v.b, v.g, v.r, v.r); }
		public static Vector4 wyxx(this Color v) { return new Vector4(v.a, v.g, v.r, v.r); }
		public static Vector4 xzxx(this Color v) { return new Vector4(v.r, v.b, v.r, v.r); }
		public static Vector4 yzxx(this Color v) { return new Vector4(v.g, v.b, v.r, v.r); }
		public static Vector4 zzxx(this Color v) { return new Vector4(v.b, v.b, v.r, v.r); }
		public static Vector4 wzxx(this Color v) { return new Vector4(v.a, v.b, v.r, v.r); }
		public static Vector4 xwxx(this Color v) { return new Vector4(v.r, v.a, v.r, v.r); }
		public static Vector4 ywxx(this Color v) { return new Vector4(v.g, v.a, v.r, v.r); }
		public static Vector4 zwxx(this Color v) { return new Vector4(v.b, v.a, v.r, v.r); }
		public static Vector4 wwxx(this Color v) { return new Vector4(v.a, v.a, v.r, v.r); }
		public static Vector4 xxyx(this Color v) { return new Vector4(v.r, v.r, v.g, v.r); }
		public static Vector4 yxyx(this Color v) { return new Vector4(v.g, v.r, v.g, v.r); }
		public static Vector4 zxyx(this Color v) { return new Vector4(v.b, v.r, v.g, v.r); }
		public static Vector4 wxyx(this Color v) { return new Vector4(v.a, v.r, v.g, v.r); }
		public static Vector4 xyyx(this Color v) { return new Vector4(v.r, v.g, v.g, v.r); }
		public static Vector4 yyyx(this Color v) { return new Vector4(v.g, v.g, v.g, v.r); }
		public static Vector4 zyyx(this Color v) { return new Vector4(v.b, v.g, v.g, v.r); }
		public static Vector4 wyyx(this Color v) { return new Vector4(v.a, v.g, v.g, v.r); }
		public static Vector4 xzyx(this Color v) { return new Vector4(v.r, v.b, v.g, v.r); }
		public static Vector4 yzyx(this Color v) { return new Vector4(v.g, v.b, v.g, v.r); }
		public static Vector4 zzyx(this Color v) { return new Vector4(v.b, v.b, v.g, v.r); }
		public static Vector4 wzyx(this Color v) { return new Vector4(v.a, v.b, v.g, v.r); }
		public static Vector4 wzyx(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.wzyx(); }
		public static Vector4 xwyx(this Color v) { return new Vector4(v.r, v.a, v.g, v.r); }
		public static Vector4 ywyx(this Color v) { return new Vector4(v.g, v.a, v.g, v.r); }
		public static Vector4 zwyx(this Color v) { return new Vector4(v.b, v.a, v.g, v.r); }
		public static Vector4 zwyx(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.zwyx(); }
		public static Vector4 wwyx(this Color v) { return new Vector4(v.a, v.a, v.g, v.r); }
		public static Vector4 xxzx(this Color v) { return new Vector4(v.r, v.r, v.b, v.r); }
		public static Vector4 yxzx(this Color v) { return new Vector4(v.g, v.r, v.b, v.r); }
		public static Vector4 zxzx(this Color v) { return new Vector4(v.b, v.r, v.b, v.r); }
		public static Vector4 wxzx(this Color v) { return new Vector4(v.a, v.r, v.b, v.r); }
		public static Vector4 xyzx(this Color v) { return new Vector4(v.r, v.g, v.b, v.r); }
		public static Vector4 yyzx(this Color v) { return new Vector4(v.g, v.g, v.b, v.r); }
		public static Vector4 zyzx(this Color v) { return new Vector4(v.b, v.g, v.b, v.r); }
		public static Vector4 wyzx(this Color v) { return new Vector4(v.a, v.g, v.b, v.r); }
		public static Vector4 wyzx(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.wyzx(); }
		public static Vector4 xzzx(this Color v) { return new Vector4(v.r, v.b, v.b, v.r); }
		public static Vector4 yzzx(this Color v) { return new Vector4(v.g, v.b, v.b, v.r); }
		public static Vector4 zzzx(this Color v) { return new Vector4(v.b, v.b, v.b, v.r); }
		public static Vector4 wzzx(this Color v) { return new Vector4(v.a, v.b, v.b, v.r); }
		public static Vector4 xwzx(this Color v) { return new Vector4(v.r, v.a, v.b, v.r); }
		public static Vector4 ywzx(this Color v) { return new Vector4(v.g, v.a, v.b, v.r); }
		public static Vector4 ywzx(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.ywzx(); }
		public static Vector4 zwzx(this Color v) { return new Vector4(v.b, v.a, v.b, v.r); }
		public static Vector4 wwzx(this Color v) { return new Vector4(v.a, v.a, v.b, v.r); }
		public static Vector4 xxwx(this Color v) { return new Vector4(v.r, v.r, v.a, v.r); }
		public static Vector4 yxwx(this Color v) { return new Vector4(v.g, v.r, v.a, v.r); }
		public static Vector4 zxwx(this Color v) { return new Vector4(v.b, v.r, v.a, v.r); }
		public static Vector4 wxwx(this Color v) { return new Vector4(v.a, v.r, v.a, v.r); }
		public static Vector4 xywx(this Color v) { return new Vector4(v.r, v.g, v.a, v.r); }
		public static Vector4 yywx(this Color v) { return new Vector4(v.g, v.g, v.a, v.r); }
		public static Vector4 zywx(this Color v) { return new Vector4(v.b, v.g, v.a, v.r); }
		public static Vector4 zywx(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.zywx(); }
		public static Vector4 wywx(this Color v) { return new Vector4(v.a, v.g, v.a, v.r); }
		public static Vector4 xzwx(this Color v) { return new Vector4(v.r, v.b, v.a, v.r); }
		public static Vector4 yzwx(this Color v) { return new Vector4(v.g, v.b, v.a, v.r); }
		public static Vector4 yzwx(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.yzwx(); }
		public static Vector4 zzwx(this Color v) { return new Vector4(v.b, v.b, v.a, v.r); }
		public static Vector4 wzwx(this Color v) { return new Vector4(v.a, v.b, v.a, v.r); }
		public static Vector4 xwwx(this Color v) { return new Vector4(v.r, v.a, v.a, v.r); }
		public static Vector4 ywwx(this Color v) { return new Vector4(v.g, v.a, v.a, v.r); }
		public static Vector4 zwwx(this Color v) { return new Vector4(v.b, v.a, v.a, v.r); }
		public static Vector4 wwwx(this Color v) { return new Vector4(v.a, v.a, v.a, v.r); }
		public static Vector4 xxxy(this Color v) { return new Vector4(v.r, v.r, v.r, v.g); }
		public static Vector4 yxxy(this Color v) { return new Vector4(v.g, v.r, v.r, v.g); }
		public static Vector4 zxxy(this Color v) { return new Vector4(v.b, v.r, v.r, v.g); }
		public static Vector4 wxxy(this Color v) { return new Vector4(v.a, v.r, v.r, v.g); }
		public static Vector4 xyxy(this Color v) { return new Vector4(v.r, v.g, v.r, v.g); }
		public static Vector4 yyxy(this Color v) { return new Vector4(v.g, v.g, v.r, v.g); }
		public static Vector4 zyxy(this Color v) { return new Vector4(v.b, v.g, v.r, v.g); }
		public static Vector4 wyxy(this Color v) { return new Vector4(v.a, v.g, v.r, v.g); }
		public static Vector4 xzxy(this Color v) { return new Vector4(v.r, v.b, v.r, v.g); }
		public static Vector4 yzxy(this Color v) { return new Vector4(v.g, v.b, v.r, v.g); }
		public static Vector4 zzxy(this Color v) { return new Vector4(v.b, v.b, v.r, v.g); }
		public static Vector4 wzxy(this Color v) { return new Vector4(v.a, v.b, v.r, v.g); }
		public static Vector4 wzxy(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.wzxy(); }
		public static Vector4 xwxy(this Color v) { return new Vector4(v.r, v.a, v.r, v.g); }
		public static Vector4 ywxy(this Color v) { return new Vector4(v.g, v.a, v.r, v.g); }
		public static Vector4 zwxy(this Color v) { return new Vector4(v.b, v.a, v.r, v.g); }
		public static Vector4 zwxy(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.zwxy(); }
		public static Vector4 wwxy(this Color v) { return new Vector4(v.a, v.a, v.r, v.g); }
		public static Vector4 xxyy(this Color v) { return new Vector4(v.r, v.r, v.g, v.g); }
		public static Vector4 yxyy(this Color v) { return new Vector4(v.g, v.r, v.g, v.g); }
		public static Vector4 zxyy(this Color v) { return new Vector4(v.b, v.r, v.g, v.g); }
		public static Vector4 wxyy(this Color v) { return new Vector4(v.a, v.r, v.g, v.g); }
		public static Vector4 xyyy(this Color v) { return new Vector4(v.r, v.g, v.g, v.g); }
		public static Vector4 yyyy(this Color v) { return new Vector4(v.g, v.g, v.g, v.g); }
		public static Vector4 zyyy(this Color v) { return new Vector4(v.b, v.g, v.g, v.g); }
		public static Vector4 wyyy(this Color v) { return new Vector4(v.a, v.g, v.g, v.g); }
		public static Vector4 xzyy(this Color v) { return new Vector4(v.r, v.b, v.g, v.g); }
		public static Vector4 yzyy(this Color v) { return new Vector4(v.g, v.b, v.g, v.g); }
		public static Vector4 zzyy(this Color v) { return new Vector4(v.b, v.b, v.g, v.g); }
		public static Vector4 wzyy(this Color v) { return new Vector4(v.a, v.b, v.g, v.g); }
		public static Vector4 xwyy(this Color v) { return new Vector4(v.r, v.a, v.g, v.g); }
		public static Vector4 ywyy(this Color v) { return new Vector4(v.g, v.a, v.g, v.g); }
		public static Vector4 zwyy(this Color v) { return new Vector4(v.b, v.a, v.g, v.g); }
		public static Vector4 wwyy(this Color v) { return new Vector4(v.a, v.a, v.g, v.g); }
		public static Vector4 xxzy(this Color v) { return new Vector4(v.r, v.r, v.b, v.g); }
		public static Vector4 yxzy(this Color v) { return new Vector4(v.g, v.r, v.b, v.g); }
		public static Vector4 zxzy(this Color v) { return new Vector4(v.b, v.r, v.b, v.g); }
		public static Vector4 wxzy(this Color v) { return new Vector4(v.a, v.r, v.b, v.g); }
		public static Vector4 wxzy(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.wxzy(); }
		public static Vector4 xyzy(this Color v) { return new Vector4(v.r, v.g, v.b, v.g); }
		public static Vector4 yyzy(this Color v) { return new Vector4(v.g, v.g, v.b, v.g); }
		public static Vector4 zyzy(this Color v) { return new Vector4(v.b, v.g, v.b, v.g); }
		public static Vector4 wyzy(this Color v) { return new Vector4(v.a, v.g, v.b, v.g); }
		public static Vector4 xzzy(this Color v) { return new Vector4(v.r, v.b, v.b, v.g); }
		public static Vector4 yzzy(this Color v) { return new Vector4(v.g, v.b, v.b, v.g); }
		public static Vector4 zzzy(this Color v) { return new Vector4(v.b, v.b, v.b, v.g); }
		public static Vector4 wzzy(this Color v) { return new Vector4(v.a, v.b, v.b, v.g); }
		public static Vector4 xwzy(this Color v) { return new Vector4(v.r, v.a, v.b, v.g); }
		public static Vector4 xwzy(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.xwzy(); }
		public static Vector4 ywzy(this Color v) { return new Vector4(v.g, v.a, v.b, v.g); }
		public static Vector4 zwzy(this Color v) { return new Vector4(v.b, v.a, v.b, v.g); }
		public static Vector4 wwzy(this Color v) { return new Vector4(v.a, v.a, v.b, v.g); }
		public static Vector4 xxwy(this Color v) { return new Vector4(v.r, v.r, v.a, v.g); }
		public static Vector4 yxwy(this Color v) { return new Vector4(v.g, v.r, v.a, v.g); }
		public static Vector4 zxwy(this Color v) { return new Vector4(v.b, v.r, v.a, v.g); }
		public static Vector4 zxwy(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.zxwy(); }
		public static Vector4 wxwy(this Color v) { return new Vector4(v.a, v.r, v.a, v.g); }
		public static Vector4 xywy(this Color v) { return new Vector4(v.r, v.g, v.a, v.g); }
		public static Vector4 yywy(this Color v) { return new Vector4(v.g, v.g, v.a, v.g); }
		public static Vector4 zywy(this Color v) { return new Vector4(v.b, v.g, v.a, v.g); }
		public static Vector4 wywy(this Color v) { return new Vector4(v.a, v.g, v.a, v.g); }
		public static Vector4 xzwy(this Color v) { return new Vector4(v.r, v.b, v.a, v.g); }
		public static Vector4 xzwy(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.xzwy(); }
		public static Vector4 yzwy(this Color v) { return new Vector4(v.g, v.b, v.a, v.g); }
		public static Vector4 zzwy(this Color v) { return new Vector4(v.b, v.b, v.a, v.g); }
		public static Vector4 wzwy(this Color v) { return new Vector4(v.a, v.b, v.a, v.g); }
		public static Vector4 xwwy(this Color v) { return new Vector4(v.r, v.a, v.a, v.g); }
		public static Vector4 ywwy(this Color v) { return new Vector4(v.g, v.a, v.a, v.g); }
		public static Vector4 zwwy(this Color v) { return new Vector4(v.b, v.a, v.a, v.g); }
		public static Vector4 wwwy(this Color v) { return new Vector4(v.a, v.a, v.a, v.g); }
		public static Vector4 xxxz(this Color v) { return new Vector4(v.r, v.r, v.r, v.b); }
		public static Vector4 yxxz(this Color v) { return new Vector4(v.g, v.r, v.r, v.b); }
		public static Vector4 zxxz(this Color v) { return new Vector4(v.b, v.r, v.r, v.b); }
		public static Vector4 wxxz(this Color v) { return new Vector4(v.a, v.r, v.r, v.b); }
		public static Vector4 xyxz(this Color v) { return new Vector4(v.r, v.g, v.r, v.b); }
		public static Vector4 yyxz(this Color v) { return new Vector4(v.g, v.g, v.r, v.b); }
		public static Vector4 zyxz(this Color v) { return new Vector4(v.b, v.g, v.r, v.b); }
		public static Vector4 wyxz(this Color v) { return new Vector4(v.a, v.g, v.r, v.b); }
		public static Vector4 wyxz(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.wyxz(); }
		public static Vector4 xzxz(this Color v) { return new Vector4(v.r, v.b, v.r, v.b); }
		public static Vector4 yzxz(this Color v) { return new Vector4(v.g, v.b, v.r, v.b); }
		public static Vector4 zzxz(this Color v) { return new Vector4(v.b, v.b, v.r, v.b); }
		public static Vector4 wzxz(this Color v) { return new Vector4(v.a, v.b, v.r, v.b); }
		public static Vector4 xwxz(this Color v) { return new Vector4(v.r, v.a, v.r, v.b); }
		public static Vector4 ywxz(this Color v) { return new Vector4(v.g, v.a, v.r, v.b); }
		public static Vector4 ywxz(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.ywxz(); }
		public static Vector4 zwxz(this Color v) { return new Vector4(v.b, v.a, v.r, v.b); }
		public static Vector4 wwxz(this Color v) { return new Vector4(v.a, v.a, v.r, v.b); }
		public static Vector4 xxyz(this Color v) { return new Vector4(v.r, v.r, v.g, v.b); }
		public static Vector4 yxyz(this Color v) { return new Vector4(v.g, v.r, v.g, v.b); }
		public static Vector4 zxyz(this Color v) { return new Vector4(v.b, v.r, v.g, v.b); }
		public static Vector4 wxyz(this Color v) { return new Vector4(v.a, v.r, v.g, v.b); }
		public static Vector4 wxyz(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.wxyz(); }
		public static Vector4 xyyz(this Color v) { return new Vector4(v.r, v.g, v.g, v.b); }
		public static Vector4 yyyz(this Color v) { return new Vector4(v.g, v.g, v.g, v.b); }
		public static Vector4 zyyz(this Color v) { return new Vector4(v.b, v.g, v.g, v.b); }
		public static Vector4 wyyz(this Color v) { return new Vector4(v.a, v.g, v.g, v.b); }
		public static Vector4 xzyz(this Color v) { return new Vector4(v.r, v.b, v.g, v.b); }
		public static Vector4 yzyz(this Color v) { return new Vector4(v.g, v.b, v.g, v.b); }
		public static Vector4 zzyz(this Color v) { return new Vector4(v.b, v.b, v.g, v.b); }
		public static Vector4 wzyz(this Color v) { return new Vector4(v.a, v.b, v.g, v.b); }
		public static Vector4 xwyz(this Color v) { return new Vector4(v.r, v.a, v.g, v.b); }
		public static Vector4 xwyz(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.xwyz(); }
		public static Vector4 ywyz(this Color v) { return new Vector4(v.g, v.a, v.g, v.b); }
		public static Vector4 zwyz(this Color v) { return new Vector4(v.b, v.a, v.g, v.b); }
		public static Vector4 wwyz(this Color v) { return new Vector4(v.a, v.a, v.g, v.b); }
		public static Vector4 xxzz(this Color v) { return new Vector4(v.r, v.r, v.b, v.b); }
		public static Vector4 yxzz(this Color v) { return new Vector4(v.g, v.r, v.b, v.b); }
		public static Vector4 zxzz(this Color v) { return new Vector4(v.b, v.r, v.b, v.b); }
		public static Vector4 wxzz(this Color v) { return new Vector4(v.a, v.r, v.b, v.b); }
		public static Vector4 xyzz(this Color v) { return new Vector4(v.r, v.g, v.b, v.b); }
		public static Vector4 yyzz(this Color v) { return new Vector4(v.g, v.g, v.b, v.b); }
		public static Vector4 zyzz(this Color v) { return new Vector4(v.b, v.g, v.b, v.b); }
		public static Vector4 wyzz(this Color v) { return new Vector4(v.a, v.g, v.b, v.b); }
		public static Vector4 xzzz(this Color v) { return new Vector4(v.r, v.b, v.b, v.b); }
		public static Vector4 yzzz(this Color v) { return new Vector4(v.g, v.b, v.b, v.b); }
		public static Vector4 zzzz(this Color v) { return new Vector4(v.b, v.b, v.b, v.b); }
		public static Vector4 wzzz(this Color v) { return new Vector4(v.a, v.b, v.b, v.b); }
		public static Vector4 xwzz(this Color v) { return new Vector4(v.r, v.a, v.b, v.b); }
		public static Vector4 ywzz(this Color v) { return new Vector4(v.g, v.a, v.b, v.b); }
		public static Vector4 zwzz(this Color v) { return new Vector4(v.b, v.a, v.b, v.b); }
		public static Vector4 wwzz(this Color v) { return new Vector4(v.a, v.a, v.b, v.b); }
		public static Vector4 xxwz(this Color v) { return new Vector4(v.r, v.r, v.a, v.b); }
		public static Vector4 yxwz(this Color v) { return new Vector4(v.g, v.r, v.a, v.b); }
		public static Vector4 yxwz(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.yxwz(); }
		public static Vector4 zxwz(this Color v) { return new Vector4(v.b, v.r, v.a, v.b); }
		public static Vector4 wxwz(this Color v) { return new Vector4(v.a, v.r, v.a, v.b); }
		public static Vector4 xywz(this Color v) { return new Vector4(v.r, v.g, v.a, v.b); }
		public static Vector4 xywz(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.xywz(); }
		public static Vector4 yywz(this Color v) { return new Vector4(v.g, v.g, v.a, v.b); }
		public static Vector4 zywz(this Color v) { return new Vector4(v.b, v.g, v.a, v.b); }
		public static Vector4 wywz(this Color v) { return new Vector4(v.a, v.g, v.a, v.b); }
		public static Vector4 xzwz(this Color v) { return new Vector4(v.r, v.b, v.a, v.b); }
		public static Vector4 yzwz(this Color v) { return new Vector4(v.g, v.b, v.a, v.b); }
		public static Vector4 zzwz(this Color v) { return new Vector4(v.b, v.b, v.a, v.b); }
		public static Vector4 wzwz(this Color v) { return new Vector4(v.a, v.b, v.a, v.b); }
		public static Vector4 xwwz(this Color v) { return new Vector4(v.r, v.a, v.a, v.b); }
		public static Vector4 ywwz(this Color v) { return new Vector4(v.g, v.a, v.a, v.b); }
		public static Vector4 zwwz(this Color v) { return new Vector4(v.b, v.a, v.a, v.b); }
		public static Vector4 wwwz(this Color v) { return new Vector4(v.a, v.a, v.a, v.b); }
		public static Vector4 xxxw(this Color v) { return new Vector4(v.r, v.r, v.r, v.a); }
		public static Vector4 yxxw(this Color v) { return new Vector4(v.g, v.r, v.r, v.a); }
		public static Vector4 zxxw(this Color v) { return new Vector4(v.b, v.r, v.r, v.a); }
		public static Vector4 wxxw(this Color v) { return new Vector4(v.a, v.r, v.r, v.a); }
		public static Vector4 xyxw(this Color v) { return new Vector4(v.r, v.g, v.r, v.a); }
		public static Vector4 yyxw(this Color v) { return new Vector4(v.g, v.g, v.r, v.a); }
		public static Vector4 zyxw(this Color v) { return new Vector4(v.b, v.g, v.r, v.a); }
		public static Vector4 zyxw(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.zyxw(); }
		public static Vector4 wyxw(this Color v) { return new Vector4(v.a, v.g, v.r, v.a); }
		public static Vector4 xzxw(this Color v) { return new Vector4(v.r, v.b, v.r, v.a); }
		public static Vector4 yzxw(this Color v) { return new Vector4(v.g, v.b, v.r, v.a); }
		public static Vector4 yzxw(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.yzxw(); }
		public static Vector4 zzxw(this Color v) { return new Vector4(v.b, v.b, v.r, v.a); }
		public static Vector4 wzxw(this Color v) { return new Vector4(v.a, v.b, v.r, v.a); }
		public static Vector4 xwxw(this Color v) { return new Vector4(v.r, v.a, v.r, v.a); }
		public static Vector4 ywxw(this Color v) { return new Vector4(v.g, v.a, v.r, v.a); }
		public static Vector4 zwxw(this Color v) { return new Vector4(v.b, v.a, v.r, v.a); }
		public static Vector4 wwxw(this Color v) { return new Vector4(v.a, v.a, v.r, v.a); }
		public static Vector4 xxyw(this Color v) { return new Vector4(v.r, v.r, v.g, v.a); }
		public static Vector4 yxyw(this Color v) { return new Vector4(v.g, v.r, v.g, v.a); }
		public static Vector4 zxyw(this Color v) { return new Vector4(v.b, v.r, v.g, v.a); }
		public static Vector4 zxyw(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.zxyw(); }
		public static Vector4 wxyw(this Color v) { return new Vector4(v.a, v.r, v.g, v.a); }
		public static Vector4 xyyw(this Color v) { return new Vector4(v.r, v.g, v.g, v.a); }
		public static Vector4 yyyw(this Color v) { return new Vector4(v.g, v.g, v.g, v.a); }
		public static Vector4 zyyw(this Color v) { return new Vector4(v.b, v.g, v.g, v.a); }
		public static Vector4 wyyw(this Color v) { return new Vector4(v.a, v.g, v.g, v.a); }
		public static Vector4 xzyw(this Color v) { return new Vector4(v.r, v.b, v.g, v.a); }
		public static Vector4 xzyw(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.xzyw(); }
		public static Vector4 yzyw(this Color v) { return new Vector4(v.g, v.b, v.g, v.a); }
		public static Vector4 zzyw(this Color v) { return new Vector4(v.b, v.b, v.g, v.a); }
		public static Vector4 wzyw(this Color v) { return new Vector4(v.a, v.b, v.g, v.a); }
		public static Vector4 xwyw(this Color v) { return new Vector4(v.r, v.a, v.g, v.a); }
		public static Vector4 ywyw(this Color v) { return new Vector4(v.g, v.a, v.g, v.a); }
		public static Vector4 zwyw(this Color v) { return new Vector4(v.b, v.a, v.g, v.a); }
		public static Vector4 wwyw(this Color v) { return new Vector4(v.a, v.a, v.g, v.a); }
		public static Vector4 xxzw(this Color v) { return new Vector4(v.r, v.r, v.b, v.a); }
		public static Vector4 yxzw(this Color v) { return new Vector4(v.g, v.r, v.b, v.a); }
		public static Vector4 yxzw(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.yxzw(); }
		public static Vector4 zxzw(this Color v) { return new Vector4(v.b, v.r, v.b, v.a); }
		public static Vector4 wxzw(this Color v) { return new Vector4(v.a, v.r, v.b, v.a); }
		public static Vector4 xyzw(this Color v) { return new Vector4(v.r, v.g, v.b, v.a); }
		public static Vector4 xyzw(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.xyzw(); }
		public static Vector4 yyzw(this Color v) { return new Vector4(v.g, v.g, v.b, v.a); }
		public static Vector4 zyzw(this Color v) { return new Vector4(v.b, v.g, v.b, v.a); }
		public static Vector4 wyzw(this Color v) { return new Vector4(v.a, v.g, v.b, v.a); }
		public static Vector4 xzzw(this Color v) { return new Vector4(v.r, v.b, v.b, v.a); }
		public static Vector4 yzzw(this Color v) { return new Vector4(v.g, v.b, v.b, v.a); }
		public static Vector4 zzzw(this Color v) { return new Vector4(v.b, v.b, v.b, v.a); }
		public static Vector4 wzzw(this Color v) { return new Vector4(v.a, v.b, v.b, v.a); }
		public static Vector4 xwzw(this Color v) { return new Vector4(v.r, v.a, v.b, v.a); }
		public static Vector4 ywzw(this Color v) { return new Vector4(v.g, v.a, v.b, v.a); }
		public static Vector4 zwzw(this Color v) { return new Vector4(v.b, v.a, v.b, v.a); }
		public static Vector4 wwzw(this Color v) { return new Vector4(v.a, v.a, v.b, v.a); }
		public static Vector4 xxww(this Color v) { return new Vector4(v.r, v.r, v.a, v.a); }
		public static Vector4 yxww(this Color v) { return new Vector4(v.g, v.r, v.a, v.a); }
		public static Vector4 zxww(this Color v) { return new Vector4(v.b, v.r, v.a, v.a); }
		public static Vector4 wxww(this Color v) { return new Vector4(v.a, v.r, v.a, v.a); }
		public static Vector4 xyww(this Color v) { return new Vector4(v.r, v.g, v.a, v.a); }
		public static Vector4 yyww(this Color v) { return new Vector4(v.g, v.g, v.a, v.a); }
		public static Vector4 zyww(this Color v) { return new Vector4(v.b, v.g, v.a, v.a); }
		public static Vector4 wyww(this Color v) { return new Vector4(v.a, v.g, v.a, v.a); }
		public static Vector4 xzww(this Color v) { return new Vector4(v.r, v.b, v.a, v.a); }
		public static Vector4 yzww(this Color v) { return new Vector4(v.g, v.b, v.a, v.a); }
		public static Vector4 zzww(this Color v) { return new Vector4(v.b, v.b, v.a, v.a); }
		public static Vector4 wzww(this Color v) { return new Vector4(v.a, v.b, v.a, v.a); }
		public static Vector4 xwww(this Color v) { return new Vector4(v.r, v.a, v.a, v.a); }
		public static Vector4 ywww(this Color v) { return new Vector4(v.g, v.a, v.a, v.a); }
		public static Vector4 zwww(this Color v) { return new Vector4(v.b, v.a, v.a, v.a); }
		public static Vector4 wwww(this Color v) { return new Vector4(v.a, v.a, v.a, v.a); }
	}

	public static class ColorrgbaSwizzleExtension
	{
		// Color with 1 components.
		public static float r(this Color v) { return v.r; }
		public static float r(this Color v, float other) { v.r = other; return v.r(); }
		public static float g(this Color v) { return v.g; }
		public static float g(this Color v, float other) { v.g = other; return v.g(); }
		public static float b(this Color v) { return v.b; }
		public static float b(this Color v, float other) { v.b = other; return v.b(); }
		public static float a(this Color v) { return v.a; }
		public static float a(this Color v, float other) { v.a = other; return v.a(); }

		// Color with 2 components.
		public static Vector2 rr(this Color v) { return new Vector2(v.r, v.r); }
		public static Vector2 gr(this Color v) { return new Vector2(v.g, v.r); }
		public static Vector2 gr(this Color v, Vector2 other) { v.g = (float)other.r();v.r = (float)other.g(); return v.gr(); }
		public static Vector2 br(this Color v) { return new Vector2(v.b, v.r); }
		public static Vector2 br(this Color v, Vector2 other) { v.b = (float)other.r();v.r = (float)other.g(); return v.br(); }
		public static Vector2 ar(this Color v) { return new Vector2(v.a, v.r); }
		public static Vector2 ar(this Color v, Vector2 other) { v.a = (float)other.r();v.r = (float)other.g(); return v.ar(); }
		public static Vector2 rg(this Color v) { return new Vector2(v.r, v.g); }
		public static Vector2 rg(this Color v, Vector2 other) { v.r = (float)other.r();v.g = (float)other.g(); return v.rg(); }
		public static Vector2 gg(this Color v) { return new Vector2(v.g, v.g); }
		public static Vector2 bg(this Color v) { return new Vector2(v.b, v.g); }
		public static Vector2 bg(this Color v, Vector2 other) { v.b = (float)other.r();v.g = (float)other.g(); return v.bg(); }
		public static Vector2 ag(this Color v) { return new Vector2(v.a, v.g); }
		public static Vector2 ag(this Color v, Vector2 other) { v.a = (float)other.r();v.g = (float)other.g(); return v.ag(); }
		public static Vector2 rb(this Color v) { return new Vector2(v.r, v.b); }
		public static Vector2 rb(this Color v, Vector2 other) { v.r = (float)other.r();v.b = (float)other.g(); return v.rb(); }
		public static Vector2 gb(this Color v) { return new Vector2(v.g, v.b); }
		public static Vector2 gb(this Color v, Vector2 other) { v.g = (float)other.r();v.b = (float)other.g(); return v.gb(); }
		public static Vector2 bb(this Color v) { return new Vector2(v.b, v.b); }
		public static Vector2 ab(this Color v) { return new Vector2(v.a, v.b); }
		public static Vector2 ab(this Color v, Vector2 other) { v.a = (float)other.r();v.b = (float)other.g(); return v.ab(); }
		public static Vector2 ra(this Color v) { return new Vector2(v.r, v.a); }
		public static Vector2 ra(this Color v, Vector2 other) { v.r = (float)other.r();v.a = (float)other.g(); return v.ra(); }
		public static Vector2 ga(this Color v) { return new Vector2(v.g, v.a); }
		public static Vector2 ga(this Color v, Vector2 other) { v.g = (float)other.r();v.a = (float)other.g(); return v.ga(); }
		public static Vector2 ba(this Color v) { return new Vector2(v.b, v.a); }
		public static Vector2 ba(this Color v, Vector2 other) { v.b = (float)other.r();v.a = (float)other.g(); return v.ba(); }
		public static Vector2 aa(this Color v) { return new Vector2(v.a, v.a); }

		// Color with 3 components.
		public static Vector3 rrr(this Color v) { return new Vector3(v.r, v.r, v.r); }
		public static Vector3 grr(this Color v) { return new Vector3(v.g, v.r, v.r); }
		public static Vector3 brr(this Color v) { return new Vector3(v.b, v.r, v.r); }
		public static Vector3 arr(this Color v) { return new Vector3(v.a, v.r, v.r); }
		public static Vector3 rgr(this Color v) { return new Vector3(v.r, v.g, v.r); }
		public static Vector3 ggr(this Color v) { return new Vector3(v.g, v.g, v.r); }
		public static Vector3 bgr(this Color v) { return new Vector3(v.b, v.g, v.r); }
		public static Vector3 bgr(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.bgr(); }
		public static Vector3 agr(this Color v) { return new Vector3(v.a, v.g, v.r); }
		public static Vector3 agr(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.agr(); }
		public static Vector3 rbr(this Color v) { return new Vector3(v.r, v.b, v.r); }
		public static Vector3 gbr(this Color v) { return new Vector3(v.g, v.b, v.r); }
		public static Vector3 gbr(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.gbr(); }
		public static Vector3 bbr(this Color v) { return new Vector3(v.b, v.b, v.r); }
		public static Vector3 abr(this Color v) { return new Vector3(v.a, v.b, v.r); }
		public static Vector3 abr(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.abr(); }
		public static Vector3 rar(this Color v) { return new Vector3(v.r, v.a, v.r); }
		public static Vector3 gar(this Color v) { return new Vector3(v.g, v.a, v.r); }
		public static Vector3 gar(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.gar(); }
		public static Vector3 bar(this Color v) { return new Vector3(v.b, v.a, v.r); }
		public static Vector3 bar(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.bar(); }
		public static Vector3 aar(this Color v) { return new Vector3(v.a, v.a, v.r); }
		public static Vector3 rrg(this Color v) { return new Vector3(v.r, v.r, v.g); }
		public static Vector3 grg(this Color v) { return new Vector3(v.g, v.r, v.g); }
		public static Vector3 brg(this Color v) { return new Vector3(v.b, v.r, v.g); }
		public static Vector3 brg(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.brg(); }
		public static Vector3 arg(this Color v) { return new Vector3(v.a, v.r, v.g); }
		public static Vector3 arg(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.arg(); }
		public static Vector3 rgg(this Color v) { return new Vector3(v.r, v.g, v.g); }
		public static Vector3 ggg(this Color v) { return new Vector3(v.g, v.g, v.g); }
		public static Vector3 bgg(this Color v) { return new Vector3(v.b, v.g, v.g); }
		public static Vector3 agg(this Color v) { return new Vector3(v.a, v.g, v.g); }
		public static Vector3 rbg(this Color v) { return new Vector3(v.r, v.b, v.g); }
		public static Vector3 rbg(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.rbg(); }
		public static Vector3 gbg(this Color v) { return new Vector3(v.g, v.b, v.g); }
		public static Vector3 bbg(this Color v) { return new Vector3(v.b, v.b, v.g); }
		public static Vector3 abg(this Color v) { return new Vector3(v.a, v.b, v.g); }
		public static Vector3 abg(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.abg(); }
		public static Vector3 rag(this Color v) { return new Vector3(v.r, v.a, v.g); }
		public static Vector3 rag(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.rag(); }
		public static Vector3 gag(this Color v) { return new Vector3(v.g, v.a, v.g); }
		public static Vector3 bag(this Color v) { return new Vector3(v.b, v.a, v.g); }
		public static Vector3 bag(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.bag(); }
		public static Vector3 aag(this Color v) { return new Vector3(v.a, v.a, v.g); }
		public static Vector3 rrb(this Color v) { return new Vector3(v.r, v.r, v.b); }
		public static Vector3 grb(this Color v) { return new Vector3(v.g, v.r, v.b); }
		public static Vector3 grb(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.grb(); }
		public static Vector3 brb(this Color v) { return new Vector3(v.b, v.r, v.b); }
		public static Vector3 arb(this Color v) { return new Vector3(v.a, v.r, v.b); }
		public static Vector3 arb(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.arb(); }
		public static Vector3 rgb(this Color v) { return new Vector3(v.r, v.g, v.b); }
		public static Vector3 rgb(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.rgb(); }
		public static Vector3 ggb(this Color v) { return new Vector3(v.g, v.g, v.b); }
		public static Vector3 bgb(this Color v) { return new Vector3(v.b, v.g, v.b); }
		public static Vector3 agb(this Color v) { return new Vector3(v.a, v.g, v.b); }
		public static Vector3 agb(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.agb(); }
		public static Vector3 rbb(this Color v) { return new Vector3(v.r, v.b, v.b); }
		public static Vector3 gbb(this Color v) { return new Vector3(v.g, v.b, v.b); }
		public static Vector3 bbb(this Color v) { return new Vector3(v.b, v.b, v.b); }
		public static Vector3 abb(this Color v) { return new Vector3(v.a, v.b, v.b); }
		public static Vector3 rab(this Color v) { return new Vector3(v.r, v.a, v.b); }
		public static Vector3 rab(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.rab(); }
		public static Vector3 gab(this Color v) { return new Vector3(v.g, v.a, v.b); }
		public static Vector3 gab(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.gab(); }
		public static Vector3 bab(this Color v) { return new Vector3(v.b, v.a, v.b); }
		public static Vector3 aab(this Color v) { return new Vector3(v.a, v.a, v.b); }
		public static Vector3 rra(this Color v) { return new Vector3(v.r, v.r, v.a); }
		public static Vector3 gra(this Color v) { return new Vector3(v.g, v.r, v.a); }
		public static Vector3 gra(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.gra(); }
		public static Vector3 bra(this Color v) { return new Vector3(v.b, v.r, v.a); }
		public static Vector3 bra(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.bra(); }
		public static Vector3 ara(this Color v) { return new Vector3(v.a, v.r, v.a); }
		public static Vector3 rga(this Color v) { return new Vector3(v.r, v.g, v.a); }
		public static Vector3 rga(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.rga(); }
		public static Vector3 gga(this Color v) { return new Vector3(v.g, v.g, v.a); }
		public static Vector3 bga(this Color v) { return new Vector3(v.b, v.g, v.a); }
		public static Vector3 bga(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.bga(); }
		public static Vector3 aga(this Color v) { return new Vector3(v.a, v.g, v.a); }
		public static Vector3 rba(this Color v) { return new Vector3(v.r, v.b, v.a); }
		public static Vector3 rba(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.rba(); }
		public static Vector3 gba(this Color v) { return new Vector3(v.g, v.b, v.a); }
		public static Vector3 gba(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.gba(); }
		public static Vector3 bba(this Color v) { return new Vector3(v.b, v.b, v.a); }
		public static Vector3 aba(this Color v) { return new Vector3(v.a, v.b, v.a); }
		public static Vector3 raa(this Color v) { return new Vector3(v.r, v.a, v.a); }
		public static Vector3 gaa(this Color v) { return new Vector3(v.g, v.a, v.a); }
		public static Vector3 baa(this Color v) { return new Vector3(v.b, v.a, v.a); }
		public static Vector3 aaa(this Color v) { return new Vector3(v.a, v.a, v.a); }

		// Color with 4 components.
		public static Vector4 rrrr(this Color v) { return new Vector4(v.r, v.r, v.r, v.r); }
		public static Vector4 grrr(this Color v) { return new Vector4(v.g, v.r, v.r, v.r); }
		public static Vector4 brrr(this Color v) { return new Vector4(v.b, v.r, v.r, v.r); }
		public static Vector4 arrr(this Color v) { return new Vector4(v.a, v.r, v.r, v.r); }
		public static Vector4 rgrr(this Color v) { return new Vector4(v.r, v.g, v.r, v.r); }
		public static Vector4 ggrr(this Color v) { return new Vector4(v.g, v.g, v.r, v.r); }
		public static Vector4 bgrr(this Color v) { return new Vector4(v.b, v.g, v.r, v.r); }
		public static Vector4 agrr(this Color v) { return new Vector4(v.a, v.g, v.r, v.r); }
		public static Vector4 rbrr(this Color v) { return new Vector4(v.r, v.b, v.r, v.r); }
		public static Vector4 gbrr(this Color v) { return new Vector4(v.g, v.b, v.r, v.r); }
		public static Vector4 bbrr(this Color v) { return new Vector4(v.b, v.b, v.r, v.r); }
		public static Vector4 abrr(this Color v) { return new Vector4(v.a, v.b, v.r, v.r); }
		public static Vector4 rarr(this Color v) { return new Vector4(v.r, v.a, v.r, v.r); }
		public static Vector4 garr(this Color v) { return new Vector4(v.g, v.a, v.r, v.r); }
		public static Vector4 barr(this Color v) { return new Vector4(v.b, v.a, v.r, v.r); }
		public static Vector4 aarr(this Color v) { return new Vector4(v.a, v.a, v.r, v.r); }
		public static Vector4 rrgr(this Color v) { return new Vector4(v.r, v.r, v.g, v.r); }
		public static Vector4 grgr(this Color v) { return new Vector4(v.g, v.r, v.g, v.r); }
		public static Vector4 brgr(this Color v) { return new Vector4(v.b, v.r, v.g, v.r); }
		public static Vector4 argr(this Color v) { return new Vector4(v.a, v.r, v.g, v.r); }
		public static Vector4 rggr(this Color v) { return new Vector4(v.r, v.g, v.g, v.r); }
		public static Vector4 gggr(this Color v) { return new Vector4(v.g, v.g, v.g, v.r); }
		public static Vector4 bggr(this Color v) { return new Vector4(v.b, v.g, v.g, v.r); }
		public static Vector4 aggr(this Color v) { return new Vector4(v.a, v.g, v.g, v.r); }
		public static Vector4 rbgr(this Color v) { return new Vector4(v.r, v.b, v.g, v.r); }
		public static Vector4 gbgr(this Color v) { return new Vector4(v.g, v.b, v.g, v.r); }
		public static Vector4 bbgr(this Color v) { return new Vector4(v.b, v.b, v.g, v.r); }
		public static Vector4 abgr(this Color v) { return new Vector4(v.a, v.b, v.g, v.r); }
		public static Vector4 abgr(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.abgr(); }
		public static Vector4 ragr(this Color v) { return new Vector4(v.r, v.a, v.g, v.r); }
		public static Vector4 gagr(this Color v) { return new Vector4(v.g, v.a, v.g, v.r); }
		public static Vector4 bagr(this Color v) { return new Vector4(v.b, v.a, v.g, v.r); }
		public static Vector4 bagr(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.bagr(); }
		public static Vector4 aagr(this Color v) { return new Vector4(v.a, v.a, v.g, v.r); }
		public static Vector4 rrbr(this Color v) { return new Vector4(v.r, v.r, v.b, v.r); }
		public static Vector4 grbr(this Color v) { return new Vector4(v.g, v.r, v.b, v.r); }
		public static Vector4 brbr(this Color v) { return new Vector4(v.b, v.r, v.b, v.r); }
		public static Vector4 arbr(this Color v) { return new Vector4(v.a, v.r, v.b, v.r); }
		public static Vector4 rgbr(this Color v) { return new Vector4(v.r, v.g, v.b, v.r); }
		public static Vector4 ggbr(this Color v) { return new Vector4(v.g, v.g, v.b, v.r); }
		public static Vector4 bgbr(this Color v) { return new Vector4(v.b, v.g, v.b, v.r); }
		public static Vector4 agbr(this Color v) { return new Vector4(v.a, v.g, v.b, v.r); }
		public static Vector4 agbr(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.agbr(); }
		public static Vector4 rbbr(this Color v) { return new Vector4(v.r, v.b, v.b, v.r); }
		public static Vector4 gbbr(this Color v) { return new Vector4(v.g, v.b, v.b, v.r); }
		public static Vector4 bbbr(this Color v) { return new Vector4(v.b, v.b, v.b, v.r); }
		public static Vector4 abbr(this Color v) { return new Vector4(v.a, v.b, v.b, v.r); }
		public static Vector4 rabr(this Color v) { return new Vector4(v.r, v.a, v.b, v.r); }
		public static Vector4 gabr(this Color v) { return new Vector4(v.g, v.a, v.b, v.r); }
		public static Vector4 gabr(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.gabr(); }
		public static Vector4 babr(this Color v) { return new Vector4(v.b, v.a, v.b, v.r); }
		public static Vector4 aabr(this Color v) { return new Vector4(v.a, v.a, v.b, v.r); }
		public static Vector4 rrar(this Color v) { return new Vector4(v.r, v.r, v.a, v.r); }
		public static Vector4 grar(this Color v) { return new Vector4(v.g, v.r, v.a, v.r); }
		public static Vector4 brar(this Color v) { return new Vector4(v.b, v.r, v.a, v.r); }
		public static Vector4 arar(this Color v) { return new Vector4(v.a, v.r, v.a, v.r); }
		public static Vector4 rgar(this Color v) { return new Vector4(v.r, v.g, v.a, v.r); }
		public static Vector4 ggar(this Color v) { return new Vector4(v.g, v.g, v.a, v.r); }
		public static Vector4 bgar(this Color v) { return new Vector4(v.b, v.g, v.a, v.r); }
		public static Vector4 bgar(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.bgar(); }
		public static Vector4 agar(this Color v) { return new Vector4(v.a, v.g, v.a, v.r); }
		public static Vector4 rbar(this Color v) { return new Vector4(v.r, v.b, v.a, v.r); }
		public static Vector4 gbar(this Color v) { return new Vector4(v.g, v.b, v.a, v.r); }
		public static Vector4 gbar(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.gbar(); }
		public static Vector4 bbar(this Color v) { return new Vector4(v.b, v.b, v.a, v.r); }
		public static Vector4 abar(this Color v) { return new Vector4(v.a, v.b, v.a, v.r); }
		public static Vector4 raar(this Color v) { return new Vector4(v.r, v.a, v.a, v.r); }
		public static Vector4 gaar(this Color v) { return new Vector4(v.g, v.a, v.a, v.r); }
		public static Vector4 baar(this Color v) { return new Vector4(v.b, v.a, v.a, v.r); }
		public static Vector4 aaar(this Color v) { return new Vector4(v.a, v.a, v.a, v.r); }
		public static Vector4 rrrg(this Color v) { return new Vector4(v.r, v.r, v.r, v.g); }
		public static Vector4 grrg(this Color v) { return new Vector4(v.g, v.r, v.r, v.g); }
		public static Vector4 brrg(this Color v) { return new Vector4(v.b, v.r, v.r, v.g); }
		public static Vector4 arrg(this Color v) { return new Vector4(v.a, v.r, v.r, v.g); }
		public static Vector4 rgrg(this Color v) { return new Vector4(v.r, v.g, v.r, v.g); }
		public static Vector4 ggrg(this Color v) { return new Vector4(v.g, v.g, v.r, v.g); }
		public static Vector4 bgrg(this Color v) { return new Vector4(v.b, v.g, v.r, v.g); }
		public static Vector4 agrg(this Color v) { return new Vector4(v.a, v.g, v.r, v.g); }
		public static Vector4 rbrg(this Color v) { return new Vector4(v.r, v.b, v.r, v.g); }
		public static Vector4 gbrg(this Color v) { return new Vector4(v.g, v.b, v.r, v.g); }
		public static Vector4 bbrg(this Color v) { return new Vector4(v.b, v.b, v.r, v.g); }
		public static Vector4 abrg(this Color v) { return new Vector4(v.a, v.b, v.r, v.g); }
		public static Vector4 abrg(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.abrg(); }
		public static Vector4 rarg(this Color v) { return new Vector4(v.r, v.a, v.r, v.g); }
		public static Vector4 garg(this Color v) { return new Vector4(v.g, v.a, v.r, v.g); }
		public static Vector4 barg(this Color v) { return new Vector4(v.b, v.a, v.r, v.g); }
		public static Vector4 barg(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.barg(); }
		public static Vector4 aarg(this Color v) { return new Vector4(v.a, v.a, v.r, v.g); }
		public static Vector4 rrgg(this Color v) { return new Vector4(v.r, v.r, v.g, v.g); }
		public static Vector4 grgg(this Color v) { return new Vector4(v.g, v.r, v.g, v.g); }
		public static Vector4 brgg(this Color v) { return new Vector4(v.b, v.r, v.g, v.g); }
		public static Vector4 argg(this Color v) { return new Vector4(v.a, v.r, v.g, v.g); }
		public static Vector4 rggg(this Color v) { return new Vector4(v.r, v.g, v.g, v.g); }
		public static Vector4 gggg(this Color v) { return new Vector4(v.g, v.g, v.g, v.g); }
		public static Vector4 bggg(this Color v) { return new Vector4(v.b, v.g, v.g, v.g); }
		public static Vector4 aggg(this Color v) { return new Vector4(v.a, v.g, v.g, v.g); }
		public static Vector4 rbgg(this Color v) { return new Vector4(v.r, v.b, v.g, v.g); }
		public static Vector4 gbgg(this Color v) { return new Vector4(v.g, v.b, v.g, v.g); }
		public static Vector4 bbgg(this Color v) { return new Vector4(v.b, v.b, v.g, v.g); }
		public static Vector4 abgg(this Color v) { return new Vector4(v.a, v.b, v.g, v.g); }
		public static Vector4 ragg(this Color v) { return new Vector4(v.r, v.a, v.g, v.g); }
		public static Vector4 gagg(this Color v) { return new Vector4(v.g, v.a, v.g, v.g); }
		public static Vector4 bagg(this Color v) { return new Vector4(v.b, v.a, v.g, v.g); }
		public static Vector4 aagg(this Color v) { return new Vector4(v.a, v.a, v.g, v.g); }
		public static Vector4 rrbg(this Color v) { return new Vector4(v.r, v.r, v.b, v.g); }
		public static Vector4 grbg(this Color v) { return new Vector4(v.g, v.r, v.b, v.g); }
		public static Vector4 brbg(this Color v) { return new Vector4(v.b, v.r, v.b, v.g); }
		public static Vector4 arbg(this Color v) { return new Vector4(v.a, v.r, v.b, v.g); }
		public static Vector4 arbg(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.arbg(); }
		public static Vector4 rgbg(this Color v) { return new Vector4(v.r, v.g, v.b, v.g); }
		public static Vector4 ggbg(this Color v) { return new Vector4(v.g, v.g, v.b, v.g); }
		public static Vector4 bgbg(this Color v) { return new Vector4(v.b, v.g, v.b, v.g); }
		public static Vector4 agbg(this Color v) { return new Vector4(v.a, v.g, v.b, v.g); }
		public static Vector4 rbbg(this Color v) { return new Vector4(v.r, v.b, v.b, v.g); }
		public static Vector4 gbbg(this Color v) { return new Vector4(v.g, v.b, v.b, v.g); }
		public static Vector4 bbbg(this Color v) { return new Vector4(v.b, v.b, v.b, v.g); }
		public static Vector4 abbg(this Color v) { return new Vector4(v.a, v.b, v.b, v.g); }
		public static Vector4 rabg(this Color v) { return new Vector4(v.r, v.a, v.b, v.g); }
		public static Vector4 rabg(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.rabg(); }
		public static Vector4 gabg(this Color v) { return new Vector4(v.g, v.a, v.b, v.g); }
		public static Vector4 babg(this Color v) { return new Vector4(v.b, v.a, v.b, v.g); }
		public static Vector4 aabg(this Color v) { return new Vector4(v.a, v.a, v.b, v.g); }
		public static Vector4 rrag(this Color v) { return new Vector4(v.r, v.r, v.a, v.g); }
		public static Vector4 grag(this Color v) { return new Vector4(v.g, v.r, v.a, v.g); }
		public static Vector4 brag(this Color v) { return new Vector4(v.b, v.r, v.a, v.g); }
		public static Vector4 brag(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.brag(); }
		public static Vector4 arag(this Color v) { return new Vector4(v.a, v.r, v.a, v.g); }
		public static Vector4 rgag(this Color v) { return new Vector4(v.r, v.g, v.a, v.g); }
		public static Vector4 ggag(this Color v) { return new Vector4(v.g, v.g, v.a, v.g); }
		public static Vector4 bgag(this Color v) { return new Vector4(v.b, v.g, v.a, v.g); }
		public static Vector4 agag(this Color v) { return new Vector4(v.a, v.g, v.a, v.g); }
		public static Vector4 rbag(this Color v) { return new Vector4(v.r, v.b, v.a, v.g); }
		public static Vector4 rbag(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.rbag(); }
		public static Vector4 gbag(this Color v) { return new Vector4(v.g, v.b, v.a, v.g); }
		public static Vector4 bbag(this Color v) { return new Vector4(v.b, v.b, v.a, v.g); }
		public static Vector4 abag(this Color v) { return new Vector4(v.a, v.b, v.a, v.g); }
		public static Vector4 raag(this Color v) { return new Vector4(v.r, v.a, v.a, v.g); }
		public static Vector4 gaag(this Color v) { return new Vector4(v.g, v.a, v.a, v.g); }
		public static Vector4 baag(this Color v) { return new Vector4(v.b, v.a, v.a, v.g); }
		public static Vector4 aaag(this Color v) { return new Vector4(v.a, v.a, v.a, v.g); }
		public static Vector4 rrrb(this Color v) { return new Vector4(v.r, v.r, v.r, v.b); }
		public static Vector4 grrb(this Color v) { return new Vector4(v.g, v.r, v.r, v.b); }
		public static Vector4 brrb(this Color v) { return new Vector4(v.b, v.r, v.r, v.b); }
		public static Vector4 arrb(this Color v) { return new Vector4(v.a, v.r, v.r, v.b); }
		public static Vector4 rgrb(this Color v) { return new Vector4(v.r, v.g, v.r, v.b); }
		public static Vector4 ggrb(this Color v) { return new Vector4(v.g, v.g, v.r, v.b); }
		public static Vector4 bgrb(this Color v) { return new Vector4(v.b, v.g, v.r, v.b); }
		public static Vector4 agrb(this Color v) { return new Vector4(v.a, v.g, v.r, v.b); }
		public static Vector4 agrb(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.agrb(); }
		public static Vector4 rbrb(this Color v) { return new Vector4(v.r, v.b, v.r, v.b); }
		public static Vector4 gbrb(this Color v) { return new Vector4(v.g, v.b, v.r, v.b); }
		public static Vector4 bbrb(this Color v) { return new Vector4(v.b, v.b, v.r, v.b); }
		public static Vector4 abrb(this Color v) { return new Vector4(v.a, v.b, v.r, v.b); }
		public static Vector4 rarb(this Color v) { return new Vector4(v.r, v.a, v.r, v.b); }
		public static Vector4 garb(this Color v) { return new Vector4(v.g, v.a, v.r, v.b); }
		public static Vector4 garb(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.garb(); }
		public static Vector4 barb(this Color v) { return new Vector4(v.b, v.a, v.r, v.b); }
		public static Vector4 aarb(this Color v) { return new Vector4(v.a, v.a, v.r, v.b); }
		public static Vector4 rrgb(this Color v) { return new Vector4(v.r, v.r, v.g, v.b); }
		public static Vector4 grgb(this Color v) { return new Vector4(v.g, v.r, v.g, v.b); }
		public static Vector4 brgb(this Color v) { return new Vector4(v.b, v.r, v.g, v.b); }
		public static Vector4 argb(this Color v) { return new Vector4(v.a, v.r, v.g, v.b); }
		public static Vector4 argb(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.argb(); }
		public static Vector4 rggb(this Color v) { return new Vector4(v.r, v.g, v.g, v.b); }
		public static Vector4 gggb(this Color v) { return new Vector4(v.g, v.g, v.g, v.b); }
		public static Vector4 bggb(this Color v) { return new Vector4(v.b, v.g, v.g, v.b); }
		public static Vector4 aggb(this Color v) { return new Vector4(v.a, v.g, v.g, v.b); }
		public static Vector4 rbgb(this Color v) { return new Vector4(v.r, v.b, v.g, v.b); }
		public static Vector4 gbgb(this Color v) { return new Vector4(v.g, v.b, v.g, v.b); }
		public static Vector4 bbgb(this Color v) { return new Vector4(v.b, v.b, v.g, v.b); }
		public static Vector4 abgb(this Color v) { return new Vector4(v.a, v.b, v.g, v.b); }
		public static Vector4 ragb(this Color v) { return new Vector4(v.r, v.a, v.g, v.b); }
		public static Vector4 ragb(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.ragb(); }
		public static Vector4 gagb(this Color v) { return new Vector4(v.g, v.a, v.g, v.b); }
		public static Vector4 bagb(this Color v) { return new Vector4(v.b, v.a, v.g, v.b); }
		public static Vector4 aagb(this Color v) { return new Vector4(v.a, v.a, v.g, v.b); }
		public static Vector4 rrbb(this Color v) { return new Vector4(v.r, v.r, v.b, v.b); }
		public static Vector4 grbb(this Color v) { return new Vector4(v.g, v.r, v.b, v.b); }
		public static Vector4 brbb(this Color v) { return new Vector4(v.b, v.r, v.b, v.b); }
		public static Vector4 arbb(this Color v) { return new Vector4(v.a, v.r, v.b, v.b); }
		public static Vector4 rgbb(this Color v) { return new Vector4(v.r, v.g, v.b, v.b); }
		public static Vector4 ggbb(this Color v) { return new Vector4(v.g, v.g, v.b, v.b); }
		public static Vector4 bgbb(this Color v) { return new Vector4(v.b, v.g, v.b, v.b); }
		public static Vector4 agbb(this Color v) { return new Vector4(v.a, v.g, v.b, v.b); }
		public static Vector4 rbbb(this Color v) { return new Vector4(v.r, v.b, v.b, v.b); }
		public static Vector4 gbbb(this Color v) { return new Vector4(v.g, v.b, v.b, v.b); }
		public static Vector4 bbbb(this Color v) { return new Vector4(v.b, v.b, v.b, v.b); }
		public static Vector4 abbb(this Color v) { return new Vector4(v.a, v.b, v.b, v.b); }
		public static Vector4 rabb(this Color v) { return new Vector4(v.r, v.a, v.b, v.b); }
		public static Vector4 gabb(this Color v) { return new Vector4(v.g, v.a, v.b, v.b); }
		public static Vector4 babb(this Color v) { return new Vector4(v.b, v.a, v.b, v.b); }
		public static Vector4 aabb(this Color v) { return new Vector4(v.a, v.a, v.b, v.b); }
		public static Vector4 rrab(this Color v) { return new Vector4(v.r, v.r, v.a, v.b); }
		public static Vector4 grab(this Color v) { return new Vector4(v.g, v.r, v.a, v.b); }
		public static Vector4 grab(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.grab(); }
		public static Vector4 brab(this Color v) { return new Vector4(v.b, v.r, v.a, v.b); }
		public static Vector4 arab(this Color v) { return new Vector4(v.a, v.r, v.a, v.b); }
		public static Vector4 rgab(this Color v) { return new Vector4(v.r, v.g, v.a, v.b); }
		public static Vector4 rgab(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.rgab(); }
		public static Vector4 ggab(this Color v) { return new Vector4(v.g, v.g, v.a, v.b); }
		public static Vector4 bgab(this Color v) { return new Vector4(v.b, v.g, v.a, v.b); }
		public static Vector4 agab(this Color v) { return new Vector4(v.a, v.g, v.a, v.b); }
		public static Vector4 rbab(this Color v) { return new Vector4(v.r, v.b, v.a, v.b); }
		public static Vector4 gbab(this Color v) { return new Vector4(v.g, v.b, v.a, v.b); }
		public static Vector4 bbab(this Color v) { return new Vector4(v.b, v.b, v.a, v.b); }
		public static Vector4 abab(this Color v) { return new Vector4(v.a, v.b, v.a, v.b); }
		public static Vector4 raab(this Color v) { return new Vector4(v.r, v.a, v.a, v.b); }
		public static Vector4 gaab(this Color v) { return new Vector4(v.g, v.a, v.a, v.b); }
		public static Vector4 baab(this Color v) { return new Vector4(v.b, v.a, v.a, v.b); }
		public static Vector4 aaab(this Color v) { return new Vector4(v.a, v.a, v.a, v.b); }
		public static Vector4 rrra(this Color v) { return new Vector4(v.r, v.r, v.r, v.a); }
		public static Vector4 grra(this Color v) { return new Vector4(v.g, v.r, v.r, v.a); }
		public static Vector4 brra(this Color v) { return new Vector4(v.b, v.r, v.r, v.a); }
		public static Vector4 arra(this Color v) { return new Vector4(v.a, v.r, v.r, v.a); }
		public static Vector4 rgra(this Color v) { return new Vector4(v.r, v.g, v.r, v.a); }
		public static Vector4 ggra(this Color v) { return new Vector4(v.g, v.g, v.r, v.a); }
		public static Vector4 bgra(this Color v) { return new Vector4(v.b, v.g, v.r, v.a); }
		public static Vector4 bgra(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.bgra(); }
		public static Vector4 agra(this Color v) { return new Vector4(v.a, v.g, v.r, v.a); }
		public static Vector4 rbra(this Color v) { return new Vector4(v.r, v.b, v.r, v.a); }
		public static Vector4 gbra(this Color v) { return new Vector4(v.g, v.b, v.r, v.a); }
		public static Vector4 gbra(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.gbra(); }
		public static Vector4 bbra(this Color v) { return new Vector4(v.b, v.b, v.r, v.a); }
		public static Vector4 abra(this Color v) { return new Vector4(v.a, v.b, v.r, v.a); }
		public static Vector4 rara(this Color v) { return new Vector4(v.r, v.a, v.r, v.a); }
		public static Vector4 gara(this Color v) { return new Vector4(v.g, v.a, v.r, v.a); }
		public static Vector4 bara(this Color v) { return new Vector4(v.b, v.a, v.r, v.a); }
		public static Vector4 aara(this Color v) { return new Vector4(v.a, v.a, v.r, v.a); }
		public static Vector4 rrga(this Color v) { return new Vector4(v.r, v.r, v.g, v.a); }
		public static Vector4 grga(this Color v) { return new Vector4(v.g, v.r, v.g, v.a); }
		public static Vector4 brga(this Color v) { return new Vector4(v.b, v.r, v.g, v.a); }
		public static Vector4 brga(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.brga(); }
		public static Vector4 arga(this Color v) { return new Vector4(v.a, v.r, v.g, v.a); }
		public static Vector4 rgga(this Color v) { return new Vector4(v.r, v.g, v.g, v.a); }
		public static Vector4 ggga(this Color v) { return new Vector4(v.g, v.g, v.g, v.a); }
		public static Vector4 bgga(this Color v) { return new Vector4(v.b, v.g, v.g, v.a); }
		public static Vector4 agga(this Color v) { return new Vector4(v.a, v.g, v.g, v.a); }
		public static Vector4 rbga(this Color v) { return new Vector4(v.r, v.b, v.g, v.a); }
		public static Vector4 rbga(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.rbga(); }
		public static Vector4 gbga(this Color v) { return new Vector4(v.g, v.b, v.g, v.a); }
		public static Vector4 bbga(this Color v) { return new Vector4(v.b, v.b, v.g, v.a); }
		public static Vector4 abga(this Color v) { return new Vector4(v.a, v.b, v.g, v.a); }
		public static Vector4 raga(this Color v) { return new Vector4(v.r, v.a, v.g, v.a); }
		public static Vector4 gaga(this Color v) { return new Vector4(v.g, v.a, v.g, v.a); }
		public static Vector4 baga(this Color v) { return new Vector4(v.b, v.a, v.g, v.a); }
		public static Vector4 aaga(this Color v) { return new Vector4(v.a, v.a, v.g, v.a); }
		public static Vector4 rrba(this Color v) { return new Vector4(v.r, v.r, v.b, v.a); }
		public static Vector4 grba(this Color v) { return new Vector4(v.g, v.r, v.b, v.a); }
		public static Vector4 grba(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.grba(); }
		public static Vector4 brba(this Color v) { return new Vector4(v.b, v.r, v.b, v.a); }
		public static Vector4 arba(this Color v) { return new Vector4(v.a, v.r, v.b, v.a); }
		public static Vector4 rgba(this Color v) { return new Vector4(v.r, v.g, v.b, v.a); }
		public static Vector4 rgba(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.rgba(); }
		public static Vector4 ggba(this Color v) { return new Vector4(v.g, v.g, v.b, v.a); }
		public static Vector4 bgba(this Color v) { return new Vector4(v.b, v.g, v.b, v.a); }
		public static Vector4 agba(this Color v) { return new Vector4(v.a, v.g, v.b, v.a); }
		public static Vector4 rbba(this Color v) { return new Vector4(v.r, v.b, v.b, v.a); }
		public static Vector4 gbba(this Color v) { return new Vector4(v.g, v.b, v.b, v.a); }
		public static Vector4 bbba(this Color v) { return new Vector4(v.b, v.b, v.b, v.a); }
		public static Vector4 abba(this Color v) { return new Vector4(v.a, v.b, v.b, v.a); }
		public static Vector4 raba(this Color v) { return new Vector4(v.r, v.a, v.b, v.a); }
		public static Vector4 gaba(this Color v) { return new Vector4(v.g, v.a, v.b, v.a); }
		public static Vector4 baba(this Color v) { return new Vector4(v.b, v.a, v.b, v.a); }
		public static Vector4 aaba(this Color v) { return new Vector4(v.a, v.a, v.b, v.a); }
		public static Vector4 rraa(this Color v) { return new Vector4(v.r, v.r, v.a, v.a); }
		public static Vector4 graa(this Color v) { return new Vector4(v.g, v.r, v.a, v.a); }
		public static Vector4 braa(this Color v) { return new Vector4(v.b, v.r, v.a, v.a); }
		public static Vector4 araa(this Color v) { return new Vector4(v.a, v.r, v.a, v.a); }
		public static Vector4 rgaa(this Color v) { return new Vector4(v.r, v.g, v.a, v.a); }
		public static Vector4 ggaa(this Color v) { return new Vector4(v.g, v.g, v.a, v.a); }
		public static Vector4 bgaa(this Color v) { return new Vector4(v.b, v.g, v.a, v.a); }
		public static Vector4 agaa(this Color v) { return new Vector4(v.a, v.g, v.a, v.a); }
		public static Vector4 rbaa(this Color v) { return new Vector4(v.r, v.b, v.a, v.a); }
		public static Vector4 gbaa(this Color v) { return new Vector4(v.g, v.b, v.a, v.a); }
		public static Vector4 bbaa(this Color v) { return new Vector4(v.b, v.b, v.a, v.a); }
		public static Vector4 abaa(this Color v) { return new Vector4(v.a, v.b, v.a, v.a); }
		public static Vector4 raaa(this Color v) { return new Vector4(v.r, v.a, v.a, v.a); }
		public static Vector4 gaaa(this Color v) { return new Vector4(v.g, v.a, v.a, v.a); }
		public static Vector4 baaa(this Color v) { return new Vector4(v.b, v.a, v.a, v.a); }
		public static Vector4 aaaa(this Color v) { return new Vector4(v.a, v.a, v.a, v.a); }
	}

	public static class ColorstpqSwizzleExtension
	{
		// Color with 1 components.
		public static float s(this Color v) { return v.r; }
		public static float s(this Color v, float other) { v.r = other; return v.s(); }
		public static float t(this Color v) { return v.g; }
		public static float t(this Color v, float other) { v.g = other; return v.t(); }
		public static float p(this Color v) { return v.b; }
		public static float p(this Color v, float other) { v.b = other; return v.p(); }
		public static float q(this Color v) { return v.a; }
		public static float q(this Color v, float other) { v.a = other; return v.q(); }

		// Color with 2 components.
		public static Vector2 ss(this Color v) { return new Vector2(v.r, v.r); }
		public static Vector2 ts(this Color v) { return new Vector2(v.g, v.r); }
		public static Vector2 ts(this Color v, Vector2 other) { v.g = (float)other.r();v.r = (float)other.g(); return v.ts(); }
		public static Vector2 ps(this Color v) { return new Vector2(v.b, v.r); }
		public static Vector2 ps(this Color v, Vector2 other) { v.b = (float)other.r();v.r = (float)other.g(); return v.ps(); }
		public static Vector2 qs(this Color v) { return new Vector2(v.a, v.r); }
		public static Vector2 qs(this Color v, Vector2 other) { v.a = (float)other.r();v.r = (float)other.g(); return v.qs(); }
		public static Vector2 st(this Color v) { return new Vector2(v.r, v.g); }
		public static Vector2 st(this Color v, Vector2 other) { v.r = (float)other.r();v.g = (float)other.g(); return v.st(); }
		public static Vector2 tt(this Color v) { return new Vector2(v.g, v.g); }
		public static Vector2 pt(this Color v) { return new Vector2(v.b, v.g); }
		public static Vector2 pt(this Color v, Vector2 other) { v.b = (float)other.r();v.g = (float)other.g(); return v.pt(); }
		public static Vector2 qt(this Color v) { return new Vector2(v.a, v.g); }
		public static Vector2 qt(this Color v, Vector2 other) { v.a = (float)other.r();v.g = (float)other.g(); return v.qt(); }
		public static Vector2 sp(this Color v) { return new Vector2(v.r, v.b); }
		public static Vector2 sp(this Color v, Vector2 other) { v.r = (float)other.r();v.b = (float)other.g(); return v.sp(); }
		public static Vector2 tp(this Color v) { return new Vector2(v.g, v.b); }
		public static Vector2 tp(this Color v, Vector2 other) { v.g = (float)other.r();v.b = (float)other.g(); return v.tp(); }
		public static Vector2 pp(this Color v) { return new Vector2(v.b, v.b); }
		public static Vector2 qp(this Color v) { return new Vector2(v.a, v.b); }
		public static Vector2 qp(this Color v, Vector2 other) { v.a = (float)other.r();v.b = (float)other.g(); return v.qp(); }
		public static Vector2 sq(this Color v) { return new Vector2(v.r, v.a); }
		public static Vector2 sq(this Color v, Vector2 other) { v.r = (float)other.r();v.a = (float)other.g(); return v.sq(); }
		public static Vector2 tq(this Color v) { return new Vector2(v.g, v.a); }
		public static Vector2 tq(this Color v, Vector2 other) { v.g = (float)other.r();v.a = (float)other.g(); return v.tq(); }
		public static Vector2 pq(this Color v) { return new Vector2(v.b, v.a); }
		public static Vector2 pq(this Color v, Vector2 other) { v.b = (float)other.r();v.a = (float)other.g(); return v.pq(); }
		public static Vector2 qq(this Color v) { return new Vector2(v.a, v.a); }

		// Color with 3 components.
		public static Vector3 sss(this Color v) { return new Vector3(v.r, v.r, v.r); }
		public static Vector3 tss(this Color v) { return new Vector3(v.g, v.r, v.r); }
		public static Vector3 pss(this Color v) { return new Vector3(v.b, v.r, v.r); }
		public static Vector3 qss(this Color v) { return new Vector3(v.a, v.r, v.r); }
		public static Vector3 sts(this Color v) { return new Vector3(v.r, v.g, v.r); }
		public static Vector3 tts(this Color v) { return new Vector3(v.g, v.g, v.r); }
		public static Vector3 pts(this Color v) { return new Vector3(v.b, v.g, v.r); }
		public static Vector3 pts(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.pts(); }
		public static Vector3 qts(this Color v) { return new Vector3(v.a, v.g, v.r); }
		public static Vector3 qts(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b(); return v.qts(); }
		public static Vector3 sps(this Color v) { return new Vector3(v.r, v.b, v.r); }
		public static Vector3 tps(this Color v) { return new Vector3(v.g, v.b, v.r); }
		public static Vector3 tps(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.tps(); }
		public static Vector3 pps(this Color v) { return new Vector3(v.b, v.b, v.r); }
		public static Vector3 qps(this Color v) { return new Vector3(v.a, v.b, v.r); }
		public static Vector3 qps(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b(); return v.qps(); }
		public static Vector3 sqs(this Color v) { return new Vector3(v.r, v.a, v.r); }
		public static Vector3 tqs(this Color v) { return new Vector3(v.g, v.a, v.r); }
		public static Vector3 tqs(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.tqs(); }
		public static Vector3 pqs(this Color v) { return new Vector3(v.b, v.a, v.r); }
		public static Vector3 pqs(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b(); return v.pqs(); }
		public static Vector3 qqs(this Color v) { return new Vector3(v.a, v.a, v.r); }
		public static Vector3 sst(this Color v) { return new Vector3(v.r, v.r, v.g); }
		public static Vector3 tst(this Color v) { return new Vector3(v.g, v.r, v.g); }
		public static Vector3 pst(this Color v) { return new Vector3(v.b, v.r, v.g); }
		public static Vector3 pst(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.pst(); }
		public static Vector3 qst(this Color v) { return new Vector3(v.a, v.r, v.g); }
		public static Vector3 qst(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b(); return v.qst(); }
		public static Vector3 stt(this Color v) { return new Vector3(v.r, v.g, v.g); }
		public static Vector3 ttt(this Color v) { return new Vector3(v.g, v.g, v.g); }
		public static Vector3 ptt(this Color v) { return new Vector3(v.b, v.g, v.g); }
		public static Vector3 qtt(this Color v) { return new Vector3(v.a, v.g, v.g); }
		public static Vector3 spt(this Color v) { return new Vector3(v.r, v.b, v.g); }
		public static Vector3 spt(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.spt(); }
		public static Vector3 tpt(this Color v) { return new Vector3(v.g, v.b, v.g); }
		public static Vector3 ppt(this Color v) { return new Vector3(v.b, v.b, v.g); }
		public static Vector3 qpt(this Color v) { return new Vector3(v.a, v.b, v.g); }
		public static Vector3 qpt(this Color v, Vector3 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b(); return v.qpt(); }
		public static Vector3 sqt(this Color v) { return new Vector3(v.r, v.a, v.g); }
		public static Vector3 sqt(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.sqt(); }
		public static Vector3 tqt(this Color v) { return new Vector3(v.g, v.a, v.g); }
		public static Vector3 pqt(this Color v) { return new Vector3(v.b, v.a, v.g); }
		public static Vector3 pqt(this Color v, Vector3 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b(); return v.pqt(); }
		public static Vector3 qqt(this Color v) { return new Vector3(v.a, v.a, v.g); }
		public static Vector3 ssp(this Color v) { return new Vector3(v.r, v.r, v.b); }
		public static Vector3 tsp(this Color v) { return new Vector3(v.g, v.r, v.b); }
		public static Vector3 tsp(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.tsp(); }
		public static Vector3 psp(this Color v) { return new Vector3(v.b, v.r, v.b); }
		public static Vector3 qsp(this Color v) { return new Vector3(v.a, v.r, v.b); }
		public static Vector3 qsp(this Color v, Vector3 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b(); return v.qsp(); }
		public static Vector3 stp(this Color v) { return new Vector3(v.r, v.g, v.b); }
		public static Vector3 stp(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.stp(); }
		public static Vector3 ttp(this Color v) { return new Vector3(v.g, v.g, v.b); }
		public static Vector3 ptp(this Color v) { return new Vector3(v.b, v.g, v.b); }
		public static Vector3 qtp(this Color v) { return new Vector3(v.a, v.g, v.b); }
		public static Vector3 qtp(this Color v, Vector3 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b(); return v.qtp(); }
		public static Vector3 spp(this Color v) { return new Vector3(v.r, v.b, v.b); }
		public static Vector3 tpp(this Color v) { return new Vector3(v.g, v.b, v.b); }
		public static Vector3 ppp(this Color v) { return new Vector3(v.b, v.b, v.b); }
		public static Vector3 qpp(this Color v) { return new Vector3(v.a, v.b, v.b); }
		public static Vector3 sqp(this Color v) { return new Vector3(v.r, v.a, v.b); }
		public static Vector3 sqp(this Color v, Vector3 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.sqp(); }
		public static Vector3 tqp(this Color v) { return new Vector3(v.g, v.a, v.b); }
		public static Vector3 tqp(this Color v, Vector3 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b(); return v.tqp(); }
		public static Vector3 pqp(this Color v) { return new Vector3(v.b, v.a, v.b); }
		public static Vector3 qqp(this Color v) { return new Vector3(v.a, v.a, v.b); }
		public static Vector3 ssq(this Color v) { return new Vector3(v.r, v.r, v.a); }
		public static Vector3 tsq(this Color v) { return new Vector3(v.g, v.r, v.a); }
		public static Vector3 tsq(this Color v, Vector3 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.tsq(); }
		public static Vector3 psq(this Color v) { return new Vector3(v.b, v.r, v.a); }
		public static Vector3 psq(this Color v, Vector3 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b(); return v.psq(); }
		public static Vector3 qsq(this Color v) { return new Vector3(v.a, v.r, v.a); }
		public static Vector3 stq(this Color v) { return new Vector3(v.r, v.g, v.a); }
		public static Vector3 stq(this Color v, Vector3 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.stq(); }
		public static Vector3 ttq(this Color v) { return new Vector3(v.g, v.g, v.a); }
		public static Vector3 ptq(this Color v) { return new Vector3(v.b, v.g, v.a); }
		public static Vector3 ptq(this Color v, Vector3 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b(); return v.ptq(); }
		public static Vector3 qtq(this Color v) { return new Vector3(v.a, v.g, v.a); }
		public static Vector3 spq(this Color v) { return new Vector3(v.r, v.b, v.a); }
		public static Vector3 spq(this Color v, Vector3 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.spq(); }
		public static Vector3 tpq(this Color v) { return new Vector3(v.g, v.b, v.a); }
		public static Vector3 tpq(this Color v, Vector3 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b(); return v.tpq(); }
		public static Vector3 ppq(this Color v) { return new Vector3(v.b, v.b, v.a); }
		public static Vector3 qpq(this Color v) { return new Vector3(v.a, v.b, v.a); }
		public static Vector3 sqq(this Color v) { return new Vector3(v.r, v.a, v.a); }
		public static Vector3 tqq(this Color v) { return new Vector3(v.g, v.a, v.a); }
		public static Vector3 pqq(this Color v) { return new Vector3(v.b, v.a, v.a); }
		public static Vector3 qqq(this Color v) { return new Vector3(v.a, v.a, v.a); }

		// Color with 4 components.
		public static Vector4 ssss(this Color v) { return new Vector4(v.r, v.r, v.r, v.r); }
		public static Vector4 tsss(this Color v) { return new Vector4(v.g, v.r, v.r, v.r); }
		public static Vector4 psss(this Color v) { return new Vector4(v.b, v.r, v.r, v.r); }
		public static Vector4 qsss(this Color v) { return new Vector4(v.a, v.r, v.r, v.r); }
		public static Vector4 stss(this Color v) { return new Vector4(v.r, v.g, v.r, v.r); }
		public static Vector4 ttss(this Color v) { return new Vector4(v.g, v.g, v.r, v.r); }
		public static Vector4 ptss(this Color v) { return new Vector4(v.b, v.g, v.r, v.r); }
		public static Vector4 qtss(this Color v) { return new Vector4(v.a, v.g, v.r, v.r); }
		public static Vector4 spss(this Color v) { return new Vector4(v.r, v.b, v.r, v.r); }
		public static Vector4 tpss(this Color v) { return new Vector4(v.g, v.b, v.r, v.r); }
		public static Vector4 ppss(this Color v) { return new Vector4(v.b, v.b, v.r, v.r); }
		public static Vector4 qpss(this Color v) { return new Vector4(v.a, v.b, v.r, v.r); }
		public static Vector4 sqss(this Color v) { return new Vector4(v.r, v.a, v.r, v.r); }
		public static Vector4 tqss(this Color v) { return new Vector4(v.g, v.a, v.r, v.r); }
		public static Vector4 pqss(this Color v) { return new Vector4(v.b, v.a, v.r, v.r); }
		public static Vector4 qqss(this Color v) { return new Vector4(v.a, v.a, v.r, v.r); }
		public static Vector4 ssts(this Color v) { return new Vector4(v.r, v.r, v.g, v.r); }
		public static Vector4 tsts(this Color v) { return new Vector4(v.g, v.r, v.g, v.r); }
		public static Vector4 psts(this Color v) { return new Vector4(v.b, v.r, v.g, v.r); }
		public static Vector4 qsts(this Color v) { return new Vector4(v.a, v.r, v.g, v.r); }
		public static Vector4 stts(this Color v) { return new Vector4(v.r, v.g, v.g, v.r); }
		public static Vector4 ttts(this Color v) { return new Vector4(v.g, v.g, v.g, v.r); }
		public static Vector4 ptts(this Color v) { return new Vector4(v.b, v.g, v.g, v.r); }
		public static Vector4 qtts(this Color v) { return new Vector4(v.a, v.g, v.g, v.r); }
		public static Vector4 spts(this Color v) { return new Vector4(v.r, v.b, v.g, v.r); }
		public static Vector4 tpts(this Color v) { return new Vector4(v.g, v.b, v.g, v.r); }
		public static Vector4 ppts(this Color v) { return new Vector4(v.b, v.b, v.g, v.r); }
		public static Vector4 qpts(this Color v) { return new Vector4(v.a, v.b, v.g, v.r); }
		public static Vector4 qpts(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.qpts(); }
		public static Vector4 sqts(this Color v) { return new Vector4(v.r, v.a, v.g, v.r); }
		public static Vector4 tqts(this Color v) { return new Vector4(v.g, v.a, v.g, v.r); }
		public static Vector4 pqts(this Color v) { return new Vector4(v.b, v.a, v.g, v.r); }
		public static Vector4 pqts(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.r = (float)other.a(); return v.pqts(); }
		public static Vector4 qqts(this Color v) { return new Vector4(v.a, v.a, v.g, v.r); }
		public static Vector4 ssps(this Color v) { return new Vector4(v.r, v.r, v.b, v.r); }
		public static Vector4 tsps(this Color v) { return new Vector4(v.g, v.r, v.b, v.r); }
		public static Vector4 psps(this Color v) { return new Vector4(v.b, v.r, v.b, v.r); }
		public static Vector4 qsps(this Color v) { return new Vector4(v.a, v.r, v.b, v.r); }
		public static Vector4 stps(this Color v) { return new Vector4(v.r, v.g, v.b, v.r); }
		public static Vector4 ttps(this Color v) { return new Vector4(v.g, v.g, v.b, v.r); }
		public static Vector4 ptps(this Color v) { return new Vector4(v.b, v.g, v.b, v.r); }
		public static Vector4 qtps(this Color v) { return new Vector4(v.a, v.g, v.b, v.r); }
		public static Vector4 qtps(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.qtps(); }
		public static Vector4 spps(this Color v) { return new Vector4(v.r, v.b, v.b, v.r); }
		public static Vector4 tpps(this Color v) { return new Vector4(v.g, v.b, v.b, v.r); }
		public static Vector4 ppps(this Color v) { return new Vector4(v.b, v.b, v.b, v.r); }
		public static Vector4 qpps(this Color v) { return new Vector4(v.a, v.b, v.b, v.r); }
		public static Vector4 sqps(this Color v) { return new Vector4(v.r, v.a, v.b, v.r); }
		public static Vector4 tqps(this Color v) { return new Vector4(v.g, v.a, v.b, v.r); }
		public static Vector4 tqps(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.r = (float)other.a(); return v.tqps(); }
		public static Vector4 pqps(this Color v) { return new Vector4(v.b, v.a, v.b, v.r); }
		public static Vector4 qqps(this Color v) { return new Vector4(v.a, v.a, v.b, v.r); }
		public static Vector4 ssqs(this Color v) { return new Vector4(v.r, v.r, v.a, v.r); }
		public static Vector4 tsqs(this Color v) { return new Vector4(v.g, v.r, v.a, v.r); }
		public static Vector4 psqs(this Color v) { return new Vector4(v.b, v.r, v.a, v.r); }
		public static Vector4 qsqs(this Color v) { return new Vector4(v.a, v.r, v.a, v.r); }
		public static Vector4 stqs(this Color v) { return new Vector4(v.r, v.g, v.a, v.r); }
		public static Vector4 ttqs(this Color v) { return new Vector4(v.g, v.g, v.a, v.r); }
		public static Vector4 ptqs(this Color v) { return new Vector4(v.b, v.g, v.a, v.r); }
		public static Vector4 ptqs(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.ptqs(); }
		public static Vector4 qtqs(this Color v) { return new Vector4(v.a, v.g, v.a, v.r); }
		public static Vector4 spqs(this Color v) { return new Vector4(v.r, v.b, v.a, v.r); }
		public static Vector4 tpqs(this Color v) { return new Vector4(v.g, v.b, v.a, v.r); }
		public static Vector4 tpqs(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.r = (float)other.a(); return v.tpqs(); }
		public static Vector4 ppqs(this Color v) { return new Vector4(v.b, v.b, v.a, v.r); }
		public static Vector4 qpqs(this Color v) { return new Vector4(v.a, v.b, v.a, v.r); }
		public static Vector4 sqqs(this Color v) { return new Vector4(v.r, v.a, v.a, v.r); }
		public static Vector4 tqqs(this Color v) { return new Vector4(v.g, v.a, v.a, v.r); }
		public static Vector4 pqqs(this Color v) { return new Vector4(v.b, v.a, v.a, v.r); }
		public static Vector4 qqqs(this Color v) { return new Vector4(v.a, v.a, v.a, v.r); }
		public static Vector4 ssst(this Color v) { return new Vector4(v.r, v.r, v.r, v.g); }
		public static Vector4 tsst(this Color v) { return new Vector4(v.g, v.r, v.r, v.g); }
		public static Vector4 psst(this Color v) { return new Vector4(v.b, v.r, v.r, v.g); }
		public static Vector4 qsst(this Color v) { return new Vector4(v.a, v.r, v.r, v.g); }
		public static Vector4 stst(this Color v) { return new Vector4(v.r, v.g, v.r, v.g); }
		public static Vector4 ttst(this Color v) { return new Vector4(v.g, v.g, v.r, v.g); }
		public static Vector4 ptst(this Color v) { return new Vector4(v.b, v.g, v.r, v.g); }
		public static Vector4 qtst(this Color v) { return new Vector4(v.a, v.g, v.r, v.g); }
		public static Vector4 spst(this Color v) { return new Vector4(v.r, v.b, v.r, v.g); }
		public static Vector4 tpst(this Color v) { return new Vector4(v.g, v.b, v.r, v.g); }
		public static Vector4 ppst(this Color v) { return new Vector4(v.b, v.b, v.r, v.g); }
		public static Vector4 qpst(this Color v) { return new Vector4(v.a, v.b, v.r, v.g); }
		public static Vector4 qpst(this Color v, Vector4 other) { v.a = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.qpst(); }
		public static Vector4 sqst(this Color v) { return new Vector4(v.r, v.a, v.r, v.g); }
		public static Vector4 tqst(this Color v) { return new Vector4(v.g, v.a, v.r, v.g); }
		public static Vector4 pqst(this Color v) { return new Vector4(v.b, v.a, v.r, v.g); }
		public static Vector4 pqst(this Color v, Vector4 other) { v.b = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.g = (float)other.a(); return v.pqst(); }
		public static Vector4 qqst(this Color v) { return new Vector4(v.a, v.a, v.r, v.g); }
		public static Vector4 sstt(this Color v) { return new Vector4(v.r, v.r, v.g, v.g); }
		public static Vector4 tstt(this Color v) { return new Vector4(v.g, v.r, v.g, v.g); }
		public static Vector4 pstt(this Color v) { return new Vector4(v.b, v.r, v.g, v.g); }
		public static Vector4 qstt(this Color v) { return new Vector4(v.a, v.r, v.g, v.g); }
		public static Vector4 sttt(this Color v) { return new Vector4(v.r, v.g, v.g, v.g); }
		public static Vector4 tttt(this Color v) { return new Vector4(v.g, v.g, v.g, v.g); }
		public static Vector4 pttt(this Color v) { return new Vector4(v.b, v.g, v.g, v.g); }
		public static Vector4 qttt(this Color v) { return new Vector4(v.a, v.g, v.g, v.g); }
		public static Vector4 sptt(this Color v) { return new Vector4(v.r, v.b, v.g, v.g); }
		public static Vector4 tptt(this Color v) { return new Vector4(v.g, v.b, v.g, v.g); }
		public static Vector4 pptt(this Color v) { return new Vector4(v.b, v.b, v.g, v.g); }
		public static Vector4 qptt(this Color v) { return new Vector4(v.a, v.b, v.g, v.g); }
		public static Vector4 sqtt(this Color v) { return new Vector4(v.r, v.a, v.g, v.g); }
		public static Vector4 tqtt(this Color v) { return new Vector4(v.g, v.a, v.g, v.g); }
		public static Vector4 pqtt(this Color v) { return new Vector4(v.b, v.a, v.g, v.g); }
		public static Vector4 qqtt(this Color v) { return new Vector4(v.a, v.a, v.g, v.g); }
		public static Vector4 sspt(this Color v) { return new Vector4(v.r, v.r, v.b, v.g); }
		public static Vector4 tspt(this Color v) { return new Vector4(v.g, v.r, v.b, v.g); }
		public static Vector4 pspt(this Color v) { return new Vector4(v.b, v.r, v.b, v.g); }
		public static Vector4 qspt(this Color v) { return new Vector4(v.a, v.r, v.b, v.g); }
		public static Vector4 qspt(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.qspt(); }
		public static Vector4 stpt(this Color v) { return new Vector4(v.r, v.g, v.b, v.g); }
		public static Vector4 ttpt(this Color v) { return new Vector4(v.g, v.g, v.b, v.g); }
		public static Vector4 ptpt(this Color v) { return new Vector4(v.b, v.g, v.b, v.g); }
		public static Vector4 qtpt(this Color v) { return new Vector4(v.a, v.g, v.b, v.g); }
		public static Vector4 sppt(this Color v) { return new Vector4(v.r, v.b, v.b, v.g); }
		public static Vector4 tppt(this Color v) { return new Vector4(v.g, v.b, v.b, v.g); }
		public static Vector4 pppt(this Color v) { return new Vector4(v.b, v.b, v.b, v.g); }
		public static Vector4 qppt(this Color v) { return new Vector4(v.a, v.b, v.b, v.g); }
		public static Vector4 sqpt(this Color v) { return new Vector4(v.r, v.a, v.b, v.g); }
		public static Vector4 sqpt(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.b = (float)other.b();v.g = (float)other.a(); return v.sqpt(); }
		public static Vector4 tqpt(this Color v) { return new Vector4(v.g, v.a, v.b, v.g); }
		public static Vector4 pqpt(this Color v) { return new Vector4(v.b, v.a, v.b, v.g); }
		public static Vector4 qqpt(this Color v) { return new Vector4(v.a, v.a, v.b, v.g); }
		public static Vector4 ssqt(this Color v) { return new Vector4(v.r, v.r, v.a, v.g); }
		public static Vector4 tsqt(this Color v) { return new Vector4(v.g, v.r, v.a, v.g); }
		public static Vector4 psqt(this Color v) { return new Vector4(v.b, v.r, v.a, v.g); }
		public static Vector4 psqt(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.psqt(); }
		public static Vector4 qsqt(this Color v) { return new Vector4(v.a, v.r, v.a, v.g); }
		public static Vector4 stqt(this Color v) { return new Vector4(v.r, v.g, v.a, v.g); }
		public static Vector4 ttqt(this Color v) { return new Vector4(v.g, v.g, v.a, v.g); }
		public static Vector4 ptqt(this Color v) { return new Vector4(v.b, v.g, v.a, v.g); }
		public static Vector4 qtqt(this Color v) { return new Vector4(v.a, v.g, v.a, v.g); }
		public static Vector4 spqt(this Color v) { return new Vector4(v.r, v.b, v.a, v.g); }
		public static Vector4 spqt(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.a = (float)other.b();v.g = (float)other.a(); return v.spqt(); }
		public static Vector4 tpqt(this Color v) { return new Vector4(v.g, v.b, v.a, v.g); }
		public static Vector4 ppqt(this Color v) { return new Vector4(v.b, v.b, v.a, v.g); }
		public static Vector4 qpqt(this Color v) { return new Vector4(v.a, v.b, v.a, v.g); }
		public static Vector4 sqqt(this Color v) { return new Vector4(v.r, v.a, v.a, v.g); }
		public static Vector4 tqqt(this Color v) { return new Vector4(v.g, v.a, v.a, v.g); }
		public static Vector4 pqqt(this Color v) { return new Vector4(v.b, v.a, v.a, v.g); }
		public static Vector4 qqqt(this Color v) { return new Vector4(v.a, v.a, v.a, v.g); }
		public static Vector4 sssp(this Color v) { return new Vector4(v.r, v.r, v.r, v.b); }
		public static Vector4 tssp(this Color v) { return new Vector4(v.g, v.r, v.r, v.b); }
		public static Vector4 pssp(this Color v) { return new Vector4(v.b, v.r, v.r, v.b); }
		public static Vector4 qssp(this Color v) { return new Vector4(v.a, v.r, v.r, v.b); }
		public static Vector4 stsp(this Color v) { return new Vector4(v.r, v.g, v.r, v.b); }
		public static Vector4 ttsp(this Color v) { return new Vector4(v.g, v.g, v.r, v.b); }
		public static Vector4 ptsp(this Color v) { return new Vector4(v.b, v.g, v.r, v.b); }
		public static Vector4 qtsp(this Color v) { return new Vector4(v.a, v.g, v.r, v.b); }
		public static Vector4 qtsp(this Color v, Vector4 other) { v.a = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.qtsp(); }
		public static Vector4 spsp(this Color v) { return new Vector4(v.r, v.b, v.r, v.b); }
		public static Vector4 tpsp(this Color v) { return new Vector4(v.g, v.b, v.r, v.b); }
		public static Vector4 ppsp(this Color v) { return new Vector4(v.b, v.b, v.r, v.b); }
		public static Vector4 qpsp(this Color v) { return new Vector4(v.a, v.b, v.r, v.b); }
		public static Vector4 sqsp(this Color v) { return new Vector4(v.r, v.a, v.r, v.b); }
		public static Vector4 tqsp(this Color v) { return new Vector4(v.g, v.a, v.r, v.b); }
		public static Vector4 tqsp(this Color v, Vector4 other) { v.g = (float)other.r();v.a = (float)other.g();v.r = (float)other.b();v.b = (float)other.a(); return v.tqsp(); }
		public static Vector4 pqsp(this Color v) { return new Vector4(v.b, v.a, v.r, v.b); }
		public static Vector4 qqsp(this Color v) { return new Vector4(v.a, v.a, v.r, v.b); }
		public static Vector4 sstp(this Color v) { return new Vector4(v.r, v.r, v.g, v.b); }
		public static Vector4 tstp(this Color v) { return new Vector4(v.g, v.r, v.g, v.b); }
		public static Vector4 pstp(this Color v) { return new Vector4(v.b, v.r, v.g, v.b); }
		public static Vector4 qstp(this Color v) { return new Vector4(v.a, v.r, v.g, v.b); }
		public static Vector4 qstp(this Color v, Vector4 other) { v.a = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.qstp(); }
		public static Vector4 sttp(this Color v) { return new Vector4(v.r, v.g, v.g, v.b); }
		public static Vector4 tttp(this Color v) { return new Vector4(v.g, v.g, v.g, v.b); }
		public static Vector4 pttp(this Color v) { return new Vector4(v.b, v.g, v.g, v.b); }
		public static Vector4 qttp(this Color v) { return new Vector4(v.a, v.g, v.g, v.b); }
		public static Vector4 sptp(this Color v) { return new Vector4(v.r, v.b, v.g, v.b); }
		public static Vector4 tptp(this Color v) { return new Vector4(v.g, v.b, v.g, v.b); }
		public static Vector4 pptp(this Color v) { return new Vector4(v.b, v.b, v.g, v.b); }
		public static Vector4 qptp(this Color v) { return new Vector4(v.a, v.b, v.g, v.b); }
		public static Vector4 sqtp(this Color v) { return new Vector4(v.r, v.a, v.g, v.b); }
		public static Vector4 sqtp(this Color v, Vector4 other) { v.r = (float)other.r();v.a = (float)other.g();v.g = (float)other.b();v.b = (float)other.a(); return v.sqtp(); }
		public static Vector4 tqtp(this Color v) { return new Vector4(v.g, v.a, v.g, v.b); }
		public static Vector4 pqtp(this Color v) { return new Vector4(v.b, v.a, v.g, v.b); }
		public static Vector4 qqtp(this Color v) { return new Vector4(v.a, v.a, v.g, v.b); }
		public static Vector4 sspp(this Color v) { return new Vector4(v.r, v.r, v.b, v.b); }
		public static Vector4 tspp(this Color v) { return new Vector4(v.g, v.r, v.b, v.b); }
		public static Vector4 pspp(this Color v) { return new Vector4(v.b, v.r, v.b, v.b); }
		public static Vector4 qspp(this Color v) { return new Vector4(v.a, v.r, v.b, v.b); }
		public static Vector4 stpp(this Color v) { return new Vector4(v.r, v.g, v.b, v.b); }
		public static Vector4 ttpp(this Color v) { return new Vector4(v.g, v.g, v.b, v.b); }
		public static Vector4 ptpp(this Color v) { return new Vector4(v.b, v.g, v.b, v.b); }
		public static Vector4 qtpp(this Color v) { return new Vector4(v.a, v.g, v.b, v.b); }
		public static Vector4 sppp(this Color v) { return new Vector4(v.r, v.b, v.b, v.b); }
		public static Vector4 tppp(this Color v) { return new Vector4(v.g, v.b, v.b, v.b); }
		public static Vector4 pppp(this Color v) { return new Vector4(v.b, v.b, v.b, v.b); }
		public static Vector4 qppp(this Color v) { return new Vector4(v.a, v.b, v.b, v.b); }
		public static Vector4 sqpp(this Color v) { return new Vector4(v.r, v.a, v.b, v.b); }
		public static Vector4 tqpp(this Color v) { return new Vector4(v.g, v.a, v.b, v.b); }
		public static Vector4 pqpp(this Color v) { return new Vector4(v.b, v.a, v.b, v.b); }
		public static Vector4 qqpp(this Color v) { return new Vector4(v.a, v.a, v.b, v.b); }
		public static Vector4 ssqp(this Color v) { return new Vector4(v.r, v.r, v.a, v.b); }
		public static Vector4 tsqp(this Color v) { return new Vector4(v.g, v.r, v.a, v.b); }
		public static Vector4 tsqp(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.tsqp(); }
		public static Vector4 psqp(this Color v) { return new Vector4(v.b, v.r, v.a, v.b); }
		public static Vector4 qsqp(this Color v) { return new Vector4(v.a, v.r, v.a, v.b); }
		public static Vector4 stqp(this Color v) { return new Vector4(v.r, v.g, v.a, v.b); }
		public static Vector4 stqp(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.a = (float)other.b();v.b = (float)other.a(); return v.stqp(); }
		public static Vector4 ttqp(this Color v) { return new Vector4(v.g, v.g, v.a, v.b); }
		public static Vector4 ptqp(this Color v) { return new Vector4(v.b, v.g, v.a, v.b); }
		public static Vector4 qtqp(this Color v) { return new Vector4(v.a, v.g, v.a, v.b); }
		public static Vector4 spqp(this Color v) { return new Vector4(v.r, v.b, v.a, v.b); }
		public static Vector4 tpqp(this Color v) { return new Vector4(v.g, v.b, v.a, v.b); }
		public static Vector4 ppqp(this Color v) { return new Vector4(v.b, v.b, v.a, v.b); }
		public static Vector4 qpqp(this Color v) { return new Vector4(v.a, v.b, v.a, v.b); }
		public static Vector4 sqqp(this Color v) { return new Vector4(v.r, v.a, v.a, v.b); }
		public static Vector4 tqqp(this Color v) { return new Vector4(v.g, v.a, v.a, v.b); }
		public static Vector4 pqqp(this Color v) { return new Vector4(v.b, v.a, v.a, v.b); }
		public static Vector4 qqqp(this Color v) { return new Vector4(v.a, v.a, v.a, v.b); }
		public static Vector4 sssq(this Color v) { return new Vector4(v.r, v.r, v.r, v.a); }
		public static Vector4 tssq(this Color v) { return new Vector4(v.g, v.r, v.r, v.a); }
		public static Vector4 pssq(this Color v) { return new Vector4(v.b, v.r, v.r, v.a); }
		public static Vector4 qssq(this Color v) { return new Vector4(v.a, v.r, v.r, v.a); }
		public static Vector4 stsq(this Color v) { return new Vector4(v.r, v.g, v.r, v.a); }
		public static Vector4 ttsq(this Color v) { return new Vector4(v.g, v.g, v.r, v.a); }
		public static Vector4 ptsq(this Color v) { return new Vector4(v.b, v.g, v.r, v.a); }
		public static Vector4 ptsq(this Color v, Vector4 other) { v.b = (float)other.r();v.g = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.ptsq(); }
		public static Vector4 qtsq(this Color v) { return new Vector4(v.a, v.g, v.r, v.a); }
		public static Vector4 spsq(this Color v) { return new Vector4(v.r, v.b, v.r, v.a); }
		public static Vector4 tpsq(this Color v) { return new Vector4(v.g, v.b, v.r, v.a); }
		public static Vector4 tpsq(this Color v, Vector4 other) { v.g = (float)other.r();v.b = (float)other.g();v.r = (float)other.b();v.a = (float)other.a(); return v.tpsq(); }
		public static Vector4 ppsq(this Color v) { return new Vector4(v.b, v.b, v.r, v.a); }
		public static Vector4 qpsq(this Color v) { return new Vector4(v.a, v.b, v.r, v.a); }
		public static Vector4 sqsq(this Color v) { return new Vector4(v.r, v.a, v.r, v.a); }
		public static Vector4 tqsq(this Color v) { return new Vector4(v.g, v.a, v.r, v.a); }
		public static Vector4 pqsq(this Color v) { return new Vector4(v.b, v.a, v.r, v.a); }
		public static Vector4 qqsq(this Color v) { return new Vector4(v.a, v.a, v.r, v.a); }
		public static Vector4 sstq(this Color v) { return new Vector4(v.r, v.r, v.g, v.a); }
		public static Vector4 tstq(this Color v) { return new Vector4(v.g, v.r, v.g, v.a); }
		public static Vector4 pstq(this Color v) { return new Vector4(v.b, v.r, v.g, v.a); }
		public static Vector4 pstq(this Color v, Vector4 other) { v.b = (float)other.r();v.r = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.pstq(); }
		public static Vector4 qstq(this Color v) { return new Vector4(v.a, v.r, v.g, v.a); }
		public static Vector4 sttq(this Color v) { return new Vector4(v.r, v.g, v.g, v.a); }
		public static Vector4 tttq(this Color v) { return new Vector4(v.g, v.g, v.g, v.a); }
		public static Vector4 pttq(this Color v) { return new Vector4(v.b, v.g, v.g, v.a); }
		public static Vector4 qttq(this Color v) { return new Vector4(v.a, v.g, v.g, v.a); }
		public static Vector4 sptq(this Color v) { return new Vector4(v.r, v.b, v.g, v.a); }
		public static Vector4 sptq(this Color v, Vector4 other) { v.r = (float)other.r();v.b = (float)other.g();v.g = (float)other.b();v.a = (float)other.a(); return v.sptq(); }
		public static Vector4 tptq(this Color v) { return new Vector4(v.g, v.b, v.g, v.a); }
		public static Vector4 pptq(this Color v) { return new Vector4(v.b, v.b, v.g, v.a); }
		public static Vector4 qptq(this Color v) { return new Vector4(v.a, v.b, v.g, v.a); }
		public static Vector4 sqtq(this Color v) { return new Vector4(v.r, v.a, v.g, v.a); }
		public static Vector4 tqtq(this Color v) { return new Vector4(v.g, v.a, v.g, v.a); }
		public static Vector4 pqtq(this Color v) { return new Vector4(v.b, v.a, v.g, v.a); }
		public static Vector4 qqtq(this Color v) { return new Vector4(v.a, v.a, v.g, v.a); }
		public static Vector4 sspq(this Color v) { return new Vector4(v.r, v.r, v.b, v.a); }
		public static Vector4 tspq(this Color v) { return new Vector4(v.g, v.r, v.b, v.a); }
		public static Vector4 tspq(this Color v, Vector4 other) { v.g = (float)other.r();v.r = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.tspq(); }
		public static Vector4 pspq(this Color v) { return new Vector4(v.b, v.r, v.b, v.a); }
		public static Vector4 qspq(this Color v) { return new Vector4(v.a, v.r, v.b, v.a); }
		public static Vector4 stpq(this Color v) { return new Vector4(v.r, v.g, v.b, v.a); }
		public static Vector4 stpq(this Color v, Vector4 other) { v.r = (float)other.r();v.g = (float)other.g();v.b = (float)other.b();v.a = (float)other.a(); return v.stpq(); }
		public static Vector4 ttpq(this Color v) { return new Vector4(v.g, v.g, v.b, v.a); }
		public static Vector4 ptpq(this Color v) { return new Vector4(v.b, v.g, v.b, v.a); }
		public static Vector4 qtpq(this Color v) { return new Vector4(v.a, v.g, v.b, v.a); }
		public static Vector4 sppq(this Color v) { return new Vector4(v.r, v.b, v.b, v.a); }
		public static Vector4 tppq(this Color v) { return new Vector4(v.g, v.b, v.b, v.a); }
		public static Vector4 pppq(this Color v) { return new Vector4(v.b, v.b, v.b, v.a); }
		public static Vector4 qppq(this Color v) { return new Vector4(v.a, v.b, v.b, v.a); }
		public static Vector4 sqpq(this Color v) { return new Vector4(v.r, v.a, v.b, v.a); }
		public static Vector4 tqpq(this Color v) { return new Vector4(v.g, v.a, v.b, v.a); }
		public static Vector4 pqpq(this Color v) { return new Vector4(v.b, v.a, v.b, v.a); }
		public static Vector4 qqpq(this Color v) { return new Vector4(v.a, v.a, v.b, v.a); }
		public static Vector4 ssqq(this Color v) { return new Vector4(v.r, v.r, v.a, v.a); }
		public static Vector4 tsqq(this Color v) { return new Vector4(v.g, v.r, v.a, v.a); }
		public static Vector4 psqq(this Color v) { return new Vector4(v.b, v.r, v.a, v.a); }
		public static Vector4 qsqq(this Color v) { return new Vector4(v.a, v.r, v.a, v.a); }
		public static Vector4 stqq(this Color v) { return new Vector4(v.r, v.g, v.a, v.a); }
		public static Vector4 ttqq(this Color v) { return new Vector4(v.g, v.g, v.a, v.a); }
		public static Vector4 ptqq(this Color v) { return new Vector4(v.b, v.g, v.a, v.a); }
		public static Vector4 qtqq(this Color v) { return new Vector4(v.a, v.g, v.a, v.a); }
		public static Vector4 spqq(this Color v) { return new Vector4(v.r, v.b, v.a, v.a); }
		public static Vector4 tpqq(this Color v) { return new Vector4(v.g, v.b, v.a, v.a); }
		public static Vector4 ppqq(this Color v) { return new Vector4(v.b, v.b, v.a, v.a); }
		public static Vector4 qpqq(this Color v) { return new Vector4(v.a, v.b, v.a, v.a); }
		public static Vector4 sqqq(this Color v) { return new Vector4(v.r, v.a, v.a, v.a); }
		public static Vector4 tqqq(this Color v) { return new Vector4(v.g, v.a, v.a, v.a); }
		public static Vector4 pqqq(this Color v) { return new Vector4(v.b, v.a, v.a, v.a); }
		public static Vector4 qqqq(this Color v) { return new Vector4(v.a, v.a, v.a, v.a); }
	}

	public static class Color32xyzwSwizzleExtension
	{
		// Color32 with 1 components.
		public static byte x(this Color32 v) { return v.r; }
		public static byte x(this Color32 v, byte other) { v.r = other; return v.x(); }
		public static byte y(this Color32 v) { return v.g; }
		public static byte y(this Color32 v, byte other) { v.g = other; return v.y(); }
		public static byte z(this Color32 v) { return v.b; }
		public static byte z(this Color32 v, byte other) { v.b = other; return v.z(); }
		public static byte w(this Color32 v) { return v.a; }
		public static byte w(this Color32 v, byte other) { v.a = other; return v.w(); }

		// Color32 with 2 components.
		public static Vector2Int xx(this Color32 v) { return new Vector2Int(v.r, v.r); }
		public static Vector2Int yx(this Color32 v) { return new Vector2Int(v.g, v.r); }
		public static Vector2Int yx(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.r = (byte)other.g(); return v.yx(); }
		public static Vector2Int zx(this Color32 v) { return new Vector2Int(v.b, v.r); }
		public static Vector2Int zx(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.r = (byte)other.g(); return v.zx(); }
		public static Vector2Int wx(this Color32 v) { return new Vector2Int(v.a, v.r); }
		public static Vector2Int wx(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.r = (byte)other.g(); return v.wx(); }
		public static Vector2Int xy(this Color32 v) { return new Vector2Int(v.r, v.g); }
		public static Vector2Int xy(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.g = (byte)other.g(); return v.xy(); }
		public static Vector2Int yy(this Color32 v) { return new Vector2Int(v.g, v.g); }
		public static Vector2Int zy(this Color32 v) { return new Vector2Int(v.b, v.g); }
		public static Vector2Int zy(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.g = (byte)other.g(); return v.zy(); }
		public static Vector2Int wy(this Color32 v) { return new Vector2Int(v.a, v.g); }
		public static Vector2Int wy(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.g = (byte)other.g(); return v.wy(); }
		public static Vector2Int xz(this Color32 v) { return new Vector2Int(v.r, v.b); }
		public static Vector2Int xz(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.b = (byte)other.g(); return v.xz(); }
		public static Vector2Int yz(this Color32 v) { return new Vector2Int(v.g, v.b); }
		public static Vector2Int yz(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.b = (byte)other.g(); return v.yz(); }
		public static Vector2Int zz(this Color32 v) { return new Vector2Int(v.b, v.b); }
		public static Vector2Int wz(this Color32 v) { return new Vector2Int(v.a, v.b); }
		public static Vector2Int wz(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.b = (byte)other.g(); return v.wz(); }
		public static Vector2Int xw(this Color32 v) { return new Vector2Int(v.r, v.a); }
		public static Vector2Int xw(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.a = (byte)other.g(); return v.xw(); }
		public static Vector2Int yw(this Color32 v) { return new Vector2Int(v.g, v.a); }
		public static Vector2Int yw(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.a = (byte)other.g(); return v.yw(); }
		public static Vector2Int zw(this Color32 v) { return new Vector2Int(v.b, v.a); }
		public static Vector2Int zw(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.a = (byte)other.g(); return v.zw(); }
		public static Vector2Int ww(this Color32 v) { return new Vector2Int(v.a, v.a); }

		// Color32 with 3 components.
		public static Vector3Int xxx(this Color32 v) { return new Vector3Int(v.r, v.r, v.r); }
		public static Vector3Int yxx(this Color32 v) { return new Vector3Int(v.g, v.r, v.r); }
		public static Vector3Int zxx(this Color32 v) { return new Vector3Int(v.b, v.r, v.r); }
		public static Vector3Int wxx(this Color32 v) { return new Vector3Int(v.a, v.r, v.r); }
		public static Vector3Int xyx(this Color32 v) { return new Vector3Int(v.r, v.g, v.r); }
		public static Vector3Int yyx(this Color32 v) { return new Vector3Int(v.g, v.g, v.r); }
		public static Vector3Int zyx(this Color32 v) { return new Vector3Int(v.b, v.g, v.r); }
		public static Vector3Int zyx(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.zyx(); }
		public static Vector3Int wyx(this Color32 v) { return new Vector3Int(v.a, v.g, v.r); }
		public static Vector3Int wyx(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.wyx(); }
		public static Vector3Int xzx(this Color32 v) { return new Vector3Int(v.r, v.b, v.r); }
		public static Vector3Int yzx(this Color32 v) { return new Vector3Int(v.g, v.b, v.r); }
		public static Vector3Int yzx(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.yzx(); }
		public static Vector3Int zzx(this Color32 v) { return new Vector3Int(v.b, v.b, v.r); }
		public static Vector3Int wzx(this Color32 v) { return new Vector3Int(v.a, v.b, v.r); }
		public static Vector3Int wzx(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.wzx(); }
		public static Vector3Int xwx(this Color32 v) { return new Vector3Int(v.r, v.a, v.r); }
		public static Vector3Int ywx(this Color32 v) { return new Vector3Int(v.g, v.a, v.r); }
		public static Vector3Int ywx(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.ywx(); }
		public static Vector3Int zwx(this Color32 v) { return new Vector3Int(v.b, v.a, v.r); }
		public static Vector3Int zwx(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.zwx(); }
		public static Vector3Int wwx(this Color32 v) { return new Vector3Int(v.a, v.a, v.r); }
		public static Vector3Int xxy(this Color32 v) { return new Vector3Int(v.r, v.r, v.g); }
		public static Vector3Int yxy(this Color32 v) { return new Vector3Int(v.g, v.r, v.g); }
		public static Vector3Int zxy(this Color32 v) { return new Vector3Int(v.b, v.r, v.g); }
		public static Vector3Int zxy(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.zxy(); }
		public static Vector3Int wxy(this Color32 v) { return new Vector3Int(v.a, v.r, v.g); }
		public static Vector3Int wxy(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.wxy(); }
		public static Vector3Int xyy(this Color32 v) { return new Vector3Int(v.r, v.g, v.g); }
		public static Vector3Int yyy(this Color32 v) { return new Vector3Int(v.g, v.g, v.g); }
		public static Vector3Int zyy(this Color32 v) { return new Vector3Int(v.b, v.g, v.g); }
		public static Vector3Int wyy(this Color32 v) { return new Vector3Int(v.a, v.g, v.g); }
		public static Vector3Int xzy(this Color32 v) { return new Vector3Int(v.r, v.b, v.g); }
		public static Vector3Int xzy(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.xzy(); }
		public static Vector3Int yzy(this Color32 v) { return new Vector3Int(v.g, v.b, v.g); }
		public static Vector3Int zzy(this Color32 v) { return new Vector3Int(v.b, v.b, v.g); }
		public static Vector3Int wzy(this Color32 v) { return new Vector3Int(v.a, v.b, v.g); }
		public static Vector3Int wzy(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.wzy(); }
		public static Vector3Int xwy(this Color32 v) { return new Vector3Int(v.r, v.a, v.g); }
		public static Vector3Int xwy(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.xwy(); }
		public static Vector3Int ywy(this Color32 v) { return new Vector3Int(v.g, v.a, v.g); }
		public static Vector3Int zwy(this Color32 v) { return new Vector3Int(v.b, v.a, v.g); }
		public static Vector3Int zwy(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.zwy(); }
		public static Vector3Int wwy(this Color32 v) { return new Vector3Int(v.a, v.a, v.g); }
		public static Vector3Int xxz(this Color32 v) { return new Vector3Int(v.r, v.r, v.b); }
		public static Vector3Int yxz(this Color32 v) { return new Vector3Int(v.g, v.r, v.b); }
		public static Vector3Int yxz(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.yxz(); }
		public static Vector3Int zxz(this Color32 v) { return new Vector3Int(v.b, v.r, v.b); }
		public static Vector3Int wxz(this Color32 v) { return new Vector3Int(v.a, v.r, v.b); }
		public static Vector3Int wxz(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.wxz(); }
		public static Vector3Int xyz(this Color32 v) { return new Vector3Int(v.r, v.g, v.b); }
		public static Vector3Int xyz(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.xyz(); }
		public static Vector3Int yyz(this Color32 v) { return new Vector3Int(v.g, v.g, v.b); }
		public static Vector3Int zyz(this Color32 v) { return new Vector3Int(v.b, v.g, v.b); }
		public static Vector3Int wyz(this Color32 v) { return new Vector3Int(v.a, v.g, v.b); }
		public static Vector3Int wyz(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.wyz(); }
		public static Vector3Int xzz(this Color32 v) { return new Vector3Int(v.r, v.b, v.b); }
		public static Vector3Int yzz(this Color32 v) { return new Vector3Int(v.g, v.b, v.b); }
		public static Vector3Int zzz(this Color32 v) { return new Vector3Int(v.b, v.b, v.b); }
		public static Vector3Int wzz(this Color32 v) { return new Vector3Int(v.a, v.b, v.b); }
		public static Vector3Int xwz(this Color32 v) { return new Vector3Int(v.r, v.a, v.b); }
		public static Vector3Int xwz(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.xwz(); }
		public static Vector3Int ywz(this Color32 v) { return new Vector3Int(v.g, v.a, v.b); }
		public static Vector3Int ywz(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.ywz(); }
		public static Vector3Int zwz(this Color32 v) { return new Vector3Int(v.b, v.a, v.b); }
		public static Vector3Int wwz(this Color32 v) { return new Vector3Int(v.a, v.a, v.b); }
		public static Vector3Int xxw(this Color32 v) { return new Vector3Int(v.r, v.r, v.a); }
		public static Vector3Int yxw(this Color32 v) { return new Vector3Int(v.g, v.r, v.a); }
		public static Vector3Int yxw(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.yxw(); }
		public static Vector3Int zxw(this Color32 v) { return new Vector3Int(v.b, v.r, v.a); }
		public static Vector3Int zxw(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.zxw(); }
		public static Vector3Int wxw(this Color32 v) { return new Vector3Int(v.a, v.r, v.a); }
		public static Vector3Int xyw(this Color32 v) { return new Vector3Int(v.r, v.g, v.a); }
		public static Vector3Int xyw(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.xyw(); }
		public static Vector3Int yyw(this Color32 v) { return new Vector3Int(v.g, v.g, v.a); }
		public static Vector3Int zyw(this Color32 v) { return new Vector3Int(v.b, v.g, v.a); }
		public static Vector3Int zyw(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.zyw(); }
		public static Vector3Int wyw(this Color32 v) { return new Vector3Int(v.a, v.g, v.a); }
		public static Vector3Int xzw(this Color32 v) { return new Vector3Int(v.r, v.b, v.a); }
		public static Vector3Int xzw(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.xzw(); }
		public static Vector3Int yzw(this Color32 v) { return new Vector3Int(v.g, v.b, v.a); }
		public static Vector3Int yzw(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.yzw(); }
		public static Vector3Int zzw(this Color32 v) { return new Vector3Int(v.b, v.b, v.a); }
		public static Vector3Int wzw(this Color32 v) { return new Vector3Int(v.a, v.b, v.a); }
		public static Vector3Int xww(this Color32 v) { return new Vector3Int(v.r, v.a, v.a); }
		public static Vector3Int yww(this Color32 v) { return new Vector3Int(v.g, v.a, v.a); }
		public static Vector3Int zww(this Color32 v) { return new Vector3Int(v.b, v.a, v.a); }
		public static Vector3Int www(this Color32 v) { return new Vector3Int(v.a, v.a, v.a); }

		// Color32 with 4 components.
		public static Vector4Int xxxx(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.r); }
		public static Vector4Int yxxx(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.r); }
		public static Vector4Int zxxx(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.r); }
		public static Vector4Int wxxx(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.r); }
		public static Vector4Int xyxx(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.r); }
		public static Vector4Int yyxx(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.r); }
		public static Vector4Int zyxx(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.r); }
		public static Vector4Int wyxx(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.r); }
		public static Vector4Int xzxx(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.r); }
		public static Vector4Int yzxx(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.r); }
		public static Vector4Int zzxx(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.r); }
		public static Vector4Int wzxx(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.r); }
		public static Vector4Int xwxx(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.r); }
		public static Vector4Int ywxx(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.r); }
		public static Vector4Int zwxx(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.r); }
		public static Vector4Int wwxx(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.r); }
		public static Vector4Int xxyx(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.r); }
		public static Vector4Int yxyx(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.r); }
		public static Vector4Int zxyx(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.r); }
		public static Vector4Int wxyx(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.r); }
		public static Vector4Int xyyx(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.r); }
		public static Vector4Int yyyx(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.r); }
		public static Vector4Int zyyx(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.r); }
		public static Vector4Int wyyx(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.r); }
		public static Vector4Int xzyx(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.r); }
		public static Vector4Int yzyx(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.r); }
		public static Vector4Int zzyx(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.r); }
		public static Vector4Int wzyx(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.r); }
		public static Vector4Int wzyx(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.wzyx(); }
		public static Vector4Int xwyx(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.r); }
		public static Vector4Int ywyx(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.r); }
		public static Vector4Int zwyx(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.r); }
		public static Vector4Int zwyx(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.zwyx(); }
		public static Vector4Int wwyx(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.r); }
		public static Vector4Int xxzx(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.r); }
		public static Vector4Int yxzx(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.r); }
		public static Vector4Int zxzx(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.r); }
		public static Vector4Int wxzx(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.r); }
		public static Vector4Int xyzx(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.r); }
		public static Vector4Int yyzx(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.r); }
		public static Vector4Int zyzx(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.r); }
		public static Vector4Int wyzx(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.r); }
		public static Vector4Int wyzx(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.wyzx(); }
		public static Vector4Int xzzx(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.r); }
		public static Vector4Int yzzx(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.r); }
		public static Vector4Int zzzx(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.r); }
		public static Vector4Int wzzx(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.r); }
		public static Vector4Int xwzx(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.r); }
		public static Vector4Int ywzx(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.r); }
		public static Vector4Int ywzx(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.ywzx(); }
		public static Vector4Int zwzx(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.r); }
		public static Vector4Int wwzx(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.r); }
		public static Vector4Int xxwx(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.r); }
		public static Vector4Int yxwx(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.r); }
		public static Vector4Int zxwx(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.r); }
		public static Vector4Int wxwx(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.r); }
		public static Vector4Int xywx(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.r); }
		public static Vector4Int yywx(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.r); }
		public static Vector4Int zywx(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.r); }
		public static Vector4Int zywx(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.zywx(); }
		public static Vector4Int wywx(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.r); }
		public static Vector4Int xzwx(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.r); }
		public static Vector4Int yzwx(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.r); }
		public static Vector4Int yzwx(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.yzwx(); }
		public static Vector4Int zzwx(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.r); }
		public static Vector4Int wzwx(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.r); }
		public static Vector4Int xwwx(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.r); }
		public static Vector4Int ywwx(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.r); }
		public static Vector4Int zwwx(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.r); }
		public static Vector4Int wwwx(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.r); }
		public static Vector4Int xxxy(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.g); }
		public static Vector4Int yxxy(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.g); }
		public static Vector4Int zxxy(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.g); }
		public static Vector4Int wxxy(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.g); }
		public static Vector4Int xyxy(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.g); }
		public static Vector4Int yyxy(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.g); }
		public static Vector4Int zyxy(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.g); }
		public static Vector4Int wyxy(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.g); }
		public static Vector4Int xzxy(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.g); }
		public static Vector4Int yzxy(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.g); }
		public static Vector4Int zzxy(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.g); }
		public static Vector4Int wzxy(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.g); }
		public static Vector4Int wzxy(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.wzxy(); }
		public static Vector4Int xwxy(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.g); }
		public static Vector4Int ywxy(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.g); }
		public static Vector4Int zwxy(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.g); }
		public static Vector4Int zwxy(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.zwxy(); }
		public static Vector4Int wwxy(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.g); }
		public static Vector4Int xxyy(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.g); }
		public static Vector4Int yxyy(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.g); }
		public static Vector4Int zxyy(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.g); }
		public static Vector4Int wxyy(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.g); }
		public static Vector4Int xyyy(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.g); }
		public static Vector4Int yyyy(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.g); }
		public static Vector4Int zyyy(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.g); }
		public static Vector4Int wyyy(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.g); }
		public static Vector4Int xzyy(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.g); }
		public static Vector4Int yzyy(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.g); }
		public static Vector4Int zzyy(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.g); }
		public static Vector4Int wzyy(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.g); }
		public static Vector4Int xwyy(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.g); }
		public static Vector4Int ywyy(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.g); }
		public static Vector4Int zwyy(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.g); }
		public static Vector4Int wwyy(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.g); }
		public static Vector4Int xxzy(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.g); }
		public static Vector4Int yxzy(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.g); }
		public static Vector4Int zxzy(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.g); }
		public static Vector4Int wxzy(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.g); }
		public static Vector4Int wxzy(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.wxzy(); }
		public static Vector4Int xyzy(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.g); }
		public static Vector4Int yyzy(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.g); }
		public static Vector4Int zyzy(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.g); }
		public static Vector4Int wyzy(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.g); }
		public static Vector4Int xzzy(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.g); }
		public static Vector4Int yzzy(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.g); }
		public static Vector4Int zzzy(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.g); }
		public static Vector4Int wzzy(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.g); }
		public static Vector4Int xwzy(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.g); }
		public static Vector4Int xwzy(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.xwzy(); }
		public static Vector4Int ywzy(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.g); }
		public static Vector4Int zwzy(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.g); }
		public static Vector4Int wwzy(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.g); }
		public static Vector4Int xxwy(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.g); }
		public static Vector4Int yxwy(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.g); }
		public static Vector4Int zxwy(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.g); }
		public static Vector4Int zxwy(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.zxwy(); }
		public static Vector4Int wxwy(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.g); }
		public static Vector4Int xywy(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.g); }
		public static Vector4Int yywy(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.g); }
		public static Vector4Int zywy(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.g); }
		public static Vector4Int wywy(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.g); }
		public static Vector4Int xzwy(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.g); }
		public static Vector4Int xzwy(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.xzwy(); }
		public static Vector4Int yzwy(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.g); }
		public static Vector4Int zzwy(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.g); }
		public static Vector4Int wzwy(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.g); }
		public static Vector4Int xwwy(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.g); }
		public static Vector4Int ywwy(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.g); }
		public static Vector4Int zwwy(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.g); }
		public static Vector4Int wwwy(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.g); }
		public static Vector4Int xxxz(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.b); }
		public static Vector4Int yxxz(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.b); }
		public static Vector4Int zxxz(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.b); }
		public static Vector4Int wxxz(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.b); }
		public static Vector4Int xyxz(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.b); }
		public static Vector4Int yyxz(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.b); }
		public static Vector4Int zyxz(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.b); }
		public static Vector4Int wyxz(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.b); }
		public static Vector4Int wyxz(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.wyxz(); }
		public static Vector4Int xzxz(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.b); }
		public static Vector4Int yzxz(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.b); }
		public static Vector4Int zzxz(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.b); }
		public static Vector4Int wzxz(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.b); }
		public static Vector4Int xwxz(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.b); }
		public static Vector4Int ywxz(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.b); }
		public static Vector4Int ywxz(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.ywxz(); }
		public static Vector4Int zwxz(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.b); }
		public static Vector4Int wwxz(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.b); }
		public static Vector4Int xxyz(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.b); }
		public static Vector4Int yxyz(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.b); }
		public static Vector4Int zxyz(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.b); }
		public static Vector4Int wxyz(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.b); }
		public static Vector4Int wxyz(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.wxyz(); }
		public static Vector4Int xyyz(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.b); }
		public static Vector4Int yyyz(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.b); }
		public static Vector4Int zyyz(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.b); }
		public static Vector4Int wyyz(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.b); }
		public static Vector4Int xzyz(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.b); }
		public static Vector4Int yzyz(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.b); }
		public static Vector4Int zzyz(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.b); }
		public static Vector4Int wzyz(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.b); }
		public static Vector4Int xwyz(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.b); }
		public static Vector4Int xwyz(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.xwyz(); }
		public static Vector4Int ywyz(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.b); }
		public static Vector4Int zwyz(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.b); }
		public static Vector4Int wwyz(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.b); }
		public static Vector4Int xxzz(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.b); }
		public static Vector4Int yxzz(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.b); }
		public static Vector4Int zxzz(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.b); }
		public static Vector4Int wxzz(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.b); }
		public static Vector4Int xyzz(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.b); }
		public static Vector4Int yyzz(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.b); }
		public static Vector4Int zyzz(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.b); }
		public static Vector4Int wyzz(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.b); }
		public static Vector4Int xzzz(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.b); }
		public static Vector4Int yzzz(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.b); }
		public static Vector4Int zzzz(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.b); }
		public static Vector4Int wzzz(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.b); }
		public static Vector4Int xwzz(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.b); }
		public static Vector4Int ywzz(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.b); }
		public static Vector4Int zwzz(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.b); }
		public static Vector4Int wwzz(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.b); }
		public static Vector4Int xxwz(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.b); }
		public static Vector4Int yxwz(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.b); }
		public static Vector4Int yxwz(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.yxwz(); }
		public static Vector4Int zxwz(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.b); }
		public static Vector4Int wxwz(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.b); }
		public static Vector4Int xywz(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.b); }
		public static Vector4Int xywz(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.xywz(); }
		public static Vector4Int yywz(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.b); }
		public static Vector4Int zywz(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.b); }
		public static Vector4Int wywz(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.b); }
		public static Vector4Int xzwz(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.b); }
		public static Vector4Int yzwz(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.b); }
		public static Vector4Int zzwz(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.b); }
		public static Vector4Int wzwz(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.b); }
		public static Vector4Int xwwz(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.b); }
		public static Vector4Int ywwz(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.b); }
		public static Vector4Int zwwz(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.b); }
		public static Vector4Int wwwz(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.b); }
		public static Vector4Int xxxw(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.a); }
		public static Vector4Int yxxw(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.a); }
		public static Vector4Int zxxw(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.a); }
		public static Vector4Int wxxw(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.a); }
		public static Vector4Int xyxw(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.a); }
		public static Vector4Int yyxw(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.a); }
		public static Vector4Int zyxw(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.a); }
		public static Vector4Int zyxw(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.zyxw(); }
		public static Vector4Int wyxw(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.a); }
		public static Vector4Int xzxw(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.a); }
		public static Vector4Int yzxw(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.a); }
		public static Vector4Int yzxw(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.yzxw(); }
		public static Vector4Int zzxw(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.a); }
		public static Vector4Int wzxw(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.a); }
		public static Vector4Int xwxw(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.a); }
		public static Vector4Int ywxw(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.a); }
		public static Vector4Int zwxw(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.a); }
		public static Vector4Int wwxw(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.a); }
		public static Vector4Int xxyw(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.a); }
		public static Vector4Int yxyw(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.a); }
		public static Vector4Int zxyw(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.a); }
		public static Vector4Int zxyw(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.zxyw(); }
		public static Vector4Int wxyw(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.a); }
		public static Vector4Int xyyw(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.a); }
		public static Vector4Int yyyw(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.a); }
		public static Vector4Int zyyw(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.a); }
		public static Vector4Int wyyw(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.a); }
		public static Vector4Int xzyw(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.a); }
		public static Vector4Int xzyw(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.xzyw(); }
		public static Vector4Int yzyw(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.a); }
		public static Vector4Int zzyw(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.a); }
		public static Vector4Int wzyw(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.a); }
		public static Vector4Int xwyw(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.a); }
		public static Vector4Int ywyw(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.a); }
		public static Vector4Int zwyw(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.a); }
		public static Vector4Int wwyw(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.a); }
		public static Vector4Int xxzw(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.a); }
		public static Vector4Int yxzw(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.a); }
		public static Vector4Int yxzw(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.yxzw(); }
		public static Vector4Int zxzw(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.a); }
		public static Vector4Int wxzw(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.a); }
		public static Vector4Int xyzw(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.a); }
		public static Vector4Int xyzw(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.xyzw(); }
		public static Vector4Int yyzw(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.a); }
		public static Vector4Int zyzw(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.a); }
		public static Vector4Int wyzw(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.a); }
		public static Vector4Int xzzw(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.a); }
		public static Vector4Int yzzw(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.a); }
		public static Vector4Int zzzw(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.a); }
		public static Vector4Int wzzw(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.a); }
		public static Vector4Int xwzw(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.a); }
		public static Vector4Int ywzw(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.a); }
		public static Vector4Int zwzw(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.a); }
		public static Vector4Int wwzw(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.a); }
		public static Vector4Int xxww(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.a); }
		public static Vector4Int yxww(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.a); }
		public static Vector4Int zxww(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.a); }
		public static Vector4Int wxww(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.a); }
		public static Vector4Int xyww(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.a); }
		public static Vector4Int yyww(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.a); }
		public static Vector4Int zyww(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.a); }
		public static Vector4Int wyww(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.a); }
		public static Vector4Int xzww(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.a); }
		public static Vector4Int yzww(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.a); }
		public static Vector4Int zzww(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.a); }
		public static Vector4Int wzww(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.a); }
		public static Vector4Int xwww(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.a); }
		public static Vector4Int ywww(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.a); }
		public static Vector4Int zwww(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.a); }
		public static Vector4Int wwww(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.a); }
	}

	public static class Color32rgbaSwizzleExtension
	{
		// Color32 with 1 components.
		public static byte r(this Color32 v) { return v.r; }
		public static byte r(this Color32 v, byte other) { v.r = other; return v.r(); }
		public static byte g(this Color32 v) { return v.g; }
		public static byte g(this Color32 v, byte other) { v.g = other; return v.g(); }
		public static byte b(this Color32 v) { return v.b; }
		public static byte b(this Color32 v, byte other) { v.b = other; return v.b(); }
		public static byte a(this Color32 v) { return v.a; }
		public static byte a(this Color32 v, byte other) { v.a = other; return v.a(); }

		// Color32 with 2 components.
		public static Vector2Int rr(this Color32 v) { return new Vector2Int(v.r, v.r); }
		public static Vector2Int gr(this Color32 v) { return new Vector2Int(v.g, v.r); }
		public static Vector2Int gr(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.r = (byte)other.g(); return v.gr(); }
		public static Vector2Int br(this Color32 v) { return new Vector2Int(v.b, v.r); }
		public static Vector2Int br(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.r = (byte)other.g(); return v.br(); }
		public static Vector2Int ar(this Color32 v) { return new Vector2Int(v.a, v.r); }
		public static Vector2Int ar(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.r = (byte)other.g(); return v.ar(); }
		public static Vector2Int rg(this Color32 v) { return new Vector2Int(v.r, v.g); }
		public static Vector2Int rg(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.g = (byte)other.g(); return v.rg(); }
		public static Vector2Int gg(this Color32 v) { return new Vector2Int(v.g, v.g); }
		public static Vector2Int bg(this Color32 v) { return new Vector2Int(v.b, v.g); }
		public static Vector2Int bg(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.g = (byte)other.g(); return v.bg(); }
		public static Vector2Int ag(this Color32 v) { return new Vector2Int(v.a, v.g); }
		public static Vector2Int ag(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.g = (byte)other.g(); return v.ag(); }
		public static Vector2Int rb(this Color32 v) { return new Vector2Int(v.r, v.b); }
		public static Vector2Int rb(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.b = (byte)other.g(); return v.rb(); }
		public static Vector2Int gb(this Color32 v) { return new Vector2Int(v.g, v.b); }
		public static Vector2Int gb(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.b = (byte)other.g(); return v.gb(); }
		public static Vector2Int bb(this Color32 v) { return new Vector2Int(v.b, v.b); }
		public static Vector2Int ab(this Color32 v) { return new Vector2Int(v.a, v.b); }
		public static Vector2Int ab(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.b = (byte)other.g(); return v.ab(); }
		public static Vector2Int ra(this Color32 v) { return new Vector2Int(v.r, v.a); }
		public static Vector2Int ra(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.a = (byte)other.g(); return v.ra(); }
		public static Vector2Int ga(this Color32 v) { return new Vector2Int(v.g, v.a); }
		public static Vector2Int ga(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.a = (byte)other.g(); return v.ga(); }
		public static Vector2Int ba(this Color32 v) { return new Vector2Int(v.b, v.a); }
		public static Vector2Int ba(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.a = (byte)other.g(); return v.ba(); }
		public static Vector2Int aa(this Color32 v) { return new Vector2Int(v.a, v.a); }

		// Color32 with 3 components.
		public static Vector3Int rrr(this Color32 v) { return new Vector3Int(v.r, v.r, v.r); }
		public static Vector3Int grr(this Color32 v) { return new Vector3Int(v.g, v.r, v.r); }
		public static Vector3Int brr(this Color32 v) { return new Vector3Int(v.b, v.r, v.r); }
		public static Vector3Int arr(this Color32 v) { return new Vector3Int(v.a, v.r, v.r); }
		public static Vector3Int rgr(this Color32 v) { return new Vector3Int(v.r, v.g, v.r); }
		public static Vector3Int ggr(this Color32 v) { return new Vector3Int(v.g, v.g, v.r); }
		public static Vector3Int bgr(this Color32 v) { return new Vector3Int(v.b, v.g, v.r); }
		public static Vector3Int bgr(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.bgr(); }
		public static Vector3Int agr(this Color32 v) { return new Vector3Int(v.a, v.g, v.r); }
		public static Vector3Int agr(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.agr(); }
		public static Vector3Int rbr(this Color32 v) { return new Vector3Int(v.r, v.b, v.r); }
		public static Vector3Int gbr(this Color32 v) { return new Vector3Int(v.g, v.b, v.r); }
		public static Vector3Int gbr(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.gbr(); }
		public static Vector3Int bbr(this Color32 v) { return new Vector3Int(v.b, v.b, v.r); }
		public static Vector3Int abr(this Color32 v) { return new Vector3Int(v.a, v.b, v.r); }
		public static Vector3Int abr(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.abr(); }
		public static Vector3Int rar(this Color32 v) { return new Vector3Int(v.r, v.a, v.r); }
		public static Vector3Int gar(this Color32 v) { return new Vector3Int(v.g, v.a, v.r); }
		public static Vector3Int gar(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.gar(); }
		public static Vector3Int bar(this Color32 v) { return new Vector3Int(v.b, v.a, v.r); }
		public static Vector3Int bar(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.bar(); }
		public static Vector3Int aar(this Color32 v) { return new Vector3Int(v.a, v.a, v.r); }
		public static Vector3Int rrg(this Color32 v) { return new Vector3Int(v.r, v.r, v.g); }
		public static Vector3Int grg(this Color32 v) { return new Vector3Int(v.g, v.r, v.g); }
		public static Vector3Int brg(this Color32 v) { return new Vector3Int(v.b, v.r, v.g); }
		public static Vector3Int brg(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.brg(); }
		public static Vector3Int arg(this Color32 v) { return new Vector3Int(v.a, v.r, v.g); }
		public static Vector3Int arg(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.arg(); }
		public static Vector3Int rgg(this Color32 v) { return new Vector3Int(v.r, v.g, v.g); }
		public static Vector3Int ggg(this Color32 v) { return new Vector3Int(v.g, v.g, v.g); }
		public static Vector3Int bgg(this Color32 v) { return new Vector3Int(v.b, v.g, v.g); }
		public static Vector3Int agg(this Color32 v) { return new Vector3Int(v.a, v.g, v.g); }
		public static Vector3Int rbg(this Color32 v) { return new Vector3Int(v.r, v.b, v.g); }
		public static Vector3Int rbg(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.rbg(); }
		public static Vector3Int gbg(this Color32 v) { return new Vector3Int(v.g, v.b, v.g); }
		public static Vector3Int bbg(this Color32 v) { return new Vector3Int(v.b, v.b, v.g); }
		public static Vector3Int abg(this Color32 v) { return new Vector3Int(v.a, v.b, v.g); }
		public static Vector3Int abg(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.abg(); }
		public static Vector3Int rag(this Color32 v) { return new Vector3Int(v.r, v.a, v.g); }
		public static Vector3Int rag(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.rag(); }
		public static Vector3Int gag(this Color32 v) { return new Vector3Int(v.g, v.a, v.g); }
		public static Vector3Int bag(this Color32 v) { return new Vector3Int(v.b, v.a, v.g); }
		public static Vector3Int bag(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.bag(); }
		public static Vector3Int aag(this Color32 v) { return new Vector3Int(v.a, v.a, v.g); }
		public static Vector3Int rrb(this Color32 v) { return new Vector3Int(v.r, v.r, v.b); }
		public static Vector3Int grb(this Color32 v) { return new Vector3Int(v.g, v.r, v.b); }
		public static Vector3Int grb(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.grb(); }
		public static Vector3Int brb(this Color32 v) { return new Vector3Int(v.b, v.r, v.b); }
		public static Vector3Int arb(this Color32 v) { return new Vector3Int(v.a, v.r, v.b); }
		public static Vector3Int arb(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.arb(); }
		public static Vector3Int rgb(this Color32 v) { return new Vector3Int(v.r, v.g, v.b); }
		public static Vector3Int rgb(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.rgb(); }
		public static Vector3Int ggb(this Color32 v) { return new Vector3Int(v.g, v.g, v.b); }
		public static Vector3Int bgb(this Color32 v) { return new Vector3Int(v.b, v.g, v.b); }
		public static Vector3Int agb(this Color32 v) { return new Vector3Int(v.a, v.g, v.b); }
		public static Vector3Int agb(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.agb(); }
		public static Vector3Int rbb(this Color32 v) { return new Vector3Int(v.r, v.b, v.b); }
		public static Vector3Int gbb(this Color32 v) { return new Vector3Int(v.g, v.b, v.b); }
		public static Vector3Int bbb(this Color32 v) { return new Vector3Int(v.b, v.b, v.b); }
		public static Vector3Int abb(this Color32 v) { return new Vector3Int(v.a, v.b, v.b); }
		public static Vector3Int rab(this Color32 v) { return new Vector3Int(v.r, v.a, v.b); }
		public static Vector3Int rab(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.rab(); }
		public static Vector3Int gab(this Color32 v) { return new Vector3Int(v.g, v.a, v.b); }
		public static Vector3Int gab(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.gab(); }
		public static Vector3Int bab(this Color32 v) { return new Vector3Int(v.b, v.a, v.b); }
		public static Vector3Int aab(this Color32 v) { return new Vector3Int(v.a, v.a, v.b); }
		public static Vector3Int rra(this Color32 v) { return new Vector3Int(v.r, v.r, v.a); }
		public static Vector3Int gra(this Color32 v) { return new Vector3Int(v.g, v.r, v.a); }
		public static Vector3Int gra(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.gra(); }
		public static Vector3Int bra(this Color32 v) { return new Vector3Int(v.b, v.r, v.a); }
		public static Vector3Int bra(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.bra(); }
		public static Vector3Int ara(this Color32 v) { return new Vector3Int(v.a, v.r, v.a); }
		public static Vector3Int rga(this Color32 v) { return new Vector3Int(v.r, v.g, v.a); }
		public static Vector3Int rga(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.rga(); }
		public static Vector3Int gga(this Color32 v) { return new Vector3Int(v.g, v.g, v.a); }
		public static Vector3Int bga(this Color32 v) { return new Vector3Int(v.b, v.g, v.a); }
		public static Vector3Int bga(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.bga(); }
		public static Vector3Int aga(this Color32 v) { return new Vector3Int(v.a, v.g, v.a); }
		public static Vector3Int rba(this Color32 v) { return new Vector3Int(v.r, v.b, v.a); }
		public static Vector3Int rba(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.rba(); }
		public static Vector3Int gba(this Color32 v) { return new Vector3Int(v.g, v.b, v.a); }
		public static Vector3Int gba(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.gba(); }
		public static Vector3Int bba(this Color32 v) { return new Vector3Int(v.b, v.b, v.a); }
		public static Vector3Int aba(this Color32 v) { return new Vector3Int(v.a, v.b, v.a); }
		public static Vector3Int raa(this Color32 v) { return new Vector3Int(v.r, v.a, v.a); }
		public static Vector3Int gaa(this Color32 v) { return new Vector3Int(v.g, v.a, v.a); }
		public static Vector3Int baa(this Color32 v) { return new Vector3Int(v.b, v.a, v.a); }
		public static Vector3Int aaa(this Color32 v) { return new Vector3Int(v.a, v.a, v.a); }

		// Color32 with 4 components.
		public static Vector4Int rrrr(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.r); }
		public static Vector4Int grrr(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.r); }
		public static Vector4Int brrr(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.r); }
		public static Vector4Int arrr(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.r); }
		public static Vector4Int rgrr(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.r); }
		public static Vector4Int ggrr(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.r); }
		public static Vector4Int bgrr(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.r); }
		public static Vector4Int agrr(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.r); }
		public static Vector4Int rbrr(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.r); }
		public static Vector4Int gbrr(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.r); }
		public static Vector4Int bbrr(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.r); }
		public static Vector4Int abrr(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.r); }
		public static Vector4Int rarr(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.r); }
		public static Vector4Int garr(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.r); }
		public static Vector4Int barr(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.r); }
		public static Vector4Int aarr(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.r); }
		public static Vector4Int rrgr(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.r); }
		public static Vector4Int grgr(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.r); }
		public static Vector4Int brgr(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.r); }
		public static Vector4Int argr(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.r); }
		public static Vector4Int rggr(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.r); }
		public static Vector4Int gggr(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.r); }
		public static Vector4Int bggr(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.r); }
		public static Vector4Int aggr(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.r); }
		public static Vector4Int rbgr(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.r); }
		public static Vector4Int gbgr(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.r); }
		public static Vector4Int bbgr(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.r); }
		public static Vector4Int abgr(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.r); }
		public static Vector4Int abgr(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.abgr(); }
		public static Vector4Int ragr(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.r); }
		public static Vector4Int gagr(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.r); }
		public static Vector4Int bagr(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.r); }
		public static Vector4Int bagr(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.bagr(); }
		public static Vector4Int aagr(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.r); }
		public static Vector4Int rrbr(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.r); }
		public static Vector4Int grbr(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.r); }
		public static Vector4Int brbr(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.r); }
		public static Vector4Int arbr(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.r); }
		public static Vector4Int rgbr(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.r); }
		public static Vector4Int ggbr(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.r); }
		public static Vector4Int bgbr(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.r); }
		public static Vector4Int agbr(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.r); }
		public static Vector4Int agbr(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.agbr(); }
		public static Vector4Int rbbr(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.r); }
		public static Vector4Int gbbr(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.r); }
		public static Vector4Int bbbr(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.r); }
		public static Vector4Int abbr(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.r); }
		public static Vector4Int rabr(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.r); }
		public static Vector4Int gabr(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.r); }
		public static Vector4Int gabr(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.gabr(); }
		public static Vector4Int babr(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.r); }
		public static Vector4Int aabr(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.r); }
		public static Vector4Int rrar(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.r); }
		public static Vector4Int grar(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.r); }
		public static Vector4Int brar(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.r); }
		public static Vector4Int arar(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.r); }
		public static Vector4Int rgar(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.r); }
		public static Vector4Int ggar(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.r); }
		public static Vector4Int bgar(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.r); }
		public static Vector4Int bgar(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.bgar(); }
		public static Vector4Int agar(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.r); }
		public static Vector4Int rbar(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.r); }
		public static Vector4Int gbar(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.r); }
		public static Vector4Int gbar(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.gbar(); }
		public static Vector4Int bbar(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.r); }
		public static Vector4Int abar(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.r); }
		public static Vector4Int raar(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.r); }
		public static Vector4Int gaar(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.r); }
		public static Vector4Int baar(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.r); }
		public static Vector4Int aaar(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.r); }
		public static Vector4Int rrrg(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.g); }
		public static Vector4Int grrg(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.g); }
		public static Vector4Int brrg(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.g); }
		public static Vector4Int arrg(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.g); }
		public static Vector4Int rgrg(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.g); }
		public static Vector4Int ggrg(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.g); }
		public static Vector4Int bgrg(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.g); }
		public static Vector4Int agrg(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.g); }
		public static Vector4Int rbrg(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.g); }
		public static Vector4Int gbrg(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.g); }
		public static Vector4Int bbrg(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.g); }
		public static Vector4Int abrg(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.g); }
		public static Vector4Int abrg(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.abrg(); }
		public static Vector4Int rarg(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.g); }
		public static Vector4Int garg(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.g); }
		public static Vector4Int barg(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.g); }
		public static Vector4Int barg(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.barg(); }
		public static Vector4Int aarg(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.g); }
		public static Vector4Int rrgg(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.g); }
		public static Vector4Int grgg(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.g); }
		public static Vector4Int brgg(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.g); }
		public static Vector4Int argg(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.g); }
		public static Vector4Int rggg(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.g); }
		public static Vector4Int gggg(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.g); }
		public static Vector4Int bggg(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.g); }
		public static Vector4Int aggg(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.g); }
		public static Vector4Int rbgg(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.g); }
		public static Vector4Int gbgg(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.g); }
		public static Vector4Int bbgg(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.g); }
		public static Vector4Int abgg(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.g); }
		public static Vector4Int ragg(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.g); }
		public static Vector4Int gagg(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.g); }
		public static Vector4Int bagg(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.g); }
		public static Vector4Int aagg(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.g); }
		public static Vector4Int rrbg(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.g); }
		public static Vector4Int grbg(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.g); }
		public static Vector4Int brbg(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.g); }
		public static Vector4Int arbg(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.g); }
		public static Vector4Int arbg(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.arbg(); }
		public static Vector4Int rgbg(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.g); }
		public static Vector4Int ggbg(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.g); }
		public static Vector4Int bgbg(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.g); }
		public static Vector4Int agbg(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.g); }
		public static Vector4Int rbbg(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.g); }
		public static Vector4Int gbbg(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.g); }
		public static Vector4Int bbbg(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.g); }
		public static Vector4Int abbg(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.g); }
		public static Vector4Int rabg(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.g); }
		public static Vector4Int rabg(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.rabg(); }
		public static Vector4Int gabg(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.g); }
		public static Vector4Int babg(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.g); }
		public static Vector4Int aabg(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.g); }
		public static Vector4Int rrag(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.g); }
		public static Vector4Int grag(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.g); }
		public static Vector4Int brag(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.g); }
		public static Vector4Int brag(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.brag(); }
		public static Vector4Int arag(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.g); }
		public static Vector4Int rgag(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.g); }
		public static Vector4Int ggag(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.g); }
		public static Vector4Int bgag(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.g); }
		public static Vector4Int agag(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.g); }
		public static Vector4Int rbag(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.g); }
		public static Vector4Int rbag(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.rbag(); }
		public static Vector4Int gbag(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.g); }
		public static Vector4Int bbag(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.g); }
		public static Vector4Int abag(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.g); }
		public static Vector4Int raag(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.g); }
		public static Vector4Int gaag(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.g); }
		public static Vector4Int baag(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.g); }
		public static Vector4Int aaag(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.g); }
		public static Vector4Int rrrb(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.b); }
		public static Vector4Int grrb(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.b); }
		public static Vector4Int brrb(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.b); }
		public static Vector4Int arrb(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.b); }
		public static Vector4Int rgrb(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.b); }
		public static Vector4Int ggrb(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.b); }
		public static Vector4Int bgrb(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.b); }
		public static Vector4Int agrb(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.b); }
		public static Vector4Int agrb(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.agrb(); }
		public static Vector4Int rbrb(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.b); }
		public static Vector4Int gbrb(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.b); }
		public static Vector4Int bbrb(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.b); }
		public static Vector4Int abrb(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.b); }
		public static Vector4Int rarb(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.b); }
		public static Vector4Int garb(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.b); }
		public static Vector4Int garb(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.garb(); }
		public static Vector4Int barb(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.b); }
		public static Vector4Int aarb(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.b); }
		public static Vector4Int rrgb(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.b); }
		public static Vector4Int grgb(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.b); }
		public static Vector4Int brgb(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.b); }
		public static Vector4Int argb(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.b); }
		public static Vector4Int argb(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.argb(); }
		public static Vector4Int rggb(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.b); }
		public static Vector4Int gggb(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.b); }
		public static Vector4Int bggb(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.b); }
		public static Vector4Int aggb(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.b); }
		public static Vector4Int rbgb(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.b); }
		public static Vector4Int gbgb(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.b); }
		public static Vector4Int bbgb(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.b); }
		public static Vector4Int abgb(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.b); }
		public static Vector4Int ragb(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.b); }
		public static Vector4Int ragb(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.ragb(); }
		public static Vector4Int gagb(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.b); }
		public static Vector4Int bagb(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.b); }
		public static Vector4Int aagb(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.b); }
		public static Vector4Int rrbb(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.b); }
		public static Vector4Int grbb(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.b); }
		public static Vector4Int brbb(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.b); }
		public static Vector4Int arbb(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.b); }
		public static Vector4Int rgbb(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.b); }
		public static Vector4Int ggbb(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.b); }
		public static Vector4Int bgbb(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.b); }
		public static Vector4Int agbb(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.b); }
		public static Vector4Int rbbb(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.b); }
		public static Vector4Int gbbb(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.b); }
		public static Vector4Int bbbb(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.b); }
		public static Vector4Int abbb(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.b); }
		public static Vector4Int rabb(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.b); }
		public static Vector4Int gabb(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.b); }
		public static Vector4Int babb(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.b); }
		public static Vector4Int aabb(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.b); }
		public static Vector4Int rrab(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.b); }
		public static Vector4Int grab(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.b); }
		public static Vector4Int grab(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.grab(); }
		public static Vector4Int brab(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.b); }
		public static Vector4Int arab(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.b); }
		public static Vector4Int rgab(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.b); }
		public static Vector4Int rgab(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.rgab(); }
		public static Vector4Int ggab(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.b); }
		public static Vector4Int bgab(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.b); }
		public static Vector4Int agab(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.b); }
		public static Vector4Int rbab(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.b); }
		public static Vector4Int gbab(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.b); }
		public static Vector4Int bbab(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.b); }
		public static Vector4Int abab(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.b); }
		public static Vector4Int raab(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.b); }
		public static Vector4Int gaab(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.b); }
		public static Vector4Int baab(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.b); }
		public static Vector4Int aaab(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.b); }
		public static Vector4Int rrra(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.a); }
		public static Vector4Int grra(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.a); }
		public static Vector4Int brra(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.a); }
		public static Vector4Int arra(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.a); }
		public static Vector4Int rgra(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.a); }
		public static Vector4Int ggra(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.a); }
		public static Vector4Int bgra(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.a); }
		public static Vector4Int bgra(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.bgra(); }
		public static Vector4Int agra(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.a); }
		public static Vector4Int rbra(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.a); }
		public static Vector4Int gbra(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.a); }
		public static Vector4Int gbra(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.gbra(); }
		public static Vector4Int bbra(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.a); }
		public static Vector4Int abra(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.a); }
		public static Vector4Int rara(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.a); }
		public static Vector4Int gara(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.a); }
		public static Vector4Int bara(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.a); }
		public static Vector4Int aara(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.a); }
		public static Vector4Int rrga(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.a); }
		public static Vector4Int grga(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.a); }
		public static Vector4Int brga(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.a); }
		public static Vector4Int brga(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.brga(); }
		public static Vector4Int arga(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.a); }
		public static Vector4Int rgga(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.a); }
		public static Vector4Int ggga(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.a); }
		public static Vector4Int bgga(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.a); }
		public static Vector4Int agga(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.a); }
		public static Vector4Int rbga(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.a); }
		public static Vector4Int rbga(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.rbga(); }
		public static Vector4Int gbga(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.a); }
		public static Vector4Int bbga(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.a); }
		public static Vector4Int abga(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.a); }
		public static Vector4Int raga(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.a); }
		public static Vector4Int gaga(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.a); }
		public static Vector4Int baga(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.a); }
		public static Vector4Int aaga(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.a); }
		public static Vector4Int rrba(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.a); }
		public static Vector4Int grba(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.a); }
		public static Vector4Int grba(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.grba(); }
		public static Vector4Int brba(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.a); }
		public static Vector4Int arba(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.a); }
		public static Vector4Int rgba(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.a); }
		public static Vector4Int rgba(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.rgba(); }
		public static Vector4Int ggba(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.a); }
		public static Vector4Int bgba(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.a); }
		public static Vector4Int agba(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.a); }
		public static Vector4Int rbba(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.a); }
		public static Vector4Int gbba(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.a); }
		public static Vector4Int bbba(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.a); }
		public static Vector4Int abba(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.a); }
		public static Vector4Int raba(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.a); }
		public static Vector4Int gaba(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.a); }
		public static Vector4Int baba(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.a); }
		public static Vector4Int aaba(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.a); }
		public static Vector4Int rraa(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.a); }
		public static Vector4Int graa(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.a); }
		public static Vector4Int braa(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.a); }
		public static Vector4Int araa(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.a); }
		public static Vector4Int rgaa(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.a); }
		public static Vector4Int ggaa(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.a); }
		public static Vector4Int bgaa(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.a); }
		public static Vector4Int agaa(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.a); }
		public static Vector4Int rbaa(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.a); }
		public static Vector4Int gbaa(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.a); }
		public static Vector4Int bbaa(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.a); }
		public static Vector4Int abaa(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.a); }
		public static Vector4Int raaa(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.a); }
		public static Vector4Int gaaa(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.a); }
		public static Vector4Int baaa(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.a); }
		public static Vector4Int aaaa(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.a); }
	}

	public static class Color32stpqSwizzleExtension
	{
		// Color32 with 1 components.
		public static byte s(this Color32 v) { return v.r; }
		public static byte s(this Color32 v, byte other) { v.r = other; return v.s(); }
		public static byte t(this Color32 v) { return v.g; }
		public static byte t(this Color32 v, byte other) { v.g = other; return v.t(); }
		public static byte p(this Color32 v) { return v.b; }
		public static byte p(this Color32 v, byte other) { v.b = other; return v.p(); }
		public static byte q(this Color32 v) { return v.a; }
		public static byte q(this Color32 v, byte other) { v.a = other; return v.q(); }

		// Color32 with 2 components.
		public static Vector2Int ss(this Color32 v) { return new Vector2Int(v.r, v.r); }
		public static Vector2Int ts(this Color32 v) { return new Vector2Int(v.g, v.r); }
		public static Vector2Int ts(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.r = (byte)other.g(); return v.ts(); }
		public static Vector2Int ps(this Color32 v) { return new Vector2Int(v.b, v.r); }
		public static Vector2Int ps(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.r = (byte)other.g(); return v.ps(); }
		public static Vector2Int qs(this Color32 v) { return new Vector2Int(v.a, v.r); }
		public static Vector2Int qs(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.r = (byte)other.g(); return v.qs(); }
		public static Vector2Int st(this Color32 v) { return new Vector2Int(v.r, v.g); }
		public static Vector2Int st(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.g = (byte)other.g(); return v.st(); }
		public static Vector2Int tt(this Color32 v) { return new Vector2Int(v.g, v.g); }
		public static Vector2Int pt(this Color32 v) { return new Vector2Int(v.b, v.g); }
		public static Vector2Int pt(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.g = (byte)other.g(); return v.pt(); }
		public static Vector2Int qt(this Color32 v) { return new Vector2Int(v.a, v.g); }
		public static Vector2Int qt(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.g = (byte)other.g(); return v.qt(); }
		public static Vector2Int sp(this Color32 v) { return new Vector2Int(v.r, v.b); }
		public static Vector2Int sp(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.b = (byte)other.g(); return v.sp(); }
		public static Vector2Int tp(this Color32 v) { return new Vector2Int(v.g, v.b); }
		public static Vector2Int tp(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.b = (byte)other.g(); return v.tp(); }
		public static Vector2Int pp(this Color32 v) { return new Vector2Int(v.b, v.b); }
		public static Vector2Int qp(this Color32 v) { return new Vector2Int(v.a, v.b); }
		public static Vector2Int qp(this Color32 v, Vector2Int other) { v.a = (byte)other.r();v.b = (byte)other.g(); return v.qp(); }
		public static Vector2Int sq(this Color32 v) { return new Vector2Int(v.r, v.a); }
		public static Vector2Int sq(this Color32 v, Vector2Int other) { v.r = (byte)other.r();v.a = (byte)other.g(); return v.sq(); }
		public static Vector2Int tq(this Color32 v) { return new Vector2Int(v.g, v.a); }
		public static Vector2Int tq(this Color32 v, Vector2Int other) { v.g = (byte)other.r();v.a = (byte)other.g(); return v.tq(); }
		public static Vector2Int pq(this Color32 v) { return new Vector2Int(v.b, v.a); }
		public static Vector2Int pq(this Color32 v, Vector2Int other) { v.b = (byte)other.r();v.a = (byte)other.g(); return v.pq(); }
		public static Vector2Int qq(this Color32 v) { return new Vector2Int(v.a, v.a); }

		// Color32 with 3 components.
		public static Vector3Int sss(this Color32 v) { return new Vector3Int(v.r, v.r, v.r); }
		public static Vector3Int tss(this Color32 v) { return new Vector3Int(v.g, v.r, v.r); }
		public static Vector3Int pss(this Color32 v) { return new Vector3Int(v.b, v.r, v.r); }
		public static Vector3Int qss(this Color32 v) { return new Vector3Int(v.a, v.r, v.r); }
		public static Vector3Int sts(this Color32 v) { return new Vector3Int(v.r, v.g, v.r); }
		public static Vector3Int tts(this Color32 v) { return new Vector3Int(v.g, v.g, v.r); }
		public static Vector3Int pts(this Color32 v) { return new Vector3Int(v.b, v.g, v.r); }
		public static Vector3Int pts(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.pts(); }
		public static Vector3Int qts(this Color32 v) { return new Vector3Int(v.a, v.g, v.r); }
		public static Vector3Int qts(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b(); return v.qts(); }
		public static Vector3Int sps(this Color32 v) { return new Vector3Int(v.r, v.b, v.r); }
		public static Vector3Int tps(this Color32 v) { return new Vector3Int(v.g, v.b, v.r); }
		public static Vector3Int tps(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.tps(); }
		public static Vector3Int pps(this Color32 v) { return new Vector3Int(v.b, v.b, v.r); }
		public static Vector3Int qps(this Color32 v) { return new Vector3Int(v.a, v.b, v.r); }
		public static Vector3Int qps(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b(); return v.qps(); }
		public static Vector3Int sqs(this Color32 v) { return new Vector3Int(v.r, v.a, v.r); }
		public static Vector3Int tqs(this Color32 v) { return new Vector3Int(v.g, v.a, v.r); }
		public static Vector3Int tqs(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.tqs(); }
		public static Vector3Int pqs(this Color32 v) { return new Vector3Int(v.b, v.a, v.r); }
		public static Vector3Int pqs(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b(); return v.pqs(); }
		public static Vector3Int qqs(this Color32 v) { return new Vector3Int(v.a, v.a, v.r); }
		public static Vector3Int sst(this Color32 v) { return new Vector3Int(v.r, v.r, v.g); }
		public static Vector3Int tst(this Color32 v) { return new Vector3Int(v.g, v.r, v.g); }
		public static Vector3Int pst(this Color32 v) { return new Vector3Int(v.b, v.r, v.g); }
		public static Vector3Int pst(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.pst(); }
		public static Vector3Int qst(this Color32 v) { return new Vector3Int(v.a, v.r, v.g); }
		public static Vector3Int qst(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b(); return v.qst(); }
		public static Vector3Int stt(this Color32 v) { return new Vector3Int(v.r, v.g, v.g); }
		public static Vector3Int ttt(this Color32 v) { return new Vector3Int(v.g, v.g, v.g); }
		public static Vector3Int ptt(this Color32 v) { return new Vector3Int(v.b, v.g, v.g); }
		public static Vector3Int qtt(this Color32 v) { return new Vector3Int(v.a, v.g, v.g); }
		public static Vector3Int spt(this Color32 v) { return new Vector3Int(v.r, v.b, v.g); }
		public static Vector3Int spt(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.spt(); }
		public static Vector3Int tpt(this Color32 v) { return new Vector3Int(v.g, v.b, v.g); }
		public static Vector3Int ppt(this Color32 v) { return new Vector3Int(v.b, v.b, v.g); }
		public static Vector3Int qpt(this Color32 v) { return new Vector3Int(v.a, v.b, v.g); }
		public static Vector3Int qpt(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b(); return v.qpt(); }
		public static Vector3Int sqt(this Color32 v) { return new Vector3Int(v.r, v.a, v.g); }
		public static Vector3Int sqt(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.sqt(); }
		public static Vector3Int tqt(this Color32 v) { return new Vector3Int(v.g, v.a, v.g); }
		public static Vector3Int pqt(this Color32 v) { return new Vector3Int(v.b, v.a, v.g); }
		public static Vector3Int pqt(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b(); return v.pqt(); }
		public static Vector3Int qqt(this Color32 v) { return new Vector3Int(v.a, v.a, v.g); }
		public static Vector3Int ssp(this Color32 v) { return new Vector3Int(v.r, v.r, v.b); }
		public static Vector3Int tsp(this Color32 v) { return new Vector3Int(v.g, v.r, v.b); }
		public static Vector3Int tsp(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.tsp(); }
		public static Vector3Int psp(this Color32 v) { return new Vector3Int(v.b, v.r, v.b); }
		public static Vector3Int qsp(this Color32 v) { return new Vector3Int(v.a, v.r, v.b); }
		public static Vector3Int qsp(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b(); return v.qsp(); }
		public static Vector3Int stp(this Color32 v) { return new Vector3Int(v.r, v.g, v.b); }
		public static Vector3Int stp(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.stp(); }
		public static Vector3Int ttp(this Color32 v) { return new Vector3Int(v.g, v.g, v.b); }
		public static Vector3Int ptp(this Color32 v) { return new Vector3Int(v.b, v.g, v.b); }
		public static Vector3Int qtp(this Color32 v) { return new Vector3Int(v.a, v.g, v.b); }
		public static Vector3Int qtp(this Color32 v, Vector3Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b(); return v.qtp(); }
		public static Vector3Int spp(this Color32 v) { return new Vector3Int(v.r, v.b, v.b); }
		public static Vector3Int tpp(this Color32 v) { return new Vector3Int(v.g, v.b, v.b); }
		public static Vector3Int ppp(this Color32 v) { return new Vector3Int(v.b, v.b, v.b); }
		public static Vector3Int qpp(this Color32 v) { return new Vector3Int(v.a, v.b, v.b); }
		public static Vector3Int sqp(this Color32 v) { return new Vector3Int(v.r, v.a, v.b); }
		public static Vector3Int sqp(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.sqp(); }
		public static Vector3Int tqp(this Color32 v) { return new Vector3Int(v.g, v.a, v.b); }
		public static Vector3Int tqp(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b(); return v.tqp(); }
		public static Vector3Int pqp(this Color32 v) { return new Vector3Int(v.b, v.a, v.b); }
		public static Vector3Int qqp(this Color32 v) { return new Vector3Int(v.a, v.a, v.b); }
		public static Vector3Int ssq(this Color32 v) { return new Vector3Int(v.r, v.r, v.a); }
		public static Vector3Int tsq(this Color32 v) { return new Vector3Int(v.g, v.r, v.a); }
		public static Vector3Int tsq(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.tsq(); }
		public static Vector3Int psq(this Color32 v) { return new Vector3Int(v.b, v.r, v.a); }
		public static Vector3Int psq(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b(); return v.psq(); }
		public static Vector3Int qsq(this Color32 v) { return new Vector3Int(v.a, v.r, v.a); }
		public static Vector3Int stq(this Color32 v) { return new Vector3Int(v.r, v.g, v.a); }
		public static Vector3Int stq(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.stq(); }
		public static Vector3Int ttq(this Color32 v) { return new Vector3Int(v.g, v.g, v.a); }
		public static Vector3Int ptq(this Color32 v) { return new Vector3Int(v.b, v.g, v.a); }
		public static Vector3Int ptq(this Color32 v, Vector3Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b(); return v.ptq(); }
		public static Vector3Int qtq(this Color32 v) { return new Vector3Int(v.a, v.g, v.a); }
		public static Vector3Int spq(this Color32 v) { return new Vector3Int(v.r, v.b, v.a); }
		public static Vector3Int spq(this Color32 v, Vector3Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.spq(); }
		public static Vector3Int tpq(this Color32 v) { return new Vector3Int(v.g, v.b, v.a); }
		public static Vector3Int tpq(this Color32 v, Vector3Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b(); return v.tpq(); }
		public static Vector3Int ppq(this Color32 v) { return new Vector3Int(v.b, v.b, v.a); }
		public static Vector3Int qpq(this Color32 v) { return new Vector3Int(v.a, v.b, v.a); }
		public static Vector3Int sqq(this Color32 v) { return new Vector3Int(v.r, v.a, v.a); }
		public static Vector3Int tqq(this Color32 v) { return new Vector3Int(v.g, v.a, v.a); }
		public static Vector3Int pqq(this Color32 v) { return new Vector3Int(v.b, v.a, v.a); }
		public static Vector3Int qqq(this Color32 v) { return new Vector3Int(v.a, v.a, v.a); }

		// Color32 with 4 components.
		public static Vector4Int ssss(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.r); }
		public static Vector4Int tsss(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.r); }
		public static Vector4Int psss(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.r); }
		public static Vector4Int qsss(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.r); }
		public static Vector4Int stss(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.r); }
		public static Vector4Int ttss(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.r); }
		public static Vector4Int ptss(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.r); }
		public static Vector4Int qtss(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.r); }
		public static Vector4Int spss(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.r); }
		public static Vector4Int tpss(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.r); }
		public static Vector4Int ppss(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.r); }
		public static Vector4Int qpss(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.r); }
		public static Vector4Int sqss(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.r); }
		public static Vector4Int tqss(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.r); }
		public static Vector4Int pqss(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.r); }
		public static Vector4Int qqss(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.r); }
		public static Vector4Int ssts(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.r); }
		public static Vector4Int tsts(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.r); }
		public static Vector4Int psts(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.r); }
		public static Vector4Int qsts(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.r); }
		public static Vector4Int stts(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.r); }
		public static Vector4Int ttts(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.r); }
		public static Vector4Int ptts(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.r); }
		public static Vector4Int qtts(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.r); }
		public static Vector4Int spts(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.r); }
		public static Vector4Int tpts(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.r); }
		public static Vector4Int ppts(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.r); }
		public static Vector4Int qpts(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.r); }
		public static Vector4Int qpts(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.qpts(); }
		public static Vector4Int sqts(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.r); }
		public static Vector4Int tqts(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.r); }
		public static Vector4Int pqts(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.r); }
		public static Vector4Int pqts(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.r = (byte)other.a(); return v.pqts(); }
		public static Vector4Int qqts(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.r); }
		public static Vector4Int ssps(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.r); }
		public static Vector4Int tsps(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.r); }
		public static Vector4Int psps(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.r); }
		public static Vector4Int qsps(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.r); }
		public static Vector4Int stps(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.r); }
		public static Vector4Int ttps(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.r); }
		public static Vector4Int ptps(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.r); }
		public static Vector4Int qtps(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.r); }
		public static Vector4Int qtps(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.qtps(); }
		public static Vector4Int spps(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.r); }
		public static Vector4Int tpps(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.r); }
		public static Vector4Int ppps(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.r); }
		public static Vector4Int qpps(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.r); }
		public static Vector4Int sqps(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.r); }
		public static Vector4Int tqps(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.r); }
		public static Vector4Int tqps(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.r = (byte)other.a(); return v.tqps(); }
		public static Vector4Int pqps(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.r); }
		public static Vector4Int qqps(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.r); }
		public static Vector4Int ssqs(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.r); }
		public static Vector4Int tsqs(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.r); }
		public static Vector4Int psqs(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.r); }
		public static Vector4Int qsqs(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.r); }
		public static Vector4Int stqs(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.r); }
		public static Vector4Int ttqs(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.r); }
		public static Vector4Int ptqs(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.r); }
		public static Vector4Int ptqs(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.ptqs(); }
		public static Vector4Int qtqs(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.r); }
		public static Vector4Int spqs(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.r); }
		public static Vector4Int tpqs(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.r); }
		public static Vector4Int tpqs(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.r = (byte)other.a(); return v.tpqs(); }
		public static Vector4Int ppqs(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.r); }
		public static Vector4Int qpqs(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.r); }
		public static Vector4Int sqqs(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.r); }
		public static Vector4Int tqqs(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.r); }
		public static Vector4Int pqqs(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.r); }
		public static Vector4Int qqqs(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.r); }
		public static Vector4Int ssst(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.g); }
		public static Vector4Int tsst(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.g); }
		public static Vector4Int psst(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.g); }
		public static Vector4Int qsst(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.g); }
		public static Vector4Int stst(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.g); }
		public static Vector4Int ttst(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.g); }
		public static Vector4Int ptst(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.g); }
		public static Vector4Int qtst(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.g); }
		public static Vector4Int spst(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.g); }
		public static Vector4Int tpst(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.g); }
		public static Vector4Int ppst(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.g); }
		public static Vector4Int qpst(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.g); }
		public static Vector4Int qpst(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.qpst(); }
		public static Vector4Int sqst(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.g); }
		public static Vector4Int tqst(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.g); }
		public static Vector4Int pqst(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.g); }
		public static Vector4Int pqst(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.g = (byte)other.a(); return v.pqst(); }
		public static Vector4Int qqst(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.g); }
		public static Vector4Int sstt(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.g); }
		public static Vector4Int tstt(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.g); }
		public static Vector4Int pstt(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.g); }
		public static Vector4Int qstt(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.g); }
		public static Vector4Int sttt(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.g); }
		public static Vector4Int tttt(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.g); }
		public static Vector4Int pttt(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.g); }
		public static Vector4Int qttt(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.g); }
		public static Vector4Int sptt(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.g); }
		public static Vector4Int tptt(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.g); }
		public static Vector4Int pptt(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.g); }
		public static Vector4Int qptt(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.g); }
		public static Vector4Int sqtt(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.g); }
		public static Vector4Int tqtt(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.g); }
		public static Vector4Int pqtt(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.g); }
		public static Vector4Int qqtt(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.g); }
		public static Vector4Int sspt(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.g); }
		public static Vector4Int tspt(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.g); }
		public static Vector4Int pspt(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.g); }
		public static Vector4Int qspt(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.g); }
		public static Vector4Int qspt(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.qspt(); }
		public static Vector4Int stpt(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.g); }
		public static Vector4Int ttpt(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.g); }
		public static Vector4Int ptpt(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.g); }
		public static Vector4Int qtpt(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.g); }
		public static Vector4Int sppt(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.g); }
		public static Vector4Int tppt(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.g); }
		public static Vector4Int pppt(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.g); }
		public static Vector4Int qppt(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.g); }
		public static Vector4Int sqpt(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.g); }
		public static Vector4Int sqpt(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.b = (byte)other.b();v.g = (byte)other.a(); return v.sqpt(); }
		public static Vector4Int tqpt(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.g); }
		public static Vector4Int pqpt(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.g); }
		public static Vector4Int qqpt(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.g); }
		public static Vector4Int ssqt(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.g); }
		public static Vector4Int tsqt(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.g); }
		public static Vector4Int psqt(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.g); }
		public static Vector4Int psqt(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.psqt(); }
		public static Vector4Int qsqt(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.g); }
		public static Vector4Int stqt(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.g); }
		public static Vector4Int ttqt(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.g); }
		public static Vector4Int ptqt(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.g); }
		public static Vector4Int qtqt(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.g); }
		public static Vector4Int spqt(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.g); }
		public static Vector4Int spqt(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.a = (byte)other.b();v.g = (byte)other.a(); return v.spqt(); }
		public static Vector4Int tpqt(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.g); }
		public static Vector4Int ppqt(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.g); }
		public static Vector4Int qpqt(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.g); }
		public static Vector4Int sqqt(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.g); }
		public static Vector4Int tqqt(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.g); }
		public static Vector4Int pqqt(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.g); }
		public static Vector4Int qqqt(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.g); }
		public static Vector4Int sssp(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.b); }
		public static Vector4Int tssp(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.b); }
		public static Vector4Int pssp(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.b); }
		public static Vector4Int qssp(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.b); }
		public static Vector4Int stsp(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.b); }
		public static Vector4Int ttsp(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.b); }
		public static Vector4Int ptsp(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.b); }
		public static Vector4Int qtsp(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.b); }
		public static Vector4Int qtsp(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.qtsp(); }
		public static Vector4Int spsp(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.b); }
		public static Vector4Int tpsp(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.b); }
		public static Vector4Int ppsp(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.b); }
		public static Vector4Int qpsp(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.b); }
		public static Vector4Int sqsp(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.b); }
		public static Vector4Int tqsp(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.b); }
		public static Vector4Int tqsp(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.a = (byte)other.g();v.r = (byte)other.b();v.b = (byte)other.a(); return v.tqsp(); }
		public static Vector4Int pqsp(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.b); }
		public static Vector4Int qqsp(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.b); }
		public static Vector4Int sstp(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.b); }
		public static Vector4Int tstp(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.b); }
		public static Vector4Int pstp(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.b); }
		public static Vector4Int qstp(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.b); }
		public static Vector4Int qstp(this Color32 v, Vector4Int other) { v.a = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.qstp(); }
		public static Vector4Int sttp(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.b); }
		public static Vector4Int tttp(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.b); }
		public static Vector4Int pttp(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.b); }
		public static Vector4Int qttp(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.b); }
		public static Vector4Int sptp(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.b); }
		public static Vector4Int tptp(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.b); }
		public static Vector4Int pptp(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.b); }
		public static Vector4Int qptp(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.b); }
		public static Vector4Int sqtp(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.b); }
		public static Vector4Int sqtp(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.a = (byte)other.g();v.g = (byte)other.b();v.b = (byte)other.a(); return v.sqtp(); }
		public static Vector4Int tqtp(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.b); }
		public static Vector4Int pqtp(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.b); }
		public static Vector4Int qqtp(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.b); }
		public static Vector4Int sspp(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.b); }
		public static Vector4Int tspp(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.b); }
		public static Vector4Int pspp(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.b); }
		public static Vector4Int qspp(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.b); }
		public static Vector4Int stpp(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.b); }
		public static Vector4Int ttpp(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.b); }
		public static Vector4Int ptpp(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.b); }
		public static Vector4Int qtpp(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.b); }
		public static Vector4Int sppp(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.b); }
		public static Vector4Int tppp(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.b); }
		public static Vector4Int pppp(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.b); }
		public static Vector4Int qppp(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.b); }
		public static Vector4Int sqpp(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.b); }
		public static Vector4Int tqpp(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.b); }
		public static Vector4Int pqpp(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.b); }
		public static Vector4Int qqpp(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.b); }
		public static Vector4Int ssqp(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.b); }
		public static Vector4Int tsqp(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.b); }
		public static Vector4Int tsqp(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.tsqp(); }
		public static Vector4Int psqp(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.b); }
		public static Vector4Int qsqp(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.b); }
		public static Vector4Int stqp(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.b); }
		public static Vector4Int stqp(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.a = (byte)other.b();v.b = (byte)other.a(); return v.stqp(); }
		public static Vector4Int ttqp(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.b); }
		public static Vector4Int ptqp(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.b); }
		public static Vector4Int qtqp(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.b); }
		public static Vector4Int spqp(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.b); }
		public static Vector4Int tpqp(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.b); }
		public static Vector4Int ppqp(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.b); }
		public static Vector4Int qpqp(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.b); }
		public static Vector4Int sqqp(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.b); }
		public static Vector4Int tqqp(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.b); }
		public static Vector4Int pqqp(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.b); }
		public static Vector4Int qqqp(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.b); }
		public static Vector4Int sssq(this Color32 v) { return new Vector4Int(v.r, v.r, v.r, v.a); }
		public static Vector4Int tssq(this Color32 v) { return new Vector4Int(v.g, v.r, v.r, v.a); }
		public static Vector4Int pssq(this Color32 v) { return new Vector4Int(v.b, v.r, v.r, v.a); }
		public static Vector4Int qssq(this Color32 v) { return new Vector4Int(v.a, v.r, v.r, v.a); }
		public static Vector4Int stsq(this Color32 v) { return new Vector4Int(v.r, v.g, v.r, v.a); }
		public static Vector4Int ttsq(this Color32 v) { return new Vector4Int(v.g, v.g, v.r, v.a); }
		public static Vector4Int ptsq(this Color32 v) { return new Vector4Int(v.b, v.g, v.r, v.a); }
		public static Vector4Int ptsq(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.g = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.ptsq(); }
		public static Vector4Int qtsq(this Color32 v) { return new Vector4Int(v.a, v.g, v.r, v.a); }
		public static Vector4Int spsq(this Color32 v) { return new Vector4Int(v.r, v.b, v.r, v.a); }
		public static Vector4Int tpsq(this Color32 v) { return new Vector4Int(v.g, v.b, v.r, v.a); }
		public static Vector4Int tpsq(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.b = (byte)other.g();v.r = (byte)other.b();v.a = (byte)other.a(); return v.tpsq(); }
		public static Vector4Int ppsq(this Color32 v) { return new Vector4Int(v.b, v.b, v.r, v.a); }
		public static Vector4Int qpsq(this Color32 v) { return new Vector4Int(v.a, v.b, v.r, v.a); }
		public static Vector4Int sqsq(this Color32 v) { return new Vector4Int(v.r, v.a, v.r, v.a); }
		public static Vector4Int tqsq(this Color32 v) { return new Vector4Int(v.g, v.a, v.r, v.a); }
		public static Vector4Int pqsq(this Color32 v) { return new Vector4Int(v.b, v.a, v.r, v.a); }
		public static Vector4Int qqsq(this Color32 v) { return new Vector4Int(v.a, v.a, v.r, v.a); }
		public static Vector4Int sstq(this Color32 v) { return new Vector4Int(v.r, v.r, v.g, v.a); }
		public static Vector4Int tstq(this Color32 v) { return new Vector4Int(v.g, v.r, v.g, v.a); }
		public static Vector4Int pstq(this Color32 v) { return new Vector4Int(v.b, v.r, v.g, v.a); }
		public static Vector4Int pstq(this Color32 v, Vector4Int other) { v.b = (byte)other.r();v.r = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.pstq(); }
		public static Vector4Int qstq(this Color32 v) { return new Vector4Int(v.a, v.r, v.g, v.a); }
		public static Vector4Int sttq(this Color32 v) { return new Vector4Int(v.r, v.g, v.g, v.a); }
		public static Vector4Int tttq(this Color32 v) { return new Vector4Int(v.g, v.g, v.g, v.a); }
		public static Vector4Int pttq(this Color32 v) { return new Vector4Int(v.b, v.g, v.g, v.a); }
		public static Vector4Int qttq(this Color32 v) { return new Vector4Int(v.a, v.g, v.g, v.a); }
		public static Vector4Int sptq(this Color32 v) { return new Vector4Int(v.r, v.b, v.g, v.a); }
		public static Vector4Int sptq(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.b = (byte)other.g();v.g = (byte)other.b();v.a = (byte)other.a(); return v.sptq(); }
		public static Vector4Int tptq(this Color32 v) { return new Vector4Int(v.g, v.b, v.g, v.a); }
		public static Vector4Int pptq(this Color32 v) { return new Vector4Int(v.b, v.b, v.g, v.a); }
		public static Vector4Int qptq(this Color32 v) { return new Vector4Int(v.a, v.b, v.g, v.a); }
		public static Vector4Int sqtq(this Color32 v) { return new Vector4Int(v.r, v.a, v.g, v.a); }
		public static Vector4Int tqtq(this Color32 v) { return new Vector4Int(v.g, v.a, v.g, v.a); }
		public static Vector4Int pqtq(this Color32 v) { return new Vector4Int(v.b, v.a, v.g, v.a); }
		public static Vector4Int qqtq(this Color32 v) { return new Vector4Int(v.a, v.a, v.g, v.a); }
		public static Vector4Int sspq(this Color32 v) { return new Vector4Int(v.r, v.r, v.b, v.a); }
		public static Vector4Int tspq(this Color32 v) { return new Vector4Int(v.g, v.r, v.b, v.a); }
		public static Vector4Int tspq(this Color32 v, Vector4Int other) { v.g = (byte)other.r();v.r = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.tspq(); }
		public static Vector4Int pspq(this Color32 v) { return new Vector4Int(v.b, v.r, v.b, v.a); }
		public static Vector4Int qspq(this Color32 v) { return new Vector4Int(v.a, v.r, v.b, v.a); }
		public static Vector4Int stpq(this Color32 v) { return new Vector4Int(v.r, v.g, v.b, v.a); }
		public static Vector4Int stpq(this Color32 v, Vector4Int other) { v.r = (byte)other.r();v.g = (byte)other.g();v.b = (byte)other.b();v.a = (byte)other.a(); return v.stpq(); }
		public static Vector4Int ttpq(this Color32 v) { return new Vector4Int(v.g, v.g, v.b, v.a); }
		public static Vector4Int ptpq(this Color32 v) { return new Vector4Int(v.b, v.g, v.b, v.a); }
		public static Vector4Int qtpq(this Color32 v) { return new Vector4Int(v.a, v.g, v.b, v.a); }
		public static Vector4Int sppq(this Color32 v) { return new Vector4Int(v.r, v.b, v.b, v.a); }
		public static Vector4Int tppq(this Color32 v) { return new Vector4Int(v.g, v.b, v.b, v.a); }
		public static Vector4Int pppq(this Color32 v) { return new Vector4Int(v.b, v.b, v.b, v.a); }
		public static Vector4Int qppq(this Color32 v) { return new Vector4Int(v.a, v.b, v.b, v.a); }
		public static Vector4Int sqpq(this Color32 v) { return new Vector4Int(v.r, v.a, v.b, v.a); }
		public static Vector4Int tqpq(this Color32 v) { return new Vector4Int(v.g, v.a, v.b, v.a); }
		public static Vector4Int pqpq(this Color32 v) { return new Vector4Int(v.b, v.a, v.b, v.a); }
		public static Vector4Int qqpq(this Color32 v) { return new Vector4Int(v.a, v.a, v.b, v.a); }
		public static Vector4Int ssqq(this Color32 v) { return new Vector4Int(v.r, v.r, v.a, v.a); }
		public static Vector4Int tsqq(this Color32 v) { return new Vector4Int(v.g, v.r, v.a, v.a); }
		public static Vector4Int psqq(this Color32 v) { return new Vector4Int(v.b, v.r, v.a, v.a); }
		public static Vector4Int qsqq(this Color32 v) { return new Vector4Int(v.a, v.r, v.a, v.a); }
		public static Vector4Int stqq(this Color32 v) { return new Vector4Int(v.r, v.g, v.a, v.a); }
		public static Vector4Int ttqq(this Color32 v) { return new Vector4Int(v.g, v.g, v.a, v.a); }
		public static Vector4Int ptqq(this Color32 v) { return new Vector4Int(v.b, v.g, v.a, v.a); }
		public static Vector4Int qtqq(this Color32 v) { return new Vector4Int(v.a, v.g, v.a, v.a); }
		public static Vector4Int spqq(this Color32 v) { return new Vector4Int(v.r, v.b, v.a, v.a); }
		public static Vector4Int tpqq(this Color32 v) { return new Vector4Int(v.g, v.b, v.a, v.a); }
		public static Vector4Int ppqq(this Color32 v) { return new Vector4Int(v.b, v.b, v.a, v.a); }
		public static Vector4Int qpqq(this Color32 v) { return new Vector4Int(v.a, v.b, v.a, v.a); }
		public static Vector4Int sqqq(this Color32 v) { return new Vector4Int(v.r, v.a, v.a, v.a); }
		public static Vector4Int tqqq(this Color32 v) { return new Vector4Int(v.g, v.a, v.a, v.a); }
		public static Vector4Int pqqq(this Color32 v) { return new Vector4Int(v.b, v.a, v.a, v.a); }
		public static Vector4Int qqqq(this Color32 v) { return new Vector4Int(v.a, v.a, v.a, v.a); }
	}
}
