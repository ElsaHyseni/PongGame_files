using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayer1;
    public float speed = 5.2f;
 

    void Update()
    {
        if (isPlayer1)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
        }

        transform.position = new Vector3( transform.position.x , Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);

    }
}
