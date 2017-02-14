namespace AccountingOrders.Views
{
    partial class OrderView
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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.finish = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(743, 264);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Order";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(94, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete Order";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(175, 13);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit Order";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(256, 13);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show Order";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(680, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(434, 16);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 7;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(50, 42);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 20);
            this.start.TabIndex = 8;
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(290, 42);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(200, 20);
            this.finish.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.start);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "OrderView";
            this.Text = "OrderView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker finish;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}