using UnityEngine;

public class CubeMover : MonoBehaviour {
  public float speed = 5f;

  void Update() {
    float horizontal = 0f;
    float vertical = 0f;

    if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
    if (Input.GetKey(KeyCode.LeftArrow))  horizontal = -1f;
    if (Input.GetKey(KeyCode.UpArrow))    vertical = 1f;
    if (Input.GetKey(KeyCode.DownArrow))  vertical = -1f;

    transform.Translate(
      horizontal * speed * Time.deltaTime,
      vertical * speed * Time.deltaTime,
      0f
    );
  }
}
