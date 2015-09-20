namespace animal_years
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ageInput = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.cow = new System.Windows.Forms.PictureBox();
            this.mouse = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.chick = new System.Windows.Forms.PictureBox();
            this.dog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            this.SuspendLayout();
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(497, 65);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(246, 187);
            this.ageInput.TabIndex = 0;
            this.ageInput.Text = "ENTER YOUR AGE!";
            this.ageInput.UseVisualStyleBackColor = true;
            this.ageInput.Click += new System.EventHandler(this.ageInput_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(804, 65);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(236, 187);
            this.Help.TabIndex = 1;
            this.Help.Text = "HELP";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(-1, 65);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(296, 80);
            this.input.TabIndex = 2;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(-1, 156);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(295, 96);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // cow
            // 
            this.cow.Image = ((System.Drawing.Image)(resources.GetObject("cow.Image")));
            this.cow.Location = new System.Drawing.Point(241, 320);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(180, 137);
            this.cow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow.TabIndex = 4;
            this.cow.TabStop = false;
            this.cow.Click += new System.EventHandler(this.cow_Click);
            // 
            // mouse
            // 
            this.mouse.Image = ((System.Drawing.Image)(resources.GetObject("mouse.Image")));
            this.mouse.Location = new System.Drawing.Point(888, 320);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(123, 115);
            this.mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mouse.TabIndex = 5;
            this.mouse.TabStop = false;
            this.mouse.Click += new System.EventHandler(this.mouse_Click);
            // 
            // cat
            // 
            this.cat.Image = ((System.Drawing.Image)(resources.GetObject("cat.Image")));
            this.cat.Location = new System.Drawing.Point(634, 287);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(196, 148);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 6;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // chick
            // 
            this.chick.Image = ((System.Drawing.Image)(resources.GetObject("chick.Image")));
            this.chick.Location = new System.Drawing.Point(455, 301);
            this.chick.Name = "chick";
            this.chick.Size = new System.Drawing.Size(133, 159);
            this.chick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chick.TabIndex = 7;
            this.chick.TabStop = false;
            this.chick.Click += new System.EventHandler(this.chick_Click);
            // 
            // dog
            // 
            this.dog.Image = ((System.Drawing.Image)(resources.GetObject("dog.Image")));
            this.dog.Location = new System.Drawing.Point(12, 301);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(209, 156);
            this.dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog.TabIndex = 8;
            this.dog.TabStop = false;
            this.dog.Click += new System.EventHandler(this.dog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 552);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.chick);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.cow);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.ageInput);
            this.Name = "Form1";
            this.Text = "c";
            ((System.ComponentModel.ISupportInitialize)(this.cow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ageInput;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.PictureBox cow;
        private System.Windows.Forms.PictureBox mouse;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox chick;
        private System.Windows.Forms.PictureBox dog;
    }
}

