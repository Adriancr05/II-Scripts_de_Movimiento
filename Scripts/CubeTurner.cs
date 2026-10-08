using UnityEngine;

public class CubeTurner : MonoBehaviour {
  public float speed = 5f;
  public float rotationSpeed = 90f;

  void Update() {
    float horizontal = Input.GetAxis("Horizontal");
    transform.Rotate(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
  }
}
