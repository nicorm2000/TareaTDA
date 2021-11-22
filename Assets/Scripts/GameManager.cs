using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerLife;
    public static int playerDamage;
    public static int enemyDamage;
    //De esta manera se puede acceder a la variable asi: GameManager.playerLife

    private void Awake()
    {
        playerLife = 100;
        playerDamage = 2;
        enemyDamage = 4;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void damagePlayer()
    {
        instance.playerLife -= GameManager.enemyDamage;
    }

    public static int getPlayerLife()
    {
        return instance.playerLife;
    }
}