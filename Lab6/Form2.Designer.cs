namespace Lab6
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRootElement = new System.Windows.Forms.TextBox();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.buttonCreateXML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddElement = new System.Windows.Forms.TextBox();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.textBoxAddAttribute = new System.Windows.Forms.TextBox();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.buttonAddSubElement = new System.Windows.Forms.Button();
            this.textBoxAddSubElement = new System.Windows.Forms.TextBox();
            this.buttonSaveElement = new System.Windows.Forms.Button();
            this.groupBoxAttributeList = new System.Windows.Forms.GroupBox();
            this.labelAttributeList = new System.Windows.Forms.Label();
            this.groupBoxSubElementList = new System.Windows.Forms.GroupBox();
            this.labelSubElementList = new System.Windows.Forms.Label();
            this.labelElementName = new System.Windows.Forms.Label();
            this.textBoxAddSubElementValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddAttributeValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOpenXML = new System.Windows.Forms.Button();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAttributeList.SuspendLayout();
            this.groupBoxSubElementList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAme main elemetn";
            // 
            // textBoxRootElement
            // 
            this.textBoxRootElement.Location = new System.Drawing.Point(166, 10);
            this.textBoxRootElement.Name = "textBoxRootElement";
            this.textBoxRootElement.Size = new System.Drawing.Size(100, 20);
            this.textBoxRootElement.TabIndex = 1;
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateXML.Location = new System.Drawing.Point(12, 36);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(254, 35);
            this.buttonCreateXML.TabIndex = 2;
            this.buttonCreateXML.Text = "Create  XML";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name element";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name atribute:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // textBoxAddElement
            // 
            this.textBoxAddElement.Location = new System.Drawing.Point(166, 118);
            this.textBoxAddElement.Name = "textBoxAddElement";
            this.textBoxAddElement.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddElement.TabIndex = 3;
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Enabled = false;
            this.buttonAddElement.Location = new System.Drawing.Point(12, 144);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(254, 35);
            this.buttonAddElement.TabIndex = 4;
            this.buttonAddElement.Text = "Add element";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // textBoxAddAttribute
            // 
            this.textBoxAddAttribute.Location = new System.Drawing.Point(166, 185);
            this.textBoxAddAttribute.Name = "textBoxAddAttribute";
            this.textBoxAddAttribute.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAttribute.TabIndex = 5;
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Enabled = false;
            this.buttonAddAttribute.Location = new System.Drawing.Point(12, 237);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(254, 35);
            this.buttonAddAttribute.TabIndex = 7;
            this.buttonAddAttribute.Text = "Add atribute";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // buttonAddSubElement
            // 
            this.buttonAddSubElement.Enabled = false;
            this.buttonAddSubElement.Location = new System.Drawing.Point(12, 330);
            this.buttonAddSubElement.Name = "buttonAddSubElement";
            this.buttonAddSubElement.Size = new System.Drawing.Size(254, 40);
            this.buttonAddSubElement.TabIndex = 10;
            this.buttonAddSubElement.Text = "Add underelement";
            this.buttonAddSubElement.UseVisualStyleBackColor = true;
            this.buttonAddSubElement.Click += new System.EventHandler(this.buttonAddSubElement_Click);
            // 
            // textBoxAddSubElement
            // 
            this.textBoxAddSubElement.Location = new System.Drawing.Point(166, 278);
            this.textBoxAddSubElement.Name = "textBoxAddSubElement";
            this.textBoxAddSubElement.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSubElement.TabIndex = 8;
            // 
            // buttonSaveElement
            // 
            this.buttonSaveElement.Enabled = false;
            this.buttonSaveElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveElement.Location = new System.Drawing.Point(12, 376);
            this.buttonSaveElement.Name = "buttonSaveElement";
            this.buttonSaveElement.Size = new System.Drawing.Size(254, 40);
            this.buttonSaveElement.TabIndex = 11;
            this.buttonSaveElement.Text = "Save elemnt";
            this.buttonSaveElement.UseVisualStyleBackColor = true;
            this.buttonSaveElement.Click += new System.EventHandler(this.buttonSaveElement_Click);
            // 
            // groupBoxAttributeList
            // 
            this.groupBoxAttributeList.Controls.Add(this.labelAttributeList);
            this.groupBoxAttributeList.Location = new System.Drawing.Point(284, 36);
            this.groupBoxAttributeList.Name = "groupBoxAttributeList";
            this.groupBoxAttributeList.Size = new System.Drawing.Size(200, 380);
            this.groupBoxAttributeList.TabIndex = 13;
            this.groupBoxAttributeList.TabStop = false;
            this.groupBoxAttributeList.Text = "List atribute:";
            // 
            // labelAttributeList
            // 
            this.labelAttributeList.AutoSize = true;
            this.labelAttributeList.Location = new System.Drawing.Point(9, 20);
            this.labelAttributeList.Name = "labelAttributeList";
            this.labelAttributeList.Size = new System.Drawing.Size(0, 13);
            this.labelAttributeList.TabIndex = 0;
            // 
            // groupBoxSubElementList
            // 
            this.groupBoxSubElementList.Controls.Add(this.labelSubElementList);
            this.groupBoxSubElementList.Location = new System.Drawing.Point(490, 36);
            this.groupBoxSubElementList.Name = "groupBoxSubElementList";
            this.groupBoxSubElementList.Size = new System.Drawing.Size(200, 380);
            this.groupBoxSubElementList.TabIndex = 14;
            this.groupBoxSubElementList.TabStop = false;
            this.groupBoxSubElementList.Text = "List underelement:";
            // 
            // labelSubElementList
            // 
            this.labelSubElementList.AutoSize = true;
            this.labelSubElementList.Location = new System.Drawing.Point(6, 20);
            this.labelSubElementList.Name = "labelSubElementList";
            this.labelSubElementList.Size = new System.Drawing.Size(0, 13);
            this.labelSubElementList.TabIndex = 1;
            // 
            // labelElementName
            // 
            this.labelElementName.AutoSize = true;
            this.labelElementName.Location = new System.Drawing.Point(290, 13);
            this.labelElementName.Name = "labelElementName";
            this.labelElementName.Size = new System.Drawing.Size(78, 13);
            this.labelElementName.TabIndex = 15;
            this.labelElementName.Text = "Name element:";
            // 
            // textBoxAddSubElementValue
            // 
            this.textBoxAddSubElementValue.Location = new System.Drawing.Point(166, 304);
            this.textBoxAddSubElementValue.Name = "textBoxAddSubElementValue";
            this.textBoxAddSubElementValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSubElementValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Value underelement:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxAddAttributeValue
            // 
            this.textBoxAddAttributeValue.Location = new System.Drawing.Point(166, 207);
            this.textBoxAddAttributeValue.Name = "textBoxAddAttributeValue";
            this.textBoxAddAttributeValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddAttributeValue.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Value atribute:";
            // 
            // buttonOpenXML
            // 
            this.buttonOpenXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenXML.Location = new System.Drawing.Point(12, 77);
            this.buttonOpenXML.Name = "buttonOpenXML";
            this.buttonOpenXML.Size = new System.Drawing.Size(254, 35);
            this.buttonOpenXML.TabIndex = 20;
            this.buttonOpenXML.Text = "Open XML";
            this.buttonOpenXML.UseVisualStyleBackColor = true;
            this.buttonOpenXML.Click += new System.EventHandler(this.buttonOpenXML_Click);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 430);
            this.Controls.Add(this.buttonOpenXML);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddAttributeValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddSubElementValue);
            this.Controls.Add(this.labelElementName);
            this.Controls.Add(this.groupBoxSubElementList);
            this.Controls.Add(this.groupBoxAttributeList);
            this.Controls.Add(this.buttonSaveElement);
            this.Controls.Add(this.buttonAddSubElement);
            this.Controls.Add(this.textBoxAddSubElement);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.textBoxAddAttribute);
            this.Controls.Add(this.buttonAddElement);
            this.Controls.Add(this.textBoxAddElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateXML);
            this.Controls.Add(this.textBoxRootElement);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Редагування XML";
            this.groupBoxAttributeList.ResumeLayout(false);
            this.groupBoxAttributeList.PerformLayout();
            this.groupBoxSubElementList.ResumeLayout(false);
            this.groupBoxSubElementList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRootElement;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.Button buttonCreateXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddElement;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.TextBox textBoxAddAttribute;
        private System.Windows.Forms.Button buttonAddAttribute;
        private System.Windows.Forms.Button buttonAddSubElement;
        private System.Windows.Forms.TextBox textBoxAddSubElement;
        private System.Windows.Forms.Button buttonSaveElement;
        private System.Windows.Forms.GroupBox groupBoxAttributeList;
        private System.Windows.Forms.GroupBox groupBoxSubElementList;
        private System.Windows.Forms.Label labelElementName;
        private System.Windows.Forms.TextBox textBoxAddSubElementValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddAttributeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAttributeList;
        private System.Windows.Forms.Label labelSubElementList;
        private System.Windows.Forms.Button buttonOpenXML;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
    }
}