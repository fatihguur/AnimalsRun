using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugManager : MonoBehaviour
{
    
    public float coin = 0;

    public TextMeshProUGUI textCoins;

    
    public GameObject player;
    public GameObject uiPanel,startPanel,ingamePanel,gameOverPanel,winPanel;
    public MovementArray moveArray;
    public ObstacleArray obstacleArray;
    private Vector3 followOffset;
    public CinemachineVirtualCamera cam;
    private CinemachineTransposer transposer;
    public TextMeshProUGUI playerMoveSpeed, playerSidewaySpeed, obstacleMoveSpeed, obstacleRotateSpeed,cameraXoffset,cameraYoffset,cameraZoffset;
    // Start is called before the first frame update
    void Start()
    {
        transposer = cam.GetCinemachineComponent<CinemachineTransposer>();
        followOffset = transposer.m_FollowOffset;

    }

    // Update is called once per frame
    void Update()
    {
        
        playerMoveSpeed.text = player.GetComponent<Movement>().playerRunSpeed.ToString();
        playerSidewaySpeed.text = player.GetComponent<Movement>().playerSidewaySpeed.ToString();
        obstacleMoveSpeed.text = obstacleArray.obstacleMov[0].speed.ToString();
        obstacleRotateSpeed.text = obstacleArray.obstacleMov[0].rotateSpeed.ToString();
        cameraXoffset.text = followOffset.x.ToString();
        cameraYoffset.text = followOffset.y.ToString();
        cameraZoffset.text = followOffset.z.ToString();

    }

     // public void CameraFovIncrease()
     // {
     //   cam.m_Lens.FieldOfView += 2.5f;
     // }
    //
    // public void CameraFovDecrease()
    // {
    //     cam.m_Lens.FieldOfView -= 2.5f;
    // }
    
    public void CameraFollowOffsetUpdate()
    {
        transposer.m_FollowOffset = followOffset;
    }

    public void CameraXOffsetIncrease()
    {
        followOffset.x += 0.5f;
        CameraFollowOffsetUpdate();
    }
    
    public void CameraXOffsetDecrease()
    {
        followOffset.x -= 0.5f;
        CameraFollowOffsetUpdate();

    }

    public void CameraYOffsetIncrease()
    {
        followOffset.y += 0.5f;
        CameraFollowOffsetUpdate();

    }
    
    public void CameraYOffsetDecrease()
    {
        followOffset.y -= 0.5f;
        CameraFollowOffsetUpdate();

    }
    
    public void CameraZOffsetIncrease()
    {
        followOffset.z += 0.5f;
        CameraFollowOffsetUpdate();

    }
    
    public void CameraZOffsetDecrease()
    {
        followOffset.z -= 0.5f;
        CameraFollowOffsetUpdate();

    }
    
    public void IncreasePlayerSidewaySpeed()
    {
        moveArray.SidewaySpeedIncrease();
    }
    
    public void DecreasePlayerSidewaySpeed()
    {
        moveArray.SidewaySpeedDecrease();
    }

    public void IncreasePlayerRunSpeed()
    {
        moveArray.MovementSpeedIncrease();
    }
    
    public void DecreasePlayerRunSpeed()
    {
        moveArray.MovementSpeedDecrease();
    }

    public void IncreaseObstacleSpeed()
    {
        obstacleArray.IncreaseObstacleSpeed();
    }
    
    public void DecreaseObstacleSpeed()
    {
        obstacleArray.DecreaseObstacleSpeed();
    }

    public void IncreaseObstacleRotateSpeed()
    {
        obstacleArray.IncreaseObstacleRotateSpeed();
    }
    
    public void DecreaseObstacleRotateSpeed()
    {
        obstacleArray.DecreaseObstacleRotateSpeed();
    }
    
    public void OpenDebugSettings()
    {

        uiPanel.SetActive(true);
        startPanel.SetActive(false);
    }

    public void CloseDebugSettings()
    {
        uiPanel.SetActive(false);
        startPanel.SetActive(true);

    }

    public void GameOver()
    {
        ingamePanel.SetActive(false);
        gameOverPanel.SetActive(true);
        moveArray.isPlaying();
        Time.timeScale = 0f;
    }

    public void FinishPassed()
    {
        ingamePanel.SetActive(false);
        winPanel.SetActive(true);
    }

    public void StartUI()
    {
        startPanel.SetActive(false);
        ingamePanel.SetActive(true);
    }
    
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single) ;        
    }
}
