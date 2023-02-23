 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene4bDialogue : MonoBehaviour {
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
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
	    public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
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
		ArtChar2c.SetActive(false);
		ArtChar2d.SetActive(false);
		ArtChar2e.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		 Choice2a.SetActive(false);
        Choice2b.SetActive(false);
		        Choice2c.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I'll head down to Main Street! The cat's there gotta be loaded!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Just gotta find one that's gullible too...";
                Char2name.text = "";
                Char2speech.text = "";
             
        }
       else if (primeInt == 4){
		   ArtBG1.SetActive(false);
		ArtBG2.SetActive(true); 
		ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
		     ArtChar2a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "???";
                Char2speech.text = "*sigh*";
              
        }
       else if (primeInt == 6){
		     ArtChar1a.SetActive(true);
                
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Excuse me sir, what's the time?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Ah.. 9:27.";
        }
       else if (primeInt == 8){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Gee thanks mister! Uh...";
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
				
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Ah Old Sport... keep your penny.";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "I've got all the riches in the world... \n But no one to share it with.";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		       else if (primeInt == 102){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(!!!)";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt == 103){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Do tell. Haven't got a missus or colleague, or anything?";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt == 104){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Heavens, no. The woman I love was supposed to show up for a dinner date but...";
        }
				       else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "*sigh*";
        }
		       else if (primeInt == 106){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "... she never showed up.";
        }		
		else if (primeInt == 107){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "That's awful... what time did you tell her to show up?";
                Char2name.text = "";
                Char2speech.text = "";
        }		    
		else if (primeInt == 108){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Oh I didn't tell her to show up.";
        }
       else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "She should know when a man of my status is out on the town.";
        }
				       else if (primeInt == 110){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "And that I wanted to have dinner at this specific restaurant with her, of course.";
        }
				       else if (primeInt == 111){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...Right.";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt == 112){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "And no colleagues either, you said?";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "None of importance, if that's what you mean.";
        }
		       else if (primeInt == 114){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Not to sound a snob but you see...";
        }
				       else if (primeInt == 115){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "I throw these divine ~Summer Parties,~ but never actually invite anyone. \n Cats just show up.";
        }
				       else if (primeInt == 116){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "It's all just for show; all of my money can't buy me a friend.";
        }
				       else if (primeInt == 117){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice1aFunct()
                Choice2b.SetActive(true); // function Choice1bFunct()
				Choice2c.SetActive(true); // function Choice1bFunct()
        }
			  else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Excuse me? I don't have time for such foolish games.";
		}
					  else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "I suggest you clean that gunk out of your ears, Old Sport.";
		}
					  else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Now-leave me to mope by the lighthouse, won't you?";
		}
					  else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
		}
					  else if (primeInt == 204){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well!!! No surpise Main Streets flooding with JERKS!!!";
                Char2name.text = "";
                Char2speech.text = "";
		}

		
		//only the last dialogue
       else if (primeInt == 205){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "This place is too stuffy for me... nobody'll buy my crap anyways.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "W-what...? You'll be my friend?";
		}	
		else if (primeInt == 301){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Yeah, why not-Old Sport!";
                Char2name.text = "";
                Char2speech.text = "";
		}	
		else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Okay well firstly that's my catchpjrase please refrain from saying my catchphrase.";
		}	
		else if (primeInt == 303){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah, uh, o-okay...";
                Char2name.text = "";
                Char2speech.text = "";
		}	
		else if (primeInt == 304){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "And secondly-what a foolish offer, Old Sport.";
		}	
		else if (primeInt == 305){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HUH?!??! I thought you were lonely!!!!";
                Char2name.text = "";
                Char2speech.text = "";
		}	
		else if (primeInt == 306){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Lonely yes. Stupid? No. Why would I befriend a stranger I just told I am the richest cat alive?";
		}	
				else if (primeInt == 307){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Not to mention a stranger who looks worse for wear and is selling literal garbage...";
		}	
		else if (primeInt == 308){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "How dare you try to take advantage of my fragile state! Goodbye, Old Sport.";
		}	
		else if (primeInt == 309){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "C-crap...! I was too obvious with my ulterior motive. Damn.";
                Char2name.text = "";
                Char2speech.text = "";
		}	
					  else if (primeInt == 310){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well!!! No surpise Main Streets flooding with JERKS!!!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		//only the last dialogue
       else if (primeInt == 311){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "This place is too stuffy for me... nobody'll buy my crap anyways.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 400){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Business partner? Old Sport, what did I just tell you?";
		}
		else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "I have all the money in the world. \n What good would investing do for my sad state?";
		}
				else if (primeInt == 402){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well, think about it! Clearly friends and lovers are tricky for you.";
                Char2name.text = "";
                Char2speech.text = "";
		}
				else if (primeInt == 403){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Try a relationship with somebody who'll listen to you, and can make money WITH you!";
                Char2name.text = "";
                Char2speech.text = "";
		}
				else if (primeInt == 404){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Hmmm... it's certainly a foreign concept to me. I've never made a deep connection with a...";
		}
						else if (primeInt == 405){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "... business partner. Not with the ones I've worked with, anyway.";
		}
						else if (primeInt == 406){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "My travelling salesman service always has customers!";
                Char2name.text = "";
                Char2speech.text = "";
		}
						else if (primeInt == 407){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "... Ah, alright. What the hell Old Sport! I'll do it.";
		}
						else if (primeInt == 408){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "My wealth is your wealth until the stock market crashes!";
		}
						else if (primeInt == 409){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "YIPPEEE!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
		}
						else if (primeInt == 500){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "W-w-what??? A hug, Old Sport?";
		}
								else if (primeInt == 501){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Yeah, hugs cheer me up real quick, usually.";
                Char2name.text = "";
                Char2speech.text = "";
		}
								else if (primeInt == 502){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "The offer is nice but I don't erm, swing that way Old Sport.";
		}
								else if (primeInt == 503){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ehhhhh your book begs to differ...";
                Char2name.text = "";
                Char2speech.text = "";
		}
								else if (primeInt == 504){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "My what?";
		}
								else if (primeInt == 505){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Nothing nevermind C'MOOON pal!! A hug is a hug!!";
                Char2name.text = "CATSBY";
                Char2speech.text = "";
		}
								else if (primeInt == 506){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Well I haven't felt the touch of another living being in years so... alright.";
		}
								else if (primeInt == 507){
                Char1name.text = "";
                Char1speech.text = "*hug*";
                Char2name.text = "";
                Char2speech.text = "";
		}
								else if (primeInt == 508){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well? Feel better now?";
                Char2name.text = "";
                Char2speech.text = "";
		}
								else if (primeInt == 509){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Unsurprisingly, no. Who could've guessed a hug wouldn't infact fix my inablity to connect to others.";
		}
								else if (primeInt == 510){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CATSBY";
                Char2speech.text = "Thank you for the effort, Old Sport, but I must be going now. Farewell.";
		}
								else if (primeInt == 511){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well geez I'm kinda embarrassed now...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		       else if (primeInt == 512){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "This place is too stuffy for me... nobody'll buy my crap anyways.";
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
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Say, what's got ya down? Penny for your thoughts?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Say it again?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2aFunct(){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I could be your friend.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false); 
                nextButton.SetActive(true);
                allowSpace = true;
        }
				        public void Choice2bFunct(){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "What you look like you need... is a business partner!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false); 
                nextButton.SetActive(true);
                allowSpace = true;
        }
				        public void Choice2cFunct(){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Wanna uh... h-hug?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 499;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
				Choice2c.SetActive(false); 
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("EndWinCatsby");
        }
}