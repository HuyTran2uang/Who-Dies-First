using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private int _dollar;

    public bool CheckEnoughDollar(int quantity) => quantity >= _dollar;

    public void IncreaseDollar(int quantity) => _dollar += quantity;

    public void UseDollar(int quantity) => _dollar -= quantity;

    public void LoadData() => _dollar = SaveLoadManager.Instance.Dollar;
    public void SaveData() => SaveLoadManager.Instance.SaveDataDollar(_dollar);
}
