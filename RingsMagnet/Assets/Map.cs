using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsCoordinates
{
   public float x;
    public float y;
    public float z;
}

public class Map : MonoBehaviour {

    public Transform hexa;

    private int[,,] myArray = new int[,,] { };

    List<PositionsCoordinates> Coordinates = new List<PositionsCoordinates>();
    // Use this for initialization
    void Start()
    {
        float altitude = 1.73205080757F;
        Coordinates.Add(new PositionsCoordinates() { x = altitude, y = 0, z = 3F });

        Coordinates.Add(new PositionsCoordinates() { x = -altitude, y = 0, z = 3F });
        Coordinates.Add(new PositionsCoordinates() { x = -2*altitude, y = 0, z = 0 });
        Coordinates.Add(new PositionsCoordinates() { x = -altitude, y = 0, z = -3F });
        Coordinates.Add(new PositionsCoordinates() { x = altitude, y = 0, z = -3F });
        Coordinates.Add(new PositionsCoordinates() { x = 2*altitude, y = 0, z = 0 });


        //1->  altitude,0, 3F
        //2-> - altitude,0 3f




        foreach (PositionsCoordinates value in Coordinates)
            {
                //if(hexa != null)

                Instantiate(hexa, new Vector3(hexa.transform.localPosition.x + value.x, hexa.transform.localPosition.y + value.y, hexa.transform.localPosition.z + value.z), Quaternion.identity);
            }

        //var clone  = Instantiate (player, player.transform);


        //.< Renderer > ().bounds.size
        // player.transform.RotateAround(player1.transform.position, Vector3.zero, 50);

    }
}
