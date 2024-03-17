using System;
using System.Collections.Generic;
using UnityEngine;

public enum CustomMeshType
{
    Head,
    Face,
    Body,
    LeftArm,
    RightArm,
    LeftLeg,
    RightLeg
}

public class CustomMesh : MonoBehaviour
{
    public string meshName;
    public CustomMeshType meshType;
    private Tuple<float[], float[], int[], float[]> rawMeshData;
    public Tuple<Vector3[], Vector2[], int[], Vector3[]> meshData;

    protected Mesh mesh;
    protected MeshFilter meshFilter;
    protected MeshRenderer meshRenderer;
    protected Material meshMaterial;
    public Texture meshTexture;

    public List<Vector3> meshVerticies = new List<Vector3>();

    public bool update;

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

        mesh = new Mesh();
        mesh.name = meshName;

        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();

        meshMaterial = new Material(Shader.Find("Standard"));
        if (meshTexture != null)
        {
            meshMaterial.SetTexture("_MainTex", meshTexture);
        }
        
        meshMaterial.SetColor("_Color", new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f)));
        meshRenderer.material = meshMaterial;

        LoadMeshData();
        meshVerticies.AddRange(meshData.Item1);
        UpdateMesh();

    }

    void Update()
    {
        if (update)
        {
            UpdateMesh();
        }
    }

    protected virtual void UpdateMesh()
    {
        if(meshData == null)
        {
            UnityEngine.Debug.LogError("Failed to create a mesh because meshData is null.");
            return;
        }

        mesh.Clear();
        mesh.vertices = meshVerticies.ToArray();//meshData.Item1;
        mesh.uv = meshData.Item2;
        mesh.triangles = meshData.Item3;
        mesh.normals = meshData.Item4;
        meshFilter.mesh = mesh;
    }

    protected virtual void LoadMeshData()
    {
        switch (meshType)
        {
            case CustomMeshType.Head:
                rawMeshData = FoeGeometryManager.GetHeadMeshData();
                break;

            case CustomMeshType.Face:
                rawMeshData = FoeGeometryManager.GetFaceMeshData();
                break;

            case CustomMeshType.Body:
                rawMeshData = FoeGeometryManager.GetBodyMeshData();
                break;

            case CustomMeshType.LeftArm:
                rawMeshData = FoeGeometryManager.GetLeftArmMeshData();
                break;

            case CustomMeshType.RightArm:
                rawMeshData = FoeGeometryManager.GetRightArmMeshData();
                break;

            case CustomMeshType.LeftLeg:
                rawMeshData = FoeGeometryManager.GetLeftLegMeshData();
                break;

            case CustomMeshType.RightLeg:
                rawMeshData = FoeGeometryManager.GetRightLegMeshData();
                break;
        }
        if (IsMeshDataValid())
        {
            meshData = ToUnity();
        }
    }

    private bool IsMeshDataValid()
    {
        return IsVertexDataValid() && IsUVsDataValid() && IsTriangleDataValid();
    }

    private bool IsVertexDataValid()
    {
        if (rawMeshData.Item1 == null)
        {
            UnityEngine.Debug.LogError("vertex data passed in the parameter is null");
            return false;
        }
        if(rawMeshData.Item1.Length <= 0)
        {
            UnityEngine.Debug.LogError("vertex data passed in the parameter is of size 0");
            return false;
        }
        if(rawMeshData.Item1.Length % 3 != 0)
        {
            UnityEngine.Debug.LogError("vertex data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private bool IsUVsDataValid()
    {
        if (rawMeshData.Item2 == null)
        {
            UnityEngine.Debug.LogError("uv data passed in the parameter is null");
            return false;
        }
        if (rawMeshData.Item2.Length <= 0)
        {
            UnityEngine.Debug.LogError("uv data passed in the parameter is of size 0");
            return false;
        }
        if (rawMeshData.Item2.Length % 2 != 0)
        {
            UnityEngine.Debug.LogError("uv data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private bool IsTriangleDataValid()
    {
        if (rawMeshData.Item3 == null)
        {
            UnityEngine.Debug.LogError("triangles data passed in the parameter is null");
            return false;
        }
        if (rawMeshData.Item3.Length <= 0)
        {
            UnityEngine.Debug.LogError("triangles data passed in the parameter is of size 0");
            return false;
        }
        if (rawMeshData.Item3.Length % 3 != 0)
        {
            UnityEngine.Debug.LogError("triangles data passed in the parameter has invalid size");
            return false;
        }

        return true;
    }

    private List<Vector3> ConvertFloatArrayToVector3Array(float[] vertices)
    {
        List<Vector3> vectors = new List<Vector3>();
        if (vertices != null)
        {
            for (int i = 0; i < vertices.Length / 3; i++)
            {
                vectors.Add(new Vector3(vertices[i + (i * 2)], vertices[i + (i * 2) + 1], vertices[i + (i * 2) + 2]));
            }
        }
        return vectors;
    }

    private List<Vector2> ConvertFloatArrayToVector2Array(float[] uvs)
    {
        List<Vector2> vectors = new List<Vector2>();
        if (uvs != null)
        {
            for (int i = 0; i < uvs.Length / 2; i++)
            {
                vectors.Add(new Vector3(uvs[i + (i * 1)], uvs[i + (i * 1) + 1]));
            }
        }
        return vectors;
    }

    private Tuple<Vector3[], Vector2[], int[], Vector3[]> ToUnity()
    {
        return Tuple.Create<Vector3[], Vector2[], int[], Vector3[]>(
            ConvertFloatArrayToVector3Array(rawMeshData.Item1).ToArray(),
            ConvertFloatArrayToVector2Array(rawMeshData.Item2).ToArray(),
            rawMeshData.Item3,
            ConvertFloatArrayToVector3Array(rawMeshData.Item4).ToArray());
    }
}
