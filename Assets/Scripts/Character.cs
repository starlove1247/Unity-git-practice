using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int atk;

    public void Attack(Enemy enemy)
    {
        // 錯誤作法
        // enemy.hp = enemy.hp - atk;
        enemy.TakeDamage(atk);
    }

    public void SetAtk(int atkValue)
    {
        atk = atkValue;
    }

    /// <summary>
    /// 攻擊偵測到的所有敵人
    /// </summary>
    public void AttackAllTriggeredEnemies()
    {
        // for (var i = 0 ; i < enemies.Count ; i++) // i+1
        // {
        //     Debug.Log(i);
        //     enemies[i].TakeDamage(atk);
        // }

        foreach (var enemy in enemies)
        {
            enemy.TakeDamage(atk);
        }
    }
    /// <summary>
    /// 偵測到的敵人
    /// </summary>
    private List<Enemy> enemies = new List<Enemy>();
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        var enemy = collider2D.GetComponent<Enemy>();
        enemies.Add(enemy);
    }
}