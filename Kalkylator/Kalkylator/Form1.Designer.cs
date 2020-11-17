
namespace Kalkylator
{
    partial class CalculatorForm
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
            this.showNumberBox = new System.Windows.Forms.TextBox();
            this.num07 = new System.Windows.Forms.Button();
            this.num08 = new System.Windows.Forms.Button();
            this.num09 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.num06 = new System.Windows.Forms.Button();
            this.num05 = new System.Windows.Forms.Button();
            this.num04 = new System.Windows.Forms.Button();
            this.num03 = new System.Windows.Forms.Button();
            this.num02 = new System.Windows.Forms.Button();
            this.num01 = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.labelCurrOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showNumberBox
            // 
            this.showNumberBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.showNumberBox.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNumberBox.Location = new System.Drawing.Point(13, 55);
            this.showNumberBox.Name = "showNumberBox";
            this.showNumberBox.ReadOnly = true;
            this.showNumberBox.Size = new System.Drawing.Size(298, 45);
            this.showNumberBox.TabIndex = 0;
            this.showNumberBox.Text = "0";
            this.showNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num07
            // 
            this.num07.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num07.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num07.Location = new System.Drawing.Point(17, 132);
            this.num07.Name = "num07";
            this.num07.Size = new System.Drawing.Size(54, 53);
            this.num07.TabIndex = 1;
            this.num07.Text = "7";
            this.num07.UseVisualStyleBackColor = false;
            this.num07.Click += new System.EventHandler(this.num01_Click);
            // 
            // num08
            // 
            this.num08.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num08.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num08.Location = new System.Drawing.Point(77, 132);
            this.num08.Name = "num08";
            this.num08.Size = new System.Drawing.Size(54, 53);
            this.num08.TabIndex = 2;
            this.num08.Text = "8";
            this.num08.UseVisualStyleBackColor = false;
            this.num08.Click += new System.EventHandler(this.num01_Click);
            // 
            // num09
            // 
            this.num09.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num09.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num09.Location = new System.Drawing.Point(137, 132);
            this.num09.Name = "num09";
            this.num09.Size = new System.Drawing.Size(54, 53);
            this.num09.TabIndex = 3;
            this.num09.Text = "9";
            this.num09.UseVisualStyleBackColor = false;
            this.num09.Click += new System.EventHandler(this.num01_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(197, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(54, 53);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.operator_click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.subtractButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(197, 132);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(54, 53);
            this.subtractButton.TabIndex = 12;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.operator_click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CEButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(257, 191);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(54, 53);
            this.CEButton.TabIndex = 16;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEbutton_click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CButton.Location = new System.Drawing.Point(257, 132);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(54, 53);
            this.CButton.TabIndex = 15;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.Cbutton_click);
            // 
            // num06
            // 
            this.num06.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num06.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num06.Location = new System.Drawing.Point(137, 191);
            this.num06.Name = "num06";
            this.num06.Size = new System.Drawing.Size(54, 53);
            this.num06.TabIndex = 21;
            this.num06.Text = "6";
            this.num06.UseVisualStyleBackColor = false;
            this.num06.Click += new System.EventHandler(this.num01_Click);
            // 
            // num05
            // 
            this.num05.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num05.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num05.Location = new System.Drawing.Point(77, 191);
            this.num05.Name = "num05";
            this.num05.Size = new System.Drawing.Size(54, 53);
            this.num05.TabIndex = 20;
            this.num05.Text = "5";
            this.num05.UseVisualStyleBackColor = false;
            this.num05.Click += new System.EventHandler(this.num01_Click);
            // 
            // num04
            // 
            this.num04.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num04.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num04.Location = new System.Drawing.Point(17, 191);
            this.num04.Name = "num04";
            this.num04.Size = new System.Drawing.Size(54, 53);
            this.num04.TabIndex = 19;
            this.num04.Text = "4";
            this.num04.UseVisualStyleBackColor = false;
            this.num04.Click += new System.EventHandler(this.num01_Click);
            // 
            // num03
            // 
            this.num03.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num03.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num03.Location = new System.Drawing.Point(137, 250);
            this.num03.Name = "num03";
            this.num03.Size = new System.Drawing.Size(54, 53);
            this.num03.TabIndex = 24;
            this.num03.Text = "3";
            this.num03.UseVisualStyleBackColor = false;
            this.num03.Click += new System.EventHandler(this.num01_Click);
            // 
            // num02
            // 
            this.num02.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num02.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num02.Location = new System.Drawing.Point(77, 250);
            this.num02.Name = "num02";
            this.num02.Size = new System.Drawing.Size(54, 53);
            this.num02.TabIndex = 23;
            this.num02.Text = "2";
            this.num02.UseVisualStyleBackColor = false;
            this.num02.Click += new System.EventHandler(this.num01_Click);
            // 
            // num01
            // 
            this.num01.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num01.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num01.Location = new System.Drawing.Point(17, 250);
            this.num01.Name = "num01";
            this.num01.Size = new System.Drawing.Size(54, 53);
            this.num01.TabIndex = 22;
            this.num01.Text = "1";
            this.num01.UseVisualStyleBackColor = false;
            this.num01.Click += new System.EventHandler(this.num01_Click);
            // 
            // commaButton
            // 
            this.commaButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.commaButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commaButton.Location = new System.Drawing.Point(137, 309);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(54, 53);
            this.commaButton.TabIndex = 25;
            this.commaButton.Text = ".";
            this.commaButton.UseVisualStyleBackColor = false;
            this.commaButton.Click += new System.EventHandler(this.num01_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.num0.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(17, 311);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(114, 53);
            this.num0.TabIndex = 26;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num01_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiplyButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(197, 250);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(54, 53);
            this.multiplyButton.TabIndex = 27;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.operator_click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.divideButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(197, 311);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(54, 53);
            this.divideButton.TabIndex = 28;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.operator_click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equalButton.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.Location = new System.Drawing.Point(257, 250);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(54, 112);
            this.equalButton.TabIndex = 29;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalbutton_click);
            // 
            // labelCurrOperation
            // 
            this.labelCurrOperation.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.labelCurrOperation.AutoSize = true;
            this.labelCurrOperation.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrOperation.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCurrOperation.Location = new System.Drawing.Point(13, 13);
            this.labelCurrOperation.Name = "labelCurrOperation";
            this.labelCurrOperation.Size = new System.Drawing.Size(0, 27);
            this.labelCurrOperation.TabIndex = 30;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 389);
            this.Controls.Add(this.labelCurrOperation);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.num03);
            this.Controls.Add(this.num02);
            this.Controls.Add(this.num01);
            this.Controls.Add(this.num06);
            this.Controls.Add(this.num05);
            this.Controls.Add(this.num04);
            this.Controls.Add(this.CEButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.num09);
            this.Controls.Add(this.num08);
            this.Controls.Add(this.num07);
            this.Controls.Add(this.showNumberBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showNumberBox;
        private System.Windows.Forms.Button num07;
        private System.Windows.Forms.Button num08;
        private System.Windows.Forms.Button num09;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button num06;
        private System.Windows.Forms.Button num05;
        private System.Windows.Forms.Button num04;
        private System.Windows.Forms.Button num03;
        private System.Windows.Forms.Button num02;
        private System.Windows.Forms.Button num01;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Label labelCurrOperation;
    }
}

