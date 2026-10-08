using UnityEngine;

public class DistanceToObjects : MonoBehaviour {
  public float distanceToCube;
  public float distanceToCylinder;

  private Transform cubeTransform;
  private Transform cylinderTransform;

  void Start() {
    GameObject cube = GameObject.FindWithTag("cube");
    GameObject cylinder = GameObject.FindWithTag("cylinder");

    cubeTransform = cube.GetComponent<Transform>();
    cylinderTransform = cylinder.GetComponent<Transform>();

    distanceToCube = Vector3.Distance(transform.position, cubeTransform.position);
    distanceToCylinder = Vector3.Distance(transform.position, cylinderTransform.position);

    Debug.Log("Distance to the cube: " + distanceToCube);
    Debug.Log("Distance to the cylinder: " + distanceToCylinder);
  }

  void Update() {
    distanceToCube = Vector3.Distance(transform.position, cubeTransform.position);
    distanceToCylinder = Vector3.Distance(transform.position, cylinderTransform.position);
  }
}