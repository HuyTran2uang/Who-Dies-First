using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPanel : MonoBehaviour
{
    [SerializeField] Button _btnClose;

    private void OnCloseButtonClicked()
    {
        MenuManager.Instance.Open("Option");
    }

    private void Start()
    {
        _btnClose.onClick.AddListener(() => this.OnCloseButtonClicked());
    }
}
