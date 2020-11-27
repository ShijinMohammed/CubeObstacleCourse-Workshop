using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed;
    public GameObject GameOverPanel;
    public GameObject WinPanel;
    private Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        
        Vector3 translatedInput = new Vector3(input.x,0,input.y);
        myRigid.AddForce(translatedInput*moveSpeed*Time.deltaTime*10);
        if(Input.GetKeyDown(KeyCode.Space))
            myRigid.AddForce(translatedInput*10,ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.transform.tag == "Obstacle")
        {
            GameOver();
        }
        else if(other.transform.tag == "Wingate")
        {
            Win();
        }
    }

    void GameOver()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
    void Win()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
