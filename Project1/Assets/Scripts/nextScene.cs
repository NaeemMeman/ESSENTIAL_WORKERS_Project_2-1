using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{

    public Animator transition;
    
    public float transitionTime = 1f;
    
    void Update()
    {

    }
    
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex+1));
    }
    
    private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex+1;
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }
    
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        
        yield return new WaitForSeconds(transitionTime);
        
        SceneManager.LoadScene(levelIndex);
    }
}
