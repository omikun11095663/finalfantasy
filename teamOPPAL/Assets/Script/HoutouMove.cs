using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoutouMove : MonoBehaviour
{
    public float rotateSpeed = 0;
    public float seconds;
    public float rotationSmooth = 1;
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        Quaternion targetRotation = Quaternion.LookRotation(Player.position - transform.position);
        //Debug.Log("PlayerPosition = " + Player.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime
             * rotationSmooth);
    }

}
