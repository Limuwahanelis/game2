﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InteractableTorch2 : MonoBehaviour,IInteractable
{
    private Light mainLight;
    public GameObject fire;
    //private GameManager gameMan;
    public GameObject canvas;
    public LogicPuzzle2 puzzle;
    private bool fireActive = false;
    public int value;
    private PlayerInteract _playerInteract;
    // Start is called before the first frame update
    void Awake()
    {
        mainLight = transform.GetComponentInChildren<Light>();
    }
    void Start()
    {
        
        //gameMan = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        //light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        mainLight.enabled = !mainLight.enabled;
        fireActive = !fireActive;
        fire.SetActive(fireActive);
        puzzle.UpdateNumber(fireActive, value);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            canvas.SetActive(true);
        _playerInteract = collision.GetComponentInParent<PlayerInteract>();
        _playerInteract.setObjectToInteract(this);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            canvas.SetActive(false);
        _playerInteract = collision.GetComponentInParent<PlayerInteract>();
        _playerInteract.setObjectToInteract(null);
    }
    public void LightUp()
    {
        Debug.Log("lightup");
        fire.SetActive(true);
        //mainLight.enabled = true;
        
    }
}
