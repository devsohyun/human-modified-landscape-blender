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
        public float latitude;
        public float longitude;
        public float zoom;
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
        
        public void NextMap(float _zoom)
        {
            // set zoom
            if (_zoom != 0)
                {
                    _map.OnUpdated += () => { _zoom = _map.Zoom; };
                }
        }

        #endregion
    }

}

