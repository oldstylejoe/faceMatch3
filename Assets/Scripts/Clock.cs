﻿using UnityEngine;
using System.Runtime.InteropServices;


public class Clock : MonoBehaviour {

    [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
    public static extern void GetSystemTimePreciseAsFileTime(out long filetime);

    public static void write(string str)
    {
        System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\DataLogs\\unity_flower\\test.txt", true);
        file.WriteLine(str);

        file.Close();
    }

}