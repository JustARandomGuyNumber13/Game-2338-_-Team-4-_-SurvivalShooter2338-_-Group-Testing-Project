﻿using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;


    Animator anim;
	float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

            if (restartTimer >= restartDelay) {
                
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
			}
        }
    }
}
