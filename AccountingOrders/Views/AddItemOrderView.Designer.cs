namespace AccountingOrders.Views
{
    partial class AddItemOrderView
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
            this.lavel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(173, 90);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 23);
            this.cancelBtn.TabIndex = 51;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(11, 90);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(149, 23);
            this.saveBtn.TabIndex = 50;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lavel.Location = new System.Drawing.Point(8, 12);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(48, 18);
            this.lavel.TabIndex = 42;
            this.lavel.Text = "Name";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(14, 40);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 18);
            this.date.TabIndex = 41;
            this.date.Text = "Price";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(62, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 52;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(63, 38);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(199, 20);
            this.price.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Count";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(62, 64);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(199, 20);
            this.count.TabIndex = 56;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(14, 125);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 58;
            // 
            // AddItemOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lavel);
            this.Controls.Add(this.date);
            this.Name = "AddItemOrderView";
            this.Text = "AddItemOrderView";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Label errorLabel;
    }
}