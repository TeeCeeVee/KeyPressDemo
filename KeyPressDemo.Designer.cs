namespace KeyPressApp
{
    partial class KeyPressDemo
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
            this.LblOnlyNumbers = new System.Windows.Forms.Label();
            this.TxtOnlyNumbers = new System.Windows.Forms.TextBox();
            this.TxtBoxAnyKey = new System.Windows.Forms.GroupBox();
            this.TxtAnyKey = new System.Windows.Forms.TextBox();
            this.TxtBoxAnyKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblOnlyNumbers
            // 
            this.LblOnlyNumbers.AutoSize = true;
            this.LblOnlyNumbers.Location = new System.Drawing.Point(144, 220);
            this.LblOnlyNumbers.Name = "LblOnlyNumbers";
            this.LblOnlyNumbers.Size = new System.Drawing.Size(138, 16);
            this.LblOnlyNumbers.TabIndex = 2;
            this.LblOnlyNumbers.Text = "Only Numbers Please";
            // 
            // TxtOnlyNumbers
            // 
            this.TxtOnlyNumbers.Location = new System.Drawing.Point(147, 267);
            this.TxtOnlyNumbers.Name = "TxtOnlyNumbers";
            this.TxtOnlyNumbers.Size = new System.Drawing.Size(132, 22);
            this.TxtOnlyNumbers.TabIndex = 3;
            this.TxtOnlyNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOnlyNumbers_KeyPress);
            // 
            // TxtBoxAnyKey
            // 
            this.TxtBoxAnyKey.Controls.Add(this.TxtAnyKey);
            this.TxtBoxAnyKey.Location = new System.Drawing.Point(128, 62);
            this.TxtBoxAnyKey.Name = "TxtBoxAnyKey";
            this.TxtBoxAnyKey.Size = new System.Drawing.Size(200, 100);
            this.TxtBoxAnyKey.TabIndex = 4;
            this.TxtBoxAnyKey.TabStop = false;
            this.TxtBoxAnyKey.Text = "Press Any Key";
            // 
            // TxtAnyKey
            // 
            this.TxtAnyKey.Location = new System.Drawing.Point(38, 31);
            this.TxtAnyKey.Name = "TxtAnyKey";
            this.TxtAnyKey.Size = new System.Drawing.Size(100, 22);
            this.TxtAnyKey.TabIndex = 0;
            this.TxtAnyKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnyKey_KeyPress);
            // 
            // KeyPressDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxAnyKey);
            this.Controls.Add(this.TxtOnlyNumbers);
            this.Controls.Add(this.LblOnlyNumbers);
            this.Name = "KeyPressDemo";
            this.Text = "Key Press Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeyPressDemo_FormClosing);
            this.TxtBoxAnyKey.ResumeLayout(false);
            this.TxtBoxAnyKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblOnlyNumbers;
        private System.Windows.Forms.TextBox TxtOnlyNumbers;
        private System.Windows.Forms.GroupBox TxtBoxAnyKey;
        private System.Windows.Forms.TextBox TxtAnyKey;
    }
}

