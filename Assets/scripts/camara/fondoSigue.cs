using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoSigue : MonoBehaviour
{
    public float followSpeed = 2f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }

}
