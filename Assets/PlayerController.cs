using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] Target;
    public UnityEngine.AI.NavMeshAgent agent;
    public int targetNumber;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {
        targetNumber = 0;
        //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Target = GameObject.FindGameObjectsWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        
        //agent.destination = Target[targetNumber].transform.position; 

        transform.position = Vector3.MoveTowards(transform.position, Target[targetNumber].transform.position, 3 * Time.deltaTime);
        
        distance = Vector3.Distance(transform.position,Target[targetNumber].transform.position);

        if(distance < .5F){
            targetNumber++;

            if(targetNumber==Target.Length){
                targetNumber=0;
            }
        }

        var targetRotation = Quaternion.LookRotation(Target[targetNumber].transform.position - transform.position);
       
        // Smoothly rotate towards the target point.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2 * Time.deltaTime);



    }

}
