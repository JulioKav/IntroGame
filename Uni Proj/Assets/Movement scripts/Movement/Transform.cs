using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messing_around : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 _oldPosition;
    public Vector3 _velocity = new(2, 2, 0);
    void Start()
    {
        _oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_oldPosition.x + _velocity.x,
                                         _oldPosition.y + _velocity.y,
                                         _oldPosition.x + _velocity.z);
        _oldPosition = transform.position;
    }
}
