
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace Grading_System
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox15 = new System.Windows.Forms.TextBox();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label10 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.FRST = new System.Windows.Forms.Button();
            this.NXT = new System.Windows.Forms.Button();
            this.LAST = new System.Windows.Forms.Button();
            this.PREV = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.STUDID = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Red;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Blue;
            this.Button1.Location = new System.Drawing.Point(1183, 125);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(178, 128);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "C&ompute";
            this.ToolTip1.SetToolTip(this.Button1, "COMPUTE GRADES\r\n    Automatically compute all the \r\ngrades of specefic students.");
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label1.Location = new System.Drawing.Point(25, 111);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Firstname:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(102, 108);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 20);
            this.TextBox1.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label2.Location = new System.Drawing.Point(259, 110);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Lastname:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(337, 107);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(155, 20);
            this.TextBox2.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBox5);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(13, 139);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(228, 51);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Attendance       20          EG         10%";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label3.Location = new System.Drawing.Point(14, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 15);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Score:";
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox5.Location = new System.Drawing.Point(168, 19);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(46, 21);
            this.TextBox5.TabIndex = 12;
            // 
            // TextBox4
            // 
            this.TextBox4.AcceptsTab = true;
            this.TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox4.Location = new System.Drawing.Point(116, 19);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(46, 21);
            this.TextBox4.TabIndex = 11;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(64, 19);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(46, 21);
            this.TextBox3.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.TextBox9);
            this.GroupBox3.Controls.Add(this.TextBox11);
            this.GroupBox3.Controls.Add(this.TextBox10);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(12, 259);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(228, 72);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Practical Quiz       50        EG        20%";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label5.Location = new System.Drawing.Point(12, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 15);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Score:";
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(66, 19);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(46, 21);
            this.TextBox9.TabIndex = 5;
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox11.Location = new System.Drawing.Point(170, 19);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.ReadOnly = true;
            this.TextBox11.Size = new System.Drawing.Size(46, 21);
            this.TextBox11.TabIndex = 19;
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox10.Location = new System.Drawing.Point(118, 19);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.Size = new System.Drawing.Size(46, 21);
            this.TextBox10.TabIndex = 20;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.TextBox12);
            this.GroupBox4.Controls.Add(this.TextBox14);
            this.GroupBox4.Controls.Add(this.TextBox13);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(266, 139);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(228, 51);
            this.GroupBox4.TabIndex = 8;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Project         100           EG          30%";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label6.Location = new System.Drawing.Point(15, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 15);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Score:";
            // 
            // TextBox12
            // 
            this.TextBox12.Location = new System.Drawing.Point(65, 19);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(46, 21);
            this.TextBox12.TabIndex = 6;
            // 
            // TextBox14
            // 
            this.TextBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox14.Location = new System.Drawing.Point(169, 19);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.ReadOnly = true;
            this.TextBox14.Size = new System.Drawing.Size(46, 21);
            this.TextBox14.TabIndex = 24;
            // 
            // TextBox13
            // 
            this.TextBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox13.Location = new System.Drawing.Point(117, 19);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.ReadOnly = true;
            this.TextBox13.Size = new System.Drawing.Size(46, 21);
            this.TextBox13.TabIndex = 23;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Label7);
            this.GroupBox5.Controls.Add(this.TextBox15);
            this.GroupBox5.Controls.Add(this.TextBox17);
            this.GroupBox5.Controls.Add(this.TextBox16);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(266, 196);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(228, 57);
            this.GroupBox5.TabIndex = 8;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Prelim Exam      100       EG      30%";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label7.Location = new System.Drawing.Point(15, 22);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 15);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Score:";
            // 
            // TextBox15
            // 
            this.TextBox15.Location = new System.Drawing.Point(65, 19);
            this.TextBox15.Name = "TextBox15";
            this.TextBox15.Size = new System.Drawing.Size(46, 21);
            this.TextBox15.TabIndex = 7;
            // 
            // TextBox17
            // 
            this.TextBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox17.Location = new System.Drawing.Point(174, 19);
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.ReadOnly = true;
            this.TextBox17.Size = new System.Drawing.Size(46, 21);
            this.TextBox17.TabIndex = 27;
            // 
            // TextBox16
            // 
            this.TextBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox16.Location = new System.Drawing.Point(119, 19);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.ReadOnly = true;
            this.TextBox16.Size = new System.Drawing.Size(46, 21);
            this.TextBox16.TabIndex = 28;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.TextBox18);
            this.GroupBox6.Controls.Add(this.Label9);
            this.GroupBox6.Controls.Add(this.TextBox19);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(262, 259);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(228, 75);
            this.GroupBox6.TabIndex = 9;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "FINAL MARK COMPUTED";
            this.GroupBox6.Enter += new System.EventHandler(this.GroupBox6_Enter);
            // 
            // TextBox18
            // 
            this.TextBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox18.Location = new System.Drawing.Point(19, 41);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.ReadOnly = true;
            this.TextBox18.Size = new System.Drawing.Size(87, 24);
            this.TextBox18.TabIndex = 29;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label9.Location = new System.Drawing.Point(116, 22);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(68, 15);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Remarks:";
            // 
            // TextBox19
            // 
            this.TextBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox19.Location = new System.Drawing.Point(119, 41);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.ReadOnly = true;
            this.TextBox19.Size = new System.Drawing.Size(98, 24);
            this.TextBox19.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label8.Location = new System.Drawing.Point(16, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(79, 15);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Final Mark:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.TextBox8);
            this.GroupBox2.Controls.Add(this.TextBox6);
            this.GroupBox2.Controls.Add(this.TextBox7);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(13, 196);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(228, 57);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Writtten Quiz       50        EG          10%";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label4.Location = new System.Drawing.Point(14, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 15);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Score:";
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox8.Location = new System.Drawing.Point(168, 19);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.ReadOnly = true;
            this.TextBox8.Size = new System.Drawing.Size(46, 21);
            this.TextBox8.TabIndex = 13;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(64, 19);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(46, 21);
            this.TextBox6.TabIndex = 4;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox7.Location = new System.Drawing.Point(116, 19);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = true;
            this.TextBox7.Size = new System.Drawing.Size(46, 21);
            this.TextBox7.TabIndex = 15;
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(531, 120);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView1.RowHeadersWidth = 15;
            this.DataGridView1.Size = new System.Drawing.Size(559, 211);
            this.DataGridView1.TabIndex = 10;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(528, 99);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 18);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Results";
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button3.Location = new System.Drawing.Point(1096, 72);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(265, 54);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "&Clear All";
            this.ToolTip1.SetToolTip(this.Button3, "CLEAR ALL\r\nAllows you to erase all the current details \r\nthat can be found in all" +
        " textbox.");
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Aqua;
            this.Label11.Font = new System.Drawing.Font("MS PGothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Label11.Location = new System.Drawing.Point(410, 8);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(549, 40);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "Grading System For Lecturers\r\n";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1364, 59);
            this.Panel1.TabIndex = 14;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button4.Location = new System.Drawing.Point(1096, 125);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(89, 128);
            this.Button4.TabIndex = 15;
            this.Button4.Text = "Save";
            this.ToolTip1.SetToolTip(this.Button4, "SAVE RECORD\r\n    It allow\'s the user to save the new record.");
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button5.Location = new System.Drawing.Point(1096, 253);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(107, 72);
            this.Button5.TabIndex = 16;
            this.Button5.Text = "&Load Students";
            this.ToolTip1.SetToolTip(this.Button5, "LOAD STUDENTS\r\n    It loads all the student information in the datagridview.\r\nAnd" +
        " the user\'s are allow to view specefic student\'s data by\r\ndouble clicking the ce" +
        "lls.");
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Gray;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button6.Location = new System.Drawing.Point(1200, 253);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(161, 73);
            this.Button6.TabIndex = 17;
            this.Button6.Text = "Show Details";
            this.ToolTip1.SetToolTip(this.Button6, "SHOW DETAILS\r\n     Let\'s you to view the current detail of the specefic \r\nstudent" +
        " you selected in the datagridview.");
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // FRST
            // 
            this.FRST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FRST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FRST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FRST.Location = new System.Drawing.Point(680, 344);
            this.FRST.Name = "FRST";
            this.FRST.Size = new System.Drawing.Size(72, 54);
            this.FRST.TabIndex = 18;
            this.FRST.Text = "First";
            this.ToolTip1.SetToolTip(this.FRST, "FIRST RECORD");
            this.FRST.UseVisualStyleBackColor = false;
            this.FRST.Click += new System.EventHandler(this.FRST_Click);
            // 
            // NXT
            // 
            this.NXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NXT.Location = new System.Drawing.Point(845, 344);
            this.NXT.Name = "NXT";
            this.NXT.Size = new System.Drawing.Size(95, 54);
            this.NXT.TabIndex = 19;
            this.NXT.Text = "Next";
            this.ToolTip1.SetToolTip(this.NXT, "NEXT");
            this.NXT.UseVisualStyleBackColor = false;
            this.NXT.Click += new System.EventHandler(this.NXT_Click);
            // 
            // LAST
            // 
            this.LAST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LAST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LAST.Location = new System.Drawing.Point(946, 344);
            this.LAST.Name = "LAST";
            this.LAST.Size = new System.Drawing.Size(76, 54);
            this.LAST.TabIndex = 20;
            this.LAST.Text = "Last";
            this.ToolTip1.SetToolTip(this.LAST, "LAST RECORD");
            this.LAST.UseVisualStyleBackColor = false;
            this.LAST.Click += new System.EventHandler(this.LAST_Click);
            // 
            // PREV
            // 
            this.PREV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PREV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PREV.Location = new System.Drawing.Point(758, 344);
            this.PREV.Name = "PREV";
            this.PREV.Size = new System.Drawing.Size(81, 54);
            this.PREV.TabIndex = 21;
            this.PREV.Text = "Previous";
            this.ToolTip1.SetToolTip(this.PREV, "PREVIOUS");
            this.PREV.UseVisualStyleBackColor = false;
            this.PREV.Click += new System.EventHandler(this.PREV_Click);
            // 
            // Button11
            // 
            this.Button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button11.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.ForeColor = System.Drawing.Color.Yellow;
            this.Button11.Location = new System.Drawing.Point(55, 353);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(185, 125);
            this.Button11.TabIndex = 22;
            this.Button11.Text = "Delete";
            this.ToolTip1.SetToolTip(this.Button11, "DELETE RECORD\r\n     It delete the any unnecessary record.");
            this.Button11.UseVisualStyleBackColor = false;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button7.Location = new System.Drawing.Point(1096, 322);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(265, 55);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "Update";
            this.ToolTip1.SetToolTip(this.Button7, "UPDATE RECORD\r\n     It allows you to upadate any changes\r\nyou made to the current" +
        " record.");
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // STUDID
            // 
            this.STUDID.Location = new System.Drawing.Point(102, 82);
            this.STUDID.Name = "STUDID";
            this.STUDID.Size = new System.Drawing.Size(144, 20);
            this.STUDID.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(16, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Student ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1364, 642);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.STUDID);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.PREV);
            this.Controls.Add(this.LAST);
            this.Controls.Add(this.NXT);
            this.Controls.Add(this.FRST);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grading System";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox19;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button FRST;
		internal System.Windows.Forms.Button NXT;
		internal System.Windows.Forms.Button LAST;
		internal System.Windows.Forms.Button PREV;
		internal System.Windows.Forms.Button Button11;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox STUDID;
		internal System.Windows.Forms.ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;
        internal Label label13;
    }
	
}
