using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;
    public Animator animator;
    public ScoreTextController score;
    public TimerController time;
    Animation ani;
    

	public void OnCollisionEnter2D(Collision2D collision)
	{
        Destroy(collision.gameObject);

        if (collision.gameObject.tag == "coke")
		{
            
            animator.Play("shut");
            
            
		}
		else
		{

            if (collision.gameObject.tag == "spicySauce")
			{
                animator.Play("spicyEat");
                

			}
			else
			{
                //AnimationState state = ani["spicyEat"];
                AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
                if (state.IsName("spicyEat"))
				{
                    if (state.normalizedTime >= 1.0f)
					{
                        
                        animator.Play("eat");
                        animator.Play("open");
                    }
                    
                }
                else if (state.IsName("coffeeEat"))
				{
                    if (state.normalizedTime >= 1.0f)
                    {

                        animator.Play("eat");
                        animator.Play("open");
                    }
                }
                else
				{
                    
                    animator.Play("eat");
                    animator.Play("open");
                }
				
                if (collision.gameObject.tag == "coffee")
                {
                    animator.Play("coffeeEat");

                }

                else if (collision.gameObject.tag == "twice")
                {
                    if (state.IsName("coffeeEat"))
					{
                        score.AddScoreAndDisplay(20);
                    }
					else
					{
                        score.AddScoreAndDisplay(10);
                    }
                    
                }

                else if (collision.gameObject.tag == "once")
                {
                    if (state.IsName("coffeeEat"))
                    {
                        score.AddScoreAndDisplay(40);
                    }
                    else
                    {
                        score.AddScoreAndDisplay(20);
                    }

                    
                }
            }

            
            
        }
        
        
	}
	// Start is called before the first frame update
	void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
            if (this.transform.position.x < 23)
			{
                this.transform.position += new Vector3(speed*Time.deltaTime*50, 0, 0);
            }
            
		}
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
            if (this.transform.position.x > -23)
			{
                this.transform.position += new Vector3(-speed*Time.deltaTime*50, 0, 0);
            }
			
		}

        
    }
}
