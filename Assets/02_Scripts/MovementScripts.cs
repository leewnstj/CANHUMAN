using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScripts : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
    }
}
