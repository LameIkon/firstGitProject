using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    // variable = type name
    public bool hasPressedSpace;
    public int score = 0;
    public float decimalNumber = 2.5f;
    public string myText = "Hello World";
    public GameObject worker;
    public float speed = 1;
    public float[] speedArray = new float[3];
    // speedArray[0] = speedArray[0] * speed;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("this happens only once at the start");
        print(MultiplyByTwo((int)decimalNumber));
        print(SqureNumber(decimalNumber));

    }


    bool n = true;
    bool m = true;
    // Update is called once per frame
    void Update()
    {

        int firstScoreLimit = 10;
        // Debug.Log("This happens every frame");
        hasPressedSpace = Input.GetKeyDown(KeyCode.Space);

        if (hasPressedSpace)
        {
            score += 1;
            PrintScore();
        }
        

        if (score > firstScoreLimit)
        {
            if (n)
            {
                n = false;
                print("Congratulations you have more than " + firstScoreLimit + " Cookies");
                print("You have unlocked a Worker!");
                worker.SetActive(true);
            }
        }

        if (score > firstScoreLimit * 10 && m == true)
        {
            worker.SetActive(false);
            m = false;
            print("No more worker for you!");
        }

        // score--;
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(speedArray[0], speedArray[1], speedArray[2]));
    }

    public void PrintScore()
    {
        print(score);
    }

    int MultiplyByTwo(int inputNumber)
    {
        int result = inputNumber * 2;
        return result;
    }

    float SqureNumber(float inputNumber)
    {
        float result = inputNumber * inputNumber;
        return result;
    }


   
}
