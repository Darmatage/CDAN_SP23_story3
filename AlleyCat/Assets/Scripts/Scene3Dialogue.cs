 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       public GameHandler gameHandler;
       //public AudioSource audioSource;
 	   public AudioSource town_theme;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
		town_theme.Play();
	   DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		 ArtChar1b.SetActive(false);
	  ArtChar1c.SetActive(false);
	   ArtChar1d.SetActive(false);
	    ArtChar1e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
       Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ahhhh my clock is tickin’. I gotta hurry up!";
        }
       else if (primeInt ==3){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Let’s see... I could go to the pub. Might be lotsa folks ‘round there...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "ORRR maybe Main Street? Might be bustling with life... and rich suckers...";
        }
       else if (primeInt == 5){
		   ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Then again... maybe I can find a rat that can actually pay me by the dumpsters. Might find more, ahem, goods.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
		    ArtChar1d.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HMMMMMM. Just gotta pick a place I guess.";				 
				nextButton.SetActive(false);
                allowSpace = false;
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				 NextScene2Button.SetActive(true);
				  NextScene3Button.SetActive(true);
        
		}		

}

//Button Functions
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene4c");
        }
}