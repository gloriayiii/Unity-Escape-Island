using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbutton : MonoBehaviour
{
    public void replaygame()
    {
        SceneManager.LoadScene(1);
    }
}
