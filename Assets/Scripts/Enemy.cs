using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;

    public void SetHp(int hpValue)
    {
        hp = hpValue;
    }

    public void TakeDamage(int damage)
    {
        // 如果已經死亡，不做後面的事情
        if(hp <=0) return; // early return

        // 設定目前血量 為 目前血量 - 傷害
        // hp = hp - damage;
        hp -= damage; // -80
        var isDead = hp < 0;
        if (isDead)
        {
            hp = 0; // 血量最低為0
        }
    }

    

    public int GetHp()
    {
        return hp;
    }
}