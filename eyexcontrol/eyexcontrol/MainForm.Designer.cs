/*
 * Created by SharpDevelop.
 * User: thomaamz
 * Date: 24/05/2016
 * Time: 09:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace eyexcontrol
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.onoff = new System.Windows.Forms.Button();
      this.notify = new System.Windows.Forms.NotifyIcon(this.components);
      this.notifymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.aboutme = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitme = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.notifymenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // onoff
      // 
      this.onoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.onoff.Location = new System.Drawing.Point(12, 39);
      this.onoff.Name = "onoff";
      this.onoff.Size = new System.Drawing.Size(166, 48);
      this.onoff.TabIndex = 0;
      this.onoff.Text = "Turn on";
      this.onoff.UseVisualStyleBackColor = true;
      this.onoff.Click += new System.EventHandler(this.OnoffClick);
      // 
      // notify
      // 
      this.notify.ContextMenuStrip = this.notifymenu;
      this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
      this.notify.Text = "Eye mouse control";
      this.notify.Visible = true;
      this.notify.DoubleClick += new System.EventHandler(this.NotifyDoubleClick);
      // 
      // notifymenu
      // 
      this.notifymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                  this.aboutme,
                  this.toolStripSeparator1,
                  this.exitme});
      this.notifymenu.Name = "notifymenu";
      this.notifymenu.Size = new System.Drawing.Size(117, 54);
      // 
      // aboutme
      // 
      this.aboutme.Name = "aboutme";
      this.aboutme.Size = new System.Drawing.Size(116, 22);
      this.aboutme.Text = "About...";
      this.aboutme.Click += new System.EventHandler(this.AboutmeClick);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
      // 
      // exitme
      // 
      this.exitme.Name = "exitme";
      this.exitme.Size = new System.Drawing.Size(116, 22);
      this.exitme.Text = "Exit";
      this.exitme.Click += new System.EventHandler(this.ExitmeClick);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(18, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(159, 22);
      this.label1.TabIndex = 1;
      this.label1.Text = "Eye mouse control";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(190, 92);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.onoff);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Eye mouse";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.Shown += new System.EventHandler(this.MainFormShown);
      this.Resize += new System.EventHandler(this.MainFormResize);
      this.notifymenu.ResumeLayout(false);
      this.ResumeLayout(false);
    }
    private System.Windows.Forms.ToolStripMenuItem exitme;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem aboutme;
    private System.Windows.Forms.ContextMenuStrip notifymenu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NotifyIcon notify;
    private System.Windows.Forms.Button onoff;
  }
}
