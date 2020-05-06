using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSP : MonoBehaviour
{
    [SerializeField] Mover prefabtospawn;
    [SerializeField] Vector3 velocityobject;
    [Tooltip("max")] [SerializeField] float minbetsp = 1f;
    [Tooltip("max")] [SerializeField] float maxbetsp = 3f;
    [Tooltip("max")] [SerializeField] float maxDist = 0.5f;
    void Start()
    {
        this.StartCoroutine(x());
    }

    private IEnumerator x ()
    {
        while (true)
        {
            float timebesp = Random.Range(minbetsp, maxbetsp);
            yield return new WaitForSeconds(timebesp);
            Vector3 positionOfspob = new Vector3(
                transform.position.x + Random.Range(-maxDist, +maxDist),
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabtospawn.gameObject, positionOfspob, Quaternion.identity);
            newObject.GetComponent<Mover>().setVelocity(velocityobject);
        }
    }
    





    void Update()
    {
        
    }
}
