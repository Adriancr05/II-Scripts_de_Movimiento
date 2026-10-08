using UnityEngine;

public class CubeConstantMovement : MonoBehaviour {
  public Vector3 moveDirection = new Vector3(0f, 0f, 1f);
  public float speed = 0.01f;
  public Space referenceSpace = Space.Self;
  void Update() { transform.Translate(moveDirection * speed, referenceSpace); }
}