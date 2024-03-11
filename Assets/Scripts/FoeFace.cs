using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeFace : FoeBaseMesh
{
    protected override void SetupMeshVertices()
    {
        float[] vertices = FoeGeometryManager.GetRawFaceVertices();
        AssignVertices(vertices);
    }

    protected override void SetupMeshUVs()
    {
        float[] uvs = FoeGeometryManager.GetRawFaceUVs();
        AssignUVs(uvs);
    }

    protected override void SetupMeshTriangles()
    {
        int[] triangles = FoeGeometryManager.GetRawFaceTriangles();
        AssignTriangles(triangles);
    }
}
