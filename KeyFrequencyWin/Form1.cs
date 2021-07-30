using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyFrequencyWin
{

    public partial class Form1 : Form
    {
        public class VOKey
        {
            public int Ascii = 0;
            public int ClickedCount = 0;
            public int PressedCount = 0;
            public float ClickedPercent = 0;
            public float PressedPercent = 0;
            public string Key = "";
        }

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        private Thread threadKey;
        private Thread threadPercent;
        private int iClickedTotal = 0;
        private int iPressedTotal = 0;
        private static int iMax = 300;
        private VOKey[] aKey = new VOKey[iMax];
        private string sLoadRecordTime="";
        private DateTime dateTimeStart;
        private DateTime dateTimeEnd;
        private string sTimeFormat = "yyyyMMddHHmmss";
        public Form1()
        {
            InitializeComponent();
            dateTimeStart = DateTime.Now;
            dateTimeEnd = DateTime.Now;
            for(int i = 0; i < iMax; i++)
            {
                aKey[i] = new VOKey();
            }
            aKey[0].Key = "Null";
            aKey[1].Key = "Mouse1";
            aKey[2].Key = "Mouse2";
            aKey[3].Key = "ETX";
            aKey[4].Key = "Mouse3";
            aKey[5].Key = "Mouse4";
            aKey[6].Key = "Mouse5";
            aKey[7].Key = "BEL";
            aKey[8].Key = "BS";
            aKey[9].Key = "Tab";
            aKey[10].Key = "";
            aKey[11].Key = "VT";
            aKey[12].Key = "FF";
            aKey[13].Key = "Enter";
            aKey[14].Key = "SO";
            aKey[15].Key = "SI";
            aKey[16].Key = "LShift";
            aKey[17].Key = "LCtrl";
            aKey[18].Key = "LAlt";
            aKey[19].Key = "DC3";
            aKey[20].Key = "DC4";
            aKey[21].Key = "NAK";
            aKey[22].Key = "SYN";
            aKey[23].Key = "ETB";
            aKey[24].Key = "Cancel";
            aKey[25].Key = "EM";
            aKey[26].Key = "SUB";
            aKey[27].Key = "ESC";
            aKey[28].Key = "FS";
            aKey[29].Key = "GS";
            aKey[30].Key = "RS";
            aKey[31].Key = "US";
            aKey[32].Key = "Space";
            aKey[33].Key = "Page Up";
            aKey[34].Key = "Page Down";
            aKey[35].Key = "#";
            aKey[36].Key = "$";
            aKey[37].Key = "Left";
            aKey[38].Key = "Up";
            aKey[39].Key = "Right";
            aKey[40].Key = "Down";
            aKey[41].Key = ")";
            aKey[42].Key = "*";
            aKey[43].Key = "+";
            aKey[44].Key = ",";
            aKey[45].Key = "Insert";
            aKey[46].Key = "Delete";
            aKey[47].Key = "/";
            aKey[48].Key = "0";
            aKey[49].Key = "1";
            aKey[50].Key = "2";
            aKey[51].Key = "3";
            aKey[52].Key = "4";
            aKey[53].Key = "5";
            aKey[54].Key = "6";
            aKey[55].Key = "7";
            aKey[56].Key = "8";
            aKey[57].Key = "9";
            aKey[58].Key = ":";
            aKey[59].Key = ";";
            aKey[60].Key = "<";
            aKey[61].Key = "=";
            aKey[62].Key = ">";
            aKey[63].Key = "?";
            aKey[64].Key = "@";
            aKey[65].Key = "A";
            aKey[66].Key = "B";
            aKey[67].Key = "C";
            aKey[68].Key = "D";
            aKey[69].Key = "E";
            aKey[70].Key = "F";
            aKey[71].Key = "G";
            aKey[72].Key = "H";
            aKey[73].Key = "I";
            aKey[74].Key = "J";
            aKey[75].Key = "K";
            aKey[76].Key = "L";
            aKey[77].Key = "M";
            aKey[78].Key = "N";
            aKey[79].Key = "O";
            aKey[80].Key = "P";
            aKey[81].Key = "Q";
            aKey[82].Key = "R";
            aKey[83].Key = "S";
            aKey[84].Key = "T";
            aKey[85].Key = "U";
            aKey[86].Key = "V";
            aKey[87].Key = "W";
            aKey[88].Key = "X";
            aKey[89].Key = "Y";
            aKey[90].Key = "Z";
            aKey[91].Key = "[";
            aKey[92].Key = "\\";
            aKey[93].Key = "]";
            aKey[94].Key = "^";
            aKey[95].Key = "_";
            aKey[96].Key = "`";
            aKey[97].Key = "a";
            aKey[98].Key = "b";
            aKey[99].Key = "c";
            aKey[100].Key = "d";
            aKey[101].Key = "e";
            aKey[102].Key = "f";
            aKey[103].Key = "g";
            aKey[104].Key = "h";
            aKey[105].Key = "i";
            aKey[106].Key = "j";
            aKey[107].Key = "k";
            aKey[108].Key = "l";
            aKey[109].Key = "m";
            aKey[110].Key = "n";
            aKey[111].Key = "o";
            aKey[112].Key = "p";
            aKey[113].Key = "q";
            aKey[114].Key = "r";
            aKey[115].Key = "s";
            aKey[116].Key = "t";
            aKey[117].Key = "u";
            aKey[118].Key = "v";
            aKey[119].Key = "w";
            aKey[120].Key = "x";
            aKey[121].Key = "y";
            aKey[122].Key = "z";
            aKey[123].Key = "{";
            aKey[124].Key = "|";
            aKey[125].Key = "}";
            aKey[126].Key = "~";
            aKey[127].Key = ""; 
            aKey[160].Key = "LShift2";
            aKey[164].Key = "LAlt2";
            aKey[186].Key = ";";
            aKey[187].Key = "=";
            aKey[188].Key = ",";
            aKey[189].Key = "-";
            aKey[190].Key = ".";
            aKey[191].Key = "/";
            aKey[192].Key = "`";
            aKey[220].Key = "\\";
            aKey[222].Key = "'";
            CheckForIllegalCrossThreadCalls = false;
            for (int i = 0; i < iMax; i++)
            {
                aKey[i].Ascii = i;
                var it = new ListViewItem(i.ToString());
                it.SubItems.Add(aKey[i].Key);
                it.SubItems.Add("0");
                it.SubItems.Add("0%");
                it.SubItems.Add("0");
                it.SubItems.Add("0%");
                listViewKey.Items.Add(it);
            }

        }

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxStart.Checked)
            {
                threadKey = new Thread(new ThreadStart(this.catchKey));
                threadKey.Start();
                threadPercent = new Thread(new ThreadStart(this.calculatePercent));
                threadPercent.Start();
                dateTimeStart = DateTime.Now;
                labelStartTime.Text = dateTimeStart.ToString(sTimeFormat);
            }
            else
            {
                dateTimeEnd = DateTime.Now;
                labelEndTime.Text = dateTimeEnd.ToString(sTimeFormat);
                threadKey.Join();
                threadPercent.Join();
            }
        }

        private void catchKey()
        {
            int KeyState = 0;
            int lastKey =0;
            int resetCount = 0;
            //bool pressed = false;
            while (this.checkBoxStart.Checked == true)
            {
                Thread.Sleep(10);
                for (int i = 0; i < iMax; i++)
                {
                    VOKey key = aKey[i];
                    KeyState = GetAsyncKeyState(key.Ascii);
                    //labelKeyState.Text = KeyState.ToString();
                    if (KeyState == 32769 || KeyState == -32767)
                    {
                        if (lastKey==key.Ascii)
                        //if(pressed)
                        {
                            key.PressedCount += 1;
                            iPressedTotal += 1;
                            labelPressedTotal.Text = iPressedTotal.ToString();
                            resetCount = 0;
                        }
                        else
                        {
                            this.labelAscii.Text = key.Ascii.ToString();
                            this.labelKey.Text = key.Key;
                            this.labelChar.Text =((char)key.Ascii).ToString();
                            iClickedTotal += 1;
                            labelClickedTotal.Text = iClickedTotal.ToString();
                            key.ClickedCount += 1;
                            lastKey = key.Ascii;
                            //pressed = true;
                        }
                        break;
                    }
                }
                /*
                if (KeyState == 32769 || KeyState == -32767)
                {
                }
                else
                {
                    pressed = false;
                }
                */
                resetCount++;
                if (resetCount == 5)
                {
                    resetCount = 0;
                    lastKey = 0;
                }

            }
        }

        private void calculatePercent()
        {
            while (this.checkBoxStart.Checked == true)
            {
                Thread.Sleep(5000);
                showList();
            }
        }
        private void showList()
        {
                for(int i = 0; i < iMax; i++)
                {
                    for(int j = i; j < iMax; j++)
                    {
                        if(aKey[i].ClickedCount < aKey[j].ClickedCount)
                        {
                            VOKey t = aKey[i];
                            aKey[i] = aKey[j];
                            aKey[j] = t;
                        }
                    }
                }

                for (int i = 0; i < iMax; i++)
                {
                    VOKey key = aKey[i];
                    listViewKey.Items[i].SubItems[0].Text = key.Ascii.ToString();
                    listViewKey.Items[i].SubItems[1].Text = key.Key;
                    listViewKey.Items[i].SubItems[2].Text = key.ClickedCount.ToString();
                    key.ClickedPercent = (float)key.ClickedCount / iClickedTotal;
                    listViewKey.Items[i].SubItems[3].Text = (Math.Round(key.ClickedPercent * 100, 2)).ToString() + "%";
                    listViewKey.Items[i].SubItems[4].Text = key.PressedCount.ToString();
                    key.PressedPercent = (float)key.PressedCount / iPressedTotal;
                    listViewKey.Items[i].SubItems[5].Text = (Math.Round(key.PressedPercent * 100, 2)).ToString() + "%";
                }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.checkBoxStart.Checked = false;
            Application.ExitThread();

            Environment.Exit(Environment.ExitCode);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialogRecord.FileName;
                try
                {
                    using(var reader = new StreamReader(file))
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (i == 1)
                            {
                                var para = line.Split(',');
                                iClickedTotal = Int32.Parse(para[3]);
                                labelClickedTotal.Text = para[3];
                                iPressedTotal = Int32.Parse(para[5]);
                                labelPressedTotal.Text = para[5];
                            }
                            if (i > 2)
                            {
                                if (line.Contains("\",\""))
                                    line=line.Replace("\",\"", "comma");
                                var para = line.Split(',');
                                VOKey key = aKey[i - 3];
                                key.Ascii = Int32.Parse(para[0]);
                                key.Key = para[1].Replace("comma", ",").Replace("\"","");
                                key.ClickedCount = Int32.Parse(para[2]);
                                key.PressedCount = Int32.Parse(para[4]);
                            }
                            i++;
                        }
                    }
                    /*
                    var lines=File.ReadAllLines(file);
                    for(int i = 2; i < lines.Length; i++)
                    {
                        string[] para = lines[i].Split(',');
                        VOKey key = aKey[i - 2];
                        key.Ascii = Int32.Parse(para[0]);
                        key.Key = para[1];
                        key.ClickedCount = Int32.Parse(para[2]);
                        key.ClickedPercent = float.Parse(para[3]);
                        key.PressedCount = Int32.Parse(para[4]);
                        key.PressedPercent = float.Parse(para[5]);

                    }*/
                    showList();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogRecord.ShowDialog();
            if(saveFileDialogRecord.FileName != "")
            {
                var csv = new StringBuilder();
                var line = string.Format("Record time:{0},{1}-{2}",sLoadRecordTime, labelStartTime.Text, labelEndTime.Text);
                csv.AppendLine(line);
                TimeSpan duration = dateTimeStart - dateTimeEnd;
                line = string.Format("Total time:,{0},Total Click:,{1},Total Press:,{2}", duration.ToString(@"hh\:mm\:ss"),iClickedTotal.ToString(),iPressedTotal.ToString());
                csv.AppendLine(line);
                line = string.Format("{0},{1},{2},{3},{4},{5}", listViewKey.Columns[0].Text, listViewKey.Columns[1].Text, listViewKey.Columns[2].Text, listViewKey.Columns[3].Text, listViewKey.Columns[4].Text, listViewKey.Columns[5].Text);
                csv.AppendLine(line);
                for (int i = 0; i < iMax; i++)
                {
                    VOKey key = aKey[i];
                    line = string.Format("{0},{1},{2},{3},{4},{5}", key.Ascii, "\""+key.Key+"\"", key.ClickedCount, key.ClickedPercent, key.PressedCount, key.PressedPercent);
                    csv.AppendLine(line);
                }
                File.WriteAllText(saveFileDialogRecord.FileName, csv.ToString());
            }
        }
    }
}
