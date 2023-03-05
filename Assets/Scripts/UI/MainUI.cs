using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    [SerializeField] Button _btnWeapon;
    [SerializeField] Button _btnAvatar;

    private void OnWeaponButtonClicked()
    {
        MenuManager.Instance.Open("Weapon");
    }

    private void OnAvatarButtonClicked()
    {
        MenuManager.Instance.Open("Avatar");
    }

    private void Start()
    {
        _btnWeapon.onClick.AddListener(() => this.OnWeaponButtonClicked());
        _btnAvatar.onClick.AddListener(() => this.OnAvatarButtonClicked());
    }
}
