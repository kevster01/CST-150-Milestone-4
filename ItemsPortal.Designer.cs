namespace Cst150Project
{
    partial class ItemsPortal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsPortal));
            this.ItemsExit_lbl = new System.Windows.Forms.Label();
            this.ItemsPortalLogout_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ItemsCategories_cBox = new System.Windows.Forms.ComboBox();
            this.ItemsManager_lbl = new System.Windows.Forms.Label();
            this.ItemQuantity_lbl = new System.Windows.Forms.Label();
            this.ItemQuantity_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemName_lbl = new System.Windows.Forms.Label();
            this.ItemName_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemId_lbl = new System.Windows.Forms.Label();
            this.ItemId_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ItemPrice_lbl = new System.Windows.Forms.Label();
            this.ItemPrice_txt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ItemCategory_lbl = new System.Windows.Forms.Label();
            this.ItemsClear_lbl = new System.Windows.Forms.Label();
            this.AddItem_btn = new System.Windows.Forms.Button();
            this.RemoveItem_btn = new System.Windows.Forms.Button();
            this.EditItem_btn = new System.Windows.Forms.Button();
            this.Back2Admin_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Forward2Categories_lbl = new System.Windows.Forms.LinkLabel();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsExit_lbl
            // 
            this.ItemsExit_lbl.AutoSize = true;
            this.ItemsExit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsExit_lbl.Location = new System.Drawing.Point(1564, 11);
            this.ItemsExit_lbl.Name = "ItemsExit_lbl";
            this.ItemsExit_lbl.Size = new System.Drawing.Size(31, 29);
            this.ItemsExit_lbl.TabIndex = 0;
            this.ItemsExit_lbl.Text = "X";
            this.ItemsExit_lbl.Click += new System.EventHandler(this.ItemsExit_lbl_Click);
            // 
            // ItemsPortalLogout_btn
            // 
            this.ItemsPortalLogout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPortalLogout_btn.Location = new System.Drawing.Point(167, 622);
            this.ItemsPortalLogout_btn.Name = "ItemsPortalLogout_btn";
            this.ItemsPortalLogout_btn.Size = new System.Drawing.Size(166, 67);
            this.ItemsPortalLogout_btn.TabIndex = 3;
            this.ItemsPortalLogout_btn.Text = "Logout";
            this.ItemsPortalLogout_btn.UseVisualStyleBackColor = true;
            this.ItemsPortalLogout_btn.Click += new System.EventHandler(this.ItemsPortalLogout_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ItemsCategories_cBox
            // 
            this.ItemsCategories_cBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsCategories_cBox.FormattingEnabled = true;
            this.ItemsCategories_cBox.Location = new System.Drawing.Point(195, 405);
            this.ItemsCategories_cBox.Name = "ItemsCategories_cBox";
            this.ItemsCategories_cBox.Size = new System.Drawing.Size(240, 37);
            this.ItemsCategories_cBox.TabIndex = 4;
            this.ItemsCategories_cBox.Text = "Select Category";
            // 
            // ItemsManager_lbl
            // 
            this.ItemsManager_lbl.AutoSize = true;
            this.ItemsManager_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsManager_lbl.Location = new System.Drawing.Point(579, 9);
            this.ItemsManager_lbl.Name = "ItemsManager_lbl";
            this.ItemsManager_lbl.Size = new System.Drawing.Size(480, 64);
            this.ItemsManager_lbl.TabIndex = 5;
            this.ItemsManager_lbl.Text = "Manage Products";
            // 
            // ItemQuantity_lbl
            // 
            this.ItemQuantity_lbl.AutoSize = true;
            this.ItemQuantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity_lbl.Location = new System.Drawing.Point(9, 289);
            this.ItemQuantity_lbl.Name = "ItemQuantity_lbl";
            this.ItemQuantity_lbl.Size = new System.Drawing.Size(170, 40);
            this.ItemQuantity_lbl.TabIndex = 6;
            this.ItemQuantity_lbl.Text = "Quantity:";
            // 
            // ItemQuantity_txt
            // 
            this.ItemQuantity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity_txt.Location = new System.Drawing.Point(196, 296);
            this.ItemQuantity_txt.Name = "ItemQuantity_txt";
            this.ItemQuantity_txt.Size = new System.Drawing.Size(239, 35);
            this.ItemQuantity_txt.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(196, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 2);
            this.panel1.TabIndex = 8;
            // 
            // ItemName_lbl
            // 
            this.ItemName_lbl.AutoSize = true;
            this.ItemName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_lbl.Location = new System.Drawing.Point(9, 234);
            this.ItemName_lbl.Name = "ItemName_lbl";
            this.ItemName_lbl.Size = new System.Drawing.Size(139, 40);
            this.ItemName_lbl.TabIndex = 6;
            this.ItemName_lbl.Text = "Name: ";
            // 
            // ItemName_txt
            // 
            this.ItemName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_txt.Location = new System.Drawing.Point(196, 246);
            this.ItemName_txt.Name = "ItemName_txt";
            this.ItemName_txt.Size = new System.Drawing.Size(239, 35);
            this.ItemName_txt.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(196, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 2);
            this.panel2.TabIndex = 8;
            // 
            // ItemId_lbl
            // 
            this.ItemId_lbl.AutoSize = true;
            this.ItemId_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemId_lbl.Location = new System.Drawing.Point(9, 179);
            this.ItemId_lbl.Name = "ItemId_lbl";
            this.ItemId_lbl.Size = new System.Drawing.Size(65, 40);
            this.ItemId_lbl.TabIndex = 6;
            this.ItemId_lbl.Text = "ID:";
            // 
            // ItemId_txt
            // 
            this.ItemId_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemId_txt.Location = new System.Drawing.Point(197, 186);
            this.ItemId_txt.Name = "ItemId_txt";
            this.ItemId_txt.Size = new System.Drawing.Size(239, 35);
            this.ItemId_txt.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(197, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 2);
            this.panel3.TabIndex = 8;
            // 
            // ItemPrice_lbl
            // 
            this.ItemPrice_lbl.AutoSize = true;
            this.ItemPrice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice_lbl.Location = new System.Drawing.Point(9, 339);
            this.ItemPrice_lbl.Name = "ItemPrice_lbl";
            this.ItemPrice_lbl.Size = new System.Drawing.Size(115, 40);
            this.ItemPrice_lbl.TabIndex = 6;
            this.ItemPrice_lbl.Text = "Price:";
            // 
            // ItemPrice_txt
            // 
            this.ItemPrice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice_txt.Location = new System.Drawing.Point(196, 351);
            this.ItemPrice_txt.Name = "ItemPrice_txt";
            this.ItemPrice_txt.Size = new System.Drawing.Size(239, 35);
            this.ItemPrice_txt.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(197, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 2);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(195, 383);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 2);
            this.panel5.TabIndex = 8;
            // 
            // ItemCategory_lbl
            // 
            this.ItemCategory_lbl.AutoSize = true;
            this.ItemCategory_lbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ItemCategory_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCategory_lbl.Location = new System.Drawing.Point(9, 405);
            this.ItemCategory_lbl.Name = "ItemCategory_lbl";
            this.ItemCategory_lbl.Size = new System.Drawing.Size(182, 40);
            this.ItemCategory_lbl.TabIndex = 6;
            this.ItemCategory_lbl.Text = "Category:";
            // 
            // ItemsClear_lbl
            // 
            this.ItemsClear_lbl.AutoSize = true;
            this.ItemsClear_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsClear_lbl.Location = new System.Drawing.Point(15, 451);
            this.ItemsClear_lbl.Name = "ItemsClear_lbl";
            this.ItemsClear_lbl.Size = new System.Drawing.Size(59, 25);
            this.ItemsClear_lbl.TabIndex = 9;
            this.ItemsClear_lbl.Text = "Clear";
            this.ItemsClear_lbl.Click += new System.EventHandler(this.ItemsClear_lbl_Click);
            // 
            // AddItem_btn
            // 
            this.AddItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_btn.Location = new System.Drawing.Point(83, 494);
            this.AddItem_btn.Name = "AddItem_btn";
            this.AddItem_btn.Size = new System.Drawing.Size(84, 41);
            this.AddItem_btn.TabIndex = 10;
            this.AddItem_btn.Text = "Add";
            this.AddItem_btn.UseVisualStyleBackColor = true;
            this.AddItem_btn.Click += new System.EventHandler(this.AddItem_btn_Click);
            // 
            // RemoveItem_btn
            // 
            this.RemoveItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem_btn.Location = new System.Drawing.Point(195, 494);
            this.RemoveItem_btn.Name = "RemoveItem_btn";
            this.RemoveItem_btn.Size = new System.Drawing.Size(85, 41);
            this.RemoveItem_btn.TabIndex = 10;
            this.RemoveItem_btn.Text = "Remove";
            this.RemoveItem_btn.UseVisualStyleBackColor = true;
            this.RemoveItem_btn.Click += new System.EventHandler(this.RemoveItem_btn_Click);
            // 
            // EditItem_btn
            // 
            this.EditItem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItem_btn.Location = new System.Drawing.Point(313, 494);
            this.EditItem_btn.Name = "EditItem_btn";
            this.EditItem_btn.Size = new System.Drawing.Size(85, 41);
            this.EditItem_btn.TabIndex = 10;
            this.EditItem_btn.Text = "Edit";
            this.EditItem_btn.UseVisualStyleBackColor = true;
            this.EditItem_btn.Click += new System.EventHandler(this.EditItem_btn_Click);
            // 
            // Back2Admin_btn
            // 
            this.Back2Admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back2Admin_btn.Location = new System.Drawing.Point(167, 558);
            this.Back2Admin_btn.Name = "Back2Admin_btn";
            this.Back2Admin_btn.Size = new System.Drawing.Size(166, 58);
            this.Back2Admin_btn.TabIndex = 11;
            this.Back2Admin_btn.Text = "Back";
            this.Back2Admin_btn.UseVisualStyleBackColor = true;
            this.Back2Admin_btn.Click += new System.EventHandler(this.Back2Admin_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // Forward2Categories_lbl
            // 
            this.Forward2Categories_lbl.AutoSize = true;
            this.Forward2Categories_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward2Categories_lbl.LinkColor = System.Drawing.Color.Black;
            this.Forward2Categories_lbl.Location = new System.Drawing.Point(10, 9);
            this.Forward2Categories_lbl.Name = "Forward2Categories_lbl";
            this.Forward2Categories_lbl.Size = new System.Drawing.Size(166, 33);
            this.Forward2Categories_lbl.TabIndex = 15;
            this.Forward2Categories_lbl.TabStop = true;
            this.Forward2Categories_lbl.Text = "Categories";
            this.Forward2Categories_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forward2Categories_lbl_LinkClicked);
            // 
            // ItemDGV
            // 
            this.ItemDGV.AllowUserToAddRows = false;
            this.ItemDGV.AllowUserToDeleteRows = false;
            this.ItemDGV.AllowUserToResizeColumns = false;
            this.ItemDGV.AllowUserToResizeRows = false;
            this.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemDGV.ColumnHeadersHeight = 34;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemDGV.EnableHeadersVisualStyles = false;
            this.ItemDGV.GridColor = System.Drawing.SystemColors.GrayText;
            this.ItemDGV.Location = new System.Drawing.Point(496, 176);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemDGV.RowHeadersVisible = false;
            this.ItemDGV.RowHeadersWidth = 62;
            this.ItemDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ItemDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(1099, 637);
            this.ItemDGV.TabIndex = 30;
            this.ItemDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDGV_CellContentClick);
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(1085, 138);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(510, 30);
            this.search_txt.TabIndex = 31;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(991, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search:";
            // 
            // ItemsPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1607, 825);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.ItemDGV);
            this.Controls.Add(this.Forward2Categories_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back2Admin_btn);
            this.Controls.Add(this.EditItem_btn);
            this.Controls.Add(this.RemoveItem_btn);
            this.Controls.Add(this.AddItem_btn);
            this.Controls.Add(this.ItemsClear_lbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemId_txt);
            this.Controls.Add(this.ItemId_lbl);
            this.Controls.Add(this.ItemName_txt);
            this.Controls.Add(this.ItemName_lbl);
            this.Controls.Add(this.ItemPrice_txt);
            this.Controls.Add(this.ItemCategory_lbl);
            this.Controls.Add(this.ItemPrice_lbl);
            this.Controls.Add(this.ItemQuantity_txt);
            this.Controls.Add(this.ItemQuantity_lbl);
            this.Controls.Add(this.ItemsManager_lbl);
            this.Controls.Add(this.ItemsCategories_cBox);
            this.Controls.Add(this.ItemsPortalLogout_btn);
            this.Controls.Add(this.ItemsExit_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemsPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemsPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsExit_lbl;
        private System.Windows.Forms.Button ItemsPortalLogout_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox ItemsCategories_cBox;
        private System.Windows.Forms.Label ItemsManager_lbl;
        private System.Windows.Forms.Label ItemQuantity_lbl;
        private System.Windows.Forms.TextBox ItemQuantity_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ItemName_lbl;
        private System.Windows.Forms.TextBox ItemName_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ItemId_lbl;
        private System.Windows.Forms.TextBox ItemId_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ItemPrice_lbl;
        private System.Windows.Forms.TextBox ItemPrice_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ItemCategory_lbl;
        private System.Windows.Forms.Label ItemsClear_lbl;
        private System.Windows.Forms.Button AddItem_btn;
        private System.Windows.Forms.Button RemoveItem_btn;
        private System.Windows.Forms.Button EditItem_btn;
        private System.Windows.Forms.Button Back2Admin_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Forward2Categories_lbl;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label2;
    }
}