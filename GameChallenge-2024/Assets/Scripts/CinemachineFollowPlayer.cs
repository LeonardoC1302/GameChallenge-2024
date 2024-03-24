using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineFollowPlayer : MonoBehaviour
{
    private GameObject player;
    private CinemachineVirtualCamera virtualCamera;
    // Start is called before the first frame update
    void Start()
    {
        // The cinemachine camera is the one with the script, so we can get the virtual camera component
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null){
            player = GameObject.FindGameObjectWithTag("Player");
        } else{
            virtualCamera.Follow = player.transform;
        }

        
    }
}
