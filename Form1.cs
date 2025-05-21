using System;
using System.Windows.Forms;

namespace NerdbankWinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelVersion.Text = $"Version: {ThisAssembly.AssemblyInformationalVersion}";
        }
    }
}