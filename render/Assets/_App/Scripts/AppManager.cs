namespace Mapbox.Unity.Map
{
    using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using Mapbox.Unity.Utilities;
	using Utils;
	using UnityEngine;
	using Mapbox.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.MeshGeneration.Data;
	using System.Globalization;

    public class AppManager : MonoBehaviour
    {
        [SerializeField] GameObject map;
        AbstractMap abstractMap;
        
        void Start(){
            abstractMap = map.GetComponent<AbstractMap>();
            abstractMap.Initialize(new Vector2d(37.558811f, 126.925585f), 6);
            Debug.Log(abstractMap.Options.locationOptions.latitudeLongitude);
            
        }
    }

}

