using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //3
    private Player player;
    private List<Enemy> enemies;
    // Start is called before the first frame update
    void Start()
    {
        //Las variables declaradas en Start se eliminan despues de terminar el Start
       //1
        Player jugador1 = new Player("Fernando");
        Empty nulo = new Empty("nuloFernando");
        //2
        var nombres = new[] { "Jose", "Federico", "Alfredo", "Luis", "Francisco" };
        const int MaxEnemies = 5;
        Character[] EnemyList = new Character[MaxEnemies];
        for (int i = 0; i < MaxEnemies; i++)
        {
            Enemy enemy = new Enemy(nombres[i]);
            EnemyList[i] = enemy;
        }
        //3
        enemies = new List<Enemy>();
        enemies.Add(new Enemy(nombres[0]));
        enemies.Add(new Enemy(nombres[1]));
        enemies.Add(new Enemy(nombres[2]));
    }

    // Update is called once per frame
    void Update()
    {
        var enemy = enemies.First(e => e.Name == "Alfredo");
    }
}
