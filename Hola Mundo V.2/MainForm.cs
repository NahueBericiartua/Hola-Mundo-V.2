/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hola_Mundo_V._
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
		void Btn_okClick(object sender, EventArgs e)
		{
			if(rbtn_azul.Checked == true){
				lbl_mostrar.ForeColor = Color.Blue;
			}else if(rbtn_rojo.Checked == true){
				lbl_mostrar.ForeColor = Color.Red;
			} else if(rbtn_verde.Checked == true){
				lbl_mostrar.ForeColor = Color.Green;
			}
			
			lbl_mostrar.Text = "Hola "+txt_nombre.Text;
			
			}
		}
}
