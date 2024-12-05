using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all : MonoBehaviour
{    
    public GameObject mouth;
    public GameObject mouth1;
    public GameObject sqmouth;
    public GameObject rightEye;
    public GameObject sqRightEye;
    public GameObject leftEye;
    public GameObject sqLeftEye;
    public GameObject O;
    public float x;

    public void Mouth(bool mouth,bool mouth1,bool sqmouth){
            this.mouth.SetActive(mouth); 
            this.mouth1.SetActive(mouth1);
            this.sqmouth.SetActive(sqmouth);
    } 
    // public void Mouth1(bool active){
    //         mouth1.SetActive(active); 
    // } 
    public void Eye(bool active1, bool active2){
            rightEye.SetActive(active1); 
            leftEye.SetActive(active1);
            sqRightEye.SetActive(active2);
            sqLeftEye.SetActive(active2);
    }

    void Start()
    {
        Mouth(false,false,true);
        // Mouth1(false);
        Eye(false,true);
        x=rightEye.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        float ynew=Mathf.Sin(Time.time)+2f;
        O.transform.position=new Vector3(O.transform.position.x,ynew*4f,O.transform.position.z);
         
/////up arrow          
        if(Input.GetKeyDown(KeyCode.UpArrow)){            
            O.SetActive(false);          
            Eye(true,false);
            Mouth(true,false,false);

            leftEye.transform.localScale=new Vector3(1.834754f,1,1.088467f);   

            rightEye.transform.localScale=new Vector3(1.834754f,1,1.088467f);
            

        }
 /////rigth arrow      
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            O.SetActive(false);
            Mouth(false,true,false);
            Eye(true,false);

            mouth1.transform.rotation=Quaternion.Euler (Vector3.zero);
            leftEye.transform.localScale=new Vector3(1.8f,1f,2.25f);
            rightEye.transform.localScale=new Vector3(1.8f,1f,2.25f);
        }
/////left arrow       
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            O.SetActive(false);
            Mouth(false,true,false);
            leftEye.transform.localScale=new Vector3(1.8f,1f,2.25f);
            rightEye.transform.localScale=new Vector3(1.8f,1f,2.25f);
            mouth1.transform.rotation=Quaternion.Euler (new Vector3(180,0,0));
        }
/////down arrow
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            O.SetActive(true);          
            Eye(false,true);
            Mouth(false,false,true);
        }
        }

    }

