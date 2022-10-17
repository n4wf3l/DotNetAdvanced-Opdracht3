namespace DotNetAdvanced_Opdracht3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.integersInput = new System.Windows.Forms.TextBox();
            this.stringsInput = new System.Windows.Forms.TextBox();
            this.tb_voetballer = new System.Windows.Forms.TextBox();
            this.inputLeeftijd = new System.Windows.Forms.TextBox();
            this.integersToevoegen = new System.Windows.Forms.Button();
            this.integersZoeken = new System.Windows.Forms.Button();
            this.integersVerwijderen = new System.Windows.Forms.Button();
            this.integersLeegmaken = new System.Windows.Forms.Button();
            this.showIntegers = new System.Windows.Forms.Button();
            this.integersCopy = new System.Windows.Forms.Button();
            this.copyStrings = new System.Windows.Forms.Button();
            this.showStrings = new System.Windows.Forms.Button();
            this.leegmakenStrings = new System.Windows.Forms.Button();
            this.verwijderenStrings = new System.Windows.Forms.Button();
            this.zoekenStrings = new System.Windows.Forms.Button();
            this.toevoegenStrings = new System.Windows.Forms.Button();
            this.copyVoetballer = new System.Windows.Forms.Button();
            this.showListVoetballer = new System.Windows.Forms.Button();
            this.leegmakenVoetballer = new System.Windows.Forms.Button();
            this.verwijderenVoetballer = new System.Windows.Forms.Button();
            this.zoekenVoetballer = new System.Windows.Forms.Button();
            this.toevoegenVoetballer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Voetballer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Leeftijd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Integers : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Strings :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Voetbal : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // integersInput
            // 
            this.integersInput.Location = new System.Drawing.Point(12, 38);
            this.integersInput.Name = "integersInput";
            this.integersInput.Size = new System.Drawing.Size(91, 23);
            this.integersInput.TabIndex = 7;
            this.integersInput.TextChanged += new System.EventHandler(this.integersInput_TextChanged);
            // 
            // stringsInput
            // 
            this.stringsInput.Location = new System.Drawing.Point(206, 38);
            this.stringsInput.Name = "stringsInput";
            this.stringsInput.Size = new System.Drawing.Size(91, 23);
            this.stringsInput.TabIndex = 8;
            // 
            // tb_voetballer
            // 
            this.tb_voetballer.Location = new System.Drawing.Point(400, 38);
            this.tb_voetballer.Name = "tb_voetballer";
            this.tb_voetballer.Size = new System.Drawing.Size(91, 23);
            this.tb_voetballer.TabIndex = 9;
            // 
            // inputLeeftijd
            // 
            this.inputLeeftijd.Location = new System.Drawing.Point(497, 38);
            this.inputLeeftijd.Name = "inputLeeftijd";
            this.inputLeeftijd.Size = new System.Drawing.Size(24, 23);
            this.inputLeeftijd.TabIndex = 10;
            this.inputLeeftijd.TextChanged += new System.EventHandler(this.inputleeftijd_TextChanged);
            // 
            // integersToevoegen
            // 
            this.integersToevoegen.Location = new System.Drawing.Point(109, 38);
            this.integersToevoegen.Name = "integersToevoegen";
            this.integersToevoegen.Size = new System.Drawing.Size(91, 63);
            this.integersToevoegen.TabIndex = 11;
            this.integersToevoegen.Text = "Toevoegen";
            this.integersToevoegen.UseVisualStyleBackColor = true;
            this.integersToevoegen.Click += new System.EventHandler(this.integersToevoegen_Click_1);
            // 
            // integersZoeken
            // 
            this.integersZoeken.Location = new System.Drawing.Point(109, 194);
            this.integersZoeken.Name = "integersZoeken";
            this.integersZoeken.Size = new System.Drawing.Size(91, 23);
            this.integersZoeken.TabIndex = 15;
            this.integersZoeken.Text = "Zoeken";
            this.integersZoeken.UseVisualStyleBackColor = true;
            this.integersZoeken.Click += new System.EventHandler(this.integersZoeken_Click);
            // 
            // integersVerwijderen
            // 
            this.integersVerwijderen.Location = new System.Drawing.Point(109, 107);
            this.integersVerwijderen.Name = "integersVerwijderen";
            this.integersVerwijderen.Size = new System.Drawing.Size(91, 23);
            this.integersVerwijderen.TabIndex = 29;
            this.integersVerwijderen.Text = "Verwijderen";
            this.integersVerwijderen.UseVisualStyleBackColor = true;
            this.integersVerwijderen.Click += new System.EventHandler(this.integersVerwijderen_Click);
            // 
            // integersLeegmaken
            // 
            this.integersLeegmaken.Location = new System.Drawing.Point(109, 136);
            this.integersLeegmaken.Name = "integersLeegmaken";
            this.integersLeegmaken.Size = new System.Drawing.Size(91, 23);
            this.integersLeegmaken.TabIndex = 30;
            this.integersLeegmaken.Text = "Leegmaken";
            this.integersLeegmaken.UseVisualStyleBackColor = true;
            this.integersLeegmaken.Click += new System.EventHandler(this.integersLeegmaken_Click);
            // 
            // showIntegers
            // 
            this.showIntegers.Location = new System.Drawing.Point(109, 165);
            this.showIntegers.Name = "showIntegers";
            this.showIntegers.Size = new System.Drawing.Size(91, 23);
            this.showIntegers.TabIndex = 31;
            this.showIntegers.Text = "Show";
            this.showIntegers.UseVisualStyleBackColor = true;
            this.showIntegers.Click += new System.EventHandler(this.showIntegers_Click);
            // 
            // integersCopy
            // 
            this.integersCopy.Location = new System.Drawing.Point(109, 223);
            this.integersCopy.Name = "integersCopy";
            this.integersCopy.Size = new System.Drawing.Size(91, 23);
            this.integersCopy.TabIndex = 32;
            this.integersCopy.Text = "Copy";
            this.integersCopy.UseVisualStyleBackColor = true;
            this.integersCopy.Click += new System.EventHandler(this.integersCopy_Click);
            // 
            // copyStrings
            // 
            this.copyStrings.Location = new System.Drawing.Point(303, 223);
            this.copyStrings.Name = "copyStrings";
            this.copyStrings.Size = new System.Drawing.Size(91, 23);
            this.copyStrings.TabIndex = 38;
            this.copyStrings.Text = "Copy";
            this.copyStrings.UseVisualStyleBackColor = true;
            this.copyStrings.Click += new System.EventHandler(this.copyStrings_Click_1);
            // 
            // showStrings
            // 
            this.showStrings.Location = new System.Drawing.Point(303, 165);
            this.showStrings.Name = "showStrings";
            this.showStrings.Size = new System.Drawing.Size(91, 23);
            this.showStrings.TabIndex = 37;
            this.showStrings.Text = "Show";
            this.showStrings.UseVisualStyleBackColor = true;
            this.showStrings.Click += new System.EventHandler(this.showStrings_Click);
            // 
            // leegmakenStrings
            // 
            this.leegmakenStrings.Location = new System.Drawing.Point(303, 136);
            this.leegmakenStrings.Name = "leegmakenStrings";
            this.leegmakenStrings.Size = new System.Drawing.Size(91, 23);
            this.leegmakenStrings.TabIndex = 36;
            this.leegmakenStrings.Text = "Leegmaken";
            this.leegmakenStrings.UseVisualStyleBackColor = true;
            this.leegmakenStrings.Click += new System.EventHandler(this.leegmakenStrings_Click_1);
            // 
            // verwijderenStrings
            // 
            this.verwijderenStrings.Location = new System.Drawing.Point(303, 107);
            this.verwijderenStrings.Name = "verwijderenStrings";
            this.verwijderenStrings.Size = new System.Drawing.Size(91, 23);
            this.verwijderenStrings.TabIndex = 35;
            this.verwijderenStrings.Text = "Verwijderen";
            this.verwijderenStrings.UseVisualStyleBackColor = true;
            this.verwijderenStrings.Click += new System.EventHandler(this.verwijderenStrings_Click_1);
            // 
            // zoekenStrings
            // 
            this.zoekenStrings.Location = new System.Drawing.Point(303, 194);
            this.zoekenStrings.Name = "zoekenStrings";
            this.zoekenStrings.Size = new System.Drawing.Size(91, 23);
            this.zoekenStrings.TabIndex = 34;
            this.zoekenStrings.Text = "Zoeken";
            this.zoekenStrings.UseVisualStyleBackColor = true;
            this.zoekenStrings.Click += new System.EventHandler(this.zoekenStrings_Click);
            // 
            // toevoegenStrings
            // 
            this.toevoegenStrings.Location = new System.Drawing.Point(303, 38);
            this.toevoegenStrings.Name = "toevoegenStrings";
            this.toevoegenStrings.Size = new System.Drawing.Size(91, 63);
            this.toevoegenStrings.TabIndex = 33;
            this.toevoegenStrings.Text = "Toevoegen";
            this.toevoegenStrings.UseVisualStyleBackColor = true;
            this.toevoegenStrings.Click += new System.EventHandler(this.toevoegenStrings_Click_1);
            // 
            // copyVoetballer
            // 
            this.copyVoetballer.Location = new System.Drawing.Point(527, 224);
            this.copyVoetballer.Name = "copyVoetballer";
            this.copyVoetballer.Size = new System.Drawing.Size(91, 23);
            this.copyVoetballer.TabIndex = 44;
            this.copyVoetballer.Text = "Copy";
            this.copyVoetballer.UseVisualStyleBackColor = true;
            this.copyVoetballer.Click += new System.EventHandler(this.copyVoetballer_Click);
            // 
            // showListVoetballer
            // 
            this.showListVoetballer.Location = new System.Drawing.Point(527, 166);
            this.showListVoetballer.Name = "showListVoetballer";
            this.showListVoetballer.Size = new System.Drawing.Size(91, 23);
            this.showListVoetballer.TabIndex = 43;
            this.showListVoetballer.Text = "Show";
            this.showListVoetballer.UseVisualStyleBackColor = true;
            this.showListVoetballer.Click += new System.EventHandler(this.showListVoetballer_Click);
            // 
            // leegmakenVoetballer
            // 
            this.leegmakenVoetballer.Location = new System.Drawing.Point(527, 137);
            this.leegmakenVoetballer.Name = "leegmakenVoetballer";
            this.leegmakenVoetballer.Size = new System.Drawing.Size(91, 23);
            this.leegmakenVoetballer.TabIndex = 42;
            this.leegmakenVoetballer.Text = "Leegmaken";
            this.leegmakenVoetballer.UseVisualStyleBackColor = true;
            this.leegmakenVoetballer.Click += new System.EventHandler(this.leegmakenVoetballer_Click);
            // 
            // verwijderenVoetballer
            // 
            this.verwijderenVoetballer.Location = new System.Drawing.Point(527, 108);
            this.verwijderenVoetballer.Name = "verwijderenVoetballer";
            this.verwijderenVoetballer.Size = new System.Drawing.Size(91, 23);
            this.verwijderenVoetballer.TabIndex = 41;
            this.verwijderenVoetballer.Text = "Verwijderen";
            this.verwijderenVoetballer.UseVisualStyleBackColor = true;
            this.verwijderenVoetballer.Click += new System.EventHandler(this.verwijderenVoetballer_Click);
            // 
            // zoekenVoetballer
            // 
            this.zoekenVoetballer.Location = new System.Drawing.Point(527, 195);
            this.zoekenVoetballer.Name = "zoekenVoetballer";
            this.zoekenVoetballer.Size = new System.Drawing.Size(91, 23);
            this.zoekenVoetballer.TabIndex = 40;
            this.zoekenVoetballer.Text = "Zoeken";
            this.zoekenVoetballer.UseVisualStyleBackColor = true;
            this.zoekenVoetballer.Click += new System.EventHandler(this.zoekenVoetballer_Click);
            // 
            // toevoegenVoetballer
            // 
            this.toevoegenVoetballer.Location = new System.Drawing.Point(527, 37);
            this.toevoegenVoetballer.Name = "toevoegenVoetballer";
            this.toevoegenVoetballer.Size = new System.Drawing.Size(91, 65);
            this.toevoegenVoetballer.TabIndex = 39;
            this.toevoegenVoetballer.Text = "Toevoegen";
            this.toevoegenVoetballer.UseVisualStyleBackColor = true;
            this.toevoegenVoetballer.Click += new System.EventHandler(this.toevoegenVoetballer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 383);
            this.Controls.Add(this.copyVoetballer);
            this.Controls.Add(this.showListVoetballer);
            this.Controls.Add(this.leegmakenVoetballer);
            this.Controls.Add(this.verwijderenVoetballer);
            this.Controls.Add(this.zoekenVoetballer);
            this.Controls.Add(this.toevoegenVoetballer);
            this.Controls.Add(this.copyStrings);
            this.Controls.Add(this.showStrings);
            this.Controls.Add(this.leegmakenStrings);
            this.Controls.Add(this.verwijderenStrings);
            this.Controls.Add(this.zoekenStrings);
            this.Controls.Add(this.toevoegenStrings);
            this.Controls.Add(this.integersCopy);
            this.Controls.Add(this.showIntegers);
            this.Controls.Add(this.integersLeegmaken);
            this.Controls.Add(this.integersVerwijderen);
            this.Controls.Add(this.integersZoeken);
            this.Controls.Add(this.integersToevoegen);
            this.Controls.Add(this.inputLeeftijd);
            this.Controls.Add(this.tb_voetballer);
            this.Controls.Add(this.stringsInput);
            this.Controls.Add(this.integersInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Int&String-Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox integersInput;
        private TextBox stringsInput;
        private TextBox tb_voetballer;
        private TextBox inputLeeftijd;
        private Button integersToevoegen;
        private Button integersZoeken;
        private Button integersVerwijderen;
        private Button integersLeegmaken;
        private Button showIntegers;
        private Button integersCopy;
        private Button copyStrings;
        private Button showStrings;
        private Button leegmakenStrings;
        private Button verwijderenStrings;
        private Button zoekenStrings;
        private Button toevoegenStrings;
        private Button copyVoetballer;
        private Button showListVoetballer;
        private Button leegmakenVoetballer;
        private Button verwijderenVoetballer;
        private Button zoekenVoetballer;
        private Button toevoegenVoetballer;
    }
}