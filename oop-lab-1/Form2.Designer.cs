namespace oop_lab_1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonSortAsc = new System.Windows.Forms.Button();
            this.buttonCreatCollection = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.listResoult = new System.Windows.Forms.ListBox();
            this.buttonSortDesc = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonISaT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер коллекции:";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSize.Location = new System.Drawing.Point(12, 48);
            this.textBoxSize.MaxLength = 2;
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(220, 31);
            this.textBoxSize.TabIndex = 1;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSortAsc
            // 
            this.buttonSortAsc.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSortAsc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSortAsc.FlatAppearance.BorderSize = 0;
            this.buttonSortAsc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonSortAsc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonSortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortAsc.Location = new System.Drawing.Point(521, 38);
            this.buttonSortAsc.Name = "buttonSortAsc";
            this.buttonSortAsc.Size = new System.Drawing.Size(22, 45);
            this.buttonSortAsc.TabIndex = 4;
            this.buttonSortAsc.Text = "↑";
            this.buttonSortAsc.UseVisualStyleBackColor = false;
            this.buttonSortAsc.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonCreatCollection
            // 
            this.buttonCreatCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreatCollection.Location = new System.Drawing.Point(12, 85);
            this.buttonCreatCollection.Name = "buttonCreatCollection";
            this.buttonCreatCollection.Size = new System.Drawing.Size(220, 55);
            this.buttonCreatCollection.TabIndex = 5;
            this.buttonCreatCollection.Text = "Сгенерировать коллекцию";
            this.buttonCreatCollection.UseVisualStyleBackColor = true;
            this.buttonCreatCollection.Click += new System.EventHandler(this.buttonCreatCollection_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new System.Drawing.Point(521, 133);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(49, 29);
            this.buttonMax.TabIndex = 7;
            this.buttonMax.Text = "max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonLINQ_Click);
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.ItemHeight = 20;
            this.listBoxCollection.Location = new System.Drawing.Point(248, 48);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(250, 144);
            this.listBoxCollection.TabIndex = 14;
            // 
            // listResoult
            // 
            this.listResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listResoult.FormattingEnabled = true;
            this.listResoult.ItemHeight = 20;
            this.listResoult.Location = new System.Drawing.Point(521, 168);
            this.listResoult.Name = "listResoult";
            this.listResoult.Size = new System.Drawing.Size(239, 24);
            this.listResoult.TabIndex = 15;
            // 
            // buttonSortDesc
            // 
            this.buttonSortDesc.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSortDesc.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSortDesc.FlatAppearance.BorderSize = 0;
            this.buttonSortDesc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buttonSortDesc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortDesc.Location = new System.Drawing.Point(548, 38);
            this.buttonSortDesc.Name = "buttonSortDesc";
            this.buttonSortDesc.Size = new System.Drawing.Size(22, 45);
            this.buttonSortDesc.TabIndex = 16;
            this.buttonSortDesc.Text = "↓";
            this.buttonSortDesc.UseVisualStyleBackColor = false;
            this.buttonSortDesc.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(576, 51);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 32);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMin.Location = new System.Drawing.Point(576, 133);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(49, 29);
            this.buttonMin.TabIndex = 17;
            this.buttonMin.Text = "min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonLINQ_Click);
            // 
            // buttonISaT
            // 
            this.buttonISaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonISaT.Location = new System.Drawing.Point(631, 133);
            this.buttonISaT.Name = "buttonISaT";
            this.buttonISaT.Size = new System.Drawing.Size(65, 29);
            this.buttonISaT.TabIndex = 18;
            this.buttonISaT.Text = "ИСиТ";
            this.buttonISaT.UseVisualStyleBackColor = true;
            this.buttonISaT.Click += new System.EventHandler(this.buttonLINQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Коллекция:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonISaT);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonSortDesc);
            this.Controls.Add(this.listResoult);
            this.Controls.Add(this.listBoxCollection);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonCreatCollection);
            this.Controls.Add(this.buttonSortAsc);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(786, 246);
            this.MinimumSize = new System.Drawing.Size(786, 246);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonSortAsc;
        private System.Windows.Forms.Button buttonCreatCollection;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.ListBox listResoult;
        private System.Windows.Forms.Button buttonSortDesc;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonISaT;
        private System.Windows.Forms.Label label2;
    }
}