using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace AniMate
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbY3 = new System.Windows.Forms.TextBox();
            this.tbX3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbY4 = new System.Windows.Forms.TextBox();
            this.tbX4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNomProg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.dgvDataBase = new System.Windows.Forms.DataGridView();
            this.dgvADB = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADB)).BeginInit();
            this.SuspendLayout();
            // 
            // tbX1
            // 
            this.tbX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbX1.Location = new System.Drawing.Point(28, 20);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(39, 20);
            this.tbX1.TabIndex = 0;
            this.tbX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // tbY1
            // 
            this.tbY1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbY1.Location = new System.Drawing.Point(28, 41);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(39, 20);
            this.tbY1.TabIndex = 3;
            this.tbY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bSave.Location = new System.Drawing.Point(377, 45);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(113, 69);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Сохранить для старта операции и закрыть настройки";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            this.bSave.MouseHover += new System.EventHandler(this.bSave_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbY1);
            this.groupBox2.Controls.Add(this.tbX1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(82, 79);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Точка №1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbY2);
            this.groupBox3.Controls.Add(this.tbX2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(105, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 79);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Точка №2";
            // 
            // tbY2
            // 
            this.tbY2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbY2.Location = new System.Drawing.Point(28, 41);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(39, 20);
            this.tbY2.TabIndex = 3;
            this.tbY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbX2
            // 
            this.tbX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbX2.Location = new System.Drawing.Point(28, 20);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(39, 20);
            this.tbX2.TabIndex = 0;
            this.tbX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbY3);
            this.groupBox4.Controls.Add(this.tbX3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(194, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(82, 79);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Точка №3";
            // 
            // tbY3
            // 
            this.tbY3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbY3.Location = new System.Drawing.Point(28, 41);
            this.tbY3.Name = "tbY3";
            this.tbY3.Size = new System.Drawing.Size(39, 20);
            this.tbY3.TabIndex = 3;
            this.tbY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbX3
            // 
            this.tbX3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbX3.Location = new System.Drawing.Point(28, 20);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(39, 20);
            this.tbX3.TabIndex = 0;
            this.tbX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Y:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbY4);
            this.groupBox5.Controls.Add(this.tbX4);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(284, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(82, 79);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Точка №4";
            // 
            // tbY4
            // 
            this.tbY4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbY4.Location = new System.Drawing.Point(28, 41);
            this.tbY4.Name = "tbY4";
            this.tbY4.Size = new System.Drawing.Size(39, 20);
            this.tbY4.TabIndex = 3;
            this.tbY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbX4
            // 
            this.tbX4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbX4.Location = new System.Drawing.Point(28, 20);
            this.tbX4.Name = "tbX4";
            this.tbX4.Size = new System.Drawing.Size(39, 20);
            this.tbX4.TabIndex = 0;
            this.tbX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(171, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Координаты точек в пределах:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(364, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "X (8 - 105); Y (22 - 50)";
            // 
            // tbNomProg
            // 
            this.tbNomProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNomProg.ForeColor = System.Drawing.Color.Black;
            this.tbNomProg.Location = new System.Drawing.Point(120, 6);
            this.tbNomProg.Name = "tbNomProg";
            this.tbNomProg.ReadOnly = true;
            this.tbNomProg.Size = new System.Drawing.Size(39, 23);
            this.tbNomProg.TabIndex = 4;
            this.tbNomProg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "№ программы:";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bAdd.Location = new System.Drawing.Point(346, 514);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(144, 44);
            this.bAdd.TabIndex = 16;
            this.bAdd.Text = "Добавить координаты в БД (новая программа)";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDel.Location = new System.Drawing.Point(15, 513);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(144, 44);
            this.bDel.TabIndex = 17;
            this.bDel.Text = "Удалить текущую строку БД";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 565);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Статус: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(14, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(413, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "База данных программ  с координатами точек сварки";
            // 
            // bChange
            // 
            this.bChange.BackColor = System.Drawing.Color.Yellow;
            this.bChange.Location = new System.Drawing.Point(182, 514);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(144, 44);
            this.bChange.TabIndex = 17;
            this.bChange.Text = "Изменить координаты в текущей строке БД";
            this.bChange.UseVisualStyleBackColor = false;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // dgvDataBase
            // 
            this.dgvDataBase.AllowUserToAddRows = false;
            this.dgvDataBase.AllowUserToDeleteRows = false;
            this.dgvDataBase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBase.Location = new System.Drawing.Point(12, 147);
            this.dgvDataBase.Name = "dgvDataBase";
            this.dgvDataBase.Size = new System.Drawing.Size(486, 239);
            this.dgvDataBase.TabIndex = 19;
            this.dgvDataBase.CurrentCellChanged += new System.EventHandler(this.dgvDataBase_CurrentCellChanged_1);
            // 
            // dgvADB
            // 
            this.dgvADB.AllowUserToAddRows = false;
            this.dgvADB.AllowUserToDeleteRows = false;
            this.dgvADB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvADB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvADB.Location = new System.Drawing.Point(12, 424);
            this.dgvADB.Name = "dgvADB";
            this.dgvADB.Size = new System.Drawing.Size(486, 72);
            this.dgvADB.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(12, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(463, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Связанная база данных  (параметры силы тока и давления аргона)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 581);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvADB);
            this.Controls.Add(this.dgvDataBase);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomProg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bSave);
            this.MaximumSize = new System.Drawing.Size(526, 620);
            this.MinimumSize = new System.Drawing.Size(526, 620);
            this.Name = "Form2";
            this.Text = "Настройки координат точек сварки и сохранение в базе данных";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX1;
        private Label label1;
        private Label label2;
        private TextBox tbY1;
        private Button bSave;
        private GroupBox groupBox2;
        private ToolTip toolTip1;
        private GroupBox groupBox3;
        private TextBox tbY2;
        private TextBox tbX2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox4;
        private TextBox tbY3;
        private TextBox tbX3;
        private Label label6;
        private Label label7;
        private GroupBox groupBox5;
        private TextBox tbY4;
        private TextBox tbX4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbNomProg;
        private Label label3;
        private Button bAdd;
        private Button bDel;
        private Label label12;
        private Label label13;
        private Button bChange;
        private DataGridView dgvDataBase;
        private DataGridView dgvADB;
        private Label label14;
    }
}