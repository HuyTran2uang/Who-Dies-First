using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionPanel : MonoBehaviourSingleton<OptionPanel>
{
    [SerializeField] private TMP_InputField _inputName;
    [SerializeField] private TMP_Dropdown _dropdownOptionFlag;
    [SerializeField] private Button _btnPlay;

    public void DropdownOptionFlag(List<FlagType> flags)
    {
        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
        foreach (var flag in flags)
        {
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
            option.text = flag.ToString();
        }
        _dropdownOptionFlag.AddOptions(options);
    }

    private void OnPlayButtonClicked()
    {
        ProfileManager.Instance.SetPlayerName(_inputName.text);
        ProfileManager.Instance.SetPlayerFlag((FlagType)_dropdownOptionFlag.value);
        ProfileManager.Instance.SetBotProfile();
    }

    private void Start()
    {
        _btnPlay.onClick.AddListener(() => this.OnPlayButtonClicked());
    }
}
