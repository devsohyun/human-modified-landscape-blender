namespace Mapbox.Examples
{
	using Mapbox.Geocoding;
	using UnityEngine.UI;
	using Mapbox.Unity.Map;
	using UnityEngine;
	using System;
	using System.Collections;

    public class MapManager : MonoBehaviour
    {
        public float currentLatitude;
        public float currentLongitude;
        public float currentZoom;
        public float zoomMax;
        Camera _camera;
		Vector3 _cameraStartPos;
		AbstractMap _map;

        #region Standard
        void Awake()
		{
			_camera = Camera.main;
			_cameraStartPos = _camera.transform.position;
			_map = FindObjectOfType<AbstractMap>();
        }

        #endregion

        #region Map Setting
        
        // IEnumerator NextMap()
        // {
        //     // set zoom
        //     if (_zoom != 0)
        //         {
        //             _map.OnUpdated += () => { _zoom = _map.Zoom; };
        //         }
        // }

        #endregion
    }

}

