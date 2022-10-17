using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveMessage : MonoBehaviour
{
    public OSC osc;

    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/Test", OnReceiveMsg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnReceiveMsg(OscMessage message)
    {
        
    }
}
