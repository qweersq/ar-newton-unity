using UnityEngine;

public class TruckMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float mass = 100f; // massa mobil dalam kilogram
    [SerializeField] private float acceleration = 10f; // percepatan mobil dalam m/s^2

    private float forceMagnitude;
    private bool clicked = false;
    private PlaceObjectForTruck placeObjectForTruck;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        placeObjectForTruck = FindObjectOfType<PlaceObjectForTruck>();
        forceMagnitude = mass * acceleration;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && !clicked)
        {
            clicked = true;
            Vector3 force = transform.forward * forceMagnitude;
            rb.AddForce(force, ForceMode.Force);
            placeObjectForTruck.OnStartClick();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall")) // jika objek yang ditabrak adalah kubus
        {
            rb.velocity = Vector3.zero; // menghentikan kecepatan truk
            rb.angularVelocity = Vector3.zero; // menghentikan rotasi truk
        }
    }
}
