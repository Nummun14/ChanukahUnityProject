using Unity.VisualScripting;
using UnityEngine;

public class DonutScript : MonoBehaviour {
    public Rigidbody2D rigidBody;
    public float flapStrength;
    public LogicManagerScript logicManagerScript;
    public bool isBirdAlive = true;
    public float screenLowestPoint = -12.5f;
    public float screenHighestPoint = 13;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        rigidBody = GetComponent<Rigidbody2D>();
        logicManagerScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update(){
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0)) && isBirdAlive)
            rigidBody.linearVelocity = Vector2.up * flapStrength;
        if (transform.position.y < screenLowestPoint || transform.position.y > screenHighestPoint)
            endGame();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        endGame();
    }

    private void endGame() {
        logicManagerScript.gameOver();
        isBirdAlive = false;
    }
}
