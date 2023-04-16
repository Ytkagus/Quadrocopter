using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}