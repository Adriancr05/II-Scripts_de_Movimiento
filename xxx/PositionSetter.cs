using UnityEngine;

public class PositionSetter : MonoBehaviour {
  public Vector3[] offsets = new Vector3[3];

  public Transform objectA;
  public Transform objectB;
  public Transform objectC;

  private Vector3 startPosA;
  private Vector3 startPosB;
  private Vector3 startPosC;

  void Start() {
    startPosA = objectA.position;
    startPosB = objectB.position;
    startPosC = objectC.position;
  }

  void Update() {
    if (Input.GetAxis("Jump") > 0) {
      objectA.position = startPosA + offsets[0];
      objectB.position = startPosB + offsets[1];
      objectC.position = startPosC + offsets[2];
    }
  }
}
