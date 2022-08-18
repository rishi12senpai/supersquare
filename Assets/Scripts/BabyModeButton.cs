using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BabyModeButton : MonoBehaviour
{
    public void PlayBabyMode()
	{
		SceneManager.LoadScene(1);
	}
}
