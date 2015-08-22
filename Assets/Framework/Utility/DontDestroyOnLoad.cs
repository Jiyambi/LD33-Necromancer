﻿// ************************************************************************ 
// File Name:   DontDestroyOnLoad.cs 
// Purpose:    	
// Project:		Framework
// Author:      Sarah Herzog  
// Copyright: 	2014 Bounder Games
// ************************************************************************ 


// ************************************************************************ 
// Imports 
// ************************************************************************ 
using UnityEngine;


// ************************************************************************ 
// Attributes 
// ************************************************************************ 


// ************************************************************************ 
// Class: DontDestroyOnLoad
// ************************************************************************ 
public class DontDestroyOnLoad : MonoBehaviour {
	
	
    // ********************************************************************
	// Function:	Awake()
	// Purpose:		Run when new instance of the object is created.
    // ********************************************************************
	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

}