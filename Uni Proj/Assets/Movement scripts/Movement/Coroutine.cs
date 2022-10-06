using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{


    private Vector3 _targetPosition = new(30,5,25);
    private Vector3 _positionModifier;
    private const int Speed = 10;

    void Start()
    {
        _positionModifier = (_targetPosition - transform.position) / Speed;
        StartCoroutine(nameof(Move));

    }

    private IEnumerator Move()
    {   
        while (transform.position != _targetPosition)
        {
            transform.position += _positionModifier;
            yield return new WaitForSeconds(1);


        }
        
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
