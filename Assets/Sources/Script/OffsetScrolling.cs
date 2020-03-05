using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class OffsetScrolling : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer renderer;
    // Start is called before the first frame update
    void Awake()
    {
        renderer = GetComponent<Renderer>();        
    }

    // Update is called once per frame
    void Update() => renderer.sharedMaterial.SetTextureOffset("_MainTex", new Vector2(Mathf.Repeat(Time.time * scrollSpeed, 1), 0));
}
