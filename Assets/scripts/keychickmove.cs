using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class keychickmove : MonoBehaviour
{
    [Tooltip("speed in m/s")] [SerializeField] float speed;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }
}
