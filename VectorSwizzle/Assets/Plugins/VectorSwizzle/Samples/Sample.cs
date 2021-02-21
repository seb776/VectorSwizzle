using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VectorSwizzle;

static class VectorSwizzleSample
{
    private static void SampleMethod01()
    {
        GameObject gameObj = null;
        Transform playerTransform = null;

        gameObj.transform.position.xy(playerTransform.position.xy());

        // Is equivalent to
        gameObj.transform.position = new Vector3(playerTransform.position.x,
                                                 playerTransform.position.y,
                                                 gameObj.transform.position.z);
    }

    private static void SampleMethod02()
    {
        GameObject gameObj = null;

        // Assign the mouse screen position to the gameObj xz plane position
        gameObj.transform.position.xz(Input.mousePosition.xy());
    }

    private static void SampleMethod03()
    {
        GameObject gameObj = null;

        // Translates a 3D position to a 2D one
        Vector2 pos2D = gameObj.transform.position.xz();
    }

    private static void SampleMethod04()
    {
        Texture2D tex = new Texture2D(42,42);
        Color inputColor = tex.GetPixel(21, 21);

        // Turns the inputColor to grey
        Color outputCol = inputColor.rrrr();
    }
}
