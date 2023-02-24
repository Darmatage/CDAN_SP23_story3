 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene4aDialogue: MonoBehaviour {
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
		public GameObject ArtChar2c;
		//public GameObject ArtChar2d;
		//public GameObject ArtChar2e;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
	 public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		        public GameObject Choice2a;
        public GameObject Choice2b;
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
		//ArtChar2d.SetActive(false);
		//ArtChar2e.SetActive(false);
       ArtBG1.SetActive(true);
	   ArtBG2.SetActive(false);
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
                Char1speech.text = "The pub's bound to be crawling with drunks-and there's nobody I love scamming more than drunks!!!";
                Char2name.text = "";
                Char2speech.text = "";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
		   ArtBG1.SetActive(false);
		    ArtBG2.SetActive(true);
	  ArtChar1a.SetActive(false);
	    DialogueDisplay.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
             		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 4){
		    ArtChar1a.SetActive(false);
		      ArtChar1e.SetActive(true);
		    DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "You there! With the stripes!";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
		     ArtChar1e.SetActive(true);
		      ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "wWho are you, ttalkjing to? ? Me??";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
              
        }
       else if (primeInt == 6){
		     ArtChar1e.SetActive(false);
		     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Yes you! What a night, huh? How many pints you put away already?";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "Pints...............";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "........of ice cream ?";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt ==9){
				     ArtChar1a.SetActive(false);
				     ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Fuck yes!!!)";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt == 10){
				     ArtChar1d.SetActive(false);
				     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Just gotta butter him up..)";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
				//these three lines below only appear at choices
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		       else if (primeInt ==16){
				   ArtChar1a.SetActive(false);
				     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "See this 'puddle' right here...? It's Miracle Murk.";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		       else if (primeInt ==17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "... mmMirachle? Murk??";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				       else if (primeInt ==18){
						   ArtChar1e.SetActive(false);
						     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Yeahhh that's the stuff! You tellin' me you've never heard of this?";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				       else if (primeInt ==19){
                Char1name.text = "";
                Char1speech.text = ""; 
                Char2name.text = "DRUNKARD";
                Char2speech.text = "nNOOO SHOULD I???!";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				       else if (primeInt ==20){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Easy pal, this here's the best cure for a hangover on the market. \n Want a taste test? I'm sellin' it y'see.";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
				       else if (primeInt ==21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "YeyyEAAAAAHshhhh i dooO!!!!";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 22){
		   ArtChar1a.SetActive(false);
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(How much puddle water do I give him?)";
                Char2name.text = "";
                Char2speech.text = "";
						 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
				//these three lines below only appear at choices
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice1aFunct()
                Choice2b.SetActive(true); // function Choice1bFunct()
        }
				else if (primeInt ==26){
					ArtChar1e.SetActive(false);
					  ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "That murky color and consistency's just all the vitamins and bact-nutrients. Nutrients. Hehe.";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }		
				else if (primeInt ==27){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "howe ... logn. Does it take. Unnntiilll it kicks inn..? ??";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }				
				
				else if (primeInt ==28){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Trust me pal. Tomorrow mornin' you'll be up and at 'em. Ready for anything!";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }		
		else if (primeInt ==29){
			ArtChar1a.SetActive(false);
			  ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "So what do ya say? Can I put you down for a full bottle's worth?";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "Hey y'know what.... I think it's already... kickin' in...";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==31){
			 ArtChar2a.SetActive(false);
			  ArtChar2b.SetActive(false);
			  ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "WOW!!! The world's not spinning anymore!! This stuff really works!!!";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }				
		else if (primeInt ==32){
		
                Char1name.text = "SCRAPPY";
                Char1speech.text = "......";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==33){
			ArtChar1e.SetActive(false);
			  ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Really?";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "I've gotta tell everyone!! Hey guys! This drink cures hangovers instantly!!!";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==35){
                Char1name.text = "";
                Char1speech.text = "*step* *step* *step *step*";
                Char2name.text = "";
                Char2speech.text = "";
						 Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }	
		else if (primeInt ==36){
			ArtChar1c.SetActive(false);
			  ArtChar1b.SetActive(true);
			   ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "RANDO 1";
				Char3speech.text = "I'll hhhave one bleaseee.!!!";
				Char4name.text = "";
                Char4speech.text = "";
		}	
				else if (primeInt ==37){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "RANDO 1";
				Char3speech.text = "Wow I really am cured!";
				Char4name.text = "";
                Char4speech.text = "";
		}	
				else if (primeInt ==38){
					ArtChar1b.SetActive(false);
					  ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Cured...?!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
		}	
				else if (primeInt ==39){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "RANDO 2";
				Char4speech.text = "MMe n-next..! Me next..!";
		}
				else if (primeInt ==40){
					ArtChar1e.SetActive(false);
					  ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(These cats're lining up for this stuff! Who knows what craps breeding in it though...)";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
		}			
						else if (primeInt ==41){
							ArtChar1a.SetActive(false);
							  ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(The short term effects are great but... what about when they throw this up tomorrow?)";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
		}	
						else if (primeInt ==42){
							ArtChar1c.SetActive(false);
							  ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(There's a market for this stuff, b-but I'm poisoning people! Ohhh what to do...)";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
			  nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
		}	
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "F...friends...? They got sick uh me. cUz i'd show up. .. w@st'd allth' teime. . ..";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 101){
		   ArtChar1a.SetActive(false);
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Oh my! So we got a bit of a drinking problem here, eh?";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				//these three lines below only appear when you move onto the next scene
        }
		       else if (primeInt == 102){
				   ArtChar1e.SetActive(false);
				     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well worry no longer for your social life friend! For I have the cure!!!";
                Char2name.text = "";
                Char2speech.text = "";
						 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				//these three lines below only appear when you move onto the next scene
				primeInt = 15;
        }


       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "AUUUGHHH... i have t'work tmrw..... i'm gon na get f fffiireeed...!!! i gotta s0ber eup....";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
		       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "do yu have a uhhhh.... raw egg and uhhhh ... baking s..soda...??";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";      
	  }
		//only the last dialogue
       else if (primeInt == 202){
		    ArtChar1e.SetActive(false);
		     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Compadre worry not!!! I have the answer you're looking for-and it isn't a disgusting egg!!!";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 15;
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";     
	 }
		  else if (primeInt == 300){

                Char1name.text = "SCRAPPY";
                Char1speech.text = "And by sample I mean a bottle cap's full.";
                Char2name.text = "";
                Char2speech.text = "";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
				  else if (primeInt == 301){
					    ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Don't want ya drinking all my product on me, ya glutton. Here.";
                Char2name.text = "";
                Char2speech.text = "";
		 	Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";      
	  }
						  else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "au bububbubububbbb.... otay.......";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";      
	  }
						  else if (primeInt == 303){
							   ArtChar2a.SetActive(false);
							    ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "*mlem* *mlem* *mlem*";
				primeInt = 27;
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
				 else if (primeInt == 400){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "R-r-r-r-r-really..!?!?!? gEE tHANKS mister crappy!!!";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
						 else if (primeInt == 401){
							 ArtChar1a.SetActive(false);
							  ArtChar1e.SetActive(false);
							  ArtChar1e.SetActive(false);
							   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ok well. That's not my name and I never gave you. My name. Ok then.";
                Char2name.text = "";
                Char2speech.text = "";
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
						 else if (primeInt == 402){
							 ArtChar1b.SetActive(false);
							   ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Whatever DRINK YOUR TROUBLES AWAYYYY!!!";
                Char2name.text = "";
                Char2speech.text = "";
		 		Char3name.text = "";
               Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
	   }
						 else if (primeInt == 403){
							  ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "DRUNKARD";
                Char2speech.text = "*SLURPSLURPSKURPSLURPSLURPSLURPSLRUPSLRUP*";
				primeInt = 27;
		 		Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";       
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
			ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HAHA! What is such a funny guy doing alome at a pub? Got any pals?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "You are too funny, friend! Say, what're you up to tomorrow? It's only Sunday, after all.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2aFunct(){
					ArtChar1e.SetActive(false);
					ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "How about just a sample size for now huh?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2bFunct(){
					ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Know what? You can get it straight from the tap my friend! Help yourself.";
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
               SceneManager.LoadScene("EndWinCEO");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5");
        }
}