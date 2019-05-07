using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{

    public GameObject[] positions;
    private int position = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().autoBraking = false;

        patrol();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<NavMeshAgent>().pathPending && GetComponent<NavMeshAgent>().remainingDistance < 0.5f)
        {
            patrol();
        }
    }

    void patrol()
    {
        GetComponent<NavMeshAgent>().destination = positions[position].transform.position;

        if (position < 3)
        {
            position++;
        }
        else
        {
            position = 0;
        }
    }
}
