using System.Collections;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public CoinsManager CoinsManager;
    public FinalMenu finalmenu;

    public IEnumerator Countdown(int value)
    {
        yield return new WaitForSeconds(value);
    }

}
