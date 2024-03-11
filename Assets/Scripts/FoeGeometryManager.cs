using UnityEngine;

public class FoeGeometryManager
{
    public static float[] GetRawHeadVertices()
    {
        return new float[]
        {
           -1f, -1f, -1f,
           -1f,  1f, -1f,
            1f,  1f, -1f,
            1f, -1f, -1f,
            1f, -1f,  1f,
            1f,  1f,  1f,
           -1f,  1f,  1f,
           -1f, -1f,  1f,
        };
    }
    public static int[] GetRawHeadTriangles()
    {
        return new int[]
        {
            3, 2, 5,
            3, 5, 4,
            4, 5, 6,
            4, 6, 7,
            7, 6, 1,
            7, 1, 0,
            1, 6, 5,
            1, 5, 2,
            7, 0, 3,
            7, 3, 4
        };
    }
    public static float[] GetRawHeadUVs()
    {
        return new float[]
        {
            0f, 0f,
            0f, 0f,
            0f, 0f,
            0f, 0f,
            0f, 0f,
            0f, 0f,
            0f, 0f,
            0f, 0f,
        };
    }

    public static float[] GetRawFaceVertices()
    {
        return new float[]
        {
           -1f, -1f, -1f,
           -1f,  1f, -1f,
            1f,  1f, -1f,
            1f, -1f, -1f,
        };
    }
    public static int[] GetRawFaceTriangles()
    {
        return new int[]
        {
            0, 1, 2,
            0, 2, 3
        };
    }
    public static float[] GetRawFaceUVs()
    {
        return new float[]
        {
            0f, 0f, 0f, 1f, 1f, 1f, 1f, 0f
        };
    }
}
