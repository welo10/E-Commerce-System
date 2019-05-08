namespace WindowsFormsApplication2
{
    partial class itemsfunction
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
            this.removeb = new System.Windows.Forms.Button();
            this.item_id = new System.Windows.Forms.TextBox();
            this.Change_price = new System.Windows.Forms.Button();
            this.change_quantity = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // removeb
            // 
            this.removeb.Location = new System.Drawing.Point(134, 290);
            this.removeb.Name = "removeb";
            this.removeb.Size = new System.Drawing.Size(87, 33);
            this.removeb.TabIndex = 12;
            this.removeb.Text = "Remove Brand";
            this.removeb.UseVisualStyleBackColor = true;
            this.removeb.Click += new System.EventHandler(this.removeb_Click);
            // 
            // item_id
            // 
            this.item_id.Location = new System.Drawing.Point(192, 255);
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(134, 20);
            this.item_id.TabIndex = 11;
            // 
            // Change_price
            // 
            this.Change_price.Location = new System.Drawing.Point(412, 290);
            this.Change_price.Name = "Change_price";
            this.Change_price.Size = new System.Drawing.Size(91, 33);
            this.Change_price.TabIndex = 10;
            this.Change_price.Text = "Change Price";
            this.Change_price.UseVisualStyleBackColor = true;
            this.Change_price.Click += new System.EventHandler(this.Change_price_Click);
            // 
            // change_quantity
            // 
            this.change_quantity.Location = new System.Drawing.Point(309, 290);
            this.change_quantity.Name = "change_quantity";
            this.change_quantity.Size = new System.Drawing.Size(97, 33);
            this.change_quantity.TabIndex = 9;
            this.change_quantity.Text = "Change quantity";
            this.change_quantity.UseVisualStyleBackColor = true;
            this.change_quantity.Click += new System.EventHandler(this.change_quantity_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(46, 290);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(82, 33);
            this.Remove.TabIndex = 8;
            this.Remove.Text = "Remove Item";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 217);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemsfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 439);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.removeb);
            this.Controls.Add(this.item_id);
            this.Controls.Add(this.Change_price);
            this.Controls.Add(this.change_quantity);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.dataGridView1);
            this.Name = "itemsfunction";
            this.Text = "itemsfunction";
            this.Load += new System.EventHandler(this.itemsfunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeb;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.Button Change_price;
        private System.Windows.Forms.Button change_quantity;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}