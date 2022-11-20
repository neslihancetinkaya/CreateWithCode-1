using System;
using UnityEngine;

public class MovingObstacleController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}