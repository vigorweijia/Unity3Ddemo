using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAction : MonoBehaviour
{
    private int is_collision = 0;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_collision == 1) {
            Debug.Log("Collision Happened.");
            is_collision = 0;
            float r = Random.Range(0f,1f);
            float g = Random.Range(0f,1f);
            float b = Random.Range(0f,1f);
            meshRenderer.material.color = new Color(r, g, b);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Sphere") {
            is_collision = 1;
        }
    }
}
