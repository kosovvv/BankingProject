namespace BankingProject
{
    partial class newAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOblast = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButtonFemale = new System.Windows.Forms.RadioButton();
            this.rButtonMale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxOblast = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnUnmarried = new System.Windows.Forms.RadioButton();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация за клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Днешна дата";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(96, 454);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DateLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Акаунт №";
            // 
            // lblOblast
            // 
            this.lblOblast.AutoSize = true;
            this.lblOblast.Location = new System.Drawing.Point(37, 287);
            this.lblOblast.Name = "lblOblast";
            this.lblOblast.Size = new System.Drawing.Size(44, 13);
            this.lblOblast.TabIndex = 4;
            this.lblOblast.Text = "Област";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(37, 265);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Адрес";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(37, 242);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Телефон";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 220);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Име";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(37, 309);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "Град";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonFemale);
            this.groupBox1.Controls.Add(this.rButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(426, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 36);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // rButtonFemale
            // 
            this.rButtonFemale.AutoSize = true;
            this.rButtonFemale.Location = new System.Drawing.Point(93, 16);
            this.rButtonFemale.Name = "rButtonFemale";
            this.rButtonFemale.Size = new System.Drawing.Size(54, 17);
            this.rButtonFemale.TabIndex = 1;
            this.rButtonFemale.TabStop = true;
            this.rButtonFemale.Text = "Жена";
            this.rButtonFemale.UseVisualStyleBackColor = true;
            // 
            // rButtonMale
            // 
            this.rButtonMale.AutoSize = true;
            this.rButtonMale.Location = new System.Drawing.Point(16, 16);
            this.rButtonMale.Name = "rButtonMale";
            this.rButtonMale.Size = new System.Drawing.Size(49, 17);
            this.rButtonMale.TabIndex = 0;
            this.rButtonMale.TabStop = true;
            this.rButtonMale.Text = "Мъж";
            this.rButtonMale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(99, 195);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(168, 20);
            this.txtAccNumber.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 220);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(95, 242);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(172, 20);
            this.txtBoxPhone.TabIndex = 13;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(81, 265);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(186, 20);
            this.txtBoxAddress.TabIndex = 14;
            // 
            // txtBoxOblast
            // 
            this.txtBoxOblast.Location = new System.Drawing.Point(81, 287);
            this.txtBoxOblast.Name = "txtBoxOblast";
            this.txtBoxOblast.Size = new System.Drawing.Size(186, 20);
            this.txtBoxOblast.TabIndex = 15;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(74, 309);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(193, 20);
            this.txtBoxCity.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Баланс";
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(437, 335);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(168, 20);
            this.txtBal.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnUnmarried);
            this.groupBox2.Controls.Add(this.rbtnMarried);
            this.groupBox2.Location = new System.Drawing.Point(426, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 36);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статус";
            // 
            // rbtnUnmarried
            // 
            this.rbtnUnmarried.AutoSize = true;
            this.rbtnUnmarried.Location = new System.Drawing.Point(93, 16);
            this.rbtnUnmarried.Name = "rbtnUnmarried";
            this.rbtnUnmarried.Size = new System.Drawing.Size(77, 17);
            this.rbtnUnmarried.TabIndex = 1;
            this.rbtnUnmarried.TabStop = true;
            this.rbtnUnmarried.Text = "Несемеен";
            this.rbtnUnmarried.UseVisualStyleBackColor = true;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(16, 16);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(64, 17);
            this.rbtnMarried.TabIndex = 0;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Семеен";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Дата на раждане";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 494);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxOblast);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblOblast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newAccount";
            this.Text = "newAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOblast;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButtonFemale;
        private System.Windows.Forms.RadioButton rButtonMale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxOblast;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnUnmarried;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}