using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorExcel
    {
      
            Base b = new Base("localhost", "root", "", "GestorPyme");

      
            public void ExportarReporteVentasACsv()
            {
                string consulta = @"
SELECT
      v.id_venta,
      v.fecha AS fecha_hora_venta,
      DATE(v.fecha) AS fecha_venta,
      TIME(v.fecha) AS hora_venta,
      v.total AS total_venta,
      v.metodo_pago,
      u.id_usuario,
      u.nombre AS nombre_vendedor,
      u.rango AS rango_vendedor,
      dv.id_detalle,
      dv.id_producto,
      p.nombre AS nombre_producto,
      c.nombre AS nombre_categoria,
      dv.cantidad AS cantidad_vendida,
      dv.precio_unitario AS precio_venta_unitario,
      (
          SELECT 
              he.precio_compra
          FROM 
              tbl_historial_entradas he
          WHERE 
              he.id_producto = dv.id_producto
          ORDER BY 
              he.fecha_registro DESC, he.id_entrada DESC
          LIMIT 1
      ) AS ultimo_precio_compra_unitario,
      dv.subtotal,
      p.precio_venta_actual AS precio_venta_actual_producto,
      -- Cálculo de la ganancia bruta por unidad: (Precio Venta Unitario - Último Precio Compra Unitario)
      (
          dv.precio_unitario - (
              SELECT 
                  he.precio_compra
              FROM 
                  tbl_historial_entradas he
              WHERE 
                  he.id_producto = dv.id_producto
              ORDER BY 
                  he.fecha_registro DESC, he.id_entrada DESC
              LIMIT 1
          )
      ) AS ganancia_unitaria_bruta,
      -- Cálculo de la ganancia bruta total por detalle de venta: (Ganancia Unitaria Bruta * Cantidad Vendida)
      (
          dv.cantidad * (
              dv.precio_unitario - (
                  SELECT 
                      he.precio_compra
                  FROM 
                      tbl_historial_entradas he
                  WHERE 
                      he.id_producto = dv.id_producto
                  ORDER BY 
                      he.fecha_registro DESC, he.id_entrada DESC
                  LIMIT 1
              )
          )
      ) AS ganancia_total_bruta
FROM
      tbl_ventas v
JOIN
      tbl_usuarios u ON v.id_usuario = u.id_usuario
JOIN
      tbl_detalle_venta dv ON v.id_venta = dv.id_venta
JOIN
      tbl_productos p ON dv.id_producto = p.id_producto
JOIN
      tbl_categorias c ON p.id_categoria = c.id_categoria
ORDER BY
      v.fecha, v.id_venta;
            ";

                try
                {
                    DataSet ds = b.Consultar(consulta, "ReporteVentas");
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron datos de ventas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Archivos CSV (*.csv)|*.csv";
                        sfd.Title = "Guardar Reporte de Ventas en CSV";
                        sfd.FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string rutaArchivo = sfd.FileName;

                         
                            ExportarDataTableACsv(dt, rutaArchivo);

                            MessageBox.Show($"Reporte de Ventas exportado con éxito en:\n{rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Exportación cancelada por el usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el reporte o exportar a CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        
            private void ExportarDataTableACsv(DataTable dt, string rutaArchivo)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(rutaArchivo, false, System.Text.Encoding.UTF8))
                    {
                        
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sw.Write(dt.Columns[i].ColumnName);
                            if (i < dt.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine(); 

                        // Escribir los datos de cada fila
                        foreach (DataRow dr in dt.Rows)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                          
                                string valor = dr[i].ToString();
                              
                                valor = valor.Replace("\"", "\"\"");
                                if (valor.Contains(","))
                                {
                                    valor = $"\"{valor}\"";
                                }

                                sw.Write(valor);
                                if (i < dt.Columns.Count - 1)
                                {
                                    sw.Write(","); 
                                }
                            }
                            sw.WriteLine(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    throw new Exception("Error al escribir los datos en el archivo CSV: " + ex.Message);
                }
            }
        }
    }

