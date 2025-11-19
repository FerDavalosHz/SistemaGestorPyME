using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorInventario
    {

        Base b = new Base("localhost", "root", "", "GestorPyme");



        public void MostrarHistorial(int idProducto, DataGridView tabla, string datos)
        {

              string consulta =
    "SELECT 'Entrada' AS tipo, cantidad_agregada AS cantidad, COALESCE(CAST(precio_compra AS CHAR), 'Descartado') AS precio, fecha_registro " +
    "FROM tbl_historial_entradas " +
    $"WHERE id_producto = {idProducto} " +
    "UNION ALL " +
    "SELECT 'Salida' AS tipo, cantidad, 'Descartado' AS precio, fecha_registro " +
    "FROM tbl_historial_salidas " +
    $"WHERE id_producto = {idProducto} " +
    "ORDER BY fecha_registro DESC";

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

          
            tabla.Columns["tipo"].HeaderText = "Tipo";
            tabla.Columns["cantidad"].HeaderText = "Cantidad";
            tabla.Columns["precio"].HeaderText = "Precio";
            tabla.Columns["fecha_registro"].HeaderText = "Fecha";

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }


        public void Mostrar(string filtro, DataGridView tabla, string datos)
        {
            string consulta =
                "SELECT " +
                "p.id_producto, " +
                "p.nombre AS nombre_producto, " +
                "c.nombre AS categoria, " +
                "COALESCE(ig.stock_actual, 0) AS stock_actual, " +
                "p.stock_minimo, " +
                "he.fecha_registro AS ultima_entrada " +
                "FROM tbl_productos p " +
                "INNER JOIN tbl_categorias c ON p.id_categoria = c.id_categoria " +
                "LEFT JOIN tbl_inventario_general ig ON p.id_producto = ig.id_producto " +
                "LEFT JOIN tbl_historial_entradas he " +
                "   ON he.id_producto = p.id_producto " +
                "   AND he.id_entrada = ( " +
                "       SELECT MAX(id_entrada) " +
                "       FROM tbl_historial_entradas " +
                "       WHERE id_producto = p.id_producto " +
                "   ) " +
                "WHERE p.activo = 1 " +
                $"AND (p.nombre LIKE '%{filtro}%' OR c.nombre LIKE '%{filtro}%') " +
                "ORDER BY p.nombre ASC";

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

        
            tabla.Columns["id_producto"].Visible = false;

         
            tabla.Columns.Add(Boton("Historial", Color.SteelBlue));
            tabla.Columns.Add(Boton("Actualizar", Color.OrangeRed));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void LlenarAlertas(ListBox lstAlertas)
        {
            lstAlertas.Items.Clear();

string consulta = "SELECT a.id_alerta, p.nombre AS producto, a.mensaje, a.fecha_creacion " +
                  "FROM tbl_alertas a " +
                  "INNER JOIN tbl_productos p ON p.id_producto = a.id_producto " +
                  "WHERE a.estado = 'no_leido' " +
                  "ORDER BY a.fecha_creacion ASC";

            DataTable dt = b.Consultar(consulta, "alertas").Tables[0];

            if (dt.Rows.Count == 0)
            {
                lstAlertas.Items.Add("==== No hay alertas nuevas ====");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                string fecha = Convert.ToDateTime(row["fecha_creacion"]).ToString("yyyy-MM-dd HH:mm");
                string producto = row["producto"].ToString().PadRight(25);
                string mensaje = row["mensaje"].ToString();

                // Formato ASCII básico: [fecha] | producto | mensaje
                string linea = $"[{fecha}] | {producto} | {mensaje}";
                lstAlertas.Items.Add(linea);
            }

}


        public void MarcarTodasLeidas()
        {
            string consulta = "UPDATE tbl_alertas SET estado='leido' WHERE estado='no_leido'";
            b.Comando(consulta);
        }


        public bool HayAlertasSinLeer()
        {
            string consulta = "SELECT COUNT(*) AS total FROM tbl_alertas WHERE estado = 'no_leido'";
            DataTable dt = b.Consultar(consulta, "alertas").Tables[0];

            if (dt.Rows.Count == 0)
                return false;

            int total = Convert.ToInt32(dt.Rows[0]["total"]);
            return total > 0;
        }

        private DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
        public void ReducirStock(int idProducto, int nuevaCantidad)
        {
         
            string consultaStock = $"SELECT stock_actual FROM tbl_inventario_general WHERE id_producto = {idProducto}";
            DataTable dt = b.Consultar(consultaStock, "inventario").Tables[0];

            if (dt.Rows.Count == 0)
                throw new Exception("Producto no encontrado en inventario.");

            int stockActual = Convert.ToInt32(dt.Rows[0]["stock_actual"]);

            if (nuevaCantidad >= stockActual)
                throw new Exception("La nueva cantidad debe ser menor al stock actual.");

            string actualizarInventario = $"UPDATE tbl_inventario_general SET stock_actual = {nuevaCantidad} WHERE id_producto = {idProducto}";
            b.Comando(actualizarInventario);
        }
    }
}
