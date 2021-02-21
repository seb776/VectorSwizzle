========== UnitySwizzle ==========
** Description **
Unity swizzle aims to bring the "swizzle" feature that is used in shader languages (GLSL, HLSL...) to Unity vector types.

For a detailed explanation of the feature check the openGL documentation down here :
https://www.khronos.org/opengl/wiki/Data_Type_(GLSL)#Swizzling



** Features **
- Added "Vector4Int" type for coherence
- xyzw / rgba / stpq masks without mixing symbols from different masks
- Implemented the same way as the GLSL implementation
- Allows for both get and set
- Each "unit" field also wrapped in an extension mathod for typing consistence ( v.x == v.x() )
- Works on Vector2, Vector3, Vector4, Vector2Int, Vector3Int, Vector4Int, Color & Color32

** Examples **
==== Sample 1

Vector4 va = new Vector4(1.0f,2.0f,3.0f,4.0f);
va.xzy();

- Equivalent to :
Vector4 va = new Vector4(1.0f,2.0f,3.0f,4.0f);
new Vector3(va.x, va.z, va.y);

==== Sample 2

Vector2 position2D = 
	new Vector2(transform.position.x, 
				transform.position.y);
				
- Equivalent to :
Vector2 position2D = transform.position.xy();

==== Sample 3 : Want to assign fields ?

Vector2 mousePos;
transform.position.xy(mousePos);

- Equivalent to :
transform.position.x = mousePos.x;
transform.position.y = mousePos.y;

** Roadmap **
- Matrices


** Contact / Help / Bug report **
I'm open to suggestion so don't hesitate to contact me through github or mail :
https://github.com/seb776
Support email : smairedev.supp@outlook.com

