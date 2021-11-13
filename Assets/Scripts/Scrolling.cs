using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {
    [SerializeField]
    private float speed;
    [SerializeField]
    private float positionY;
    [SerializeField]
    private float startX;
    [SerializeField]
    private float endX;

    private void Update() {
        var scroll = new Vector3(Time.deltaTime * speed, 0, 0);
        transform.position += scroll;

        if (transform.position.x >= endX) {
            transform.position = new Vector3(startX, positionY, 0);
        }
    }
}
