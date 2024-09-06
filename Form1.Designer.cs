partial class Form1
{
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        
        // label1
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(142, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Temperatura da CPU:";
        
        // label2
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 35);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(96, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "Uso da CPU:";
        
        // label3
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 60);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(96, 15);
        this.label3.TabIndex = 2;
        this.label3.Text = "Placa Mãe:";
        
        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 81);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.Text = "Monitor de CPU";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
