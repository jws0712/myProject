using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_GameObject : MonoBehaviour
{
    public int hp = 30;
    public Vector3 pos = Vector3.zero;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        hp = 50;

        pos = new Vector3(0, 0, 0);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveSpeed += 1;
        }
 
    }

    public void MoveCube()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * Time.deltaTime * moveSpeed;

       //if (Input.GetKey(KeyCode.UpArrow))
       // {
       //     transform.position += new Vector3(0.0f, moveSpeed * Time.deltaTime, 0.0f);
       // }

       //if (Input.GetKey(KeyCode.DownArrow))
       // {
       //     transform.position += new Vector3(0.0f, -moveSpeed * Time.deltaTime, 0.0f);
       // }
       //if (Input.GetKey(KeyCode.LeftArrow))
       // {
       //     transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0.0f, 0.0f);
       // }
       //if (Input.GetKey(KeyCode.RightArrow))
       // {
       //     transform.position += new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f );
       // }
    }
}
