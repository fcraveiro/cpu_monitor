partial class Form1
{
    private System.Windows.Forms.Label label1; // Placa Mãe
    private System.Windows.Forms.Label label2; // Processador
    private System.Windows.Forms.Label label3; // Temperatura
    private System.Windows.Forms.Label label4; // Uso da CPU
    private System.Windows.Forms.Label label5; // Armazenamento

    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label(); // Placa Mãe
        this.label2 = new System.Windows.Forms.Label(); // Processador
        this.label3 = new System.Windows.Forms.Label(); // Temperatura
        this.label4 = new System.Windows.Forms.Label(); // Uso da CPU
        this.label5 = new System.Windows.Forms.Label(); // Armazenamento

        this.SuspendLayout();
        
        // label1 (Placa Mãe)
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(96, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Placa Mãe:";
        
        // label2 (Processador)
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 30);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(88, 15);
        this.label2.TabIndex = 1;
        this.label2.Text = "Processador:";
        
        // label3 (Temperatura)
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 51);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(142, 15);
        this.label3.TabIndex = 2;
        this.label3.Text = "Temperatura da CPU:";
        
        // label4 (Uso da CPU)
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(12, 72);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(96, 15);
        this.label4.TabIndex = 3;
        this.label4.Text = "Uso da CPU:";
        
        // label5 (Armazenamento)
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(12, 93);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(96, 15);
        this.label5.TabIndex = 4;
        this.label5.Text = "Armazenamento:";
        
        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 121);
        this.Controls.Add(this.label5); // Armazenamento
        this.Controls.Add(this.label4); // Uso da CPU
        this.Controls.Add(this.label3); // Temperatura
        this.Controls.Add(this.label2); // Processador
        this.Controls.Add(this.label1); // Placa Mãe
        this.Name = "Form1";
        this.Text = "Monitor de Hardware";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
