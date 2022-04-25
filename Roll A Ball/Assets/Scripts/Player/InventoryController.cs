using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [HideInInspector] public int pickUpAmount;

    private void Start()
    {
        AssignVariables();
    }

    public void ItemPickup()
    {
        pickUpAmount++;

        UIManager.Instance.UpdateCount(pickUpAmount);
    }

    private void AssignVariables()
    {
        pickUpAmount = 0;

        UIManager.Instance.UpdateCount(pickUpAmount);
    }
}
