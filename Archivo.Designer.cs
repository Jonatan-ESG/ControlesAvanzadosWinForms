namespace ControlesAvanzados
{
    partial class Archivo
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
            label1 = new Label();
            listadoVentas = new FlowLayoutPanel();
            checkedListBox1 = new CheckedListBox();
            selectorDepartamento = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 31);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Nuevo Archivo";
            label1.Click += label1_Click;
            // 
            // listadoVentas
            // 
            listadoVentas.AutoScroll = true;
            listadoVentas.Location = new Point(407, 58);
            listadoVentas.Name = "listadoVentas";
            listadoVentas.Size = new Size(827, 768);
            listadoVentas.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(271, 519);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 2;
            // 
            // selectorDepartamento
            // 
            selectorDepartamento.FormattingEnabled = true;
            selectorDepartamento.Location = new Point(26, 97);
            selectorDepartamento.Name = "selectorDepartamento";
            selectorDepartamento.SelectionMode = SelectionMode.MultiSimple;
            selectorDepartamento.Size = new Size(316, 164);
            selectorDepartamento.TabIndex = 3;
            // 
            // Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 928);
            Controls.Add(selectorDepartamento);
            Controls.Add(checkedListBox1);
            Controls.Add(listadoVentas);
            Controls.Add(label1);
            Name = "Archivo";
            Text = "Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel listadoVentas;
        private CheckedListBox checkedListBox1;
        private ListBox selectorDepartamento;
    }
}