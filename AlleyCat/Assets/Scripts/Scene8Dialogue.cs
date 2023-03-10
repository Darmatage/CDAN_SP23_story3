 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene8Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		 public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
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
		public GameObject ArtChar3a;
		public GameObject ArtChar3b;
		public GameObject ArtChar4a;
		public GameObject ArtChar4b;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
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
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar4a.SetActive(false);
		ArtChar4b.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
               ArtChar1d.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Whatever happens, at least the view is nice...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
		   ArtChar1d.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
             
        }
       else if (primeInt == 4){
		   ArtChar1d.SetActive(false);
		   ArtChar1a.SetActive(true);
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(false);
		   ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Grunt 2";
                Char4speech.text = "Heyyy kitty cat.";
        }
       else if (primeInt == 5){
		   ArtChar1a.SetActive(false);
		   ArtChar1e.SetActive(true);
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "AH!! You guys...!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
              
        }
       else if (primeInt == 6){
		   
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(false);
		   ArtChar3b.SetActive(true);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Grunt 1";
                Char3speech.text = "Got the money or what, jackass?";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
		   ArtChar1e.SetActive(false);
		   ArtChar1b.SetActive(true);
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "H-h-here!!! It's all here...! It's all I h-have... Please...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 8){
		    ArtChar1e.SetActive(false);
		   ArtChar1b.SetActive(true);
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "...";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				//if you have more choices later on, label them, like if its the 2nd choice= Choice2a and Choice2b
		       else if (primeInt == 9){
				   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 10){
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Well I'll be... you reached your goal, cat.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 11){
		   ArtChar1c.SetActive(false);
		   ArtChar1e.SetActive(true);
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Huh!?!?!? Really...?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 12){
		   
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(false);
		   ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Grunt 2";
                Char4speech.text = "Damn. I was lookin' forward to tearin' ya limb from limb.\nYou are one luckyyy bastard!";
        }
       else if (primeInt == 13){
		   
		   ArtChar2a.SetActive(true);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(false);
		   ArtChar3b.SetActive(true);
		   ArtChar4a.SetActive(true);
		   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Grunt 1";
                Char3speech.text = "You ever try to rip us off like that again though...";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 14){
		  
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
		   ArtChar3a.SetActive(false);
		   ArtChar3b.SetActive(true);
		   ArtChar4a.SetActive(false);
		   ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Money won't save you next time.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt == 15){
				  ArtChar1e.SetActive(false);
		   ArtChar1a.SetActive(true); 
				   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(false);
		   ArtChar3b.SetActive(false);
		   ArtChar4a.SetActive(false);
		   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt == 16){
				   ArtChar1a.SetActive(false);
		   ArtChar1d.SetActive(true); 
                Char1name.text = "SCRAPPY";
                Char1speech.text = "... hhhah... Oh my god, phew...! I really did it!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt == 17){
				   ArtChar1d.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				       else if (primeInt == 18){
						   ArtChar1e.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I should've asked them for cab fare...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				  nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
		//only the last dialogue
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
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
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("EndWinSurvive");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2");
        }
}