namespace MNIST.IO
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageViewer9 = new MNIST.IO.imageViewer();
            this.imageViewer8 = new MNIST.IO.imageViewer();
            this.imageViewer7 = new MNIST.IO.imageViewer();
            this.imageViewer6 = new MNIST.IO.imageViewer();
            this.imageViewer5 = new MNIST.IO.imageViewer();
            this.imageViewer4 = new MNIST.IO.imageViewer();
            this.imageViewer3 = new MNIST.IO.imageViewer();
            this.imageViewer2 = new MNIST.IO.imageViewer();
            this.imageViewer1 = new MNIST.IO.imageViewer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 378);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(500, 486);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 147);
            this.listBox1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(82, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 19;
            this.button4.Text = "Train";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 22);
            this.button5.TabIndex = 20;
            this.button5.Text = "Test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 22);
            this.button6.TabIndex = 21;
            this.button6.Text = "Auto Train";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 22);
            this.button7.TabIndex = 22;
            this.button7.Text = "Save Ann";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 490);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 23);
            this.button8.TabIndex = 23;
            this.button8.Text = "Load Ann";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(500, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(349, 468);
            this.treeView1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            // 
            // imageViewer9
            // 
            this.imageViewer9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer9.Location = new System.Drawing.Point(340, 486);
            this.imageViewer9.Name = "imageViewer9";
            this.imageViewer9.Size = new System.Drawing.Size(152, 152);
            this.imageViewer9.TabIndex = 11;
            // 
            // imageViewer8
            // 
            this.imageViewer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer8.Location = new System.Drawing.Point(340, 328);
            this.imageViewer8.Name = "imageViewer8";
            this.imageViewer8.Size = new System.Drawing.Size(152, 152);
            this.imageViewer8.TabIndex = 10;
            // 
            // imageViewer7
            // 
            this.imageViewer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer7.Location = new System.Drawing.Point(340, 170);
            this.imageViewer7.Name = "imageViewer7";
            this.imageViewer7.Size = new System.Drawing.Size(152, 152);
            this.imageViewer7.TabIndex = 9;
            // 
            // imageViewer6
            // 
            this.imageViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer6.Location = new System.Drawing.Point(340, 12);
            this.imageViewer6.Name = "imageViewer6";
            this.imageViewer6.Size = new System.Drawing.Size(152, 152);
            this.imageViewer6.TabIndex = 8;
            // 
            // imageViewer5
            // 
            this.imageViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer5.Location = new System.Drawing.Point(182, 486);
            this.imageViewer5.Name = "imageViewer5";
            this.imageViewer5.Size = new System.Drawing.Size(152, 152);
            this.imageViewer5.TabIndex = 7;
            // 
            // imageViewer4
            // 
            this.imageViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer4.Location = new System.Drawing.Point(182, 328);
            this.imageViewer4.Name = "imageViewer4";
            this.imageViewer4.Size = new System.Drawing.Size(152, 152);
            this.imageViewer4.TabIndex = 6;
            // 
            // imageViewer3
            // 
            this.imageViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer3.Location = new System.Drawing.Point(182, 170);
            this.imageViewer3.Name = "imageViewer3";
            this.imageViewer3.Size = new System.Drawing.Size(152, 152);
            this.imageViewer3.TabIndex = 5;
            // 
            // imageViewer2
            // 
            this.imageViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer2.Location = new System.Drawing.Point(182, 12);
            this.imageViewer2.Name = "imageViewer2";
            this.imageViewer2.Size = new System.Drawing.Size(152, 152);
            this.imageViewer2.TabIndex = 4;
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.Location = new System.Drawing.Point(12, 12);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(152, 152);
            this.imageViewer1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Maroon;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(12, 170);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 58);
            this.listBox2.TabIndex = 26;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 23);
            this.button9.TabIndex = 27;
            this.button9.Text = "Open Image";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(106, 234);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 24);
            this.button10.TabIndex = 28;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(12, 405);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 662);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.imageViewer9);
            this.Controls.Add(this.imageViewer8);
            this.Controls.Add(this.imageViewer7);
            this.Controls.Add(this.imageViewer6);
            this.Controls.Add(this.imageViewer5);
            this.Controls.Add(this.imageViewer4);
            this.Controls.Add(this.imageViewer3);
            this.Controls.Add(this.imageViewer2);
            this.Controls.Add(this.imageViewer1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private imageViewer imageViewer1;
        private imageViewer imageViewer2;
        private imageViewer imageViewer3;
        private imageViewer imageViewer4;
        private imageViewer imageViewer5;
        private imageViewer imageViewer6;
        private imageViewer imageViewer7;
        private imageViewer imageViewer8;
        private imageViewer imageViewer9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

