using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Camera MainCamera;
    private Vector2 screenBounds;
    [Tooltip("movment vector")][SerializeField] Vector3 velocity;
    void Start()
    {
        MainCamera = Camera.main;
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }

    
    void Update()
    {
        Vector3 viewPos = transform.position;
        if (viewPos.y < screenBounds.y * -1)
            Destroy(gameObject);
        else
            transform.position += velocity * Time.deltaTime;

    }

    public void setVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}

//private Camera MainCamera;
//private Vector2 screenBounds;
//private float objectWidth;
//private float objectHeight;

//// Use this for initialization
//void Start()
//{
//    MainCamera = Camera.main;
//    screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
//    objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
//    objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
//}

//// Update is called once per frame
//void LateUpdate()
//{
//    Vector3 viewPos = transform.position;
//    viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
//    viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
//    transform.position = viewPos;
//}
