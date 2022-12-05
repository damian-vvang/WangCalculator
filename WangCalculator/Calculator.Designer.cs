namespace WangCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lcdResult = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_1_slash_x = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_plus_or_minus = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button_ln = new System.Windows.Forms.Button();
            this.button_x_to_the_power_of_y = new System.Windows.Forms.Button();
            this.button_x_to_the_power_of_3 = new System.Windows.Forms.Button();
            this.button_x_to_the_power_of_2 = new System.Windows.Forms.Button();
            this.button_tan = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_sinh = new System.Windows.Forms.Button();
            this.button_cosh = new System.Windows.Forms.Button();
            this.button_tanh = new System.Windows.Forms.Button();
            this.button_factorial = new System.Windows.Forms.Button();
            this.button_modulo = new System.Windows.Forms.Button();
            this.button_pi = new System.Windows.Forms.Button();
            this.button_x_to_the_power_of_1_slash_y = new System.Windows.Forms.Button();
            this.button_x_to_the_power_of_1_slash_3 = new System.Windows.Forms.Button();
            this.button_Exp = new System.Windows.Forms.Button();
            this.button_OPTN = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_MS = new System.Windows.Forms.Button();
            this.button_mPlus = new System.Windows.Forms.Button();
            this.button_mMinus = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lcdHistory = new System.Windows.Forms.TextBox();
            this.lcdSecond = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_e_to_the_power_of_x = new System.Windows.Forms.Button();
            this.mLight = new System.Windows.Forms.Label();
            this.button_10_to_the_power_of_x = new System.Windows.Forms.Button();
            this.button_2pi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lcdResult
            // 
            this.lcdResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.lcdResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcdResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lcdResult.Location = new System.Drawing.Point(42, 267);
            this.lcdResult.Multiline = true;
            this.lcdResult.Name = "lcdResult";
            this.lcdResult.ReadOnly = true;
            this.lcdResult.Size = new System.Drawing.Size(523, 53);
            this.lcdResult.TabIndex = 1;
            this.lcdResult.Text = "0";
            this.lcdResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_1
            // 
            this.button_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_1.BackgroundImage")));
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.ForeColor = System.Drawing.Color.Transparent;
            this.button_1.Location = new System.Drawing.Point(41, 799);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(100, 75);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_0
            // 
            this.button_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_0.BackgroundImage")));
            this.button_0.ForeColor = System.Drawing.Color.Transparent;
            this.button_0.Location = new System.Drawing.Point(41, 880);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(100, 75);
            this.button_0.TabIndex = 3;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_dot.BackgroundImage")));
            this.button_dot.ForeColor = System.Drawing.Color.Transparent;
            this.button_dot.Location = new System.Drawing.Point(147, 880);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(100, 75);
            this.button_dot.TabIndex = 4;
            this.button_dot.Text = ",";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_2
            // 
            this.button_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_2.BackgroundImage")));
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.ForeColor = System.Drawing.Color.Transparent;
            this.button_2.Location = new System.Drawing.Point(147, 799);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(100, 75);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_3
            // 
            this.button_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_3.BackgroundImage")));
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.ForeColor = System.Drawing.Color.Transparent;
            this.button_3.Location = new System.Drawing.Point(253, 799);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(100, 75);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_4
            // 
            this.button_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_4.BackgroundImage")));
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.ForeColor = System.Drawing.Color.Transparent;
            this.button_4.Location = new System.Drawing.Point(41, 718);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(100, 75);
            this.button_4.TabIndex = 7;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_5
            // 
            this.button_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_5.BackgroundImage")));
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5.ForeColor = System.Drawing.Color.Transparent;
            this.button_5.Location = new System.Drawing.Point(147, 718);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(100, 75);
            this.button_5.TabIndex = 8;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_6
            // 
            this.button_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_6.BackgroundImage")));
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_6.ForeColor = System.Drawing.Color.Transparent;
            this.button_6.Location = new System.Drawing.Point(253, 718);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(100, 75);
            this.button_6.TabIndex = 9;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_7
            // 
            this.button_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_7.BackgroundImage")));
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_7.ForeColor = System.Drawing.Color.Transparent;
            this.button_7.Location = new System.Drawing.Point(41, 637);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(100, 75);
            this.button_7.TabIndex = 10;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_8
            // 
            this.button_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_8.BackgroundImage")));
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_8.ForeColor = System.Drawing.Color.Transparent;
            this.button_8.Location = new System.Drawing.Point(147, 637);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(100, 75);
            this.button_8.TabIndex = 11;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_9
            // 
            this.button_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_9.BackgroundImage")));
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_9.ForeColor = System.Drawing.Color.Transparent;
            this.button_9.Location = new System.Drawing.Point(253, 637);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(100, 75);
            this.button_9.TabIndex = 12;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.numbers_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_multiplication.BackgroundImage")));
            this.button_multiplication.ForeColor = System.Drawing.Color.Black;
            this.button_multiplication.Location = new System.Drawing.Point(358, 637);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(100, 75);
            this.button_multiplication.TabIndex = 13;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_division
            // 
            this.button_division.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_division.BackgroundImage")));
            this.button_division.ForeColor = System.Drawing.Color.Black;
            this.button_division.Location = new System.Drawing.Point(358, 718);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(100, 75);
            this.button_division.TabIndex = 14;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_subtraction.BackgroundImage")));
            this.button_subtraction.ForeColor = System.Drawing.Color.Black;
            this.button_subtraction.Location = new System.Drawing.Point(359, 799);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(100, 75);
            this.button_subtraction.TabIndex = 15;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_addition
            // 
            this.button_addition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_addition.BackgroundImage")));
            this.button_addition.Location = new System.Drawing.Point(359, 880);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(100, 75);
            this.button_addition.TabIndex = 16;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_1_slash_x
            // 
            this.button_1_slash_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_1_slash_x.BackgroundImage")));
            this.button_1_slash_x.Location = new System.Drawing.Point(464, 718);
            this.button_1_slash_x.Name = "button_1_slash_x";
            this.button_1_slash_x.Size = new System.Drawing.Size(100, 75);
            this.button_1_slash_x.TabIndex = 17;
            this.button_1_slash_x.UseVisualStyleBackColor = true;
            this.button_1_slash_x.Click += new System.EventHandler(this.button_1_slash_x_Click);
            // 
            // button_percent
            // 
            this.button_percent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_percent.BackgroundImage")));
            this.button_percent.Location = new System.Drawing.Point(464, 637);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(100, 75);
            this.button_percent.TabIndex = 18;
            this.button_percent.UseVisualStyleBackColor = true;
            this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // button_result
            // 
            this.button_result.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_result.BackgroundImage")));
            this.button_result.Location = new System.Drawing.Point(465, 880);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(100, 75);
            this.button_result.TabIndex = 19;
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_CE
            // 
            this.button_CE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CE.BackgroundImage")));
            this.button_CE.Location = new System.Drawing.Point(358, 556);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(100, 75);
            this.button_CE.TabIndex = 20;
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_C
            // 
            this.button_C.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_C.BackgroundImage")));
            this.button_C.Location = new System.Drawing.Point(253, 556);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(100, 75);
            this.button_C.TabIndex = 21;
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sqrt.BackgroundImage")));
            this.button_sqrt.Location = new System.Drawing.Point(465, 799);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(100, 75);
            this.button_sqrt.TabIndex = 22;
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.button_sqrt_Click);
            // 
            // button_plus_or_minus
            // 
            this.button_plus_or_minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_plus_or_minus.BackgroundImage")));
            this.button_plus_or_minus.Location = new System.Drawing.Point(252, 880);
            this.button_plus_or_minus.Name = "button_plus_or_minus";
            this.button_plus_or_minus.Size = new System.Drawing.Size(100, 75);
            this.button_plus_or_minus.TabIndex = 23;
            this.button_plus_or_minus.UseVisualStyleBackColor = true;
            this.button_plus_or_minus.Click += new System.EventHandler(this.button_plus_or_minus_Click);
            // 
            // button_backspace
            // 
            this.button_backspace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_backspace.BackgroundImage")));
            this.button_backspace.Location = new System.Drawing.Point(465, 556);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(100, 75);
            this.button_backspace.TabIndex = 26;
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.button_backspace_Click);
            // 
            // button_log
            // 
            this.button_log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_log.BackgroundImage")));
            this.button_log.Location = new System.Drawing.Point(464, 512);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(100, 38);
            this.button_log.TabIndex = 27;
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_ln
            // 
            this.button_ln.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ln.BackgroundImage")));
            this.button_ln.Location = new System.Drawing.Point(464, 468);
            this.button_ln.Name = "button_ln";
            this.button_ln.Size = new System.Drawing.Size(100, 38);
            this.button_ln.TabIndex = 28;
            this.button_ln.UseVisualStyleBackColor = true;
            this.button_ln.Click += new System.EventHandler(this.button_ln_Click);
            // 
            // button_x_to_the_power_of_y
            // 
            this.button_x_to_the_power_of_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_x_to_the_power_of_y.BackgroundImage")));
            this.button_x_to_the_power_of_y.Location = new System.Drawing.Point(253, 512);
            this.button_x_to_the_power_of_y.Name = "button_x_to_the_power_of_y";
            this.button_x_to_the_power_of_y.Size = new System.Drawing.Size(100, 38);
            this.button_x_to_the_power_of_y.TabIndex = 29;
            this.button_x_to_the_power_of_y.UseVisualStyleBackColor = true;
            this.button_x_to_the_power_of_y.Click += new System.EventHandler(this.button_x_to_the_power_of_y_Click);
            // 
            // button_x_to_the_power_of_3
            // 
            this.button_x_to_the_power_of_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_x_to_the_power_of_3.BackgroundImage")));
            this.button_x_to_the_power_of_3.Location = new System.Drawing.Point(147, 512);
            this.button_x_to_the_power_of_3.Name = "button_x_to_the_power_of_3";
            this.button_x_to_the_power_of_3.Size = new System.Drawing.Size(100, 38);
            this.button_x_to_the_power_of_3.TabIndex = 30;
            this.button_x_to_the_power_of_3.UseVisualStyleBackColor = true;
            this.button_x_to_the_power_of_3.Click += new System.EventHandler(this.button_x_to_the_power_of_3_Click);
            // 
            // button_x_to_the_power_of_2
            // 
            this.button_x_to_the_power_of_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_x_to_the_power_of_2.BackgroundImage")));
            this.button_x_to_the_power_of_2.Location = new System.Drawing.Point(41, 512);
            this.button_x_to_the_power_of_2.Name = "button_x_to_the_power_of_2";
            this.button_x_to_the_power_of_2.Size = new System.Drawing.Size(100, 38);
            this.button_x_to_the_power_of_2.TabIndex = 31;
            this.button_x_to_the_power_of_2.UseVisualStyleBackColor = true;
            this.button_x_to_the_power_of_2.Click += new System.EventHandler(this.button_x_to_the_power_of_2_Click);
            // 
            // button_tan
            // 
            this.button_tan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tan.BackgroundImage")));
            this.button_tan.Location = new System.Drawing.Point(252, 468);
            this.button_tan.Name = "button_tan";
            this.button_tan.Size = new System.Drawing.Size(100, 38);
            this.button_tan.TabIndex = 32;
            this.button_tan.UseVisualStyleBackColor = true;
            this.button_tan.Click += new System.EventHandler(this.button_tan_Click);
            // 
            // button_cos
            // 
            this.button_cos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cos.BackgroundImage")));
            this.button_cos.Location = new System.Drawing.Point(147, 468);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(100, 38);
            this.button_cos.TabIndex = 33;
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_sin
            // 
            this.button_sin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sin.BackgroundImage")));
            this.button_sin.Location = new System.Drawing.Point(41, 468);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(100, 38);
            this.button_sin.TabIndex = 34;
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_sinh
            // 
            this.button_sinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_sinh.BackgroundImage")));
            this.button_sinh.Location = new System.Drawing.Point(41, 424);
            this.button_sinh.Name = "button_sinh";
            this.button_sinh.Size = new System.Drawing.Size(100, 38);
            this.button_sinh.TabIndex = 35;
            this.button_sinh.UseVisualStyleBackColor = true;
            this.button_sinh.Click += new System.EventHandler(this.button_sinh_Click);
            // 
            // button_cosh
            // 
            this.button_cosh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cosh.BackgroundImage")));
            this.button_cosh.Location = new System.Drawing.Point(147, 424);
            this.button_cosh.Name = "button_cosh";
            this.button_cosh.Size = new System.Drawing.Size(100, 38);
            this.button_cosh.TabIndex = 36;
            this.button_cosh.UseVisualStyleBackColor = true;
            this.button_cosh.Click += new System.EventHandler(this.button_cosh_Click);
            // 
            // button_tanh
            // 
            this.button_tanh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_tanh.BackgroundImage")));
            this.button_tanh.Location = new System.Drawing.Point(253, 424);
            this.button_tanh.Name = "button_tanh";
            this.button_tanh.Size = new System.Drawing.Size(100, 38);
            this.button_tanh.TabIndex = 37;
            this.button_tanh.UseVisualStyleBackColor = true;
            this.button_tanh.Click += new System.EventHandler(this.button_tanh_Click);
            // 
            // button_factorial
            // 
            this.button_factorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_factorial.BackgroundImage")));
            this.button_factorial.Location = new System.Drawing.Point(358, 512);
            this.button_factorial.Name = "button_factorial";
            this.button_factorial.Size = new System.Drawing.Size(100, 38);
            this.button_factorial.TabIndex = 38;
            this.button_factorial.UseVisualStyleBackColor = true;
            this.button_factorial.Click += new System.EventHandler(this.button_factorial_Click);
            // 
            // button_modulo
            // 
            this.button_modulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_modulo.BackgroundImage")));
            this.button_modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_modulo.ForeColor = System.Drawing.Color.Transparent;
            this.button_modulo.Location = new System.Drawing.Point(358, 380);
            this.button_modulo.Name = "button_modulo";
            this.button_modulo.Size = new System.Drawing.Size(100, 38);
            this.button_modulo.TabIndex = 39;
            this.button_modulo.Text = "Mod";
            this.button_modulo.UseVisualStyleBackColor = true;
            this.button_modulo.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_pi
            // 
            this.button_pi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pi.BackgroundImage")));
            this.button_pi.Location = new System.Drawing.Point(358, 468);
            this.button_pi.Name = "button_pi";
            this.button_pi.Size = new System.Drawing.Size(100, 38);
            this.button_pi.TabIndex = 40;
            this.button_pi.UseVisualStyleBackColor = true;
            this.button_pi.Click += new System.EventHandler(this.button_pi_Click);
            // 
            // button_x_to_the_power_of_1_slash_y
            // 
            this.button_x_to_the_power_of_1_slash_y.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_x_to_the_power_of_1_slash_y.BackgroundImage")));
            this.button_x_to_the_power_of_1_slash_y.Location = new System.Drawing.Point(41, 380);
            this.button_x_to_the_power_of_1_slash_y.Name = "button_x_to_the_power_of_1_slash_y";
            this.button_x_to_the_power_of_1_slash_y.Size = new System.Drawing.Size(100, 38);
            this.button_x_to_the_power_of_1_slash_y.TabIndex = 42;
            this.button_x_to_the_power_of_1_slash_y.UseVisualStyleBackColor = true;
            this.button_x_to_the_power_of_1_slash_y.Click += new System.EventHandler(this.button_x_to_the_power_of_1_slash_y_Click);
            // 
            // button_x_to_the_power_of_1_slash_3
            // 
            this.button_x_to_the_power_of_1_slash_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_x_to_the_power_of_1_slash_3.BackgroundImage")));
            this.button_x_to_the_power_of_1_slash_3.Location = new System.Drawing.Point(147, 380);
            this.button_x_to_the_power_of_1_slash_3.Name = "button_x_to_the_power_of_1_slash_3";
            this.button_x_to_the_power_of_1_slash_3.Size = new System.Drawing.Size(100, 38);
            this.button_x_to_the_power_of_1_slash_3.TabIndex = 43;
            this.button_x_to_the_power_of_1_slash_3.UseVisualStyleBackColor = true;
            this.button_x_to_the_power_of_1_slash_3.Click += new System.EventHandler(this.button_x_to_the_power_of_1_slash_3_Click);
            // 
            // button_Exp
            // 
            this.button_Exp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exp.BackgroundImage")));
            this.button_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Exp.ForeColor = System.Drawing.Color.Transparent;
            this.button_Exp.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Exp.Location = new System.Drawing.Point(465, 380);
            this.button_Exp.Name = "button_Exp";
            this.button_Exp.Size = new System.Drawing.Size(100, 38);
            this.button_Exp.TabIndex = 46;
            this.button_Exp.Text = "Exp";
            this.button_Exp.UseVisualStyleBackColor = true;
            this.button_Exp.Click += new System.EventHandler(this.operators_Click);
            // 
            // button_OPTN
            // 
            this.button_OPTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_OPTN.BackgroundImage")));
            this.button_OPTN.Location = new System.Drawing.Point(41, 556);
            this.button_OPTN.Name = "button_OPTN";
            this.button_OPTN.Size = new System.Drawing.Size(100, 75);
            this.button_OPTN.TabIndex = 48;
            this.button_OPTN.UseVisualStyleBackColor = true;
            this.button_OPTN.Click += new System.EventHandler(this.button_OPTN_Click);
            // 
            // button_MC
            // 
            this.button_MC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MC.BackgroundImage")));
            this.button_MC.Location = new System.Drawing.Point(41, 336);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(100, 38);
            this.button_MC.TabIndex = 49;
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.button_MC_Click);
            // 
            // button_MR
            // 
            this.button_MR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MR.BackgroundImage")));
            this.button_MR.Location = new System.Drawing.Point(147, 336);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(100, 38);
            this.button_MR.TabIndex = 50;
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.button_MR_Click);
            // 
            // button_MS
            // 
            this.button_MS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MS.BackgroundImage")));
            this.button_MS.Location = new System.Drawing.Point(253, 336);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(100, 38);
            this.button_MS.TabIndex = 51;
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // button_mPlus
            // 
            this.button_mPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_mPlus.BackgroundImage")));
            this.button_mPlus.Location = new System.Drawing.Point(358, 336);
            this.button_mPlus.Name = "button_mPlus";
            this.button_mPlus.Size = new System.Drawing.Size(100, 38);
            this.button_mPlus.TabIndex = 52;
            this.button_mPlus.UseVisualStyleBackColor = true;
            this.button_mPlus.Click += new System.EventHandler(this.button_mPlus_Click);
            // 
            // button_mMinus
            // 
            this.button_mMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_mMinus.BackgroundImage")));
            this.button_mMinus.Location = new System.Drawing.Point(464, 336);
            this.button_mMinus.Name = "button_mMinus";
            this.button_mMinus.Size = new System.Drawing.Size(100, 38);
            this.button_mMinus.TabIndex = 53;
            this.button_mMinus.UseVisualStyleBackColor = true;
            this.button_mMinus.Click += new System.EventHandler(this.button_mMinus_Click);
            // 
            // button_history
            // 
            this.button_history.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_history.BackgroundImage")));
            this.button_history.Location = new System.Drawing.Point(147, 556);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(100, 75);
            this.button_history.TabIndex = 54;
            this.button_history.UseVisualStyleBackColor = true;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(543, 823);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // lcdHistory
            // 
            this.lcdHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.lcdHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcdHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lcdHistory.Location = new System.Drawing.Point(642, 123);
            this.lcdHistory.Multiline = true;
            this.lcdHistory.Name = "lcdHistory";
            this.lcdHistory.ReadOnly = true;
            this.lcdHistory.Size = new System.Drawing.Size(523, 799);
            this.lcdHistory.TabIndex = 56;
            // 
            // lcdSecond
            // 
            this.lcdSecond.AutoSize = true;
            this.lcdSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.lcdSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lcdSecond.Location = new System.Drawing.Point(83, 178);
            this.lcdSecond.Name = "lcdSecond";
            this.lcdSecond.Size = new System.Drawing.Size(0, 25);
            this.lcdSecond.TabIndex = 57;
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear.BackgroundImage")));
            this.button_clear.Location = new System.Drawing.Point(804, 940);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(207, 62);
            this.button_clear.TabIndex = 58;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_e_to_the_power_of_x
            // 
            this.button_e_to_the_power_of_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_e_to_the_power_of_x.BackgroundImage")));
            this.button_e_to_the_power_of_x.Location = new System.Drawing.Point(464, 424);
            this.button_e_to_the_power_of_x.Name = "button_e_to_the_power_of_x";
            this.button_e_to_the_power_of_x.Size = new System.Drawing.Size(100, 38);
            this.button_e_to_the_power_of_x.TabIndex = 61;
            this.button_e_to_the_power_of_x.UseVisualStyleBackColor = true;
            this.button_e_to_the_power_of_x.Click += new System.EventHandler(this.button_e_to_the_power_of_x_Click);
            // 
            // mLight
            // 
            this.mLight.AutoSize = true;
            this.mLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.mLight.Enabled = false;
            this.mLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mLight.Location = new System.Drawing.Point(49, 123);
            this.mLight.Name = "mLight";
            this.mLight.Size = new System.Drawing.Size(43, 37);
            this.mLight.TabIndex = 64;
            this.mLight.Text = "M";
            this.mLight.Visible = false;
            // 
            // button_10_to_the_power_of_x
            // 
            this.button_10_to_the_power_of_x.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_10_to_the_power_of_x.BackgroundImage")));
            this.button_10_to_the_power_of_x.Location = new System.Drawing.Point(252, 380);
            this.button_10_to_the_power_of_x.Name = "button_10_to_the_power_of_x";
            this.button_10_to_the_power_of_x.Size = new System.Drawing.Size(100, 38);
            this.button_10_to_the_power_of_x.TabIndex = 65;
            this.button_10_to_the_power_of_x.UseVisualStyleBackColor = true;
            this.button_10_to_the_power_of_x.Click += new System.EventHandler(this.button_10_to_the_power_of_x_Click);
            // 
            // button_2pi
            // 
            this.button_2pi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_2pi.BackgroundImage")));
            this.button_2pi.Location = new System.Drawing.Point(358, 424);
            this.button_2pi.Name = "button_2pi";
            this.button_2pi.Size = new System.Drawing.Size(100, 38);
            this.button_2pi.TabIndex = 66;
            this.button_2pi.UseVisualStyleBackColor = true;
            this.button_2pi.Click += new System.EventHandler(this.button_2pi_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 1021);
            this.Controls.Add(this.button_2pi);
            this.Controls.Add(this.button_10_to_the_power_of_x);
            this.Controls.Add(this.mLight);
            this.Controls.Add(this.button_e_to_the_power_of_x);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.lcdSecond);
            this.Controls.Add(this.lcdResult);
            this.Controls.Add(this.lcdHistory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.button_mMinus);
            this.Controls.Add(this.button_mPlus);
            this.Controls.Add(this.button_MS);
            this.Controls.Add(this.button_MR);
            this.Controls.Add(this.button_MC);
            this.Controls.Add(this.button_OPTN);
            this.Controls.Add(this.button_Exp);
            this.Controls.Add(this.button_x_to_the_power_of_1_slash_3);
            this.Controls.Add(this.button_x_to_the_power_of_1_slash_y);
            this.Controls.Add(this.button_pi);
            this.Controls.Add(this.button_modulo);
            this.Controls.Add(this.button_factorial);
            this.Controls.Add(this.button_tanh);
            this.Controls.Add(this.button_cosh);
            this.Controls.Add(this.button_sinh);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_tan);
            this.Controls.Add(this.button_x_to_the_power_of_2);
            this.Controls.Add(this.button_x_to_the_power_of_3);
            this.Controls.Add(this.button_x_to_the_power_of_y);
            this.Controls.Add(this.button_ln);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_plus_or_minus);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_percent);
            this.Controls.Add(this.button_1_slash_x);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
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
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WangCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lcdResult;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Button button_addition;
        private System.Windows.Forms.Button button_1_slash_x;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_plus_or_minus;
        private System.Windows.Forms.Button button_backspace;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_ln;
        private System.Windows.Forms.Button button_x_to_the_power_of_y;
        private System.Windows.Forms.Button button_x_to_the_power_of_3;
        private System.Windows.Forms.Button button_x_to_the_power_of_2;
        private System.Windows.Forms.Button button_tan;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_sinh;
        private System.Windows.Forms.Button button_cosh;
        private System.Windows.Forms.Button button_tanh;
        private System.Windows.Forms.Button button_factorial;
        private System.Windows.Forms.Button button_modulo;
        private System.Windows.Forms.Button button_pi;
        private System.Windows.Forms.Button button_x_to_the_power_of_1_slash_y;
        private System.Windows.Forms.Button button_x_to_the_power_of_1_slash_3;
        private System.Windows.Forms.Button button_Exp;
        private System.Windows.Forms.Button button_OPTN;
        private System.Windows.Forms.Button button_MC;
        private System.Windows.Forms.Button button_MR;
        private System.Windows.Forms.Button button_MS;
        private System.Windows.Forms.Button button_mPlus;
        private System.Windows.Forms.Button button_mMinus;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox lcdHistory;
        private System.Windows.Forms.Label lcdSecond;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_e_to_the_power_of_x;
        private System.Windows.Forms.Label mLight;
        private System.Windows.Forms.Button button_10_to_the_power_of_x;
        private System.Windows.Forms.Button button_2pi;
    }
}

