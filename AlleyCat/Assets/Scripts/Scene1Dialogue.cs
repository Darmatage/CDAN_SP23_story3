 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
	   public Text Char4name;
       public Text Char4speech;
        public GameObject DialogueDisplay;
		//player art
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
		public GameObject ArtChar1e;
		public GameObject ArtChar1f;
		//NPC art
       public GameObject ArtChar2a;
       public GameObject ArtChar2b;
       public GameObject ArtChar3a;
       public GameObject ArtChar3b;	   
       public GameObject ArtChar4a;
       public GameObject ArtChar4b;	   
	   
        public GameObject ArtBG1;
		
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
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
		ArtChar1f.SetActive(false);
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
        //NextScene2Button.SetActive(false);
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
                Char1speech.text = "Holy heck, the city always smells worse at night.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";				
        }
       else if (primeInt ==3){
		   ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "At least I have this alley to myself.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		    ArtChar1a.SetActive(false);
		    ArtChar1e.SetActive(true);
			
		   ArtChar2a.SetActive(true);
		   ArtChar3a.SetActive(true);
		   ArtChar4a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Oh! Hey, fellas. Three canines against one scrappy cat, is that how it is?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";			
		}
       else if (primeInt == 5){
		     ArtChar1a.SetActive(true);
		    ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "You know why we’re here, cat.";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
                //gameHandler.AddPlayerStat(1);
        }
  
       else if (primeInt == 6){
		     ArtChar1a.SetActive(false);
		    ArtChar1f.SetActive(true);		   
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Uh, oh. Do I beg for more time, or remind 'em they need me?)";
                Char2name.text = "";
                Char2speech.text = "";
                 Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	               
				
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		
		
     else if (primeInt == 10){
		 		     ArtChar1d.SetActive(false);
		    ArtChar1e.SetActive(false);
			 ArtChar1f.SetActive(true);
		  ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
		   		  ArtChar3b.SetActive(false);
		   ArtChar3a.SetActive(true);
		   ArtChar4a.SetActive(true);
			 ArtChar4b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "You are now three weeks behind on payments. \n You know exactly what happens next.";
        
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";			
		}
       else if (primeInt ==11){
		   ArtChar1f.SetActive(false);
			 ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "C’mon! I-I’ve been such a good salescat! \n I can scrape it all together in an afternoon!";
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
		    ArtChar3a.SetActive(false);
			 ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        
                Char3name.text = "GRUNT 1";
                Char3speech.text = "Another lie to save your worthless fur?";				
                Char4name.text = "";
                Char4speech.text = "";			
		}
       else if (primeInt ==13){
		   ArtChar1d.SetActive(false);
			 ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "W-what? No way! I-I’ve got this big deal, see! A few, actually! \n I’ll have it all settled lickity split!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}		
     else if (primeInt == 14){
		 
		 ArtChar3a.SetActive(true);
			 ArtChar3b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "DOGS";
                Char4speech.text = "(...)";			
		}
       else if (primeInt ==15){
		   ArtChar1c.SetActive(false);
			 ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "…heh heh…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}		
				
		else if (primeInt ==16){
			ArtChar1f.SetActive(false);
			 ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "You have until tonight. \n Do not keep us waiting.";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}
	
		else if (primeInt ==17){
			ArtChar3a.SetActive(false);
			 ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GRUNT 1";
                Char3speech.text = "And don’t try to skip town, neither. \n You even try to hitch a ride…";				
                Char4name.text = "";
                Char4speech.text = "";	
	}
	
	       else if (primeInt ==18){
			   ArtChar3a.SetActive(true);
			 ArtChar3b.SetActive(false);
			 ArtChar4a.SetActive(false);
			 ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GRUNT 2";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "GRUNT 2";
                Char4speech.text = "You’re. Done. Capiche?";	
	}
	
	       else if (primeInt ==19){
			   ArtChar1a.SetActive(false);
			 ArtChar1c.SetActive(true);
			   ArtChar4a.SetActive(true);
			 ArtChar4b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Yeah, yeah! I got it! I’ll get it ALL done!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}

	       else if (primeInt ==20){
			   ArtChar2a.SetActive(false);
			 ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BOSS";
                Char2speech.text = "Hmph.";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}

	       else if (primeInt ==21){
			   ArtChar1c.SetActive(false);
			 ArtChar1a.SetActive(true);
			ArtChar2a.SetActive(false);
			ArtChar2b.SetActive(false);
		   ArtChar3a.SetActive(false);
		   ArtChar4a.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Okay. I got til tonight… I got til tonight…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
	}

	       else if (primeInt ==22){
			   ArtChar1a.SetActive(false);
			 ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I better grab my cart with the goods n' get goin'...";
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
		   ArtChar4a.SetActive(false);
			 ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "GRUNT 2";
                Char4speech.text = "Heh. I like it when they beg.";	

	}
	
	       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GRUNT 1";
                Char3speech.text = "Yeah. But it’s a bit late, ain't it?";				
                Char4name.text = "";
                Char4speech.text = "";	
				primeInt = 9;

	}
	

       else if (primeInt == 200){

		   ArtChar4a.SetActive(false);
			 ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "GRUNT 2";
                Char4speech.text = "You think you’re hot stuff?";	        
		
		}
		
       else if (primeInt == 201){
		   		   ArtChar1f.SetActive(true);
			 ArtChar1e.SetActive(false);
		   ArtChar3a.SetActive(false);
			 ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GRUNT 1";
                Char3speech.text = "How hot will olll Scrappy be, stuffed in a hobo trash fire?";				
                Char4name.text = "";
                Char4speech.text = "";	        
		
		}
		
       else if (primeInt == 202){
		   
		   ArtChar4a.SetActive(false);
			 ArtChar4b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "GRUNT 2";
                Char4speech.text = "Pretty hot!";	        
				primeInt = 9;
		}
		
		
		
	//END BRACKETT OF NEXT FUNCTION. DO NOT DELETE:	
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
					     ArtChar1d.SetActive(true);
		    ArtChar1f.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hey now, fellas! L-look. I know I'm late-gimme a bit more time! \n I promise I can pay it all back!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";	
				
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
					     ArtChar1f.SetActive(false);
		    ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hey now, fellas! I know it ain't all settled yet, but I’m your best dealer! \n You won’t find anyone better than me.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";				
                Char4name.text = "";
                Char4speech.text = "";					
				
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
        }
        // public void SceneChange2(){
                // SceneManager.LoadScene("Scene2b");
        // }
}