/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hola_Mundo_V._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton rbtn_verde;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lbl_mostrar;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.RadioButton rbtn_azul;
		private System.Windows.Forms.RadioButton rbtn_rojo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.rbtn_verde = new System.Windows.Forms.RadioButton();
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_mostrar = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.rbtn_azul = new System.Windows.Forms.RadioButton();
			this.rbtn_rojo = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// rbtn_verde
			// 
			this.rbtn_verde.Location = new System.Drawing.Point(3, 76);
			this.rbtn_verde.Name = "rbtn_verde";
			this.rbtn_verde.Size = new System.Drawing.Size(123, 30);
			this.rbtn_verde.TabIndex = 0;
			this.rbtn_verde.TabStop = true;
			this.rbtn_verde.Text = "Verde";
			this.rbtn_verde.UseVisualStyleBackColor = true;
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(186, 86);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(86, 98);
			this.btn_ok.TabIndex = 1;
			this.btn_ok.Text = "button1";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_okClick);
			// 
			// lbl_mostrar
			// 
			this.lbl_mostrar.ForeColor = System.Drawing.Color.Black;
			this.lbl_mostrar.Location = new System.Drawing.Point(12, 203);
			this.lbl_mostrar.Name = "lbl_mostrar";
			this.lbl_mostrar.Size = new System.Drawing.Size(260, 49);
			this.lbl_mostrar.TabIndex = 2;
			this.lbl_mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(12, 40);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(260, 20);
			this.txt_nombre.TabIndex = 3;
			// 
			// rbtn_azul
			// 
			this.rbtn_azul.Location = new System.Drawing.Point(3, 112);
			this.rbtn_azul.Name = "rbtn_azul";
			this.rbtn_azul.Size = new System.Drawing.Size(123, 34);
			this.rbtn_azul.TabIndex = 4;
			this.rbtn_azul.TabStop = true;
			this.rbtn_azul.Text = "Azul";
			this.rbtn_azul.UseVisualStyleBackColor = true;
			// 
			// rbtn_rojo
			// 
			this.rbtn_rojo.Location = new System.Drawing.Point(3, 152);
			this.rbtn_rojo.Name = "rbtn_rojo";
			this.rbtn_rojo.Size = new System.Drawing.Size(123, 32);
			this.rbtn_rojo.TabIndex = 5;
			this.rbtn_rojo.TabStop = true;
			this.rbtn_rojo.Text = "Rojo";
			this.rbtn_rojo.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.rbtn_rojo);
			this.Controls.Add(this.rbtn_azul);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.lbl_mostrar);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.rbtn_verde);
			this.Name = "MainForm";
			this.Text = "Hola Mundo V.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
