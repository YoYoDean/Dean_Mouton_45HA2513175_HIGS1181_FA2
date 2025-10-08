using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class GridManager : MonoBehaviour

{
    //Declaring variables
    public GameObject Collectible;
    public GameObject Obsticle;
    public int gridSize = 12;
    public static int totalCollectibles = 10;
    public int totalObsticles = 12;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spwan(); //Calling spawn method to spawn obsticles and collectibles
    }

    // Update is called once per frame
    public void Spwan()
    {
        bool[,] spaceTaken = new bool[gridSize, gridSize];//creating a boolean array to check if space is taken


        int iterate = 0;
        //Collectible spawner
        while (iterate < totalCollectibles)
        {

            int posX = Random.Range(0, gridSize);
            int posY = Random.Range(0, gridSize);


            if (spaceTaken[posX, posY])
            {
                continue; //if space taken skip this iteration
            }
            else
            {
                spaceTaken[posX, posY] = true;//when space gets filled

                Vector3 spawnPosCollectible = new(posX, posY, 0);//position of spawn

                Instantiate(Collectible, spawnPosCollectible, quaternion.identity);//acctual spawn
            }

            iterate++; //counter to keep track of how many times loop must run

        }


        int iterateob = 0;
        //Obsticles spawn
        while (iterateob < totalObsticles)
        {

            int obPosX = Random.Range(0, gridSize);
            int obPosY = Random.Range(0, gridSize);//get random posiotions 

            if (!spaceTaken[obPosX, obPosY])
            {
                iterateob++;
                
                spaceTaken[obPosX, obPosY] = true;//taken space

                Vector3 spawnPosObsticle = new(obPosX, obPosY, 0);//setting position

                Instantiate(Obsticle, spawnPosObsticle, quaternion.identity);//spawner acctual
            }
            
        }
    }
    
}
