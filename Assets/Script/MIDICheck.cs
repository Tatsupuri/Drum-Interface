
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MIDICheck : MonoBehaviour
{
    
    [DllImport("__Internal")]
    private static extern bool GetMIDI();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool midi = GetMIDI();
        this.GetComponent<Text>().text  = midi.ToString();
    }
    
}
