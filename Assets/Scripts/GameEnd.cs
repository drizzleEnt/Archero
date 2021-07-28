using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    [SerializeField] private  GameObject _resultScreen;
    [SerializeField] private  TMP_Text _resultText;
    [SerializeField] private  TMP_Text _resultButtonText;

    public static GameEnd Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            Player.IsVictory = true;
            EndGame();
        }

    }

    public  void EndGame()
    {
        _resultScreen.SetActive(true);
        _resultText.text = Player.IsVictory ? "Level complete" : "Failed";
        _resultButtonText.text = Player.IsVictory ? "Next level" : "Try again";
    }
}
