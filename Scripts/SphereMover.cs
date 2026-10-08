using UnityEngine;

public class SphereMover : MonoBehaviour {
  public float speed = 5f;

  void Update() {
    float horizontal = 0f;
    float vertical = 0f;

    if (Input.GetKey(KeyCode.D)) horizontal = 1f;
    if (Input.GetKey(KeyCode.A)) horizontal = -1f;
    if (Input.GetKey(KeyCode.W)) vertical = 1f;
    if (Input.GetKey(KeyCode.S)) vertical = -1f;

    transform.Translate(
      horizontal * speed * Time.deltaTime,
      vertical * speed * Time.deltaTime,
      0f
    );
  }
}
