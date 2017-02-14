namespace AccountingOrders.Views
{
    partial class AddOrderView
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.edtNumber = new System.Windows.Forms.NumericUpDown();
            this.Number = new System.Windows.Forms.Label();
            this.edtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMName = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(91, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(46, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 18);
            this.date.TabIndex = 28;
            this.date.Text = "Date";
            // 
            // edtNumber
            // 
            this.edtNumber.Location = new System.Drawing.Point(91, 12);
            this.edtNumber.Name = "edtNumber";
            this.edtNumber.Size = new System.Drawing.Size(200, 20);
            this.edtNumber.TabIndex = 30;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(24, 12);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(61, 18);
            this.Number.TabIndex = 29;
            this.Number.Text = "Number";
            // 
            // edtFName
            // 
            this.edtFName.Location = new System.Drawing.Point(91, 68);
            this.edtFName.Name = "edtFName";
            this.edtFName.Size = new System.Drawing.Size(200, 20);
            this.edtFName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Last name";
            // 
            // edtLName
            // 
            this.edtLName.Location = new System.Drawing.Point(91, 120);
            this.edtLName.Name = "edtLName";
            this.edtLName.Size = new System.Drawing.Size(200, 20);
            this.edtLName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Midle name";
            // 
            // edtMName
            // 
            this.edtMName.Location = new System.Drawing.Point(91, 94);
            this.edtMName.Name = "edtMName";
            this.edtMName.Size = new System.Drawing.Size(200, 20);
            this.edtMName.TabIndex = 36;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(10, 146);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(178, 23);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(194, 146);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 23);
            this.cancelBtn.TabIndex = 39;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(12, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 40;
            // 
            // AddOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 201);
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
            this.Controls.Add(this.Number);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddOrderView";
            this.Text = "AddOrderView";
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox edtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.NumericUpDown edtNumber;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label errorLabel;
    }
}