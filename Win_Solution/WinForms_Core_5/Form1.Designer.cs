
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUseDelegate = new System.Windows.Forms.Button();
            this.btnUseBuiltin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUseDelegate
            // 
            this.btnUseDelegate.Location = new System.Drawing.Point(123, 92);
            this.btnUseDelegate.Name = "btnUseDelegate";
            this.btnUseDelegate.Size = new System.Drawing.Size(155, 34);
            this.btnUseDelegate.TabIndex = 0;
            this.btnUseDelegate.Text = "Use Delegate";
            this.btnUseDelegate.UseVisualStyleBackColor = true;
            this.btnUseDelegate.Click += new System.EventHandler(this.btnUseDelegate_Click);
            // 
            // btnUseBuiltin
            // 
            this.btnUseBuiltin.Location = new System.Drawing.Point(326, 91);
            this.btnUseBuiltin.Name = "btnUseBuiltin";
            this.btnUseBuiltin.Size = new System.Drawing.Size(129, 34);
            this.btnUseBuiltin.TabIndex = 1;
            this.btnUseBuiltin.Text = "Use Built-in";
            this.btnUseBuiltin.UseVisualStyleBackColor = true;
            this.btnUseBuiltin.Click += new System.EventHandler(this.btnUseBuiltin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUseBuiltin);
            this.Controls.Add(this.btnUseDelegate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUseDelegate;
        private System.Windows.Forms.Button btnUseBuiltin;
    }
}

