
namespace CopyNewer.WinForms
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
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(12, 12);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(143, 25);
            this.buttonSource.TabIndex = 0;
            this.buttonSource.Text = "Source folder";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.button_Click_SourceSelect);
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(12, 43);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(143, 25);
            this.buttonDestination.TabIndex = 0;
            this.buttonDestination.Text = "Destination folder";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.button_Click_DestinationSelect);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(161, 12);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(484, 25);
            this.textBoxSource.TabIndex = 1;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(161, 43);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(484, 25);
            this.textBoxDestination.TabIndex = 1;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.textBoxDestination_TextChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(12, 74);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(633, 37);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "Copy Files";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.button_Click_Copy);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files copied:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonDestination);
            this.Controls.Add(this.buttonSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

