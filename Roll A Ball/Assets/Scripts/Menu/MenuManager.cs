using UnityEngine;

public class MenuManager : MonoBehaviour
{
    #region Singleton Init

    public static MenuManager Instance;

	void Awake() => Instance = this;

    #endregion

    [SerializeField] Menu[] menus;

	public void OpenMenu(string menuName)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i].menuName == menuName)
			{
				menus[i].Open();
			}
			else if (menus[i].open)
			{
				CloseMenu(menus[i]);
			}
		}
	}

	public void OpenMenu(Menu menu)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i].open)
			{
				CloseMenu(menus[i]);
			}
		}
		menu.Open();
	}

	public void CloseMenu(Menu menu)
	{
		menu.Close();
	}
}
