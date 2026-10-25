namespace ReproductorMusica
{
    partial class FrmReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtArtista = new TextBox();
            label4 = new Label();
            cmbGenero = new ComboBox();
            label5 = new Label();
            txtDuracion = new TextBox();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnOrdenarTitulo = new Button();
            btnOrdenarDuracion = new Button();
            btnEjemplo = new Button();
            btnSalir = new Button();
            label6 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblResumen = new Label();
            lblSeccionCatalogo = new Label();
            lstCatalogo = new ListBox();
            btnAgregarLista = new Button();
            lblSeccionLista = new Label();
            lstLista = new ListBox();
            btnAnterior = new Button();
            btnReproducir = new Button();
            btnSiguiente = new Button();
            btnQuitarLista = new Button();
            btnAlReves = new Button();
            lblAhora = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(255, 211, 105);
            lblTitulo.Location = new Point(23, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(374, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mi Lista de Reproducción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(57, 62, 70);
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.FromArgb(238, 238, 238);
            txtCodigo.Location = new Point(143, 87);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(245, 27);
            txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(57, 62, 70);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = Color.FromArgb(238, 238, 238);
            txtTitulo.Location = new Point(143, 133);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(245, 27);
            txtTitulo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(238, 238, 238);
            label3.Location = new Point(23, 184);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Artista:";
            // 
            // txtArtista
            // 
            txtArtista.BackColor = Color.FromArgb(57, 62, 70);
            txtArtista.BorderStyle = BorderStyle.FixedSingle;
            txtArtista.ForeColor = Color.FromArgb(238, 238, 238);
            txtArtista.Location = new Point(143, 180);
            txtArtista.Margin = new Padding(3, 4, 3, 4);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(245, 27);
            txtArtista.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(238, 238, 238);
            label4.Location = new Point(23, 231);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "Género:";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.FromArgb(57, 62, 70);
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FlatStyle = FlatStyle.Flat;
            cmbGenero.ForeColor = Color.FromArgb(238, 238, 238);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(143, 227);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(245, 28);
            cmbGenero.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(238, 238, 238);
            label5.Location = new Point(23, 277);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 9;
            label5.Text = "Duración (seg):";
            // 
            // txtDuracion
            // 
            txtDuracion.BackColor = Color.FromArgb(57, 62, 70);
            txtDuracion.BorderStyle = BorderStyle.FixedSingle;
            txtDuracion.ForeColor = Color.FromArgb(238, 238, 238);
            txtDuracion.Location = new Point(143, 273);
            txtDuracion.Margin = new Padding(3, 4, 3, 4);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(245, 27);
            txtDuracion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 173, 181);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.FromArgb(255, 255, 255);
            btnRegistrar.Location = new Point(23, 327);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(183, 40);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 173, 181);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.FromArgb(255, 255, 255);
            btnModificar.Location = new Point(217, 327);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(171, 40);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(238, 99, 99);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(255, 255, 255);
            btnEliminar.Location = new Point(23, 376);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(183, 40);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 173, 181);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(255, 255, 255);
            btnLimpiar.Location = new Point(217, 376);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(171, 40);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnOrdenarTitulo
            // 
            btnOrdenarTitulo.BackColor = Color.FromArgb(0, 173, 181);
            btnOrdenarTitulo.FlatAppearance.BorderSize = 0;
            btnOrdenarTitulo.FlatStyle = FlatStyle.Flat;
            btnOrdenarTitulo.ForeColor = Color.FromArgb(255, 255, 255);
            btnOrdenarTitulo.Location = new Point(23, 425);
            btnOrdenarTitulo.Margin = new Padding(3, 4, 3, 4);
            btnOrdenarTitulo.Name = "btnOrdenarTitulo";
            btnOrdenarTitulo.Size = new Size(183, 40);
            btnOrdenarTitulo.TabIndex = 15;
            btnOrdenarTitulo.Text = "Ordenar por título";
            btnOrdenarTitulo.UseVisualStyleBackColor = false;
            btnOrdenarTitulo.Click += btnOrdenarTitulo_Click;
            // 
            // btnOrdenarDuracion
            // 
            btnOrdenarDuracion.BackColor = Color.FromArgb(0, 173, 181);
            btnOrdenarDuracion.FlatAppearance.BorderSize = 0;
            btnOrdenarDuracion.FlatStyle = FlatStyle.Flat;
            btnOrdenarDuracion.ForeColor = Color.FromArgb(255, 255, 255);
            btnOrdenarDuracion.Location = new Point(217, 425);
            btnOrdenarDuracion.Margin = new Padding(3, 4, 3, 4);
            btnOrdenarDuracion.Name = "btnOrdenarDuracion";
            btnOrdenarDuracion.Size = new Size(171, 40);
            btnOrdenarDuracion.TabIndex = 16;
            btnOrdenarDuracion.Text = "Ordenar por duración";
            btnOrdenarDuracion.UseVisualStyleBackColor = false;
            btnOrdenarDuracion.Click += btnOrdenarDuracion_Click;
            // 
            // btnEjemplo
            // 
            btnEjemplo.BackColor = Color.FromArgb(0, 173, 181);
            btnEjemplo.FlatAppearance.BorderSize = 0;
            btnEjemplo.FlatStyle = FlatStyle.Flat;
            btnEjemplo.ForeColor = Color.FromArgb(255, 255, 255);
            btnEjemplo.Location = new Point(23, 475);
            btnEjemplo.Margin = new Padding(3, 4, 3, 4);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(183, 40);
            btnEjemplo.TabIndex = 17;
            btnEjemplo.Text = "Datos de ejemplo";
            btnEjemplo.UseVisualStyleBackColor = false;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(238, 99, 99);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(255, 255, 255);
            btnSalir.Location = new Point(217, 475);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 40);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(238, 238, 238);
            label6.Location = new Point(23, 541);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 19;
            label6.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(57, 62, 70);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.ForeColor = Color.FromArgb(238, 238, 238);
            txtBuscar.Location = new Point(91, 537);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(194, 27);
            txtBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 173, 181);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(255, 255, 255);
            btnBuscar.Location = new Point(297, 533);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 37);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblResumen
            // 
            lblResumen.BackColor = Color.FromArgb(57, 62, 70);
            lblResumen.BorderStyle = BorderStyle.FixedSingle;
            lblResumen.Font = new Font("Segoe UI", 10F);
            lblResumen.ForeColor = Color.FromArgb(0, 173, 181);
            lblResumen.Location = new Point(23, 593);
            lblResumen.Name = "lblResumen";
            lblResumen.Padding = new Padding(11, 13, 11, 13);
            lblResumen.Size = new Size(365, 199);
            lblResumen.TabIndex = 22;
            // 
            // lblSeccionCatalogo
            // 
            lblSeccionCatalogo.AutoSize = true;
            lblSeccionCatalogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeccionCatalogo.ForeColor = Color.FromArgb(255, 211, 105);
            lblSeccionCatalogo.Location = new Point(446, 91);
            lblSeccionCatalogo.Name = "lblSeccionCatalogo";
            lblSeccionCatalogo.Size = new Size(188, 23);
            lblSeccionCatalogo.TabIndex = 23;
            lblSeccionCatalogo.Text = "Catálogo de canciones";
            // 
            // lstCatalogo
            // 
            lstCatalogo.BackColor = Color.FromArgb(57, 62, 70);
            lstCatalogo.BorderStyle = BorderStyle.FixedSingle;
            lstCatalogo.ForeColor = Color.FromArgb(238, 238, 238);
            lstCatalogo.FormattingEnabled = true;
            lstCatalogo.Location = new Point(446, 123);
            lstCatalogo.Margin = new Padding(3, 4, 3, 4);
            lstCatalogo.Name = "lstCatalogo";
            lstCatalogo.Size = new Size(674, 222);
            lstCatalogo.TabIndex = 24;
            lstCatalogo.SelectedIndexChanged += lstCatalogo_SelectedIndexChanged;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.BackColor = Color.FromArgb(0, 173, 181);
            btnAgregarLista.FlatAppearance.BorderSize = 0;
            btnAgregarLista.FlatStyle = FlatStyle.Flat;
            btnAgregarLista.ForeColor = Color.FromArgb(255, 255, 255);
            btnAgregarLista.Location = new Point(446, 360);
            btnAgregarLista.Margin = new Padding(3, 4, 3, 4);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(674, 40);
            btnAgregarLista.TabIndex = 25;
            btnAgregarLista.Text = "Agregar a la lista de reproducción";
            btnAgregarLista.UseVisualStyleBackColor = false;
            btnAgregarLista.Click += btnAgregarLista_Click;
            // 
            // lblSeccionLista
            // 
            lblSeccionLista.AutoSize = true;
            lblSeccionLista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeccionLista.ForeColor = Color.FromArgb(255, 211, 105);
            lblSeccionLista.Location = new Point(446, 420);
            lblSeccionLista.Name = "lblSeccionLista";
            lblSeccionLista.Size = new Size(183, 23);
            lblSeccionLista.TabIndex = 26;
            lblSeccionLista.Text = "Lista de reproducción";
            // 
            // lstLista
            // 
            lstLista.BackColor = Color.FromArgb(57, 62, 70);
            lstLista.BorderStyle = BorderStyle.FixedSingle;
            lstLista.ForeColor = Color.FromArgb(238, 238, 238);
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(446, 453);
            lstLista.Margin = new Padding(3, 4, 3, 4);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(674, 222);
            lstLista.TabIndex = 27;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(255, 211, 105);
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.ForeColor = Color.FromArgb(34, 40, 49);
            btnAnterior.Location = new Point(446, 693);
            btnAnterior.Margin = new Padding(3, 4, 3, 4);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(114, 45);
            btnAnterior.TabIndex = 28;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.BackColor = Color.FromArgb(255, 211, 105);
            btnReproducir.FlatAppearance.BorderSize = 0;
            btnReproducir.FlatStyle = FlatStyle.Flat;
            btnReproducir.ForeColor = Color.FromArgb(34, 40, 49);
            btnReproducir.Location = new Point(571, 693);
            btnReproducir.Margin = new Padding(3, 4, 3, 4);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(114, 45);
            btnReproducir.TabIndex = 29;
            btnReproducir.Text = "Reproducir";
            btnReproducir.UseVisualStyleBackColor = false;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(255, 211, 105);
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.ForeColor = Color.FromArgb(34, 40, 49);
            btnSiguiente.Location = new Point(697, 693);
            btnSiguiente.Margin = new Padding(3, 4, 3, 4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(114, 45);
            btnSiguiente.TabIndex = 30;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnQuitarLista
            // 
            btnQuitarLista.BackColor = Color.FromArgb(238, 99, 99);
            btnQuitarLista.FlatAppearance.BorderSize = 0;
            btnQuitarLista.FlatStyle = FlatStyle.Flat;
            btnQuitarLista.ForeColor = Color.FromArgb(255, 255, 255);
            btnQuitarLista.Location = new Point(823, 693);
            btnQuitarLista.Margin = new Padding(3, 4, 3, 4);
            btnQuitarLista.Name = "btnQuitarLista";
            btnQuitarLista.Size = new Size(143, 45);
            btnQuitarLista.TabIndex = 31;
            btnQuitarLista.Text = "Quitar";
            btnQuitarLista.UseVisualStyleBackColor = false;
            btnQuitarLista.Click += btnQuitarLista_Click;
            // 
            // btnAlReves
            // 
            btnAlReves.BackColor = Color.FromArgb(0, 173, 181);
            btnAlReves.FlatAppearance.BorderSize = 0;
            btnAlReves.FlatStyle = FlatStyle.Flat;
            btnAlReves.ForeColor = Color.FromArgb(255, 255, 255);
            btnAlReves.Location = new Point(977, 693);
            btnAlReves.Margin = new Padding(3, 4, 3, 4);
            btnAlReves.Name = "btnAlReves";
            btnAlReves.Size = new Size(143, 45);
            btnAlReves.TabIndex = 32;
            btnAlReves.Text = "Ver al revés";
            btnAlReves.UseVisualStyleBackColor = false;
            btnAlReves.Click += btnAlReves_Click;
            // 
            // lblAhora
            // 
            lblAhora.BackColor = Color.FromArgb(255, 211, 105);
            lblAhora.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAhora.ForeColor = Color.FromArgb(34, 40, 49);
            lblAhora.Location = new Point(446, 753);
            lblAhora.Name = "lblAhora";
            lblAhora.Padding = new Padding(11, 0, 0, 0);
            lblAhora.Size = new Size(674, 60);
            lblAhora.TabIndex = 33;
            lblAhora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmReproductor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1143, 853);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(txtArtista);
            Controls.Add(label4);
            Controls.Add(cmbGenero);
            Controls.Add(label5);
            Controls.Add(txtDuracion);
            Controls.Add(btnRegistrar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOrdenarTitulo);
            Controls.Add(btnOrdenarDuracion);
            Controls.Add(btnEjemplo);
            Controls.Add(btnSalir);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblResumen);
            Controls.Add(lblSeccionCatalogo);
            Controls.Add(lstCatalogo);
            Controls.Add(btnAgregarLista);
            Controls.Add(lblSeccionLista);
            Controls.Add(lstLista);
            Controls.Add(btnAnterior);
            Controls.Add(btnReproducir);
            Controls.Add(btnSiguiente);
            Controls.Add(btnQuitarLista);
            Controls.Add(btnAlReves);
            Controls.Add(lblAhora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmReproductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi lista de reproducción";
            Load += FrmReproductor_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOrdenarTitulo;
        private System.Windows.Forms.Button btnOrdenarDuracion;
        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblSeccionCatalogo;
        private System.Windows.Forms.ListBox lstCatalogo;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.Label lblSeccionLista;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnQuitarLista;
        private System.Windows.Forms.Button btnAlReves;
        private System.Windows.Forms.Label lblAhora;
    }
}
