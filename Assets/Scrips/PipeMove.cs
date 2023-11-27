using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float _speed = .65f;

    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
