using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Falys.BrowserLinkLib;
using Microsoft.AspNet.SignalR.Infrastructure;
using System.Runtime.Remoting.Contexts;

namespace Sample
{
	public partial class Form1 : Form
	{
		private BrowserLink _browserLink;
			
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var proc = Process.Start("http://localhost:8080/");
			// proc.
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_browserLink = new BrowserLink();
			_browserLink.Start();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			_browserLink.Dispose();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_browserLink.Send(textBox1.Text);
		}

	}
}
