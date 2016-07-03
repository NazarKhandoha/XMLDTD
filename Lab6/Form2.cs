using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Lab6
{
    public struct ElementInfo
    {
        private string _name;
        private string _value;
       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
       
        public ElementInfo(string _Name, string _Value)
        {
            _name = _Name;
            _value = _Value;
        }
    }

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string ElementName;
        private List <ElementInfo> AttributeList = new List<ElementInfo>();
        private List <ElementInfo> SubElementList = new List<ElementInfo>(); 

        public void CreateXml(string pathToXml, string startElementName)
        {
            XmlTextWriter Writer = new XmlTextWriter(pathToXml, Encoding.UTF8);

            Writer.WriteStartDocument();

            Writer.WriteStartElement(startElementName);
            Writer.WriteEndElement();

            Writer.Close();
        }
        public void WriteToXml(string pathToXml, string _ElementName, List <ElementInfo> _AttributeList, List <ElementInfo> _SubElementList)
        {
            XmlDocument Document = new XmlDocument();

            Document.Load(pathToXml);

            XmlNode Element = Document.CreateElement(_ElementName);
            Document.DocumentElement.AppendChild(Element);

            foreach (ElementInfo NewAttribute in _AttributeList)
            {
                XmlAttribute Attribute = Document.CreateAttribute(NewAttribute.Name);
                Attribute.Value = NewAttribute.Value;
                Element.Attributes.Append(Attribute);
            }

            foreach (ElementInfo NewSubElement in _SubElementList)
            {
                XmlNode SubElement = Document.CreateElement(NewSubElement.Name);
                SubElement.InnerText = NewSubElement.Value;
                Element.AppendChild(SubElement);
            }         

            Document.Save(pathToXml);
        }
        
        private void buttonCreateXML_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "XML-файли|*.xml";
            saveFileDialogMain.FileName = textBoxRootElement.Text;

            if (saveFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                CreateXml(saveFileDialogMain.FileName, textBoxRootElement.Text);
        }
        private void buttonOpenXML_Click(object sender, EventArgs e)
        {
            openFileDialogMain.Filter = "XML-файли|*.xml";

            if (openFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                buttonAddElement.Enabled = true;
            }
        }

        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            ElementName = textBoxAddElement.Text;

            labelElementName.Text = ElementName;

            if (ElementName != "")
            {
                buttonAddAttribute.Enabled = true;
                buttonAddSubElement.Enabled = true;
                buttonSaveElement.Enabled = true;
            }
        }
        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            AttributeList.Add(new ElementInfo(textBoxAddAttribute.Text, textBoxAddAttributeValue.Text));
            labelAttributeList.Text += String.Format("{0} = \"{1}\"\n", AttributeList.Last().Name, AttributeList.Last().Value);

            textBoxAddAttribute.Text = "";
            textBoxAddAttributeValue.Text = "";

            textBoxAddAttribute.Focus();
        }
        private void buttonAddSubElement_Click(object sender, EventArgs e)
        {
            SubElementList.Add(new ElementInfo(textBoxAddSubElement.Text, textBoxAddSubElementValue.Text));
            labelSubElementList.Text += String.Format("<{0}> {1} </{0}>\n", SubElementList.Last().Name, SubElementList.Last().Value);

            textBoxAddSubElement.Text = "";
            textBoxAddSubElementValue.Text = "";

            textBoxAddSubElement.Focus();
        }
        private void buttonSaveElement_Click(object sender, EventArgs e)
        {
            WriteToXml(openFileDialogMain.FileName, ElementName, AttributeList, SubElementList);

            ElementName = "";
            labelElementName.Text = "Назва елементу:";
            labelAttributeList.Text = "";
            labelSubElementList.Text = "";

            buttonAddAttribute.Enabled = false;
            buttonAddSubElement.Enabled = false;
            buttonSaveElement.Enabled = false;

            AttributeList.Clear();
            SubElementList.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }      
    }
}
