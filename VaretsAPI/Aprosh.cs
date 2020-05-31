using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc.Collections;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System.IO;
using System.Globalization;
using MaterialSkin.Controls;
using MaterialSkin;

namespace VaretsAPI
{
    public partial class Aprosh : MaterialForm
    {
        string doc_filepath = "", messEncrypt = "",pathDocument="",strFormatExport="",
            pathSaveReceivedFile="", strForCheckColor = "";
        float singleBitValue, zeroBitValue;
        Random rand = new Random();
        public Aprosh()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.BlueGrey900, Primary.Brown900, Accent.LightBlue200, TextShade.WHITE);

            openFileDialog1.Filter = "Word Documents(*.doc, *.docx, *.docm, *.dot, *.dotm, *.dotx)|*.doc;*.docx;*.docm;*.dot;*.dotm;*.dotx;" +
                "|Text files(*.txt)|*.txt" +
                "|XML files(*.xml)|*.xml"+
                "|All files(*.*)|*.*";
            CBForZeroSpacing.Items.AddRange(new string[] { "-0.4", "-0.3", "-0.2", "-0.1", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1" });
            CBForSingleSpacing.Items.AddRange(new string[] { "-0.4", "-0.3", "-0.2", "-0.1", "0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1" });
            CBForFormatExpport.Items.AddRange(new string[] {  "Doc", "Docx", "Docm", "Dot", "Dotm", "Dotx", "Xml","Rtf"});
            CBForCheckColor.Items.AddRange(new string[] { "Да","Нет" });  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            СoncealmentMethod();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InformationExtraction();
        }

        public void InformationExtraction()
        {
            string decMess = "";
            Document document = new Document();
            document.LoadFromFile(pathSaveReceivedFile);
            ParagraphCollection paragraph = document.Sections[0].Paragraphs;
            foreach (Paragraph par in paragraph)
            {
                foreach (DocumentObject docObj in par.ChildObjects)
                {
                    if (docObj is TextRange)
                    {
                        TextRange textRange = docObj as TextRange;
                        if (textRange.CharacterFormat.CharacterSpacing == singleBitValue)
                        {
                            decMess += '1';
                        }
                        if (textRange.CharacterFormat.CharacterSpacing == zeroBitValue)
                        {
                            decMess += '0';
                        }
                        if (textRange.CharacterFormat.CharacterSpacing == 0.05f)
                        {
                            decMess += ' ';
                        }
                    }
                }
            }
            labelDecryptText.Text = "Извлеченная информация: " + ConvertToMessage(decMess);
        }
        public void СoncealmentMethod()
        {
            Document document = new Document();
            if (pathDocument != "")
            {
                document.LoadFromFile(pathDocument);
                string str = document.GetText();
                //labelForCountSymbol.Text = "Количество символов, которые можно скрыть: " + (str.Length / 7).ToString();
                if (TBForMessage.Text != "")
                {
                    messEncrypt = ConvertToByte(ConvertToASCII(TBForMessage.Text));
                    //////////////////////////////////////////////////////////////////
                    Document doc = new Document();
                    Paragraph paragraph1 = doc.AddSection().AddParagraph();
                    paragraph1.AppendText(str);

                    int part = str.Length / messEncrypt.Length;
                    if (part > 1)
                    {
                        TextRange range = new TextRange(doc);

                        if (singleBitValue != 0 && zeroBitValue != 0 && strFormatExport != "")
                        {
                            if (singleBitValue != zeroBitValue)
                            {
                                for (int i = 0; i < messEncrypt.Length; i++)
                                {
                                    var randPositin = rand.Next(part * i + 1, part * (i + 1));
                                    TextSelection selections = new TextSelection(paragraph1, randPositin, randPositin + 1);
                                    range = selections.GetAsOneRange();
                                    if (strForCheckColor == "Да")
                                    {
                                        if (messEncrypt[i] == '1')
                                        {
                                            range.CharacterFormat.CharacterSpacing = singleBitValue;
                                            range.CharacterFormat.TextColor = Color.Red;
                                        }
                                        if (messEncrypt[i] == '0')
                                        {
                                            range.CharacterFormat.CharacterSpacing = zeroBitValue;
                                            range.CharacterFormat.TextColor = Color.BlueViolet;
                                        }
                                        if (messEncrypt[i] == ' ')
                                        {
                                            range.CharacterFormat.CharacterSpacing = 0.05f;
                                        }
                                    }
                                    else
                                    {
                                        if (messEncrypt[i] == '1')
                                        {
                                            range.CharacterFormat.CharacterSpacing = singleBitValue;
                                        }
                                        if (messEncrypt[i] == '0')
                                        {
                                            range.CharacterFormat.CharacterSpacing = zeroBitValue;
                                        }
                                        if (messEncrypt[i] == ' ')
                                        {
                                            range.CharacterFormat.CharacterSpacing = 0.05f;
                                        }
                                    }
                                }
                                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                                {
                                    string filename = saveFileDialog1.FileName;
                                    labelPathSaveFile.Text = Path.GetFullPath(filename);
                                    pathSaveReceivedFile = Path.GetFullPath(filename);
                                    if (strFormatExport == "Doc") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Doc); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Docx") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Docx); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Docm") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Docm); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Dot") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Dot); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Dotm") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Dotm); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Dotx") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Dotx); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Xml") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Xml); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                    if (strFormatExport == "Rtf") { doc.SaveToFile(pathSaveReceivedFile, FileFormat.Rtf); labelForStatusScritiya.Text = "СООБЩЕНИЕ СКРЫТО УСПЕШНО!"; }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Значение Апроша для \nнулевого и единичного битa \nне должно совпадать!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Выберите все параметры!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Количество символов в выбранном тексте недостаточно\nдля сокрытия сообщения такой длины!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Введите сообщение, которое\nнужно скрыть!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите файл с текстом!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static string ConvertToByte(string str)
        {
            string messBits = "",currMess="";
            for(int j = 0; j < str.Length; j++)
            {
                if(str[j]!=' ')
                {
                    currMess += str[j];
                }
                else
                {
                    var a = Convert.ToString(Convert.ToInt32(currMess),2);
                    currMess = "";
                    foreach (var ch in a) { messBits += ch; }
                    messBits += " ";
                } 
            }
            return messBits;
        }
        static string ConvertToASCII(string stascii)
        {
            string strForASCIIMess = "";
            foreach(char ch in stascii)
            {
                strForASCIIMess += Convert.ToInt32(ch).ToString() + " ";
            }
            return strForASCIIMess;
        }
        static string ConvertToMessage(string binaryStr)
        {
            string strfordecr = "";
            string messBits = "";

            for (int i = 0; i < binaryStr.Length; i++)
            {
                if (binaryStr[i] != ' ')
                {
                    strfordecr += binaryStr[i];
                }
                else
                {
                    var bytes = strfordecr.Split(' ').Select(x => Convert.ToByte(x, 2)).ToArray();
                    messBits += Encoding.ASCII.GetString(bytes);
                    strfordecr = "";
                }
            }
            return messBits;
        }

        private void butForViewFile_Click(object sender, EventArgs e)
        {
            if (pathSaveReceivedFile != "")
            {
                System.Diagnostics.Process.Start(pathSaveReceivedFile);
            }
            else
            {
                MessageBox.Show("Информация не была скрыта!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                doc_filepath = openFileDialog1.FileName;
                label1.Text = Path.GetFullPath(doc_filepath);
                pathDocument = Path.GetFullPath(doc_filepath);
            }
        }

        private void CBForSingleSpacing_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = CBForSingleSpacing.SelectedItem.ToString();
            singleBitValue = float.Parse(selectedState, CultureInfo.InvariantCulture);
        }
        private void CBForCheckColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            strForCheckColor = CBForCheckColor.SelectedItem.ToString();
        }

