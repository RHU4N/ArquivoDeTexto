/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 05/11/2021
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArquivoTexto1dsCotia
{
	
	public partial class MainForm : Form
	{

		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void BtnSAVEClick(object sender, EventArgs e)
		{
			//SALVAR
			richTextBox1.SaveFile("agenda.txt", RichTextBoxStreamType.PlainText);
			MessageBox.Show("Arquivo salvo com sucesso");
			
		}
		
		void BtnABRIRClick(object sender, EventArgs e)
		{
			//ABRIR
			richTextBox1.LoadFile("agenda.txt",RichTextBoxStreamType.PlainText);
		}
		
		void BtnLIMPARClick(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		
		void Limpar(){
			lblRegistrado.Text = richTextBox1.Lines.Length.ToString();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox1.Focus();
		}
		void BtnADDClick(object sender, EventArgs e)
		{
			richTextBox1.Text += textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\n";
			richTextBox1.SaveFile("agenda.txt",RichTextBoxStreamType.PlainText);
			
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			lblRegistrado.Text = richTextBox1.Lines.Length.ToString();
			
			MessageBox.Show("Arquivo salvo com sucesso");
			
			textBox1.Focus();
		} 
		
		void BtnConsClick(object sender, EventArgs e)
		{
			int nLinha = int.Parse(textBox5.Text) - 1;
			string linhaInteira = richTextBox1.Lines[nLinha];
			string[] dados = linhaInteira.Split('\t');
			
			textBox1.Text = dados[0];
			textBox2.Text = dados[1];
			textBox3.Text = dados[2];
			lblRegistrado.Text = textBox5.Text;
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				richTextBox1.LoadFile("agenda.txt",RichTextBoxStreamType.PlainText);
				lblRegistrado.Text=richTextBox1.Lines.Length.ToString();
			}
			catch
			{
				
			}
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			string nome = textBox4.Text;
			int cont=0;
			bool achou = false;
			
			foreach (string linhaInteira in richTextBox1.Lines){
				string[] dados = linhaInteira .Split('\t');
				cont++;
				if (dados[0] == nome){
					achou = true;
					lblRegistrado.Text = cont.ToString();
					textBox1.Text = dados[0];
					textBox2.Text = dados[1];
					textBox3.Text = dados[2];
				}
			}
			
			if (achou == false){
				Limpar();
				MessageBox.Show("Nome não cadastrado","AVISO");
			}
		}
	}
}
