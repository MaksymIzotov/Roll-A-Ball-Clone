using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    #region Singleton Init

    public static UIManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    #endregion

    [SerializeField] private TMP_Text countText;

    public void UpdateCount(int amount)
    {
        countText.text = "Count: " + amount;
    }
}
