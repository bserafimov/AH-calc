namespace Auction_House_Flip_Calc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalcBtn = new System.Windows.Forms.Button();
            this.PurchBox = new System.Windows.Forms.TextBox();
            this.SaleBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BreakEvenLabel = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfitPerBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.penapicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.penapicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcBtn.Location = new System.Drawing.Point(0, 219);
            this.CalcBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(444, 30);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calculate!";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PurchBox
            // 
            this.PurchBox.Location = new System.Drawing.Point(106, 113);
            this.PurchBox.Margin = new System.Windows.Forms.Padding(2);
            this.PurchBox.Name = "PurchBox";
            this.PurchBox.Size = new System.Drawing.Size(68, 20);
            this.PurchBox.TabIndex = 1;
            this.PurchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PurchBox.Enter += new System.EventHandler(this.PurchBox_Enter);
            this.PurchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PurchBox_MouseDown);
            // 
            // SaleBox
            // 
            this.SaleBox.Location = new System.Drawing.Point(106, 146);
            this.SaleBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaleBox.Name = "SaleBox";
            this.SaleBox.Size = new System.Drawing.Size(68, 20);
            this.SaleBox.TabIndex = 2;
            this.SaleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaleBox.Enter += new System.EventHandler(this.SaleBox_Enter_1);
            this.SaleBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaleBox_MouseDown);
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(195, 146);
            this.TotalBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(121, 20);
            this.TotalBox.TabIndex = 3;
            this.TotalBox.TabStop = false;
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sale price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(318, 148);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Break even price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BreakEvenLabel
            // 
            this.BreakEvenLabel.AutoSize = true;
            this.BreakEvenLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BreakEvenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BreakEvenLabel.Location = new System.Drawing.Point(106, 177);
            this.BreakEvenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BreakEvenLabel.MinimumSize = new System.Drawing.Size(20, 0);
            this.BreakEvenLabel.Name = "BreakEvenLabel";
            this.BreakEvenLabel.Size = new System.Drawing.Size(20, 20);
            this.BreakEvenLabel.TabIndex = 3;
            this.BreakEvenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quantity
            // 
            this.Quantity.HideSelection = false;
            this.Quantity.Location = new System.Drawing.Point(106, 81);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(68, 20);
            this.Quantity.TabIndex = 4;
            this.Quantity.Text = "1";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfitPerBox
            // 
            this.ProfitPerBox.Location = new System.Drawing.Point(195, 113);
            this.ProfitPerBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProfitPerBox.Name = "ProfitPerBox";
            this.ProfitPerBox.ReadOnly = true;
            this.ProfitPerBox.Size = new System.Drawing.Size(121, 20);
            this.ProfitPerBox.TabIndex = 6;
            this.ProfitPerBox.TabStop = false;
            this.ProfitPerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Profit per";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // penapicbox
            // 
            this.penapicbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penapicbox.Image = ((System.Drawing.Image)(resources.GetObject("penapicbox.Image")));
            this.penapicbox.Location = new System.Drawing.Point(140, 256);
            this.penapicbox.Margin = new System.Windows.Forms.Padding(2);
            this.penapicbox.Name = "penapicbox";
            this.penapicbox.Padding = new System.Windows.Forms.Padding(2);
            this.penapicbox.Size = new System.Drawing.Size(164, 164);
            this.penapicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.penapicbox.TabIndex = 8;
            this.penapicbox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 428);
            this.Controls.Add(this.penapicbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProfitPerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.BreakEvenLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.SaleBox);
            this.Controls.Add(this.PurchBox);
            this.Controls.Add(this.CalcBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 467);
            this.MinimumSize = new System.Drawing.Size(459, 467);
            this.Name = "Form1";
            this.Text = "AH flip calc";
            ((System.ComponentModel.ISupportInitialize)(this.penapicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox PurchBox;
        private System.Windows.Forms.TextBox SaleBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BreakEvenLabel;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProfitPerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox penapicbox;
    }
}

