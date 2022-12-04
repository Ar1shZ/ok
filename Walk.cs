using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Walk : MonoBehaviour
{
    // привет
    int health = 5;

    int level = 1;

    float speed = 1.2f;

 


    void Start()
    {
        health += level;
        Debug.Log("здоровье "+health);
    }


    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
