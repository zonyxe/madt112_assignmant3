using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickball : MonoBehaviour
{
    public GameObject GoalGameObject;
    private void OnMouseDrag()
    {      
       Vector3 mousePosWorld = Input.mousePosition;
        mousePosWorld.z = transform.position.z - Camera.main.transform.position.z;
        mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosWorld);

        transform.position = new Vector3(mousePosWorld.x, 
                                            mousePosWorld.y, 
                                            transform.position.z);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.Equals(GoalGameObject))
        {
            Debug.Log("win");
        }
    }
}
