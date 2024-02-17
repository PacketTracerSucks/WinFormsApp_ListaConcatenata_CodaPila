namespace WinFormsApp_ListaConcatenata_CodaPila
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
            buttonPush = new Button();
            buttonPopCoda = new Button();
            buttonPopPila = new Button();
            buttonSerializza = new Button();
            buttonDeserializza = new Button();
            textBoxValore = new TextBox();
            listBoxLista = new ListBox();
            SuspendLayout();
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(12, 45);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(125, 29);
            buttonPush.TabIndex = 0;
            buttonPush.Text = "PUSH";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonPopCoda
            // 
            buttonPopCoda.Location = new Point(12, 80);
            buttonPopCoda.Name = "buttonPopCoda";
            buttonPopCoda.Size = new Size(125, 29);
            buttonPopCoda.TabIndex = 1;
            buttonPopCoda.Text = "FIFO";
            buttonPopCoda.UseVisualStyleBackColor = true;
            buttonPopCoda.Click += buttonPopCoda_Click;
            // 
            // buttonPopPila
            // 
            buttonPopPila.Location = new Point(12, 115);
            buttonPopPila.Name = "buttonPopPila";
            buttonPopPila.Size = new Size(125, 29);
            buttonPopPila.TabIndex = 2;
            buttonPopPila.Text = "LIFO";
            buttonPopPila.UseVisualStyleBackColor = true;
            buttonPopPila.Click += buttonPopPila_Click;
            // 
            // buttonSerializza
            // 
            buttonSerializza.Location = new Point(12, 195);
            buttonSerializza.Name = "buttonSerializza";
            buttonSerializza.Size = new Size(125, 29);
            buttonSerializza.TabIndex = 3;
            buttonSerializza.Text = "Serializza";
            buttonSerializza.UseVisualStyleBackColor = true;
            buttonSerializza.Click += buttonSerializza_Click;
            // 
            // buttonDeserializza
            // 
            buttonDeserializza.Location = new Point(12, 230);
            buttonDeserializza.Name = "buttonDeserializza";
            buttonDeserializza.Size = new Size(125, 29);
            buttonDeserializza.TabIndex = 4;
            buttonDeserializza.Text = "Deserializza";
            buttonDeserializza.UseVisualStyleBackColor = true;
            buttonDeserializza.Click += buttonDeserializza_Click;
            // 
            // textBoxValore
            // 
            textBoxValore.Location = new Point(12, 12);
            textBoxValore.Name = "textBoxValore";
            textBoxValore.Size = new Size(125, 27);
            textBoxValore.TabIndex = 5;
            // 
            // listBoxLista
            // 
            listBoxLista.FormattingEnabled = true;
            listBoxLista.ItemHeight = 20;
            listBoxLista.Location = new Point(143, 12);
            listBoxLista.Name = "listBoxLista";
            listBoxLista.Size = new Size(210, 244);
            listBoxLista.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 269);
            Controls.Add(listBoxLista);
            Controls.Add(textBoxValore);
            Controls.Add(buttonDeserializza);
            Controls.Add(buttonSerializza);
            Controls.Add(buttonPopPila);
            Controls.Add(buttonPopCoda);
            Controls.Add(buttonPush);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPush;
        private Button buttonPopCoda;
        private Button buttonPopPila;
        private Button buttonSerializza;
        private Button buttonDeserializza;
        private TextBox textBoxValore;
        private ListBox listBoxLista;
    }
}
