namespace JerryBibles.UI.Registros
{
    partial class rLibros
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LibroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SiglastextBox = new System.Windows.Forms.TextBox();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LibroId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Siglas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // LibroIdnumericUpDown
            // 
            this.LibroIdnumericUpDown.Location = new System.Drawing.Point(118, 55);
            this.LibroIdnumericUpDown.Name = "LibroIdnumericUpDown";
            this.LibroIdnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.LibroIdnumericUpDown.TabIndex = 5;
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(118, 107);
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(200, 69);
            this.DescripcionrichTextBox.TabIndex = 6;
            this.DescripcionrichTextBox.Text = "";
            // 
            // SiglastextBox
            // 
            this.SiglastextBox.Location = new System.Drawing.Point(118, 204);
            this.SiglastextBox.Name = "SiglastextBox";
            this.SiglastextBox.Size = new System.Drawing.Size(200, 20);
            this.SiglastextBox.TabIndex = 7;
            // 
            // TipotextBox
            // 
            this.TipotextBox.Location = new System.Drawing.Point(118, 244);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(200, 20);
            this.TipotextBox.TabIndex = 8;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::JerryBibles.Properties.Resources.icons8_Search_Property_16;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(195, 57);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::JerryBibles.Properties.Resources.icons8_Delete_Document_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(312, 296);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 56);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::JerryBibles.Properties.Resources.icons8_Save_as_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(204, 296);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 10;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::JerryBibles.Properties.Resources.icons8_Add_Property_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(94, 296);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 56);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // rLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(477, 364);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.TipotextBox);
            this.Controls.Add(this.SiglastextBox);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.LibroIdnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(493, 403);
            this.MaximumSize = new System.Drawing.Size(493, 403);
            this.MinimumSize = new System.Drawing.Size(493, 403);
            this.Name = "rLibros";
            this.Text = "registro de libros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.TextBox SiglastextBox;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.NumericUpDown LibroIdnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
    }
}