using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class MatchMakingManager : NetworkManager
{

    private NetworkMatch networkMatch;

    // Update is called once per frame
    void Update()
    {
        if (networkMatch == null)
        {
            var nm = GetComponent<NetworkMatch>();
            if (nm != null)
            {
                networkMatch = nm as NetworkMatch;
                UnityEngine.Networking.Types.AppID appid = (UnityEngine.Networking.Types.AppID)94451;
                nm.SetProgramAppID(appid);
            }
        }
    }
}