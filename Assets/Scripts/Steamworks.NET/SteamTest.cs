using Steamworks;
using UnityEngine;

public class SteamTest : MonoBehaviour
{
    private void Start()
    {
        if (SteamManager.Initialized)
        {
            var personaName = SteamFriends.GetPersonaName();
            Debug.Log(personaName);
        }
    }
}