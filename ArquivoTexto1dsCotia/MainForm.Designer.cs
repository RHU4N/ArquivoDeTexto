/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 05/11/2021
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ArquivoTexto1dsCotia
{
	partial class MainForm
	{
		
		private System.ComponentModel.IContainer components = null;
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnABRIR = new System.Windows.Forms.Button();
			this.btnLIMPAR = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblRegistrado = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.btnCons = new System.Windows.Forms.Button();
			this.btnADD = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Silver;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(431, 41);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(401, 278);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnSAVE
			// 
			this.btnSAVE.BackColor = System.Drawing.Color.Black;
			this.btnSAVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.Location = new System.Drawing.Point(445, 335);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(95, 40);
			this.btnSAVE.TabIndex = 1;
			this.btnSAVE.Text = "SALVAR";
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnSAVE.Click += new System.EventHandler(this.BtnSAVEClick);
			// 
			// btnABRIR
			// 
			this.btnABRIR.BackColor = System.Drawing.Color.Black;
			this.btnABRIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnABRIR.Location = new System.Drawing.Point(576, 335);
			this.btnABRIR.Name = "btnABRIR";
			this.btnABRIR.Size = new System.Drawing.Size(97, 40);
			this.btnABRIR.TabIndex = 2;
			this.btnABRIR.Text = "ABRIR";
			this.btnABRIR.UseVisualStyleBackColor = false;
			this.btnABRIR.Click += new System.EventHandler(this.BtnABRIRClick);
			// 
			// btnLIMPAR
			// 
			this.btnLIMPAR.BackColor = System.Drawing.Color.Black;
			this.btnLIMPAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLIMPAR.Location = new System.Drawing.Point(713, 335);
			this.btnLIMPAR.Name = "btnLIMPAR";
			this.btnLIMPAR.Size = new System.Drawing.Size(97, 40);
			this.btnLIMPAR.TabIndex = 3;
			this.btnLIMPAR.Text = "LIMPAR";
			this.btnLIMPAR.UseVisualStyleBackColor = false;
			this.btnLIMPAR.Click += new System.EventHandler(this.BtnLIMPARClick);
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(176, 308);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(44, 24);
			this.textBox5.TabIndex = 29;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(76, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 31);
			this.button1.TabIndex = 28;
			this.button1.Text = "Consulta p/ nome";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblRegistrado
			// 
			this.lblRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegistrado.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblRegistrado.Location = new System.Drawing.Point(170, 42);
			this.lblRegistrado.Name = "lblRegistrado";
			this.lblRegistrado.Size = new System.Drawing.Size(100, 23);
			this.lblRegistrado.TabIndex = 27;
			this.lblRegistrado.Text = "1";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(84, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "Registrado:";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(209, 262);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(119, 24);
			this.textBox4.TabIndex = 25;
			// 
			// btnCons
			// 
			this.btnCons.BackColor = System.Drawing.Color.Black;
			this.btnCons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCons.Location = new System.Drawing.Point(76, 301);
			this.btnCons.Name = "btnCons";
			this.btnCons.Size = new System.Drawing.Size(94, 31);
			this.btnCons.TabIndex = 24;
			this.btnCons.Text = "Consulta por Nº:";
			this.btnCons.UseVisualStyleBackColor = false;
			this.btnCons.Click += new System.EventHandler(this.BtnConsClick);
			// 
			// btnADD
			// 
			this.btnADD.BackColor = System.Drawing.Color.Black;
			this.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.Location = new System.Drawing.Point(239, 194);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(53, 43);
			this.btnADD.TabIndex = 23;
			this.btnADD.Text = "ADD>>";
			this.btnADD.UseVisualStyleBackColor = false;
			this.btnADD.Click += new System.EventHandler(this.BtnADDClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(99, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "Telefone:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(99, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "Endereço:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(99, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nome:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(99, 202);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(119, 24);
			this.textBox3.TabIndex = 19;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(99, 149);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(229, 24);
			this.textBox2.TabIndex = 18;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(99, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(229, 24);
			this.textBox1.TabIndex = 17;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(864, 432);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblRegistrado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.btnCons);
			this.Controls.Add(this.btnADD);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnLIMPAR);
			this.Controls.Add(this.btnABRIR);
			this.Controls.Add(this.btnSAVE);
			this.Controls.Add(this.richTextBox1);
			this.Name = "MainForm";
			this.Text = "ArquivoTexto1dsCotia";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnCons;
		private System.Windows.Forms.Button btnADD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnLIMPAR;
		private System.Windows.Forms.Button btnABRIR;
		private System.Windows.Forms.Button btnSAVE;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblRegistrado;
	}
}
