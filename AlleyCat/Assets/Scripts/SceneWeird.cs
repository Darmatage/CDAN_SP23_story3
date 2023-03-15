 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class SceneWeird : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
		//IF YOU HAVE TO ADD A NEW CHARACTER, OR MORE SPRITES FOR ONE CHARACTER MAKE SURE YOU INCLUDE THAT HERE
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
		public GameObject ArtChar1e;
		public GameObject ArtChar2a;
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
		public GameObject ArtChar2d;
		public GameObject ArtChar2e;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
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
	    ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		ArtChar2d.SetActive(false);
		ArtChar2e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
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
               ArtChar2a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "THIS [[lovely, longing]] DEVICE CAN BE YOURS FOR THE LOW LOW PRICE OF ___ AT NO EXTRA CHARGE! ";
        }
       else if (primeInt ==3){
               ArtChar2a.SetActive(false);
               ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "BUY IT NOW! [[You don’t have a choice]]!";
             
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
				//these three lines below only appear at choices
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
				//if you have more choices later on, label them, like if its the 2nd choice= Choice2a and Choice2b
				
//Yes
       else if (primeInt == 100){
               ArtChar2b.SetActive(false);
               ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "ENJOY YOUR [[fancy new carmanunga]]! I’LL JUST TKAE ALL YOUR [[Wacky stacks]]!";
        }
       else if (primeInt == 101){
               ArtChar2c.SetActive(false);
               ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Oh... he took... everything...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 102){
               ArtChar1e.SetActive(false);
               ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well... maybe I can sell this thing for a pretty penny...?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 103){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Let's take a look inside...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 104){
               ArtChar1d.SetActive(false);
               ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 105){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hey! The door's locked! I'm trapped inside!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 106){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "What the hell's going on??";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

//No
       else if (primeInt == 200){
               ArtChar2d.SetActive(false);
               ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "…You made your choice.";
        }
       else if (primeInt == 201){
               ArtChar2e.SetActive(false);
               ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Oof!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 202){
               ArtChar1b.SetActive(false);
               ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hey! Wait! Where are you going?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 203){
               ArtChar1a.SetActive(false);
               ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "PLEASE! LET ME OUT!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		//only the last dialogue
       else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }
// THERE SHOULD ALWAYS BE TWO BRACKETS ABOVE, ONE TO CLOSE THE LAST DIALOGUE LINE AND ONE TO CLOSE THE ENTIRE STORY UNIT SECTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)

//so for these, this is the single line your character says after picking a choice and the number (ending in 99) reroutes the dialogue to the correct route,
//which will be the first number that comes after the one ending in 99 here
//the first choice says 99, it will reroute you to the dialogue that starts at primeInt=100 bc 100 comes after 99
//same for the second choice saying 199, it will reroute you to the dialogue that starts at primeInt=200 bc 200 comes after 199
//the numbers will probably get pretty big depending on how many choices you have so dont stress if they do

        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "A DEALS A DEAL!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
               ArtChar2b.SetActive(false);
               ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "...";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("EndWeird");
        }
}