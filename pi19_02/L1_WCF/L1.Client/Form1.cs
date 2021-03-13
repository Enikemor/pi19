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
using WindowsFormsApp1.ServiceReference1;

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
            string sUrlService = "http://127.0.0.1:8000/Service1";
            BasicHttpContextBinding pBinding = new BasicHttpContextBinding(); 
            EndpointAddress pEndpointAddress = new EndpointAddress(sUrlService); 
            EncyclopediaServiceClient pClient = new EncyclopediaServiceClient(pBinding, pEndpointAddress); 
            pClient.GetArticle("001","0001");
        }
    }
}
