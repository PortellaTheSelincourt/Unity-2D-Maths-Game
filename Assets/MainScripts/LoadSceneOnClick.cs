using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

    public void LoadByIndex(int sceneIndex)  // pass this value to the a button, depending what the value is (1,2,3) it will be a diferent scene in unity
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
