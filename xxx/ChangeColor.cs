using UnityEngine;

public class ChangeColor : MonoBehaviour {
  public int waitingFrames = 120;
  private float[] values = new float[3];
  private int counter = 0;
  private Renderer rend;

  void Start() {
    rend = GetComponent<Renderer>();
    for (int i = 0; i < values.Length; i++) values[i] = Random.Range(0.0f, 1.0f);
    rend.material.color = new Color(values[0], values[1], values[2]);
  }

  void Update() {
    counter++;
    if (counter >= waitingFrames) {
      counter = 0;
      int position = Random.Range(0, 3);
      values[position] = Random.Range(0.0f, 1.0f);
      rend.material.color = new Color(values[0], values[1], values[2]);
    }
  }
}
