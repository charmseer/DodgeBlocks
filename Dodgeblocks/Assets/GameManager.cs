﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;
    public void EndGame()
    {
        Debug.Log("End Game");

        //StartCoroutine(RestartLevel());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

 /*   IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowness;

        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f/ slowness);
        
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }*/
}
