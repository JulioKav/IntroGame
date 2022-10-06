using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Vector3 from;
    public Vector3 to;
    public float duration;
    private float _elapsed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var t = _elapsed / duration;
        transform.position = Vector3.Lerp(from, to, t);
        _elapsed += Time.deltaTime;
    }
}
