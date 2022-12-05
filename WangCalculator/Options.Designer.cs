namespace WangCalculator
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.button_unit_converter = new System.Windows.Forms.Button();
            this.button_numeral_systems_calculator = new System.Windows.Forms.Button();
            this.button_complex_numbers_calculator = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_unit_converter
            // 
            this.button_unit_converter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_unit_converter.BackgroundImage")));
            this.button_unit_converter.FlatAppearance.BorderSize = 0;
            this.button_unit_converter.Location = new System.Drawing.Point(102, 149);
            this.button_unit_converter.Name = "button_unit_converter";
            this.button_unit_converter.Size = new System.Drawing.Size(300, 65);
            this.button_unit_converter.TabIndex = 0;
            this.button_unit_converter.UseVisualStyleBackColor = true;
            this.button_unit_converter.Click += new System.EventHandler(this.button_unit_converter_Click);
            // 
            // button_numeral_systems_calculator
            // 
            this.button_numeral_systems_calculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_numeral_systems_calculator.BackgroundImage")));
            this.button_numeral_systems_calculator.Location = new System.Drawing.Point(102, 300);
            this.button_numeral_systems_calculator.Name = "button_numeral_systems_calculator";
            this.button_numeral_systems_calculator.Size = new System.Drawing.Size(300, 65);
            this.button_numeral_systems_calculator.TabIndex = 2;
            this.button_numeral_systems_calculator.UseVisualStyleBackColor = true;
            this.button_numeral_systems_calculator.Click += new System.EventHandler(this.button_numeral_system_calculator_Click);
            // 
            // button_complex_numbers_calculator
            // 
            this.button_complex_numbers_calculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_complex_numbers_calculator.BackgroundImage")));
            this.button_complex_numbers_calculator.Location = new System.Drawing.Point(102, 224);
            this.button_complex_numbers_calculator.Name = "button_complex_numbers_calculator";
            this.button_complex_numbers_calculator.Size = new System.Drawing.Size(300, 65);
            this.button_complex_numbers_calculator.TabIndex = 3;
            this.button_complex_numbers_calculator.UseVisualStyleBackColor = true;
            this.button_complex_numbers_calculator.Click += new System.EventHandler(this.button_complex_numbers_calculator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 80);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_complex_numbers_calculator);
            this.Controls.Add(this.button_numeral_systems_calculator);
            this.Controls.Add(this.button_unit_converter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_unit_converter;
        private System.Windows.Forms.Button button_numeral_systems_calculator;
        private System.Windows.Forms.Button button_complex_numbers_calculator;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}