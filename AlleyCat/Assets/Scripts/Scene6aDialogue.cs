 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene6aDialogue : MonoBehaviour {
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
		public GameObject ArtBG3;
		public GameObject ArtBG4;
        public GameObject Choice1a;
        public GameObject Choice1b;
		        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
	   public AudioSource beach_theme;
       //public AudioSource audioSource;
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
		ArtChar2d.SetActive(false);
		ArtChar2e.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
                Char1speech.text = "Ahhh the sight of water usually scares me but that smell is so ni-";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		   	ArtChar1a.SetActive(false);
		     ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...*sniff*... Where's that scrumptious stank comin' from?";
                Char2name.text = "";
                Char2speech.text = "";
             
        }
       else if (primeInt == 4){
		   ArtChar2b.SetActive(true);
		  
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "GOOD DAY SIR! Hate to be a bother, but you seem to be blocking the dock with your cart!";
        }
       else if (primeInt == 5){
		   	ArtChar1a.SetActive(false);
		     ArtChar1b.SetActive(true);
			ArtChar2b.SetActive(false);
		     ArtChar2a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "OH WOW A FISH!?!? Great timing I'm STARV-";
                Char2name.text = "";
                Char2speech.text = "";
              
        }
       else if (primeInt == 6){
		   ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);

                Char1name.text = "SCRAPPY";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
		   
		    DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
		    DialogueDisplay.SetActive(true);
			ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);

                Char1name.text = "SCRAPPY";
                Char1speech.text = "(What am I looking at here.)";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
				//these three lines below only appear at choices
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		       else if (primeInt ==15){
			ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(false);
					ArtChar1d.SetActive(false);
						ArtChar1e.SetActive(false);
						
		     ArtChar1c.SetActive(true);
			ArtChar2b.SetActive(false);
		     ArtChar2a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I see... well. Must get lonely huh, dear customer of mine?";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt ==16){
						  
		ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
		ArtBG4.SetActive(false);
						   ArtChar1c.SetActive(false);
		     ArtChar1b.SetActive(true);
			ArtChar2a.SetActive(false);
		     ArtChar2b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "What if I showed you a... TIN OF SARDINES?!?! Fish to keep you company!";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt ==17){
						   ArtChar1a.SetActive(false);
		     ArtChar1b.SetActive(true);
			ArtChar2b.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "OHO! I AM painfully lonely! Let's see... AHHH!!!";
        }
				       else if (primeInt ==18){
			ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);
			ArtChar2c.SetActive(false);
		     ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "GOOD GOD MAN... THESE ARE...!!!";
        }
				       else if (primeInt ==19){
						   ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);
			ArtChar2d.SetActive(false);
		     ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "MY CHILDREN!!!!!!";
        }		       
				else if (primeInt ==20){
					ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);
	
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...Huh. How do you... know that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt ==21){
						   ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);
			ArtChar2e.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "ARE YOU BLIND!?!? Look at their little legs...!!!";
        }
			 else if (primeInt ==22){
		ArtBG2.SetActive(true);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(true);
				 ArtChar1a.SetActive(true);
		     ArtChar1d.SetActive(false);
			ArtChar2e.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "......";
                Char2name.text = "";
                Char2speech.text = "";
        }
						       else if (primeInt ==23){
		
			
				  ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);
			ArtChar2e.SetActive(false);
		     ArtChar2c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...Oh. Well. So, you want to buy them?";
                Char2name.text = "";
                Char2speech.text = "";
        }
						       else if (primeInt ==24){
			ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);
			ArtChar2c.SetActive(false);
		     ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Well I didn't say that.";
        }
						       else if (primeInt ==25){
								   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
								    ArtChar1a.SetActive(true);
		     ArtChar1d.SetActive(false);
			ArtChar2c.SetActive(false);
		     ArtChar2d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Huh? But they're yours. Are you a...";
                Char2name.text = "";
                Char2speech.text = "";
				                nextButton.SetActive(false);
                allowSpace = false;
				Choice2a.SetActive(true); // function Choice1aFunct()
                Choice2b.SetActive(true); // function Choice1bFunct()
        }
				//if you have more choices later on, label them, like if its the 2nd choice= Choice2a and Choice2b
				
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
		   			ArtChar1b.SetActive(false);
		     ArtChar1d.SetActive(true);
			  ArtChar2a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "It's just... a giant talking fish is mind boggling.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
		   		   			ArtChar1a.SetActive(true);
		     ArtChar1d.SetActive(false);
			  ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Ahahah I can understand! Seeing someone so beautiful can be shocking.";
	   }		
        else if (primeInt == 102){
					   		   			
			  ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "If you keep a good skincare routine you too could look as extravagant as me!";
		}
       else if (primeInt == 103){
		   		   		   			ArtChar1a.SetActive(false);
		     ArtChar1b.SetActive(true);
			  ArtChar2a.SetActive(true);
			    ArtChar2b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "What's your routine?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 104){
		   ArtChar1a.SetActive(false);
		     ArtChar1b.SetActive(true);
			  ArtChar2a.SetActive(false);
			    ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Swimming in radioactive water every night!";
				primeInt = 14;
        }


       else if (primeInt == 200){
		   ArtChar1a.SetActive(true);
		     ArtChar1c.SetActive(false);
			  ArtChar2a.SetActive(true);
			    ArtChar2b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "That's the only possible explanation for those legs.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		//only the last dialogue
       else if (primeInt == 201){
		
			  ArtChar2a.SetActive(false);
			    ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "COSTUME!?!? SIR! I work hard to get them this smooth!";
        }
		       else if (primeInt == 202){
				   ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);
			  ArtChar2a.SetActive(false);
			    ArtChar2c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "How'd ya uh... get them in the first place.";
                Char2name.text = "";
                Char2speech.text = "";
        }
				       else if (primeInt == 203){
				 ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);
			  ArtChar2c.SetActive(false);
			    ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Exercise is key! A good workout will help you build muscle!";
        }
				       else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Like swimming laps in that green goo lake leaking out the Malwart down the road!";
				primeInt = 14;
        }
				else if (primeInt == 300){
					 ArtChar1a.SetActive(true);
		     ArtChar1e.SetActive(false);
			  ArtChar2a.SetActive(false);
			    ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "W-W-Wh..! I-I'm not fit to care for them...! I...";
        }
						else if (primeInt == 301){
							 ArtChar1a.SetActive(true);
		     ArtChar1b.SetActive(false);
			  ArtChar2d.SetActive(false);
			    ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "I sold them to a fisherman after gambling all my money at a Clamsino...";
        }
						else if (primeInt == 302){
							ArtChar1a.SetActive(false);
		     ArtChar1c.SetActive(true);
			  ArtChar2d.SetActive(false);
			    ArtChar2e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Wow. What a guy. But I know how ya feel, mister. Don't this seem like fate, though?";
                Char2name.text = "";
                Char2speech.text = "";
        }
						else if (primeInt == 303){
							ArtChar1b.SetActive(true);
		     ArtChar1c.SetActive(false);
			  ArtChar2d.SetActive(true);
			    ArtChar2e.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Why not give yerself a second chance at fatherhood? For the kids' sakes.";
                Char2name.text = "";
                Char2speech.text = "";
        }
						else if (primeInt == 304){
					ArtChar1b.SetActive(false);	
		     ArtChar1a.SetActive(true);
			  ArtChar2d.SetActive(false);
			    ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Glbblblgblg... *SNIFFLEEE* Y-you're right...!!! It's what's right.";
        }
						else if (primeInt == 305){
				
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Thank you for showing me the right path... I'll take th-";
        }
						else if (primeInt == 306){
							ArtChar1a.SetActive(false);	
		     ArtChar1c.SetActive(true);
			  ArtChar2e.SetActive(true);
			    ArtChar2c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Woah woah woah-! This is a store, not an adoption agency. Cash only!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
						else if (primeInt == 307){
		
			  ArtChar2e.SetActive(false);
			    ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "Ughhhh... Fine. Take my money.";
        }
								else if (primeInt == 308){
									ArtChar1c.SetActive(false);	
		     ArtChar1b.SetActive(true);
			  ArtChar2d.SetActive(false);
			    ArtChar2c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "PLEASURE DOING BUSINESS!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
								else if (primeInt == 309){
									
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Mwehehe... I'll take a walk on the beach as a reward.";
                Char2name.text = "";
                Char2speech.text = "";

        }
										else if (primeInt == 310){
				ArtChar1a.SetActive(true);	
		     ArtChar1b.SetActive(false);							
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hope I made enough to ward off the hounds...";
                Char2name.text = "";
                Char2speech.text = "";
						nextButton.SetActive(false);
                allowSpace = false;
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);	
        }
       
		
						       else if (primeInt == 400){
			ArtChar1a.SetActive(true);	
		     ArtChar1e.SetActive(false);
			  ArtChar2d.SetActive(false);
			    ArtChar2c.SetActive(true);					   
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "WELL I never...!!!!";
        }
								       else if (primeInt == 401){
										    ArtChar2d.SetActive(true);
			    ArtChar2c.SetActive(false);	
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "You don't know what I've been through..!";
        }
								       else if (primeInt == 402){
										    ArtChar2d.SetActive(false);
			    ArtChar2e.SetActive(true);	
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "How much radioactive water I've had to swim through to get to this point!";
        }
								       else if (primeInt == 403){
				ArtChar2e.SetActive(false);
			    ArtChar2c.SetActive(true);							   
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MERMAID";
                Char2speech.text = "SCREW YOU JERK!!!";
        }
								       else if (primeInt == 404){
					 ArtChar2c.SetActive(false);					   
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*splash*";
        }
								       else if (primeInt == 405){
			 ArtChar1a.SetActive(false);	
		     ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Into the sea he goes... well carp. Crap, crap. Not carp.";
                Char2name.text = "";
                Char2speech.text = "";
        }
								       else if (primeInt == 406){
										   ArtBG2.SetActive(true);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(true);
				 ArtChar1d.SetActive(false);	
		     ArtChar1c.SetActive(true);						   
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well... these sardines sure do look good... and he ain't comin' back...";
                Char2name.text = "";
                Char2speech.text = "";
        }
								       else if (primeInt == 407){
										   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
				 ArtChar1c.SetActive(false);	
		     ArtChar1b.SetActive(true);						   
                Char1name.text = "SCRAPPY";
                Char1speech.text = "*nom nom nom nom*";
                Char2name.text = "";
                Char2speech.text = "";
        }
										       else if (primeInt == 408){
				 ArtChar1b.SetActive(false);	
		     ArtChar1a.SetActive(true);								   
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ahh.. much better. Now... hope I made enough to ward off the hounds...";
                Char2name.text = "";
                Char2speech.text = "";
								nextButton.SetActive(false);
                allowSpace = false;
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
				 ArtChar1d.SetActive(false);	
		     ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Sorry but er uh... how are you. Alive?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
				 ArtChar1d.SetActive(false);	
		     ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Are you wearing a fish costume, guy?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2aFunct(){
ArtChar1a.SetActive(false);
						ArtChar1b.SetActive(false);
						ArtChar1c.SetActive(false);
						ArtChar1d.SetActive(false);						 
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "A neglectful parent who left these babies to die?! These poor souls!!!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2bFunct(){
						ArtChar1a.SetActive(false);
						ArtChar1b.SetActive(false);
						ArtChar1c.SetActive(false);
						ArtChar1d.SetActive(false);	
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "A deadbeat, scumbag, good-for-nothing dad?!?!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("Scene8");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene7");
        }
}