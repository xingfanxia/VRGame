using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Health : MonoBehaviour {
	public int inthealth;
    public int curhealth;
    public Text gameOver;
    public int bleed;
    public int curtime = 0;
	// Use this for initialization
	void Start () {
        inthealth = 100;
	    curhealth = inthealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (curhealth <= 0) {
  
            SceneManager.LoadScene("End");
        }
        bleed = (int)(Time.time);
        if (bleed - curtime == 2){
            curhealth -= 1;
            curtime = bleed;
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.StartsWith("Zombie") && curhealth > 0)
        {
            
            curhealth = curhealth - 15;
            if (curhealth < 0) {
                curhealth = 0;
            }
			print(curhealth);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
        }

		if (col.gameObject.name.StartsWith("HPPack") && curhealth > 0)
		{ 
			curhealth = curhealth + 50;
			print(curhealth);
			Destroy (col.gameObject);
		}


    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        print(Time.time);
    }



}
