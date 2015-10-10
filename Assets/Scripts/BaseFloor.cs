using UnityEngine;
using System.Collections;

public class BaseFloor : MonoBehaviour
{
    private const string k_BlockTag = "Block";
    private const string k_GameOverScene = "GameOver";

    private int m_BlocksTouchingTheFloor = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D i_Collision)
    {
        if (i_Collision.collider.CompareTag(k_BlockTag))
        {
            ++m_BlocksTouchingTheFloor;

            if (m_BlocksTouchingTheFloor > 1)
            {
                Application.LoadLevel(k_GameOverScene);
            }
        }
    }
    
    void OnCollisionExit2D(Collision2D i_Collision)
    {
        if (i_Collision.collider.CompareTag(k_BlockTag))
        {
            --m_BlocksTouchingTheFloor;
        }
    }
}
