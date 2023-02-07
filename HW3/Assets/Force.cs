using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private Rigidbody2D body;
    private int counter = 60;
    private bool right = true;
    [SerializeField]
    public float Amplitude;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (counter > 120)
        {
            if (right)
                right = false;
            else
                right = true;

            counter = 0;
        }

        if (right)
            body.AddForce(new Vector2(Amplitude, 0));
        else
            body.AddForce(new Vector2(Amplitude * -1, 1));

        counter++;

    }

}
