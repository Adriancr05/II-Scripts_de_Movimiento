using UnityEngine;

public class SpeedDebugger : MonoBehaviour {
  public float speed = 5f;

  void Update() {
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      float vertical = Input.GetAxis("Vertical");
      Debug.Log("Up Arrow: " + (speed * vertical));
    } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
      float vertical = Input.GetAxis("Vertical");
      Debug.Log("Down Arrow: " + (speed * vertical));
    }

    if (Input.GetKeyDown(KeyCode.LeftArrow)) {
      float horizontal = Input.GetAxis("Horizontal");
      Debug.Log("Left Arrow: " + (speed * horizontal));
    } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
      float horizontal = Input.GetAxis("Horizontal");
      Debug.Log("Right Arrow: " + (speed * horizontal));
    }
  }
}
