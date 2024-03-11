using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeBaseMesh : MonoBehaviour
{
    public string meshName;
    protected Mesh mesh;
    protected MeshFilter meshFilter;
    protected MeshRenderer meshRenderer;
    protected Material meshMaterial;
    public Texture meshTexture;
    protected float[] rawMeshVertices;
    protected List<Vector3> meshVertices;
    protected float[] rawUVs;
    protected List<Vector2> meshUVs;
    protected List<int> meshTriangles;
    protected List<Vector3> meshNormals;
    void Awake()
    {
        if(!GetComponent<MeshFilter>())
        {
            gameObject.AddComponent<MeshFilter>();
        }
        if(!GetComponent<MeshRenderer>())
        {
            gameObject.AddComponent<MeshRenderer>();
        }

        meshVertices = new List<Vector3>();
        meshUVs = new List<Vector2>();
        meshTriangles = new List<int>();
        meshNormals = new List<Vector3>();

        mesh = new Mesh();
        mesh.name = meshName;
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

        meshMaterial = new Material(Shader.Find("Standard"));

        if (meshTexture != null)
        {
            meshMaterial.SetTexture("_MainTex", meshTexture);
        }
        meshRenderer.material = meshMaterial;

        UpdateMesh();
    }

    protected virtual void UpdateMesh()
    {
        SetupMeshVertices();
        SetupMeshUVs();
        SetupMeshTriangles();
        SetupMeshNormals();

        if (!IsVertexDataValid(rawMeshVertices))
        {
            Debug.LogError("Mesh can not be generated because invalid mesh vertices.");
            return;
        }
        if(!IsTriangleDataValid(meshTriangles.ToArray()))
        {
            Debug.LogError("Mesh can not be generated because invalid mesh triangles.");
            return;
        }
        if (!IsUVsDataValid(rawUVs))
        {
            Debug.LogError("Mesh can not be generated because invalid mesh uvs.");
            return;
        }

        mesh.Clear();
        if (meshVertices != null || meshVertices.Count > 0)
        {
            mesh.vertices = meshVertices.ToArray();
        }
        if (meshUVs != null || meshUVs.Count > 0)
        {
            mesh.uv = meshUVs.ToArray();
        }
        if (meshTriangles != null || meshTriangles.Count > 0)
        {
            mesh.triangles = meshTriangles.ToArray();
        }
        if (meshNormals != null || meshNormals.Count > 0)
        {
            mesh.normals = meshNormals.ToArray();
        }
        meshFilter.mesh = mesh;
    }

    protected virtual void SetupMeshVertices()
    {

    }

    protected virtual void SetupMeshUVs()
    {

    }

    protected virtual void SetupMeshTriangles()
    {

    }

    protected virtual void SetupMeshNormals()
    {

    }

    protected void AssignVertices(float[] vertices)
    {
        if(IsVertexDataValid(vertices))
        {
            rawMeshVertices = vertices;
            meshVertices = ConvertRawVerticesToVector3Array(rawMeshVertices);
        }
    }

    protected void AssignUVs(float[] uvs)
    {
        if (IsUVsDataValid(uvs))
        {
            rawUVs = uvs;
            meshUVs = ConvertRawUVsToVector2Array(rawUVs);
        }
    }

    protected void AssignTriangles(int[] triangles)
    {
        if (IsTriangleDataValid(triangles))
        {
            meshTriangles.Clear();
            meshTriangles.AddRange(triangles);
        }
    }

    private bool IsVertexDataValid(float[] vertices)
    {
        if (vertices == null)
        {
            Debug.LogError("vertex data passed in the parameter is null");
            return false;
        }
        if(vertices.Length <= 0)
        {
            Debug.LogError("vertex data passed in the parameter is of size 0");
            return false;
        }
        if(vertices.Length % 3 != 0)
        {
            Debug.LogError("vertex data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private bool IsUVsDataValid(float[] uvs)
    {
        if (uvs == null)
        {
            Debug.LogError($"{nameof(uvs)} data passed in the parameter is null");
            return false;
        }
        if (uvs.Length <= 0)
        {
            Debug.LogError($"{nameof(uvs)} data passed in the parameter is of size 0");
            return false;
        }
        if (uvs.Length % 2 != 0)
        {
            Debug.LogError($"{nameof(uvs)} data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private bool IsTriangleDataValid(int[] triangles)
    {
        if (triangles == null)
        {
            Debug.LogError($"{nameof(triangles)} data passed in the parameter is null");
            return false;
        }
        if (triangles.Length <= 0)
        {
            Debug.LogError($"{nameof(triangles)} data passed in the parameter is of size 0");
            return false;
        }
        if (triangles.Length % 3 != 0)
        {
            Debug.LogError($"{nameof(triangles)} data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private List<Vector3> ConvertRawVerticesToVector3Array(float[] vertices)
    {
        List<Vector3> vectors = new List<Vector3>();
        for (int i = 0; i < vertices.Length / 3; i++)
        {
            vectors.Add(new Vector3(vertices[i + (i * 2)], vertices[i + (i * 2) + 1], vertices[i + (i * 2) + 2]));
        }
        return vectors;
    }

    private List<Vector2> ConvertRawUVsToVector2Array(float[] uvs)
    {
        List<Vector2> vectors = new List<Vector2>();
        for (int i = 0; i < uvs.Length / 2; i++)
        {
            vectors.Add(new Vector3(uvs[i + (i * 1)], uvs[i + (i * 1) + 1]));
        }
        return vectors;
    }
}
