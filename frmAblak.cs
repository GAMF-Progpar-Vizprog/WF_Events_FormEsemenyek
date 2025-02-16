using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormEsemenyek
{
  public partial class frmAblak : Form
  {
    public frmAblak()
    {
      InitializeComponent();
    }

    private void frmAblak_Activated(object sender, EventArgs e)
    {
      tbEsemények.Text += "Activated\r\n";
    }

    private void frmAblak_Deactivate(object sender, EventArgs e)
    {
      tbEsemények.Text += "Deactivate\r\n";
    }

    private void frmAblak_Load(object sender, EventArgs e)
    {
      tbEsemények.Text += "Load\r\n";
    }

    private void frmAblak_Click(object sender, EventArgs e)
    {
      tbEsemények.Text += "Click\r\n";
    }

    private void frmAblak_SizeChanged(object sender, EventArgs e)
    {
      tbEsemények.Text += "SizeChanged\r\n";
    }

    

    private void frmAblak_FormClosing(object sender, FormClosingEventArgs e)
    {
      tbEsemények.Text += "FormClosing\r\n";
      if(MessageBox.Show("FormClosing","Message",MessageBoxButtons.OKCancel)==DialogResult.Cancel)
				e.Cancel=true;
    }

    private void frmAblak_FormClosed(object sender, FormClosedEventArgs e)
    {
      tbEsemények.Text += "FormClosed\r\n";
      MessageBox.Show("FormClosed");
    }

    
  }
}
