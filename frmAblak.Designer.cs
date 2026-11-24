namespace WF_Events_FormEsemenyek
{
  partial class frmAblak
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
      this.tbEsemények = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // tbEsemények
      // 
      this.tbEsemények.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbEsemények.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbEsemények.Location = new System.Drawing.Point(0, 0);
      this.tbEsemények.Multiline = true;
      this.tbEsemények.Name = "tbEsemények";
      this.tbEsemények.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbEsemények.Size = new System.Drawing.Size(656, 479);
      this.tbEsemények.TabIndex = 0;
      // 
      // frmAblak
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 479);
      this.Controls.Add(this.tbEsemények);
      this.Name = "frmAblak";
      this.Text = "Form események";
      this.Activated += new System.EventHandler(this.frmAblak_Activated);
      this.Deactivate += new System.EventHandler(this.frmAblak_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAblak_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAblak_FormClosed);
      this.Load += new System.EventHandler(this.frmAblak_Load);
      this.SizeChanged += new System.EventHandler(this.frmAblak_SizeChanged);
      this.Click += new System.EventHandler(this.frmAblak_Click);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbEsemények;
  }
}

