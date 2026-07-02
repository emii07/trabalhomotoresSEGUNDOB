using System;

public static class PlayerObserverManager
{
  
    public static event Action<int> OnCoinCollected;

    
    public static void SendCoinCollected(int currentCoins)
    {
        
        OnCoinCollected?.Invoke(currentCoins);
    }
}