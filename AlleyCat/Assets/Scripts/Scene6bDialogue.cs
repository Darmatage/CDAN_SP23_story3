 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


//CHANGE THIS TO SAY Scene(NUMBER)Dialogue
public class Scene6bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
		//IF YOU HAVE TO ADD A NEW CHARACTER, OR MORE SPRITES FOR ONE CHARACTER MAKE SURE YOU INCLUDE THAT HERE
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
		public GameObject ArtChar1e;
		public GameObject ArtChar1f;
		public GameObject ArtChar2a;
		public GameObject ArtChar2b;
		public GameObject ArtChar2c;
		public GameObject ArtChar3a;
		public GameObject ArtChar3b;
		public GameObject ArtChar3c;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject ArtBG3;
		public GameObject ArtBG4;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
		public AudioSource footsteps;
       //public GameHandler gameHandler;
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
		ArtChar1f.SetActive(false);
	    ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		ArtChar3a.SetActive(false);
		ArtChar3b.SetActive(false);
		ArtChar3c.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
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
        }
		
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah of course!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "The beach = people = customers = chumps = big money!!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";             
        }
       else if (primeInt == 4){
               ArtChar1a.SetActive(false);
               ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "OHOHOO!! I see a star glistening in the moonlight...!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
               ArtChar1b.SetActive(false);
               ArtChar2a.SetActive(true);
               ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "FANCY CAT";
                Char2speech.text = "Oh my!!! What a garish scene-it reeks of decay...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
               ArtChar2a.SetActive(false);
               ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "ORANGE CAT";
                Char3speech.text = "Really? Smells kinda nice... like pasta.";
        }
       else if (primeInt ==7){
               ArtChar1a.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "HELLOOO valued customers!!! Welcome to my humble storefront!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt ==8){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I have all sorts of lovely accessories and wares!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt ==9){
               ArtChar1e.SetActive(true);
               ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "FANCY CAT";
                Char2speech.text = "Gurf, I really don’t think theres anything of value here...";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt ==10){
               ArtChar3b.SetActive(false);
               ArtChar3c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "C’mon ChiChi... I see something yummy-looking on the corner of the cart...";
        }
		
       else if (primeInt ==11){
		   ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
		ArtBG4.SetActive(false);
		
               ArtChar2c.SetActive(false);
               ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "That moldy piece of lasagna???! Don’t be daft!";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt ==12){
		   ArtBG2.SetActive(true);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(true);
               ArtChar2a.SetActive(false);
               ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "That bedazzled hair tie on the other hand... Now that’s chic.";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
		
       else if (primeInt == 13){
		   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "(Hmmm... who to pander to...)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
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
		   ArtBG2.SetActive(true);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "This hair tie is Gucci... with REAL diamonds!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 101){
               ArtChar2a.SetActive(true);
               ArtChar2c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "I’m sure that a lady of such grace as yourself would be the talk of the town playing with this thing!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "Oh, you’re so right...!!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 103){
		   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
               ArtChar2c.SetActive(true);
               ArtChar2a.SetActive(false);
               ArtChar1f.SetActive(true);
               ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "Gurf, can you lend me some more cash? Pretty please?";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 104){
               ArtChar3b.SetActive(false);
               ArtChar3c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "Ah... but... I bought your hat, gloves, purse, necklace, sunglasses, and all three meals today alone...";
        }
		
       else if (primeInt == 105){
               ArtChar2b.SetActive(true);
               ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "I don’t think you need this actually...?";
        }
		
       else if (primeInt == 106){
               ArtChar1d.SetActive(true);
               ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "No-you don’t understand!!! I’ll pay you back, I promise!!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 107){
		   
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "I just need to beg my friends and family to buy the 400 pillows I invested in...!!\nCOME BACK!!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 108){
			footsteps.Play();
			ArtChar3a.SetActive(false);
               ArtChar3b.SetActive(false);
			   ArtChar3c.SetActive(false);
               ArtChar2a.SetActive(false);
			ArtChar2b.SetActive(false);
               ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "*step* *step* *step*";
        }
		
       else if (primeInt == 109){
               footsteps.Stop();
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Ah... my money...! Nooo...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 110){
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Well. Time's up. How much did I make? I'd like to stop by the docks, too.\nMaybe I can flee by boat!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				//these three lines below only appear when you move onto the next scene
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
		   ArtBG2.SetActive(true);
		ArtBG3.SetActive(true);
		ArtBG4.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "See, the mold on this lasagna is cheese from the swiss hills actually!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 201){
               ArtChar3b.SetActive(false);
               ArtChar3c.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Only the most delectable flavoring in the world for my clientele.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 202){
               ArtChar2c.SetActive(false);
               ArtChar2b.SetActive(true);
               ArtChar1c.SetActive(true);
               ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "Ahhh I’m so hungry... It’s all I can afford after buying all your stuff and food today ChiChi...";
        }
		
       else if (primeInt == 203){
		   ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "B-b-b-b-b-b-b-but I promised I’ll pay you back...";
                Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 204){
               ArtChar1e.SetActive(true);
               ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "Hmmmmm...";
        }

       else if (primeInt == 205){
               ArtChar1c.SetActive(true);
               ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "Nahh... I need something to look forward to tomorrow Monday morning... this is all I got...";
        }
		else if (primeInt == 206){
               ArtChar1c.SetActive(true);
               ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "GURF";
                Char3speech.text = "I'll take it... thank you.";
        }
		else if (primeInt == 207){
               ArtChar1c.SetActive(true);
               ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "CHICHI";
                Char2speech.text = "WAAAIT please, it looked sooo fancyyy!!!";
                Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 208){
			footsteps.Play();
               ArtChar1c.SetActive(true);
               ArtChar3a.SetActive(false);
               ArtChar3b.SetActive(false);
			   ArtChar3c.SetActive(false);
               ArtChar2a.SetActive(false);
			ArtChar2b.SetActive(false);
               ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*step* *step* *step*";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 209){
		   footsteps.Stop();
               ArtChar1a.SetActive(true);
               ArtChar1c.SetActive(false);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "Pleasure doing business sir!!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }

		//only the last dialogue
       else if (primeInt == 210){
               ArtChar2b.SetActive(false);
               ArtChar3c.SetActive(false);
               ArtChar1a.SetActive(false);
               ArtChar1b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "AH... AHAH!! Yes... okay, how much did I make...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
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
               ArtChar1a.SetActive(true);
               ArtChar1e.SetActive(false);
               ArtChar3c.SetActive(false);
               ArtChar3b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "A-Ah!!!!! Yes, yes, yes you have a good eye!!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
               ArtChar1a.SetActive(true);
               ArtChar1e.SetActive(false);
               ArtChar3c.SetActive(false);
               ArtChar3b.SetActive(true);
                Char1name.text = "SCRAPPY";
                Char1speech.text = "And what a fine nose you have kind sir!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
//make sure for the scene change below it matches the name of the scene you want to go to, like endloserat or scene5 etc

        public void SceneChange1(){
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene8");
        }
}