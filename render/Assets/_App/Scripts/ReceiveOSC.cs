using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveOSC : MonoBehaviour
{
    public OSC osc;

    // public class Coordinate
    // {
    //     public float latitude;
    //     public float longitude;
    // }
    
    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler( "/coordinate" , ReceiveMessage );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReceiveMessage(OscMessage message)
    {
        if (message.values[0].ToString() == "") return;

        // string coordinate = JsonUtility.FromJson<Coordinate>("{\"coordinate\":" + message.values[0].ToString() + "}");

        float latitude = float.Parse(message.values[0].ToString());
        float longitude = float.Parse(message.values[1].ToString());
        Debug.Log("latitude: " + latitude + ", longitude: " + longitude);

    }
}