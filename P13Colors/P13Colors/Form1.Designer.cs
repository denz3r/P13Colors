namespace P13Colors
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
            this.red = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.pink = new System.Windows.Forms.Button();
            this.gray = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.red.Location = new System.Drawing.Point(391, 92);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(191, 87);
            this.red.TabIndex = 2;
            this.red.Text = "RED";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.blue.Location = new System.Drawing.Point(391, 684);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(191, 87);
            this.blue.TabIndex = 0;
            this.blue.Text = "BLUE";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // yellow
            // 
            this.yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.yellow.Location = new System.Drawing.Point(391, 395);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(191, 87);
            this.yellow.TabIndex = 2;
            this.yellow.Text = "WHITE";
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // black
            // 
            this.black.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.black.Location = new System.Drawing.Point(1302, 92);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(191, 87);
            this.black.TabIndex = 3;
            this.black.Text = "BLACK";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // pink
            // 
            this.pink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pink.Location = new System.Drawing.Point(1302, 395);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(191, 87);
            this.pink.TabIndex = 4;
            this.pink.Text = "PINK";
            this.pink.UseVisualStyleBackColor = true;
            this.pink.Click += new System.EventHandler(this.pink_Click);
            // 
            // gray
            // 
            this.gray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.gray.Location = new System.Drawing.Point(1302, 684);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(191, 87);
            this.gray.TabIndex = 5;
            this.gray.Text = "GRAY";
            this.gray.UseVisualStyleBackColor = true;
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // green
            // 
            this.green.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.green.Location = new System.Drawing.Point(839, 351);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(198, 178);
            this.green.TabIndex = 6;
            this.green.Text = "Favorite Color";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1966, 905);
            this.Controls.Add(this.green);
            this.Controls.Add(this.gray);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.black);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Name = "Form1";
            this.Text = "Color Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button pink;
        private System.Windows.Forms.Button gray;
        private System.Windows.Forms.Button green;
    }
}

