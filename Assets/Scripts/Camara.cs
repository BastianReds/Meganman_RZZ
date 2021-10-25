using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform playerKeeper;
    public float offset_x, offset_y;
    public float cameraDistance = 30.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    void Start()
    {
        playerKeeper = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playerKeeper.position.x;
        temp.x *= offset_x;

        temp.y = playerKeeper.position.y;
        temp.y += offset_y;

        transform.position = temp;
    }
}