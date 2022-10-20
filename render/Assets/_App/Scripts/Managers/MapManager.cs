using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;




public class MapManager : MonoBehaviour
{
    [SerializeField]
    public AppManager appManager;
    public GameObject mapBox;

    [SerializeField]
    AbstractMap _map;
    string[] _locationStrings;

    [SerializeField]
    Vector2d[] _locations;


	
    // Start is called before the first frame update
    void Start()
    {
        _locations = new Vector2d[_locationStrings.Length];

    }

    // Update is called once per frame
    void Update()
    {

        // Debug keyboard
        if (Input.GetKeyDown(KeyCode.D)){
               
        }
    }


}
