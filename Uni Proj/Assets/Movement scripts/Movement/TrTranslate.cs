using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrTranslate : MonoBehaviour
{
    public float speed = 10f;
    private static readonly Vector3 Forward = Vector3.forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var delta = Forward * (speed * Time.deltaTime);

        transform.Translate(delta, Space.Self);

        transform.Translate(delta, Space.World);

        transform.Translate(delta);
    }
}
