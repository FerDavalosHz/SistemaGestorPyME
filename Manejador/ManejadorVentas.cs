using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorVentas
    {


        Base b = new Base("localhost", "root", "", "GestorPyme");
        public void Mostrar(string producto, DataGridView tabla, string datos)
        {

            string consulta =
            "SELECT " +
            "p.id_producto, " +
            "l.id_lote, " +
            "p.nombre AS NombreProducto, " +
            "cat.nombre AS Categoria, " +
            "l.codigo_lote, " +
            "p.precio_venta_actual, " +
            "l.cantidad_disponible AS Stock, " +
            "l.fecha_vencimiento " +
            "FROM tbl_productos p " +
            "INNER JOIN tbl_categorias cat ON p.id_categoria = cat.id_categoria " +
            "INNER JOIN tbl_lotes l ON p.id_producto = l.id_producto " +
            "INNER JOIN ( " +
            "   SELECT id_producto, MAX(fecha_vencimiento) AS fecha_vencimiento_reciente " +
            "   FROM tbl_lotes " +
            "   WHERE fecha_vencimiento > CURDATE() " + 
            "   GROUP BY id_producto " +
            ") AS ultimos_vencidos ON l.id_producto = ultimos_vencidos.id_producto " +
            "AND l.fecha_vencimiento = ultimos_vencidos.fecha_vencimiento_reciente " +
            $"WHERE p.activo = 1 AND p.nombre LIKE '%{producto}%' OR cat.nombre LIKE '%{producto}%' " +
            "ORDER BY l.fecha_vencimiento ASC;";

            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];

            tabla.Columns["id_producto"].Visible = false;
            tabla.Columns["id_lote"].Visible = false;
            tabla.Columns["codigo_lote"].Visible = false;
            tabla.Columns["Stock"].Visible = false;



            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }


    }
}
