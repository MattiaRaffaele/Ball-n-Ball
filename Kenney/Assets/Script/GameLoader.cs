using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{

    [Tooltip("Scene that needs to be loaded")]
    [SerializeField] int sceneIndex;


    [Header("Loading slider")]
    [Tooltip("Slider in the loading screen")]
    [SerializeField] Slider slider;




    private void Start()
    {
        StartGameVoid(sceneIndex);
    }

    public void StartGameVoid(int sceneIndex)
    {
        StartCoroutine(StartGame(sceneIndex));
    }

    public IEnumerator StartGame(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
}
