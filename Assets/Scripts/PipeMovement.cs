using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float pipeSpeed = 1.5f;

    public void Update()
    {
        transform.Translate(Vector3.left * pipeSpeed * Time.deltaTime);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
