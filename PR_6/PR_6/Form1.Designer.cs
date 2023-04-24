namespace PR_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeName = new System.Windows.Forms.Button();
            this.MoveImage = new System.Windows.Forms.Button();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.moxzaika = new System.Windows.Forms.Button();
            this.NameFlag = new System.Windows.Forms.Label();
            this.ChangeFlag = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeName
            // 
            this.ChangeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeName.ForeColor = System.Drawing.Color.White;
            this.ChangeName.Location = new System.Drawing.Point(397, 67);
            this.ChangeName.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(183, 40);
            this.ChangeName.TabIndex = 1;
            this.ChangeName.Text = "Измени надпись";
            this.ChangeName.UseVisualStyleBackColor = false;
            this.ChangeName.Click += new System.EventHandler(this.ChangeName_Click);
            // 
            // MoveImage
            // 
            this.MoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.MoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveImage.ForeColor = System.Drawing.SystemColors.Window;
            this.MoveImage.Location = new System.Drawing.Point(397, 127);
            this.MoveImage.Margin = new System.Windows.Forms.Padding(2);
            this.MoveImage.Name = "MoveImage";
            this.MoveImage.Size = new System.Drawing.Size(183, 40);
            this.MoveImage.TabIndex = 2;
            this.MoveImage.Text = "Сдвинь рисунок вправо";
            this.MoveImage.UseVisualStyleBackColor = false;
            this.MoveImage.Click += new System.EventHandler(this.MoveImage_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeColor.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangeColor.Location = new System.Drawing.Point(397, 192);
            this.ChangeColor.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(183, 40);
            this.ChangeColor.TabIndex = 3;
            this.ChangeColor.Text = "Измени цвет фона";
            this.ChangeColor.UseVisualStyleBackColor = false;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // moxzaika
            // 
            this.moxzaika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.moxzaika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moxzaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moxzaika.ForeColor = System.Drawing.SystemColors.Window;
            this.moxzaika.Location = new System.Drawing.Point(397, 248);
            this.moxzaika.Margin = new System.Windows.Forms.Padding(2);
            this.moxzaika.Name = "moxzaika";
            this.moxzaika.Size = new System.Drawing.Size(183, 40);
            this.moxzaika.TabIndex = 4;
            this.moxzaika.Text = "Мозайка";
            this.moxzaika.UseVisualStyleBackColor = false;
            this.moxzaika.Click += new System.EventHandler(this.MoveImage_Click);
            // 
            // NameFlag
            // 
            this.NameFlag.AutoSize = true;
            this.NameFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFlag.ForeColor = System.Drawing.Color.White;
            this.NameFlag.Location = new System.Drawing.Point(114, 79);
            this.NameFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameFlag.Name = "NameFlag";
            this.NameFlag.Size = new System.Drawing.Size(118, 20);
            this.NameFlag.TabIndex = 5;
            this.NameFlag.Text = "Флаг России";
            // 
            // ChangeFlag
            // 
            this.ChangeFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(112)))), ((int)(((byte)(177)))));
            this.ChangeFlag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeFlag.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangeFlag.Location = new System.Drawing.Point(397, 312);
            this.ChangeFlag.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeFlag.Name = "ChangeFlag";
            this.ChangeFlag.Size = new System.Drawing.Size(183, 40);
            this.ChangeFlag.TabIndex = 6;
            this.ChangeFlag.Text = "Измени флаг и надпись";
            this.ChangeFlag.UseVisualStyleBackColor = false;
            this.ChangeFlag.Click += new System.EventHandler(this.ChangeFlag_Click);
            // 
            // Image
            // 
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Image.Image = global::PR_6.Properties.Resources.eb6c7c01c4e98e1f2578f9959463b973_XS;
            this.Image.Location = new System.Drawing.Point(58, 115);
            this.Image.Margin = new System.Windows.Forms.Padding(2);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(232, 199);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(600, 436);
            this.Controls.Add(this.ChangeFlag);
            this.Controls.Add(this.NameFlag);
            this.Controls.Add(this.moxzaika);
            this.Controls.Add(this.ChangeColor);
            this.Controls.Add(this.MoveImage);
            this.Controls.Add(this.ChangeName);
            this.Controls.Add(this.Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FLUG";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button ChangeName;
        private System.Windows.Forms.Button MoveImage;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.Button moxzaika;
        private System.Windows.Forms.Label NameFlag;
        private System.Windows.Forms.Button ChangeFlag;
    }
}

