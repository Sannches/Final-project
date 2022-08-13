
namespace AniMate
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSettings = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.LB3 = new System.Windows.Forms.Label();
            this.LB4 = new System.Windows.Forms.Label();
            this.Box_WeldingTable = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_FIO = new System.Windows.Forms.Label();
            this.bShowProg = new System.Windows.Forms.Button();
            this.Box_WeldingTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Text = "Hello World (:";
            this.notifyIcon.Visible = true;
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Brown;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.White;
            this.bStart.Location = new System.Drawing.Point(265, 177);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(114, 52);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Старт операции";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(271, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(271, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(271, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "...";
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.Transparent;
            this.bSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSettings.ForeColor = System.Drawing.Color.YellowGreen;
            this.bSettings.Location = new System.Drawing.Point(17, 382);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(114, 38);
            this.bSettings.TabIndex = 9;
            this.bSettings.Text = "Настройки";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.BackColor = System.Drawing.Color.Transparent;
            this.LB1.ForeColor = System.Drawing.Color.White;
            this.LB1.Location = new System.Drawing.Point(8, 22);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(20, 13);
            this.LB1.TabIndex = 10;
            this.LB1.Text = "Х1";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.BackColor = System.Drawing.Color.Transparent;
            this.LB2.ForeColor = System.Drawing.Color.White;
            this.LB2.Location = new System.Drawing.Point(105, 47);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(20, 13);
            this.LB2.TabIndex = 11;
            this.LB2.Text = "Х2";
            // 
            // LB3
            // 
            this.LB3.AutoSize = true;
            this.LB3.BackColor = System.Drawing.Color.Transparent;
            this.LB3.ForeColor = System.Drawing.Color.White;
            this.LB3.Location = new System.Drawing.Point(37, 47);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(20, 13);
            this.LB3.TabIndex = 12;
            this.LB3.Text = "Х3";
            // 
            // LB4
            // 
            this.LB4.AutoSize = true;
            this.LB4.BackColor = System.Drawing.Color.Transparent;
            this.LB4.ForeColor = System.Drawing.Color.White;
            this.LB4.Location = new System.Drawing.Point(71, 22);
            this.LB4.Name = "LB4";
            this.LB4.Size = new System.Drawing.Size(20, 13);
            this.LB4.TabIndex = 13;
            this.LB4.Text = "Х4";
            // 
            // Box_WeldingTable
            // 
            this.Box_WeldingTable.BackColor = System.Drawing.Color.Transparent;
            this.Box_WeldingTable.Controls.Add(this.LB4);
            this.Box_WeldingTable.Controls.Add(this.LB1);
            this.Box_WeldingTable.Controls.Add(this.LB2);
            this.Box_WeldingTable.Controls.Add(this.LB3);
            this.Box_WeldingTable.ForeColor = System.Drawing.Color.Yellow;
            this.Box_WeldingTable.Location = new System.Drawing.Point(314, 248);
            this.Box_WeldingTable.Name = "Box_WeldingTable";
            this.Box_WeldingTable.Size = new System.Drawing.Size(138, 87);
            this.Box_WeldingTable.TabIndex = 14;
            this.Box_WeldingTable.TabStop = false;
            this.Box_WeldingTable.Text = "Сварочный стол";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.DimGray;
            this.pb1.ForeColor = System.Drawing.Color.Red;
            this.pb1.Location = new System.Drawing.Point(314, 321);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(138, 10);
            this.pb1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "\"FANUC\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Робото-технический сварочный комплекс";
            // 
            // LB_FIO
            // 
            this.LB_FIO.AutoSize = true;
            this.LB_FIO.BackColor = System.Drawing.Color.Transparent;
            this.LB_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_FIO.ForeColor = System.Drawing.Color.White;
            this.LB_FIO.Location = new System.Drawing.Point(12, 54);
            this.LB_FIO.Name = "LB_FIO";
            this.LB_FIO.Size = new System.Drawing.Size(106, 15);
            this.LB_FIO.TabIndex = 19;
            this.LB_FIO.Text = "Оператор АПЛС: ";
            // 
            // bShowProg
            // 
            this.bShowProg.BackColor = System.Drawing.Color.Transparent;
            this.bShowProg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bShowProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowProg.ForeColor = System.Drawing.Color.PeachPuff;
            this.bShowProg.Location = new System.Drawing.Point(17, 338);
            this.bShowProg.Name = "bShowProg";
            this.bShowProg.Size = new System.Drawing.Size(114, 38);
            this.bShowProg.TabIndex = 20;
            this.bShowProg.Text = "Просмотр программ сварки";
            this.bShowProg.UseVisualStyleBackColor = false;
            this.bShowProg.Click += new System.EventHandler(this.bShowProg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AniMate.Properties.Resources.Fanuc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 441);
            this.Controls.Add(this.bShowProg);
            this.Controls.Add(this.LB_FIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.Box_WeldingTable);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStart);
            this.MaximumSize = new System.Drawing.Size(490, 480);
            this.MinimumSize = new System.Drawing.Size(490, 480);
            this.Name = "Form1";
            this.Text = "Симулятор точек сварки на РТК. Автор: Круталевич А.";
            this.Box_WeldingTable.ResumeLayout(false);
            this.Box_WeldingTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Label LB3;
        private System.Windows.Forms.Label LB4;
        private System.Windows.Forms.GroupBox Box_WeldingTable;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_FIO;
        private System.Windows.Forms.Button bShowProg;
    }
}
