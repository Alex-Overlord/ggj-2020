using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10f;
    private Vector2 moveDir = Vector2.zero;
    private Player player;

    void Start() {
        player = GetComponent<Player>();
    }

    void Update() {
        //move
    }

    void movePlayer() {
        if (Input.GetKeyDown(KeyCode.Z)) {

        }
    }
}
