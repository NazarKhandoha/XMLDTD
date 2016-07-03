using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private static bool isValid;
        private static string ValidateMessage;
        private static string PathToXML = String.Empty;
        private static string PathToDTD = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemCreateXML_Click(object sender, EventArgs e)
        {
            Form2 CreateXMLForm = new Form2();
            CreateXMLForm.ShowDialog();
        }
        private void toolStripMenuItemCreateDTD_Click(object sender, EventArgs e)
        {
            Form3 CreateDTDForm = new Form3();
            CreateDTDForm.ShowDialog();
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialogMain.Filter = "XML-файли|*.xml|DTD-файли|*.dtd";

            if (openFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialogMain.FileName.EndsWith(".xml"))
                {
                    PathToXML = openFileDialogMain.FileName;
                    textBoxXML.Text = System.IO.File.ReadAllText(PathToXML);
                }
                else if (openFileDialogMain.FileName.EndsWith(".dtd"))
                {
                    PathToDTD = openFileDialogMain.FileName;
                    textBoxDTD.Text = System.IO.File.ReadAllText(PathToDTD);
                }
            }

            if (PathToXML != "")
            {
                ToolStripMenuItemValidate.Enabled = true;
                if (PathToDTD != "")
                    ToolStripMenuItemTieXMLtoDTD.Enabled = true;
            }
                
        }
        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "XML-файли|*.xml|DTD-файли|*.dtd";

            if (saveFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialogMain.FileName.EndsWith(".xml"))
                {
                    System.IO.File.WriteAllText(saveFileDialogMain.FileName, textBoxXML.Text, Encoding.UTF8);
                }
                else if (saveFileDialogMain.FileName.EndsWith(".dtd"))
                {
                    System.IO.File.WriteAllText(saveFileDialogMain.FileName, textBoxDTD.Text, Encoding.UTF8);
                }
            }
        }

        private void ToolStripMenuItemTieXMLtoDTD_Click(object sender, EventArgs e)
        {
            XmlDocument Document = new XmlDocument();
            Document.Load(PathToXML);

            if (Document.DocumentType != null)
                Document.RemoveChild(Document.DocumentType);

            XmlDocumentType DocType = Document.CreateDocumentType(Document.DocumentElement.Name, null, PathToDTD, null);
            Document.InsertAfter(DocType, Document.FirstChild);

            Document.Save(PathToXML);
            textBoxXML.Text = System.IO.File.ReadAllText(PathToXML);
        }
        private void toolStripMenuItemValidate_Click(object sender, EventArgs e)
        {
            isValid = true;
            ValidateMessage = String.Empty;

            XmlReaderSettings Settings = new XmlReaderSettings();

            Settings.DtdProcessing = DtdProcessing.Parse;
            Settings.ValidationType = ValidationType.DTD;
            Settings.ValidationEventHandler += new ValidationEventHandler(CatchValidationEvent);

            XmlReader reader = XmlReader.Create(PathToXML, Settings);

      
            reader.Close();

            if (isValid)
                MessageBox.Show("XML-файл валідний.");
            else
                MessageBox.Show("XML-файл невалідний.\n\n" + ValidateMessage);
        }
        private void CatchValidationEvent(object sender, ValidationEventArgs args)
        {
            isValid = false;
            ValidateMessage += String.Format("{0}\nЛінійка: {1} Позиція: {2}\n\n", args.Message, args.Exception.LineNumber, args.Exception.LinePosition.ToString());
        }
    }
}
