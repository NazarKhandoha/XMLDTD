namespace Lab6
{
    partial class Form3
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
            this.buttonStartAddingElement = new System.Windows.Forms.Button();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.textBoxDTD = new System.Windows.Forms.TextBox();
            this.radioButtonElementOrElement = new System.Windows.Forms.RadioButton();
            this.radioButtonElement = new System.Windows.Forms.RadioButton();
            this.radioButtonText = new System.Windows.Forms.RadioButton();
            this.buttonEndAddingElement = new System.Windows.Forms.Button();
            this.textBoxElementName = new System.Windows.Forms.TextBox();
            this.buttonAddParameter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.groupBoxParamType = new System.Windows.Forms.GroupBox();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonNullOrOne = new System.Windows.Forms.RadioButton();
            this.radioButtonOneOrMore = new System.Windows.Forms.RadioButton();
            this.radioButtonNullOrMore = new System.Windows.Forms.RadioButton();
            this.textBoxParameterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxElementOrElementName = new System.Windows.Forms.TextBox();
            this.buttonElementOrElementAdd = new System.Windows.Forms.Button();
            this.buttonStartAddingAttribute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAttributeName = new System.Windows.Forms.TextBox();
            this.groupBoxAttributeType = new System.Windows.Forms.GroupBox();
            this.radioButtonTypeEssence = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeID = new System.Windows.Forms.RadioButton();
            this.radioButtonTypeString = new System.Windows.Forms.RadioButton();
            this.groupBoxAttributeParameters = new System.Windows.Forms.GroupBox();
            this.radioButtonImplied = new System.Windows.Forms.RadioButton();
            this.radioButtonRequired = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            this.groupBoxParamType.SuspendLayout();
            this.groupBoxAttributeType.SuspendLayout();
            this.groupBoxAttributeParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartAddingElement
            // 
            this.buttonStartAddingElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartAddingElement.Location = new System.Drawing.Point(12, 38);
            this.buttonStartAddingElement.Name = "buttonStartAddingElement";
            this.buttonStartAddingElement.Size = new System.Drawing.Size(200, 35);
            this.buttonStartAddingElement.TabIndex = 2;
            this.buttonStartAddingElement.Text = "Open new element";
            this.buttonStartAddingElement.UseVisualStyleBackColor = true;
            this.buttonStartAddingElement.Click += new System.EventHandler(this.buttonStartAddingElement_Click);
            // 
            // textBoxDTD
            // 
            this.textBoxDTD.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxDTD.Location = new System.Drawing.Point(424, 12);
            this.textBoxDTD.Multiline = true;
            this.textBoxDTD.Name = "textBoxDTD";
            this.textBoxDTD.Size = new System.Drawing.Size(332, 431);
            this.textBoxDTD.TabIndex = 0;
            this.textBoxDTD.UseWaitCursor = true;
            // 
            // radioButtonElementOrElement
            // 
            this.radioButtonElementOrElement.AutoSize = true;
            this.radioButtonElementOrElement.Location = new System.Drawing.Point(6, 42);
            this.radioButtonElementOrElement.Name = "radioButtonElementOrElement";
            this.radioButtonElementOrElement.Size = new System.Drawing.Size(175, 17);
            this.radioButtonElementOrElement.TabIndex = 4;
            this.radioButtonElementOrElement.Text = "Список елемент-або-елемент";
            this.radioButtonElementOrElement.UseVisualStyleBackColor = true;
            this.radioButtonElementOrElement.CheckedChanged += new System.EventHandler(this.radioButtonElementOrElement_CheckedChanged);
            // 
            // radioButtonElement
            // 
            this.radioButtonElement.AutoSize = true;
            this.radioButtonElement.Checked = true;
            this.radioButtonElement.Location = new System.Drawing.Point(6, 19);
            this.radioButtonElement.Name = "radioButtonElement";
            this.radioButtonElement.Size = new System.Drawing.Size(69, 17);
            this.radioButtonElement.TabIndex = 3;
            this.radioButtonElement.TabStop = true;
            this.radioButtonElement.Text = "Елемент";
            this.radioButtonElement.UseVisualStyleBackColor = true;
            // 
            // radioButtonText
            // 
            this.radioButtonText.AutoSize = true;
            this.radioButtonText.Location = new System.Drawing.Point(6, 65);
            this.radioButtonText.Name = "radioButtonText";
            this.radioButtonText.Size = new System.Drawing.Size(55, 17);
            this.radioButtonText.TabIndex = 5;
            this.radioButtonText.Text = "Текст";
            this.radioButtonText.UseVisualStyleBackColor = true;
            this.radioButtonText.CheckedChanged += new System.EventHandler(this.radioButtonText_CheckedChanged);
            // 
            // buttonEndAddingElement
            // 
            this.buttonEndAddingElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndAddingElement.Location = new System.Drawing.Point(12, 394);
            this.buttonEndAddingElement.Name = "buttonEndAddingElement";
            this.buttonEndAddingElement.Size = new System.Drawing.Size(200, 40);
            this.buttonEndAddingElement.TabIndex = 14;
            this.buttonEndAddingElement.Text = "Закрити новий елемент";
            this.buttonEndAddingElement.UseVisualStyleBackColor = true;
            this.buttonEndAddingElement.Click += new System.EventHandler(this.buttonEndAddingElement_Click);
            // 
            // textBoxElementName
            // 
            this.textBoxElementName.Location = new System.Drawing.Point(111, 12);
            this.textBoxElementName.Name = "textBoxElementName";
            this.textBoxElementName.Size = new System.Drawing.Size(100, 20);
            this.textBoxElementName.TabIndex = 1;
            // 
            // buttonAddParameter
            // 
            this.buttonAddParameter.Location = new System.Drawing.Point(12, 348);
            this.buttonAddParameter.Name = "buttonAddParameter";
            this.buttonAddParameter.Size = new System.Drawing.Size(200, 40);
            this.buttonAddParameter.TabIndex = 13;
            this.buttonAddParameter.Text = "Додати параметр";
            this.buttonAddParameter.UseVisualStyleBackColor = true;
            this.buttonAddParameter.Click += new System.EventHandler(this.buttonAddParameter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name elmetn:";
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.radioButtonText);
            this.groupBoxParams.Controls.Add(this.radioButtonElement);
            this.groupBoxParams.Controls.Add(this.radioButtonElementOrElement);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 79);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(200, 90);
            this.groupBoxParams.TabIndex = 10;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Тип параметра:";
            // 
            // groupBoxParamType
            // 
            this.groupBoxParamType.Controls.Add(this.radioButtonOne);
            this.groupBoxParamType.Controls.Add(this.radioButtonNullOrOne);
            this.groupBoxParamType.Controls.Add(this.radioButtonOneOrMore);
            this.groupBoxParamType.Controls.Add(this.radioButtonNullOrMore);
            this.groupBoxParamType.Location = new System.Drawing.Point(12, 175);
            this.groupBoxParamType.Name = "groupBoxParamType";
            this.groupBoxParamType.Size = new System.Drawing.Size(200, 115);
            this.groupBoxParamType.TabIndex = 11;
            this.groupBoxParamType.TabStop = false;
            this.groupBoxParamType.Text = "К-сть входжень параметра:";
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Checked = true;
            this.radioButtonOne.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(31, 17);
            this.radioButtonOne.TabIndex = 6;
            this.radioButtonOne.TabStop = true;
            this.radioButtonOne.Text = "1";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonNullOrOne
            // 
            this.radioButtonNullOrOne.AutoSize = true;
            this.radioButtonNullOrOne.Location = new System.Drawing.Point(6, 65);
            this.radioButtonNullOrOne.Name = "radioButtonNullOrOne";
            this.radioButtonNullOrOne.Size = new System.Drawing.Size(61, 17);
            this.radioButtonNullOrOne.TabIndex = 8;
            this.radioButtonNullOrOne.Text = "0 або 1";
            this.radioButtonNullOrOne.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneOrMore
            // 
            this.radioButtonOneOrMore.AutoSize = true;
            this.radioButtonOneOrMore.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOneOrMore.Name = "radioButtonOneOrMore";
            this.radioButtonOneOrMore.Size = new System.Drawing.Size(89, 17);
            this.radioButtonOneOrMore.TabIndex = 7;
            this.radioButtonOneOrMore.Text = "1 або більше";
            this.radioButtonOneOrMore.UseVisualStyleBackColor = true;
            // 
            // radioButtonNullOrMore
            // 
            this.radioButtonNullOrMore.AutoSize = true;
            this.radioButtonNullOrMore.Location = new System.Drawing.Point(6, 88);
            this.radioButtonNullOrMore.Name = "radioButtonNullOrMore";
            this.radioButtonNullOrMore.Size = new System.Drawing.Size(89, 17);
            this.radioButtonNullOrMore.TabIndex = 9;
            this.radioButtonNullOrMore.Text = "0 або більше";
            this.radioButtonNullOrMore.UseVisualStyleBackColor = true;
            // 
            // textBoxParameterName
            // 
            this.textBoxParameterName.Location = new System.Drawing.Point(117, 322);
            this.textBoxParameterName.Name = "textBoxParameterName";
            this.textBoxParameterName.Size = new System.Drawing.Size(94, 20);
            this.textBoxParameterName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Назва параметра:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Назва:";
            // 
            // textBoxElementOrElementName
            // 
            this.textBoxElementOrElementName.Enabled = false;
            this.textBoxElementOrElementName.Location = new System.Drawing.Point(60, 296);
            this.textBoxElementOrElementName.Name = "textBoxElementOrElementName";
            this.textBoxElementOrElementName.Size = new System.Drawing.Size(91, 20);
            this.textBoxElementOrElementName.TabIndex = 10;
            // 
            // buttonElementOrElementAdd
            // 
            this.buttonElementOrElementAdd.Enabled = false;
            this.buttonElementOrElementAdd.Location = new System.Drawing.Point(156, 296);
            this.buttonElementOrElementAdd.Name = "buttonElementOrElementAdd";
            this.buttonElementOrElementAdd.Size = new System.Drawing.Size(56, 20);
            this.buttonElementOrElementAdd.TabIndex = 11;
            this.buttonElementOrElementAdd.Text = "Додати";
            this.buttonElementOrElementAdd.UseVisualStyleBackColor = true;
            this.buttonElementOrElementAdd.Click += new System.EventHandler(this.buttonElementOrElementAdd_Click);
            // 
            // buttonStartAddingAttribute
            // 
            this.buttonStartAddingAttribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartAddingAttribute.Location = new System.Drawing.Point(218, 209);
            this.buttonStartAddingAttribute.Name = "buttonStartAddingAttribute";
            this.buttonStartAddingAttribute.Size = new System.Drawing.Size(200, 40);
            this.buttonStartAddingAttribute.TabIndex = 21;
            this.buttonStartAddingAttribute.Text = "Add new atribute";
            this.buttonStartAddingAttribute.UseVisualStyleBackColor = true;
            this.buttonStartAddingAttribute.Click += new System.EventHandler(this.buttonStartAddingAttribute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name atribute:";
            // 
            // textBoxAttributeName
            // 
            this.textBoxAttributeName.Location = new System.Drawing.Point(318, 12);
            this.textBoxAttributeName.Name = "textBoxAttributeName";
            this.textBoxAttributeName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAttributeName.TabIndex = 15;
            // 
            // groupBoxAttributeType
            // 
            this.groupBoxAttributeType.Controls.Add(this.radioButtonTypeEssence);
            this.groupBoxAttributeType.Controls.Add(this.radioButtonTypeID);
            this.groupBoxAttributeType.Controls.Add(this.radioButtonTypeString);
            this.groupBoxAttributeType.Location = new System.Drawing.Point(218, 38);
            this.groupBoxAttributeType.Name = "groupBoxAttributeType";
            this.groupBoxAttributeType.Size = new System.Drawing.Size(200, 90);
            this.groupBoxAttributeType.TabIndex = 20;
            this.groupBoxAttributeType.TabStop = false;
            this.groupBoxAttributeType.Text = "Тип атрибута:";
            // 
            // radioButtonTypeEssence
            // 
            this.radioButtonTypeEssence.AutoSize = true;
            this.radioButtonTypeEssence.Location = new System.Drawing.Point(6, 65);
            this.radioButtonTypeEssence.Name = "radioButtonTypeEssence";
            this.radioButtonTypeEssence.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTypeEssence.TabIndex = 18;
            this.radioButtonTypeEssence.Text = "Сутність";
            this.radioButtonTypeEssence.UseVisualStyleBackColor = true;
            // 
            // radioButtonTypeID
            // 
            this.radioButtonTypeID.AutoSize = true;
            this.radioButtonTypeID.Location = new System.Drawing.Point(6, 42);
            this.radioButtonTypeID.Name = "radioButtonTypeID";
            this.radioButtonTypeID.Size = new System.Drawing.Size(97, 17);
            this.radioButtonTypeID.TabIndex = 17;
            this.radioButtonTypeID.Text = "Унікальний ID";
            this.radioButtonTypeID.UseVisualStyleBackColor = true;
            // 
            // radioButtonTypeString
            // 
            this.radioButtonTypeString.AutoSize = true;
            this.radioButtonTypeString.Checked = true;
            this.radioButtonTypeString.Location = new System.Drawing.Point(6, 19);
            this.radioButtonTypeString.Name = "radioButtonTypeString";
            this.radioButtonTypeString.Size = new System.Drawing.Size(101, 17);
            this.radioButtonTypeString.TabIndex = 16;
            this.radioButtonTypeString.TabStop = true;
            this.radioButtonTypeString.Text = "Символьні дані";
            this.radioButtonTypeString.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttributeParameters
            // 
            this.groupBoxAttributeParameters.Controls.Add(this.radioButtonImplied);
            this.groupBoxAttributeParameters.Controls.Add(this.radioButtonRequired);
            this.groupBoxAttributeParameters.Location = new System.Drawing.Point(218, 134);
            this.groupBoxAttributeParameters.Name = "groupBoxAttributeParameters";
            this.groupBoxAttributeParameters.Size = new System.Drawing.Size(200, 69);
            this.groupBoxAttributeParameters.TabIndex = 21;
            this.groupBoxAttributeParameters.TabStop = false;
            this.groupBoxAttributeParameters.Text = "Опис атрибута:";
            // 
            // radioButtonImplied
            // 
            this.radioButtonImplied.AutoSize = true;
            this.radioButtonImplied.Location = new System.Drawing.Point(6, 42);
            this.radioButtonImplied.Name = "radioButtonImplied";
            this.radioButtonImplied.Size = new System.Drawing.Size(107, 17);
            this.radioButtonImplied.TabIndex = 20;
            this.radioButtonImplied.Text = "Необов\'язковий";
            this.radioButtonImplied.UseVisualStyleBackColor = true;
            // 
            // radioButtonRequired
            // 
            this.radioButtonRequired.AutoSize = true;
            this.radioButtonRequired.Checked = true;
            this.radioButtonRequired.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRequired.Name = "radioButtonRequired";
            this.radioButtonRequired.Size = new System.Drawing.Size(95, 17);
            this.radioButtonRequired.TabIndex = 19;
            this.radioButtonRequired.TabStop = true;
            this.radioButtonRequired.Text = "Обов\'язковий";
            this.radioButtonRequired.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(218, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 86);
            this.button1.TabIndex = 22;
            this.button1.Text = "Зберегти DTD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxAttributeParameters);
            this.Controls.Add(this.groupBoxAttributeType);
            this.Controls.Add(this.textBoxAttributeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStartAddingAttribute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxElementOrElementName);
            this.Controls.Add(this.buttonElementOrElementAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParameterName);
            this.Controls.Add(this.groupBoxParamType);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddParameter);
            this.Controls.Add(this.textBoxElementName);
            this.Controls.Add(this.buttonEndAddingElement);
            this.Controls.Add(this.textBoxDTD);
            this.Controls.Add(this.buttonStartAddingElement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Редагування DTD";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.groupBoxParamType.ResumeLayout(false);
            this.groupBoxParamType.PerformLayout();
            this.groupBoxAttributeType.ResumeLayout(false);
            this.groupBoxAttributeType.PerformLayout();
            this.groupBoxAttributeParameters.ResumeLayout(false);
            this.groupBoxAttributeParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartAddingElement;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.TextBox textBoxDTD;
        private System.Windows.Forms.RadioButton radioButtonElement;
        private System.Windows.Forms.RadioButton radioButtonText;
        private System.Windows.Forms.Button buttonEndAddingElement;
        private System.Windows.Forms.TextBox textBoxElementName;
        private System.Windows.Forms.RadioButton radioButtonElementOrElement;
        private System.Windows.Forms.Button buttonAddParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.GroupBox groupBoxParamType;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.RadioButton radioButtonNullOrOne;
        private System.Windows.Forms.RadioButton radioButtonOneOrMore;
        private System.Windows.Forms.RadioButton radioButtonNullOrMore;
        private System.Windows.Forms.TextBox textBoxParameterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxElementOrElementName;
        private System.Windows.Forms.Button buttonElementOrElementAdd;
        private System.Windows.Forms.Button buttonStartAddingAttribute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAttributeName;
        private System.Windows.Forms.GroupBox groupBoxAttributeType;
        private System.Windows.Forms.RadioButton radioButtonTypeEssence;
        private System.Windows.Forms.RadioButton radioButtonTypeID;
        private System.Windows.Forms.RadioButton radioButtonTypeString;
        private System.Windows.Forms.GroupBox groupBoxAttributeParameters;
        private System.Windows.Forms.RadioButton radioButtonImplied;
        private System.Windows.Forms.RadioButton radioButtonRequired;
        private System.Windows.Forms.Button button1;
    }
}