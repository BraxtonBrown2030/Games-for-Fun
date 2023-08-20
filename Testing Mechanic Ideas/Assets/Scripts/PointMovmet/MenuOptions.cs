using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public Canvas playerUi;
    public int sceneToLoad;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        




    }
    public void SceneChange()
    {

        SceneManager.LoadScene(sceneToLoad);

    }
}
