
namespace SESIA2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edIsmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSkidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proisvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skidkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoSkladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isobroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лист1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekzamen2DataSet = new SESIA2.ekzamen2DataSet();
            this.лист1_TableAdapter = new SESIA2.ekzamen2DataSetTableAdapters.Лист1_TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ekzamen2DataSet1 = new SESIA2.ekzamen2DataSet1();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogTableAdapter = new SESIA2.ekzamen2DataSet1TableAdapters.catalogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лист1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamen2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamen2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.edIsmerDataGridViewTextBoxColumn,
            this.stoimDataGridViewTextBoxColumn,
            this.maxSkidkaDataGridViewTextBoxColumn,
            this.proisvodDataGridViewTextBoxColumn,
            this.postavDataGridViewTextBoxColumn,
            this.katTovarDataGridViewTextBoxColumn,
            this.skidkaDataGridViewTextBoxColumn,
            this.kolvoSkladDataGridViewTextBoxColumn,
            this.opisanDataGridViewTextBoxColumn,
            this.isobroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // artikDataGridViewTextBoxColumn
            // 
            this.artikDataGridViewTextBoxColumn.DataPropertyName = "Artik";
            this.artikDataGridViewTextBoxColumn.HeaderText = "Artik";
            this.artikDataGridViewTextBoxColumn.Name = "artikDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // edIsmerDataGridViewTextBoxColumn
            // 
            this.edIsmerDataGridViewTextBoxColumn.DataPropertyName = "ed ismer";
            this.edIsmerDataGridViewTextBoxColumn.HeaderText = "ed ismer";
            this.edIsmerDataGridViewTextBoxColumn.Name = "edIsmerDataGridViewTextBoxColumn";
            // 
            // stoimDataGridViewTextBoxColumn
            // 
            this.stoimDataGridViewTextBoxColumn.DataPropertyName = "Stoim";
            this.stoimDataGridViewTextBoxColumn.HeaderText = "Stoim";
            this.stoimDataGridViewTextBoxColumn.Name = "stoimDataGridViewTextBoxColumn";
            // 
            // maxSkidkaDataGridViewTextBoxColumn
            // 
            this.maxSkidkaDataGridViewTextBoxColumn.DataPropertyName = "max skidka";
            this.maxSkidkaDataGridViewTextBoxColumn.HeaderText = "max skidka";
            this.maxSkidkaDataGridViewTextBoxColumn.Name = "maxSkidkaDataGridViewTextBoxColumn";
            // 
            // proisvodDataGridViewTextBoxColumn
            // 
            this.proisvodDataGridViewTextBoxColumn.DataPropertyName = "Proisvod";
            this.proisvodDataGridViewTextBoxColumn.HeaderText = "Proisvod";
            this.proisvodDataGridViewTextBoxColumn.Name = "proisvodDataGridViewTextBoxColumn";
            // 
            // postavDataGridViewTextBoxColumn
            // 
            this.postavDataGridViewTextBoxColumn.DataPropertyName = "postav";
            this.postavDataGridViewTextBoxColumn.HeaderText = "postav";
            this.postavDataGridViewTextBoxColumn.Name = "postavDataGridViewTextBoxColumn";
            // 
            // katTovarDataGridViewTextBoxColumn
            // 
            this.katTovarDataGridViewTextBoxColumn.DataPropertyName = "kat tovar";
            this.katTovarDataGridViewTextBoxColumn.HeaderText = "kat tovar";
            this.katTovarDataGridViewTextBoxColumn.Name = "katTovarDataGridViewTextBoxColumn";
            // 
            // skidkaDataGridViewTextBoxColumn
            // 
            this.skidkaDataGridViewTextBoxColumn.DataPropertyName = "skidka";
            this.skidkaDataGridViewTextBoxColumn.HeaderText = "skidka";
            this.skidkaDataGridViewTextBoxColumn.Name = "skidkaDataGridViewTextBoxColumn";
            // 
            // kolvoSkladDataGridViewTextBoxColumn
            // 
            this.kolvoSkladDataGridViewTextBoxColumn.DataPropertyName = "kol-vo sklad";
            this.kolvoSkladDataGridViewTextBoxColumn.HeaderText = "kol-vo sklad";
            this.kolvoSkladDataGridViewTextBoxColumn.Name = "kolvoSkladDataGridViewTextBoxColumn";
            // 
            // opisanDataGridViewTextBoxColumn
            // 
            this.opisanDataGridViewTextBoxColumn.DataPropertyName = "Opisan";
            this.opisanDataGridViewTextBoxColumn.HeaderText = "Opisan";
            this.opisanDataGridViewTextBoxColumn.Name = "opisanDataGridViewTextBoxColumn";
            // 
            // isobroDataGridViewTextBoxColumn
            // 
            this.isobroDataGridViewTextBoxColumn.DataPropertyName = "isobro";
            this.isobroDataGridViewTextBoxColumn.HeaderText = "isobro";
            this.isobroDataGridViewTextBoxColumn.Name = "isobroDataGridViewTextBoxColumn";
            // 
            // лист1BindingSource
            // 
            this.лист1BindingSource.DataMember = "Лист1$";
            this.лист1BindingSource.DataSource = this.ekzamen2DataSet;
            // 
            // ekzamen2DataSet
            // 
            this.ekzamen2DataSet.DataSetName = "ekzamen2DataSet";
            this.ekzamen2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лист1_TableAdapter
            // 
            this.лист1_TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(351, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по названию ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск по артикулу ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск по цене";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(207, 440);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(506, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сортировка цены по возрастанию";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(506, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сортировка цены по убыванию";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "СОРТИРОВКА";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(864, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "СОРТИРОВКА";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(637, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "СБРОС";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(448, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 42);
            this.button5.TabIndex = 14;
            this.button5.Text = "Товар в наличии ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ekzamen2DataSet1
            // 
            this.ekzamen2DataSet1.DataSetName = "ekzamen2DataSet1";
            this.ekzamen2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catalogBindingSource
            // 
            this.catalogBindingSource.DataMember = "catalog";
            this.catalogBindingSource.DataSource = this.ekzamen2DataSet1;
            // 
            // catalogTableAdapter
            // 
            this.catalogTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 537);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лист1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamen2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekzamen2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ekzamen2DataSet ekzamen2DataSet;
        private System.Windows.Forms.BindingSource лист1BindingSource;
        private ekzamen2DataSetTableAdapters.Лист1_TableAdapter лист1_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edIsmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSkidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proisvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skidkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoSkladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isobroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ekzamen2DataSet1 ekzamen2DataSet1;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private ekzamen2DataSet1TableAdapters.catalogTableAdapter catalogTableAdapter;
    }
}