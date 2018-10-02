namespace Graphics3
{
    partial class Task1B
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picture_button = new System.Windows.Forms.Button();
            this.fill_button = new System.Windows.Forms.Button();
            this.draw_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 530);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(1095, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 115);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // picture_button
            // 
            this.picture_button.Location = new System.Drawing.Point(961, 13);
            this.picture_button.Name = "picture_button";
            this.picture_button.Size = new System.Drawing.Size(127, 115);
            this.picture_button.TabIndex = 8;
            this.picture_button.Text = "Выбрать файл";
            this.picture_button.UseVisualStyleBackColor = true;
            this.picture_button.Click += new System.EventHandler(this.picture_button_Click);
            // 
            // fill_button
            // 
            this.fill_button.Location = new System.Drawing.Point(961, 134);
            this.fill_button.Name = "fill_button";
            this.fill_button.Size = new System.Drawing.Size(127, 115);
            this.fill_button.TabIndex = 9;
            this.fill_button.Text = "Заливка";
            this.fill_button.UseVisualStyleBackColor = true;
            this.fill_button.Click += new System.EventHandler(this.fill_button_Click);
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(961, 255);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(127, 115);
            this.draw_button.TabIndex = 10;
            this.draw_button.Text = "Рисование";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(961, 376);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(127, 115);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 550);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(284, 45);
            this.trackBar1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Толщина границ";
            // 
            // Task1B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.fill_button);
            this.Controls.Add(this.picture_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task1B";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button picture_button;
        private System.Windows.Forms.Button fill_button;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}