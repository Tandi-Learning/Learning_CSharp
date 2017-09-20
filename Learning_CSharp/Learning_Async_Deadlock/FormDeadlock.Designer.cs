namespace Learning_Async_Deadlock
{
    partial class FormDeadlock
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
            this.components = new System.ComponentModel.Container();
            this.btnGetName = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBlockName = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetName
            // 
            this.btnGetName.Location = new System.Drawing.Point(12, 22);
            this.btnGetName.Name = "btnGetName";
            this.btnGetName.Size = new System.Drawing.Size(75, 23);
            this.btnGetName.TabIndex = 0;
            this.btnGetName.Text = "Get Name";
            this.btnGetName.UseVisualStyleBackColor = true;
            this.btnGetName.Click += new System.EventHandler(this.btnGetName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(107, 24);
            this.lblName.MaximumSize = new System.Drawing.Size(200, 20);
            this.lblName.MinimumSize = new System.Drawing.Size(200, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 20);
            this.lblName.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBlockName
            // 
            this.lblBlockName.AutoSize = true;
            this.lblBlockName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBlockName.Location = new System.Drawing.Point(107, 68);
            this.lblBlockName.MaximumSize = new System.Drawing.Size(200, 20);
            this.lblBlockName.MinimumSize = new System.Drawing.Size(200, 20);
            this.lblBlockName.Name = "lblBlockName";
            this.lblBlockName.Size = new System.Drawing.Size(200, 20);
            this.lblBlockName.TabIndex = 3;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(12, 66);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // FormDeadlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 151);
            this.Controls.Add(this.lblBlockName);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGetName);
            this.Name = "FormDeadlock";
            this.Text = "Async Deadlock";
            this.Load += new System.EventHandler(this.FormDeadlock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBlockName;
        private System.Windows.Forms.Button btnBlock;
    }
}

