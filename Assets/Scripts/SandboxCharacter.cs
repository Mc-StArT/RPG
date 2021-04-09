using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandboxCharacter : MonoBehaviour
{
    private float _speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float _vertical = Input.GetAxis("Vertical");
        float _horizontal = Input.GetAxis("Horizontal")*-1;
        transform.Translate(new Vector3((_speed*_vertical), 0, 0)*Time.deltaTime);
    }
}
