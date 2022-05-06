namespace Ejercicio_12
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.pnl_opcion = new System.Windows.Forms.Panel();
            this.btn_lista = new FontAwesome.Sharp.IconButton();
            this.btn_refresh = new FontAwesome.Sharp.IconButton();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_simular = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.lbl_multa = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.txt_permiso = new System.Windows.Forms.TextBox();
            this.txt_multa = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_lista = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.list_simulaciones = new System.Windows.Forms.ListBox();
            this.lbl_promSurtidas = new System.Windows.Forms.Label();
            this.lbl_promVendidas = new System.Windows.Forms.Label();
            this.lbl_promedioUtilidad = new System.Windows.Forms.Label();
            this.btn_ultimafila = new FontAwesome.Sharp.IconButton();
            this.lbl_promedioUtilidadPermiso = new System.Windows.Forms.Label();
            this.lbl_permisoPpal = new System.Windows.Forms.Label();
            this.lbl_prodPpal = new System.Windows.Forms.Label();
            this.lbl_rangoPpal = new System.Windows.Forms.Label();
            this.lbl_costoPpal = new System.Windows.Forms.Label();
            this.lbl_cantPpal = new System.Windows.Forms.Label();
            this.lbl_precioPpal = new System.Windows.Forms.Label();
            this.lbl_multaPpal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_opcion.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_lista.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_menu.IconColor = System.Drawing.Color.DimGray;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 32;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(48, 48);
            this.btn_menu.TabIndex = 4;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pnl_opcion
            // 
            this.pnl_opcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_opcion.Controls.Add(this.btn_lista);
            this.pnl_opcion.Controls.Add(this.btn_refresh);
            this.pnl_opcion.Controls.Add(this.btn_menu);
            this.pnl_opcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_opcion.Location = new System.Drawing.Point(0, 0);
            this.pnl_opcion.Name = "pnl_opcion";
            this.pnl_opcion.Size = new System.Drawing.Size(48, 567);
            this.pnl_opcion.TabIndex = 5;
            // 
            // btn_lista
            // 
            this.btn_lista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_lista.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lista.FlatAppearance.BorderSize = 0;
            this.btn_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lista.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_lista.IconColor = System.Drawing.Color.DimGray;
            this.btn_lista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_lista.IconSize = 32;
            this.btn_lista.Location = new System.Drawing.Point(0, 96);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(48, 48);
            this.btn_lista.TabIndex = 5;
            this.btn_lista.UseVisualStyleBackColor = false;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btn_refresh.IconColor = System.Drawing.Color.DimGray;
            this.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refresh.IconSize = 32;
            this.btn_refresh.Location = new System.Drawing.Point(0, 48);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(48, 48);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_menu.Controls.Add(this.btn_simular);
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Controls.Add(this.lbl_dias);
            this.pnl_menu.Controls.Add(this.lbl_permiso);
            this.pnl_menu.Controls.Add(this.lbl_multa);
            this.pnl_menu.Controls.Add(this.lbl_precio);
            this.pnl_menu.Controls.Add(this.lbl_costo);
            this.pnl_menu.Controls.Add(this.lbl_prod);
            this.pnl_menu.Controls.Add(this.txt_hasta);
            this.pnl_menu.Controls.Add(this.txt_desde);
            this.pnl_menu.Controls.Add(this.txt_cant);
            this.pnl_menu.Controls.Add(this.txt_permiso);
            this.pnl_menu.Controls.Add(this.txt_multa);
            this.pnl_menu.Controls.Add(this.txt_precio);
            this.pnl_menu.Controls.Add(this.txt_costo);
            this.pnl_menu.Controls.Add(this.txt_prod);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(48, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(10, 567);
            this.pnl_menu.TabIndex = 6;
            // 
            // btn_simular
            // 
            this.btn_simular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_simular.FlatAppearance.BorderSize = 0;
            this.btn_simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_simular.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btn_simular.IconColor = System.Drawing.Color.DimGray;
            this.btn_simular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_simular.IconSize = 32;
            this.btn_simular.Location = new System.Drawing.Point(0, 200);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(216, 54);
            this.btn_simular.TabIndex = 2;
            this.btn_simular.Text = "Simular";
            this.btn_simular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_simular.UseVisualStyleBackColor = false;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar rango";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dias.Location = new System.Drawing.Point(54, 14);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(106, 20);
            this.lbl_dias.TabIndex = 1;
            this.lbl_dias.Text = "Días a simular";
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.AutoSize = true;
            this.lbl_permiso.Location = new System.Drawing.Point(24, 408);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(64, 20);
            this.lbl_permiso.TabIndex = 1;
            this.lbl_permiso.Text = "Permiso:";
            // 
            // lbl_multa
            // 
            this.lbl_multa.AutoSize = true;
            this.lbl_multa.Location = new System.Drawing.Point(24, 375);
            this.lbl_multa.Name = "lbl_multa";
            this.lbl_multa.Size = new System.Drawing.Size(50, 20);
            this.lbl_multa.TabIndex = 1;
            this.lbl_multa.Text = "Multa:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(24, 342);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(93, 20);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio venta:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(24, 309);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(105, 20);
            this.lbl_costo.TabIndex = 1;
            this.lbl_costo.Text = "Costo unitario:";
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.Location = new System.Drawing.Point(24, 276);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(86, 20);
            this.lbl_prod.TabIndex = 1;
            this.lbl_prod.Text = "Produccion:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(54, 149);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(106, 27);
            this.txt_hasta.TabIndex = 0;
            this.txt_hasta.Text = "60";
            this.txt_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(54, 119);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(106, 27);
            this.txt_desde.TabIndex = 0;
            this.txt_desde.Text = "0";
            this.txt_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(54, 37);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(108, 27);
            this.txt_cant.TabIndex = 0;
            this.txt_cant.Text = "60";
            this.txt_cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_permiso
            // 
            this.txt_permiso.Location = new System.Drawing.Point(125, 405);
            this.txt_permiso.Name = "txt_permiso";
            this.txt_permiso.Size = new System.Drawing.Size(66, 27);
            this.txt_permiso.TabIndex = 0;
            this.txt_permiso.Text = "200";
            this.txt_permiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_multa
            // 
            this.txt_multa.Location = new System.Drawing.Point(125, 372);
            this.txt_multa.Name = "txt_multa";
            this.txt_multa.Size = new System.Drawing.Size(66, 27);
            this.txt_multa.TabIndex = 0;
            this.txt_multa.Text = "300";
            this.txt_multa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(126, 339);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(66, 27);
            this.txt_precio.TabIndex = 0;
            this.txt_precio.Text = "30";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(126, 306);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(66, 27);
            this.txt_costo.TabIndex = 0;
            this.txt_costo.Text = "10";
            this.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_prod
            // 
            this.txt_prod.Location = new System.Drawing.Point(125, 273);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(66, 27);
            this.txt_prod.TabIndex = 0;
            this.txt_prod.Text = "50";
            this.txt_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pnl_lista);
            this.panel2.Controls.Add(this.lbl_promSurtidas);
            this.panel2.Controls.Add(this.lbl_promVendidas);
            this.panel2.Controls.Add(this.lbl_promedioUtilidad);
            this.panel2.Controls.Add(this.btn_ultimafila);
            this.panel2.Controls.Add(this.lbl_promedioUtilidadPermiso);
            this.panel2.Controls.Add(this.lbl_permisoPpal);
            this.panel2.Controls.Add(this.lbl_prodPpal);
            this.panel2.Controls.Add(this.lbl_rangoPpal);
            this.panel2.Controls.Add(this.lbl_costoPpal);
            this.panel2.Controls.Add(this.lbl_cantPpal);
            this.panel2.Controls.Add(this.lbl_precioPpal);
            this.panel2.Controls.Add(this.lbl_multaPpal);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.grid);
            this.panel2.Location = new System.Drawing.Point(48, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 567);
            this.panel2.TabIndex = 7;
            // 
            // pnl_lista
            // 
            this.pnl_lista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_lista.Controls.Add(this.label4);
            this.pnl_lista.Controls.Add(this.list_simulaciones);
            this.pnl_lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_lista.Location = new System.Drawing.Point(0, 0);
            this.pnl_lista.Name = "pnl_lista";
            this.pnl_lista.Size = new System.Drawing.Size(20, 567);
            this.pnl_lista.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resumen de simulaciones";
            // 
            // list_simulaciones
            // 
            this.list_simulaciones.FormattingEnabled = true;
            this.list_simulaciones.ItemHeight = 20;
            this.list_simulaciones.Location = new System.Drawing.Point(42, 97);
            this.list_simulaciones.Name = "list_simulaciones";
            this.list_simulaciones.Size = new System.Drawing.Size(975, 444);
            this.list_simulaciones.TabIndex = 0;
            // 
            // lbl_promSurtidas
            // 
            this.lbl_promSurtidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_promSurtidas.AutoSize = true;
            this.lbl_promSurtidas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_promSurtidas.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_promSurtidas.Location = new System.Drawing.Point(53, 525);
            this.lbl_promSurtidas.Name = "lbl_promSurtidas";
            this.lbl_promSurtidas.Size = new System.Drawing.Size(213, 27);
            this.lbl_promSurtidas.TabIndex = 1;
            this.lbl_promSurtidas.Text = "Promedio surtidas";
            // 
            // lbl_promVendidas
            // 
            this.lbl_promVendidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_promVendidas.AutoSize = true;
            this.lbl_promVendidas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_promVendidas.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_promVendidas.Location = new System.Drawing.Point(53, 481);
            this.lbl_promVendidas.Name = "lbl_promVendidas";
            this.lbl_promVendidas.Size = new System.Drawing.Size(235, 27);
            this.lbl_promVendidas.TabIndex = 1;
            this.lbl_promVendidas.Text = "Promedio vendidas";
            // 
            // lbl_promedioUtilidad
            // 
            this.lbl_promedioUtilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_promedioUtilidad.AutoSize = true;
            this.lbl_promedioUtilidad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_promedioUtilidad.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_promedioUtilidad.Location = new System.Drawing.Point(592, 481);
            this.lbl_promedioUtilidad.Name = "lbl_promedioUtilidad";
            this.lbl_promedioUtilidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_promedioUtilidad.Size = new System.Drawing.Size(216, 27);
            this.lbl_promedioUtilidad.TabIndex = 1;
            this.lbl_promedioUtilidad.Text = "Promedio utilidad";
            this.lbl_promedioUtilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ultimafila
            // 
            this.btn_ultimafila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ultimafila.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ultimafila.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_ultimafila.IconColor = System.Drawing.Color.DimGray;
            this.btn_ultimafila.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ultimafila.IconSize = 52;
            this.btn_ultimafila.Location = new System.Drawing.Point(638, 32);
            this.btn_ultimafila.Name = "btn_ultimafila";
            this.btn_ultimafila.Size = new System.Drawing.Size(141, 52);
            this.btn_ultimafila.TabIndex = 3;
            this.btn_ultimafila.Text = "Mostrar última fila";
            this.btn_ultimafila.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ultimafila.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ultimafila.UseVisualStyleBackColor = false;
            this.btn_ultimafila.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbl_promedioUtilidadPermiso
            // 
            this.lbl_promedioUtilidadPermiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_promedioUtilidadPermiso.AutoSize = true;
            this.lbl_promedioUtilidadPermiso.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_promedioUtilidadPermiso.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_promedioUtilidadPermiso.Location = new System.Drawing.Point(592, 525);
            this.lbl_promedioUtilidadPermiso.Name = "lbl_promedioUtilidadPermiso";
            this.lbl_promedioUtilidadPermiso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_promedioUtilidadPermiso.Size = new System.Drawing.Size(362, 27);
            this.lbl_promedioUtilidadPermiso.TabIndex = 1;
            this.lbl_promedioUtilidadPermiso.Text = "Promedio utilidad con permiso";
            this.lbl_promedioUtilidadPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_permisoPpal
            // 
            this.lbl_permisoPpal.AutoSize = true;
            this.lbl_permisoPpal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_permisoPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_permisoPpal.Location = new System.Drawing.Point(425, 80);
            this.lbl_permisoPpal.Name = "lbl_permisoPpal";
            this.lbl_permisoPpal.Size = new System.Drawing.Size(122, 16);
            this.lbl_permisoPpal.TabIndex = 1;
            this.lbl_permisoPpal.Text = "Costo de permiso";
            // 
            // lbl_prodPpal
            // 
            this.lbl_prodPpal.AutoSize = true;
            this.lbl_prodPpal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_prodPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_prodPpal.Location = new System.Drawing.Point(425, 12);
            this.lbl_prodPpal.Name = "lbl_prodPpal";
            this.lbl_prodPpal.Size = new System.Drawing.Size(81, 16);
            this.lbl_prodPpal.TabIndex = 1;
            this.lbl_prodPpal.Text = "Produccion";
            // 
            // lbl_rangoPpal
            // 
            this.lbl_rangoPpal.AutoSize = true;
            this.lbl_rangoPpal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rangoPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_rangoPpal.Location = new System.Drawing.Point(26, 64);
            this.lbl_rangoPpal.Name = "lbl_rangoPpal";
            this.lbl_rangoPpal.Size = new System.Drawing.Size(200, 27);
            this.lbl_rangoPpal.TabIndex = 1;
            this.lbl_rangoPpal.Text = "Rango mostrado";
            // 
            // lbl_costoPpal
            // 
            this.lbl_costoPpal.AutoSize = true;
            this.lbl_costoPpal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_costoPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_costoPpal.Location = new System.Drawing.Point(425, 29);
            this.lbl_costoPpal.Name = "lbl_costoPpal";
            this.lbl_costoPpal.Size = new System.Drawing.Size(99, 16);
            this.lbl_costoPpal.TabIndex = 1;
            this.lbl_costoPpal.Text = "Costo unitario";
            // 
            // lbl_cantPpal
            // 
            this.lbl_cantPpal.AutoSize = true;
            this.lbl_cantPpal.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_cantPpal.Location = new System.Drawing.Point(26, 20);
            this.lbl_cantPpal.Name = "lbl_cantPpal";
            this.lbl_cantPpal.Size = new System.Drawing.Size(179, 27);
            this.lbl_cantPpal.TabIndex = 1;
            this.lbl_cantPpal.Text = "Dias simulados";
            // 
            // lbl_precioPpal
            // 
            this.lbl_precioPpal.AutoSize = true;
            this.lbl_precioPpal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_precioPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_precioPpal.Location = new System.Drawing.Point(425, 46);
            this.lbl_precioPpal.Name = "lbl_precioPpal";
            this.lbl_precioPpal.Size = new System.Drawing.Size(109, 16);
            this.lbl_precioPpal.TabIndex = 1;
            this.lbl_precioPpal.Text = "Precio de venta";
            // 
            // lbl_multaPpal
            // 
            this.lbl_multaPpal.AutoSize = true;
            this.lbl_multaPpal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_multaPpal.ForeColor = System.Drawing.Color.White;
            this.lbl_multaPpal.Location = new System.Drawing.Point(425, 63);
            this.lbl_multaPpal.Name = "lbl_multaPpal";
            this.lbl_multaPpal.Size = new System.Drawing.Size(109, 16);
            this.lbl_multaPpal.TabIndex = 1;
            this.lbl_multaPpal.Text = "Costo de multa";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(830, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 84);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fernando Eber Alemán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ejercicio 12 - Final Simulación";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.grid.Location = new System.Drawing.Point(0, 113);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(1057, 352);
            this.grid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reloj (Días)";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RND Demanda";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Demanda";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prob. Multa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RND Multa";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Multa";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tortas vendidas";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vendidas AC";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tortas Surtidas";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Surtidas AC";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Utilidad";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Utilidad AC";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Permiso";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Utilidad con permiso";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Utilidad con permiso AC";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1105, 567);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_opcion);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Simulación venta de tortas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_opcion.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_lista.ResumeLayout(false);
            this.pnl_lista.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FontAwesome.Sharp.IconButton btn_menu;
        private Panel pnl_opcion;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private Panel pnl_menu;
        private Label lbl_dias;
        private Label lbl_prod;
        private TextBox txt_prod;
        private Label label1;
        private TextBox txt_hasta;
        private TextBox txt_desde;
        private TextBox txt_cant;
        private Label lbl_multa;
        private Label lbl_precio;
        private Label lbl_costo;
        private TextBox txt_multa;
        private TextBox txt_precio;
        private TextBox txt_costo;
        private Label lbl_permiso;
        private TextBox txt_permiso;
        private Panel panel2;
        private DataGridView grid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private FontAwesome.Sharp.IconButton btn_simular;
        private Label lbl_rangoPpal;
        private Label lbl_cantPpal;
        private Label lbl_multaPpal;
        private Label lbl_permisoPpal;
        private Label lbl_precioPpal;
        private Label lbl_costoPpal;
        private Label lbl_prodPpal;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label lbl_promSurtidas;
        private Label lbl_promVendidas;
        private Label lbl_promedioUtilidadPermiso;
        private Label lbl_promedioUtilidad;
        private FontAwesome.Sharp.IconButton btn_ultimafila;
        private FontAwesome.Sharp.IconButton btn_lista;
        private Panel pnl_lista;
        private ListBox list_simulaciones;
        private Label label4;
    }
}