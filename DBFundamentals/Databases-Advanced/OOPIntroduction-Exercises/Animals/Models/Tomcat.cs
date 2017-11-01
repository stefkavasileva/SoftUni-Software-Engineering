public class Tomcat :Cat
{
    public Tomcat(string name, int age, string gender) 
        : base(name, age, gender)
    {

    }

    public override string ProduceSound()
    {
       return Constats.TomcatSound;
    }
}

