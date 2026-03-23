using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene : MonoBehaviour
{
  public void LoadNextScene(string sceneName)
  {
	  SceneManager.LoadScene(sceneName);
  }
}
