using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class GridManager : MonoBehaviour

{
    
    public GameObject Collectible;
    public GameObject Obsticle;
    public int gridSize = 12;
    public static int totalCollectibles = 5;
    public int totalObsticles = 3;

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spwan();
    }

    // Update is called once per frame
    public void Spwan()
    {
        bool[,] spaceTaken = new bool[gridSize, gridSize];


        int iterate = 0;
        //Collectible spawn
        while (iterate < totalCollectibles)
        {

            int posX = Random.Range(0, gridSize);
            int posY = Random.Range(0, gridSize);


            if (spaceTaken[posX, posY])
            {
                continue;
            }
            else
            {
                spaceTaken[posX, posY] = true;

                Vector3 spawnPosCollectible = new(posX, posY, 0);

                Instantiate(Collectible, spawnPosCollectible, quaternion.identity);
            }

            iterate++;

        }


        int iterateob = 0;
        //Obsticles spawn
        while (iterateob < totalObsticles)
        {

            int obPosX = Random.Range(0, gridSize);
            int obPosY = Random.Range(0, gridSize);

            if (!spaceTaken[obPosX, obPosY])
            {
                iterateob++;
                
                spaceTaken[obPosX, obPosY] = true;

                Vector3 spawnPosObsticle = new(obPosX, obPosY, 0);

                Instantiate(Obsticle, spawnPosObsticle, quaternion.identity);
            }
            
        }
    }
    
}
