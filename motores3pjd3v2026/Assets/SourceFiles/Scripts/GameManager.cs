using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
      
        SceneManager.LoadScene("GetStarted_Scene");

       
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }
}