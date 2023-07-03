using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    [SerializeField]
    public Button _shopAButton, _shopBButton, _itemButton;
    [SerializeField]
    private GameObject _shop, _shopA, _shopB, _item;
    [SerializeField]
    public Button _backButtonA, _backButtonB, _backButtonI;
    // Start is called before the first frame update
    void Start()
    {
        _shopAButton.onClick.AddListener(ShopAOnClick);
        _shopBButton.onClick.AddListener(ShopBOnClick);
        _itemButton.onClick.AddListener(ItemOnClick);
        _backButtonA.onClick.AddListener(BackHome);
        _backButtonB.onClick.AddListener(BackHome);
        _backButtonI.onClick.AddListener(BackHome);
    }

    void ShopAOnClick()
    {
        _shopA.SetActive(true);
        _shop.SetActive(false);
    }

    void ShopBOnClick()
    {
        _shopB.SetActive(true);
        _shop.SetActive(false);
    }

    void ItemOnClick()
    {
        _item.SetActive(true);
        _shop.SetActive(false);
    }

    void BackHome()
    {
        _shopA.SetActive(false);
        _shopB.SetActive(false);
        _item.SetActive(false);
        _shop.SetActive(true);
    }
}
