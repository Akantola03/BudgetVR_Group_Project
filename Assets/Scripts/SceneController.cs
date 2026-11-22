using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Interactive
{
    public string SceneName;
    public new void Interact()
    {
        ChangeScene(SceneName);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
