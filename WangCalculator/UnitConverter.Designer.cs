namespace WangCalculator
{
    partial class UnitConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConverter));
            this.unitType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.unitIn = new System.Windows.Forms.ComboBox();
            this.unitIn_value = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.unitOut = new System.Windows.Forms.ComboBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.result_value = new System.Windows.Forms.TextBox();
            this.button_keyboard = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.calculateLight = new System.Windows.Forms.PictureBox();
            this.keyboardLight = new System.Windows.Forms.PictureBox();
            this.calculateBacklight = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // unitType
            // 
            this.unitType.BackColor = System.Drawing.SystemColors.InfoText;
            this.unitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitType.ForeColor = System.Drawing.SystemColors.Info;
            this.unitType.FormattingEnabled = true;
            this.unitType.Items.AddRange(new object[] {
            "<Select>",
            "Weight",
            "Time",
            "Length",
            "Angle",
            "Power",
            "Volume",
            "Area",
            "Speed",
            "Temperature"});
            this.unitType.Location = new System.Drawing.Point(150, 157);
            this.unitType.Name = "unitType";
            this.unitType.Size = new System.Drawing.Size(318, 39);
            this.unitType.TabIndex = 0;
            this.unitType.SelectedIndexChanged += new System.EventHandler(this.unitType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 75);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // unitIn
            // 
            this.unitIn.BackColor = System.Drawing.SystemColors.InfoText;
            this.unitIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitIn.Enabled = false;
            this.unitIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitIn.ForeColor = System.Drawing.SystemColors.Info;
            this.unitIn.FormattingEnabled = true;
            this.unitIn.Location = new System.Drawing.Point(150, 323);
            this.unitIn.Name = "unitIn";
            this.unitIn.Size = new System.Drawing.Size(318, 39);
            this.unitIn.TabIndex = 3;
            // 
            // unitIn_value
            // 
            this.unitIn_value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.unitIn_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.unitIn_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unitIn_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitIn_value.ForeColor = System.Drawing.SystemColors.Desktop;
            this.unitIn_value.Location = new System.Drawing.Point(150, 659);
            this.unitIn_value.Multiline = true;
            this.unitIn_value.Name = "unitIn_value";
            this.unitIn_value.ReadOnly = true;
            this.unitIn_value.Size = new System.Drawing.Size(318, 37);
            this.unitIn_value.TabIndex = 4;
            this.unitIn_value.Text = "0";
            this.unitIn_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(104, 570);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 75);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(104, 401);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 75);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // unitOut
            // 
            this.unitOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.unitOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOut.Enabled = false;
            this.unitOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unitOut.ForeColor = System.Drawing.SystemColors.Info;
            this.unitOut.FormattingEnabled = true;
            this.unitOut.Location = new System.Drawing.Point(150, 489);
            this.unitOut.Name = "unitOut";
            this.unitOut.Size = new System.Drawing.Size(318, 39);
            this.unitOut.TabIndex = 7;
            // 
            // button_calculate
            // 
            this.button_calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_calculate.BackgroundImage")));
            this.button_calculate.Enabled = false;
            this.button_calculate.Location = new System.Drawing.Point(765, 718);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(283, 75);
            this.button_calculate.TabIndex = 11;
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(104, 743);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(400, 75);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // result_value
            // 
            this.result_value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.result_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.result_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result_value.ForeColor = System.Drawing.SystemColors.Desktop;
            this.result_value.Location = new System.Drawing.Point(150, 833);
            this.result_value.Multiline = true;
            this.result_value.Name = "result_value";
            this.result_value.ReadOnly = true;
            this.result_value.Size = new System.Drawing.Size(318, 37);
            this.result_value.TabIndex = 13;
            this.result_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_keyboard
            // 
            this.button_keyboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_keyboard.BackgroundImage")));
            this.button_keyboard.Location = new System.Drawing.Point(260, 907);
            this.button_keyboard.Name = "button_keyboard";
            this.button_keyboard.Size = new System.Drawing.Size(100, 75);
            this.button_keyboard.TabIndex = 22;
            this.button_keyboard.UseVisualStyleBackColor = true;
            this.button_keyboard.Click += new System.EventHandler(this.button_keyboard_Click);
            // 
            // button_9
            // 
            this.button_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_9.BackgroundImage")));
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_9.ForeColor = System.Drawing.Color.Transparent;
            this.button_9.Location = new System.Drawing.Point(964, 248);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(100, 75);
            this.button_9.TabIndex = 34;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_8
            // 
            this.button_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_8.BackgroundImage")));
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_8.ForeColor = System.Drawing.Color.Transparent;
            this.button_8.Location = new System.Drawing.Point(858, 248);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(100, 75);
            this.button_8.TabIndex = 33;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_7
            // 
            this.button_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_7.BackgroundImage")));
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_7.ForeColor = System.Drawing.Color.Transparent;
            this.button_7.Location = new System.Drawing.Point(752, 248);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(100, 75);
            this.button_7.TabIndex = 32;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_6
            // 
            this.button_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_6.BackgroundImage")));
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_6.ForeColor = System.Drawing.Color.Transparent;
            this.button_6.Location = new System.Drawing.Point(964, 329);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(100, 75);
            this.button_6.TabIndex = 31;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_5
            // 
            this.button_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_5.BackgroundImage")));
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5.ForeColor = System.Drawing.Color.Transparent;
            this.button_5.Location = new System.Drawing.Point(858, 329);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(100, 75);
            this.button_5.TabIndex = 30;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_4
            // 
            this.button_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_4.BackgroundImage")));
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.ForeColor = System.Drawing.Color.Transparent;
            this.button_4.Location = new System.Drawing.Point(752, 329);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(100, 75);
            this.button_4.TabIndex = 29;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_3
            // 
            this.button_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_3.BackgroundImage")));
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.ForeColor = System.Drawing.Color.Transparent;
            this.button_3.Location = new System.Drawing.Point(964, 410);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(100, 75);
            this.button_3.TabIndex = 28;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_2
            // 
            this.button_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_2.BackgroundImage")));
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.ForeColor = System.Drawing.Color.Transparent;
            this.button_2.Location = new System.Drawing.Point(858, 410);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(100, 75);
            this.button_2.TabIndex = 27;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_dot.BackgroundImage")));
            this.button_dot.ForeColor = System.Drawing.Color.Transparent;
            this.button_dot.Location = new System.Drawing.Point(858, 491);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(100, 75);
            this.button_dot.TabIndex = 26;
            this.button_dot.Text = ",";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_0
            // 
            this.button_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_0.BackgroundImage")));
            this.button_0.ForeColor = System.Drawing.Color.Transparent;
            this.button_0.Location = new System.Drawing.Point(752, 491);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(100, 75);
            this.button_0.TabIndex = 25;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_1
            // 
            this.button_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_1.BackgroundImage")));
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.ForeColor = System.Drawing.Color.Transparent;
            this.button_1.Location = new System.Drawing.Point(752, 410);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(100, 75);
            this.button_1.TabIndex = 24;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_backspace.BackgroundImage")));
            this.button_backspace.Location = new System.Drawing.Point(964, 491);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(100, 75);
            this.button_backspace.TabIndex = 35;
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_reset.BackgroundImage")));
            this.button_reset.Location = new System.Drawing.Point(752, 570);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(312, 75);
            this.button_reset.TabIndex = 37;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // calculateLight
            // 
            this.calculateLight.BackColor = System.Drawing.Color.Red;
            this.calculateLight.Location = new System.Drawing.Point(760, 713);
            this.calculateLight.Name = "calculateLight";
            this.calculateLight.Size = new System.Drawing.Size(293, 85);
            this.calculateLight.TabIndex = 71;
            this.calculateLight.TabStop = false;
            // 
            // keyboardLight
            // 
            this.keyboardLight.BackColor = System.Drawing.Color.Green;
            this.keyboardLight.Location = new System.Drawing.Point(255, 902);
            this.keyboardLight.Name = "keyboardLight";
            this.keyboardLight.Size = new System.Drawing.Size(110, 85);
            this.keyboardLight.TabIndex = 72;
            this.keyboardLight.TabStop = false;
            // 
            // calculateBacklight
            // 
            this.calculateBacklight.Enabled = true;
            this.calculateBacklight.Tick += new System.EventHandler(this.calculateBacklight_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(143, 316);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(334, 53);
            this.pictureBox6.TabIndex = 73;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(143, 150);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(334, 53);
            this.pictureBox7.TabIndex = 74;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(143, 482);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(334, 53);
            this.pictureBox8.TabIndex = 75;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(143, 651);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(334, 53);
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(143, 824);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(334, 53);
            this.pictureBox10.TabIndex = 77;
            this.pictureBox10.TabStop = false;
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 1021);
            this.Controls.Add(this.unitIn_value);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button_keyboard);
            this.Controls.Add(this.keyboardLight);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.calculateLight);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.result_value);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.unitOut);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.unitIn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.unitType);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnitConverter";
            this.Text = "Unit Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculateLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox unitType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox unitIn;
        private System.Windows.Forms.TextBox unitIn_value;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox unitOut;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox result_value;
        private System.Windows.Forms.Button button_keyboard;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.PictureBox calculateLight;
        private System.Windows.Forms.PictureBox keyboardLight;
        private System.Windows.Forms.Timer calculateBacklight;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}