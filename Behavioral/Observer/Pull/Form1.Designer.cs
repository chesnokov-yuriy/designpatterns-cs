namespace Observer
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
                        this.runButton = new System.Windows.Forms.Button();
                        this.stopButton = new System.Windows.Forms.Button();
                        this.utcLabel = new System.Windows.Forms.Label();
                        this.japanLabel = new System.Windows.Forms.Label();
                        this.localLabel = new System.Windows.Forms.Label();
                        this.SuspendLayout();
                        // 
                        // runButton
                        // 
                        this.runButton.Location = new System.Drawing.Point(23, 26);
                        this.runButton.Name = "runButton";
                        this.runButton.Size = new System.Drawing.Size(75, 23);
                        this.runButton.TabIndex = 0;
                        this.runButton.Text = "run";
                        this.runButton.UseVisualStyleBackColor = true;
                        this.runButton.Click += new System.EventHandler(this.runButton_Click);
                        // 
                        // stopButton
                        // 
                        this.stopButton.Enabled = false;
                        this.stopButton.Location = new System.Drawing.Point(23, 55);
                        this.stopButton.Name = "stopButton";
                        this.stopButton.Size = new System.Drawing.Size(75, 23);
                        this.stopButton.TabIndex = 1;
                        this.stopButton.Text = "stop";
                        this.stopButton.UseVisualStyleBackColor = true;
                        this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
                        // 
                        // utcLabel
                        // 
                        this.utcLabel.AutoSize = true;
                        this.utcLabel.Location = new System.Drawing.Point(129, 26);
                        this.utcLabel.Name = "utcLabel";
                        this.utcLabel.Size = new System.Drawing.Size(29, 13);
                        this.utcLabel.TabIndex = 2;
                        this.utcLabel.Text = "UTC";
                        // 
                        // japanLabel
                        // 
                        this.japanLabel.AutoSize = true;
                        this.japanLabel.Location = new System.Drawing.Point(122, 65);
                        this.japanLabel.Name = "japanLabel";
                        this.japanLabel.Size = new System.Drawing.Size(36, 13);
                        this.japanLabel.TabIndex = 3;
                        this.japanLabel.Text = "Japan";
                        // 
                        // localLabel
                        // 
                        this.localLabel.AutoSize = true;
                        this.localLabel.Location = new System.Drawing.Point(129, 45);
                        this.localLabel.Name = "localLabel";
                        this.localLabel.Size = new System.Drawing.Size(29, 13);
                        this.localLabel.TabIndex = 4;
                        this.localLabel.Text = "local";
                        // 
                        // Form1
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(266, 113);
                        this.Controls.Add(this.localLabel);
                        this.Controls.Add(this.japanLabel);
                        this.Controls.Add(this.utcLabel);
                        this.Controls.Add(this.stopButton);
                        this.Controls.Add(this.runButton);
                        this.MaximizeBox = false;
                        this.Name = "Form1";
                        this.Text = "Observer";
                        this.ResumeLayout(false);
                        this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Button runButton;
                private System.Windows.Forms.Button stopButton;
                private System.Windows.Forms.Label utcLabel;
                private System.Windows.Forms.Label japanLabel;
                private System.Windows.Forms.Label localLabel;
        }
}

