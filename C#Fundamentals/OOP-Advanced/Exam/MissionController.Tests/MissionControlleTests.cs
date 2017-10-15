using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
[TestFixture]
public class MissionControlleTests
{
    [Test]
    public void ExecuteMission()
    {
        IMission mission = new Easy("name", 1.1, 2.2, 3.3, new List<IAmmunition>());
        List<ISoldier> missionTeam = new List<ISoldier>();
        missionTeam.Add(new Corporal("test", 3, 2, 4));
        missionTeam.Add(new Ranker("test", 15, 30, 15));

        Assert.IsFalse(missionTeam.Sum(w => w.OverallSkill) >= mission.ScoreToComplete);
    }

   
}

