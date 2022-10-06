using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform character;
    private readonly Vector3 _targetposition = new(30, 20, 5);
    private const int Speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = Vector3.MoveTowards(transform.position, character.position, Speed * Time.deltaTime);
    }
}
