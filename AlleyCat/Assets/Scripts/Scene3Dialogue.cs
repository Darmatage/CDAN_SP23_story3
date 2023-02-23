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
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
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
                Char1speech.text = "Ahhhh my clock is tickin’... I gotta hurry up!";
        }
       else if (primeInt ==3){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Let’s see… I couuuld go to the pub… might be a lotta folks ‘round there…";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "ORRR maybe Main Street? Might be bustling with life… and suckers…";
        }
       else if (primeInt == 5){
		   ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Then again… maybe I can find me a rat that can actually pay me if I hang around the dumpsters… might find more, ahem, goods. Over there.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
		    ArtChar1d.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HMMMMMM I think…";				 
        }
		       else if (primeInt == 7){

				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
				Choice1b.SetActive(true);
				Choice1c.SetActive(true);
		}		
			   }
}
