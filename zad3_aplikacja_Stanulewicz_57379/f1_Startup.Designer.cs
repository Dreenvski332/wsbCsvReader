namespace zad3_aplikacja_Stanulewicz_57379
{
    partial class f1_Startup
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
            this.f1_startUpButton = new System.Windows.Forms.Button();
            this.f1_startUpTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // f1_startUpButton
            // 
            this.f1_startUpButton.Location = new System.Drawing.Point(28, 197);
            this.f1_startUpButton.Name = "f1_startUpButton";
            this.f1_startUpButton.Size = new System.Drawing.Size(240, 90);
            this.f1_startUpButton.TabIndex = 1;
            this.f1_startUpButton.Text = "Rozpocznij";
            this.f1_startUpButton.UseVisualStyleBackColor = true;
            this.f1_startUpButton.Click += new System.EventHandler(this.f1_startUpButton_Click);
            // 
            // f1_startUpTextbox
            // 
            this.f1_startUpTextbox.Location = new System.Drawing.Point(28, 27);
            this.f1_startUpTextbox.Multiline = true;
            this.f1_startUpTextbox.Name = "f1_startUpTextbox";
            this.f1_startUpTextbox.ReadOnly = true;
            this.f1_startUpTextbox.Size = new System.Drawing.Size(240, 79);
            this.f1_startUpTextbox.TabIndex = 2;
            this.f1_startUpTextbox.Text = "Zadanie z LINQ i wczytania pliku CSV, naciśnij przycisk \"Rozpocznij\" aby przejść " +
    "do zadania.";
            this.f1_startUpTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // f1_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 318);
            this.Controls.Add(this.f1_startUpTextbox);
            this.Controls.Add(this.f1_startUpButton);
            this.Name = "f1_Startup";
            this.Text = "Zadanie 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button f1_startUpButton;
        private System.Windows.Forms.TextBox f1_startUpTextbox;
    }
}

