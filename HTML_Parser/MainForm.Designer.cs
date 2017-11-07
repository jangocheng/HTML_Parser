namespace HTML_Parser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTitles = new System.Windows.Forms.ListBox();
            this.startPointLabel = new System.Windows.Forms.Label();
            this.endPointLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // listTitles
            // 
            this.listTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTitles.FormattingEnabled = true;
            this.listTitles.Location = new System.Drawing.Point(12, 12);
            this.listTitles.Name = "listTitles";
            this.listTitles.Size = new System.Drawing.Size(211, 238);
            this.listTitles.TabIndex = 0;
            // 
            // startPointLabel
            // 
            this.startPointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPointLabel.AutoSize = true;
            this.startPointLabel.Location = new System.Drawing.Point(229, 12);
            this.startPointLabel.Name = "startPointLabel";
            this.startPointLabel.Size = new System.Drawing.Size(56, 13);
            this.startPointLabel.TabIndex = 1;
            this.startPointLabel.Text = "Start Point";
            // 
            // endPointLabel
            // 
            this.endPointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endPointLabel.AutoSize = true;
            this.endPointLabel.Location = new System.Drawing.Point(229, 62);
            this.endPointLabel.Name = "endPointLabel";
            this.endPointLabel.Size = new System.Drawing.Size(53, 13);
            this.endPointLabel.TabIndex = 2;
            this.endPointLabel.Text = "End Point";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(232, 117);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endButton
            // 
            this.endButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endButton.Location = new System.Drawing.Point(232, 159);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 4;
            this.endButton.Text = "Stop";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // numericStart
            // 
            this.numericStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericStart.Location = new System.Drawing.Point(232, 28);
            this.numericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(98, 20);
            this.numericStart.TabIndex = 5;
            this.numericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericEnd.Location = new System.Drawing.Point(232, 78);
            this.numericEnd.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(101, 20);
            this.numericEnd.TabIndex = 6;
            this.numericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 320);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endPointLabel);
            this.Controls.Add(this.startPointLabel);
            this.Controls.Add(this.listTitles);
            this.Name = "MainForm";
            this.Text = "HTML Parser";
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTitles;
        private System.Windows.Forms.Label startPointLabel;
        private System.Windows.Forms.Label endPointLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
    }
}

