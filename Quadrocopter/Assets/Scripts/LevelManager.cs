using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int sceneNumber;
    private void Transition()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}