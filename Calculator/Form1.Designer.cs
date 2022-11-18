namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonNP = new System.Windows.Forms.Button();
            this.ButtonEq = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonTimes = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonBackward = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.RightParenthesis = new System.Windows.Forms.Button();
            this.LeftParenthesis = new System.Windows.Forms.Button();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.FormulaText = new System.Windows.Forms.TextBox();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.PreOrderText = new System.Windows.Forms.TextBox();
            this.InOrderText = new System.Windows.Forms.TextBox();
            this.PostOrderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.Color.Black;
            this.ButtonDot.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonDot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDot.Location = new System.Drawing.Point(203, 549);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(109, 64);
            this.ButtonDot.TabIndex = 11;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.Color.Black;
            this.ButtonZero.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonZero.Location = new System.Drawing.Point(99, 549);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(109, 64);
            this.ButtonZero.TabIndex = 12;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonNP
            // 
            this.ButtonNP.BackColor = System.Drawing.Color.Black;
            this.ButtonNP.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonNP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNP.Location = new System.Drawing.Point(-6, 549);
            this.ButtonNP.Name = "ButtonNP";
            this.ButtonNP.Size = new System.Drawing.Size(109, 64);
            this.ButtonNP.TabIndex = 13;
            this.ButtonNP.Text = "+/-";
            this.ButtonNP.UseVisualStyleBackColor = false;
            this.ButtonNP.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonEq
            // 
            this.ButtonEq.BackColor = System.Drawing.Color.Black;
            this.ButtonEq.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonEq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEq.Location = new System.Drawing.Point(308, 549);
            this.ButtonEq.Name = "ButtonEq";
            this.ButtonEq.Size = new System.Drawing.Size(109, 64);
            this.ButtonEq.TabIndex = 14;
            this.ButtonEq.Text = "=";
            this.ButtonEq.UseVisualStyleBackColor = false;
            this.ButtonEq.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.Color.Black;
            this.ButtonOne.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonOne.Location = new System.Drawing.Point(-6, 489);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(109, 64);
            this.ButtonOne.TabIndex = 15;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.Color.Black;
            this.ButtonFour.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonFour.Location = new System.Drawing.Point(-6, 429);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(109, 64);
            this.ButtonFour.TabIndex = 16;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.Color.Black;
            this.ButtonSeven.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSeven.Location = new System.Drawing.Point(-6, 369);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(109, 64);
            this.ButtonSeven.TabIndex = 17;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.Color.Black;
            this.ButtonTwo.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonTwo.Location = new System.Drawing.Point(99, 489);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(109, 64);
            this.ButtonTwo.TabIndex = 18;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.Color.Black;
            this.ButtonFive.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonFive.Location = new System.Drawing.Point(99, 429);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(109, 64);
            this.ButtonFive.TabIndex = 19;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.Color.Black;
            this.ButtonEight.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEight.Location = new System.Drawing.Point(99, 369);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(109, 64);
            this.ButtonEight.TabIndex = 20;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.Color.Black;
            this.ButtonThree.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonThree.Location = new System.Drawing.Point(203, 489);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(109, 64);
            this.ButtonThree.TabIndex = 21;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.Color.Black;
            this.ButtonSix.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSix.Location = new System.Drawing.Point(203, 429);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(109, 64);
            this.ButtonSix.TabIndex = 22;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.Color.Black;
            this.ButtonNine.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNine.Location = new System.Drawing.Point(203, 369);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(109, 64);
            this.ButtonNine.TabIndex = 23;
            this.ButtonNine.Tag = "ButtonAddNumber";
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.BackColor = System.Drawing.Color.Black;
            this.ButtonDiv.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonDiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDiv.Location = new System.Drawing.Point(308, 309);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(109, 64);
            this.ButtonDiv.TabIndex = 24;
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = false;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonTimes
            // 
            this.ButtonTimes.BackColor = System.Drawing.Color.Black;
            this.ButtonTimes.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonTimes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonTimes.Location = new System.Drawing.Point(308, 369);
            this.ButtonTimes.Name = "ButtonTimes";
            this.ButtonTimes.Size = new System.Drawing.Size(109, 64);
            this.ButtonTimes.TabIndex = 25;
            this.ButtonTimes.Text = "*";
            this.ButtonTimes.UseVisualStyleBackColor = false;
            this.ButtonTimes.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.Black;
            this.ButtonMinus.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMinus.Location = new System.Drawing.Point(308, 429);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(109, 64);
            this.ButtonMinus.TabIndex = 26;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Black;
            this.ButtonAdd.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAdd.Location = new System.Drawing.Point(308, 489);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(109, 64);
            this.ButtonAdd.TabIndex = 27;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonBackward
            // 
            this.ButtonBackward.BackColor = System.Drawing.Color.Black;
            this.ButtonBackward.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonBackward.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonBackward.Location = new System.Drawing.Point(308, 248);
            this.ButtonBackward.Name = "ButtonBackward";
            this.ButtonBackward.Size = new System.Drawing.Size(109, 64);
            this.ButtonBackward.TabIndex = 28;
            this.ButtonBackward.Text = "Back";
            this.ButtonBackward.UseVisualStyleBackColor = false;
            this.ButtonBackward.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.Black;
            this.ButtonC.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonC.Location = new System.Drawing.Point(203, 248);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(109, 64);
            this.ButtonC.TabIndex = 29;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonCE
            // 
            this.ButtonCE.BackColor = System.Drawing.Color.Black;
            this.ButtonCE.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCE.Location = new System.Drawing.Point(99, 248);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(109, 64);
            this.ButtonCE.TabIndex = 30;
            this.ButtonCE.Tag = "";
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = false;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // RightParenthesis
            // 
            this.RightParenthesis.BackColor = System.Drawing.Color.Black;
            this.RightParenthesis.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RightParenthesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightParenthesis.Location = new System.Drawing.Point(99, 309);
            this.RightParenthesis.Name = "RightParenthesis";
            this.RightParenthesis.Size = new System.Drawing.Size(109, 64);
            this.RightParenthesis.TabIndex = 32;
            this.RightParenthesis.Text = ")";
            this.RightParenthesis.UseVisualStyleBackColor = false;
            this.RightParenthesis.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // LeftParenthesis
            // 
            this.LeftParenthesis.BackColor = System.Drawing.Color.Black;
            this.LeftParenthesis.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LeftParenthesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftParenthesis.Location = new System.Drawing.Point(-6, 309);
            this.LeftParenthesis.Name = "LeftParenthesis";
            this.LeftParenthesis.Size = new System.Drawing.Size(109, 64);
            this.LeftParenthesis.TabIndex = 33;
            this.LeftParenthesis.Text = "(";
            this.LeftParenthesis.UseVisualStyleBackColor = false;
            this.LeftParenthesis.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ButtonMod
            // 
            this.ButtonMod.BackColor = System.Drawing.Color.Black;
            this.ButtonMod.Enabled = false;
            this.ButtonMod.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMod.Location = new System.Drawing.Point(-6, 248);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(109, 64);
            this.ButtonMod.TabIndex = 34;
            this.ButtonMod.Tag = "Calculator.SayHi()";
            this.ButtonMod.Text = "None";
            this.ButtonMod.UseVisualStyleBackColor = false;
            this.ButtonMod.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // ResultText
            // 
            this.ResultText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ResultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultText.Font = new System.Drawing.Font("新細明體", 22F);
            this.ResultText.ForeColor = System.Drawing.Color.White;
            this.ResultText.Location = new System.Drawing.Point(-6, 203);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(414, 48);
            this.ResultText.TabIndex = 36;
            this.ResultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormulaText
            // 
            this.FormulaText.BackColor = System.Drawing.Color.Black;
            this.FormulaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormulaText.Font = new System.Drawing.Font("新細明體", 14F);
            this.FormulaText.ForeColor = System.Drawing.Color.White;
            this.FormulaText.Location = new System.Drawing.Point(-6, 155);
            this.FormulaText.Multiline = true;
            this.FormulaText.Name = "FormulaText";
            this.FormulaText.Size = new System.Drawing.Size(414, 42);
            this.FormulaText.TabIndex = 37;
            this.FormulaText.Text = "    ";
            this.FormulaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.BackColor = System.Drawing.Color.Black;
            this.ButtonSqrt.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ButtonSqrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSqrt.Location = new System.Drawing.Point(203, 309);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(109, 64);
            this.ButtonSqrt.TabIndex = 38;
            this.ButtonSqrt.Tag = "ButtonAddNumber";
            this.ButtonSqrt.Text = "Sqrt";
            this.ButtonSqrt.UseVisualStyleBackColor = false;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonOnclick);
            // 
            // PreOrderText
            // 
            this.PreOrderText.BackColor = System.Drawing.Color.Black;
            this.PreOrderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreOrderText.Font = new System.Drawing.Font("新細明體", 14F);
            this.PreOrderText.ForeColor = System.Drawing.Color.White;
            this.PreOrderText.Location = new System.Drawing.Point(-6, 4);
            this.PreOrderText.Multiline = true;
            this.PreOrderText.Name = "PreOrderText";
            this.PreOrderText.Size = new System.Drawing.Size(414, 45);
            this.PreOrderText.TabIndex = 39;
            this.PreOrderText.Text = "    ";
            this.PreOrderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InOrderText
            // 
            this.InOrderText.BackColor = System.Drawing.Color.Black;
            this.InOrderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InOrderText.Font = new System.Drawing.Font("新細明體", 14F);
            this.InOrderText.ForeColor = System.Drawing.Color.White;
            this.InOrderText.Location = new System.Drawing.Point(-6, 55);
            this.InOrderText.Multiline = true;
            this.InOrderText.Name = "InOrderText";
            this.InOrderText.Size = new System.Drawing.Size(414, 44);
            this.InOrderText.TabIndex = 40;
            this.InOrderText.Text = "    ";
            this.InOrderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PostOrderText
            // 
            this.PostOrderText.BackColor = System.Drawing.Color.Black;
            this.PostOrderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostOrderText.Font = new System.Drawing.Font("新細明體", 14F);
            this.PostOrderText.ForeColor = System.Drawing.Color.White;
            this.PostOrderText.Location = new System.Drawing.Point(-6, 105);
            this.PostOrderText.Multiline = true;
            this.PostOrderText.Name = "PostOrderText";
            this.PostOrderText.Size = new System.Drawing.Size(414, 44);
            this.PostOrderText.TabIndex = 41;
            this.PostOrderText.Text = "    ";
            this.PostOrderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(407, 605);
            this.Controls.Add(this.PostOrderText);
            this.Controls.Add(this.InOrderText);
            this.Controls.Add(this.PreOrderText);
            this.Controls.Add(this.ButtonSqrt);
            this.Controls.Add(this.FormulaText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.LeftParenthesis);
            this.Controls.Add(this.RightParenthesis);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonBackward);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonTimes);
            this.Controls.Add(this.ButtonDiv);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonSeven);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.ButtonEq);
            this.Controls.Add(this.ButtonNP);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonDot);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonNP;
        private System.Windows.Forms.Button ButtonEq;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button ButtonTimes;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonBackward;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button RightParenthesis;
        private System.Windows.Forms.Button LeftParenthesis;
        private System.Windows.Forms.Button ButtonMod;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.TextBox FormulaText;
        private System.Windows.Forms.Button ButtonSqrt;
        private System.Windows.Forms.TextBox PreOrderText;
        private System.Windows.Forms.TextBox InOrderText;
        private System.Windows.Forms.TextBox PostOrderText;
    }
}

