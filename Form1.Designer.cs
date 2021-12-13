namespace WindowsFormsApp1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DecimalPointButton = new System.Windows.Forms.Button();
            this.No0Button = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.No3Button = new System.Windows.Forms.Button();
            this.No2Button = new System.Windows.Forms.Button();
            this.No1Button = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.No6Button = new System.Windows.Forms.Button();
            this.No5Button = new System.Windows.Forms.Button();
            this.No4Button = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.No9Button = new System.Windows.Forms.Button();
            this.No8Button = new System.Windows.Forms.Button();
            this.No7Button = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(35, 21);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(337, 26);
            this.UserInputText.TabIndex = 1;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Location = new System.Drawing.Point(31, 64);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(341, 33);
            this.CalculationResultText.TabIndex = 2;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DecimalPointButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.No0Button, 1, 4);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.No3Button, 2, 3);
            this.ButtonsPanel.Controls.Add(this.No2Button, 1, 3);
            this.ButtonsPanel.Controls.Add(this.No1Button, 0, 3);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.No6Button, 2, 2);
            this.ButtonsPanel.Controls.Add(this.No5Button, 1, 2);
            this.ButtonsPanel.Controls.Add(this.No4Button, 0, 2);
            this.ButtonsPanel.Controls.Add(this.TimesButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.No9Button, 2, 1);
            this.ButtonsPanel.Controls.Add(this.No8Button, 1, 1);
            this.ButtonsPanel.Controls.Add(this.No7Button, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(35, 100);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(337, 300);
            this.ButtonsPanel.TabIndex = 3;
            this.ButtonsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonsPanel_Paint);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Location = new System.Drawing.Point(255, 243);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(79, 54);
            this.EqualsButton.TabIndex = 19;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DecimalPointButton
            // 
            this.DecimalPointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecimalPointButton.Location = new System.Drawing.Point(171, 243);
            this.DecimalPointButton.Name = "DecimalPointButton";
            this.DecimalPointButton.Size = new System.Drawing.Size(78, 54);
            this.DecimalPointButton.TabIndex = 18;
            this.DecimalPointButton.Text = ".";
            this.DecimalPointButton.UseVisualStyleBackColor = true;
            this.DecimalPointButton.Click += new System.EventHandler(this.DecimalPointButton_Click);
            // 
            // No0Button
            // 
            this.No0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No0Button.Location = new System.Drawing.Point(87, 243);
            this.No0Button.Name = "No0Button";
            this.No0Button.Size = new System.Drawing.Size(78, 54);
            this.No0Button.TabIndex = 17;
            this.No0Button.Text = "0";
            this.No0Button.UseVisualStyleBackColor = true;
            this.No0Button.Click += new System.EventHandler(this.No0Button_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(255, 183);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(79, 54);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // No3Button
            // 
            this.No3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No3Button.Location = new System.Drawing.Point(171, 183);
            this.No3Button.Name = "No3Button";
            this.No3Button.Size = new System.Drawing.Size(78, 54);
            this.No3Button.TabIndex = 14;
            this.No3Button.Text = "3";
            this.No3Button.UseVisualStyleBackColor = true;
            this.No3Button.Click += new System.EventHandler(this.No3Button_Click);
            // 
            // No2Button
            // 
            this.No2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No2Button.Location = new System.Drawing.Point(87, 183);
            this.No2Button.Name = "No2Button";
            this.No2Button.Size = new System.Drawing.Size(78, 54);
            this.No2Button.TabIndex = 13;
            this.No2Button.Text = "2";
            this.No2Button.UseVisualStyleBackColor = true;
            this.No2Button.Click += new System.EventHandler(this.No2Button_Click);
            // 
            // No1Button
            // 
            this.No1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No1Button.Location = new System.Drawing.Point(3, 183);
            this.No1Button.Name = "No1Button";
            this.No1Button.Size = new System.Drawing.Size(78, 54);
            this.No1Button.TabIndex = 12;
            this.No1Button.Text = "1";
            this.No1Button.UseVisualStyleBackColor = true;
            this.No1Button.Click += new System.EventHandler(this.No1Button_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(255, 123);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(79, 54);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // No6Button
            // 
            this.No6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No6Button.Location = new System.Drawing.Point(171, 123);
            this.No6Button.Name = "No6Button";
            this.No6Button.Size = new System.Drawing.Size(78, 54);
            this.No6Button.TabIndex = 10;
            this.No6Button.Text = "6";
            this.No6Button.UseVisualStyleBackColor = true;
            this.No6Button.Click += new System.EventHandler(this.No6Button_Click);
            // 
            // No5Button
            // 
            this.No5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No5Button.Location = new System.Drawing.Point(87, 123);
            this.No5Button.Name = "No5Button";
            this.No5Button.Size = new System.Drawing.Size(78, 54);
            this.No5Button.TabIndex = 9;
            this.No5Button.Text = "5";
            this.No5Button.UseVisualStyleBackColor = true;
            this.No5Button.Click += new System.EventHandler(this.No5Button_Click);
            // 
            // No4Button
            // 
            this.No4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No4Button.Location = new System.Drawing.Point(3, 123);
            this.No4Button.Name = "No4Button";
            this.No4Button.Size = new System.Drawing.Size(78, 54);
            this.No4Button.TabIndex = 8;
            this.No4Button.Text = "4";
            this.No4Button.UseVisualStyleBackColor = true;
            this.No4Button.Click += new System.EventHandler(this.No4Button_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimesButton.Location = new System.Drawing.Point(255, 63);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(79, 54);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "X";
            this.TimesButton.UseVisualStyleBackColor = true;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // No9Button
            // 
            this.No9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No9Button.Location = new System.Drawing.Point(171, 63);
            this.No9Button.Name = "No9Button";
            this.No9Button.Size = new System.Drawing.Size(78, 54);
            this.No9Button.TabIndex = 6;
            this.No9Button.Text = "9";
            this.No9Button.UseVisualStyleBackColor = true;
            this.No9Button.Click += new System.EventHandler(this.No9Button_Click);
            // 
            // No8Button
            // 
            this.No8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No8Button.Location = new System.Drawing.Point(87, 63);
            this.No8Button.Name = "No8Button";
            this.No8Button.Size = new System.Drawing.Size(78, 54);
            this.No8Button.TabIndex = 5;
            this.No8Button.Text = "8";
            this.No8Button.UseVisualStyleBackColor = true;
            this.No8Button.Click += new System.EventHandler(this.No8Button_Click);
            // 
            // No7Button
            // 
            this.No7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No7Button.Location = new System.Drawing.Point(3, 63);
            this.No7Button.Name = "No7Button";
            this.No7Button.Size = new System.Drawing.Size(78, 54);
            this.No7Button.TabIndex = 4;
            this.No7Button.Text = "7";
            this.No7Button.UseVisualStyleBackColor = true;
            this.No7Button.Click += new System.EventHandler(this.No7Button_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(255, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(79, 54);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "%";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(171, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(78, 54);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(78, 54);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(408, 424);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(430, 480);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DecimalPointButton;
        private System.Windows.Forms.Button No0Button;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button No3Button;
        private System.Windows.Forms.Button No2Button;
        private System.Windows.Forms.Button No1Button;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button No6Button;
        private System.Windows.Forms.Button No5Button;
        private System.Windows.Forms.Button No4Button;
        private System.Windows.Forms.Button TimesButton;
        private System.Windows.Forms.Button No9Button;
        private System.Windows.Forms.Button No8Button;
        private System.Windows.Forms.Button No7Button;
        private System.Windows.Forms.Button DivideButton;
    }
}

