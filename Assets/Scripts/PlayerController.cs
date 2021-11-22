using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float mouseXAxis;
    [SerializeField] float speedWalking = 4f;
    private GameObject enemy1;
    private GameObject enemy2;
    private GameObject enemy3;
    List<GameObject> list = new List<GameObject>();
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        enemy1 = GameObject.FindWithTag("Enemy 1");
        enemy2 = GameObject.FindWithTag("Enemy 2");
        enemy3 = GameObject.FindWithTag("Enemy 3");
        List();
        Dictionary();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speedWalking);
        RotatePlayer();
    }
    private void Dictionary()
    {
        dictionary.Add("en marcha", "El juego esta en marcha");
        dictionary.Add("finalizado", "Ganaste el juego");
    }

    private void List()
    {
        list.Add(enemy1);
        list.Add(enemy2);
        list.Add(enemy3);
    }
    private void Move(float speed)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }

    private void RotatePlayer()
    {
        mouseXAxis += Input.GetAxis("Mouse X");
        Quaternion newrotation = Quaternion.Euler(0, mouseXAxis, 0);
        transform.rotation = newrotation;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy 1") || collision.gameObject.CompareTag("Enemy 2") || collision.gameObject.CompareTag("Enemy 3"))
        {
            foreach (GameObject gObject in list)
            {
                Destroy(gObject);
                Debug.Log("Los enemigos se han destruido");
                Debug.Log(dictionary["finalizado"]);
            }
        }

    }
}
