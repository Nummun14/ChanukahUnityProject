using UnityEngine;

public class CandleScript : MonoBehaviour {
    public float moveSpeed = 10;
    private float deadzone = -40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadzone )
            Destroy(gameObject);
    }
}
