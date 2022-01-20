using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramobile : MonoBehaviour
{
    public float speed;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                Vector2 rot = new Vector2(0, t.deltaPosition.x);
                transform.Rotate(rot * speed * Time.deltaTime, Space.Self);

            }
        }

    }
}

