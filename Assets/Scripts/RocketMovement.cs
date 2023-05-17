using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    private Rigidbody thisRigidbody;
    private bool activate;

    public int force = 100;

    // Start is called before the first frame update
    void Awake()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        StartCoroutine(LaunchRocket());
    }

    private IEnumerator LaunchRocket()
    {
        yield return new WaitForSeconds(3f);
        activate = true;
    }

    private void FixedUpdate()
    {
        if (activate)
        {
            thisRigidbody.AddForce(Vector3.up * Time.deltaTime * force, ForceMode.Acceleration);
        }
    }
}
