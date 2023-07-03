using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField]
    int _money = 1000;
    [SerializeField]
    public Text _moneyText;
    [SerializeField]
    public Button _yakusouButton, _dokukeshiButton, _seisuiAButton;
    [SerializeField]
    public Button _seisuiBButton, _kenButton, _yoroiButton;
    // Start is called before the first frame update
    void Start()
    {
        _yakusouButton.onClick.AddListener(BuyYakusouOnClick);
        _dokukeshiButton.onClick.AddListener(BuyDokukeshiOnClick);
        _seisuiAButton.onClick.AddListener(BuySeisuiOnClick);
        _seisuiBButton.onClick.AddListener(BuySeisuiOnClick);
        _kenButton.onClick.AddListener(BuyKenOnClick);
        _yoroiButton.onClick.AddListener(BuyYoroiOnClick);
    }

    void BuyYakusouOnClick()
    {
        _money -= 10;
    }

    void BuyDokukeshiOnClick()
    {
        _money -= 15;
    }

    void BuySeisuiOnClick()
    {
        _money -= 20;
    }

    void BuyKenOnClick()
    {
        _money -= 300;
    }

    void BuyYoroiOnClick()
    {
        _money -= 350;
    }
}
