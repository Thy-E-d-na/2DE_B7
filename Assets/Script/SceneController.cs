using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneControlle : MonoBehaviour
{
    [SerializeField] private GameObject _opt;
    private void Awake()
    {
        SoundManager.instance.PlayBGM(0);
    }
    public void loadScene()
    {
       SceneManager.LoadScene("SampleScene");
        SoundManager.instance.stopSound();
    }
    public void optBnt() => _opt.gameObject.SetActive(!_opt.gameObject.activeSelf);
    public void Quit() => Application.Quit();
}
