
namespace AniMate
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progRTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rTKDataSet = new AniMate.RTKDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProgramNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTokToTableProgRTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progRTKTableAdapter = new AniMate.RTKDataSetTableAdapters.ProgRTKTableAdapter();
            this.tokTableAdapter = new AniMate.RTKDataSetTableAdapters.TokTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progRTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTokToTableProgRTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.progDataGridViewTextBoxColumn,
            this.x1DataGridViewTextBoxColumn,
            this.x2DataGridViewTextBoxColumn,
            this.x3DataGridViewTextBoxColumn,
            this.x4DataGridViewTextBoxColumn,
            this.y1DataGridViewTextBoxColumn,
            this.y2DataGridViewTextBoxColumn,
            this.y3DataGridViewTextBoxColumn,
            this.y4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.progRTKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(420, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // progDataGridViewTextBoxColumn
            // 
            this.progDataGridViewTextBoxColumn.DataPropertyName = "Prog";
            this.progDataGridViewTextBoxColumn.HeaderText = "№ программы";
            this.progDataGridViewTextBoxColumn.Name = "progDataGridViewTextBoxColumn";
            this.progDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // x1DataGridViewTextBoxColumn
            // 
            this.x1DataGridViewTextBoxColumn.DataPropertyName = "X1";
            this.x1DataGridViewTextBoxColumn.HeaderText = "X1";
            this.x1DataGridViewTextBoxColumn.Name = "x1DataGridViewTextBoxColumn";
            this.x1DataGridViewTextBoxColumn.ReadOnly = true;
            this.x1DataGridViewTextBoxColumn.Width = 30;
            // 
            // x2DataGridViewTextBoxColumn
            // 
            this.x2DataGridViewTextBoxColumn.DataPropertyName = "X2";
            this.x2DataGridViewTextBoxColumn.HeaderText = "X2";
            this.x2DataGridViewTextBoxColumn.Name = "x2DataGridViewTextBoxColumn";
            this.x2DataGridViewTextBoxColumn.ReadOnly = true;
            this.x2DataGridViewTextBoxColumn.Width = 30;
            // 
            // x3DataGridViewTextBoxColumn
            // 
            this.x3DataGridViewTextBoxColumn.DataPropertyName = "X3";
            this.x3DataGridViewTextBoxColumn.HeaderText = "X3";
            this.x3DataGridViewTextBoxColumn.Name = "x3DataGridViewTextBoxColumn";
            this.x3DataGridViewTextBoxColumn.ReadOnly = true;
            this.x3DataGridViewTextBoxColumn.Width = 30;
            // 
            // x4DataGridViewTextBoxColumn
            // 
            this.x4DataGridViewTextBoxColumn.DataPropertyName = "X4";
            this.x4DataGridViewTextBoxColumn.HeaderText = "X4";
            this.x4DataGridViewTextBoxColumn.Name = "x4DataGridViewTextBoxColumn";
            this.x4DataGridViewTextBoxColumn.ReadOnly = true;
            this.x4DataGridViewTextBoxColumn.Width = 30;
            // 
            // y1DataGridViewTextBoxColumn
            // 
            this.y1DataGridViewTextBoxColumn.DataPropertyName = "Y1";
            this.y1DataGridViewTextBoxColumn.HeaderText = "Y1";
            this.y1DataGridViewTextBoxColumn.Name = "y1DataGridViewTextBoxColumn";
            this.y1DataGridViewTextBoxColumn.ReadOnly = true;
            this.y1DataGridViewTextBoxColumn.Width = 30;
            // 
            // y2DataGridViewTextBoxColumn
            // 
            this.y2DataGridViewTextBoxColumn.DataPropertyName = "Y2";
            this.y2DataGridViewTextBoxColumn.HeaderText = "Y2";
            this.y2DataGridViewTextBoxColumn.Name = "y2DataGridViewTextBoxColumn";
            this.y2DataGridViewTextBoxColumn.ReadOnly = true;
            this.y2DataGridViewTextBoxColumn.Width = 30;
            // 
            // y3DataGridViewTextBoxColumn
            // 
            this.y3DataGridViewTextBoxColumn.DataPropertyName = "Y3";
            this.y3DataGridViewTextBoxColumn.HeaderText = "Y3";
            this.y3DataGridViewTextBoxColumn.Name = "y3DataGridViewTextBoxColumn";
            this.y3DataGridViewTextBoxColumn.ReadOnly = true;
            this.y3DataGridViewTextBoxColumn.Width = 30;
            // 
            // y4DataGridViewTextBoxColumn
            // 
            this.y4DataGridViewTextBoxColumn.DataPropertyName = "Y4";
            this.y4DataGridViewTextBoxColumn.HeaderText = "Y4";
            this.y4DataGridViewTextBoxColumn.Name = "y4DataGridViewTextBoxColumn";
            this.y4DataGridViewTextBoxColumn.ReadOnly = true;
            this.y4DataGridViewTextBoxColumn.Width = 30;
            // 
            // progRTKBindingSource
            // 
            this.progRTKBindingSource.DataMember = "ProgRTK";
            this.progRTKBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rTKDataSet;
            this.bindingSource1.Position = 0;
            // 
            // rTKDataSet
            // 
            this.rTKDataSet.DataSetName = "RTKDataSet";
            this.rTKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramNom,
            this.silaDataGridViewTextBoxColumn,
            this.primDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKTokToTableProgRTKBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(436, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(371, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // ProgramNom
            // 
            this.ProgramNom.DataPropertyName = "ProgramNom";
            this.ProgramNom.HeaderText = "Id программы";
            this.ProgramNom.Name = "ProgramNom";
            this.ProgramNom.ReadOnly = true;
            this.ProgramNom.ToolTipText = "Id программы с координатами";
            this.ProgramNom.Width = 70;
            // 
            // silaDataGridViewTextBoxColumn
            // 
            this.silaDataGridViewTextBoxColumn.DataPropertyName = "Sila";
            this.silaDataGridViewTextBoxColumn.HeaderText = "Сила тока";
            this.silaDataGridViewTextBoxColumn.Name = "silaDataGridViewTextBoxColumn";
            this.silaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primDataGridViewTextBoxColumn
            // 
            this.primDataGridViewTextBoxColumn.DataPropertyName = "Prim";
            this.primDataGridViewTextBoxColumn.FillWeight = 150F;
            this.primDataGridViewTextBoxColumn.HeaderText = "Газовый флюс";
            this.primDataGridViewTextBoxColumn.Name = "primDataGridViewTextBoxColumn";
            this.primDataGridViewTextBoxColumn.ReadOnly = true;
            this.primDataGridViewTextBoxColumn.Width = 150;
            // 
            // fKTokToTableProgRTKBindingSource
            // 
            this.fKTokToTableProgRTKBindingSource.DataMember = "FK_Tok_ToTableProgRTK";
            this.fKTokToTableProgRTKBindingSource.DataSource = this.progRTKBindingSource;
            // 
            // tokBindingSource
            // 
            this.tokBindingSource.DataMember = "Tok";
            this.tokBindingSource.DataSource = this.bindingSource1;
            // 
            // progRTKTableAdapter
            // 
            this.progRTKTableAdapter.ClearBeforeFill = true;
            // 
            // tokTableAdapter
            // 
            this.tokTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(12, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(413, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "База данных программ  с координатами точек сварки";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(438, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(369, 33);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Связанная база данных  (параметры силы тока и параметров флюса)";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.Location = new System.Drawing.Point(567, 235);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(123, 46);
            this.bClose.TabIndex = 25;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 396);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр баз данных (связь через внешний ключ)";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progRTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTokToTableProgRTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RTKDataSet rTKDataSet;
        private System.Windows.Forms.BindingSource progRTKBindingSource;
        private RTKDataSetTableAdapters.ProgRTKTableAdapter progRTKTableAdapter;
        private System.Windows.Forms.BindingSource tokBindingSource;
        private RTKDataSetTableAdapters.TokTableAdapter tokTableAdapter;
        private System.Windows.Forms.BindingSource fKTokToTableProgRTKBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn silaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bClose;
    }
}