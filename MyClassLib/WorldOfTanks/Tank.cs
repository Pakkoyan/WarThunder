using System.Reflection;

namespace MyClassLib.WorldOfTanks;

public abstract class Tank
{
    readonly int Ammunition;
    readonly int LevelOfArmor;
    readonly int Maneuverability;

    public Tank()
    {
        Random random = new Random();
        Ammunition = random.Next(1, 101);
        LevelOfArmor = random.Next(1, 101);
        Maneuverability = random.Next(1, 101);
    }

    public static bool operator*(Tank firstTank, Tank secondTank)
    {
        int firstReception = 0;
        int secodReception = 0;
        
        firstReception += firstTank.Ammunition - secondTank.Ammunition;
        secodReception += secondTank.Ammunition - firstTank.Ammunition;
        firstReception += firstTank.LevelOfArmor - secondTank.LevelOfArmor;
        secodReception += secondTank.LevelOfArmor - firstTank.LevelOfArmor;
        firstReception += firstTank.Maneuverability - secondTank.Maneuverability;
        secodReception += secondTank.Maneuverability - firstTank.Maneuverability;

        if (firstReception > secodReception)
        {
            return true;
        }
        else if (secodReception > firstReception)
        {
            return false;
        }
        else
        {
            throw new ArgumentException("Пат");
        }
        
        
        
    }

    public void GetInfo()
    {
        Console.WriteLine("------------ {0} ------------", LevelOfArmor);
        Console.WriteLine("------------ {0} ------------", Ammunition);
        Console.WriteLine("------------ {0} ------------", Maneuverability);
    }
    
}

public class T34 : Tank
{
    public string Name = "T34";
}

public class Pantera : Tank
{
    public string Name = "Pantera";
}
