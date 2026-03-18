using UnityEngine;

using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class ScoreTest
{
    private ScoreCalculator _scoreCalculator;

    [SetUp]
    public void SetUp()
    {
        _scoreCalculator = new ScoreCalculator();   
    }


    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        int kills = 0;
        int time = 1;

        int result = _scoreCalculator.Calculate(kills, time);

        Assert.AreEqual(0, result);
    }


    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {
        
        int kills = 3;
        
        _scoreCalculator.ApplyCombo(kills);

        Assert.AreEqual(3, _scoreCalculator.Multiplier);
    }

    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {
        int kills = 3;

        _scoreCalculator.ApplyCombo(kills);
        _scoreCalculator.ResetMultiplier();

        Assert.AreEqual(1f, _scoreCalculator.Multiplier);
    }


    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {

        int kills = 3;
        int time = 1;

        _scoreCalculator.Calculate(kills,time);

        Assert.AreEqual(1f, _scoreCalculator.Multiplier);
    }
}
