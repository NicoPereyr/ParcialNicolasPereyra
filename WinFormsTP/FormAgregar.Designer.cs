namespace WinFormsTP
{
    partial class FormAgregar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
            LabelAgregar = new Label();
            txtRadio = new TextBox();
            BtnAgregar = new Button();
            BtnLimpiar = new Button();
            BtnCancelar = new Button();
            lado1ErrorProvider = new ErrorProvider(components);
            label1 = new Label();
            txtBorde = new TextBox();
            lado2ErrorProvider = new ErrorProvider(components);
            labelColor = new Label();
            txtColor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)lado1ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lado2ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // LabelAgregar
            // 
            LabelAgregar.AutoSize = true;
            LabelAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAgregar.Location = new Point(12, 19);
            LabelAgregar.Name = "LabelAgregar";
            LabelAgregar.Size = new Size(203, 21);
            LabelAgregar.TabIndex = 0;
            LabelAgregar.Text = "Ingrese el radio de la esfera:";
            LabelAgregar.Click += LabelAgregar_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(221, 17);
            txtRadio.Name = "txtRadio";
            txtRadio.PlaceholderText = "Radio";
            txtRadio.Size = new Size(123, 23);
            txtRadio.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.AutoSize = true;
            BtnAgregar.Image = (Image)resources.GetObject("BtnAgregar.Image");
            BtnAgregar.ImageAlign = ContentAlignment.TopCenter;
            BtnAgregar.Location = new Point(33, 136);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(83, 57);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.AutoSize = true;
            BtnLimpiar.Image = Properties.Resources.Barrer;
            BtnLimpiar.ImageAlign = ContentAlignment.TopCenter;
            BtnLimpiar.Location = new Point(159, 136);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(83, 57);
            BtnLimpiar.TabIndex = 5;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Image = Properties.Resources.Cancel;
            BtnCancelar.ImageAlign = ContentAlignment.TopCenter;
            BtnCancelar.Location = new Point(291, 136);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(83, 57);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // lado1ErrorProvider
            // 
            lado1ErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el tipo de borde:";
            // 
            // txtBorde
            // 
            txtBorde.Location = new Point(195, 57);
            txtBorde.Name = "txtBorde";
            txtBorde.PlaceholderText = "Borde";
            txtBorde.Size = new Size(123, 23);
            txtBorde.TabIndex = 2;
            // 
            // lado2ErrorProvider
            // 
            lado2ErrorProvider.ContainerControl = this;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(12, 96);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(116, 21);
            labelColor.TabIndex = 0;
            labelColor.Text = "Ingrese el color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(143, 94);
            txtColor.Name = "txtColor";
            txtColor.PlaceholderText = "Color";
            txtColor.Size = new Size(127, 23);
            txtColor.TabIndex = 3;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 223);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnAgregar);
            Controls.Add(txtColor);
            Controls.Add(txtBorde);
            Controls.Add(txtRadio);
            Controls.Add(labelColor);
            Controls.Add(label1);
            Controls.Add(LabelAgregar);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)lado1ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)lado2ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAgregar;
        private TextBox txtRadio;
        private Button BtnAgregar;
        private Button BtnLimpiar;
        private Button BtnCancelar;
        private ErrorProvider lado1ErrorProvider;
        private TextBox txtBorde;
        private Label label1;
        private ErrorProvider lado2ErrorProvider;
        private TextBox txtColor;
        private Label labelColor;
    }
}