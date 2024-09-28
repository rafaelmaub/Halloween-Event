using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        //Moving enemy
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
