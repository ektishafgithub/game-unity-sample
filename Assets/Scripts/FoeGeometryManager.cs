using System;
using UnityEngine;

public class FoeGeometryManager
{
    public static Tuple<float[], float[], int[], float[]> GetHeadMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
               -1f, -1f, -1f,
               -1f,  1f, -1f,
                1f,  1f, -1f,
                1f, -1f, -1f,
                1f, -1f,  1f,
                1f,  1f,  1f,
               -1f,  1f,  1f,
               -1f, -1f,  1f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
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
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetFaceMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
               -1f, -1f, -1f,
               -1f,  1f, -1f,
                1f,  1f, -1f,
                1f, -1f, -1f,
            },
            new float[]
            {
                0f, 0f, 0f, 1f, 1f, 1f, 1f, 0f
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetBodyMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
               -1f, -2f, -1f,
               -1f,  1f, -0.5f,
                1f,  1f, -0.5f,
                1f, -2f, -1f,
                1f, -2f,  1f,
                1f,  1f,  1f,
               -1f,  1f,  1f,
               -1f, -2f,  1f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3,
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
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetRightArmMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
               -1f, -2f, -0.5f,
               -1f,  1f, -0.5f,
                0f,  1f, -0.5f,
                0f, -2f, -0.5f,
                0f, -2f,  0.5f,
                0f,  1f,  0.5f,
               -1f,  1f,  0.5f,
               -1f, -2f,  0.5f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3,
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
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetLeftArmMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
                0f, -2f, -0.5f,
                0f,  1f, -0.5f,
                1f,  1f, -0.5f,
                1f, -2f, -0.5f,
                1f, -2f,  0.5f,
                1f,  1f,  0.5f,
                0f,  1f,  0.5f,
                0f, -2f,  0.5f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3,
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
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetRightLegMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
               -1f, -2f, -1f,
               -1f,  1f, -1f,
                0f,  1f, -1f,
                0f, -2f, -1f,
                0f, -2f,  1f,
                0f,  1f,  1f,
               -1f,  1f,  1f,
               -1f, -2f,  1f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3,
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
            },
            new float[]
            {
            });
    }

    public static Tuple<float[], float[], int[], float[]> GetLeftLegMeshData()
    {
        return Tuple.Create<float[], float[], int[], float[]>(
            new float[]
            {
                0f, -2f, -1f,
                0f,  1f, -1f,
                1f,  1f, -1f,
                1f, -2f, -1f,
                1f, -2f,  1f,
                1f,  1f,  1f,
                0f,  1f,  1f,
                0f, -2f,  1f,
            },
            new float[]
            {
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
                0f, 0f,
            },
            new int[]
            {
                0, 1, 2,
                0, 2, 3,
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
            },
            new float[]
            {
            });
    }
}
