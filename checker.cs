using System;
using System.Diagnostics;
namespace Checkers
{
public class CheckBPM
{
    internal void Check_BPM(float bpm)
    {
        if(bpm>150)
        {
            Console.WriteLine("bpm is high");
        }
        else if(bpm>150)
        {
            Console.WriteLine("bpm is low");
        }
        else
        {
            Console.WriteLine("bpm is normal");
        }
    }
}

public class CheckSPO2
{
    internal void Check_spo2(float spo2)
    {
        if(spo2>90)
        {
            Console.WriteLine("spo2 is normal");
        }
        else
        {
            Console.WriteLine("spo2 level is low");
        }
    }
}

public class CheckResperate
{
    internal void Check_Resperate(float resperate)
    {
        if(resperate>95)
        {
            Console.WriteLine("respiration rate is high");
        }
        else if(resperate<30)
        {
            Console.WriteLine("respiration rate is low");
        
        }
        else
        {
            Console.WriteLine("respiration rate is normal");
        }
    }
}
public delegate void VitalDataCheck(float value);

public class Evaluate
{
    VitalDataCheck vitalDataCheck;
    public Evaluate(VitalDataCheck vitalDataCheck)
    {
        this.vitalDataCheck=vitalDataCheck;
    }
    public void eval(float vitalDataCheck)
    {
        this.vitalDataCheck.invoke(vitalDataCheck);
    }
}
public class Program
{
    static CheckBPM checkBPM= new CheckBPM();
    static CheckSPO2 checkspo2=new CheckSPO2();
    static CheckResperate checkResperate =new CheckResperate();
    static int Main()
    {
       Evaluate evalBPM=new Evaluate(new VitalDataCheck(CheckBPM.Check_BPM));
       evalBPM.eval(75);

       Evaluate evalSPO2=new Evaluate(new VitalDataCheck(CheckSPO2.Check_SPO2));
       evalSPO2.eval(75);

       Evaluate evalResperate=new Evaluate(new VitalDataCheck(CheckResperate.Check_Resperate));
       evalResperate.eval(75);
        
    }
}
}