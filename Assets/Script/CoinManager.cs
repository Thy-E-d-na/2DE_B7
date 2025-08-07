using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    int coinbag;
   
    public void AddCoin()
    {
        coinbag++;
        _text.text = "" + coinbag;
    }
}
