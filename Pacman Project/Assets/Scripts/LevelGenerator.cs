using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject outsideCorner; //1
    public GameObject outsideWall; //2
    public GameObject insideCorner; //3
    public GameObject insideWall; //4
    public GameObject standardPallet; //5
    public GameObject powerPallet; //6
    public GameObject tJunction; //7
    public GameObject levelParent;
    int[,] levelMap =
        {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };
    // Start is called before the first frame update
    void Start()
    {
        DrawMap();

      // remove sample tiles
        gameObject.transform.GetChild(0).gameObject.SetActive(false);

        // Instantiate and rotate
        GameObject.Instantiate(gameObject.transform.GetChild(1), new Vector2(27, 0), Quaternion.Euler(0, 180, 0), gameObject.transform.GetChild(1).parent);
        GameObject.Instantiate(gameObject.transform.GetChild(1), new Vector2(27, -28), Quaternion.Euler(-180, 180, 0), gameObject.transform.GetChild(1).parent);
        GameObject.Instantiate(gameObject.transform.GetChild(1), new Vector2(0, -28), Quaternion.Euler(-180, 0, 0), gameObject.transform.GetChild(1).parent);
    }

  //  Update is called once per frame
    void Update()
    {
        
    }
    void DrawMap()
    {
        for (int row = 0; row < 15; row++)
        {
            for (int col = 0; col < 14; col++)
            {
                int tileNum = levelMap[row, col];
                if (tileNum != 0)
                {
                    GameObject tile = GameObject.FindWithTag(tileNum.ToString());
                    GameObject rotateTile = GameObject.Instantiate(tile, new Vector2(col, -row), Quaternion.identity);

                    rotateTile.transform.parent = levelParent.transform;

                    float rotateAngle = 0;

                    // outside corner "©³"
                    if (tileNum == 1)
                    { //"©»"
                        if (row == 9 && col == 0)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 9 && col == 5)
                        {//¡°©·¡±
                            rotateAngle = -90f;
                        }
                        if (row == 13)
                        {//¡°©¿¡±
                            rotateAngle = 180f;
                        }
                        rotateTile.transform.Rotate(0f, 0f, rotateAngle);
                    }

                    // outside wall
                    if (tileNum == 2)
                    {
                        if (row >= 1 && row <= 8)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row >= 10 && row <= 12)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                    }

                    // inside corner "¨q "
                    if (tileNum == 3)
                    {
                        // inside corners " ¨r"
                        if (row == 2 && col == 5)
                        {
                            rotateAngle = 270f;
                        }
                        if (row == 2 && col == 11)
                        {
                            rotateAngle = 270f;
                        }
                        if (row == 6 && col == 5)
                        {
                            rotateAngle = 270f;
                        }
                        if (row == 6 && col == 8)
                        {
                            rotateAngle = 270f;
                        }
                        if (row == 7 && col == 13)
                        {
                            rotateAngle = 270f;
                        }
                        if (row == 9 && col == 11)
                        {
                            rotateAngle = 270f;
                        }


                        // inside corners  "¨t "
                        if (row == 4 && col == 2)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 4 && col == 7)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 4 && col == 13)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 10 && col == 2)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 10 && col == 7)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 10 && col == 13)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 7 && col == 2)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 7 && col == 7)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 7 && col == 8)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 7 && col == 10)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 9 && col == 2)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 9 && col == 7)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 9 && col == 8)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 9 && col == 10)
                        {
                            rotateAngle = 90f;
                        }
                        if (row == 13 && col == 7)
                        {
                            rotateAngle = 90f;
                        }

                        // inside corners " ¨s"

                        if (row == 13 && col == 8)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 4 && col == 5)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 4 && col == 11)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 7 && col == 5)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 7 && col == 11)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 10 && col == 5)
                        {
                            rotateAngle = 180f;
                        }
                        if (row == 10 && col == 11)
                        {
                            rotateAngle = 180f;
                        }
                        rotateTile.transform.Rotate(0f, 0f, rotateAngle);
                    }

                    // inside walls
                    if (tileNum == 4)
                    {
                        if (row == 2 && col == 13)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 9 && col == 13)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 1 || row == 3 || row == 8 || row == 11 || row == 13 || row == 14)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 7 && col == 7)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 7 && col == 8)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 9 && col == 7)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 9 && col == 8)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 10 && col == 7)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 10 && col == 8)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 12 && col == 7)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }
                        if (row == 12 && col == 8)
                        {
                            rotateTile.transform.Rotate(0f, 0f, 90f);
                        }

                    }
                }
            }
        }
    }
}

