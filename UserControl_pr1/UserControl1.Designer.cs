namespace UserControl_pr1
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMotorbike = new System.Windows.Forms.PictureBox();
            this.labellDData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // pictureBoxMotorbike
            // 
            this.pictureBoxMotorbike.Location = new System.Drawing.Point(23, 23);
            this.pictureBoxMotorbike.Name = "pictureBoxMotorbike";
            this.pictureBoxMotorbike.Size = new System.Drawing.Size(274, 130);
            this.pictureBoxMotorbike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMotorbike.TabIndex = 1;
            this.pictureBoxMotorbike.TabStop = false;
            // 
            // labellDData
            // 
            this.labellDData.AutoSize = true;
            this.labellDData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labellDData.Location = new System.Drawing.Point(154, 194);
            this.labellDData.Name = "labellDData";
            this.labellDData.Size = new System.Drawing.Size(92, 20);
            this.labellDData.TabIndex = 2;
            this.labellDData.Text = "labellDData";
            this.labellDData.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(39, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(39, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Марка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(39, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(39, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Л/С";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(39, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Пробег";
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelModelData.Location = new System.Drawing.Point(154, 234);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(120, 20);
            this.labelModelData.TabIndex = 8;
            this.labelModelData.Text = "labelModelData";
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBrandData.Location = new System.Drawing.Point(154, 275);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(120, 20);
            this.labelBrandData.TabIndex = 9;
            this.labelBrandData.Text = "labelBrandData";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPriceData.Location = new System.Drawing.Point(154, 316);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(112, 20);
            this.labelPriceData.TabIndex = 10;
            this.labelPriceData.Text = "labelPriceData";
            // 
            // labelHorsepowerData
            // 
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHorsepowerData.Location = new System.Drawing.Point(154, 355);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Size = new System.Drawing.Size(163, 20);
            this.labelHorsepowerData.TabIndex = 11;
            this.labelHorsepowerData.Text = "labelHorsepowerData";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMileageData.Location = new System.Drawing.Point(154, 392);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(132, 20);
            this.labelMileageData.TabIndex = 12;
            this.labelMileageData.Text = "labelMileageData";
            this.labelMileageData.Click += new System.EventHandler(this.label12_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labellDData);
            this.Controls.Add(this.pictureBoxMotorbike);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(322, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMotorbike;
        private System.Windows.Forms.Label labellDData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label labelMileageData;
    }
}
