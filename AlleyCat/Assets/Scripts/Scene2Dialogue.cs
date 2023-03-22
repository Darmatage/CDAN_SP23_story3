 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
		public GameObject ArtChar1f;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
		
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
       public AudioSource town_theme;
	   public AudioSource rat_theme;
	 public AudioSource footsteps;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
		town_theme.Play();
        ArtChar1a.SetActive(false);
		 ArtChar1b.SetActive(false);
	  ArtChar1c.SetActive(false);
	   ArtChar1d.SetActive(false);
	    ArtChar1e.SetActive(false);
		   ArtChar1f.SetActive(false);
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
			
               ArtChar1f.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Aw geez. How the hell am I supposed to come up with that much money???)";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(I've been livin' off dead roaches for the past two weeks for cryin' out loud...)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   ArtChar1f.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "OOF!!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "SHEESH! What the he-";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
		    ArtChar1e.SetActive(false);
		   ArtChar1a.SetActive(true);
		   ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Hey, you okay?";
				 
        }
		       else if (primeInt == 7){
				    ArtChar1a.SetActive(false);
		   ArtChar1f.SetActive(true);
			    
                Char1name.text = "SCRAPPY";
                Char1speech.text = "A customer?! Or... a sucker!?!";
                Char2name.text = "";
                Char2speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true);
				Choice1b.SetActive(true);
				
			   }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
		   
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Cut the shit. You landed on your feet, cat.";
        }
       else if (primeInt == 101){
		    ArtChar1e.SetActive(false);
		   ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah...er, uhuh uhhhh w-well-";
                Char2name.text = "";
                Char2speech.text = "";

        }
		       else if (primeInt == 102){
				    ArtChar1f.SetActive(false);
		   ArtChar1d.SetActive(true);
				   ArtChar2a.SetActive(true);
		        ArtChar2b.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "WELCOME VALUED CUSTOMER to my quaint little cart of goods!!";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 103){
		    ArtChar1d.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "How may I help you on this divine evening?!?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 104){
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "??? You tripped over me???";

        }
       else if (primeInt == 105){
                ArtChar2a.SetActive(true);
		        ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Either way I don't want your garbage, pal.";

        }
       else if (primeInt == 106){
		    ArtChar1c.SetActive(false);
		   ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "GARBAGE? Listen buddy-I mean. Kind sir, I'm offended!!";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 107){
		    ArtChar1f.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "These are the highest quality luxury items and gourmet foods!";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 108){
		    ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "F-for instance, you seem to be a rat with the most distinguished taste! So...";
                Char2name.text = "";
                Char2speech.text = "";
 
        }
       else if (primeInt == 109){
		   ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Does this delectable goat's milk cheese pique your interest?!?";
                Char2name.text = "";
                Char2speech.text = "";

        }
       else if (primeInt == 110){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "That... is a moldy sponge.";

        }
		       else if (primeInt == 111){
				    ArtChar1c.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Nuh-uh.";
                Char2name.text = "";
                Char2speech.text = "";

        }
		       else if (primeInt == 112){
				   ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "There's flies swarming it. It's green on the back. It's fuzzy.";

        }
		       else if (primeInt == 113){
				   
				    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "This sounds like a typical French cheese to me, doesn't it?";
                Char2name.text = "";
                Char2speech.text = "";

        }
		      
        
		       else if (primeInt == 114){
				  ArtChar2a.SetActive(true);
		        ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "I. I don't think that's correct, actually.";


        }
		       else if (primeInt == 115){
				   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
				    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ohhh what. You a cheese connoisseur?\nYou want my cheese or what.";
                Char2name.text = "";
                Char2speech.text = "";

        }
		       else if (primeInt == 116){
				   
		        ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "You are REALLY startin' to piss me off here. Tryna pull a fast one on me?";

        }
		       else if (primeInt == 117){
				    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Of course not! You shouldn't get so riled up little guy-";
                Char2name.text = "";
                Char2speech.text = "";

        }
		       else if (primeInt == 118){
				town_theme.Stop();
				rat_theme.Play();
				    ArtChar2b.SetActive(false);
		        ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "LITTLE? WHO YOU CALLIN' LITTLE JACKASS?!";

        }
		       else if (primeInt == 119){
				   ArtBG4.SetActive(true);
				   ArtBG2.SetActive(true);
				    ArtChar1b.SetActive(false);
		   ArtChar1f.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "*siiiiip*";

        }
		       else if (primeInt == 120){
				    ArtBG4.SetActive(false);
				   ArtBG2.SetActive(false);
				    ArtChar2d.SetActive(false);
		        ArtChar2e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah. Motherfu-";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
       else if (primeInt == 200){
		    ArtChar1b.SetActive(false);
		     ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "WELCOME VALUED CUSTOMER to my quaint little cart of goods!!";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
       else if (primeInt == 201){
		    ArtChar1d.SetActive(false);
		     ArtChar1c.SetActive(true);
                 Char1name.text = "SCRAPPY";
                Char1speech.text = "How may I help you on this divine evening?!?";
                Char2name.text = "";
                Char2speech.text = "";
               
        }
		       else if (primeInt == 202){
				    ArtChar2a.SetActive(false);
		        ArtChar2c.SetActive(true);
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Oh uh... don't worry 'bout it.";
               
        }
            else if (primeInt == 203){
				ArtChar2a.SetActive(true);
		        ArtChar2c.SetActive(false);
                 Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "But ain't this a buncha... garbage?";
               
        }
		       else if (primeInt == 204){
				    ArtChar1c.SetActive(false);
		     ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "GARBAGE? Listen buddy-I mean. Kind sir, I'm offended!!";
                Char2name.text = "";
                Char2speech.text = "";
               
        }
		       else if (primeInt == 205){
				  
               Char1name.text = "SCRAPPY";
                Char1speech.text = "These are only the highest of quality luxury items and gourmet foods!";
                Char2name.text = "";
                Char2speech.text = "";
               
        }
			   else if (primeInt == 206){
				      ArtChar1b.SetActive(false);
		     ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "F-for instance, you seem to be a rat with the most distinguished taste! So...";
                Char2name.text = "";
                Char2speech.text = "";
               
        }		
		       else if (primeInt == 207){
				   ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
				      ArtChar1c.SetActive(false);
		     ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Does this delectable goat's milk cheese pique your interest?!?";
                Char2name.text = "";
                Char2speech.text = "";
             
        }
			   else if (primeInt == 208){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "...";
               
        }
			   else if (primeInt == 209){
				      ArtChar1d.SetActive(false);
		     ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";

        }
			   else if (primeInt == 210){
				   ArtChar2a.SetActive(false);
		        ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Gourmet... I ain't never had fancy food before...";
               
        }		
			   else if (primeInt == 211){
				   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
				   ArtChar2c.SetActive(false);
		        ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "But I ain't got any cash on me, pal.\nSpot me one?";
               
        }		
			   else if (primeInt == 212){
				   ArtChar2a.SetActive(false);
		        ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "I can promise your... protection.";
              
        }		
			   else if (primeInt == 213){
				      ArtChar1a.SetActive(false);
		     ArtChar1f.SetActive(true);
				   ArtChar2a.SetActive(true);
		        ArtChar2c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I'm... not sure. I need money bad, but it's cuz' I AM in danger...";
                Char2name.text = "";
                Char2speech.text = "";
               
        }		
			   else if (primeInt == 214){
				      ArtChar1f.SetActive(false);
		     ArtChar1c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Can I trust you to keep your word?";
                Char2name.text = "";
                Char2speech.text = "";
             
        }		
			   else if (primeInt == 215){
				      ArtChar2a.SetActive(false);
		        ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Rat's honor boss!";
              
        }		
			   else if (primeInt == 216){
				      ArtChar1c.SetActive(false);
		     ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Hmmm... what should I do?)";
                Char2name.text = "";
                Char2speech.text = "";
                 nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true);
				Choice2b.SetActive(true);
				
        }		
		       else if (primeInt == 300){
				   
				   ArtChar2a.SetActive(true);
		        ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "*shrug*";
               
        }
		       else if (primeInt == 301){
				   ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Your loss, pal.";
                
        }
		       else if (primeInt == 302){
				ArtChar2a.SetActive(true);
		        ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Good luck with your... situation and all.";
               
        }
		       else if (primeInt == 303){
				   footsteps.Play();
				      ArtChar1b.SetActive(false);
		     ArtChar1a.SetActive(true);
				   ArtChar2a.SetActive(false);
				 //   AudioSource.Play(footsteps);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
               
        }
		       else if (primeInt == 304){
				   footsteps.Stop();
                Char1name.text = "SCRAPPY";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
               
        }
		       else if (primeInt == 305){
				      ArtChar1a.SetActive(false);
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(What a jackass!!!! An IOU? What good is that for?!?)";
                Char2name.text = "";
                Char2speech.text = "";
               
        }
		       else if (primeInt == 306){
				      ArtChar1e.SetActive(false);
		     ArtChar1f.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Man. I gotta get outta this damp alley.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
				Debug.Log("is the rat on your side? " + GameHandler.ratAlly);
        }
		
		
		       else if (primeInt == 400){
				      ArtChar1c.SetActive(false);
		     ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I got these... scary guys I owe. And my deadline's tonight!!!";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
		       else if (primeInt == 401){
				   ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Sheesh. Sounds like you're in some hot shit pal. Don't you worry though.";
              
        }
		       else if (primeInt == 402){
				      ArtChar1e.SetActive(false);
		     ArtChar1a.SetActive(true);
				    ArtChar2b.SetActive(false);
		        ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "This rat's got your scrawny little back!";
               
        }
		       else if (primeInt == 403){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "RAT";
                Char2speech.text = "Hey, thanks for the cheese. The boys and me are gonna eat gooood tonight!";
             
        }
		       else if (primeInt == 404){
				      ArtChar1a.SetActive(false);
		     ArtChar1d.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Haha... yes, very good. Uhm. Enjoy your cheese and I'll be on my way now byeee!!!";
                Char2name.text = "";
                Char2speech.text = "";
              
        }
		       else if (primeInt == 405){
				   footsteps.Play();
				   ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "*stepstepstepstep*";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
				
				Debug.Log("is the rat on your side? " + GameHandler.ratAlly);
        }
	}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
			 ArtChar1f.SetActive(false);
		   ArtChar1e.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "OWWW!!! MY PAW-I THINK IT'S B-BROKEN?!! YOU'LL PAY MY BILL-";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			 ArtChar1f.SetActive(false);
		     ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "S-sorry 'bout that... uhm.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
			   ArtChar1f.SetActive(false);
		     ArtChar1b.SetActive(true);
			 GameHandler.ratAlly = false;
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah... a kind offer, but I'm kinda desperate for money right now sir.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice2bFunct(){
		   ArtChar1f.SetActive(false);
		     ArtChar1c.SetActive(true);
		     GameHandler.ratAlly = true; 
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well! I'll take you up on that offer.\nGod knows I need all the help I can get.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){
               SceneManager.LoadScene("EndLose1Rat");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3");
        }
}