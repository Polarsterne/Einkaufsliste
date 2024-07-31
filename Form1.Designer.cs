namespace Einkaufsliste
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMarkAsDone = new System.Windows.Forms.Button();
            this.textBoxNewItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 29;
            this.listBoxItems.Location = new System.Drawing.Point(29, 134);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(456, 323);
            this.listBoxItems.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(300, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMarkAsDone
            // 
            this.buttonMarkAsDone.Location = new System.Drawing.Point(29, 494);
            this.buttonMarkAsDone.Name = "buttonMarkAsDone";
            this.buttonMarkAsDone.Size = new System.Drawing.Size(201, 56);
            this.buttonMarkAsDone.TabIndex = 2;
            this.buttonMarkAsDone.Text = "erledigt";
            this.buttonMarkAsDone.UseVisualStyleBackColor = true;
            this.buttonMarkAsDone.Click += new System.EventHandler(this.buttonMarkAsDone_Click);
            // 
            // textBoxNewItem
            // 
            this.textBoxNewItem.Location = new System.Drawing.Point(29, 81);
            this.textBoxNewItem.Name = "textBoxNewItem";
            this.textBoxNewItem.Size = new System.Drawing.Size(233, 22);
            this.textBoxNewItem.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 574);
            this.Controls.Add(this.textBoxNewItem);
            this.Controls.Add(this.buttonMarkAsDone);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Einkaufsliste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMarkAsDone;
        private System.Windows.Forms.TextBox textBoxNewItem;
    }
}

