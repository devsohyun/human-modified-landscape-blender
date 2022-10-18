using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCManager : MonoBehaviour
{
    public OSC osc;

    public float latitude;
    public float longitude;
    
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

        latitude = float.Parse(message.values[0].ToString());
        longitude = float.Parse(message.values[1].ToString());
        Debug.Log("latitude: " + latitude + ", longitude: " + longitude);

    }
}