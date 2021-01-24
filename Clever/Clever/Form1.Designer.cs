
namespace Clever
{
 partial class Form1
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
   this.button1 = new System.Windows.Forms.Button();
   this.delBTN = new System.Windows.Forms.Button();
   this.button2 = new System.Windows.Forms.Button();
   this.button3 = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // button1
   // 
   this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
   this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
   this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
   this.button1.Location = new System.Drawing.Point(128, -1);
   this.button1.Name = "button1";
   this.button1.Size = new System.Drawing.Size(76, 87);
   this.button1.TabIndex = 1;
   this.button1.UseVisualStyleBackColor = false;
   this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
   // 
   // delBTN
   // 
   this.delBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
   this.delBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
   this.delBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBTN.BackgroundImage")));
   this.delBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
   this.delBTN.Location = new System.Drawing.Point(-4, -1);
   this.delBTN.Name = "delBTN";
   this.delBTN.Size = new System.Drawing.Size(76, 87);
   this.delBTN.TabIndex = 0;
   this.delBTN.UseVisualStyleBackColor = false;
   this.delBTN.Click += new System.EventHandler(this.delBTN_Click);
   this.delBTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.delBTN_MouseDown);
   // 
   // button2
   // 
   this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
   this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
   this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
   this.button2.Location = new System.Drawing.Point(200, -1);
   this.button2.Name = "button2";
   this.button2.Size = new System.Drawing.Size(76, 87);
   this.button2.TabIndex = 2;
   this.button2.UseVisualStyleBackColor = false;
   this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
   // 
   // button3
   // 
   this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
   this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
   this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
   this.button3.Location = new System.Drawing.Point(266, -1);
   this.button3.Name = "button3";
   this.button3.Size = new System.Drawing.Size(76, 87);
   this.button3.TabIndex = 3;
   this.button3.UseVisualStyleBackColor = false;
   this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
   this.CausesValidation = false;
   this.ClientSize = new System.Drawing.Size(341, 81);
   this.ControlBox = false;
   this.Controls.Add(this.button3);
   this.Controls.Add(this.button2);
   this.Controls.Add(this.button1);
   this.Controls.Add(this.delBTN);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
   this.MaximizeBox = false;
   this.MinimizeBox = false;
   this.Name = "Form1";
   this.ShowIcon = false;
   this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
   this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
   this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button delBTN;
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Button button2;
  private System.Windows.Forms.Button button3;
 }
}

