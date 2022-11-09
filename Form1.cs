using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Vigenere_Cipher
{
    public partial class Form1 : Form
    {
        private Panel bottomBorderBtn;
        private IconButton currentBtn;
        private char[] upperAlphabet = new char[26] {'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        private char[] lowerAlphabet = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        private double[] letterFrequency = new double[26] { 8.167, 1.492, 2.782, 4.253, 12.702, 2.228, 2.015, 6.094, 6.996, 0.153, 0.772, 4.025, 2.406, 6.749, 7.507, 1.929, 0.095, 5.987, 6.327, 9.056, 2.758, 0.978, 2.360, 0.150, 1.974, 0.074};
        private int[] key;
        public Form1()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(326, 7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point location = EncDecPanel.Location;
            chTextPanel.Location = location;
            ciTextPanel.Location = location;
            coTextPanel.Location = location;
        }

        // // Design Methods \\
        //
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50, 78, 79);
                currentBtn.Controls.Add(bottomBorderBtn);
                //bottom border button
                bottomBorderBtn.BackColor = currentBtn.ForeColor;
                bottomBorderBtn.Location = new Point(2, 60);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 68, 69);
            }
        }

        private void EncDecbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            EncDecPanel.Visible = true;
            chTextPanel.Visible = false;
            ciTextPanel.Visible = false;
            coTextPanel.Visible = false;
        }

        private void chTextbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            EncDecPanel.Visible = false;
            chTextPanel.Visible = true;
            ciTextPanel.Visible = false;
            coTextPanel.Visible = false;
        }

        private void ciTextbtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            EncDecPanel.Visible = false;
            chTextPanel.Visible = false;
            ciTextPanel.Visible = true;
            coTextPanel.Visible = false;
        }

        private void ciOnlybtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            EncDecPanel.Visible = false;
            chTextPanel.Visible = false;
            ciTextPanel.Visible = false;
            coTextPanel.Visible = true;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void KeyText_TextChanged(object sender, EventArgs e)
        {
            EncDecKeylengthlabel.Text = KeyText.Text.Length.ToString();
        }
        // \\ End of Design Methods //
        //
        // // Interface Methods \\
        //
        // Opening a File
        private string openFile()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    string fileText = File.ReadAllText(fileName);
                    return fileText;
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                MessageBox.Show("There was an error loading your file.");
                return "";
            }
        }
        // Saving a file
        private void saveFile(RichTextBox prevName)
        {
            // Error handling
            if (prevName.Text == "")
            {
                MessageBox.Show("There is nothing to save");
                return;
            }
            //
            //
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save The Selected text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, prevName.Text);
            }
        }
        // Add FlowLayoutPanel for keys to the sent panel
        private void addtoPanel(FlowLayoutPanel pnl,int ciKLength, string name)
        {
            pnl.Controls.Clear();
            
            for (int i = 0; i < ciKLength; i++)
            {
                pnl.Controls.Add(addFLPanel(i , name));
            }
        }
        // Add FlowLayoutPanel dynamically 
        FlowLayoutPanel addFLPanel(int i,string name)
        {
            FlowLayoutPanel F = new FlowLayoutPanel();
            F.Name = name + i.ToString();
            F.Width = 36;
            F.Height = 200;
            F.BackColor = Color.FromArgb(111, 185, 143);
            return F;
        }
        // Add label dynamically
        Label addLabel(char chr, int i,string name)
        {
            Label l = new Label();
            l.Name = name + i.ToString();
            l.ForeColor = Color.Gold;
            l.Text = chr.ToString();
            l.AutoSize = true;
            return l;
        }
        // Add label for the Nth key
        Label addKeyNumLabel(int i)
        {
            i = i + 1;
            Label leb = new Label();
            leb.Text = i.ToString();
            leb.Height = 20;
            leb.ForeColor = Color.White;
            return leb;
        }
        // Add button dynamically
        Button addButton(char chr,int i, int j, string labelname, string btnName, FlowLayoutPanel labelpnl)
        {
            Button b = new Button();
            b.Name = btnName + i.ToString() + j.ToString();
            b.Width = 30;
            b.Height = 30;
            b.Cursor = Cursors.Hand;
            b.BackColor = Color.FromArgb(44, 120, 115);
            b.FlatStyle = FlatStyle.Popup;
            b.ForeColor = Color.Gold;
            b.Text = chr.ToString();
            b.Click += (sender, EventArgs) => { keybtnClick(sender, EventArgs, i, labelname, labelpnl); };
            return b;
        }
        // Button click event handle
        private void keybtnClick(object sender, EventArgs e, int i, string labelname, FlowLayoutPanel labelpnl)
        {
            Button thebtn = (Button)sender;
            labelpnl.Controls[labelname + i.ToString()].Text = thebtn.Text;
        }
        // Add key length button
        Button addKLButton(int val, int i)
        {
            Button b = new Button();
            b.Name = "KLbutton" + i.ToString();
            b.Height = 30;
            b.AutoSize = true;
            b.Cursor = Cursors.Hand;
            b.BackColor = Color.FromArgb(44, 120, 115);
            b.FlatStyle = FlatStyle.Popup;
            b.ForeColor = Color.Gold;
            b.Text = val.ToString();
            b.Click += (sender, EventArgs) => { KLkeybtnClick(sender, EventArgs , val); };
            return b;
        }
        // Add click event to every possible key length of CO
        private void KLkeybtnClick(object sender, EventArgs e, int length)
        {
            // Error handling
            if (coCText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text back and try again");
                coClicklabel.Visible = false;
                coPossibKLPanel.Visible = false;
                return;
            }
            //
            //
            int ciKLength = length;
            string legalStr = legalString(coCText.Text);
            StringBuilder[] sepratedSTR = seperateStr(legalStr, ciKLength);
            double[][] frequency = findFrequency(sepratedSTR, ciKLength);
            char[][] fivebest = findFiveBestFit(frequency, ciKLength, sepratedSTR);

            addtoPanel(coPossibPanel, ciKLength, "coFLPanel");
            coSelectedKey.Controls.Clear();
            for (int i = 0; i < ciKLength; i++)
            {
                Label leb = addKeyNumLabel(i);
                coPossibPanel.Controls["coFLPanel" + i].Controls.Add(leb);
                for (int j = 0; j < 5; j++)
                {
                    Button b = addButton(fivebest[i][j], i, j, "coKeylabel" ,"coKeybutton", coSelectedKey);
                    coPossibPanel.Controls["coFLPanel" + i].Controls.Add(b);
                }
                Label l = addLabel(fivebest[i][0], i, "coKeylabel");
                coSelectedKey.Controls.Add(l);
            }
            coSelectKeylabel.Visible = true;
            coDecryptbtn.Visible = true;
            coPtext.Visible = true;
            coSavePtextbtn.Visible = true;
        }
        private void OpenEncDecFilebtn_Click(object sender, EventArgs e)
        {
            EncDecText.Text = openFile();
        }

        private void OpenKeybtn_Click(object sender, EventArgs e)
        {
            KeyText.Text = openFile();
        }

        private void SaveEndDecbtn_Click(object sender, EventArgs e)
        {
            saveFile(EncDecText);
        }
        private void coOpenCtextbtn_Click(object sender, EventArgs e)
        {
            coCText.Text = openFile();
        }
        private void ciOpenCTextbtn_Click(object sender, EventArgs e)
        {
            ciCText.Text = openFile();
        }

        private void chSavekeytbn_Click(object sender, EventArgs e)
        {
            saveFile(chFindKeyText);
        }

        private void ciSavePtextbtn_Click(object sender, EventArgs e)
        {
            saveFile(ciPtext);
        }
        private void chOpenPtextbtn_Click(object sender, EventArgs e)
        {
            chPText.Text = openFile();
        }

        private void chOpenCtextbtn_Click(object sender, EventArgs e)
        {
            chCText.Text = openFile();
        }
        // \\ End of interface methods //
        //
        // // Coding methods \\
        //
        // Convert a key to an array of corresponding numbers
        private int[] strToNum(string input)
        {
            int[] result = new int[input.Length];
            int count = 0;
            while (input.Length > 0)
            {
                for(int i = 0; i < 26; i++)
                {
                    if(input[0] == lowerAlphabet[i] || input[0] == upperAlphabet[i])
                    {
                        result[count] = i;
                        count++;
                        break;
                    }
                }
                input = input.Remove(0, 1);
            }
            return result;
        }
        // Return the characters of the input which is in our legal alphabets and are transformable
        private string legalString(string input)
        {
            StringBuilder Result = new StringBuilder();
            while (input.Length > 0)
            {
                for (int i = 0; i < 26; i++)
                {
                    if(input[0] == lowerAlphabet[i] || input[0] == upperAlphabet[i])
                    {
                        Result.Append(input[0]);
                        break;
                    }
                }
                input = input.Remove(0, 1);
            }
            return Result.ToString();
        }
        // seperate strings based on the length
        private StringBuilder[] seperateStr(string legalStr, int ciKLength)
        {
            StringBuilder[] seperatedSTR = new StringBuilder[ciKLength];
            for (int ix = 0; ix < ciKLength; ++ix)
            {
                seperatedSTR[ix] = new StringBuilder();
            }


            while (legalStr.Length >= ciKLength)
            {
                for (int i = 0; i < ciKLength; i++)
                {
                    seperatedSTR[i].Append(legalStr[0]);
                    legalStr = legalStr.Remove(0, 1);
                }
            }
            if (legalStr.Length > 0)
            {
                for (int i = 0; i < legalStr.Length; i++)
                {
                    seperatedSTR[i].Append(legalStr[0]);
                    legalStr = legalStr.Remove(0, 1);
                }
            }

            return seperatedSTR;
        }
        // Find the frequency of letters
        private double[][] findFrequency(StringBuilder[] strbld, int length)
        {
            double[][] Result = new double[length][];
            for (int a = 0; a < length; a++)
            {
                Result[a] = new double[26];
            }
            for (int i = 0; i < length; i++)
            {
                // Find alphabets counts
                for (int j = 0; j < strbld[i].Length; j++)
                {
                    for (int k = 0; k < 26; k++)
                    {
                        if (strbld[i][j] == lowerAlphabet[k] || strbld[0][j] == upperAlphabet[k])
                        {
                            Result[i][k]++;
                            break;
                        }
                    }
                }
                // Calculate frequency
                for (int k = 0; k < 26; k++)
                {
                    Result[i][k] = Math.Round((Result[i][k] / strbld[i].Length) * 100, 3);
                }
            }
            

            return Result;
        }
        // shifts the array one to left and replace the most left hand side element to the right
        private double[] shiftLreplace(double[] input)
        {
            double[] Result = new double[26];
            for (int i = 1; i < 26; i++)
            {
                Result[i-1] = input[i];
            }
            Result[25] = input[0];

            return Result;
        }
        
        // Find indexes of 5 lowest numbers
        private int[][] findFiveLowest(double[][] input, int length, StringBuilder[] strbld)
        {
            int[][] Result = new int[length][];
            for (int a = 0; a < length; a++)
            {
                Result[a] = new int[5];
            }
            int pos = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // find index of minimun
                    for (int k = 0; k < 26; k++)
                    {
                        if (input[i][k] < input[i][pos])
                        {
                            pos = k;
                        }
                    }
                    input[i][pos] = strbld[i].Length;
                    Result[i][j] = pos;
                    pos = 0;
                }
            }
            
            return Result;
        }
        // Find Five best fitted letters from the frequency
        private char[][] findFiveBestFit(double[][] frequency, int length, StringBuilder[] strbld)
        {
            char[][] Result = new char[length][];
            for (int a = 0; a < length; a++)
            {
                Result[a] = new char[5];
            }

            double[][] freqDif = new double[length][];
            for (int a = 0; a < length; a++)
            {
                freqDif[a] = new double[26];
            }

            double tempR = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    for (int k = 0; k < 26; k++)
                    {
                        tempR += Math.Abs(frequency[i][k] - letterFrequency[k]);
                    }
                    freqDif[i][j] = tempR;
                    tempR = 0;
                    frequency[i] = shiftLreplace(frequency[i]);
                }
            }
            int[][] fiveBest = findFiveLowest(freqDif, length, strbld);
            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Result[i][j] = lowerAlphabet[fiveBest[i][j]];
                }
            }
            return Result;
        }
        // Find the index of coincidence of the given 3d array
        private double[] findIC(double[][][] freq, int length)
        {
            double[] Result = new double[length];
            double[] tempResultArr = new double[length+1];
            double tempResult = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    for(int k = 0; k < 26; k++)
                    {
                        tempResultArr[j] += Math.Pow(freq[i][j][k], 2);
                    }
                }
                for(int t = 0; t < i + 1; t++)
                {
                    tempResult += tempResultArr[t];
                    tempResultArr[t] = 0;
                }
                Result[i] = Math.Round(tempResult / (i + 1), 3);
                tempResult = 0;
                //tempResultArr = new double[length + 1];
            }
            return Result;
        }
        // find the numbers that are possibly the length of the key
        private int[] findPossibleKeyLengths(double[] IC, int length)
        {
            int[] tempR = new int[length];
            /*
            int max = 0;
            for (int i = 0; i < length; i++)
            {
                if (IC[i] > IC[max])
                {
                    max = i;
                }
            }
            max = max + 1;
            int count = 0;
            for(int i = 2; i < (max / 2) + 1; i++)
            {
                if(max % i == 0)
                {
                    tempR[count] = i;
                    count++;
                }
            }*/
            int count = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (IC[i] > 625)
                {
                    tempR[count] = i+1;
                    count++;
                }
                if (count == 10)
                {
                    break;
                }
            }

            int[] Result = new int[count];
            for(int i = 0; i < count; i++)
            {
                Result[i] = tempR[i];
            }

            return Result;
        }
        // Decryption and Encryption
        private string Transform(string input,int[] key,string type)
        {
            StringBuilder Result = new StringBuilder();
            int count = 0;
            int exist = 0;
            if(type == "enc")
            {
                // If we are Encrypting
                while (input.Length > 0)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (input[0] == lowerAlphabet[i])
                        {
                            Result.Append(lowerAlphabet[(key[count] + i) % 26]);
                            exist = 1;
                            count++;
                            break;
                        }
                        if (input[0] == upperAlphabet[i])
                        {
                            Result.Append(upperAlphabet[(key[count] + i) % 26]);
                            exist = 1;
                            count++;
                            break;
                        }
                    }
                    if (exist == 0)
                    {
                        Result.Append(input[0]);
                    }
                    else
                    {
                        exist = 0;
                    }
                    if (count == key.Length)
                    {
                        count = 0;
                    }
                    input = input.Remove(0, 1);
                }
            }
            else
            {
                // If we are decrypting
                while (input.Length > 0)
                {
                    for (int i = 0; i < 26; i++)
                    {
                        if (input[0] == lowerAlphabet[i])
                        {
                            Result.Append(lowerAlphabet[i - key[count] >= 0 ? i - key[count] : i - key[count] + 26]);
                            exist = 1;
                            count++;
                            break;
                        }
                        if (input[0] == upperAlphabet[i])
                        {
                            Result.Append(upperAlphabet[i - key[count] >= 0 ? i - key[count] : i - key[count] + 26]);
                            exist = 1;
                            count++;
                            break;
                        }
                    }
                    if (exist == 0)
                    {
                        Result.Append(input[0]);
                    }
                    else
                    {
                        exist = 0;
                    }
                    if (count == key.Length)
                    {
                        count = 0;
                    }
                    input = input.Remove(0, 1);
                }
            }
            
            return Result.ToString();
        }

        // Finding the key knowing the key length, cipher text and plain text
        private string chosenTextFindKey(string plainText, string cipherText, int keyLength)
        {
            
            int[] pTextNum = strToNum(legalString(plainText).Substring(0, keyLength));
            int[] cTextNum = strToNum(legalString(cipherText).Substring(0, keyLength));
            StringBuilder Result = new StringBuilder();
            for(int i = 0; i < keyLength; i++)
            {
                Result.Append(lowerAlphabet[cTextNum[i] - pTextNum[i] >= 0 ? cTextNum[i] - pTextNum[i] : cTextNum[i] - pTextNum[i] + 26]);
            }
            return Result.ToString();
        }
        // \\ End of coding methods //
        //
        // // Buttons being clicked \\
        //
        // Encryption button clicked
        private void Encryptbtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if(EncDecText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text/Plain-Text");
                return;
            }
            if (KeyText.Text == "")
            {
                MessageBox.Show("Please insert the Key");
                return;
            }
            if (KeyText.Text.Length > EncDecText.Text.Length)
            {
                MessageBox.Show("The Cipher-Text/Plain-Text must be bigger than the Key");
                return;
            }
            //
            //
            key = strToNum(KeyText.Text);
            EncDecResultText.Text = Transform(EncDecText.Text, key, "enc");
        }
        // Decryption button clicked
        private void Decryptbtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if (EncDecText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text/Plain-Text");
                return;
            }
            if (KeyText.Text == "")
            {
                MessageBox.Show("Please insert the Key");
                return;
            }
            if (KeyText.Text.Length > EncDecText.Text.Length)
            {
                MessageBox.Show("The Cipher-Text/Plain-Text must be bigger than the Key");
                return;
            }
            //
            //
            key = strToNum(KeyText.Text);
            EncDecResultText.Text = Transform(EncDecText.Text, key, "dec");
        }
        // Find the key button clicked (chosen text with key length)
        private void chFindKeybtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if (chCText.Text == "" || chPText.Text == "")
            {
                MessageBox.Show("Please insert the Plain-Text and Cipher-Text first");
                return;
            }
            if (chCText.Text.Length < chKeyLength.Value || chPText.Text.Length < chKeyLength.Value)
            {
                MessageBox.Show("The Cipher-Text and Plain-Text must be bigger than the Key length");
                return;
            }
            if (chCText.Text.Length != chPText.Text.Length)
            {
                MessageBox.Show("The Cipher-Text and Plain-Text must have the same length");
                return;
            }
            //
            //
            chFindKeyText.Text = chosenTextFindKey(chPText.Text, chCText.Text, Convert.ToInt32(chKeyLength.Value));
        }
        // Find the possible keys clicked (cipher text with key length)
        private void ciFindPossib_Click(object sender, EventArgs e)
        {
            // Error handling
            if(ciCText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text first");
                ciPossibleKeyPanel.Visible = false;
                ciSelectedKey.Visible = false;
                ciSelectAkeyLabel.Visible = false;
                ciDecryptbtn.Visible = false;
                ciPtext.Visible = false;
                ciSavePtextbtn.Visible = false;
                return;
            }
            if (ciCText.Text.Length < ciKeyLength.Value)
            {
                MessageBox.Show("The Cipher-Text must be bigger than the Key length");
                ciPossibleKeyPanel.Visible = false;
                ciSelectedKey.Visible = false;
                ciSelectAkeyLabel.Visible = false;
                ciDecryptbtn.Visible = false;
                ciPtext.Visible = false;
                ciSavePtextbtn.Visible = false;
                return;
            }
            //
            //
            int ciKLength = Convert.ToInt32(ciKeyLength.Value);
            string legalStr = legalString(ciCText.Text);
            StringBuilder[] sepratedSTR = seperateStr(legalStr,ciKLength);
            double[][] frequency = findFrequency(sepratedSTR, ciKLength);
            char[][] fivebest = findFiveBestFit(frequency, ciKLength, sepratedSTR);
            
            addtoPanel(ciPossibleKeyPanel,ciKLength, "ciFLPanel");
            ciSelectedKey.Controls.Clear();
            for (int i = 0; i < ciKLength; i++)
            {
                Label leb = addKeyNumLabel(i);
                ciPossibleKeyPanel.Controls["ciFLPanel" + i].Controls.Add(leb);
                for (int j = 0; j < 5; j++)
                {
                    Button b = addButton(fivebest[i][j],i,j,"ciKeylabel" ,"ciKeyButton", ciSelectedKey);
                    ciPossibleKeyPanel.Controls["ciFLPanel" + i].Controls.Add(b);
                }
                Label l = addLabel(fivebest[i][0], i, "ciKeylabel");
                ciSelectedKey.Controls.Add(l);
            }

            ciPossibleKeyPanel.Visible = true;
            ciSelectedKey.Visible = true;
            ciSelectAkeyLabel.Visible = true;
            ciDecryptbtn.Visible = true;
            ciPtext.Visible = true;
            ciSavePtextbtn.Visible = true;
        }
        // Decrpyt button clicked (Cipher text with key)
        private void ciDecryptbtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if (ciCText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text");
                ciPossibleKeyPanel.Visible = false;
                ciSelectedKey.Visible = false;
                ciSelectAkeyLabel.Visible = false;
                ciDecryptbtn.Visible = false;
                ciPtext.Visible = false;
                ciSavePtextbtn.Visible = false;
                return;
            }
            if (ciCText.Text.Length < ciKeyLength.Value)
            {
                MessageBox.Show("The Cipher-Text must be bigger than the Key length");
                ciPossibleKeyPanel.Visible = false;
                ciSelectedKey.Visible = false;
                ciSelectAkeyLabel.Visible = false;
                ciDecryptbtn.Visible = false;
                ciPtext.Visible = false;
                ciSavePtextbtn.Visible = false;
                return;
            }
            //
            //
            StringBuilder keystrbld = new StringBuilder();
            int ciKLength = Convert.ToInt32(ciKeyLength.Value);
            for (int i = 0; i < ciKLength; i++)
            {
                keystrbld.Append(ciSelectedKey.Controls["ciKeylabel" + i.ToString()].Text);
            }
            key = strToNum(keystrbld.ToString());
            ciPtext.Text = Transform(ciCText.Text, key, "dec");
        }
        // Guessing the possible Key length button clicked
        private void coGuessKLbtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if (coCText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text first");
                return;
            }
            //
            //
            string legalStr = legalString(coCText.Text);
            StringBuilder[][] seperatedSTR = new StringBuilder[legalStr.Length / 2][];
            for (int i = 0; i < legalStr.Length / 2 ; i++)
            {
                seperatedSTR[i] = seperateStr(legalStr, i+1);
            }

            double[][][] frequency = new double[legalStr.Length / 2][][];
            for (int i = 0; i < legalStr.Length / 2; i++)
            {
                frequency[i] = new double[i + 1][];
                frequency[i] = findFrequency(seperatedSTR[i], i+1);
            }

            double[] indexCoincidence = findIC(frequency, legalStr.Length / 2);

            int[] possibKeyL = findPossibleKeyLengths(indexCoincidence, legalStr.Length / 2);

            coPossibKLPanel.Controls.Clear();
            for (int i = 0; i < possibKeyL.Length; i++)
            {
                Button bt = addKLButton(possibKeyL[i], i);
                coPossibKLPanel.Controls.Add(bt);
            }
            coClicklabel.Visible = true;
        }
        // Decrypt button clicked (Cipher text only)
        private void coDecryptbtn_Click(object sender, EventArgs e)
        {
            // Error handling
            if (coCText.Text == "")
            {
                MessageBox.Show("Please insert the Cipher-Text back and try again");
                coClicklabel.Visible = false;
                coPossibKLPanel.Visible = false;
                return;
            }
            //
            //
            StringBuilder keystrbld = new StringBuilder();
            int ciKLength = 0;
            foreach (Control c in coSelectedKey.Controls)
            {
                ciKLength++;
            }
            for (int i = 0; i < ciKLength; i++)
            {
                keystrbld.Append(coSelectedKey.Controls["coKeylabel" + i.ToString()].Text);
            }
            key = strToNum(keystrbld.ToString());
            coPtext.Text = Transform(coCText.Text, key, "dec");
        }

        // \\ End of Buttons being clicked //
        //
    }
}