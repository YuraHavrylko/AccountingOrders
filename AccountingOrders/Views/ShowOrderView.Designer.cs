namespace AccountingOrders.Views
{
    partial class ShowOrderView
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
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
            this.dataGridViewOrderItem = new System.Windows.Forms.DataGridView();
            this.edtId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtId)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(158, 126);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 65;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(318, 14);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 23);
            this.deleteBtn.TabIndex = 64;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(211, 14);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 23);
            this.addBtn.TabIndex = 63;
            this.addBtn.Text = "Add Item Order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Midle name";
            // 
            // edtMName
            // 
            this.edtMName.Enabled = false;
            this.edtMName.Location = new System.Drawing.Point(95, 124);
            this.edtMName.Name = "edtMName";
            this.edtMName.Size = new System.Drawing.Size(109, 20);
            this.edtMName.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Last name";
            // 
            // edtLName
            // 
            this.edtLName.Enabled = false;
            this.edtLName.Location = new System.Drawing.Point(95, 150);
            this.edtLName.Name = "edtLName";
            this.edtLName.Size = new System.Drawing.Size(109, 20);
            this.edtLName.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "First name";
            // 
            // edtFName
            // 
            this.edtFName.Enabled = false;
            this.edtFName.Location = new System.Drawing.Point(96, 98);
            this.edtFName.Name = "edtFName";
            this.edtFName.Size = new System.Drawing.Size(109, 20);
            this.edtFName.TabIndex = 57;
            // 
            // edtNumber
            // 
            this.edtNumber.Enabled = false;
            this.edtNumber.Location = new System.Drawing.Point(96, 42);
            this.edtNumber.Name = "edtNumber";
            this.edtNumber.Size = new System.Drawing.Size(109, 20);
            this.edtNumber.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Number";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(51, 72);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 18);
            this.date.TabIndex = 54;
            this.date.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(96, 72);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker.TabIndex = 53;
            // 
            // dataGridViewOrderItem
            // 
            this.dataGridViewOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItem.Location = new System.Drawing.Point(211, 42);
            this.dataGridViewOrderItem.Name = "dataGridViewOrderItem";
            this.dataGridViewOrderItem.Size = new System.Drawing.Size(541, 152);
            this.dataGridViewOrderItem.TabIndex = 66;
            // 
            // edtId
            // 
            this.edtId.Enabled = false;
            this.edtId.Location = new System.Drawing.Point(96, 14);
            this.edtId.Name = "edtId";
            this.edtId.Size = new System.Drawing.Size(109, 20);
            this.edtId.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(67, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "ID";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(431, 21);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-5, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "Total amount";
            // 
            // totalAmount
            // 
            this.totalAmount.Enabled = false;
            this.totalAmount.Location = new System.Drawing.Point(96, 176);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(109, 20);
            this.totalAmount.TabIndex = 72;
            // 
            // ShowOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 215);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.edtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewOrderItem);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
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
            this.Name = "ShowOrderView";
            this.Text = "ShowOrderView";
            ((System.ComponentModel.ISupportInitialize)(this.edtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
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
        private System.Windows.Forms.DataGridView dataGridViewOrderItem;
        private System.Windows.Forms.NumericUpDown edtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label label6;
    }
}