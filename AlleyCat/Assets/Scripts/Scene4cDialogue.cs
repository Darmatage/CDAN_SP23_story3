 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene4cDialogue : MonoBehaviour {
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
		public GameObject ArtChar2f;
		public GameObject ArtChar2g;
		public GameObject ArtChar2h;
		public GameObject ArtChar2i;
		public GameObject ArtChar2j;
		public GameObject ArtChar2k;
		public GameObject ArtChar2l;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2;
        public GameObject Choice3;
        public GameObject Choice4;
        public GameObject ChoiceWeird;
        public GameObject ChoiceWeird1a;
        public GameObject ChoiceWeird1b;
        public GameObject ChoiceWeird2;
        public GameObject ChoiceWeird3;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextSceneWeirdButton;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource scambo_theme;
       public AudioSource scambo_intro;
       public AudioSource weird_route;
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
		ArtChar2f.SetActive(false);
		ArtChar2g.SetActive(false);
		ArtChar2h.SetActive(false);
		ArtChar2i.SetActive(false);
		ArtChar2j.SetActive(false);
		ArtChar2k.SetActive(false);
		ArtChar2l.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2.SetActive(false);
        Choice3.SetActive(false);
        Choice4.SetActive(false);
        ChoiceWeird.SetActive(false);
        ChoiceWeird1a.SetActive(false);
        ChoiceWeird1b.SetActive(false);
        ChoiceWeird2.SetActive(false);
        ChoiceWeird3.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextSceneWeirdButton.SetActive(false);
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
               ArtChar1c.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Maybe there’s some more stuff to sell in this dumpster...?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
		   scambo_intro.Play();
		      ArtChar1c.SetActive(false);
			  ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "HEY THERE EVERY     !";
             
        }
       else if (primeInt == 4){
		      ArtChar1b.SetActive(true);
			  ArtChar2a.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "AH!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
		      ArtChar1b.SetActive(false);
			  ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "IT’S ME! THE BEST DARN CATNIP DEALER THIS SIDE OF THE [[Mississippi]]!";
              
        }
       else if (primeInt == 6){
			  ArtChar2a.SetActive(false);
			  ArtChar2b.SetActive(true);		   
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "SCAMBO A. SCRAMBLO! HAHAHAHAHAHAHAHA!";
        }
       else if (primeInt ==7){
			  ArtChar2b.SetActive(false);	
			  ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "WOAH, IF IT ISN’T A...";
	   }
				
       else if (primeInt ==8){
		   scambo_theme.Play();
		   scambo_intro.Stop();
			  ArtChar2c.SetActive(false);
			  ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "BIG CAT, HEY HEY HEY!";
				
	   }
				
       else if (primeInt ==9){
			  ArtChar2d.SetActive(false);
			  ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "HAVE YOU EVER FELT [[So so alone]]? HOUNDED BY [[Relentless heathens of the [[MUTT]] variety?]]";
	   }
				
       else if (primeInt ==10){
			  ArtChar2c.SetActive(false);
			  ArtChar2e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "ABANDONED AND THROWN INTO A F[[ifty percent off discount]] GARBAGE CAN?";
	   }
				
       else if (primeInt ==11){
			  ArtChar2e.SetActive(false);
			  ArtChar2g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "HAHAHAHA! BOY DO I HAVE A [[false hope]] FOR YOU!";
	   }
				
       else if (primeInt ==12){
			  ArtChar2g.SetActive(false);
			  ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hmm... already not thinkin’ he’s the greatest customer...";
                Char2name.text = "";
                Char2speech.text = "";
	   }
				
       else if (primeInt ==13){
			  ArtChar1a.SetActive(false);
			  ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Hey, uh, pal... I got somethin’ really good for ya, might spice up your...";
                Char2name.text = "";
                Char2speech.text = "";
	   }
				
       else if (primeInt ==14){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...dumpster there... How would YOU be interested in a-";
                Char2name.text = "";
                Char2speech.text = "";
	   }
				
       else if (primeInt ==15){
			  ArtChar1d.SetActive(false);
			  ArtChar2i.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "YOU THINK I WaNT YOUR GODDAMN GARBAGE?";
	   }
				
				
       else if (primeInt ==16){
			  ArtChar2i.SetActive(false);
			  ArtChar2f.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "I LIVE IN A DUMPSTER FOR [[Ford’s]] SAKE!";
	   }
				
       else if (primeInt ==17){
			  ArtChar2f.SetActive(false);
			  ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "BUT YOU, YOU LOOK LIKE A [[Weasely little urchin]] WHO COULD USE SOME [[Super Specal Herbal Product]]!";
	   }
				
       else if (primeInt ==18){
			  ArtChar2d.SetActive(false);
			  ArtChar2h.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "BUY IT NOW, B Uy IT HOW?? YOUR GUESS IS AS GOOD AS [[Investing in stocks today]]! ONLY 19 D0LLARONIS!!!!";
	   }
				
				
        
       else if (primeInt == 19){
			  ArtChar2h.SetActive(false);
			  ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Take the weed...?";
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
			  ArtChar2f.SetActive(false);
			  ArtChar2h.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "KICK BACK AND RELAX WITH SOME GOOD OLD FASHIONED [[Satan’s leaves]]!";
				
        }
		
       else if (primeInt == 101){
			  ArtChar2h.SetActive(false);
			  ArtChar2g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "YOUR’ E MY [[Latest, greatest]] CUSTOMER!";
	   }
		
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "Take the weed??";
                Char2name.text = "";
                Char2speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
