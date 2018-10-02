namespace Graphics3
{
    partial class Task1A
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.color_button = new System.Windows.Forms.Button();
            this.fill_button = new System.Windows.Forms.Button();
            this.draw_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp1);
            // 
            // color_button
            // 
            this.color_button.Location = new System.Drawing.Point(959, 12);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(127, 115);
            this.color_button.TabIndex = 1;
            this.color_button.Text = "Выбрать цвет";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // fill_button
            // 
            this.fill_button.Location = new System.Drawing.Point(959, 133);
            this.fill_button.Name = "fill_button";
            this.fill_button.Size = new System.Drawing.Size(127, 115);
            this.fill_button.TabIndex = 2;
            this.fill_button.Text = "Заливка";
            this.fill_button.UseVisualStyleBackColor = true;
            this.fill_button.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(959, 254);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(127, 115);
            this.draw_button.TabIndex = 3;
            this.draw_button.Text = "Рисование";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 548);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(284, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Толщина границ";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(959, 375);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(127, 115);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Task1A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.fill_button);
            this.Controls.Add(this.color_button);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Task1A";
            this.Text = "Заливка цветом";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button color_button;
        private System.Windows.Forms.Button fill_button;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button clear_button;
    }
}