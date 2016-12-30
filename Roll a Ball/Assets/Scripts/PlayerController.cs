using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Called before rendering a frame
	void Update(){}

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	//Counts each pickup
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
	}

    //Called before just performing any physics calculations
    void FixedUpdate()
    {
		//Use Ctrl + ' To get documentation
		//Gets axis from input
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
    }

	//When collision occurs
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 10)
		{
			winText.text = "You Win";
		}
	}
}
