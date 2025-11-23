using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        if (!SceneManager.HasInstance)
        {
            var commonSceneLoadOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(m_xommonScene, LoadSceneMode.Additive);
            while (!commonSceneLoadOperation.isDone)
            {
                yield return null;
            }
        }
        Scene scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(m_scene.SceneName.Contains(scene.name))
        {
            SceneManager.Istance.SetFirstScene(this);
        }
        else if (m_active)
        {
            SetChildActive(false);
        }

        yield break;
    }
}
