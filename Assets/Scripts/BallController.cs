using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private bool clicked = false;
    private PlaceObjectOnPlane placeObjectOnPlane;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        placeObjectOnPlane = FindObjectOfType<PlaceObjectOnPlane>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !clicked)
        {
            clicked = true;
            rb.AddForce(new Vector3(0f, 0f, 1f) * moveSpeed, ForceMode.Impulse);
            placeObjectOnPlane.OnBallClick();
        }
    }
}
