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
        #region Variables
        
        [Header("Map")]
        [SerializeField] GameObject map;
        AbstractMap abstractMap;

        [Header("NDI")]
        public bool allow_NDI;
        public Camera mainCamera;

        [Header("Dependencies")]
        public NdiManager ndiManager;

        #endregion
        
        void Awake()
        {
            ndiManager.transform.gameObject.SetActive(true);

            if (allow_NDI) mainCamera.targetTexture = ndiManager.rt_main_camera;
        }

        void Start()
        {
            abstractMap = map.GetComponent<AbstractMap>();
            abstractMap.Initialize(new Vector2d(37.558811f, 126.925585f), 6);
            Debug.Log(abstractMap.Options.locationOptions.latitudeLongitude);
            
        }

        public void Update()
        {
            // shortcut keyboard
            // if (Input.GetKeyDown(KeyCode.R)) StartCoroutine(ReloadScene());
            // if (Input.GetKeyDown(KeyCode.Q)) StartCoroutine(QuitScene());
        }

        public IEnumerator ReloadScene()
        {
            yield return new WaitForEndOfFrame();
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }

        public IEnumerator QuitScene()
        {
            yield return new WaitForEndOfFrame();
            Application.Quit();
        }
    }

}

