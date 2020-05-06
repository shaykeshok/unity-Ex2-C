using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [Tooltip("blla")] [SerializeField] string trigr;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == trigr)
            Destroy(this.gameObject);
            Destroy(other.gameObject);
    }



}
