using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        List<string> ElementOrElementList = new List<string>();

        private void radioButtonText_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxParamType.Enabled = !groupBoxParamType.Enabled;
            textBoxParameterName.Enabled = !textBoxParameterName.Enabled;
        }
        private void radioButtonElementOrElement_CheckedChanged(object sender, EventArgs e)
        {
            textBoxParameterName.Enabled = !textBoxParameterName.Enabled;
            textBoxElementOrElementName.Enabled = !textBoxElementOrElementName.Enabled;
            buttonElementOrElementAdd.Enabled = !buttonElementOrElementAdd.Enabled;
        }

        private void buttonStartAddingElement_Click(object sender, EventArgs e)
        {
            textBoxDTD.AppendText(String.Format("<!ELEMENT {0} (", textBoxElementName.Text));
            textBoxElementName.Text = String.Empty;
        }
        private void buttonEndAddingElement_Click(object sender, EventArgs e)
        {
            if (textBoxDTD.Text[textBoxDTD.Text.Length - 1] == ',')
            {
                textBoxDTD.Text = textBoxDTD.Text.Remove(textBoxDTD.Text.Length-1);
            }

            textBoxDTD.AppendText(")>" + Environment.NewLine);
        }

        private void buttonAddParameter_Click(object sender, EventArgs e)
        {
            if (radioButtonText.Checked)
            {
                textBoxDTD.AppendText("#PCDATA");
            }
            else
            {
                if (radioButtonElement.Checked)
                {
                    textBoxDTD.AppendText(textBoxParameterName.Text);
                    textBoxParameterName.Text = String.Empty;
                    textBoxParameterName.Focus();
                }
                else if (radioButtonElementOrElement.Checked)
                {
                    string ElementOrElementString = "(";

                    foreach (string NewElement in ElementOrElementList)
                    {
                        ElementOrElementString += NewElement + "|";
                    }

                    ElementOrElementList.Clear();

                    ElementOrElementString = ElementOrElementString.Remove(ElementOrElementString.Length-1);
                    ElementOrElementString += ")";

                    textBoxDTD.AppendText(ElementOrElementString);
                }

                if (radioButtonNullOrOne.Checked)
                {
                     textBoxDTD.Text += "?";
                }
                else if (radioButtonOneOrMore.Checked)
                {
                    textBoxDTD.Text += "+";
                }
                else if (radioButtonNullOrMore.Checked)
                {
                    textBoxDTD.Text += "*";
                }

                textBoxDTD.Text += ",";
            }
        }
        private void buttonElementOrElementAdd_Click(object sender, EventArgs e)
        {
            string TempString = textBoxElementOrElementName.Text;

            if (radioButtonNullOrOne.Checked)
            {
                TempString += "?";
            }
            else if (radioButtonOneOrMore.Checked)
            {
                TempString += "+";
            }
            else if (radioButtonNullOrMore.Checked)
            {
                TempString += "*";
            }

            ElementOrElementList.Add(TempString);
            textBoxElementOrElementName.Text = String.Empty;
            textBoxElementOrElementName.Focus();
        }

        private void buttonStartAddingAttribute_Click(object sender, EventArgs e)
        {
            string TempString = String.Format("<!ATTLIST {0} {1} ", textBoxElementName.Text, textBoxAttributeName.Text);

            if (radioButtonTypeString.Checked)
            {
                TempString += "CDATA ";
            }
            else if (radioButtonTypeID.Checked)
            {
                TempString += "ID ";
            }
            else if (radioButtonTypeEssence.Checked)
            {
                TempString += "ENTITY ";
            }

            if (radioButtonRequired.Checked)
            {
                TempString += "#REQUIRED";
            }
            else if (radioButtonImplied.Checked)
            {
                TempString += "#IMPLIED";
            }

            TempString += ">" + Environment.NewLine;

            textBoxDTD.AppendText(TempString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialogMain.Filter = "DTD-файли|*.dtd";

            if (saveFileDialogMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter NewDTD = new System.IO.StreamWriter(saveFileDialogMain.FileName))
                {
                    NewDTD.Write(textBoxDTD.Text);
                }
            }
        }
    }
}
