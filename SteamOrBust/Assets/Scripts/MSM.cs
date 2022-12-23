using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSM : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject playerPrefab;
    public GameObject portalPrefab;

    public GameObject currentPlayer;
    public GameObject currentPortal;
    public GameObject currentWall;
    // Start is called before the first frame update
    void Start()
    {
       currentPlayer= Instantiate(playerPrefab, new Vector2(1, 1), Quaternion.identity);
      currentWall=  Instantiate(wallPrefab, new Vector2(3, 3), Quaternion.identity);
       currentPortal= Instantiate(portalPrefab, new Vector2(5, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shuffle()
    {
        Destroy(currentWall.gameObject);
        Destroy(currentPortal.gameObject);
        Destroy(currentPlayer.gameObject);

        float playerX = Random.Range(0f, 10f);
        float playerY = Random.Range(0f, 10f);

         currentPlayer=Instantiate(playerPrefab, new Vector2(playerX, playerY), Quaternion.identity);
        Random.InitState((int)Time.time);

        float portalX = Random.Range(0f, 10f);
        float portalY = Random.Range(0f, 10f);
        currentPortal=Instantiate(portalPrefab, new Vector2(playerX, playerY), Quaternion.identity);
        Random.InitState((int)Time.time);

        float wallX = Random.Range(0f, 10f);
        float wallY = Random.Range(0f, 10f);
       currentWall= Instantiate(wallPrefab, new Vector2(playerX, playerY), Quaternion.identity);

    }
}
