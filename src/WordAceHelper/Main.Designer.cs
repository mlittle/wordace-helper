namespace WordAceHelper
{
  partial class Main
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
      this.txtHoleCards = new System.Windows.Forms.TextBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.rtfPossibleHands = new System.Windows.Forms.RichTextBox();
      this.txtCommunityCards = new System.Windows.Forms.TextBox();
      this.rtfOpponentHands = new System.Windows.Forms.RichTextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnClear = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtHoleCards
      // 
      this.txtHoleCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHoleCards.Location = new System.Drawing.Point(198, 10);
      this.txtHoleCards.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.txtHoleCards.MaxLength = 2;
      this.txtHoleCards.Name = "txtHoleCards";
      this.txtHoleCards.Size = new System.Drawing.Size(198, 29);
      this.txtHoleCards.TabIndex = 1;
      this.txtHoleCards.Text = "te";
      this.txtHoleCards.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown);
      // 
      // btnCalculate
      // 
      this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnCalculate.AutoSize = true;
      this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnCalculate.Location = new System.Drawing.Point(405, 9);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(130, 31);
      this.btnCalculate.TabIndex = 4;
      this.btnCalculate.Text = "&Calculate!";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.CalculateClick);
      // 
      // rtfPossibleHands
      // 
      this.rtfPossibleHands.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtfPossibleHands.Location = new System.Drawing.Point(9, 30);
      this.rtfPossibleHands.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.rtfPossibleHands.Name = "rtfPossibleHands";
      this.rtfPossibleHands.Size = new System.Drawing.Size(390, 293);
      this.rtfPossibleHands.TabIndex = 0;
      this.rtfPossibleHands.Text = "";
      // 
      // txtCommunityCards
      // 
      this.txtCommunityCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCommunityCards.Location = new System.Drawing.Point(198, 60);
      this.txtCommunityCards.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.txtCommunityCards.MaxLength = 5;
      this.txtCommunityCards.Name = "txtCommunityCards";
      this.txtCommunityCards.Size = new System.Drawing.Size(198, 29);
      this.txtCommunityCards.TabIndex = 3;
      this.txtCommunityCards.Text = "oance";
      this.txtCommunityCards.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputKeyDown);
      // 
      // rtfOpponentHands
      // 
      this.rtfOpponentHands.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtfOpponentHands.Location = new System.Drawing.Point(9, 30);
      this.rtfOpponentHands.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.rtfOpponentHands.Name = "rtfOpponentHands";
      this.rtfOpponentHands.Size = new System.Drawing.Size(391, 293);
      this.rtfOpponentHands.TabIndex = 0;
      this.rtfOpponentHands.Text = "";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.rtfPossibleHands);
      this.groupBox1.Location = new System.Drawing.Point(6, 111);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
      this.groupBox1.Size = new System.Drawing.Size(408, 331);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Possible Hands/Points";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.rtfOpponentHands);
      this.groupBox2.Location = new System.Drawing.Point(426, 111);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
      this.groupBox2.Size = new System.Drawing.Size(409, 331);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Opponent Hands/Points";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 447);
      this.tableLayoutPanel1.TabIndex = 7;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.Controls.Add(this.txtCommunityCards, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.txtHoleCards, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.btnCalculate, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 1);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(835, 100);
      this.tableLayoutPanel2.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(186, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "&Hole Cards:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(186, 21);
      this.label2.TabIndex = 2;
      this.label2.Text = "Comm&unity Cards:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnClear.AutoSize = true;
      this.btnClear.Location = new System.Drawing.Point(405, 59);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 31);
      this.btnClear.TabIndex = 5;
      this.btnClear.Text = "Clea&r";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.ClearClick);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(5, 452);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(841, 22);
      this.statusStrip1.TabIndex = 8;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tableLayoutPanel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(5, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(841, 447);
      this.panel1.TabIndex = 5;
      // 
      // Main
      // 
      this.AcceptButton = this.btnCalculate;
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(851, 479);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.statusStrip1);
      this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.Name = "Main";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Word Ace Helper";
      this.Load += new System.EventHandler(this.MainLoad);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtHoleCards;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.RichTextBox rtfPossibleHands;
    private System.Windows.Forms.TextBox txtCommunityCards;
    private System.Windows.Forms.RichTextBox rtfOpponentHands;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.Panel panel1;
  }
}

