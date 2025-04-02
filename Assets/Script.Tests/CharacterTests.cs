using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using NUnit.Framework;
using UnityEngine;

public class CharacterTests
{
    [Test(Description = "角色攻擊敵人")]
    public void Character_Attack_Enemy()
    {
        // arrange
        // 建立玩家角色的元件
        var go1 = new GameObject();
        go1.AddComponent<Character>();
        var character = go1.GetComponent<Character>();
        character.SetAtk(10);

        // 建立敵人的元件
        var go2 = new GameObject();
        go2.AddComponent<Enemy>();
        var enemy = go2.GetComponent<Enemy>();
        enemy.SetHp(100);

        // act
        // 玩家角色攻擊敵人
        character.Attack(enemy);

        // assert
        // enemy.hp -= 100; // 不應破壞封裝，錯誤範例
        var hp = enemy.GetHp();
        Assert.AreEqual(90 , hp);
    }

    [Test(Description = "攻擊已死亡的敵人就不會繼續扣血，血量最低為0")]
    public void Character_Attack_Dead_Enemy()
    {
        // arrange
        // 建立玩家角色的元件
        var character = new GameObject().AddComponent<Character>();
        character.SetAtk(30);

        // 建立敵人的元件
        var enemy = new GameObject().AddComponent<Enemy>();
        enemy.SetHp(20);

        // act
        // 玩家角色攻擊敵人
        character.Attack(enemy);

        // assert
        var hp = enemy.GetHp();
        Assert.AreEqual(0 , hp);
    }

    [Test(Description = "角色攻擊偵測區域內的所有敵人")]
    public void Character_Attack_All_Triggered_Enemies()
    {
        // arrange
        // 建立玩家角色的元件
        var character = new GameObject().AddComponent<Character>();
        character.SetAtk(10);
        // 建立敵人的元件
        var enemy1        = new GameObject().AddComponent<Enemy>();
        var enemy1Collider = enemy1.gameObject.AddComponent<BoxCollider2D>();
        enemy1.SetHp(100);
        var enemy2 = new GameObject().AddComponent<Enemy>();
        var enemy2Collider = enemy2.gameObject.AddComponent<BoxCollider2D>();
        enemy2.SetHp(100);
        character.OnTriggerEnter2D(enemy1Collider);
        character.OnTriggerEnter2D(enemy2Collider);

        // act
        // 玩家角色攻擊
        character.AttackAllTriggeredEnemies();

        // assert
        Assert.AreEqual(90 , enemy1.GetHp());
        Assert.AreEqual(90 , enemy2.GetHp());
    }
}