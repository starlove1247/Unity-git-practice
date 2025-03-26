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
}
