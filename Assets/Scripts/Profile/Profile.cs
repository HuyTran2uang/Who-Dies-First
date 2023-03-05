using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Profile
{
    public string Name { get; set; }
    public FlagType Flag { get; set; }
    public string Skin { get; set; }

    public Profile() { }

    public Profile(string name, FlagType flag, string _skin = null)
    {
        Name = name;
        Flag = flag;
        Skin = Skin;
    }


}
