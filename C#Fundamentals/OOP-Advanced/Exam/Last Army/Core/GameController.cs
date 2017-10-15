using System;
using System.Collections.Generic;

public class GameController
{
    private Dictionary<string, IList<ISoldier>> army;
    private Dictionary<string, IList<IAmmunition>> wearHouse;
    private MissionController missionControllerField;

    public GameController()
    {
        this.Army = new Dictionary<string, IList<ISoldier>>();
        this.WearHouse = new Dictionary<string, IList<IAmmunition>>();
        //this.MissionControllerField = new MissionController();
    }

    public Dictionary<string, IList<ISoldier>> Army
    {
        get { return army; }
        set { army = value; }
    }

    public Dictionary<string, IList<IAmmunition>> WearHouse
    {
        get { return wearHouse; }
        set { wearHouse = value; }
    }

    public MissionController MissionControllerField
    {
        get { return missionControllerField; }
        set { missionControllerField = value; }
    }

    public void GiveInputToGameController(string input)
    {
        var soldierFactory = new SoldiersFactory();
        var data = input.Split();

        if (data[0].Equals("Soldier"))
        {
            var soldier = soldierFactory.CreateSoldier(data[2], int.Parse(data[3]), double.Parse(data[4]), double.Parse(data[5]));
            army[soldier.Name].Add(soldier);
            
            
            //string type = string.Empty;
            //string name = string.Empty;
            //int age = 0;
            //int experience = 0;
            //double speed = 0d;
            //double endurance = 0d;
            //double motivation = 0;
            //double maxWeight = 0d;

            //if (data.Length == 3)
            //{
            //    type = data[1];
            //    name = data[2];
            //}
            //else
            //{
            //    type = data[1];
            //    name = data[2];
            //    age = int.Parse(data[3]);
            //    experience = int.Parse(data[4]);
            //    speed = double.Parse(data[5]);
            //    endurance = double.Parse(data[6]);
            //    motivation = double.Parse(data[7]);
            //    maxWeight = double.Parse(data[8]);
            //}

            //switch (type)
            //{
            //    case "Ranker":
            //        var ranker = soldierFactory.GenerateRanker(name, age, experience, endurance);
            //        AddSoldierToArmy(ranker, type);
            //        break;
            //    case "Corporal":
            //        var corporal = soldierFactory.GenerateCorporal(name, age, experience, endurance);
            //        AddSoldierToArmy(corporal, type);
            //        break;
            //    case "Special-Force":
            //        var specialForce = soldierFactory.GenerateSpecialForce(name, age, experience, endurance);
            //        AddSoldierToArmy(specialForce, type);
            //        break;
            //    //case "Regenerate":
            //    //    soldierFactory.TeamRegenerate(army,name);
            //    //    break;
            //    //case "Vacation":
            //    //    SoldierController.TeamGoesOnVacation(army, name);
            //    //    break;
            //    //case "Bonus":
            //    //    SoldierController.TeamGetBonus(army, name);
            //    //    break;
            //}

        }
        else if (data[0].Equals("WearHouse"))
        {
            string name = data[1];

            var amunitionFactory= new AmmunitionFactory();
            AddAmmunitions(amunitionFactory.CreateAmmunition(data[1],double.Parse(data[2])));
        }
        else if (data[0].Equals("Mission"))
        {
            //create mission
            //this.MissionControllerField.PerformMission(new Easy());
        }
    }

    private void AddSoldierToArmy(ISoldier soldier, string type)
    {
        this.army[type].Add(soldier);
    }

    public string RequestResult()
    {
        //return Output.GiveOutput( army, wearHouse, this.MissionControllerField.MissionQueue.Count);
        ////
        /// 
        /// 
        /// 
        /// constanta
         var output = new Output();
        ;
        return output.GiveOutput(army, wearHouse, 3);

    }

    private void AddAmmunitions(IAmmunition ammunition)
    {
        if (!this.WearHouse.ContainsKey(ammunition.Name))
        {
            this.WearHouse[ammunition.Name] = new List<IAmmunition>();
            this.WearHouse[ammunition.Name].Add(ammunition);
        }
        //else
        //{
        //    this.WearHouse[ammunition.Name][0].Number += ammunition.Number;
        //}
    }

    //private void AddSoldierToArmy(Soldier soldier, string type)
    //{
    //    if (!soldier.CheckIfSoldierCanJoinTeam())
    //    {
    //        throw new ArgumentException($"The soldier {soldier.Name} is not skillful enough {type} team");
    //    }

    //    if (!this.Army.ContainsKey(type))
    //    {
    //        this.Army[type] = new List<Soldier>();
    //    }
    //    this.Army[type].Add(soldier);
    //}
}
