using UnityEngine;

[ExecuteInEditMode]
public class DynamicPlaneMesh : MonoBehaviour
{
    private Vector3 _currentScale;

    private void Start()
    {
        Calculate();
    }

    private void Update()
    {
        Calculate();
    }

    public void Calculate()
    {
        if (_currentScale == transform.localScale) return;
        _currentScale = transform.localScale;
        if (CheckForDefaultSize()) return;

        var mesh = GetMesh();
        mesh.uv = SetupUvMap(mesh.uv);
        mesh.name = "Plane Instance";

        if (GetComponent<Renderer>().sharedMaterial.mainTexture.wrapMode != TextureWrapMode.Repeat)
        {
            GetComponent<Renderer>().sharedMaterial.mainTexture.wrapMode = TextureWrapMode.Repeat;
        }
    }

    private Mesh GetMesh()
    {
        Mesh mesh;

#if UNITY_EDITOR

        var meshFilter = GetComponent<MeshFilter>();
        var meshCopy = Instantiate(meshFilter.sharedMesh);
        mesh = meshFilter.mesh = meshCopy;

#else
        
        mesh = GetComponent<MeshFilter>().mesh;

#endif

        return mesh;
    }

    private Vector2[] SetupUvMap(Vector2[] meshUVs)
    {
        var width = _currentScale.x;
        var depth = _currentScale.z;

        // You can customize the UV mapping for a plane here.
        meshUVs[2] = new Vector2(0, 0);
        meshUVs[3] = new Vector2(width, 0);
        meshUVs[0] = new Vector2(0, depth);
        meshUVs[1] = new Vector2(width, depth);

        return meshUVs;
    }

    private bool CheckForDefaultSize()
    {
        if (_currentScale != Vector3.one) return false;

        var plane = GameObject.CreatePrimitive(PrimitiveType.Plane);

        DestroyImmediate(GetComponent<MeshFilter>());
        gameObject.AddComponent<MeshFilter>();
        GetComponent<MeshFilter>().sharedMesh = plane.GetComponent<MeshFilter>().sharedMesh;

        DestroyImmediate(plane);

        return true;
    }
}