namespace Medical_Store
{
    partial class insertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertForm));
            this.label1 = new System.Windows.Forms.Label();
            this.insertbutton1 = new System.Windows.Forms.Button();
            this.itemnametextBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pricetextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantitytextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.companynametextBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deletebutton2 = new System.Windows.Forms.Button();
            this.updatebutton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // insertbutton1
            // 
            this.insertbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbutton1.Location = new System.Drawing.Point(143, 164);
            this.insertbutton1.Name = "insertbutton1";
            this.insertbutton1.Size = new System.Drawing.Size(69, 66);
            this.insertbutton1.TabIndex = 5;
            this.insertbutton1.Text = "&Insert Record";
            this.insertbutton1.UseVisualStyleBackColor = true;
            this.insertbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemnametextBox1
            // 
            this.itemnametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnametextBox1.Location = new System.Drawing.Point(143, 12);
            this.itemnametextBox1.Name = "itemnametextBox1";
            this.itemnametextBox1.Size = new System.Drawing.Size(203, 21);
            this.itemnametextBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // pricetextBox2
            // 
            this.pricetextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextBox2.Location = new System.Drawing.Point(143, 40);
            this.pricetextBox2.Name = "pricetextBox2";
            this.pricetextBox2.Size = new System.Drawing.Size(203, 21);
            this.pricetextBox2.TabIndex = 1;
            this.pricetextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quanity";
            // 
            // quantitytextBox3
            // 
            this.quantitytextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytextBox3.Location = new System.Drawing.Point(143, 66);
            this.quantitytextBox3.Name = "quantitytextBox3";
            this.quantitytextBox3.Size = new System.Drawing.Size(203, 21);
            this.quantitytextBox3.TabIndex = 2;
            this.quantitytextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytextBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company Name";
            // 
            // companynametextBox4
            // 
            this.companynametextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynametextBox4.Location = new System.Drawing.Point(143, 92);
            this.companynametextBox4.Name = "companynametextBox4";
            this.companynametextBox4.Size = new System.Drawing.Size(203, 21);
            this.companynametextBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // deletebutton2
            // 
            this.deletebutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton2.Location = new System.Drawing.Point(219, 200);
            this.deletebutton2.Name = "deletebutton2";
            this.deletebutton2.Size = new System.Drawing.Size(127, 30);
            this.deletebutton2.TabIndex = 5;
            this.deletebutton2.Text = "&Delete Record";
            this.deletebutton2.UseVisualStyleBackColor = true;
            this.deletebutton2.Click += new System.EventHandler(this.deletebutton2_Click);
            // 
            // updatebutton4
            // 
            this.updatebutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton4.Location = new System.Drawing.Point(218, 164);
            this.updatebutton4.Name = "updatebutton4";
            this.updatebutton4.Size = new System.Drawing.Size(127, 30);
            this.updatebutton4.TabIndex = 5;
            this.updatebutton4.Text = "&Update Record";
            this.updatebutton4.UseVisualStyleBackColor = true;
            this.updatebutton4.Click += new System.EventHandler(this.updatebutton4_Click);
            // 
            // insertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 259);
            this.Controls.Add(this.insertbutton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.companynametextBox4);
            this.Controls.Add(this.quantitytextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricetextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemnametextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletebutton2);
            this.Controls.Add(this.updatebutton4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "insertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "insertForm";
            this.Load += new System.EventHandler(this.insertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertbutton1;
        private System.Windows.Forms.TextBox itemnametextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricetextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantitytextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox companynametextBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deletebutton2;
        private System.Windows.Forms.Button updatebutton4;
    }
}