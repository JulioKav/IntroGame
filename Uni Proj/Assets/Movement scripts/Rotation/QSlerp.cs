using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QSlerp : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        Quaternion from = transform.rotation;

        Quaternion to = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(from, to, Time.deltaTime);
    }
}
