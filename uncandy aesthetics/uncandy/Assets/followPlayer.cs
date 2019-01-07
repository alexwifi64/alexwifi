using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script perque la camera segueixi al cub tronja player

public class followPlayer : MonoBehaviour
{
    //aqui cridem la variable transform per obtenir la posicio del cub player, a unity la linkem amb player perque pilli especificament
    //les dades de player
    public Transform player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //igualem la posició de la camara (transform.position) amb la posició del cub player
        transform.position = player.position;
    }
}
