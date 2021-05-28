using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdaownLength = 2f;
    public void EndGame()
    {
        Debug.Log("End Game");
        Invoke("Restart", 2);
        //StartCoroutine(RestartLevel());
        
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
/*    IEnumerator RestartLevel()
    {
        Time.timeScale += (1f / slowness)* Time.deltaTime;

        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f/ slowness);
        
        Time.timeScale = slowdownLength;
        Time.fixedDeltaTime = Time.fixedDeltaTime * 0.2f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
