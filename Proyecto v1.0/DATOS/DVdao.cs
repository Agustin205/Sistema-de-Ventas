using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
	public class DVDao : daoUsuario
	{

		public bool verificarDVV(string tabla)
		{
			string dvvCalculado = calcularDVV(tabla).GetHashCode().ToString();
			return dvvCalculado.Equals(obtenerDVV(tabla));
		}

		public string calcularDVV(string tabla)
		{
			string selectDVH = $"SELECT dvh FROM {tabla}";
			SqlCommand query = new SqlCommand(selectDVH, con);
			con.Open();
			SqlDataReader data = query.ExecuteReader();

			var dvhs = new System.Text.StringBuilder();
			while (data.Read())
			{
				dvhs.Append(data["dvh"]);
			}
			con.Close();

			return dvhs.ToString();
		}

		public string obtenerDVV(string tabla)
		{
			string selectDVV = $"SELECT dvv FROM dvv WHERE nombre_tabla = '{tabla}'";
			SqlCommand query = new SqlCommand(selectDVV, con);
			con.Open();
			SqlDataReader data = query.ExecuteReader();

			string dvv = "";
			while (data.Read())
			{
				dvv = data["dvv"].ToString();
			}
			con.Close();

			return dvv;
		}

		public List<string> verificarDVH(string tabla)
		{
			List<string> result = new List<string>();

			string selectDVH = $"SELECT * FROM {tabla}";
			SqlCommand query = new SqlCommand(selectDVH, con);
			con.Open();
			SqlDataReader data = query.ExecuteReader();

			var dvhs = new System.Text.StringBuilder();
			int row = 1;
			while (data.Read())
			{
				for (int i = 0; i < data.FieldCount; i++)
				{
					if (!data.GetName(i).Equals("dvh") && !isForeignKey(data.GetName(i)))
					{
						dvhs.Append(data.GetValue(i).GetHashCode().ToString());
					}
				}

				string dvhsCalculated = dvhs.ToString().GetHashCode().ToString();
				if (dvhsCalculated != data["dvh"].ToString())
				{
					result.Add(row.ToString());
				}
				row++;
				dvhs.Clear();
			}
			con.Close();

			return result;
		}

		public void actualizarDVV(string tabla)
		{
			try
			{
				if (con.State == ConnectionState.Open)
				{
					return;
				}

				string SQL = $"UPDATE Dvv SET dvv = '{calcularDVV(tabla).GetHashCode().ToString()}' WHERE nombre_tabla = '{tabla}'";
				con.Open();
				SqlCommand mCom = new SqlCommand(SQL, con);

				mCom.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{

			}
		}

		public void actualizarDVH(string tabla)
		{
			try
			{
				if (con.State == ConnectionState.Open)
				{
					return;
				}

				List<string> result = new List<string>();

				string selectDVH = $"SELECT * FROM {tabla}";
				SqlCommand selectQuery = new SqlCommand(selectDVH, con);
				con.Open();
				SqlDataReader data = selectQuery.ExecuteReader();

				var finalQuery = new System.Text.StringBuilder();
				var dvhs = new System.Text.StringBuilder();
				int row = 1;
				while (data.Read())
				{
					for (int i = 0; i < data.FieldCount; i++)
					{
						if (!data.GetName(i).Equals("dvh") && !isForeignKey(data.GetName(i)))
						{
							dvhs.Append(data.GetValue(i).GetHashCode().ToString());
						}
					}

					finalQuery.Append($"UPDATE {tabla} SET dvh = '{dvhs.ToString().GetHashCode().ToString()}' WHERE id = {data["id"].ToString()};");
					row++;
					dvhs.Clear();
				}
				con.Close();

				con.Open();
				SqlCommand updateQuery = new SqlCommand(finalQuery.ToString(), con);
				updateQuery.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception)
			{

			}
		}

		public List<string> obtenerTablas()
		{
			string selectDVV = "SELECT nombre_tabla FROM dvv";
			SqlCommand query = new SqlCommand(selectDVV, con);
			con.Open();
			SqlDataReader data = query.ExecuteReader();

			List<string> names = new List<string>();
			while (data.Read())
			{
				names.Add(data["nombre_tabla"].ToString());
			}
			con.Close();

			return names;
		}
	} 
}
