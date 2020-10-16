namespace POS
{
    partial class frmSale
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
            this.invoicetextBox = new System.Windows.Forms.TextBox();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.discounttextBox = new System.Windows.Forms.TextBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.subtotaltextBox = new System.Windows.Forms.TextBox();
            this.taxtextBox = new System.Windows.Forms.TextBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.grandtotaltextBox = new System.Windows.Forms.TextBox();
            this.amountpaidtextBox = new System.Windows.Forms.TextBox();
            this.changetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.btnClearGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicetextBox
            // 
            this.invoicetextBox.Location = new System.Drawing.Point(169, 50);
            this.invoicetextBox.Name = "invoicetextBox";
            this.invoicetextBox.ReadOnly = true;
            this.invoicetextBox.Size = new System.Drawing.Size(152, 26);
            this.invoicetextBox.TabIndex = 10;
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(169, 102);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.ReadOnly = true;
            this.usertextBox.Size = new System.Drawing.Size(152, 26);
            this.usertextBox.TabIndex = 11;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(169, 199);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.ReadOnly = true;
            this.pricetextBox.Size = new System.Drawing.Size(152, 26);
            this.pricetextBox.TabIndex = 1;
            // 
            // discounttextBox
            // 
            this.discounttextBox.Location = new System.Drawing.Point(169, 249);
            this.discounttextBox.Name = "discounttextBox";
            this.discounttextBox.Size = new System.Drawing.Size(152, 26);
            this.discounttextBox.TabIndex = 2;
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Enabled = false;
            this.quantitytextBox.Location = new System.Drawing.Point(374, 50);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(152, 26);
            this.quantitytextBox.TabIndex = 3;
            this.quantitytextBox.TextChanged += new System.EventHandler(this.quantitytextBox_TextChanged);
            // 
            // subtotaltextBox
            // 
            this.subtotaltextBox.Location = new System.Drawing.Point(374, 102);
            this.subtotaltextBox.Name = "subtotaltextBox";
            this.subtotaltextBox.ReadOnly = true;
            this.subtotaltextBox.Size = new System.Drawing.Size(152, 26);
            this.subtotaltextBox.TabIndex = 4;
            this.subtotaltextBox.TextChanged += new System.EventHandler(this.subtotaltextBox_TextChanged);
            // 
            // taxtextBox
            // 
            this.taxtextBox.Location = new System.Drawing.Point(374, 152);
            this.taxtextBox.Name = "taxtextBox";
            this.taxtextBox.ReadOnly = true;
            this.taxtextBox.Size = new System.Drawing.Size(152, 26);
            this.taxtextBox.TabIndex = 5;
            this.taxtextBox.TextChanged += new System.EventHandler(this.taxtextBox_TextChanged);
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(374, 199);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.ReadOnly = true;
            this.totaltextBox.Size = new System.Drawing.Size(152, 26);
            this.totaltextBox.TabIndex = 6;
            // 
            // grandtotaltextBox
            // 
            this.grandtotaltextBox.Location = new System.Drawing.Point(374, 249);
            this.grandtotaltextBox.Name = "grandtotaltextBox";
            this.grandtotaltextBox.ReadOnly = true;
            this.grandtotaltextBox.Size = new System.Drawing.Size(152, 26);
            this.grandtotaltextBox.TabIndex = 7;
            // 
            // amountpaidtextBox
            // 
            this.amountpaidtextBox.Location = new System.Drawing.Point(571, 50);
            this.amountpaidtextBox.Name = "amountpaidtextBox";
            this.amountpaidtextBox.Size = new System.Drawing.Size(152, 26);
            this.amountpaidtextBox.TabIndex = 8;
            this.amountpaidtextBox.TextChanged += new System.EventHandler(this.amountpaidtextBox_TextChanged);
            // 
            // changetextBox
            // 
            this.changetextBox.Location = new System.Drawing.Point(571, 102);
            this.changetextBox.Name = "changetextBox";
            this.changetextBox.ReadOnly = true;
            this.changetextBox.Size = new System.Drawing.Size(152, 26);
            this.changetextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Invoice No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Grand Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(568, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Amount Paid";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(568, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Change";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(169, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(250, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(806, 255);
            this.dataGridView1.TabIndex = 26;
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Location = new System.Drawing.Point(169, 150);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(152, 28);
            this.itemcomboBox.TabIndex = 0;
            this.itemcomboBox.SelectedIndexChanged += new System.EventHandler(this.itemcomboBox_SelectedIndexChanged);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Location = new System.Drawing.Point(761, 606);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(75, 28);
            this.btnClearGrid.TabIndex = 27;
            this.btnClearGrid.Text = "Clear";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 640);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.itemcomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changetextBox);
            this.Controls.Add(this.amountpaidtextBox);
            this.Controls.Add(this.grandtotaltextBox);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.taxtextBox);
            this.Controls.Add(this.subtotaltextBox);
            this.Controls.Add(this.quantitytextBox);
            this.Controls.Add(this.discounttextBox);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.usertextBox);
            this.Controls.Add(this.invoicetextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invoicetextBox;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox discounttextBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.TextBox subtotaltextBox;
        private System.Windows.Forms.TextBox taxtextBox;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.TextBox grandtotaltextBox;
        private System.Windows.Forms.TextBox amountpaidtextBox;
        private System.Windows.Forms.TextBox changetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.Button btnClearGrid;
    }
}