using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace eyexcontrol
{

  public partial class MainForm : Form
  {

    Process eyemouse;
    SpeechSynthesizer voice;
    bool eyemouseon=false,hidden=true;

    public MainForm()
    {
      InitializeComponent();
    }
    
    void MainFormLoad(object sender,EventArgs e)
    {
      voice=new SpeechSynthesizer();
    }

    void MainFormShown(object sender, EventArgs e)
    {
      this.Left=Screen.PrimaryScreen.WorkingArea.Width-190;
      this.Top=Screen.PrimaryScreen.WorkingArea.Bottom-92;
      this.WindowState=FormWindowState.Minimized;
      Hide();
    }

    void MainFormFormClosing(object sender,FormClosingEventArgs e)
    {
      if(eyemouseon==true) stopeyemouse();
    }

    void MainFormResize(object sender,EventArgs e)
    {
      if(FormWindowState.Minimized==WindowState) Hide();
    }

    void OnoffClick(object sender,EventArgs e)
    {
      if(eyemouseon==false) starteyemouse();
      else stopeyemouse();
    }

    private void starteyemouse()
    {
      if(eyemouseon==false)
      {
        eyemouse=new Process();
        eyemouse.StartInfo.FileName=AppDomain.CurrentDomain.BaseDirectory+"EyeXMouse.exe";
        eyemouse.StartInfo.Arguments="";
        eyemouse.StartInfo.UseShellExecute=false;
        eyemouse.Start();
        eyemouseon=true;
        speak("Eye mouse started");
        onoff.Text="Turn off";
      }
    }
    
    private void stopeyemouse()
    {
      if(eyemouseon==true)
      {
        eyemouse.Kill();
        eyemouseon=false;
        speak("Eye mouse stopped");
        onoff.Text="Turn on";
      }
    }

    void speak(String txt)
    {
      voice.SpeakAsyncCancelAll();
      voice.Volume=100;
      voice.SpeakAsync(txt);
    }

    void AboutmeClick(object sender, EventArgs e)
    {
      MessageBox.Show("EyeXMouse on/off controller. Produced by the Digital Humanities Hub at the University of Birmingham, UK, 2016. Programming by Dr Andrew Thomas.");
    }
    
    void ExitmeClick(object sender, EventArgs e)
    {
      Application.Exit();
    }

    void NotifyDoubleClick(object sender, EventArgs e)
    {
      if(hidden==true)
      {
        hidden=false;
        this.Left=Screen.PrimaryScreen.WorkingArea.Right-190;
        this.Top=Screen.PrimaryScreen.WorkingArea.Bottom-92;
        Show();
        WindowState=FormWindowState.Normal;
      }
      else
      {
        hidden=true;
        Hide();
      }
    }
    
  }
}
