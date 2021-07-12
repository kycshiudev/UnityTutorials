using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 15.0f;
    private float bottomBound = -10.0f;
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
