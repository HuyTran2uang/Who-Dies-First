using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileManager : MonoBehaviourSingleton<ProfileManager>
{
    [SerializeField] private Profile _playerProfile = new Profile();
    [SerializeField] private Profile _botProfile = new Profile();
    [SerializeField] private List<Profile> _botProfiles = new List<Profile>();

    public void SetPlayerName(string name)
    {
        _playerProfile.Name = name;
    }

    public void SetPlayerFlag(FlagType flag)
    {
        _playerProfile.Flag = flag;
    }

    public void SetPlayerSkin(string skin)
    {
        _playerProfile.Skin = skin;
    }

    public void SetBotProfile()
    {
        _botProfile = _botProfiles[Random.Range(0, _botProfiles.Count)];
    }

    private void ListBotProfile()
    {
        _botProfiles = new List<Profile>();
        _botProfiles.Add(new Profile("A", FlagType.Vietnam));
        _botProfiles.Add(new Profile("B", FlagType.Brazil));
        _botProfiles.Add(new Profile("C", FlagType.America));
        _botProfiles.Add(new Profile("D", FlagType.China));
        _botProfiles.Add(new Profile("E", FlagType.Indonesia));
    }

    private void Awake()
    {
        this.ListBotProfile();
        this.SetBotProfile();
        this.SetPlayerName("Player123");
    }
}

public enum FlagType
{
    Vietnam,
    England,
    America,
    Brazil,
    China,
    Thailand,
    Malaysia,
    Indonesia,
}
