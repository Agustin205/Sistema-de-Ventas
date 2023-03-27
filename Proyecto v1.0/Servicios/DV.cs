using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;

namespace Servicios
{
	public static class DV
	{
		static List<string> errores = new List<string>();
		static DVDao dao = new DVDao();

		public static bool verificarDVH(string tabla)
		{
			List<string> rows = dao.verificarDVH(tabla);

			if (rows.Count == 0)
			{
				return true;
			}

			return false;
		}

		public static bool verificarDV()
		{
			bool ok = true;

			foreach (string tabla in dao.obtenerTablas())
			{
				if (!dao.verificarDVV(tabla))
				{
					ok = false;
				}
				if (!verificarDVH(tabla))
				{
					ok = false;
				}
			}

			return ok;
		}

		public static string obtenerErrores()
		{
			var result = new System.Text.StringBuilder();
			foreach (string error in errores)
			{
				result.Append(error + "\n");
			}

			return result.ToString();
		}

		public static void actualizarDV()
		{
				try
				{
					DV.borrarErrores();

					foreach (string tabla in dao.obtenerTablas())
					{
						dao.actualizarDVH(tabla);
						dao.actualizarDVV(tabla);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
		}

		private static void borrarErrores()
		{
			errores.Clear();
		}
	}
}
