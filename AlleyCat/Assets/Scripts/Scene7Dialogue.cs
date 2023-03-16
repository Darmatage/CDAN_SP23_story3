 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene7Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		 public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
       public Text Char5name;
       public Text Char5speech;
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
		public GameObject ArtChar3a;
		public GameObject ArtChar3b;
		public GameObject ArtChar3c;
		public GameObject ArtChar4a;
		public GameObject ArtChar4b;
		public GameObject ArtChar4c;
		 public GameObject ArtChar5a;
		public GameObject ArtChar5b;
		public GameObject ArtChar5c;
		public GameObject ArtChar5d;
		public GameObject ArtChar5e;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		 public GameObject ArtBG2;
		  public GameObject ArtBG3;
        public GameObject Choice1a;
       // public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
	   public AudioSource mafia_theme;
       public AudioSource rat_theme;
       
	   public AudioSource footsteps;
	   public AudioSource beach_theme;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        beach_theme.Play();
		DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar1e.SetActive(false);
	    ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
		ArtChar4a.SetActive(false);
		ArtChar4b.SetActive(false);
		ArtChar4c.SetActive(false);
		ArtChar5a.SetActive(false);
		ArtChar5b.SetActive(false);
		ArtChar5c.SetActive(false);
		ArtChar5d.SetActive(false);
		ArtChar5e.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
        Choice1a.SetActive(false);
      //  Choice1b.SetActive(false);
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
               ArtChar1a.SetActive(true);
			   ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah. I sure hope that's enough... *sigh*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt ==3){
		   
		   ArtChar1a.SetActive(false);
		   ArtChar1e.SetActive(true);
			   ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			   ArtChar4a.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Whatever happens, at least the view is nice.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
             Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 4){
		  beach_theme.Stop();
		   footsteps.Play();
		   ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			   ArtChar4a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 5){
		   footsteps.Stop();
			mafia_theme.Play();
		   ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(true);
			   ArtChar4a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Time's up bub.";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
              
        }
       else if (primeInt == 6){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(true);
			   ArtChar4a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "H-Huh!?! Y-You...! Why are you here, I thought-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt ==7){
		   ArtChar1b.SetActive(false);
		   ArtChar1d.SetActive(true);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(false);
			    ArtChar3b.SetActive(true);
			   ArtChar4a.SetActive(true);
                Char1name.text = "";
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Grunt 1";
                Char3speech.text = "You thought wrong, Scraps. We've been so patient with you-and ya still couldn't get the job done, eh?";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt ==8){
			ArtChar1d.SetActive(false);
		   ArtChar1c.SetActive(true);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(true);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "NO-! Please pleaseplease PLEASE don't hurt me!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		       else if (primeInt ==9){
				   ArtChar1c.SetActive(false);
		   ArtChar1b.SetActive(true);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(true);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I-I've worked so hard!!! If you could just give me a little more time I could-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		       else if (primeInt ==10){
				    ArtChar1c.SetActive(false);
		   ArtChar1b.SetActive(true);
			   ArtChar2a.SetActive(true);
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
                Char4speech.text = "Cut the shit. We're done waiting. Please don't squirm while we finish ya off,\nKeep SOME dignity intact.";
       Char5name.text = "";
                Char5speech.text = "";
	   }
		       else if (primeInt ==11){
				   ArtChar1b.SetActive(false);
		   ArtChar1d.SetActive(true);
			   ArtChar2a.SetActive(true);
			   ArtChar3a.SetActive(true);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(true);
			   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*knuckle crack*";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
       else if (primeInt == 12){
		   ArtChar1b.SetActive(false);
		   ArtChar1d.SetActive(true);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
			   ArtChar3a.SetActive(true);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(true);
			   ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "End of the line, kitty cat.";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				
                // Turn off "Next" button, turn on "Choice" buttons
				//these three lines below only appear at choices
             //   nextButton.SetActive(false);
              //  allowSpace = false;
                 // function Choice1aFunct()
             //   Choice1b.SetActive(true); // function Choice1bFunct()
        }
				else if (primeInt == 13){
					 ArtChar1c.SetActive(true);
		   ArtChar1d.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
			   ArtChar3a.SetActive(false);
			    ArtChar3b.SetActive(true);
			   ArtChar4a.SetActive(false);
			   ArtChar4b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "N-NOOOOOOOOOOOOO!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				
				if (GameHandler.ratAlly == false){
					NextScene1Button.SetActive(true);
				} else {
					Choice1a.SetActive(true);
				}
			
			
			Debug.Log("is the rat on your side? " + GameHandler.ratAlly);
        }				
	
				
			//if you have more choices later on, label them, like if its the 2nd choice= Choice2a and Choice2b
				
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
		   ArtChar1b.SetActive(true);
		   ArtChar1d.SetActive(false);
			  ArtChar2a.SetActive(false);
			  ArtChar2c.SetActive(false);
			    ArtChar2b.SetActive(true);
				 ArtChar3a.SetActive(false);
			   ArtChar3c.SetActive(false);
			    ArtChar3b.SetActive(true);
			   ArtChar4a.SetActive(false);
			  ArtChar4c.SetActive(false);
			   ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Huh? You tryna act tough now, cat?";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 101){
		    ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
		   ArtChar2a.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "Down here dumbass.";
        }
		else if (primeInt == 102){
		  ArtChar1e.SetActive(true);
		   ArtChar1a.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Y-you!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 103){
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(false);
			   ArtChar5b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "Now. What're you mangy mutts doin' to my pal here?\nI suggest you back off.";
        }
		else if (primeInt == 104){
		   ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2b.SetActive(false);
			    ArtChar2a.SetActive(true);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(true);
			   ArtChar4a.SetActive(false);
			   ArtChar4b.SetActive(true);
			   ArtChar5b.SetActive(false);
			   ArtChar5a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Grunt 2";
                Char4speech.text = "gYAHAHAHA!!! The hell is this?!?!";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 105){
		  ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
			   ArtChar3a.SetActive(false);
			    ArtChar3b.SetActive(true);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(true);
			   ArtChar5b.SetActive(false);
			   ArtChar5a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "GRUNT 1";
                Char3speech.text = "HAHAHAAA! WOW. This supposed to be yer backup Scraps?";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 106){
		  ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2b.SetActive(false);
			    ArtChar2a.SetActive(true);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(true);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(true);
			   ArtChar5a.SetActive(false);
			   ArtChar5b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "A bite sized piece a' trash has somethin' to say to ME?\nWhat the hell do you care for, rat?";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 107){
		  ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
			   ArtChar3a.SetActive(false);
			    ArtChar3b.SetActive(true);
			   ArtChar4a.SetActive(false);
			   ArtChar4b.SetActive(true);
			   ArtChar5a.SetActive(false);
			   ArtChar5b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Thought cats and rats were natural enemies, little guy. Hahaha.";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 108){
		  ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2b.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar5a.SetActive(false);
			   ArtChar5c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "Now my pal here may not be very bright. He's a moron, actually.";
        }
		else if (primeInt == 109){
		  ArtChar1d.SetActive(true);
		   ArtChar1a.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5c.SetActive(false);
			   ArtChar5a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HEY!!!! Rude.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 110){
		   ArtChar1a.SetActive(true);
		   ArtChar1d.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(false);
			   ArtChar5d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "But he ain't stupid enough to call me little guy.";
        }
		else if (primeInt == 111){
			ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5a.SetActive(false);
			   ArtChar5d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "*siiiiiip*";
        }
		else if (primeInt == 112){
			mafia_theme.Stop();
			ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2a.SetActive(true);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(true);
			   ArtChar4a.SetActive(false);
			   ArtChar4b.SetActive(true);
			   ArtChar5a.SetActive(false);
			   ArtChar5d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "GRUNT 2";
                Char4speech.text = "Whatcha drinkin', gonna have a growth spurt? HA!";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 113){
			rat_theme.Play();
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(false);
			   ArtChar3b.SetActive(false);
			    ArtChar3a.SetActive(false);
			   ArtChar4b.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar5d.SetActive(false);
			   ArtChar5e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "Yes.";
        }
		else if (primeInt == 114){
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2c.SetActive(true);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(true);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(true);
			   ArtChar5a.SetActive(false);
			   ArtChar5e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "WHAT THE FU-";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 115){
		   ArtChar1a.SetActive(false);
		   ArtChar1e.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5d.SetActive(false);
			   ArtChar5e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "*PUNCHPUNCHPUNCHPUNCHPUNCHPUNCHPUNCHPUNCHPUNCHPUNCH*";
        }
		else if (primeInt == 116){
			rat_theme.Stop();
		  ArtChar1a.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5c.SetActive(true);
			   ArtChar5e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "Well. That takes care of that.";
        }
		else if (primeInt == 117){
			beach_theme.Play();
		  ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5a.SetActive(true);
			   ArtChar5c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Haha. Yeah. You really saved my bacon, bub. Thanks.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 118){
			
		  ArtChar1e.SetActive(true);
		   ArtChar1b.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5a.SetActive(true);
			   ArtChar5c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Was the cheese that good?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
        }
		else if (primeInt == 119){
		  ArtChar1d.SetActive(true);
		   ArtChar1e.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5b.SetActive(true);
			   ArtChar5a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "No. That was a moldy sponge you sold me.";
        }
		else if (primeInt == 120){
		  ArtChar1a.SetActive(true);
		   ArtChar1d.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5c.SetActive(true);
			   ArtChar5b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "RAT";
                Char5speech.text = "But it poisoned the the guy sleepin' with my girl. So I owed ya one.\nThanks.";
        }
		 
       else if (primeInt == 121){
		   ArtChar1e.SetActive(true);
		   ArtChar1a.SetActive(false);
			   ArtChar2c.SetActive(false);
			    ArtChar2a.SetActive(false);
			   ArtChar3a.SetActive(false);
			    ArtChar3c.SetActive(false);
			   ArtChar4a.SetActive(false);
			   ArtChar4c.SetActive(false);
			   ArtChar5c.SetActive(true);
			   ArtChar5b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah. Good for you.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "";
                Char5speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
}

  //     else if (primeInt == 200){
   //             Char1name.text = "";
  //              Char1speech.text = "";
  //              Char2name.text = "";
  //              Char2speech.text = "";
  //      }
		//only the last dialogue
  //     else if (primeInt == 201){
  //              Char1name.text = "";
  //              Char1speech.text = "";
  //              Char2name.text = "";
  //              Char2speech.text = "";
   //             nextButton.SetActive(false);
   //             allowSpace = false;
          //      NextScene2Button.SetActive(true);
   //     }
   //  }
