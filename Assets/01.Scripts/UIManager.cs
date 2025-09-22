#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public AudioSource music;
    // ���� �����
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        TimeScale(1);
    }

    // ���� ����
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
Application.Quit();
#endif
    }

    public void TimeScale(int scale)
    {
        Time.timeScale = scale;

        switch (scale)
        {
            case 0:
                music.Pause();
                break;
            case 1:
                music.Play();
                break;
        }
    }
}
