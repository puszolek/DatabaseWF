namespace DatabaseWF
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.TextBoxComment = new System.Windows.Forms.TextBox();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelComment = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listBoxId = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.listBoxComment = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(66, 12);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(100, 20);
            this.TextBoxValue.TabIndex = 0;
            // 
            // TextBoxComment
            // 
            this.TextBoxComment.Location = new System.Drawing.Point(66, 38);
            this.TextBoxComment.Name = "TextBoxComment";
            this.TextBoxComment.Size = new System.Drawing.Size(100, 20);
            this.TextBoxComment.TabIndex = 1;
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Location = new System.Drawing.Point(26, 15);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(34, 13);
            this.LabelValue.TabIndex = 2;
            this.LabelValue.Text = "Value";
            // 
            // LabelComment
            // 
            this.LabelComment.AutoSize = true;
            this.LabelComment.Location = new System.Drawing.Point(9, 41);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(51, 13);
            this.LabelComment.TabIndex = 3;
            this.LabelComment.Text = "Comment";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.Location = new System.Drawing.Point(205, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 47);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(286, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.Location = new System.Drawing.Point(367, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 47);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listBoxId
            // 
            this.listBoxId.FormattingEnabled = true;
            this.listBoxId.Location = new System.Drawing.Point(15, 74);
            this.listBoxId.Name = "listBoxId";
            this.listBoxId.Size = new System.Drawing.Size(93, 264);
            this.listBoxId.TabIndex = 7;
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.Location = new System.Drawing.Point(114, 74);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(120, 264);
            this.listBoxTime.TabIndex = 8;
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.Location = new System.Drawing.Point(241, 74);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(80, 264);
            this.listBoxValue.TabIndex = 9;
            // 
            // listBoxComment
            // 
            this.listBoxComment.FormattingEnabled = true;
            this.listBoxComment.Location = new System.Drawing.Point(328, 74);
            this.listBoxComment.Name = "listBoxComment";
            this.listBoxComment.Size = new System.Drawing.Size(147, 264);
            this.listBoxComment.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 359);
            this.Controls.Add(this.listBoxComment);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.LabelComment);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.TextBoxComment);
            this.Controls.Add(this.TextBoxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxValue;
        private System.Windows.Forms.TextBox TextBoxComment;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelComment;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listBoxId;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.ListBox listBoxComment;
    }
}

