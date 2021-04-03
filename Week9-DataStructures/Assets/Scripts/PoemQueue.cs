using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PoemQueue : MonoBehaviour
{
    //create queue for poetry lines
    private Queue<string> lineQueue = new Queue<string>();
    
        //grab canvas text
        public Text display;
    
        //create 3 second timer for when poetry lines can be entered
        private float timer = 0;
        private float targetTime = 5;
        
        private void Update()
        {
            // press space to reload scene and start over 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
            // if targetTime is reached, continue
            if (timer > targetTime) return;
            
            // increase timer with game-time
            timer += Time.deltaTime;
    
            // if letter is pressed, enqueue letter-specific line
            if (Input.GetKeyDown(KeyCode.A))
            {
                lineQueue.Enqueue("Now a rope around her neck pleads, come home come home.");
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                lineQueue.Enqueue("We have never wanted anything but this.");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                lineQueue.Enqueue("We are approaching the vast pines and power plants, the place the snow begins to darken red.");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                lineQueue.Enqueue("One time she said the body of a plane was like the belly of a horse.");
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                lineQueue.Enqueue("And you are such a pretty girl.");
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                lineQueue.Enqueue("My mother is about to born, her mother wants her out.");
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                lineQueue.Enqueue("It is a sight I will not soon forget: my love weeping inconsolably, bent double under stars.");
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                lineQueue.Enqueue("Mercy.");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                lineQueue.Enqueue("We want the fucking to start.");
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                lineQueue.Enqueue("Keep quiet is a muscle. Keep quiet is a city with all the swing gone out of its hips.");
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                lineQueue.Enqueue("When I was small no one stopped the fights. A man could beat you till you died.");
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                lineQueue.Enqueue("I was never sorry.");
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                lineQueue.Enqueue("I let the town drift from view, my mother still humming.");
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                lineQueue.Enqueue("O if this were the worst of it.");
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                lineQueue.Enqueue("The others nestled together like eggs.");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                lineQueue.Enqueue("There are so many kinds of darkness.");
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                lineQueue.Enqueue("But America is like that, you get what you ask for in the ring or on the kitchen floor.");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                lineQueue.Enqueue("What was it they wanted that I wanted too?");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                lineQueue.Enqueue("Her mouth find's the woman's, and we are all moaning in the pasture."); 
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                lineQueue.Enqueue("She won't believe that woman's dead. She says, I think it's romantic to disappear.");
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                lineQueue.Enqueue("How do you tell your children they'll never get away?");
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                lineQueue.Enqueue("I'll have to walk.");
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                lineQueue.Enqueue("What if the door had been locked and they couldn't get in and find us or what if they found us?");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                lineQueue.Enqueue("I am everything now.");
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                lineQueue.Enqueue("O dark barns who will move me now?");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                lineQueue.Enqueue("It isn't how we look up close, so much as in dreams.");
            } 
            
            // if time runs out, change display text and run ShowQueuePoem function
            if (timer >= targetTime)
            {
                display.text = "Your poem: \n";
    
                ShowQueuePoem();
            }
            else
            {
                // otherwise, display shorter version of countdown
                display.text = "Use A-Z to write your own poem. Timer: " + 
                               (targetTime - timer).ToString("F1");
            }
        }
    
        //function to display dequeued lines when timer runs out
        private void ShowQueuePoem()
        {
            while (lineQueue.Count > 0)
                display.text += "\n" + lineQueue.Dequeue();
        }
}