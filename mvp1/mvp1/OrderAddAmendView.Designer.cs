namespace MVP.OrderAddAmend.View
{
    partial class OrderAddAmendView
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
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.OrderRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.TextBox();
            this.Item = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.UnitCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHeader.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.SystemColors.Info;
            this.txtHeader.Location = new System.Drawing.Point(72, 27);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ReadOnly = true;
            this.txtHeader.Size = new System.Drawing.Size(371, 59);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.TabStop = false;
            this.txtHeader.Text = "Order Add/Amend";
            this.txtHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderRef
            // 
            this.OrderRef.Location = new System.Drawing.Point(156, 119);
            this.OrderRef.Name = "OrderRef";
            this.OrderRef.Size = new System.Drawing.Size(100, 20);
            this.OrderRef.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Ref";
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(156, 172);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(100, 20);
            this.Customer.TabIndex = 4;
            // 
            // Item
            // 
            this.Item.Location = new System.Drawing.Point(156, 217);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(100, 20);
            this.Item.TabIndex = 5;
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(156, 276);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(100, 20);
            this.Qty.TabIndex = 6;
            // 
            // UnitCost
            // 
            this.UnitCost.Location = new System.Drawing.Point(156, 329);
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.Size = new System.Drawing.Size(100, 20);
            this.UnitCost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unit Cost";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OrderAddAmendView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 387);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnitCost);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderRef);
            this.Controls.Add(this.txtHeader);
            this.Name = "OrderAddAmendView";
            this.Text = "OrderAddAmendView";
            this.Load += new System.EventHandler(this.OrderAddAmendView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox OrderRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.TextBox Item;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.TextBox UnitCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}