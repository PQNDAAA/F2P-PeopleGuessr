using System.Collections;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public GameManager gameManager;
    public FinalMenu finalmenu;

    public IEnumerator CountdownPopupCoins (int value)
    {
        yield return new WaitForSeconds(value);

        finalmenu.popupCoinsState = false;
    }

}
