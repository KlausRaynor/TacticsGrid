using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject _selectedHeroObject, _tileObject, _tileUnitObject;
    public static MenuManager Instance;

    public void ShowTileInfo(Tile tile)
    {
        if (tile == null)
        {
            _tileObject.SetActive(false);
            _tileUnitObject.SetActive(false);
            return;
        }
        _tileObject.GetComponentInChildren<TMP_Text>().text = tile.TileName;
        _tileObject.SetActive(true);

        if (tile.OccupiedUnit)
        {
            _tileUnitObject.GetComponentInChildren<TMP_Text>().text = tile.OccupiedUnit.UnitName;
            _tileUnitObject.SetActive(true);
        }
    }
    void Awake()
    {
        Instance = this;
    }

    public void ShowSelectedHero(BaseHero hero)
    {
        if (hero == null)
        {
            _selectedHeroObject.SetActive(false);
            return;
        }
        _selectedHeroObject.GetComponentInChildren<TMP_Text>().text = hero.UnitName;
        _selectedHeroObject.SetActive(true);
    }
}
