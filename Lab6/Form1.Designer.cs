namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateXML = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateDTD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemTieXMLtoDTD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.textBoxXML = new System.Windows.Forms.TextBox();
            this.textBoxDTD = new System.Windows.Forms.TextBox();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.ToolStripMenuItemOpen,
            this.toolStripSeparator,
            this.ToolStripMenuItemSave,
            this.toolStripSeparator1,
            this.ToolStripMenuItemTieXMLtoDTD,
            this.ToolStripMenuItemValidate,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "&File";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCreateXML,
            this.ToolStripMenuItemCreateDTD});
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.создатьToolStripMenuItem.Text = "Створити/Редагувати";
            // 
            // ToolStripMenuItemCreateXML
            // 
            this.ToolStripMenuItemCreateXML.Name = "ToolStripMenuItemCreateXML";
            this.ToolStripMenuItemCreateXML.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemCreateXML.Size = new System.Drawing.Size(181, 22);
            this.ToolStripMenuItemCreateXML.Text = "XML...";
            this.ToolStripMenuItemCreateXML.Click += new System.EventHandler(this.toolStripMenuItemCreateXML_Click);
            // 
            // ToolStripMenuItemCreateDTD
            // 
            this.ToolStripMenuItemCreateDTD.Name = "ToolStripMenuItemCreateDTD";
            this.ToolStripMenuItemCreateDTD.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemCreateDTD.Size = new System.Drawing.Size(181, 22);
            this.ToolStripMenuItemCreateDTD.Text = "DTD...";
            this.ToolStripMenuItemCreateDTD.Click += new System.EventHandler(this.toolStripMenuItemCreateDTD_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen.Image")));
            this.ToolStripMenuItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemOpen.Text = "Відкрити...";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(219, 6);
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave.Image")));
            this.ToolStripMenuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemSave.Text = "Зберегти...";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // ToolStripMenuItemTieXMLtoDTD
            // 
            this.ToolStripMenuItemTieXMLtoDTD.Enabled = false;
            this.ToolStripMenuItemTieXMLtoDTD.Name = "ToolStripMenuItemTieXMLtoDTD";
            this.ToolStripMenuItemTieXMLtoDTD.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemTieXMLtoDTD.Text = "Прив\'язати XML до DTD";
            this.ToolStripMenuItemTieXMLtoDTD.Click += new System.EventHandler(this.ToolStripMenuItemTieXMLtoDTD_Click);
            // 
            // ToolStripMenuItemValidate
            // 
            this.ToolStripMenuItemValidate.Enabled = false;
            this.ToolStripMenuItemValidate.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemValidate.Image")));
            this.ToolStripMenuItemValidate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItemValidate.Name = "ToolStripMenuItemValidate";
            this.ToolStripMenuItemValidate.Size = new System.Drawing.Size(222, 22);
            this.ToolStripMenuItemValidate.Text = "Перевірити валідність XML";
            this.ToolStripMenuItemValidate.Click += new System.EventHandler(this.toolStripMenuItemValidate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.выходToolStripMenuItem.Text = "Вихід";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(796, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "Меню";
            // 
            // textBoxXML
            // 
            this.textBoxXML.Location = new System.Drawing.Point(12, 27);
            this.textBoxXML.Multiline = true;
            this.textBoxXML.Name = "textBoxXML";
            this.textBoxXML.Size = new System.Drawing.Size(380, 535);
            this.textBoxXML.TabIndex = 2;
            // 
            // textBoxDTD
            // 
            this.textBoxDTD.Location = new System.Drawing.Point(404, 27);
            this.textBoxDTD.Multiline = true;
            this.textBoxDTD.Name = "textBoxDTD";
            this.textBoxDTD.Size = new System.Drawing.Size(380, 535);
            this.textBoxDTD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 574);
            this.Controls.Add(this.textBoxDTD);
            this.Controls.Add(this.textBoxXML);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Form1";
            this.Text = "XML/DTD Reader";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTieXMLtoDTD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemValidate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.TextBox textBoxXML;
        private System.Windows.Forms.TextBox textBoxDTD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateXML;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateDTD;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;

    }
}

