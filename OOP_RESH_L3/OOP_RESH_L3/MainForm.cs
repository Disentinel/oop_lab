/*
 * Created by SharpDevelop.
 * User: Disentine
 * Date: 09.01.2017
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_RESH_L3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	///
	public struct Coord {
		public Int32 X;
		public Int32 Y;
	}
		
	public class CanvasObject : Object
	{
		private Int32 SizeX;
		private Int32 SizeY;
		private Coord Coordinates; //Я подозреваю что рисовать будем от центра
		private int Angles;
		
		public Coord GetSize() 
		{
			Coord Size;
			Size.X = SizeX;
			Size.Y = SizeY;
			return Size;
		}
		
		public void SetSize(Int32 Width, Int32 Height) 
		{
			SizeX = Width;
			SizeY = Height;
		}
	}
	
	
	
	
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
		void TopToolStripPanelClick(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		object CreateNewCanvas(int32 sizeX, int32 sizeY) { //Создаём холст указанного размера, отрисовываем.
			object Canvas = new System.Drawing.Bitmap(sizeX, sizeY);
			
			
			
			return Canvas;
		}
	}
}
