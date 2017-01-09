/*
 * Created by SharpDevelop.
 * User: Disentine
 * Date: 15.11.2016
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_RESH_L1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(panel1.BackColor == System.Drawing.Color.Red) {
				panel1.BackColor = System.Drawing.Color.Blue;
				button1.Text = "Покрасить панель в красный";
			} else {
				panel1.BackColor = System.Drawing.Color.Red;
				button1.Text = "Покрасить панель в синий";
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(panel1.Visible == true) {
				panel1.Visible = false;
				button2.Text = "Показать панель";
			} else {
				panel1.Visible = true;
				button2.Text = "Скрыть панель";
			}
		}
		void RadioButton1Click(object sender, EventArgs e)
		{
			decimal A = numericUpDown1.Value + numericUpDown2.Value;
			label1.Text = "+";
			textBox1.Text = A.ToString();
		}
		void RadioButton2Click(object sender, EventArgs e)
		{
			decimal A = numericUpDown1.Value - numericUpDown2.Value;
			label1.Text = "-";
			textBox1.Text = A.ToString();
		}
		void RadioButton3Click(object sender, EventArgs e)
		{
			decimal A = numericUpDown1.Value * numericUpDown2.Value;
			label1.Text = "*";
			textBox1.Text = A.ToString();
		}
		void RadioButton4Click(object sender, EventArgs e)
		{
			if(numericUpDown2.Value != 0) {
				decimal A = numericUpDown1.Value / numericUpDown2.Value;
				label1.Text = "/";
				textBox1.Text = A.ToString();
			}
		}
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			progressBar1.Value = trackBar1.Value * 10;
		}
		void CheckBox1Click(object sender, EventArgs e)
		{
			if(groupBox1.Visible == true) {
				groupBox1.Visible = false;
			} else {
				groupBox1.Visible = true;
			}
		}
		void CheckBox2Click(object sender, EventArgs e)
		{
			if(groupBox2.Visible == true) {
				groupBox2.Visible = false;
			} else {
				groupBox2.Visible = true;
			}
		}
		void CheckBox3Click(object sender, EventArgs e)
		{
			if(groupBox3.Visible == true) {
				groupBox3.Visible = false;
			} else {
				groupBox3.Visible = true;
			}
		}
		void CheckBox4Click(object sender, EventArgs e)
		{
			if(button1.Visible == true) {
				button1.Visible = false;
				button2.Visible = false;
			} else {
				button2.Visible = true;
				button1.Visible = true;
			}
		}
	}
}
