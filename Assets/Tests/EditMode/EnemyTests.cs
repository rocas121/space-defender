using UnityEngine;

using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class EnemyTests
{
    private Enemy _enemy;

    [SetUp]
    public void SetUp()
    {
        _enemy = new Enemy();   
    }


    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse()
    {
        int damage = 100;

        _enemy.TakeDamage(damage);

        Assert.IsFalse(_enemy.IsAlive);
    }


    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero()
    {
        int damage = 100;

        _enemy.TakeDamage(damage);
        int result = _enemy.GetReward();

        Assert.AreEqual(0, result);

    }

}
