using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameHandler : MonoBehaviour {

        public static bool ratAlly = false;


        public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
		public Texture2D cursorArrow;

        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
                GameisPaused = false;
				   Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

        // public void UpdatePlayerStat(int amount){
                // playerStat += amount;
                // Debug.Log("Current Player Stat = " + playerStat);
        // }

        // public int CheckPlayerStat(){
                // return playerStat;
        // }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}