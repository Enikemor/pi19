using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUrlService = textBox1.Text;
            BasicHttpContextBinding pBinding = new BasicHttpContextBinding(); 
            EndpointAddress pEndpointAddress = new EndpointAddress(sUrlService); 
            Service1Client pClient = new Service1Client(pBinding, pEndpointAddress); 
            //MessageBox.Show(pClient.GetData(1));
        }
    }
}
