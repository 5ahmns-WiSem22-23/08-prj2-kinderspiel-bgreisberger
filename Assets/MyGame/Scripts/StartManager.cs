using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void PlayGameAgain()
    {
        SceneManager.LoadScene(0);
    }

}
