using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    private Rigidbody rb;
    private int force = 5;
    private int is_landing = 0;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        Debug.Log("Hello Unity!");
    }

    // Update is called once per frame
    void Update()
    {
        if (is_landing == 1) {
            Debug.Log("Landing!");
            is_landing = 0;
            meshRenderer.material.color = Color.red;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * 5);
    }

    void OnCollisionEnter(Collision collision) {
        is_landing = 1;
    }
}