// THERE SHOULD ALWAYS BE TWO BRACKETS ABOVE, ONE TO CLOSE THE LAST DIALOGUE LINE AND ONE TO CLOSE THE ENTIRE STORY UNIT SECTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)

//so for these, this is the single line your character says after picking a choice and the number (ending in 99) reroutes the dialogue to the correct route,
//which will be the first number that comes after the one ending in 99 here
//the first choice says 99, it will reroute you to the dialogue that starts at primeInt=100 bc 100 comes after 99
//same for the second choice saying 199, it will reroute you to the dialogue that starts at primeInt=200 bc 200 comes after 199
//the numbers will probably get pretty big depending on how many choices you have so dont stress if they do

        public void Choice1aFunct(){
			 ArtChar1c.SetActive(false);
		   ArtChar1d.SetActive(true);
			   ArtChar2a.SetActive(true);
			    ArtChar2b.SetActive(false);
			   ArtChar3a.SetActive(true);
			    ArtChar3b.SetActive(false);
			   ArtChar4a.SetActive(true);
			   ArtChar4b.SetActive(false);
			 GameHandler.ratAlly = true; 
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
				Char5name.text = "VOICE";
                Char5speech.text = "Not so fast.";
                primeInt = 99;
                Choice1a.SetActive(false);
             //   Choice1b.SetActive(false);
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
             //   Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("EndLoseDock");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("EndWinRat");
        }
}