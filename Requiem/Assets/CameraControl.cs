using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

    GameObject Player;
    GameObject mainCamera;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    // Update is called once per frame
    void Update()
    {

        mainCamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 10);

    }
}