using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public int difficulty;
    [SerializeField] float difficultyMultiplyer = 0.01f;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale += Time.deltaTime * difficulty * difficultyMultiplyer;
        transform.Translate(Vector2.left * Time.deltaTime * speed);
       
    }
}
