using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Button prevBtn;
    public Button nextbtn;

    private void Start()
    {
        prevBtn.onClick.AddListener(onPrevBtnClicked);
        nextbtn.onClick.AddListener(onNextBtnClicked);
    }

    private void onPrevBtnClicked()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }

    private void onNextBtnClicked()
    {
        if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
