using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dustbunny : MonoBehaviour
{
    private void onTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        Debug.Log("dustbunng working");

        GetComponent<Attacker>().Attack(otherObject);

        // if(otherObject.GetComponent<Defender>())
        // {
        //     GetComponent<Attacker>().Attack(otherObject);
        // }
    }
}