//Choice 1b
       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "JSUT TAKE THE FDA [[recalled]] [[Specal]] PRODUCT!!!";
        }
		
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "Take the weed?!?!?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice2.SetActive(true);
        }
		
//Choice 2
       else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "JUST BUY SOME OF MY [[Big bad stuff for a limited time only]]!";
        }
		
       else if (primeInt == 301){
			  ArtChar2i.SetActive(false);
			  ArtChar2g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "IT’S SO GOOD, I $#%@ MYSELF!";
        }
		
       else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "Take. The. Weed.";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice3.SetActive(true); // function Choice1bFunct()
        }
		
//Choice 3
       else if (primeInt == 400){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "JUST. BUY. THE GODDAMN. [[Funny sauce]]!!!!";
        }
		
       else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "TAKE! THE! GODDAMN! WEED!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
                Choice4.SetActive(true);
                ChoiceWeird.SetActive(true);
	   }
				
//Choice 4

       else if (primeInt == 500){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		
//Weird Route Time
       else if (primeInt == 600){
			  ArtChar2j.SetActive(false);
			  ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(For once, he stopped talking.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
      else if (primeInt == 601){
		   weird_route.Play();
			  ArtChar1a.SetActive(false);
			  ArtChar2k.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "Once we go down this road, there’s no turning back. Do you understand?";
        }
		
       else if (primeInt == 602){
			  ArtChar2k.SetActive(false);
			  ArtChar2j.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Do you understand?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                ChoiceWeird1a.SetActive(true);
                ChoiceWeird1b.SetActive(true);
	   }
	   
//If Chose No
       else if (primeInt == 700){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
	   }
		
//Yes String
		       else if (primeInt == 800){
			  ArtChar2k.SetActive(false);
			  ArtChar2j.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "Will you keep going?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                ChoiceWeird2.SetActive(true);
                ChoiceWeird1b.SetActive(true);
	   }
	   
      else if (primeInt == 900){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "If you want to turn back, take it.";
        }
		
      else if (primeInt == 901){
			  ArtChar2k.SetActive(false);
			  ArtChar2l.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "N O W.";
        }
		
		       else if (primeInt == 902){
                Char1name.text = "";
                Char1speech.text = "Will you continue on anyway?";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                ChoiceWeird3.SetActive(true);
                ChoiceWeird1b.SetActive(true);
	   }
	   
      else if (primeInt == 1000){
			  ArtChar2k.SetActive(false);
			  ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "NOW THAT THE DEAL IS [[clap on, clap off]], LET ME SHOW YOU MY [[wares]]!";
        }
		
       else if (primeInt == 1001){
                Char1name.text = "";
                Char1speech.text = "Go deeper.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextSceneWeirdButton.SetActive(true);
	   }
	   
     }
// THERE SHOULD ALWAYS BE TWO BRACKETS ABOVE, ONE TO CLOSE THE LAST DIALOGUE LINE AND ONE TO CLOSE THE ENTIRE STORY UNIT SECTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)

//so for these, this is the single line your character says after picking a choice and the number (ending in 99) reroutes the dialogue to the correct route,
//which will be the first number that comes after the one ending in 99 here
//the first choice says 99, it will reroute you to the dialogue that starts at primeInt=100 bc 100 comes after 99
//same for the second choice saying 199, it will reroute you to the dialogue that starts at primeInt=200 bc 200 comes after 199
//the numbers will probably get pretty big depending on how many choices you have so dont stress if they do

//Normal Routes
        public void Choice1aFunct(){
			  ArtChar2d.SetActive(false);
			  ArtChar2i.SetActive(false);
			  ArtChar2g.SetActive(false);
			  ArtChar2f.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "NOW THAT’S THE [[heart and soul]]!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice2.SetActive(false);
                Choice3.SetActive(false);
                Choice4.SetActive(false);
				ChoiceWeird.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			  ArtChar2d.SetActive(false);
			  ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "WHAT? COME ON, YOU WERE SO CLOSE!";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2Funct(){
			  ArtChar2c.SetActive(false);
			  ArtChar2i.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "COME ON, BUD. DON’T BE A [[dead man walking]] HERE!";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice2.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3Funct(){
			  ArtChar2g.SetActive(false);
			  ArtChar2i.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "YOU'RE REAAALLY PUSHIN MY [[sales pins]] HERE, BUD.";
                primeInt = 399;
                Choice1a.SetActive(false);
                Choice3.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
		}
        public void Choice4Funct(){
			  ArtChar2i.SetActive(false);
			  ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I'm gettin' outta here...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 499;
                Choice1a.SetActive(false);
                Choice4.SetActive(false);
				ChoiceWeird.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
//Weird Route
		
        public void ChoiceWeirdFunct(){
		   scambo_theme.Stop();
			  ArtChar2i.SetActive(false);
			  ArtChar2j.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "...";
                primeInt = 599;
                Choice1a.SetActive(false);
                Choice4.SetActive(false);
				ChoiceWeird.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void ChoiceWeird1bFunct(){
			  ArtChar2j.SetActive(false);
			  ArtChar2l.SetActive(false);
			  ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Time to get out of here...)";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 699;
				ChoiceWeird1a.SetActive(false);
				ChoiceWeird1b.SetActive(false);
				ChoiceWeird2.SetActive(false);
				ChoiceWeird3.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void ChoiceWeird1aFunct(){
			  ArtChar2j.SetActive(false);
			  ArtChar2k.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "This is not a decision made lightly. You cannot turn back. Do you wish to proceed?";
                primeInt = 799;
				ChoiceWeird1a.SetActive(false);
				ChoiceWeird1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void ChoiceWeird2Funct(){
			  ArtChar2j.SetActive(false);
			  ArtChar2k.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "…I will give you one last chance.";
                primeInt = 899;
				ChoiceWeird2.SetActive(false);
				ChoiceWeird1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void ChoiceWeird3Funct(){
			  ArtChar2l.SetActive(false);
			  ArtChar2k.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SCAMBO";
                Char2speech.text = "…Understood.";
                primeInt = 999;
				ChoiceWeird3.SetActive(false);
				ChoiceWeird1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("EndLoseWeed");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5");
        }
        public void SceneChangeWeird(){
               SceneManager.LoadScene("SceneWeird");
        }
}