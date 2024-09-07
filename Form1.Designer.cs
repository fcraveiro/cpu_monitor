partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBoxInfo;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.textBoxInfo = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBoxInfo
        // 
        this.textBoxInfo.Location = new System.Drawing.Point(12, 12);
        this.textBoxInfo.Multiline = true;
        this.textBoxInfo.Name = "textBoxInfo";
        this.textBoxInfo.ReadOnly = true;
        this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxInfo.Size = new System.Drawing.Size(460, 337);
        this.textBoxInfo.TabIndex = 0;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 361);
        this.Controls.Add(this.textBoxInfo);
        this.Name = "Form1";
        this.Text = "Monitor de Hardware";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}