using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    [SerializeField] List<string> _skins = new List<string>();

    private void SetListSkin()
    {

    }

    public void UseSkin(Skin skin)
    {

    }
}

[System.Serializable]
public class Skin
{
    public SkinType type;
    public bool isOwner;
    public bool isUsing;
    public int dollar;

    public Skin(SkinType type, bool isOwner, bool isUsing)
    {
        this.type = type;
        this.isOwner = isOwner;
    }

    public void Use()
    {

    }

    public void Buy()
    {

    }
}

public enum SkinType
{
    Dollar,
    WatchAds,
    VIP,
}