using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int SceneIndex;
    public int count;
    
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if(count == 4){
            SceneManager.LoadScene(SceneIndex);

        }


    }
}
