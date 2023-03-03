using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviourSingleton<SaveLoadManager>
{
    private int _dollar;

    public int Dollar => _dollar;

    public void LoadAllData()
    {
        LoadDataDollar();
    }

    //money
    private void LoadDataDollar() => _dollar = PlayerPrefs.GetInt(GlobalKey.Dollar, 0);
    public void SaveDataDollar(int quantity) => PlayerPrefs.SetInt(GlobalKey.Dollar, quantity);
    //
}
