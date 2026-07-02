using UnityEngine;
using TMPro; 

public class UIManager : MonoBehaviour
{
  
    [SerializeField] private TextMeshProUGUI coinText;

    private void OnEnable()
    {
        
        PlayerObserverManager.OnCoinCollected += UpdateCoinDisplay;
    }

    private void OnDisable()
    {
       
        PlayerObserverManager.OnCoinCollected -= UpdateCoinDisplay;
    }

    
    private void UpdateCoinDisplay(int currentCoins)
    {
        coinText.text = $"Moedas: {currentCoins}";
    }
}