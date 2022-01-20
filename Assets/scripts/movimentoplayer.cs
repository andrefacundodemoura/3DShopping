using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoplayer : MonoBehaviour
{
    public FixedJoystick joystick;

    public float speed = 10.0f;

    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = joystick.Horizontal * speed * Time.deltaTime;
        vertical = joystick.Vertical * speed * -Time.deltaTime;

        transform.Translate(vertical, 0, horizontal);




    }
}

