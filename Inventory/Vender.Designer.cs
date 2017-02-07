namespace Inventory
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.VendersLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.VenderName = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateVenders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VendersLbl
            // 
            this.VendersLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VendersLbl.AutoSize = true;
            this.VendersLbl.BackColor = System.Drawing.Color.Transparent;
            this.VendersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendersLbl.ForeColor = System.Drawing.Color.Black;
            this.VendersLbl.Location = new System.Drawing.Point(206, 24);
            this.VendersLbl.Name = "VendersLbl";
            this.VendersLbl.Size = new System.Drawing.Size(92, 25);
            this.VendersLbl.TabIndex = 0;
            this.VendersLbl.Text = "Venders";
            // 
            // NameLbl
            // 
            this.NameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.Black;
            this.NameLbl.Location = new System.Drawing.Point(137, 73);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 16);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // VenderName
            // 
            this.VenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VenderName.Location = new System.Drawing.Point(189, 73);
            this.VenderName.Name = "VenderName";
            this.VenderName.Size = new System.Drawing.Size(145, 20);
            this.VenderName.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(340, 73);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(49, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // vendersBindingSource
            // 
            this.vendersBindingSource.DataMember = "Venders";
            // 
            // UpdateVenders
            // 
            this.UpdateVenders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateVenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateVenders.Location = new System.Drawing.Point(354, 347);
            this.UpdateVenders.Name = "UpdateVenders";
            this.UpdateVenders.Size = new System.Drawing.Size(85, 30);
            this.UpdateVenders.TabIndex = 5;
            this.UpdateVenders.Text = "Update";
            this.UpdateVenders.UseVisualStyleBackColor = true;
            this.UpdateVenders.Click += new System.EventHandler(this.UpdateVenders_Click);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 412);
            this.Controls.Add(this.UpdateVenders);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.VenderName);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.VendersLbl);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VendersLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox VenderName;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UpdateVenders;
    }
}