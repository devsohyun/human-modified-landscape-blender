using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscManager : MonoBehaviour
{
    public OSC osc;
    public bool isOscOn;

    [SerializeField]
    public float latitude;
    public float longitude;
    
    void Start()
    {
        osc.SetAddressHandler( "/coordinate" , ReceiveMessage );
    }


    void ReceiveMessage(OscMessage message)
    {
        if (message.values[0].ToString() == "" || isOscOn == false) return;

        // string coordinate = JsonUtility.FromJson<Coordinate>("{\"coordinate\":" + message.values[0].ToString() + "}");

        latitude = float.Parse(message.values[0].ToString());
        longitude = float.Parse(message.values[1].ToString());
        
        Debug.Log("latitude: " + latitude + ", longitude: " + longitude);

    }
}