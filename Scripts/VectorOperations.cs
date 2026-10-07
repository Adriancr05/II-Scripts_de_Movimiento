using UnityEngine;

public class VectorOperations : MonoBehaviour {
  public Vector3 vectorA;
  public Vector3 vectorB;

  public float magnitudeA;
  public float magnitudeB;
  public float angle;
  public float distance;
  public string heightMessage;

  public Vector3 spherePosition;
  private Transform sphereTransform;

  void Start() {
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;
    angle = Vector3.Angle(vectorA, vectorB);
    distance = Vector3.Distance(vectorA, vectorB);

    if (vectorA.y > vectorB.y) heightMessage = "Vector A is higher";
    else if (vectorB.y > vectorA.y) heightMessage = "Vector B is higher";
    else heightMessage = "Both vectors are at the same height";

    Debug.Log("Magnitude of A: " + magnitudeA);
    Debug.Log("Magnitude of B: " + magnitudeB);
    Debug.Log("Angle between A and B: " + angle + " degrees");
    Debug.Log("Distance between A and B: " + distance);
    Debug.Log(heightMessage);

    sphereTransform = GetComponent<Transform>();
    spherePosition = sphereTransform.position;
    Debug.Log("Sphere position (GetComponent): " + spherePosition);
    Debug.Log("Sphere position (transform.position): " + transform.position);
  }

  void Update() { spherePosition = transform.position; }
}
