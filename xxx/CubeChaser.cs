using UnityEngine;

public class CubeChaser : MonoBehaviour {
  public Transform sphere;
  public float speed = 5f;

  void Start() {
    GameObject sphere_object = GameObject.FindWithTag("sphere");
    sphere = sphere_object.GetComponent<Transform>();
  }

  void Update() {
    Vector3 direction = sphere.position - transform.position;
    direction.y = 0f;
    transform.LookAt(sphere);
    direction = direction.normalized;
    transform.Translate(direction * speed * Time.deltaTime, Space.World);
  }
}
