using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public float fullHealth;
//	public restartGame theGameManager;

	float currentHealth;

    


    //HUD references
    public Image healthSlider;
/*	public Image damageIndicator;
	public Text rubyCount;
	public CanvasGroup endGameCanvas;
	public Text EndGameText;

	Color flashColour = new Color (255f, 255f, 255f, 0.5f);
	float indicatorSpeed = 5f;
*/
	//Player death
	playerControllerScript controlMovement;
	bool isDead;
	bool damaged;
	//public GameObject playerDeathFX;

    public GameObject startPos;

	//ruby collection
	int collectedRubies = 0;



    public int limbCount;
    public Text limbText;
    public Text win;




    // Use this for initialization
    void Start () {
		currentHealth = fullHealth;


        
        //healthSlider.fillAmount = 0f;
        controlMovement = GetComponent<playerControllerScript> ();
        limbCount = 0;
        //playerAS = GetComponent<AudioSource> ();
        //rubyCount.text = collectedRubies.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        limbText.text = "x " + limbCount + " /10";

        //are we damaged?
        /*		if (damaged) {
                    damageIndicator.color = flashColour;
                } else {
                    damageIndicator.color = Color.Lerp(damageIndicator.color, Color.clear, indicatorSpeed*Time.deltaTime);
                }
                damaged = false;


        */
        if (limbCount > 9)
        {
            //EndGameText.text = "You Win!";
            //	GetComponent<playerControllerScript>().toggleCanMoveFalse();
            win.text = "You Win!";
            //winGame();
        }

    }
    public void addDamage(float damage){
		if (damage <= 0)
			return;
		currentHealth -= damage;
        healthSlider.fillAmount = 1 - currentHealth/fullHealth;
        //playerAS.clip = playerDamaged;
        //playerAS.PlayOneShot (playerDamaged);

        print("Current health" + currentHealth);
		damaged = true;
		if (currentHealth <= 0)
			makeDead ();
        
	}

	public void addHealth(float health){
		currentHealth += health;
		if (currentHealth > fullHealth)
			currentHealth = fullHealth;
//		healthSlider.fillAmount = 1 - currentHealth/fullHealth;
	}

	public void makeDead(){
		//kill the player - death particles - destroy character - sound
		isDead = true;
//		Instantiate (playerDeathFX, transform.position, transform.rotation);
	//	damageIndicator.color = flashColour;
		//EndGameText.text = "You Died!";
		winGame();
        //Destroy (gameObject);
        transform.position = startPos.transform.position;
        currentHealth = fullHealth;
        SceneManager.LoadScene("Mystery");
        //limbCount = 0;
    }

	public void addRuby(){
		collectedRubies +=1;
        print("Collected notes" + collectedRubies);
//		rubyCount.text = collectedRubies.ToString();
		if(collectedRubies>2){
			//EndGameText.text = "You Win!";
		//	GetComponent<playerControllerScript>().toggleCanMoveFalse();
			winGame();
		}
	}

    public void addLimb()
    {
        limbCount += 1;
        
    }

    public void winGame(){
	//	endGameCanvas.alpha = 1f;
		//endGameCanvas.interactable = true;
	}
}

