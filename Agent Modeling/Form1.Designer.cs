namespace Agent_Modeling
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.lambda1UpDown = new System.Windows.Forms.NumericUpDown();
            this.lambda2UpDown = new System.Windows.Forms.NumericUpDown();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.modelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ1: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "λ2: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 322);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Error: ";
            // 
            // lambda1UpDown
            // 
            this.lambda1UpDown.DecimalPlaces = 2;
            this.lambda1UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lambda1UpDown.Location = new System.Drawing.Point(42, 7);
            this.lambda1UpDown.Name = "lambda1UpDown";
            this.lambda1UpDown.Size = new System.Drawing.Size(56, 20);
            this.lambda1UpDown.TabIndex = 5;
            // 
            // lambda2UpDown
            // 
            this.lambda2UpDown.DecimalPlaces = 2;
            this.lambda2UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lambda2UpDown.Location = new System.Drawing.Point(42, 32);
            this.lambda2UpDown.Name = "lambda2UpDown";
            this.lambda2UpDown.Size = new System.Drawing.Size(56, 20);
            this.lambda2UpDown.TabIndex = 6;
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(42, 58);
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(56, 20);
            this.nUpDown.TabIndex = 8;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(190, 9);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(225, 308);
            this.textBox.TabIndex = 9;
            this.textBox.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 153);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // modelButton
            // 
            this.modelButton.Location = new System.Drawing.Point(15, 193);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(75, 23);
            this.modelButton.TabIndex = 11;
            this.modelButton.Text = "Modeling";
            this.modelButton.UseVisualStyleBackColor = true;
            this.modelButton.Click += new System.EventHandler(this.modelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 357);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.lambda2UpDown);
            this.Controls.Add(this.lambda1UpDown);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lambda1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.NumericUpDown lambda1UpDown;
        private System.Windows.Forms.NumericUpDown lambda2UpDown;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button modelButton;
    }
}

