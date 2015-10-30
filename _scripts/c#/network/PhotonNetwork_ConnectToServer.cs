using UnityEngine;
using System.Collections;

public class PhotonNetwork_ConnectToServer : Photon.MonoBehaviour {

    // Use this for initialization
    void Start() {

        PhotonNetwork.ConnectUsingSettings("0.1a");
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("StandartLobby", new RoomOptions(), TypedLobby.Default);
    }

}
