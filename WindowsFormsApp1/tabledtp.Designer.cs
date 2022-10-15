namespace WindowsFormsApp1
{
    partial class tabledtp
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.гбддDataSet = new WindowsFormsApp1.гбддDataSet();
            this.дтпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дтпTableAdapter = new WindowsFormsApp1.гбддDataSetTableAdapters.дтпTableAdapter();
            this.классификацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПроишествияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.другиеОбъектыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЖертвDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гбддDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дтпBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(688, 544);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 58);
            this.button3.TabIndex = 87;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(745, -194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 28);
            this.button2.TabIndex = 86;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(905, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 28);
            this.button1.TabIndex = 88;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.классификацияDataGridViewTextBoxColumn,
            this.фиоDataGridViewTextBoxColumn,
            this.вуDataGridViewTextBoxColumn,
            this.местоПроишествияDataGridViewTextBoxColumn,
            this.номераDataGridViewTextBoxColumn,
            this.другиеОбъектыDataGridViewTextBoxColumn,
            this.колвоЖертвDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дтпBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 435);
            this.dataGridView1.TabIndex = 89;
            // 
            // гбддDataSet
            // 
            this.гбддDataSet.DataSetName = "гбддDataSet";
            this.гбддDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дтпBindingSource
            // 
            this.дтпBindingSource.DataMember = "дтп";
            this.дтпBindingSource.DataSource = this.гбддDataSet;
            // 
            // дтпTableAdapter
            // 
            this.дтпTableAdapter.ClearBeforeFill = true;
            // 
            // классификацияDataGridViewTextBoxColumn
            // 
            this.классификацияDataGridViewTextBoxColumn.DataPropertyName = "классификация";
            this.классификацияDataGridViewTextBoxColumn.HeaderText = "классификация";
            this.классификацияDataGridViewTextBoxColumn.Name = "классификацияDataGridViewTextBoxColumn";
            // 
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "фио";
            this.фиоDataGridViewTextBoxColumn.HeaderText = "фио";
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            // 
            // вуDataGridViewTextBoxColumn
            // 
            this.вуDataGridViewTextBoxColumn.DataPropertyName = "ву";
            this.вуDataGridViewTextBoxColumn.HeaderText = "ву";
            this.вуDataGridViewTextBoxColumn.Name = "вуDataGridViewTextBoxColumn";
            // 
            // местоПроишествияDataGridViewTextBoxColumn
            // 
            this.местоПроишествияDataGridViewTextBoxColumn.DataPropertyName = "место проишествия";
            this.местоПроишествияDataGridViewTextBoxColumn.HeaderText = "место проишествия";
            this.местоПроишествияDataGridViewTextBoxColumn.Name = "местоПроишествияDataGridViewTextBoxColumn";
            // 
            // номераDataGridViewTextBoxColumn
            // 
            this.номераDataGridViewTextBoxColumn.DataPropertyName = "номера";
            this.номераDataGridViewTextBoxColumn.HeaderText = "номера";
            this.номераDataGridViewTextBoxColumn.Name = "номераDataGridViewTextBoxColumn";
            // 
            // другиеОбъектыDataGridViewTextBoxColumn
            // 
            this.другиеОбъектыDataGridViewTextBoxColumn.DataPropertyName = "другие объекты";
            this.другиеОбъектыDataGridViewTextBoxColumn.HeaderText = "другие объекты";
            this.другиеОбъектыDataGridViewTextBoxColumn.Name = "другиеОбъектыDataGridViewTextBoxColumn";
            // 
            // колвоЖертвDataGridViewTextBoxColumn
            // 
            this.колвоЖертвDataGridViewTextBoxColumn.DataPropertyName = "кол-во жертв";
            this.колвоЖертвDataGridViewTextBoxColumn.HeaderText = "кол-во жертв";
            this.колвоЖертвDataGridViewTextBoxColumn.Name = "колвоЖертвDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewTextBoxColumn
            // 
            this.фотоDataGridViewTextBoxColumn.DataPropertyName = "фото";
            this.фотоDataGridViewTextBoxColumn.HeaderText = "фото";
            this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
            // 
            // tabledtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabledtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabledtp";
            this.Load += new System.EventHandler(this.tabledtp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гбддDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дтпBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private гбддDataSet гбддDataSet;
        private System.Windows.Forms.BindingSource дтпBindingSource;
        private гбддDataSetTableAdapters.дтпTableAdapter дтпTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn классификацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПроишествияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn другиеОбъектыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЖертвDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
    }
}