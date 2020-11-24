using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
	SpriteRenderer sprite_renderer;

	public float color = 1.0f;

	public float max_color = 1.0f;
	public float min_color = 0.3f;

	public float time_pi = 0.0f;

	public float oscillation_speed = 9f;

	public static Vector3 default_position = new Vector3(0.0f, 0.0f, 0.0f);

	// On initialize
	void Awake()
	{
		sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	time_pi += Time.deltaTime * oscillation_speed;

    	while(time_pi >= 6.2830f) time_pi -= 6.2830f;

    	if(gameObject.activeInHierarchy)
    	{
    		color = MathExt.SinLim(time_pi, max_color, min_color);

    		sprite_renderer.color = new Color(color, color, color);
    	}    
    }
}
