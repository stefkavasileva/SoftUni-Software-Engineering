public abstract class Mission : IMission
{
    //За създаване на мисия е необходимо единствено типа който в класа всъщност и точки
    //другите неща за какво са и то къде се взимат никаква идея
    protected Mission(double scoreToComplete)
    {
        //this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scoreToComplete;
        //this.WearLevelDecrement = wearLevelDecrement;
    }

    public string Name { get; protected set; }
    public double EnduranceRequired { get; protected set; }
    public double ScoreToComplete { get; protected set; }
    public double WearLevelDecrement { get; protected set; }
}

