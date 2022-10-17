using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveMessage : MonoBehaviour
{
    public OSC osc;

    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/coordinates", OnReceiveCoordinate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnReceiveCoordinate(OscMessage message)
    {
        if (message.values[0].ToString() == "") return;

        // float latitude = message.GetFloat(0);
        // float longitude = message.GetFloat(1);

        // Debug.Log("latitude: " + latitude + ", longitude: " + longitude);
        Debug.Log(message);
    }
}
