using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CheckRibbon
{
    public partial class Form1 : Form
    {
        private Symbols symbols;

        public Form1()
        {
            InitializeComponent();

            resourcefiles.Items.Add(@"C:\Program Files (x86)\Microsoft Visual Studio 9.0\VC\atlmfc\include\afxres.h");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addresource_Click(object sender, EventArgs e)
        {
            OpenFileDialog PickFile = new OpenFileDialog();
            PickFile.Multiselect = true;
            PickFile.Filter = "include files (.h)|*.h*";
            PickFile.FilterIndex = 1;

            if (PickFile.ShowDialog() == DialogResult.OK)
            {

                foreach (String file in PickFile.FileNames)
                {
                    resourcefiles.Items.Add(file);
                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ribbonfile.Text))
                return;

            if (resourcefiles.Items.Count == 0)
                return;

            status.Items.Clear();
            symbols = new Symbols();

            List<String> errors = new List<String>();
            List<String> warnings = new List<String>();

            foreach (object item in resourcefiles.Items)
            {
                String resfile = item.ToString();
                if (File.Exists(resfile))
                    symbols.load(resfile, ref errors, ref warnings);
            }

            if (showwarnings.Checked)
            {
                foreach (String error in warnings)
                {
                    AddMessage(String.Format(@"{0}", error));
                }
            }

            foreach (String error in errors)
            {
                AddMessage(String.Format(@"{0}", error));
            }

            XmlDocument doc = new XmlDocument();

            String file = ribbonfile.Text;
            doc.Load(file);

            XmlNodeList nodes = doc.SelectNodes(@".//ID");

            foreach (XmlNode node in nodes)
            {
                String name = node["NAME"].InnerText;
                String value = node["VALUE"].InnerText;

                if (IsNumber(name))
                {
                    Tuple t = symbols.getTupleFromID((Int32.Parse(value)));
                    if (t == null)
                    {
                        AddMessage(String.Format(@"{0} is a number and should be a symbol", value));
                        continue;
                    }

                    AddMessage(String.Format(@"<NAME>{0}</NAME> should be <NAME>{1}</NAME> from ""{2}""", value, t.m_name, t.m_file));
                }
                else
                {
                    Tuple t = symbols.getTupleFromSymbol(name);
                    if (t == null)
                    {
                        AddMessage(String.Format(@"""{0}"" is undefined", name));
                        continue;
                    }

                    if (t.m_id != Int32.Parse(value))
                    {
                        AddMessage(String.Format(@"""{0}""={1} is wrong, should be ""{0}""={2} from ""{3}""", name, value, t.m_id, t.m_file));

                    }
                }
            }
        }

        private void AddMessage(String message)
        {
            if(!status.Items.Contains(message))
                status.Items.Add(message);
        }


        private void browseribbon_Click(object sender, EventArgs e)
        {
            OpenFileDialog PickFile = new OpenFileDialog();
            PickFile.Multiselect = true;
            PickFile.Filter = "XML (.xml)|*.xml*";
            PickFile.FilterIndex = 1;

            if (PickFile.ShowDialog() == DialogResult.OK)
            {

                foreach (String file in PickFile.FileNames)
                {
                    ribbonfile.Text = file;
                }
            }
        }

        public Boolean IsNumber(String value)
        {
            return value.All(Char.IsDigit);
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = status.SelectedItem.ToString();

            Clipboard.SetData(DataFormats.Text, text);
        }

        private void deleteresource_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selected = new ListBox.SelectedObjectCollection(resourcefiles);
            selected = resourcefiles.SelectedItems;

            if (resourcefiles.SelectedIndex != -1)
            {
                for (int i = selected.Count - 1; i >= 0; i--)
                    resourcefiles.Items.Remove(selected[i]);
            }
        }

        private void status_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
