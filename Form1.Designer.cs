namespace Vigenere_Cipher
{
    partial class Form1
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
            this.EncDecbtn = new FontAwesome.Sharp.IconButton();
            this.ciOnlybtn = new FontAwesome.Sharp.IconButton();
            this.ciTextbtn = new FontAwesome.Sharp.IconButton();
            this.chTextbtn = new FontAwesome.Sharp.IconButton();
            this.EncDecPanel = new System.Windows.Forms.Panel();
            this.EncDecKeylengthlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveEndDecbtn = new FontAwesome.Sharp.IconButton();
            this.EncDecResultText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Decryptbtn = new FontAwesome.Sharp.IconButton();
            this.Encryptbtn = new FontAwesome.Sharp.IconButton();
            this.KeyText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenKeybtn = new FontAwesome.Sharp.IconButton();
            this.OpenEncDecFilebtn = new FontAwesome.Sharp.IconButton();
            this.EncDecText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chTextPanel = new System.Windows.Forms.Panel();
            this.chSavekeytbn = new FontAwesome.Sharp.IconButton();
            this.chFindKeyText = new System.Windows.Forms.RichTextBox();
            this.chFindKeybtn = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chKeyLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chOpenCtextbtn = new FontAwesome.Sharp.IconButton();
            this.chCText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chOpenPtextbtn = new FontAwesome.Sharp.IconButton();
            this.chPText = new System.Windows.Forms.RichTextBox();
            this.ciTextPanel = new System.Windows.Forms.Panel();
            this.ciSavePtextbtn = new FontAwesome.Sharp.IconButton();
            this.ciPtext = new System.Windows.Forms.RichTextBox();
            this.ciDecryptbtn = new FontAwesome.Sharp.IconButton();
            this.ciSelectedKey = new System.Windows.Forms.FlowLayoutPanel();
            this.ciSelectAkeyLabel = new System.Windows.Forms.Label();
            this.ciPossibleKeyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ciFindPossib = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ciKeyLength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ciOpenCTextbtn = new FontAwesome.Sharp.IconButton();
            this.ciCText = new System.Windows.Forms.RichTextBox();
            this.coTextPanel = new System.Windows.Forms.Panel();
            this.coClicklabel = new System.Windows.Forms.Label();
            this.coPossibKLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.coSavePtextbtn = new FontAwesome.Sharp.IconButton();
            this.coPtext = new System.Windows.Forms.RichTextBox();
            this.coDecryptbtn = new FontAwesome.Sharp.IconButton();
            this.coSelectedKey = new System.Windows.Forms.FlowLayoutPanel();
            this.coSelectKeylabel = new System.Windows.Forms.Label();
            this.coPossibPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.coGuessKLbtn = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.coOpenCtextbtn = new FontAwesome.Sharp.IconButton();
            this.coCText = new System.Windows.Forms.RichTextBox();
            this.EncDecPanel.SuspendLayout();
            this.chTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKeyLength)).BeginInit();
            this.ciTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciKeyLength)).BeginInit();
            this.coTextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncDecbtn
            // 
            this.EncDecbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.EncDecbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncDecbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncDecbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncDecbtn.ForeColor = System.Drawing.Color.LawnGreen;
            this.EncDecbtn.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.EncDecbtn.IconColor = System.Drawing.Color.LawnGreen;
            this.EncDecbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EncDecbtn.Location = new System.Drawing.Point(12, 12);
            this.EncDecbtn.Name = "EncDecbtn";
            this.EncDecbtn.Size = new System.Drawing.Size(330, 67);
            this.EncDecbtn.TabIndex = 0;
            this.EncDecbtn.Text = "Encrypt / Decrypt";
            this.EncDecbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncDecbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EncDecbtn.UseVisualStyleBackColor = false;
            this.EncDecbtn.Click += new System.EventHandler(this.EncDecbtn_Click);
            // 
            // ciOnlybtn
            // 
            this.ciOnlybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciOnlybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciOnlybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ciOnlybtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciOnlybtn.ForeColor = System.Drawing.Color.Gold;
            this.ciOnlybtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ciOnlybtn.IconColor = System.Drawing.Color.Gold;
            this.ciOnlybtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciOnlybtn.Location = new System.Drawing.Point(1020, 12);
            this.ciOnlybtn.Name = "ciOnlybtn";
            this.ciOnlybtn.Size = new System.Drawing.Size(330, 67);
            this.ciOnlybtn.TabIndex = 1;
            this.ciOnlybtn.Text = "Cipher Text Only";
            this.ciOnlybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ciOnlybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ciOnlybtn.UseVisualStyleBackColor = false;
            this.ciOnlybtn.Click += new System.EventHandler(this.ciOnlybtn_Click);
            // 
            // ciTextbtn
            // 
            this.ciTextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciTextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciTextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ciTextbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciTextbtn.ForeColor = System.Drawing.Color.Cyan;
            this.ciTextbtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ciTextbtn.IconColor = System.Drawing.Color.Cyan;
            this.ciTextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciTextbtn.Location = new System.Drawing.Point(684, 12);
            this.ciTextbtn.Name = "ciTextbtn";
            this.ciTextbtn.Size = new System.Drawing.Size(330, 67);
            this.ciTextbtn.TabIndex = 2;
            this.ciTextbtn.Text = "Cipher Text W/Key Length";
            this.ciTextbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ciTextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ciTextbtn.UseVisualStyleBackColor = false;
            this.ciTextbtn.Click += new System.EventHandler(this.ciTextbtn_Click);
            // 
            // chTextbtn
            // 
            this.chTextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.chTextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chTextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chTextbtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTextbtn.ForeColor = System.Drawing.Color.Tomato;
            this.chTextbtn.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.chTextbtn.IconColor = System.Drawing.Color.Tomato;
            this.chTextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chTextbtn.Location = new System.Drawing.Point(348, 12);
            this.chTextbtn.Name = "chTextbtn";
            this.chTextbtn.Size = new System.Drawing.Size(330, 67);
            this.chTextbtn.TabIndex = 3;
            this.chTextbtn.Text = "Chosen Text W/Key Length";
            this.chTextbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chTextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chTextbtn.UseVisualStyleBackColor = false;
            this.chTextbtn.Click += new System.EventHandler(this.chTextbtn_Click);
            // 
            // EncDecPanel
            // 
            this.EncDecPanel.Controls.Add(this.EncDecKeylengthlabel);
            this.EncDecPanel.Controls.Add(this.label9);
            this.EncDecPanel.Controls.Add(this.SaveEndDecbtn);
            this.EncDecPanel.Controls.Add(this.EncDecResultText);
            this.EncDecPanel.Controls.Add(this.label3);
            this.EncDecPanel.Controls.Add(this.Decryptbtn);
            this.EncDecPanel.Controls.Add(this.Encryptbtn);
            this.EncDecPanel.Controls.Add(this.KeyText);
            this.EncDecPanel.Controls.Add(this.label2);
            this.EncDecPanel.Controls.Add(this.OpenKeybtn);
            this.EncDecPanel.Controls.Add(this.OpenEncDecFilebtn);
            this.EncDecPanel.Controls.Add(this.EncDecText);
            this.EncDecPanel.Controls.Add(this.label1);
            this.EncDecPanel.Location = new System.Drawing.Point(12, 85);
            this.EncDecPanel.Name = "EncDecPanel";
            this.EncDecPanel.Size = new System.Drawing.Size(1338, 692);
            this.EncDecPanel.TabIndex = 4;
            this.EncDecPanel.Visible = false;
            // 
            // EncDecKeylengthlabel
            // 
            this.EncDecKeylengthlabel.AutoSize = true;
            this.EncDecKeylengthlabel.ForeColor = System.Drawing.Color.White;
            this.EncDecKeylengthlabel.Location = new System.Drawing.Point(1002, 346);
            this.EncDecKeylengthlabel.Name = "EncDecKeylengthlabel";
            this.EncDecKeylengthlabel.Size = new System.Drawing.Size(0, 21);
            this.EncDecKeylengthlabel.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(891, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Key length =";
            // 
            // SaveEndDecbtn
            // 
            this.SaveEndDecbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.SaveEndDecbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveEndDecbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEndDecbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEndDecbtn.ForeColor = System.Drawing.Color.Lime;
            this.SaveEndDecbtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.SaveEndDecbtn.IconColor = System.Drawing.Color.Lime;
            this.SaveEndDecbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveEndDecbtn.IconSize = 40;
            this.SaveEndDecbtn.Location = new System.Drawing.Point(474, 641);
            this.SaveEndDecbtn.Name = "SaveEndDecbtn";
            this.SaveEndDecbtn.Size = new System.Drawing.Size(387, 48);
            this.SaveEndDecbtn.TabIndex = 10;
            this.SaveEndDecbtn.Text = "Save the Result";
            this.SaveEndDecbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveEndDecbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveEndDecbtn.UseVisualStyleBackColor = false;
            this.SaveEndDecbtn.Click += new System.EventHandler(this.SaveEndDecbtn_Click);
            // 
            // EncDecResultText
            // 
            this.EncDecResultText.BackColor = System.Drawing.Color.LightGray;
            this.EncDecResultText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncDecResultText.Location = new System.Drawing.Point(27, 438);
            this.EncDecResultText.Name = "EncDecResultText";
            this.EncDecResultText.Size = new System.Drawing.Size(1282, 197);
            this.EncDecResultText.TabIndex = 9;
            this.EncDecResultText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(659, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // Decryptbtn
            // 
            this.Decryptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Decryptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decryptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decryptbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryptbtn.ForeColor = System.Drawing.Color.Red;
            this.Decryptbtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.Decryptbtn.IconColor = System.Drawing.Color.Red;
            this.Decryptbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Decryptbtn.Location = new System.Drawing.Point(687, 363);
            this.Decryptbtn.Name = "Decryptbtn";
            this.Decryptbtn.Size = new System.Drawing.Size(174, 56);
            this.Decryptbtn.TabIndex = 7;
            this.Decryptbtn.Text = "Decrypt";
            this.Decryptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Decryptbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Decryptbtn.UseVisualStyleBackColor = false;
            this.Decryptbtn.Click += new System.EventHandler(this.Decryptbtn_Click);
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.Encryptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encryptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encryptbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryptbtn.ForeColor = System.Drawing.Color.Lime;
            this.Encryptbtn.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.Encryptbtn.IconColor = System.Drawing.Color.Lime;
            this.Encryptbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Encryptbtn.Location = new System.Drawing.Point(474, 363);
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.Size = new System.Drawing.Size(174, 56);
            this.Encryptbtn.TabIndex = 6;
            this.Encryptbtn.Text = "Encrypt";
            this.Encryptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Encryptbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Encryptbtn.UseVisualStyleBackColor = false;
            this.Encryptbtn.Click += new System.EventHandler(this.Encryptbtn_Click);
            // 
            // KeyText
            // 
            this.KeyText.BackColor = System.Drawing.Color.Gold;
            this.KeyText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.ForeColor = System.Drawing.Color.Black;
            this.KeyText.Location = new System.Drawing.Point(687, 289);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(622, 48);
            this.KeyText.TabIndex = 5;
            this.KeyText.Text = "";
            this.KeyText.TextChanged += new System.EventHandler(this.KeyText_TextChanged);
            this.KeyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(523, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Write or open Key";
            // 
            // OpenKeybtn
            // 
            this.OpenKeybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.OpenKeybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenKeybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenKeybtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenKeybtn.ForeColor = System.Drawing.Color.Gold;
            this.OpenKeybtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.OpenKeybtn.IconColor = System.Drawing.Color.Gold;
            this.OpenKeybtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OpenKeybtn.Location = new System.Drawing.Point(144, 289);
            this.OpenKeybtn.Name = "OpenKeybtn";
            this.OpenKeybtn.Size = new System.Drawing.Size(369, 48);
            this.OpenKeybtn.TabIndex = 3;
            this.OpenKeybtn.Text = "Open Key file";
            this.OpenKeybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenKeybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OpenKeybtn.UseVisualStyleBackColor = false;
            this.OpenKeybtn.Click += new System.EventHandler(this.OpenKeybtn_Click);
            // 
            // OpenEncDecFilebtn
            // 
            this.OpenEncDecFilebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.OpenEncDecFilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenEncDecFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenEncDecFilebtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenEncDecFilebtn.ForeColor = System.Drawing.Color.Lime;
            this.OpenEncDecFilebtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.OpenEncDecFilebtn.IconColor = System.Drawing.Color.Lime;
            this.OpenEncDecFilebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OpenEncDecFilebtn.Location = new System.Drawing.Point(13, 83);
            this.OpenEncDecFilebtn.Name = "OpenEncDecFilebtn";
            this.OpenEncDecFilebtn.Size = new System.Drawing.Size(125, 127);
            this.OpenEncDecFilebtn.TabIndex = 2;
            this.OpenEncDecFilebtn.Text = "Open Plain-Text/\r\nCipher-Text file";
            this.OpenEncDecFilebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenEncDecFilebtn.UseVisualStyleBackColor = false;
            this.OpenEncDecFilebtn.Click += new System.EventHandler(this.OpenEncDecFilebtn_Click);
            // 
            // EncDecText
            // 
            this.EncDecText.BackColor = System.Drawing.Color.LightGray;
            this.EncDecText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncDecText.Location = new System.Drawing.Point(144, 38);
            this.EncDecText.Name = "EncDecText";
            this.EncDecText.Size = new System.Drawing.Size(1165, 224);
            this.EncDecText.TabIndex = 1;
            this.EncDecText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(523, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write or open Plain-Text/Cipher-Text file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chTextPanel
            // 
            this.chTextPanel.Controls.Add(this.chSavekeytbn);
            this.chTextPanel.Controls.Add(this.chFindKeyText);
            this.chTextPanel.Controls.Add(this.chFindKeybtn);
            this.chTextPanel.Controls.Add(this.label6);
            this.chTextPanel.Controls.Add(this.chKeyLength);
            this.chTextPanel.Controls.Add(this.label5);
            this.chTextPanel.Controls.Add(this.chOpenCtextbtn);
            this.chTextPanel.Controls.Add(this.chCText);
            this.chTextPanel.Controls.Add(this.label4);
            this.chTextPanel.Controls.Add(this.chOpenPtextbtn);
            this.chTextPanel.Controls.Add(this.chPText);
            this.chTextPanel.Location = new System.Drawing.Point(18, 82);
            this.chTextPanel.Name = "chTextPanel";
            this.chTextPanel.Size = new System.Drawing.Size(1338, 692);
            this.chTextPanel.TabIndex = 5;
            this.chTextPanel.Visible = false;
            // 
            // chSavekeytbn
            // 
            this.chSavekeytbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.chSavekeytbn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chSavekeytbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chSavekeytbn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSavekeytbn.ForeColor = System.Drawing.Color.Tomato;
            this.chSavekeytbn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.chSavekeytbn.IconColor = System.Drawing.Color.Tomato;
            this.chSavekeytbn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chSavekeytbn.IconSize = 40;
            this.chSavekeytbn.Location = new System.Drawing.Point(19, 609);
            this.chSavekeytbn.Name = "chSavekeytbn";
            this.chSavekeytbn.Size = new System.Drawing.Size(194, 48);
            this.chSavekeytbn.TabIndex = 13;
            this.chSavekeytbn.Text = "Save the Key";
            this.chSavekeytbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chSavekeytbn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chSavekeytbn.UseVisualStyleBackColor = false;
            this.chSavekeytbn.Click += new System.EventHandler(this.chSavekeytbn_Click);
            // 
            // chFindKeyText
            // 
            this.chFindKeyText.BackColor = System.Drawing.Color.Gold;
            this.chFindKeyText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chFindKeyText.ForeColor = System.Drawing.Color.Black;
            this.chFindKeyText.Location = new System.Drawing.Point(231, 609);
            this.chFindKeyText.Name = "chFindKeyText";
            this.chFindKeyText.ReadOnly = true;
            this.chFindKeyText.Size = new System.Drawing.Size(951, 48);
            this.chFindKeyText.TabIndex = 12;
            this.chFindKeyText.Text = "";
            // 
            // chFindKeybtn
            // 
            this.chFindKeybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.chFindKeybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chFindKeybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chFindKeybtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chFindKeybtn.ForeColor = System.Drawing.Color.Tomato;
            this.chFindKeybtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.chFindKeybtn.IconColor = System.Drawing.Color.Tomato;
            this.chFindKeybtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chFindKeybtn.Location = new System.Drawing.Point(478, 540);
            this.chFindKeybtn.Name = "chFindKeybtn";
            this.chFindKeybtn.Size = new System.Drawing.Size(387, 48);
            this.chFindKeybtn.TabIndex = 11;
            this.chFindKeybtn.Text = "Find the Key";
            this.chFindKeybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chFindKeybtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chFindKeybtn.UseVisualStyleBackColor = false;
            this.chFindKeybtn.Click += new System.EventHandler(this.chFindKeybtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(554, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key length =";
            // 
            // chKeyLength
            // 
            this.chKeyLength.Location = new System.Drawing.Point(666, 496);
            this.chKeyLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.chKeyLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chKeyLength.Name = "chKeyLength";
            this.chKeyLength.Size = new System.Drawing.Size(120, 28);
            this.chKeyLength.TabIndex = 9;
            this.chKeyLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(577, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Write or open Cipher-Text";
            // 
            // chOpenCtextbtn
            // 
            this.chOpenCtextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.chOpenCtextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chOpenCtextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chOpenCtextbtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOpenCtextbtn.ForeColor = System.Drawing.Color.Cyan;
            this.chOpenCtextbtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.chOpenCtextbtn.IconColor = System.Drawing.Color.Cyan;
            this.chOpenCtextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chOpenCtextbtn.Location = new System.Drawing.Point(19, 298);
            this.chOpenCtextbtn.Name = "chOpenCtextbtn";
            this.chOpenCtextbtn.Size = new System.Drawing.Size(125, 127);
            this.chOpenCtextbtn.TabIndex = 7;
            this.chOpenCtextbtn.Text = "Open Cipher-Text";
            this.chOpenCtextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chOpenCtextbtn.UseVisualStyleBackColor = false;
            this.chOpenCtextbtn.Click += new System.EventHandler(this.chOpenCtextbtn_Click);
            // 
            // chCText
            // 
            this.chCText.BackColor = System.Drawing.Color.LightGray;
            this.chCText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCText.Location = new System.Drawing.Point(150, 271);
            this.chCText.Name = "chCText";
            this.chCText.Size = new System.Drawing.Size(1165, 190);
            this.chCText.TabIndex = 6;
            this.chCText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(577, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Write or open Plain-Text";
            // 
            // chOpenPtextbtn
            // 
            this.chOpenPtextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.chOpenPtextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chOpenPtextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chOpenPtextbtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOpenPtextbtn.ForeColor = System.Drawing.Color.Tomato;
            this.chOpenPtextbtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.chOpenPtextbtn.IconColor = System.Drawing.Color.Tomato;
            this.chOpenPtextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chOpenPtextbtn.Location = new System.Drawing.Point(19, 58);
            this.chOpenPtextbtn.Name = "chOpenPtextbtn";
            this.chOpenPtextbtn.Size = new System.Drawing.Size(125, 127);
            this.chOpenPtextbtn.TabIndex = 4;
            this.chOpenPtextbtn.Text = "Open Plain-Text";
            this.chOpenPtextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chOpenPtextbtn.UseVisualStyleBackColor = false;
            this.chOpenPtextbtn.Click += new System.EventHandler(this.chOpenPtextbtn_Click);
            // 
            // chPText
            // 
            this.chPText.BackColor = System.Drawing.Color.LightGray;
            this.chPText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPText.Location = new System.Drawing.Point(150, 41);
            this.chPText.Name = "chPText";
            this.chPText.Size = new System.Drawing.Size(1165, 190);
            this.chPText.TabIndex = 3;
            this.chPText.Text = "";
            // 
            // ciTextPanel
            // 
            this.ciTextPanel.Controls.Add(this.ciSavePtextbtn);
            this.ciTextPanel.Controls.Add(this.ciPtext);
            this.ciTextPanel.Controls.Add(this.ciDecryptbtn);
            this.ciTextPanel.Controls.Add(this.ciSelectedKey);
            this.ciTextPanel.Controls.Add(this.ciSelectAkeyLabel);
            this.ciTextPanel.Controls.Add(this.ciPossibleKeyPanel);
            this.ciTextPanel.Controls.Add(this.ciFindPossib);
            this.ciTextPanel.Controls.Add(this.label8);
            this.ciTextPanel.Controls.Add(this.ciKeyLength);
            this.ciTextPanel.Controls.Add(this.label7);
            this.ciTextPanel.Controls.Add(this.ciOpenCTextbtn);
            this.ciTextPanel.Controls.Add(this.ciCText);
            this.ciTextPanel.Location = new System.Drawing.Point(25, 79);
            this.ciTextPanel.Name = "ciTextPanel";
            this.ciTextPanel.Size = new System.Drawing.Size(1338, 692);
            this.ciTextPanel.TabIndex = 6;
            this.ciTextPanel.Visible = false;
            // 
            // ciSavePtextbtn
            // 
            this.ciSavePtextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciSavePtextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciSavePtextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciSavePtextbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciSavePtextbtn.ForeColor = System.Drawing.Color.Cyan;
            this.ciSavePtextbtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.ciSavePtextbtn.IconColor = System.Drawing.Color.Cyan;
            this.ciSavePtextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciSavePtextbtn.IconSize = 40;
            this.ciSavePtextbtn.Location = new System.Drawing.Point(14, 554);
            this.ciSavePtextbtn.Name = "ciSavePtextbtn";
            this.ciSavePtextbtn.Size = new System.Drawing.Size(118, 126);
            this.ciSavePtextbtn.TabIndex = 20;
            this.ciSavePtextbtn.Text = "Save the Plain Text";
            this.ciSavePtextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ciSavePtextbtn.UseVisualStyleBackColor = false;
            this.ciSavePtextbtn.Visible = false;
            this.ciSavePtextbtn.Click += new System.EventHandler(this.ciSavePtextbtn_Click);
            // 
            // ciPtext
            // 
            this.ciPtext.BackColor = System.Drawing.Color.LightGray;
            this.ciPtext.Location = new System.Drawing.Point(138, 554);
            this.ciPtext.Name = "ciPtext";
            this.ciPtext.ReadOnly = true;
            this.ciPtext.Size = new System.Drawing.Size(1165, 126);
            this.ciPtext.TabIndex = 19;
            this.ciPtext.Text = "";
            this.ciPtext.Visible = false;
            // 
            // ciDecryptbtn
            // 
            this.ciDecryptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciDecryptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciDecryptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciDecryptbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciDecryptbtn.ForeColor = System.Drawing.Color.Red;
            this.ciDecryptbtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.ciDecryptbtn.IconColor = System.Drawing.Color.Red;
            this.ciDecryptbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciDecryptbtn.IconSize = 40;
            this.ciDecryptbtn.Location = new System.Drawing.Point(574, 501);
            this.ciDecryptbtn.Name = "ciDecryptbtn";
            this.ciDecryptbtn.Size = new System.Drawing.Size(174, 44);
            this.ciDecryptbtn.TabIndex = 18;
            this.ciDecryptbtn.Text = "Decrypt";
            this.ciDecryptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ciDecryptbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ciDecryptbtn.UseVisualStyleBackColor = false;
            this.ciDecryptbtn.Visible = false;
            this.ciDecryptbtn.Click += new System.EventHandler(this.ciDecryptbtn_Click);
            // 
            // ciSelectedKey
            // 
            this.ciSelectedKey.AutoScroll = true;
            this.ciSelectedKey.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciSelectedKey.Location = new System.Drawing.Point(169, 452);
            this.ciSelectedKey.Name = "ciSelectedKey";
            this.ciSelectedKey.Size = new System.Drawing.Size(1139, 41);
            this.ciSelectedKey.TabIndex = 17;
            this.ciSelectedKey.WrapContents = false;
            // 
            // ciSelectAkeyLabel
            // 
            this.ciSelectAkeyLabel.AutoSize = true;
            this.ciSelectAkeyLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ciSelectAkeyLabel.Location = new System.Drawing.Point(10, 464);
            this.ciSelectAkeyLabel.Name = "ciSelectAkeyLabel";
            this.ciSelectAkeyLabel.Size = new System.Drawing.Size(153, 21);
            this.ciSelectAkeyLabel.TabIndex = 16;
            this.ciSelectAkeyLabel.Text = "Select a key to test";
            this.ciSelectAkeyLabel.Visible = false;
            // 
            // ciPossibleKeyPanel
            // 
            this.ciPossibleKeyPanel.AutoScroll = true;
            this.ciPossibleKeyPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciPossibleKeyPanel.Location = new System.Drawing.Point(12, 235);
            this.ciPossibleKeyPanel.Name = "ciPossibleKeyPanel";
            this.ciPossibleKeyPanel.Size = new System.Drawing.Size(1294, 211);
            this.ciPossibleKeyPanel.TabIndex = 15;
            this.ciPossibleKeyPanel.WrapContents = false;
            // 
            // ciFindPossib
            // 
            this.ciFindPossib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciFindPossib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciFindPossib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciFindPossib.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciFindPossib.ForeColor = System.Drawing.Color.Cyan;
            this.ciFindPossib.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.ciFindPossib.IconColor = System.Drawing.Color.Cyan;
            this.ciFindPossib.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciFindPossib.IconSize = 35;
            this.ciFindPossib.Location = new System.Drawing.Point(461, 186);
            this.ciFindPossib.Name = "ciFindPossib";
            this.ciFindPossib.Size = new System.Drawing.Size(387, 40);
            this.ciFindPossib.TabIndex = 14;
            this.ciFindPossib.Text = "Find the Possibilities";
            this.ciFindPossib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ciFindPossib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ciFindPossib.UseVisualStyleBackColor = false;
            this.ciFindPossib.Click += new System.EventHandler(this.ciFindPossib_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(147, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Key length =";
            // 
            // ciKeyLength
            // 
            this.ciKeyLength.Location = new System.Drawing.Point(259, 194);
            this.ciKeyLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ciKeyLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ciKeyLength.Name = "ciKeyLength";
            this.ciKeyLength.Size = new System.Drawing.Size(120, 28);
            this.ciKeyLength.TabIndex = 12;
            this.ciKeyLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(570, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Write or open Cipher-Text";
            // 
            // ciOpenCTextbtn
            // 
            this.ciOpenCTextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.ciOpenCTextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciOpenCTextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciOpenCTextbtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciOpenCTextbtn.ForeColor = System.Drawing.Color.Cyan;
            this.ciOpenCTextbtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.ciOpenCTextbtn.IconColor = System.Drawing.Color.Cyan;
            this.ciOpenCTextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ciOpenCTextbtn.Location = new System.Drawing.Point(12, 44);
            this.ciOpenCTextbtn.Name = "ciOpenCTextbtn";
            this.ciOpenCTextbtn.Size = new System.Drawing.Size(125, 136);
            this.ciOpenCTextbtn.TabIndex = 10;
            this.ciOpenCTextbtn.Text = "Open Cipher-Text";
            this.ciOpenCTextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ciOpenCTextbtn.UseVisualStyleBackColor = false;
            this.ciOpenCTextbtn.Click += new System.EventHandler(this.ciOpenCTextbtn_Click);
            // 
            // ciCText
            // 
            this.ciCText.BackColor = System.Drawing.Color.LightGray;
            this.ciCText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciCText.Location = new System.Drawing.Point(143, 44);
            this.ciCText.Name = "ciCText";
            this.ciCText.Size = new System.Drawing.Size(1165, 136);
            this.ciCText.TabIndex = 9;
            this.ciCText.Text = "";
            // 
            // coTextPanel
            // 
            this.coTextPanel.Controls.Add(this.coClicklabel);
            this.coTextPanel.Controls.Add(this.coPossibKLPanel);
            this.coTextPanel.Controls.Add(this.coSavePtextbtn);
            this.coTextPanel.Controls.Add(this.coPtext);
            this.coTextPanel.Controls.Add(this.coDecryptbtn);
            this.coTextPanel.Controls.Add(this.coSelectedKey);
            this.coTextPanel.Controls.Add(this.coSelectKeylabel);
            this.coTextPanel.Controls.Add(this.coPossibPanel);
            this.coTextPanel.Controls.Add(this.coGuessKLbtn);
            this.coTextPanel.Controls.Add(this.label11);
            this.coTextPanel.Controls.Add(this.coOpenCtextbtn);
            this.coTextPanel.Controls.Add(this.coCText);
            this.coTextPanel.Location = new System.Drawing.Point(37, 76);
            this.coTextPanel.Name = "coTextPanel";
            this.coTextPanel.Size = new System.Drawing.Size(1338, 692);
            this.coTextPanel.TabIndex = 7;
            this.coTextPanel.Visible = false;
            // 
            // coClicklabel
            // 
            this.coClicklabel.AutoSize = true;
            this.coClicklabel.ForeColor = System.Drawing.Color.Gold;
            this.coClicklabel.Location = new System.Drawing.Point(842, 174);
            this.coClicklabel.Name = "coClicklabel";
            this.coClicklabel.Size = new System.Drawing.Size(466, 21);
            this.coClicklabel.TabIndex = 33;
            this.coClicklabel.Text = "Click on any key length to find the possible key for that length";
            this.coClicklabel.Visible = false;
            // 
            // coPossibKLPanel
            // 
            this.coPossibKLPanel.AutoScroll = true;
            this.coPossibKLPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coPossibKLPanel.Location = new System.Drawing.Point(258, 172);
            this.coPossibKLPanel.Name = "coPossibKLPanel";
            this.coPossibKLPanel.Size = new System.Drawing.Size(578, 57);
            this.coPossibKLPanel.TabIndex = 30;
            this.coPossibKLPanel.WrapContents = false;
            // 
            // coSavePtextbtn
            // 
            this.coSavePtextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.coSavePtextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coSavePtextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coSavePtextbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coSavePtextbtn.ForeColor = System.Drawing.Color.Gold;
            this.coSavePtextbtn.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.coSavePtextbtn.IconColor = System.Drawing.Color.Gold;
            this.coSavePtextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.coSavePtextbtn.IconSize = 40;
            this.coSavePtextbtn.Location = new System.Drawing.Point(12, 557);
            this.coSavePtextbtn.Name = "coSavePtextbtn";
            this.coSavePtextbtn.Size = new System.Drawing.Size(118, 126);
            this.coSavePtextbtn.TabIndex = 32;
            this.coSavePtextbtn.Text = "Save the Plain Text";
            this.coSavePtextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coSavePtextbtn.UseVisualStyleBackColor = false;
            this.coSavePtextbtn.Visible = false;
            // 
            // coPtext
            // 
            this.coPtext.BackColor = System.Drawing.Color.LightGray;
            this.coPtext.Location = new System.Drawing.Point(138, 557);
            this.coPtext.Name = "coPtext";
            this.coPtext.ReadOnly = true;
            this.coPtext.Size = new System.Drawing.Size(1165, 126);
            this.coPtext.TabIndex = 31;
            this.coPtext.Text = "";
            this.coPtext.Visible = false;
            // 
            // coDecryptbtn
            // 
            this.coDecryptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.coDecryptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coDecryptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coDecryptbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coDecryptbtn.ForeColor = System.Drawing.Color.Red;
            this.coDecryptbtn.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.coDecryptbtn.IconColor = System.Drawing.Color.Red;
            this.coDecryptbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.coDecryptbtn.IconSize = 40;
            this.coDecryptbtn.Location = new System.Drawing.Point(574, 502);
            this.coDecryptbtn.Name = "coDecryptbtn";
            this.coDecryptbtn.Size = new System.Drawing.Size(174, 44);
            this.coDecryptbtn.TabIndex = 30;
            this.coDecryptbtn.Text = "Decrypt";
            this.coDecryptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coDecryptbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.coDecryptbtn.UseVisualStyleBackColor = false;
            this.coDecryptbtn.Visible = false;
            this.coDecryptbtn.Click += new System.EventHandler(this.coDecryptbtn_Click);
            // 
            // coSelectedKey
            // 
            this.coSelectedKey.AutoScroll = true;
            this.coSelectedKey.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coSelectedKey.Location = new System.Drawing.Point(169, 455);
            this.coSelectedKey.Name = "coSelectedKey";
            this.coSelectedKey.Size = new System.Drawing.Size(1139, 41);
            this.coSelectedKey.TabIndex = 29;
            this.coSelectedKey.WrapContents = false;
            // 
            // coSelectKeylabel
            // 
            this.coSelectKeylabel.AutoSize = true;
            this.coSelectKeylabel.ForeColor = System.Drawing.Color.Gold;
            this.coSelectKeylabel.Location = new System.Drawing.Point(10, 467);
            this.coSelectKeylabel.Name = "coSelectKeylabel";
            this.coSelectKeylabel.Size = new System.Drawing.Size(153, 21);
            this.coSelectKeylabel.TabIndex = 28;
            this.coSelectKeylabel.Text = "Select a key to test";
            this.coSelectKeylabel.Visible = false;
            // 
            // coPossibPanel
            // 
            this.coPossibPanel.AutoScroll = true;
            this.coPossibPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coPossibPanel.Location = new System.Drawing.Point(14, 235);
            this.coPossibPanel.Name = "coPossibPanel";
            this.coPossibPanel.Size = new System.Drawing.Size(1294, 214);
            this.coPossibPanel.TabIndex = 27;
            this.coPossibPanel.WrapContents = false;
            // 
            // coGuessKLbtn
            // 
            this.coGuessKLbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.coGuessKLbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coGuessKLbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coGuessKLbtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coGuessKLbtn.ForeColor = System.Drawing.Color.Gold;
            this.coGuessKLbtn.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.coGuessKLbtn.IconColor = System.Drawing.Color.Gold;
            this.coGuessKLbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.coGuessKLbtn.IconSize = 35;
            this.coGuessKLbtn.Location = new System.Drawing.Point(12, 172);
            this.coGuessKLbtn.Name = "coGuessKLbtn";
            this.coGuessKLbtn.Size = new System.Drawing.Size(239, 40);
            this.coGuessKLbtn.TabIndex = 26;
            this.coGuessKLbtn.Text = "Guess the Key length";
            this.coGuessKLbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coGuessKLbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.coGuessKLbtn.UseVisualStyleBackColor = false;
            this.coGuessKLbtn.Click += new System.EventHandler(this.coGuessKLbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(570, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Write or open Cipher-Text";
            // 
            // coOpenCtextbtn
            // 
            this.coOpenCtextbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.coOpenCtextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coOpenCtextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coOpenCtextbtn.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coOpenCtextbtn.ForeColor = System.Drawing.Color.Gold;
            this.coOpenCtextbtn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.coOpenCtextbtn.IconColor = System.Drawing.Color.Gold;
            this.coOpenCtextbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.coOpenCtextbtn.Location = new System.Drawing.Point(12, 44);
            this.coOpenCtextbtn.Name = "coOpenCtextbtn";
            this.coOpenCtextbtn.Size = new System.Drawing.Size(125, 122);
            this.coOpenCtextbtn.TabIndex = 22;
            this.coOpenCtextbtn.Text = "Open Cipher-Text";
            this.coOpenCtextbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.coOpenCtextbtn.UseVisualStyleBackColor = false;
            this.coOpenCtextbtn.Click += new System.EventHandler(this.coOpenCtextbtn_Click);
            // 
            // coCText
            // 
            this.coCText.BackColor = System.Drawing.Color.LightGray;
            this.coCText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coCText.Location = new System.Drawing.Point(143, 44);
            this.coCText.Name = "coCText";
            this.coCText.Size = new System.Drawing.Size(1165, 122);
            this.coCText.TabIndex = 21;
            this.coCText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1368, 789);
            this.Controls.Add(this.chTextbtn);
            this.Controls.Add(this.ciTextbtn);
            this.Controls.Add(this.ciOnlybtn);
            this.Controls.Add(this.EncDecbtn);
            this.Controls.Add(this.coTextPanel);
            this.Controls.Add(this.ciTextPanel);
            this.Controls.Add(this.chTextPanel);
            this.Controls.Add(this.EncDecPanel);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vigenere Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EncDecPanel.ResumeLayout(false);
            this.EncDecPanel.PerformLayout();
            this.chTextPanel.ResumeLayout(false);
            this.chTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKeyLength)).EndInit();
            this.ciTextPanel.ResumeLayout(false);
            this.ciTextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciKeyLength)).EndInit();
            this.coTextPanel.ResumeLayout(false);
            this.coTextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton EncDecbtn;
        private FontAwesome.Sharp.IconButton ciOnlybtn;
        private FontAwesome.Sharp.IconButton ciTextbtn;
        private FontAwesome.Sharp.IconButton chTextbtn;
        private System.Windows.Forms.Panel EncDecPanel;
        private FontAwesome.Sharp.IconButton SaveEndDecbtn;
        private System.Windows.Forms.RichTextBox EncDecResultText;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Decryptbtn;
        private FontAwesome.Sharp.IconButton Encryptbtn;
        private System.Windows.Forms.RichTextBox KeyText;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton OpenKeybtn;
        private FontAwesome.Sharp.IconButton OpenEncDecFilebtn;
        private System.Windows.Forms.RichTextBox EncDecText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel chTextPanel;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton chOpenPtextbtn;
        private System.Windows.Forms.RichTextBox chPText;
        private System.Windows.Forms.RichTextBox chFindKeyText;
        private FontAwesome.Sharp.IconButton chFindKeybtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown chKeyLength;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton chOpenCtextbtn;
        private System.Windows.Forms.RichTextBox chCText;
        private FontAwesome.Sharp.IconButton chSavekeytbn;
        private System.Windows.Forms.Panel ciTextPanel;
        private FontAwesome.Sharp.IconButton ciFindPossib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ciKeyLength;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton ciOpenCTextbtn;
        private System.Windows.Forms.RichTextBox ciCText;
        private System.Windows.Forms.FlowLayoutPanel ciPossibleKeyPanel;
        private System.Windows.Forms.FlowLayoutPanel ciSelectedKey;
        private System.Windows.Forms.Label ciSelectAkeyLabel;
        private System.Windows.Forms.RichTextBox ciPtext;
        private FontAwesome.Sharp.IconButton ciDecryptbtn;
        private FontAwesome.Sharp.IconButton ciSavePtextbtn;
        private System.Windows.Forms.Panel coTextPanel;
        private System.Windows.Forms.Label coClicklabel;
        private System.Windows.Forms.FlowLayoutPanel coPossibKLPanel;
        private FontAwesome.Sharp.IconButton coSavePtextbtn;
        private System.Windows.Forms.RichTextBox coPtext;
        private FontAwesome.Sharp.IconButton coDecryptbtn;
        private System.Windows.Forms.FlowLayoutPanel coSelectedKey;
        private System.Windows.Forms.Label coSelectKeylabel;
        private System.Windows.Forms.FlowLayoutPanel coPossibPanel;
        private FontAwesome.Sharp.IconButton coGuessKLbtn;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton coOpenCtextbtn;
        private System.Windows.Forms.RichTextBox coCText;
        private System.Windows.Forms.Label EncDecKeylengthlabel;
        private System.Windows.Forms.Label label9;
    }
}

