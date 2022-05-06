using Ejercicio_12.Controladores;
using System.Data;

namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        private bool menuOculto = true;
        private bool  listaOculta = true;
        private FilaController filaController;
        private string[] ultimaFila;
        private bool ultimaOculta = true;
        private int numSimulacion = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Ocultar Paneles
            pnl_menu.Width = 0;
            pnl_lista.Width = 0;

            //Iniciar nueva simulación
            filaController = new FilaController(Int32.Parse(txt_prod.Text), 
                Int32.Parse(txt_costo.Text), Int32.Parse(txt_precio.Text), Int32.Parse(txt_multa.Text), Int32.Parse(txt_permiso.Text));

            //Simular y cargar en en grilla
            cargarGrilla();

            //Editar labels
            cargarLabels();

            //Agregar resumen simulación a lista
            actualizarLista();
                     
        }

        private void cargarGrilla()
        {
            for (int i = 0; i <= Int32.Parse(txt_cant.Text); i++)
            {
                string[] fila = filaController.siguienteFila();
                
                //Cargar rango
                if(i >= Int32.Parse(txt_desde.Text) && i <= Int32.Parse(txt_hasta.Text))
                {
                    grid.Rows.Add(fila);
                }
                
                //Calcular y cargar promedios finales...
                if (i == Int32.Parse(txt_cant.Text))
                {
                    lbl_promVendidas.Text = "Promedio vendidas: " + filaController.calcularPromedioVendidas();
                    lbl_promSurtidas.Text = "Promedio surtidas: " + filaController.calcularPromedioSurtidas();
                    lbl_promedioUtilidad.Text = "Promedio utilidad: " + filaController.calcularPromedioUtilidad();
                    lbl_promedioUtilidadPermiso.Text = "Promedio utilidad con permiso: " + filaController.calcularPromedioUtilidadPermiso();

                    //Almacena la ultima fila simulada...
                    ultimaFila = fila;
                    numSimulacion++;                    
                }                

            }
        }

        private void cargarLabels()
        {
            lbl_cantPpal.Text = "Días simulados: " + txt_cant.Text;
            lbl_rangoPpal.Text = "Rango mostrado: " + txt_desde.Text + " - " + txt_hasta.Text;
            lbl_prodPpal.Text = "Produccion: " + txt_prod.Text;            
            lbl_costoPpal.Text = "Costo unitario: " + txt_costo.Text;
            lbl_precioPpal.Text = "Precio de venta: " + txt_precio.Text;
            lbl_multaPpal.Text = "Costo de multa: " + txt_multa.Text;
            lbl_permisoPpal.Text = "Costo permiso: " + txt_permiso.Text;
        }

        private void actualizarLista()
        {
            list_simulaciones.Items.Add("Simulacion: " + numSimulacion + " | Días: " + txt_cant.Text +  " | Prom vendidas: " + filaController.calcularPromedioVendidas() +
                " | Prom surtidas: " + filaController.calcularPromedioSurtidas() + " | Prom utilidad: " + filaController.calcularPromedioUtilidad() +
                " | Prom utilidad con permiso: " + filaController.calcularPromedioUtilidadPermiso() );
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (menuOculto) { pnl_menu.Width = 216; menuOculto = false; }
            else { pnl_menu.Width = 0; menuOculto = true; }            
        }

        public Form1()
        {            
            InitializeComponent();  
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //Limpiar grilla
            this.grid.Rows.Clear();

            //Iniciar nueva simulación
            filaController = new FilaController( Int32.Parse(txt_prod.Text),
                Int32.Parse(txt_costo.Text), Int32.Parse(txt_precio.Text), Int32.Parse(txt_multa.Text), Int32.Parse(txt_permiso.Text));

            //Simular y cargar en en grilla
            cargarGrilla();

            //Editar labels
            cargarLabels();

            //Agregar resumen simulación a lista
            actualizarLista();

            //Ocultar panel menu
            pnl_menu.Width = 0; menuOculto = true;          

        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //Ocultar panel menu
            pnl_menu.Width = 0; menuOculto = true;
            

            //Limpiar grilla
            this.grid.Rows.Clear();
            this.ultimaOculta = true;

            //Iniciar nueva simulación
            filaController = new FilaController(Int32.Parse(txt_prod.Text),
                Int32.Parse(txt_costo.Text), Int32.Parse(txt_precio.Text), Int32.Parse(txt_multa.Text), Int32.Parse(txt_permiso.Text));

            //Simular y cargar en en grilla
            cargarGrilla();

            //Editar labels
            cargarLabels();

            //Agregar resumen simulación a lista
            actualizarLista();

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

            if( txt_hasta.Text != txt_cant.Text && ultimaOculta)
            {
                this.grid.Rows.Add("...");
                this.grid.Rows.Add(ultimaFila);
                ultimaOculta = false;
            }

            grid.CurrentCell = grid.Rows[grid.RowCount - 2].Cells[0];
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            if (listaOculta) { pnl_lista.Width = 1057; listaOculta = false; }
            else { pnl_lista.Width = 0; listaOculta = true; }
        }
    }
}