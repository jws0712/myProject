using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public float movespeed = 10.0f;
    public GameObject pivot;
    public Camera viewCamera;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        Vector3 targetPos = new Vector3(mousePos.x, transform.position.y, mousePos.z);


        pivot.transform.LookAt(targetPos, Vector3.up);
    }
}
