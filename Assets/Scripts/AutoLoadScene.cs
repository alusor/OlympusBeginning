﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AutoLoadScene : MonoBehaviour {

    public string NextLevel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(NextLevel);
        //Application.LoadLevel(NextLevel);
    }
}
