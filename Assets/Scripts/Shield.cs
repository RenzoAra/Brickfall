using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public static GameObject objetoMover;
    public static Transform endPoint;
    public static Transform startPoint;
    public static float velocidad;
    private static Vector3 moverHacia;


    // Start is called before the first frame update
    void Start()
    {
        moverHacia = endPoint.position;
        objetoMover.transform.position = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        objetoMover.transform.position = Vector3.MoveTowards(objetoMover.transform.position, moverHacia, velocidad * Time.deltaTime);
        if(objetoMover.transform.position == endPoint.position){
            moverHacia = startPoint.position;
        }
        if(objetoMover.transform.position == startPoint.position){
            moverHacia = endPoint.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "LimiteInferior")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
}
