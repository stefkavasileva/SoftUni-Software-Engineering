using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class TestClass
{
    private MissionController missionController;

    [SetUp]
    public void TestInitialize()
    {
        this.missionController = new MissionController(new Army(), new WareHouse());
    }

    [Test]
    public void MissionsCountTest()
    {
        this.missionController.Missions.Enqueue(new Easy(12.5));
        this.missionController.Missions.Enqueue(new Hard(56));
        this.missionController.Missions.Enqueue(new Hard(5));

        Assert.AreEqual(3, this.missionController.Missions.Count);
    }

    [Test]
    public void FailedMissionCounterTest()
    {
        this.missionController.Missions.Enqueue(new Easy(12.5));
        this.missionController.Missions.Enqueue(new Hard(56));
        this.missionController.Missions.Enqueue(new Hard(5));
        this.missionController.Missions.Enqueue(new Hard(6));

        this.missionController.PerformMission(new Easy(23));

        Assert.AreEqual(1, this.missionController.FailedMissionCounter);
    }

    [Test]
    public void PerformMissionTest()
    {
        IArmy army = new Army();
        army.AddSoldier(new Corporal("Pepo", 12, 23, 2));
        army.AddSoldier(new Corporal("Ricky", 29, 29, 20));
        IWareHouse wareHouse = new WareHouse();
        wareHouse.AddAmmunitions("AutomaticMachine", 12);
        wareHouse.AddAmmunitions("Gun", 3);
        wareHouse.AddAmmunitions("Helmet", 5);
        wareHouse.AddAmmunitions("Knife", 12);
        wareHouse.AddAmmunitions("MachineGun", 3);
        wareHouse.AddAmmunitions("NightVision", 5);
        wareHouse.AddAmmunitions("RPG", 56);
        MissionController mc = new MissionController(army, wareHouse);

        mc.Missions.Enqueue(new Easy(12.5));
        mc.Missions.Enqueue(new Hard(56));
        mc.Missions.Enqueue(new Hard(5));
        mc.Missions.Enqueue(new Hard(6));

        string res = mc.PerformMission(new Easy(23));
        int n = res.Length;

        Assert.AreEqual(229, n);
    }

    //[SetUp]
    //public void TestInitialize()
    //{
    //    this.missionController = new MissionController(new Army(), new WareHouse());
    //}

    //[Test]
    //public void ExecuteMission()
    //{
    //    IMission mission = new Medium(200);
    //    List<ISoldier> missionTeam = new List<ISoldier>();

    //    var soldier = new Corporal("corporal", 15, 10, 11);
    //    var secondSoldier = new SpecialForce("special", 10, 14, 22);
    //    missionTeam.Add(soldier);
    //    missionTeam.Add(secondSoldier);

    //    Assert.AreEqual(false, missionTeam.Sum(w => w.OverallSkill) >= mission.ScoreToComplete);
    //}

    //[Test]
    //public void FailedMissionCounterTest()
    //{
    //    this.missionController.Missions.Enqueue(new Easy(7));
    //    this.missionController.Missions.Enqueue(new Hard(56));
    //    this.missionController.Missions.Enqueue(new Medium(50));
    //    this.missionController.Missions.Enqueue(new Hard(360));

    //    this.missionController.PerformMission(new Easy(2));

    //    Assert.AreEqual(1, this.missionController.FailedMissionCounter);
    //}

    //[Test]
    //public void PerformMissionTest()
    //{
    //    IArmy army = new Army();
    //    army.AddSoldier(new Corporal("Test", 18, 33, 2));
    //    army.AddSoldier(new SpecialForce("Special", 2, 20, 10));
    //    IWareHouse wareHouse = new WareHouse();
    //    wareHouse.AddAmmunitions("AutomaticMachine", 4);
    //    wareHouse.AddAmmunitions("Gun", 30);
    //    wareHouse.AddAmmunitions("Helmet", 54);
    //    wareHouse.AddAmmunitions("Knife", 10);
    //    wareHouse.AddAmmunitions("MachineGun", 47);
    //    wareHouse.AddAmmunitions("NightVision", 21);
    //    wareHouse.AddAmmunitions("RPG", 85);
    //    MissionController missionController = new MissionController(army, wareHouse);

    //    this.missionController.Missions.Enqueue(new Easy(7));
    //    this.missionController.Missions.Enqueue(new Hard(56));
    //    this.missionController.Missions.Enqueue(new Medium(50));
    //    this.missionController.Missions.Enqueue(new Hard(360));

    //    string res = missionController.PerformMission(new Easy(2));
    //    int n = res.Length;

    //    Assert.AreEqual(229, n);
    //}
}

