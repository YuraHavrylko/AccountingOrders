namespace AccountingOrders.Views
{
    partial class EditOrderView
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtFName = new System.Windows.Forms.TextBox();
            this.edtNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(197, 146);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 23);
            this.cancelBtn.TabIndex = 51;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 146);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(178, 23);
            this.saveBtn.TabIndex = 50;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Midle name";
            // 
            // edtMName
            // 
            this.edtMName.Location = new System.Drawing.Point(94, 94);
            this.edtMName.Name = "edtMName";
            this.edtMName.Size = new System.Drawing.Size(200, 20);
            this.edtMName.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 47;
            this.label3.Text = "Last name";
            // 
            // edtLName
            // 
            this.edtLName.Location = new System.Drawing.Point(94, 120);
            this.edtLName.Name = "edtLName";
            this.edtLName.Size = new System.Drawing.Size(200, 20);
            this.edtLName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "First name";
            // 
            // edtFName
            // 
            this.edtFName.Location = new System.Drawing.Point(94, 68);
            this.edtFName.Name = "edtFName";
            this.edtFName.Size = new System.Drawing.Size(200, 20);
            this.edtFName.TabIndex = 44;
            // 
            // edtNumber
            // 
            this.edtNumber.Location = new System.Drawing.Point(94, 12);
            this.edtNumber.Name = "edtNumber";
            this.edtNumber.Size = new System.Drawing.Size(200, 20);
            this.edtNumber.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Number";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(49, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 18);
            this.date.TabIndex = 41;
            this.date.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(94, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 40;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(156, 96);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 53;
            // 
            // EditOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 201);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtMName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtFName);
            this.Controls.Add(this.edtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "EditOrderView";
            this.Text = "EditOrderView";
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtFName;
        private System.Windows.Forms.NumericUpDown edtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label5;
    }
}