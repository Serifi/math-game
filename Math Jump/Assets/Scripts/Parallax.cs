using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float scrollSpeed = 0.25f;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Transmitter.isStartedT)
        {
            Vector2 offset = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
            offset.y -= Time.deltaTime * scrollSpeed;
            meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    }
}