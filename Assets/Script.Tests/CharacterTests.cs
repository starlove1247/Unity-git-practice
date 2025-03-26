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
        character.SetAtk(90);

        // 建立敵人的元件
        var enemy = new GameObject().AddComponent<Enemy>();
        enemy.SetHp(100);

        // act
        // 玩家角色攻擊敵人
        character.Attack(enemy);
        character.Attack(enemy);

        // assert
        var hp = enemy.GetHp();
        Assert.AreEqual(0 , hp);
    }
}