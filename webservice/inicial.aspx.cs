using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webservice
{
    public partial class inicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        List<string> Datos = new List<string>();
        List<string> Deducciones = new List<string>();
        List<string> Devengados = new List<string>();
        string SueldoTotal;
        int ValorSueldo;

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValorSueldo = Convert.ToInt32(LabelSueldo.Text);
            ServiceReference1.WebService1SoapClient Servicio1 = new ServiceReference1.WebService1SoapClient();
            Datos = Servicio1.CalculoSueldo(txtIdent.Text, Nombre.Text, Apellido.Text, DropDownListCargo.SelectedValue, Convert.ToInt32(LabelSueldo.Text),
                Convert.ToInt32(DropDownListDom.SelectedValue), Convert.ToInt32(fallas.Text), Convert.ToInt32(horasext.Text));
            id.Text = Datos[0];
            nomb.Text = Datos[1]; 
            carg.Text = Datos[2]; 
            sueldo.Text = Datos[3];
            dom.Text = Datos[4]; 
            he.Text = Datos[5];  
            TotDed.Text = Datos[6];
            st.Text = Datos[7];
            f.Text = Datos[8]; 
            p.Text = Datos[9]; 
            s.Text = Datos[10];
            TotDev.Text = Datos[11];
            qt.Text = Datos[12];
        }

        protected void DropDownListCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Cargo = DropDownListCargo.SelectedValue;
            switch (Cargo)
            {
                case "Asesor":
                    LabelSueldo.Text = "877900";
                    break;
                case "Mercaderista":
                    LabelSueldo.Text = "1100900";
                    break;
                case "Supervisor":
                    LabelSueldo.Text = "1609900";
                    break;
                case "Coordinador":
                    LabelSueldo.Text = "2100900";
                    break;

            }
        }
    }
}