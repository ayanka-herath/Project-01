namespace userLogin
{
    partial class Chef
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvchef = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.foodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ready = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchef)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::userLogin.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(637, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Treat RESTAURANT";
            // 
            // dgvchef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvchef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvchef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchef.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvchef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.tableNo,
            this.foodID,
            this.foodName,
            this.quantity,
            this.ready});
            this.dgvchef.Location = new System.Drawing.Point(12, 122);
            this.dgvchef.Name = "dgvchef";
            this.dgvchef.Size = new System.Drawing.Size(738, 318);
            this.dgvchef.TabIndex = 28;
            // 
            // orderNo
            // 
            this.orderNo.HeaderText = "Order No";
            this.orderNo.Name = "orderNo";
            // 
            // tableNo
            // 
            this.tableNo.HeaderText = "Table No";
            this.tableNo.Name = "tableNo";
            this.tableNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tableNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // foodID
            // 
            this.foodID.HeaderText = "Food ID";
            this.foodID.Name = "foodID";
            // 
            // foodName
            // 
            this.foodName.HeaderText = "Food Name";
            this.foodName.Name = "foodName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // ready
            // 
            this.ready.HeaderText = "Ready";
            this.ready.Name = "ready";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnlogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnlogout.Location = new System.Drawing.Point(642, 450);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(108, 31);
            this.btnlogout.TabIndex = 29;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.dgvchef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chef";
            this.Text = "Treat Restaurent";
            this.Load += new System.EventHandler(this.Cheif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvchef;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn tableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ready;
        private System.Windows.Forms.Button btnlogout;
    }
}