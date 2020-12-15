using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
