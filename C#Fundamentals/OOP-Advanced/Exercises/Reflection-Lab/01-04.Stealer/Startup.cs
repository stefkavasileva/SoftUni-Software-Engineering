using System;

public class Startup
{
    public static void Main()
    {
        var spy= new Spy();

        //////==============1==============//////
        //var result = spy.StealFieldInfo("Hacker", "username", "password");
        //System.Console.WriteLine(result);

        //////==============2==============//////
        //var result = spy.AnalyzeAcessModifiers("Hacker");
        //Console.WriteLine(result);

        //////==============3==============//////
        //var result = spy.RevealPrivateMethods("Hacker");
        //Console.WriteLine(result);

        //////==============4==============//////
        var result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}

