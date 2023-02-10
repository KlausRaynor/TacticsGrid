// using System;
// using System.Collections;
// using System.Collections.Generic;
// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;
//
// public class MenuManager : MonoBehaviour
// {
//     [SerializeField] private GameObject _colorSelectPanel;
//     [SerializeField] private TextMeshProUGUI _stateText;
//     [SerializeField] private Button _attackButton;
//     void Start()
//     {
//         
//     }
//
//     void Awake()
//     {
//         GameManager.OnGameStateChanged += GameManagerOnOnGameStateChanged;
//     }
//
//     void onDestroy()
//     {
//         GameManager.OnGameStateChanged -= GameManagerOnOnGameStateChanged;
//     }
//
//     private void GameManagerOnOnGameStateChanged(GameState state)
//     {
//         _colorSelectPanel.SetActive(state == GameState.SelectColor);
//
//         _attackButton.interactable = state == GameState.PlayerTurn;
//     }
//
//     public void AttackPressed()
//     { 
//         UnitManager.Instance.Attack(Faction.Player);
//         GameManager.Instance.UpdateGameState(GameState.EnemyTurn);
//     }
// }
