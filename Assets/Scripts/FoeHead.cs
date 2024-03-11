using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeHead : FoeBaseMesh
{
    protected override void SetupMeshVertices()
    {
        float[] vertices = FoeGeometryManager.GetRawHeadVertices();
        AssignVertices(vertices);
    }

    protected override void SetupMeshUVs()
    {
        float[] uvs = FoeGeometryManager.GetRawHeadUVs();
        AssignUVs(uvs);
    }

    protected override void SetupMeshTriangles()
    {
        int[] triangles = FoeGeometryManager.GetRawHeadTriangles();
        AssignTriangles(triangles);
    }
}
