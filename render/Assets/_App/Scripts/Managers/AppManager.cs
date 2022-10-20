using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    [SerializeField]
    public OscManager oscManager;
    public MapManager mapManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // shortcut keyboard
        if (Input.GetKeyDown(KeyCode.R)) StartCoroutine(ReloadScene());
        if (Input.GetKeyDown(KeyCode.Q)) StartCoroutine(QuitScene());
    }

    #region Standard Functions

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

    #endregion
}
