using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
    }
}
