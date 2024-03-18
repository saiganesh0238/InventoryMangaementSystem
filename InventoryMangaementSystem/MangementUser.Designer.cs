namespace InventoryMangaementSystem
{
    partial class MangementUser
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.TelephonetextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.FullnametextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 119);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1138, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "MANAGE USERS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsertextBox
            // 
            this.UsertextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertextBox.Location = new System.Drawing.Point(87, 181);
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(125, 32);
            this.UsertextBox.TabIndex = 2;
            this.UsertextBox.Text = "USER NAME";
            this.UsertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelephonetextBox
            // 
            this.TelephonetextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephonetextBox.Location = new System.Drawing.Point(87, 404);
            this.TelephonetextBox.Name = "TelephonetextBox";
            this.TelephonetextBox.Size = new System.Drawing.Size(125, 32);
            this.TelephonetextBox.TabIndex = 3;
            this.TelephonetextBox.Text = "TELEPHONE";
            this.TelephonetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(87, 321);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(125, 32);
            this.PasswordtextBox.TabIndex = 4;
            this.PasswordtextBox.Text = "PASSWORD";
            this.PasswordtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullnametextBox
            // 
            this.FullnametextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnametextBox.Location = new System.Drawing.Point(87, 245);
            this.FullnametextBox.Name = "FullnametextBox";
            this.FullnametextBox.Size = new System.Drawing.Size(125, 32);
            this.FullnametextBox.TabIndex = 5;
            this.FullnametextBox.Text = "FULL NAME";
            this.FullnametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Red;
            this.Addbutton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(87, 479);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(89, 36);
            this.Addbutton.TabIndex = 6;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Red;
            this.deletebutton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(384, 479);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(89, 36);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Red;
            this.Editbutton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbutton.Location = new System.Drawing.Point(238, 479);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(89, 36);
            this.Editbutton.TabIndex = 8;
            this.Editbutton.Text = "EDIT";
            this.Editbutton.UseVisualStyleBackColor = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.Color.Red;
            this.homebutton.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Location = new System.Drawing.Point(238, 553);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(89, 36);
            this.homebutton.TabIndex = 9;
            this.homebutton.Text = "HOME";
            this.homebutton.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(12, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1162, 18);
            this.panel4.TabIndex = 11;
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(550, 137);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.RowHeadersWidth = 51;
            this.dataGridInventory.RowTemplate.Height = 24;
            this.dataGridInventory.Size = new System.Drawing.Size(542, 468);
            this.dataGridInventory.TabIndex = 12;
            this.dataGridInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventory_CellContentClick);
            // 
            // MangementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 641);
            this.Controls.Add(this.dataGridInventory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.FullnametextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.TelephonetextBox);
            this.Controls.Add(this.UsertextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangementUser";
            this.Text = "MangementUser";
            this.Load += new System.EventHandler(this.MangementUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.TextBox TelephonetextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox FullnametextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridInventory;
    }
}