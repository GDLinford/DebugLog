using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLog : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("GRIM REAPER");
       
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Moon"); 
        
    }

    private void FixedUpdate()
    {
        Debug.Log("GoodBye World");
    }

    private void LateUpdate()
    {
        Debug.Log("See you soon!");
    }


}
