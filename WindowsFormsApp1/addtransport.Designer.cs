namespace WindowsFormsApp1
{
    partial class addtransport
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vinname = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.type_of_transport = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.categories = new System.Windows.Forms.ComboBox();
            this.type_of_drive = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.Engine_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(851, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Добавить транспортное средство";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(250, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 53;
            this.label9.Text = "Выберите цвет:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(190, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Введите год выпуска:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(190, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Выберите категорию:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Введите тип транспортного средства:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(237, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Введите модель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Введите марку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Введите VIN номер автомобиля:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(221, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Введите вес (в кг):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(172, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 25);
            this.label12.TabIndex = 57;
            this.label12.Text = "Выберите тип привода:";
            // 
            // vinname
            // 
            this.vinname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vinname.Location = new System.Drawing.Point(424, 111);
            this.vinname.Name = "vinname";
            this.vinname.Size = new System.Drawing.Size(353, 31);
            this.vinname.TabIndex = 58;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manufacturer.Location = new System.Drawing.Point(424, 156);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(353, 31);
            this.Manufacturer.TabIndex = 59;
            // 
            // model
            // 
            this.model.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model.Location = new System.Drawing.Point(424, 204);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(353, 31);
            this.model.TabIndex = 60;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.Location = new System.Drawing.Point(424, 342);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(353, 31);
            this.year.TabIndex = 61;
            // 
            // type_of_transport
            // 
            this.type_of_transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_transport.Location = new System.Drawing.Point(424, 250);
            this.type_of_transport.Name = "type_of_transport";
            this.type_of_transport.Size = new System.Drawing.Size(353, 31);
            this.type_of_transport.TabIndex = 62;
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(424, 441);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(353, 31);
            this.weight.TabIndex = 63;
            // 
            // categories
            // 
            this.categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categories.FormattingEnabled = true;
            this.categories.Items.AddRange(new object[] {
            "M",
            "A",
            "A1",
            "B",
            "BE",
            "B1",
            "C",
            "C1",
            "C1E",
            "CE",
            "D",
            "D1",
            "D1E",
            "DE",
            "Tm",
            "Tb"});
            this.categories.Location = new System.Drawing.Point(424, 294);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(200, 32);
            this.categories.TabIndex = 65;
            // 
            // type_of_drive
            // 
            this.type_of_drive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_drive.FormattingEnabled = true;
            this.type_of_drive.Items.AddRange(new object[] {
            "front-wheel drive",
            "full drive",
            "rear drive"});
            this.type_of_drive.Location = new System.Drawing.Point(424, 493);
            this.type_of_drive.Name = "type_of_drive";
            this.type_of_drive.Size = new System.Drawing.Size(200, 32);
            this.type_of_drive.TabIndex = 66;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(424, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 31);
            this.button4.TabIndex = 67;
            this.button4.Text = "выбрать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(652, 856);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 58);
            this.button3.TabIndex = 69;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(155, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 25);
            this.label10.TabIndex = 70;
            this.label10.Text = "Выберите тип двигателя:";
            // 
            // Engine_type
            // 
            this.Engine_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Engine_type.FormattingEnabled = true;
            this.Engine_type.Items.AddRange(new object[] {
            "Бензиновый",
            "Дизельный",
            "Газовый"});
            this.Engine_type.Location = new System.Drawing.Point(424, 546);
            this.Engine_type.Name = "Engine_type";
            this.Engine_type.Size = new System.Drawing.Size(200, 32);
            this.Engine_type.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(295, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 58);
            this.button1.TabIndex = 72;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(103, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(315, 25);
            this.label11.TabIndex = 73;
            this.label11.Text = "Введите фамилию владельца:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(161, 656);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(257, 25);
            this.label13.TabIndex = 74;
            this.label13.Text = "Введите имя владельца:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(110, 704);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(308, 25);
            this.label14.TabIndex = 75;
            this.label14.Text = "Введите отчество владельца:";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(424, 599);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(353, 31);
            this.surname.TabIndex = 76;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(424, 650);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(353, 31);
            this.name.TabIndex = 77;
            // 
            // middlename
            // 
            this.middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlename.Location = new System.Drawing.Point(424, 698);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(353, 31);
            this.middlename.TabIndex = 78;
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Триумф",
            "Кардинал",
            "Баклажановый",
            "Рубин",
            "Коралл",
            "Кармен",
            "Майя",
            "Вишня",
            "Искра",
            "Виктория",
            "Магия",
            "Аметист",
            "Торнадо",
            "Гранат",
            "Белый",
            "Белый",
            "Жасмин",
            "Айсберг",
            "Примула",
            "Сафари",
            "Миндаль",
            "Нарцисс",
            "Чайная роза",
            "Белый",
            "Бежевый",
            "Серо-бежевый",
            "Золотая нива",
            "Приз",
            "Антилопа Люкс",
            "Мираж",
            "Опатия",
            "Сливочно-белый",
            "Серебристая ива",
            "Моцарт",
            "Зеленый сад",
            "Валюта",
            "Игуана",
            "Оливковый",
            "Оливин",
            "Корсика",
            "Амулет",
            "Серо-зеленая",
            "Мурена",
            "Ниагара",
            "Изумруд",
            "Папирус",
            "Табачный",
            "Монте-Карло",
            "Ирис",
            "Чароит",
            "Электрон",
            "Фея (Лесная фея)",
            "Пицунда",
            "Опал",
            "Балтика",
            "Афалина",
            "Адриатика",
            "Серо-голубой",
            "Медео",
            "Лазурит",
            "Сапфир",
            "Синяя полночь",
            "Рапсодия",
            "Океан",
            "Темно-синий",
            "Мулен-Руж",
            "Аквамарин Люкс",
            "Валентина",
            "Бриз",
            "Голубая",
            "Лагуна",
            "Лазурно-синий",
            "Темно-бежевая",
            "Черный",
            "Авантюрин",
            "Мокрый асфальт",
            "Нептун",
            "Серебристый",
            "Сандаловый",
            "Светло-серый",
            "Снежная королева",
            "Темно-коричневый",
            "Пирано",
            "Корица",
            "Зеленая"});
            this.color.Location = new System.Drawing.Point(577, 389);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(200, 32);
            this.color.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(21, 44);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.Visible = false;
            // 
            // addtransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(906, 960);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.color);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Engine_type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.type_of_drive);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.type_of_transport);
            this.Controls.Add(this.year);
            this.Controls.Add(this.model);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.vinname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addtransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addtransport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox vinname;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox type_of_transport;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.ComboBox type_of_drive;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Engine_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}