        private void CDForFormatExpport_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFormatExport = CBForFormatExpport.SelectedItem.ToString();
            if (strFormatExport == "Doc") { saveFileDialog1.Filter = "Doc file(*.doc)|*.doc"; }
            if (strFormatExport == "Docx") { saveFileDialog1.Filter = "Docx file(*.docx)|*.docx";  }
            if (strFormatExport == "Docm") { saveFileDialog1.Filter = "The document is macro-enabled Docm (*.docm)|*.docm";  }
            if (strFormatExport == "Dot") { saveFileDialog1.Filter = "Dot file(*.dot)|*.dot";  }
            if (strFormatExport == "Dotm") { saveFileDialog1.Filter = "Template with macro support Dotm (*.dotm)|*.dotm";  }
            if (strFormatExport == "Dotx") { saveFileDialog1.Filter = "Template Dotx (*.dotx)|*.dotx";  }
            if (strFormatExport == "Xml") { saveFileDialog1.Filter = "XML file(*.xml)|*.xml";  }
            if (strFormatExport == "Rtf") { saveFileDialog1.Filter = "Rtf file(*.rtf)|*.rtf"; }
        }

        private void comboBoxForSpacing_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = CBForZeroSpacing.SelectedItem.ToString();
            zeroBitValue = float.Parse(selectedState, CultureInfo.InvariantCulture);
        }
       
    }
}
