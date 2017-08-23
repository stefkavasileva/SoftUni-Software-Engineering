using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

public class GameController
{
    //private IDictionary<string, IList<ISoldier>> army;
    //private IDictionary<string, IList<IAmmunition>> wearHouse;

    private IList<ISoldier> army;
    private IList<IAmmunition> wearWouse;

    private MissionController missionControllerField;

    public GameController()
    {
        //this.Army = new Dictionary<string, IList<ISoldier>>();
        //this.WearHouse = new Dictionary<string, IList<IAmmunition>>();

        this.army=new List<ISoldier>();
        this.wearWouse = new List<IAmmunition>();

        // Изисква се армия и wearHouse .. тук имаме лист от тях ???
        //this.MissionControllerField = new MissionController();
    }

    //public IDictionary<string, IList<ISoldier>> Army
    //{
    //    get => this.army;
    //    private set => this.army = value;
    //}

    //public IDictionary<string, IList<IAmmunition>> WearHouse
    //{
    //    get => this.wearHouse;
    //    private set => this.wearHouse = value;
    //}

    //Защо подяволите е необходим този контролер
    public MissionController MissionControllerField
    {
        get { return missionControllerField; }
        private set { missionControllerField = value; }
    }

    //Метод на който подаваме инпута 
    public void GiveInputToGameController(string input)
    {
        // сплитваме
        var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //проверяваме каква е командата от инпута
        if (data[0].Equals("Soldier"))
        {
            string type = string.Empty;
            string name = string.Empty;
            int age = 0;
            int experience = 0;

            //double speed = 0d; // ненужна променлива 
            double endurance = 0d;
            //double motivation = 0; // ненужна променлива 
            //double maxWeight = 0d; // ненужна променлива  

            if (data.Length == 3)
            {
                type = data[1];
                name = data[2];
            }
            else
            {
                type = data[1];
                name = data[2];
                age = int.Parse(data[3]);
                experience = int.Parse(data[4]);
                //speed = double.Parse(data[5]);
                endurance = double.Parse(data[6]);
                // motivation = double.Parse(data[7]);
                //maxWeight = double.Parse(data[8]);
            }

            var soldiersFactory = new SoldierFactory();
            var soldier = soldiersFactory.CreateSoldier(type, name, age, experience, endurance);
            //switch (type)
            //{
            //    case "Ranker":
            //        var ranker = soldiersFactory.GenerateRanker(name, age, experience, endurance);

            //        //AddSoldierToArmy(ranker, type);
            //        break;
            //    case "Corporal":
            //        var corporal = soldiersFactory.GenerateCorporal(name, age, experience, endurance);
            //        // AddSoldierToArmy(corporal, type);
            //        break;
            //    case "Special-Force":
            //        var specialForce = soldiersFactory.GenerateSpecialForce(name, age, experience, endurance);
            //        // AddSoldierToArmy(specialForce, type);
            //        break;
            //    case "Regenerate":
            //        var soldierController = new SoldierController(); ;
            //        soldierController.TeamRegenerate(army, name);
            //        break;
            //        //case "Vacation": // излишни методи
            //        //    SoldierController.TeamGoesOnVacation(army, name);
            //        //    break;
            //        //case "Bonus":
            //        //    SoldierController.TeamGetBonus(army, name);
            //        //    break;
            //}

        }
        else if (data[0].Equals("WareHouse"))
        {
            string name = data[1];
            int number = int.Parse(data[2]);
            var ammunitionFactory = new AmmunitionFactory();
            var ammunition = ammunitionFactory.CreateAmmunition(name);
            this.AddAmmunitions(ammunition);
            // AddAmmunitions(ammunitionFactory.CreateAmmunitions(name, number));
        }
        else if (data[0].Equals("Mission"))
        {
            //Трябва да се направи проверка за това каква мисия да бъде стартирана и изобщо 
            //има ли смисъл от тези няколко вида мисии и как да се разбере кога коя мисия да бъде изпълнена
            //this.MissionControllerField.PerformMission(new Easy());
            var missionFactory = new MissionFactory();
            var mission = missionFactory.CreateMission(data[1], double.Parse(data[2]));
        }
    }

    //Какво прави този метод и изобщо трябва ли ми класа Output и каква му е работата в Core ??? 
    //public string RequestResult()
    //{
    //    return Output.GiveOutput(result, army, wearHouse, this.MissionControllerField.MissionQueue.Count);
    //}

    private void AddAmmunitions(IAmmunition ammunition)
    {
        this.wearWouse.Add(ammunition);
        //if (!this.WearHouse.ContainsKey(ammunition.Name))
        //{
        //    this.WearHouse[ammunition.Name] = new List<IAmmunition>();
        //    this.WearHouse[ammunition.Name].Add(ammunition);
        //}
        //else
        //{
        //    // тук трябва да се увеличи броя на уръжията в wearhouse но не виждам логика да се ползва 
        //    // речник от уръжия като има клас за тази работа а той трябва ли и трябвал и да държи лист 
        //    // от оръжия никаква идея
        //    //this.WearHouse[ammunition.Name][0].Number += ammunition.Number;
        //}
    }

    // ненужен метод
    //private void AddSoldierToArmy(ISoldier soldier, string type)
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

    //public void ProcessCommand(string input)
    //{
    //    List<string> data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    //    string commandExecute = data[0];
    //    data.RemoveAt(0);
    //    string pattern = Process + commandExecute + Command;
    //    try
    //    {
    //        this.GetType()
    //            .GetMethod(pattern, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
    //            .Invoke(this, new object[] { data });
    //    }
    //    catch (Exception exception)
    //    {
    //        this.Writer.StoreMessage(exception.InnerException.Message);
    //    }
    //}

}
